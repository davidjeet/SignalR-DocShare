<%@ Page Language="C#" ClientIDMode="Static" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication1.Default" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="Scripts/jquery-1.6.4.min.js" type="text/javascript"></script>
    <script src="Scripts/jquery.signalR.min.js" type="text/javascript"></script>
        <script type="text/javascript">
            $(function () {
                var connection = $.connection('echo');

                connection.received(function (data) {
                    $('#messages').append('<li>' + data + '</li>');
                });

                connection.start();

                $("#broadcast").click(function () {
                    connection.send($('#msg').val());
                });
            });
    </script>
</head>
<body>
    <form id="form1" runat="server">

    <input type="text" id="msg" />
    <input type="button" id="broadcast" />
    <ul id="messages">
    </ul>
    </form>
</body>
</html>
