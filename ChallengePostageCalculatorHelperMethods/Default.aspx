<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="ChallengePostageCalculatorHelperMethods.Default" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
    
        Postal Calculator<br />
        <br />
    
    </div>
        Width:&nbsp;
        <asp:TextBox ID="widthInput" runat="server" OnTextChanged="text_TextChanged" AutoPostBack="True"></asp:TextBox>
        <br />
        Height:&nbsp; <asp:TextBox ID="heightInput" runat="server" OnTextChanged="text_TextChanged" AutoPostBack="True" TabIndex="1"></asp:TextBox>
        <br />
        Length:
        <asp:TextBox ID="lengthInput" runat="server" OnTextChanged="text_TextChanged" AutoPostBack="True" TabIndex="2"></asp:TextBox>
        <br />
        <br />
        <asp:RadioButton ID="shippingGroundRadioButton" runat="server" AutoPostBack="True" GroupName="ShippingType" OnCheckedChanged="radioButton_CheckedChanged" Text="Ground" />
        <br />
        <asp:RadioButton ID="shippingAirRadioButton" runat="server" AutoPostBack="True" GroupName="ShippingType" OnCheckedChanged="radioButton_CheckedChanged" Text="Air" />
        <br />
        <asp:RadioButton ID="shippingNextDayRadioButton" runat="server" AutoPostBack="True" GroupName="ShippingType" OnCheckedChanged="radioButton_CheckedChanged" Text="Next Day" />
        <br />
        <br />
        <asp:Label ID="result" runat="server"></asp:Label>
    </form>
    <p>
        &nbsp;</p>
</body>
</html>
