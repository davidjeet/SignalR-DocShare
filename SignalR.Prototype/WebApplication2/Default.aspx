<%@ Page Language="C#" ClientIDMode="Static" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication2.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>

<script src="Scripts/jquery-1.6.4.min.js" type="text/javascript"></script>
<script src="Scripts/jquery.signalR.min.js" type="text/javascript"></script>
<script src="signalr/hubs" type="text/javascript"></script>

</head>

<body>
    <form id="form1" runat="server">
    <input type="text" id="msg" />
    <input type="button" id="broadcast" value="broadcast" />
    <ul id="messages">
    </ul>
    </form>

</body>

<script type="text/javascript">
    $(function () {

        // Proxy created on the fly
        var chat = $.connection.chat;

        // Declare a function on the chat hub so the server can invoke it
        chat.addMessage = function (message) {
            $('#messages').append('<li>' + message + '</li>');
        };

        $("#broadcast").click(function () {

            // Call the chat method on the server
            chat.send($('#msg').val())
            .done(function () {
                console.log('Success!')
            })
            .fail(function (e) {
                console.warn(e);
            })
        });

        // Start the connection
        $.connection.hub.start();
    });
</script>

<script type="text/javascript">
    $(function () {
        var statusChange = $.connection.statusChanges;
        statusChange.serverChange = function () {
            alert(8);
        };
        $.connection.hub.start();
    });
</script>

</html>
