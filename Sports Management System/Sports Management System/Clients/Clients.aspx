<%@ Page Language="C#" AutoEventWireup="true" MasterPageFile="~/Site.Master" CodeBehind="Clients.aspx.cs" Inherits="Sports_Management_System.Clients.Clients" %>

<%@ Register Src="~/Clients/AddClient.ascx" TagPrefix="uc1" TagName="AddClient" %>


<asp:Content runat="server" ContentPlaceHolderID="content">

    <asp:LinkButton runat="server" ID="btnNewClient" data-toggle="modal" data-target="#myModal" CssClass="btn btn-success btn-sm" Text="new client">     
    </asp:LinkButton>

    <div class="input-group">
        <asp:TextBox CssClass="form-control form-control-sm" runat="server" ID="inputSearch" />
        <asp:LinkButton CssClass="btn btn-sm" runat="server" Text="search" ID="btnSearch">
        </asp:LinkButton>
    </div>

    <div class="col-md-10">
        <table id="clientTable" class="table table-hover table-bordered">
            <tr>
                <th>Name</th>
                <th>Surname</th>
                <th>Age</th>
                <th>Email</th>
                <th>Address</th>
                <th>Phone</th>
            </tr>
            <asp:Repeater runat="server" ID="repCustomers" OnItemCommand="repCustomers_ItemCommand">
                <ItemTemplate>
                    <tr>
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
                            <asp:LinkButton CssClass="btn btn-sm btn-danger" runat="server" ID="delete" Text="delete" CommandName="delete" CommandArgument='<%# Eval("clientId") %>' />
                        </td>
                    </tr>
                </ItemTemplate>
            </asp:Repeater>
        </table>
    </div>

    <div class="container">
        <!-- Modal -->
        <div class="modal fade" id="myModal" role="dialog">
            <div class="modal-dialog">

                <!-- Modal content-->
                <div class="modal-content">
                    <div class="modal-header">
                        <button type="button" class="close" data-dismiss="modal">&times;</button>
                        <h4 class="modal-title">Add Client</h4>
                    </div>
                    <div class="modal-body">
                        <uc1:AddClient runat="server" ID="AddClient" />
                    </div>
                    <div class="modal-footer">
                        <button type="button" class="btn btn-default" data-dismiss="modal">Close</button>
                    </div>
                </div>
            </div>
        </div>
    </div>

</asp:Content>
