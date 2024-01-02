<%@ Page Title="" Language="C#" MasterPageFile="~/OurSite.Master" AutoEventWireup="true" CodeBehind="ClassesRegister.aspx.cs" Inherits="Phase3PracticeProject3.ClassesRegister" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
    .auto-style7 {
        width: 166px;
    }
</style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table class="auto-style1">
    <tr>
        <td class="auto-style7">ClassId</td>
        <td>
            <asp:TextBox ID="ClassId" runat="server"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">ClassName</td>
        <td>
            <asp:TextBox ID="ClassName" runat="server" OnTextChanged="TextBox2_TextChanged"></asp:TextBox>
        </td>
    </tr>
    <tr>
        <td class="auto-style7">&nbsp;</td>
        <td>
            <asp:Button ID="BtnRegister" runat="server" OnClick="BtnRegister_Click" Text="Register" />
        </td>
    </tr>
    <tr>
        <td class="auto-style7">
            <asp:Label ID="LblMsg" runat="server"></asp:Label>
        </td>
        <td>&nbsp;</td>
    </tr>
</table>
</asp:Content>
