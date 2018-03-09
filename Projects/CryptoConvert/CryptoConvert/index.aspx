<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="index.aspx.cs" Inherits="CryptoConvert.index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head id="Head1" runat="server">
    <title>Crypto Converter</title>
    <link rel="stylesheet" href="CSS.css" />
    <link href="https://fonts.googleapis.com/css?family=Lato:300,400" rel="stylesheet" type="text/css"/>
	<style type="text/css">
		.auto-style1 {
			border-style: none;
			border-color: inherit;
			border-width: medium;
            font-family: 'Lato';
			font-size: 30px;
			width: 300px;
			height: 52px;
			position: relative;
			overflow: hidden;
			border-radius: 3px;
			background-color: #FAF9F4;
			box-shadow: 0 0 0.25em 0 rgba(0,0,0,.125);
			left: 0px;
			top: 0px;
		}
		.auto-style2 {
			background: center;
			position: relative;
			left: -1px;
			top: 102px;
		}
		.auto-style3 {
			border-style: none;
			border-color: inherit;
			border-width: medium;
			font-family: 'Lato';
			font-size: 30px;
			width: 300px;
			height: 50px;
			position: relative;
			overflow: hidden;
			border-radius: 3px;
			background-color: #FAF9F4;
			box-shadow: 0 0 0.25em 0 rgba(0,0,0,.125);
			left: 0px;
			top: 1px;
		}
		.darkmode{
			margin-top: 5px;
			position:absolute;
			padding: 10px 20px;
			overflow:hidden;
			font-family:inherit;
			background-color: #FAF9F4;
			border-style:none;
			box-shadow: 0 0 0.25em 0 rgba(0,0,0,.125)
		}
		.lightmode{
			margin-top: 5px;
			position:absolute;
			padding: 10px 20px;
			overflow:hidden;
			font-family:inherit;
			background-color: #FAF9F4;
			border-style:none;
		}
		.auto-style4 {
			margin-top: 5px;
			position: relative;
			float: right;
			padding: 10px 20px;
			overflow: hidden;
			font-family: inherit;
			background-color: #FAF9F4;
			border-style: none;
			box-shadow: 0 0 0.25em 0 rgba(0,0,0,.125);
			left: -13px;
			top: -34px;
		}
		.auto-style5 {
			margin-top: 5px;
			position: relative;
			float: right;
			padding: 10px 20px;
			overflow: hidden;
			font-family: inherit;
			color: #FAF9F4;
			background-color: #303030;
			border-style: none;
			box-shadow: 0 0 0.25em 0 rgb(255, 255, 255);
			left: -12px;
			top: -34px;
		}
	</style>
</head>
<body id="main" runat="server">
    <form id="form1" runat="server" method="post" autocomplete="off">
    <div class="top" id="top" runat="server">
<div class="toptext"><a>Crypto Converter</a>
        <asp:Label ID="lblCurrency1" runat="server"></asp:Label>
        <a> to </a> 
        <asp:Label ID="lblCurrency2" runat="server"></asp:Label></div>
		<asp:Button ID="DarkMode" runat="server" Text="Dark Mode" OnClick="DarkMode_Click" CssClass="auto-style4" /><asp:Button ID="LightMode" runat="server" Text="Light Mode" OnClick="LightMode_Click" CssClass="auto-style5"></asp:Button>
    </div>
        <br />
        <br />
        <center><asp:Image ID="bitcoinimage" runat="server" ImageUrl="~/bitcoin.png" Height="128px" />
        <asp:Image ID="whitebitcoin" runat="server" ImageUrl="~/bitcoin white.png" /></center>
        <br />
        <br />
    <div class="mid" runat="server" id="mid">
		<div class ="auto-style2">
        <asp:DropDownList ID="currency1" runat="server" CssClass="dropdownlist" OnSelectedIndexChanged="currency1_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>Bitcoin (BTC)</asp:ListItem>
            <asp:ListItem>Ethereum (ETH)</asp:ListItem>
            <asp:ListItem>Bitcoin Cash (BCH)</asp:ListItem>
            <asp:ListItem>DogeCoin (XDG)</asp:ListItem>
        </asp:DropDownList>
        <asp:TextBox ID="txtBoxCurrency1"  cssclass="auto-style1" runat="server" OnTextChanged="txtBoxCurrency1_TextChanged" AutoPostBack="true"></asp:TextBox>
        &nbsp;<a class="">=</a>&nbsp;
        <asp:TextBox ID="txtBoxCurrency2" CssClass="auto-style3" runat="server" OnTextChanged="txtBoxCurrency2_TextChanged" AutoPostBack="true"></asp:TextBox>
        <asp:DropDownList ID="currency2" runat="server" CssClass="dropdownlist" OnSelectedIndexChanged="currency2_SelectedIndexChanged" AutoPostBack="true">
            <asp:ListItem>US Dollars (USD)</asp:ListItem>
            <asp:ListItem>SG Dollars (SGD)</asp:ListItem>
            <asp:ListItem>European Union (EURO)</asp:ListItem>
            <asp:ListItem>Japanese Yen (JPY)</asp:ListItem>
        </asp:DropDownList>
        <br />
            <asp:Label ID="lblvalidation" runat="server" CssClass="text" Visible="False"></asp:Label>
        <br />
        <br />
			</div>
        </div>
        <div class="footer" id ="footer" runat="server">
            <center><a class="description" id="A1" runat="server"> This is a cryptocurrency converter, a cryptocurrency is digital currency in which encryption techniques are used to regulate the generation of units of currency and verify the transfer of funds, operating independently of a central bank.
         <br />This website converts cryptocurrencies such as bitcoins to real world currencies.</a></center> <br />
            <a href="http://kennyng.me">made by kennyng</a>
        </div>
        </form>
</body>
</html>