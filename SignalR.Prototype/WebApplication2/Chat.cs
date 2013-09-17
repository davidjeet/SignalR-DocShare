using SignalR.Hubs;

public class Chat : Hub
{
    public void Send(string message)
    {
        // Call the addMessage method on all clients
        //Clients.addMessage(message);

        // Invoke a method on the calling client
        Caller.addMessage(message);

        // Similar to above, the more verbose way
        Clients[Context.ClientId].addMessage(message);
    }
}

public class statusChanges : Hub
{
    public void ServerChange()
    {
        Clients.serverChange();
    }
}