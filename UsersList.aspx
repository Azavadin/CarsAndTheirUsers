﻿<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="UsersList.aspx.cs" Inherits="CarsAndTheirUsers.WebForm1" %>
<asp:Content ID="Content1" ContentPlaceHolderID="MainContent" runat="server">

    <asp:ValidationSummary ShowModelStateErrors="true" runat="server" />
    <asp:HyperLink NavigateUrl="~/AddUser" Text="Add New User" runat="server" />
     <asp:GridView runat="server" ID="studentsGrid"
        ItemType="CarsAndTheirUsers.Models.User" DataKeyNames="UserID" 
        SelectMethod="GetUsers" UpdateMethod="usersGrid_UpdateItem" DeleteMethod="usersGrid_DeleteItem"
         AllowSorting="true" AllowPaging="true" PageSize="4"
    AutoGenerateEditButton="true" AutoGenerateDeleteButton="true"  
        AutoGenerateColumns="false">
        <Columns>
            <asp:DynamicField DataField="UserID" />
            <asp:DynamicField DataField="UserName" />
        </Columns>
    </asp:GridView>

</asp:Content>
