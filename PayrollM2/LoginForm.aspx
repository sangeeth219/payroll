<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="LoginForm.aspx.cs" Inherits="PayrollM2.LoginForm" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server" >
    <div >
    
    <asp:Panel ID="TitlePanel" runat="server" BackColor="BlueViolet" Height="29px" 
        style="top: 121px; left: 436px; position: absolute; width: 266px;">
        <asp:Label ID="lblTitle" runat="server" Text="Login" 
            Style="position:absolute;left:107px; top:6px;" CssClass="mylabel" 
            Font-Bold="True" Font-Size="15px" ForeColor="White"></asp:Label>
    </asp:Panel>

    <asp:Panel ID="LoginPanel" runat="server" BackColor="lightyellow"  
                style="top: 153px; left: 437px; position: absolute; height: 116px; z-index: -1; width: 264px;">
        <asp:Label ID="lblPassword" runat="server" Text="Password:" 
            Style="position:absolute;left:22px; top:50px; z-index: 1;" CssClass="mylabel" 
            Font-Bold="True" ForeColor="Red"></asp:Label>
        <asp:TextBox ID="txtPassword" runat="server" 
            Style="position:absolute;left:98px; top:47px; width: 139px;" 
            CssClass="mytextbox" TextMode="Password" TabIndex="30"></asp:TextBox>
        <asp:Label ID="lblUserName" runat="server" Text="User Name:" 
            Style="position:absolute;left:8px; top:21px; z-index: 1; width: 83px;" CssClass="mylabel" 
            Font-Bold="True" ForeColor="Red"></asp:Label>
        <br />
        <asp:TextBox ID="txtUserName" runat="server" 
            Style="position:absolute;left:98px; top:17px; width: 138px;" 
            CssClass="mytextbox" TabIndex="20"></asp:TextBox>
        <asp:Button ID="btnSubmit" runat="server" Text="Submit" 
            Style="position:absolute;left:176px; top:83px;" BorderStyle="Ridge" 
            BorderWidth="0px" CssClass="mytextbox" Font-Bold="True" TabIndex="50" 
            BackColor="#336600" ForeColor="Yellow" onclick="btnSubmit_Click"/>
    </asp:Panel>
        <asp:Image ID="Image1" runat="server" ImageAlign="Middle" ImageUrl="~/images/projecttitle.JPG" style="margin-left: 346px" />

    &nbsp;</div>
    <asp:Label ID="lblError" runat="server" CssClass="mylabel" 
        Style="position:absolute;top:290px; left:550px;" Font-Bold="True" 
        ForeColor="Red">
        </asp:Label>

    </form>
</body>
</html>
