<%@ Page Title="add" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="add.aspx.cs" Inherits="WebApplication3.add" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>  
        <tr>  
            <td colspan="2">  
                <h1>ADD FILM</h1>
                <p>&nbsp;</p>
            </td>
        </tr>
        <tr

        <tr>  
            <td>Title</td>  
            <td>:</td>  
            <td style="width: 450px">  
                <asp:TextBox ID="t" runat="server"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td>Description</td>  
            <td>:</td>  
            <td style="width: 450px">  
                <asp:TextBox ID="d" runat="server"></asp:TextBox>  
            </td>  
        </tr>  
        <tr>  
            <td>Rating</td>  
            <td>:</td>  
            <td style="width: 450px">  
                <asp:TextBox ID="r" runat="server"></asp:TextBox>  
            </td>  
        </tr> 
        <tr>  
            <td colspan="2">  
                <asp:Button ID="btnInsertion" runat="server" Text="Insert"  OnClick="tambah" Style="width: 48px" />  
                <asp:Label ID="lblmsg" href="~/" runat="server" ForeColor="Red"></asp:Label>  
                <br />
            </td>  
        </tr>  
    </table>
   
</asp:Content>