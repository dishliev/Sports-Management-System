<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddClient.ascx.cs" Inherits="Sports_Management_System.Clients.AddClient" %>

<div class="row">
    <asp:Label runat="server" Text="Name:" />
    <asp:TextBox runat="server" ID="name" />
    <asp:Label runat="server" Text="Surname:" />
    <asp:TextBox runat="server" ID="surname" />
</div>
<div class="row">
    <asp:Label runat="server" Text="Age:" />
    <asp:TextBox runat="server" ID="age" />
    <asp:Label runat="server" Text="Email:" />
    <asp:TextBox runat="server" ID="email" />
</div>
<div class="row">
    <asp:Label runat="server" Text="Address:" />
    <asp:TextBox runat="server" ID="address" />
    <asp:Label runat="server" Text="Phone:" />
    <asp:TextBox runat="server" ID="phone" />
</div>
<div class="row">
<asp:LinkButton runat="server" Text="Save" ID="save" OnClick="save_Click"></asp:LinkButton>
</div>