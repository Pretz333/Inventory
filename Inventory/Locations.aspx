﻿<%@ Page Title="Locations" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Locations.aspx.cs" Inherits="Inventory.Locations" %>
<asp:Content ID="LocationContent" ContentPlaceHolderID="MainContent" runat="server">
    <asp:SqlDataSource ID="SQLDSLocations" runat="server" ConnectionString="<%$ ConnectionStrings:ConnectionString %>" SelectCommand="SELECT * FROM [Location]" />
    <asp:GridView ID="gvLocations" runat="server" DataSourceID="SQLDSLocations">
    </asp:GridView>
    <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Button" />
</asp:Content>