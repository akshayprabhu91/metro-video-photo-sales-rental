<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="SalesQuotes.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Marketing_Sales.SalesQuotes" %>
<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>
<%@ Register Src="~/Controls/DisplayTable.ascx" TagPrefix="uc1" TagName="DisplayTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <h1>Sales Quotes</h1>

     <uc1:DisplayTable runat="server" ID="DisplayTable" query ="select * from SalesQuotes" tableName ="SalesQuotes" />

</asp:Content>
