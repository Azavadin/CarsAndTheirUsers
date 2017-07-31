<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="CarsAccessible.aspx.cs" Inherits="CarsAndTheirUsers.CarsAccessible" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">
    <div id="CarsMenu" style="text-align: center">       
            <asp:ListView ID="carsList"  
                ItemType="CarsAndTheirUsers.Models.Accessibility" 
                runat="server"
                SelectMethod="GetCars" >
                <ItemTemplate>
                    <b style="font-size: large; font-style: normal">
                        <%#: Item.Car.CarName %>
                        </a>
                    </b>
                    <br>
                </ItemTemplate>
            </asp:ListView>
        </div>



</asp:Content>
