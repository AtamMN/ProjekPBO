<%@ Page Title="About" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="About.aspx.cs" Inherits="WebApplication3.About" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <table>  
        <tr>  
            <td>  
                <h1>Selection</h1>  
            </td>  
        </tr>  
        <tr>  
            <td>  
                <asp:Button ID="btnSelect" runat="server" Text="Select All Data" OnClick="btnSelect_Click" />  
            </td>  
        </tr>  
        <tr>  
            <td>  
                <asp:GridView ID="GridView1" runat="server"></asp:GridView>  
            </td>  
        </tr>  
    </table>  
</asp:Content>
