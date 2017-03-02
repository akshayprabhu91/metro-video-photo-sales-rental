<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalesOrders.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Marketing_Sales.SalesOrders" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>
<%@ Register Src="~/Controls/DisplayTable.ascx" TagPrefix="uc1" TagName="DisplayTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Sales Orders</h1>
    <uc1:DisplayTable runat="server" ID="DisplayTable" query="select * from SalesOrders" tableName="SalesOrders" />

</asp:Content>
