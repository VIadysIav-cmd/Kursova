using ServerSupplierNodes;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

var receivedItems = new List<GoodsItem>();
const string Ip = "192.168.0.143";  // IP сервера
const int workerPort = 5000;
const int adminPort = 5001;


var adminListener = new TcpListener(IPAddress.Parse(Ip), adminPort);

var workerListener = new TcpListener(IPAddress.Parse(Ip), workerPort);
workerListener.Start();
adminListener.Start();

Console.WriteLine("🟢 Сервер запущен на порту 5000 (для работников)\n");
Console.WriteLine("🟢 Сервер запущен на порту 5001 (для админа)");

Task.Run(() =>
{
    while (true)
    {
        var adminClient = adminListener.AcceptTcpClient();
        Task.Run(() => HandleAdminClient(adminClient));
    }
});


while (true)
{
    var client = workerListener.AcceptTcpClient();
    Task.Run(() => HandleWorkerClient(client));
}

void HandleWorkerClient(TcpClient client)
{
    try
    {
        Console.WriteLine("📥 Подключился работник");
        using var stream = client.GetStream();
        using var reader = new StreamReader(stream, Encoding.UTF8);
        string json = reader.ReadToEnd();

        if (string.IsNullOrWhiteSpace(json))
        {
            Console.WriteLine("⚠️ Пустое сообщение от работника");
            return;
        }

        var items = JsonSerializer.Deserialize<List<GoodsItem>>(json);
        if (items != null)
        {
            lock (receivedItems)
            {
                receivedItems.AddRange(items);
            }

            Console.WriteLine($"✅ Принято от работника: {items.Count} товаров");
            foreach (var item in items)
                Console.WriteLine($"- Поставщик: {item.Supplier}, Название: {item.Name}, Кол-во: {item.Quantity}");

        }
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Ошибка при приеме от работника: {ex.Message}");
    }
}

void HandleAdminClient(TcpClient client)
{
    try
    {
        Console.WriteLine("📥 Подключился админ");
        using var stream = client.GetStream();
        using var writer = new StreamWriter(stream, Encoding.UTF8) { AutoFlush = true };

        List<GoodsItem> itemsToSend;
        lock (receivedItems)
        {
            itemsToSend = receivedItems.ToList();
            receivedItems.Clear();
        }

        string jsonToSend = JsonSerializer.Serialize(itemsToSend);
        writer.Write(jsonToSend);

        writer.Flush();
        client.GetStream().Close(); // Закрываем поток, чтобы клиент завершил чтение
        client.Close();
        Console.WriteLine($"📤 Отправлено админу: {itemsToSend.Count} товаров");
    }
    catch (Exception ex)
    {
        Console.WriteLine($"❌ Ошибка при отправке админу: {ex.Message}");
    }
    finally
    {
        client.Close();
    }
}
