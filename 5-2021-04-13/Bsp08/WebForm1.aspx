<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Bsp08.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:TextBox ID="txtZahl1" runat="server" Width="108px">0</asp:TextBox>
            <asp:TextBox ID="txtZahl2" runat="server">0</asp:TextBox>
        </div>
        <p>
            <asp:Button ID="btnAddieren" runat="server" Text="+" Width="72px" OnClick="btnAddieren_Click" />
            <asp:Button ID="btnSubtrahieren" runat="server" Text="-" Width="69px" />
            <asp:Button ID="btnMultiplizieren" runat="server" Text="*" Width="70px" />
            <asp:Button ID="btnDividieren" runat="server" Text="/" Width="69px" />
            </p>
        <p>
            <asp:TextBox ID="txtErgebnis" runat="server" Width="268px"></asp:TextBox>
            </p>
    </form>
</body>
</html>
