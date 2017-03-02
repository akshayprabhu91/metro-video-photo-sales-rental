<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ViewApplications.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Human_Resource.Hiring.Applications.ViewApplications" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>
<%@ Register Src="~/Controls/DisplayTable.ascx" TagPrefix="uc1" TagName="DisplayTable" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="../hrcss.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container">

        <div class="row">
            <p class="lead">View Applications</p>
        </div>
        <div class="row">
            <div class="col-md-3 col-md-offset-1 col-sm-12">
                <div class="btn-small" onclick="location.href='ApplicationsReport.aspx'">
                    Print Report
                </div>
            </div>

            <div class="col-md-3 col-md-offset-1 col-sm-12">
                <div class="btn-small" onclick="location.href='ApplicationsChart.aspx'">
                    View Chart
                </div>
            </div>
            <div class="col-md-3 col-md-offset-1 col-sm-12">
                <div class="btn-small" onclick="location.href='ApplicantToEmp.aspx'">
                    Add new Employee
                </div>
            </div>
        </div>
        <div style="height: auto">
            <uc1:DisplayTable runat="server" ID="DisplayTable" query="select * from applications" tableName="applications" />
        </div>
        <div class="row">

            <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Human_Resource/Default.aspx" />
        </div>
    </div>
</asp:Content>
