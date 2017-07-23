<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarList.aspx.cs" Inherits="CarsAndTheirUsers.CarList" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="CarsMenu" style="text-align: center">       
            <asp:ListView ID="carsList"  
                ItemType="CarsAndTheirUsers.Models.Car" 
                runat="server"
                SelectMethod="GetCars" >
                <ItemTemplate>
                    <b style="font-size: large; font-style: normal">
                        <a href="/UsersList.aspx?id=<%#: Item.CarID %>">
                        <%#: Item.CarName %>
                        </a>
                    </b>
                </ItemTemplate>
                <ItemSeparatorTemplate>  |  </ItemSeparatorTemplate>
            </asp:ListView>
        </div>
</asp:Content>
