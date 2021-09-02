using System;
using System.Configuration;
using System.IO;
using System.Net.Sockets;
using System.Threading.Tasks;

namespace DemoProtocol.Connection
{
    /// <summary>
    /// Service for subscribing and notifying <paramref name="SettingParametersRecord"/>s about <paramref name="ModelTime"/>.
    /// </summary>
    public static class Connection
    {
        // Contains Tcp connection
        private static TcpClient client;

        // Contains stream of client
        private static Stream stream;

        /// <summary>
        /// Contains ip adresss of server
        /// </summary>
        public static readonly string Ip;

        /// <summary>
        /// Contains port of server
        /// </summary>
        public static readonly int Port;

        // Get Ip and Port from App.config 
        static Connection()
        {
            Ip = ConfigurationManager.AppSettings["ip"];
            Port = int.Parse(ConfigurationManager.AppSettings["port"]);

            _ = Initialize();
        }

        // initialize TcpClient and connects asynchronously to the server
        private static async Task Initialize()
        {
            client = new TcpClient();

            while (!client.Connected)
            {
                await client.ConnectAsync(Ip, Port);
            }
        }

        /// <summary>
        /// Asynchronously send message to the server
        /// </summary>
        /// <param name="message">Array of bytes for sending</param>
        public static async Task SendMessage(byte[] message)
        {
            stream = client.GetStream();
            await stream.WriteAsync(message);
        }

        /// <summary>
        /// Close connection.
        /// </summary>
        public static void EndSession()
        {
            stream.Close();
        }
    }
}
