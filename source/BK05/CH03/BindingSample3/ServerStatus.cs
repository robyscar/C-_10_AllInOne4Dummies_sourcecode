namespace BindingSample3
{
    public class ServerStatus
    {
        public string ServerName { get; set; }
        public bool IsServerUp { get; set; }
        public int NumberOfConnectedUsers { get; set; }

        public ServerStatus() { }
    }
}
