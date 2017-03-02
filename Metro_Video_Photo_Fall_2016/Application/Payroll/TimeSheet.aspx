<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="TimeSheet.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Payroll.TimeSheet" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>
<%@ Register  Src="~/Controls/DisplayTable.ascx" TagPrefix="uc2" TagName="DisplayTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div class="container">
        <div class="row">
            <h2 class="text-center">Timesheets</h2>
            <br />

    <p>
        <asp:Button ID="Button1" CssClass="btn btn-warning" runat="server" OnClick="Button1_Click" Text="Enter Hours" />
    </p>
            <br />

    <h4>Following are the available timesheets:</h4>
            <p>
        
    <uc2:DisplayTable  runat="server" ID="DisplayTable" tableName="timesheets"  />
    </p>
    
    <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Payroll/Default.aspx"/>

        </div>
        </div>

    </asp:Content>
