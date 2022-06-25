<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="WebApplication3._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

<table>  
    <tr>  
        <td colspan="2">  
            <h1>Insertion</h1>  
        </td>  
    </tr>  
    <tr>  
        <td>Employee ID</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtEmpID" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>Employee First Name</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtEmpFname" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>Employee Last Name</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtEmpLname" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td>Employee Email-ID</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtEmpEmail" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr>  
        <td colspan="2">  
            <asp:Button ID="btnInsertion" runat="server" Text="Insert" OnClick="btnInsertion_Click" Style="width: 48px" />  
            <asp:Label ID="lblmsg" runat="server" ForeColor="Red"></asp:Label>  
        </td>  
    </tr>  
</table>  

<table>  
    <tr>  
        <td colspan="3">  
            <h1>Deletion</h1>  
        </td>  
    </tr>  
    <tr>  
        <td>Employee ID</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="txtEmployeeID" runat="server"></asp:TextBox>  
        </td>  
    </tr>  
    <tr >  
        <td colspan="3">  
            <asp:Button ID="btnDelete" runat="server" Text="Delete" OnClick="btnDelete_Click" />  
            <asp:Label ID="lblmessage" runat="server" ForeColor="Red"></asp:Label>  
        </td>  
    </tr>  
</table>  





</asp:Content>
