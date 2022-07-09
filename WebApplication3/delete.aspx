<%@ Page Title="delete" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="delete.aspx.cs" Inherits="WebApplication3.delete" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
<table>  
    <tr>  
        <td colspan="3">  
            <h1>Delete</h1>  
        </td>  
    </tr>  
    <tr>  
        <td>Film ID</td>  
        <td>:</td>  
        <td>  
            <asp:TextBox ID="id" runat="server"></asp:TextBox>  
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
