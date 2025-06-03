using System.Net.Sockets;
using System.Text;
using System.Text.Json;
using System.ComponentModel;


namespace AdminService.Models
{
    public class GoodsReceiverService
    {
        private readonly string _serverIp;
        private readonly int _serverPort;

        public GoodsReceiverService(string serverIp, int serverPort)
        {
            _serverIp = serverIp;
            _serverPort = serverPort;
        }

        /// <summary>
        /// Подключается к серверу, получает данные и обновляет BindingList на UI.
        /// </summary>
        public async Task FetchGoodsAsync(BindingList<GoodsItem> bindingList, Form uiForm)
        {
            try
            {
                using var client = new TcpClient();
                await client.ConnectAsync(_serverIp, _serverPort);

                using var stream = client.GetStream();
                using var reader = new StreamReader(stream, Encoding.UTF8);

                // Читаем весь JSON, который пришлёт сервер
                string json = await reader.ReadToEndAsync();

                if (!string.IsNullOrWhiteSpace(json))
                {
                    var goods = JsonSerializer.Deserialize<List<GoodsItem>>(json);
                    if (goods != null)
                    {
                        // Обновляем UI через invoke, чтобы избежать проблем с потоками
                        uiForm.Invoke(() =>
                        {
                            foreach (var item in goods)
                            {
                                bindingList.Add(item);
                            }
                        });
                    }
                }
                else
                {
                    MessageBox.Show("Данные отсутствуют", "Ответ от сервера", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (SocketException)
            {
                MessageBox.Show("Не удалось подключиться к серверу. Проверьте, запущен ли он и доступен ли IP/порт.",
                                "Ошибка подключения", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка при подключении к серверу: {ex.Message}");
            }
        }
    }
}

