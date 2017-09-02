<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Clients.aspx.cs" Inherits="Sports_Management_System.Clients.Clients" %>

<asp:Content runat="server" ContentPlaceHolderID="content">
    <asp:LinkButton runat="server" ID="btnNewClient" CssClass="btn btn-success btn-sm" Text="new client">     
    </asp:LinkButton>
    <asp:TextBox CssClass="form-control form-control-sm" runat="server" ID="inputSearch" />
    <asp:LinkButton CssClass="btn btn-sm" runat="server" Text="search" ID="btnSearch">
    </asp:LinkButton>
</asp:Content>