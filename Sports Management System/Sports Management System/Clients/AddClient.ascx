<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="AddClient.ascx.cs" Inherits="Sports_Management_System.Clients.AddClient" %>

<asp:Label runat="server" Text="Name:"/>
<asp:TextBox runat="server" ID="name"/>
<asp:TextBox runat="server" ID="surname"/>
<asp:TextBox runat="server" ID="age"/>
<asp:TextBox runat="server" ID="email"/>
<asp:TextBox runat="server" ID="address"/>

<asp:LinkButton runat="server" Text="Save"></asp:LinkButton>