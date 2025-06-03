using CatalogService.Interfaces;
using CatalogService.Models;
using System.Net.Sockets;
using System.Text;
using System.Text.Json;

namespace CatalogService.Services
{
    public class NetworkGoodsSender : IGoodsSender
    {
        private readonly string _serverIp;
        private readonly int _port;

        public NetworkGoodsSender(string serverIp, int port)
        {
            _serverIp = serverIp;
            _port = port;
        }

        public void SendGoods(IEnumerable<GoodsItem> items)
        {
            var json = JsonSerializer.Serialize(items);

            using (var client = new TcpClient())
            {
                client.ReceiveTimeout = 5000;
                client.SendTimeout = 5000;


                client.Connect(_serverIp, _port);
                using (var stream = client.GetStream())
                {
                    var data = Encoding.UTF8.GetBytes(json);
                    stream.Write(data, 0, data.Length);
                }
            }
        }
    }
}
