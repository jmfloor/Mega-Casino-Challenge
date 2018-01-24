<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="MegaCasinoChallenge.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>
            <asp:Image ID="reelOneImage" runat="server" Height="100px" Width="100px" />
            <asp:Image ID="reelTwoImage" runat="server" Height="100px" Width="100px" />
            <asp:Image ID="reelThreeImage" runat="server" Height="100px" Width="100px" />
        </div>
        <p>
            Your Bet:
            <asp:TextBox ID="betTextBox" runat="server"></asp:TextBox>
        </p>
        <p>
            <asp:Button ID="leverButton" runat="server" Text="Pull the Lever" />
        </p>
        <p>
            <asp:Label ID="Label1" runat="server" Text="Label"></asp:Label>
        </p>
        <p>
            <asp:Label ID="Label2" runat="server" Text="Label"></asp:Label>
        </p>
        <div>
            1 Cherry - x2 your bet<br />
            2 Cherries - x3 your bet<br />
            3 Cherries - x4 your bet<br />
            3 7&#39;s - Jackpot - x100 your bet<br />
            However, if there is even ONE BAR, then you win nothing</div>
        <p>
            &nbsp;</p>
        <p>
            &nbsp;</p>
    </form>
</body>
</html>
