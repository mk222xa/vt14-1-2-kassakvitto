<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="_1DV406L1._2.Default" ViewStateMode="Disabled"%>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:Label ID="Label1" runat="server" Text="Kassakvitto"></asp:Label>
        <asp:TextBox ID="UserInputTextBox" runat="server" TextMode="SingleLine"></asp:TextBox>
        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ErrorMessage="Fältet måste fyllas i" ControlToValidate="UserInputTextBox">            
        </asp:RequiredFieldValidator>
        <asp:CompareValidator ID="CompareValidator1" runat="server" ErrorMessage="Summan måste vara större än 0" ControlToValidate="UserInputTextBox" Operator="GreaterThanEqual" ValueToCompare="0" Type="Double"></asp:CompareValidator>
        
        <asp:Button ID="SendButton" runat="server" Text="Beräkna rabatt" OnClick="SendButton_Click" />

        <asp:Label ID="Subtotal" runat="server" Text="Label" Visible="false"></asp:Label>
        <asp:Label ID="DiscountRate" runat="server" Text="Label" Visible="false"></asp:Label>
        <asp:Label ID="MoneyOff" runat="server" Text="Label" Visible="false"></asp:Label>
        <asp:Label ID="Total" runat="server" Text="Label" Visible="false"></asp:Label>
    </div>
    </form>
</body>
</html>
