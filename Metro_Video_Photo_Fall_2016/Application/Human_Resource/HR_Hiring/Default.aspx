<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Human_Resource.Default" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>
<%@ Register Src="~/Controls/DisplayTable.ascx" TagPrefix="uc1" TagName="DisplayTable" %>


<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="Hiring/hrcss.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <%--Start Your Code from here--%>
    <div class="container">
        <div class="row">

            <p class="lead">Human Resouce</p>
        </div>
        <div style="background-image: url('Images/bg1.jpg'); background-repeat: no-repeat;">
            <div class="pad20">
                <div class="row">
                    <div class="col-md-4 col-md-offset-1 col-sm-12">
                        <div class="btn" onclick="location.href='/Application/Human_Resource/HR_Hiring/Hiring/Hiring.aspx'">
                            Hiring
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Human_Resource/Default.aspx" />
    </div>






</asp:Content>
