<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsersAccessible.aspx.cs" Inherits="CarsAndTheirUsers.UsersAccessible" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="UsersMenu" style="text-align: center">       
            <asp:ListView ID="usersList"  
                ItemType="CarsAndTheirUsers.Models.Accessibility" 
                runat="server"
                SelectMethod="GetUsers" >
                <ItemTemplate>
                    <b style="font-size: large; font-style: normal">
                        <%#: Item.User.UserName %>
                        </b>
                    <br>
                </ItemTemplate>
            </asp:ListView>
        </div>

</asp:Content>
