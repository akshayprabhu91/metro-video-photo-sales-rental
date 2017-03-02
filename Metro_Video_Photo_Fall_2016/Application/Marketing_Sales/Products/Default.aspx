<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Marketing_Sales.Default" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Marketing_Sales/Default.aspx" />

    <div id="hr_menu">
        <h1>Marketing and Sales
        </h1>

        <p>
            <a href="Products_Dashboard.aspx">Dashboard</a>
            <br />
            <a href="SalesQuotes.aspx">View Sales Quotes </a>
            <br />
            <a href="SalesOrders.aspx">View Sales Orders </a>
            <br />
            <a href="../../../ListObject.aspx"">View Documents</a>
            <br />
            <a href="../../../ChangeInfraDocument.aspx">Create Sales Quotes </a>
            <br />          
            <a href="../../../ChangeInfraDocument.aspx">Create Sales Orders</a>
            <br />
            
           

        </p>


    </div>
</asp:Content>
