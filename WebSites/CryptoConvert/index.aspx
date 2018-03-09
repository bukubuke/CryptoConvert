
<%@ Page Language="C#" AutoEventWireup="true" CodeFile="index.aspx.cs" Inherits="index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Crypto Converter</title>
    <link rel="stylesheet" href="CSS.css" />
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400" rel="stylesheet" type="text/css"/>
</head>
<body>
    <form id="form1" runat="server">
    <div class="top">
<a>Crypto Converter</a>
        <asp:Label ID="lblCurrency1" runat="server"></asp:Label>
        <a> to </a> 
        <asp:Label ID="lblCurrency2" runat="server"></asp:Label>
    </div>
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
        <br />
    <div class="mid">
        <asp:DropDownList ID="dropdowncurrency1" runat="server">
        </asp:DropDownList>
        <asp:TextBox ID="txtBoxCurrency1" runat="server"></asp:TextBox>
        <a class="">=</a>
        <asp:TextBox ID="txtBoxCurrency2" runat="server"></asp:TextBox>
        <asp:DropDownList ID="dropdowncurrency2" runat="server">
        </asp:DropDownList>
        </div>
        </form>
</body>
</html>
