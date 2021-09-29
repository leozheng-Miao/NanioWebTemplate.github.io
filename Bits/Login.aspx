<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="Bits.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
    <link type="text/css" rel="stylesheet" href="BITs.css"/>
</head>
     <body background="Background.png">
            <form id="form1" runat="server" class="box"  method="post">
          <div class="head">
            <div class="left">
                WE
            </div>
            <div class="middle">
                    <ul>
                        <li><a href="#">Latest news</a></li>
                        <li><a href="#">Articles</a></li>
                        <li><a href="#">Donation</a></li>
                        <li><a href="#">Relevance game</a></li>

                    </ul>
            </div>
            <div class="right">
                    <ul class="parent">
                        <li>
                            <a href="Sign.aspx">Sign up</a>
                        </li>
                        <li>
                            <a href="Login.aspx" style="color: #a1c18c;">Log in</a>
                        </li>
                    </ul>
            </div>
            <div class="search">
                <a href="#"><img src="icon.png" style="width: 70px; height: 70px;"></a>
            </div>
        </div>
        <div class="log" >
            <div class="font">
                LOG IN WITH
            </div>
            <div class="icon" style="margin:5px auto; text-align: center;cursor: pointer">
                <img src="ways.png">
            </div>
            <div class="font2">
                <div style="border: 0.5px solid #CCC; width: 120px; margin-left: 90px;float: left;margin-top: 10px;"></div>
                <div style="float: left; padding-left: 20px; margin-bottom: 30px;">or</div>
                <div style="border: 0.5px solid #CCC; width: 115px; margin-left: 20px;float: left;margin-top: 10px;"></div>
            </div>
            <div class="input">
                <ul>
                    <li>Your UserName</li>
                    <li><asp:TextBox ID="txtName" runat="server" CssClass="txtNum" value="Write your UserName"></asp:TextBox></li>
                    <li>Password</li>
                    <li><asp:TextBox ID="txtPwd" runat="server" CssClass="txtPwd"></asp:TextBox></li>
                </ul>
            </div>
            <div class="font4">
                <a href="#">Forgot your password?</a>
            </div>
             <asp:Button ID="btnLogin" CssClass="btnLogin" runat="server" Text="Go Inside!" OnClick="btnLogin_Click"/>
             <div style="margin-left: 100px;margin-top: 5px;"><font style="color: yellowgreen;font-size: 12px;">Do you need an account? </font> <a href="Sign.aspx"><font style="font-size: 12px;color: white;">Create new account</font></a></div>
        </div>
    </form>
</body>
    
</html>
