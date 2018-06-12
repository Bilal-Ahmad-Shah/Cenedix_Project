<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculator.aspx.cs" Inherits="WebForm_Calc_Program4.Calculator" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <h2>Webform Calculator</h2>
        <table style="width: 50%;">
            <tr>
                <td>
                    <asp:TextBox ID="result" runat="server" Width="100%" Height="50px">0</asp:TextBox>
                </td>
                

            </tr>
        
        </table>
        <table style="width: 50%;">
            <tr>
                <td><asp:Button runat="server" Text="1" Width="100%" ID="btn1" OnClick="button_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="2" Width="100%" ID="btn2" OnClick="button_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="3" Width="100%" ID="btn3" OnClick="button_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="+" Width="100%" ID="btnAdd" OnClick="Calc_Click"></asp:Button></td>
            </tr>
            <tr>
                <td><asp:Button runat="server" Text="4" Width="100%" ID="btn4" OnClick="button_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="5" Width="100%" ID="btn5" OnClick="button_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="6" Width="100%" ID="btn6" OnClick="button_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="-" Width="100%" ID="btnSub" OnClick="Calc_Click"></asp:Button></td>
            </tr>
            <tr>
                <td><asp:Button runat="server" Text="7" Width="100%" ID="btn7" OnClick="button_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="8" Width="100%" ID="btn8" OnClick="button_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="9" Width="100%" ID="btn9" OnClick="button_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="*" Width="100%" ID="btnMul" OnClick="Calc_Click"></asp:Button></td>
            </tr>
            <tr>
                <td><asp:Button runat="server" Text="CE" Width="100%" ID="btnClear" OnClick="btnClear_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="0" Width="100%" ID="btn0" OnClick="button_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="/" Width="100%" ID="btnDivide" OnClick="Calc_Click"></asp:Button></td>
                <td><asp:Button runat="server" Text="=" Width="100%" ID="btnEqual" OnClick="btnEqual_Click"></asp:Button></td>
            </tr>

        </table>
    </div>
    </form>
</body>
</html>
