<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="CarsAndTheirUsers.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="UsersMenu" style="text-align: center">       
            <asp:ListView ID="usersList"  
                ItemType="CarsAndTheirUsers.Models.User" 
                runat="server"
                SelectMethod="GetUsers" >
                <ItemTemplate>
                    <b style="font-size: large; font-style: normal">
                        <%#: Item.UserID %>
                        <%#: Item.UserName %>
                        
                    </b>
                </ItemTemplate>
                <ItemSeparatorTemplate>  |  </ItemSeparatorTemplate>
            </asp:ListView>
        </div>

</asp:Content>
