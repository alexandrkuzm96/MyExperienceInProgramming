﻿<%@ Page Language="C#" MasterPageFile="~/ЛР6/MasterPage.master" AutoEventWireup="true" CodeFile="Default2.aspx.cs" Inherits="ЛР6_Default2" Title="Untitled Page" %>
<%@ Register Src="~/ЛР6/WebUserControl2.ascx" TagPrefix="us" TagName="sum" %>
<asp:Content ID="Content1" ContentPlaceHolderID="PageContent" Runat="Server">
<h1 id="zogolovok" style=" margin-top:3%; margin-left:3%;">Стрраница 1</h1>
<us:sum runat="server" ID="sum" />
</asp:Content>
