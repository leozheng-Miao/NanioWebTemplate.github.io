<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Sign.aspx.cs" Inherits="Bits.Sign" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
<meta http-equiv="Content-Type" content="text/html; charset=utf-8"/>
    <title></title>
      <link type="text/css" rel="stylesheet" href="Sign.css"/>
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
                <a href="Sign.aspx" style="color: #a1c18c;">Sign up</a>
              </li>
              <li class="current">
                <a href="Login.aspx">Log in</a>
              </li>
              </ul>
          </div>
          <div class="search">
            <a href="#"><img src="icon.png" style="width: 70px; height: 70px;"></a>
          </div>
        </div>
        <div class="log" >
          <div class="font">
            SIGN UP WITH
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
              <li><asp:TextBox ID="txtName2" runat="server" CssClass="txtNum" value="Write your UserName"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtName2" ErrorMessage="*UserName is required" ForeColor="#A1C18C"></asp:RequiredFieldValidator>
              </li>
              <li>Password</li>
              <li><asp:TextBox ID="txtPwd2" runat="server" CssClass="txtPwd"></asp:TextBox>
                  <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPwd2" ErrorMessage="*Password is required" ForeColor="#A1C18C"></asp:RequiredFieldValidator>
              </li>
            </ul>
          </div>
          <div class="font4">
            <input type="checkbox" class="check"/>
            <font style="color: yellowgreen;font-size: 14px;">I agree to </font> <a href="#"><font style="font-size: 14px;color: white;">terms & conditions</font></a>
          </div>
           <asp:Button ID="btnSign" CssClass="btnSign" runat="server" Text="Sign Up" OnClick="btnReg_Click"/>
          <div style="margin-left: 115px;margin-top: 5px;"><font style="color: yellowgreen;font-size: 12px;">Do you already have an account? </font> <a href="Login.aspx"><font style="font-size: 12px;color: white;">Log in</font></a></div>
        </div>
    </form>
</body>
</html>
