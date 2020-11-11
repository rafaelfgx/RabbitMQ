namespace RabbitMQ
{
    public sealed class Connection
    {
        public Connection
        (
            string hostName,
            int port,
            string userName,
            string password
        )
        {
            HostName = hostName;
            Port = port;
            UserName = userName;
            Password = password;
        }

        public string HostName { get; }

        public int Port { get; }

        public string UserName { get; }

        public string Password { get; }
    }
}
