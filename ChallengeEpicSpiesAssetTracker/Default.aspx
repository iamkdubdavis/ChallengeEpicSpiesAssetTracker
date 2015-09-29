<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengeEpicSpiesAssetTracker.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            font-family: Arial, Helvetica, sans-serif;
        }
    </style>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        <asp:Image ID="logoImage" runat="server" Height="190px" ImageUrl="~/epic-spies-logo.jpg" />
        <br />
        <h1 class="auto-style1">Asset Performance Tracker</h1>
        Asset Name:
        <asp:TextBox ID="assetTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Elections Rigged:
        <asp:TextBox ID="electionsTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        Acts of Subterfuge Performed:
        <asp:TextBox ID="subTextBox" runat="server"></asp:TextBox>
        <br />
        <br />
        <asp:Button ID="okButton" runat="server" OnClick="okButton_Click" Text="Add Asset" />
        <br />
        <br />
        <asp:Label ID="resultLabel" runat="server"></asp:Label>
    
    </div>
    </form>
</body>
</html>
