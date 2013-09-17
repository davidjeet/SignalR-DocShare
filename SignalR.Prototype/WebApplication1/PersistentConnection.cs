using System.Threading.Tasks;
using SignalR;

public class MyConnection : PersistentConnection
{
    protected override Task OnReceivedAsync(string clientId, string data)
    {
        // Broadcast data to all clients
        return Connection.Broadcast(data);
    }
}