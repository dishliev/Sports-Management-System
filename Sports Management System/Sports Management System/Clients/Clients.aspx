<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Clients.aspx.cs" Inherits="Sports_Management_System.Clients.Clients" %>

<%@ Register Src="~/Clients/AddClient.ascx" TagPrefix="uc1" TagName="AddClient" %>

<asp:Content runat="server" ContentPlaceHolderID="content">

    <asp:LinkButton runat="server" ID="btnNewClient" CssClass="btn btn-success btn-sm" Text="new client">     
    </asp:LinkButton>

    <div class="input-group">
        <asp:TextBox CssClass="form-control form-control-sm" runat="server" ID="inputSearch" />
        <asp:LinkButton CssClass="btn btn-sm" runat="server" Text="search" ID="btnSearch">
        </asp:LinkButton>
    </div>

    <div class="col-md-10">
        <table class="table table-hover table-bordered">
            <thead>
                <th>Name</th>
                <th>Surname</th>
                <th>Age</th>
                <th>Email</th>
                <th>Address</th>
                <th>Phone</th>
            </thead>
            <asp:Repeater runat="server" ID="repCustomers">
                <ItemTemplate>
                    <tbody>
                        <asp:HiddenField runat="server" ID="hfclientId" Value='<%# Eval("clientId") %>' />

                        <td><%# Eval("name") %></td>
                        <td><%# Eval("Surname") %></td>
                        <td><%# Eval("age") %></td>
                        <td><%# Eval("email") %></td>
                        <td><%# Eval("address") %></td>
                        <td><%# Eval("phone") %></td>
                        <td>
                            <asp:LinkButton CssClass="btn btn-sm btn-info" runat="server" ID="LinkButton1" Text="open" />
                            <asp:LinkButton CssClass="btn btn-sm btn-warning" runat="server" ID="edit" Text="edit" />
                            <asp:LinkButton CssClass="btn btn-sm btn-danger" runat="server" ID="delete" Text="delete" />
                        </td>
                    </tbody>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>
</asp:Content>
