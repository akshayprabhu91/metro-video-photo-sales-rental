<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Home.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Home" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div style="background-image:url('Images/bg1.jpg');background-repeat:no-repeat;">
        <div class="pad20">
        <div class="row mrgnT2">
            <div class="col-md-3 col-md-offset-1 col-sm-12">
                <a href="#" style="text-decoration: none;">
                    <div class="divTeams" onclick="location.href='/Application/Accounting/Default.aspx'">
                        Accounting
                    </div>
                </a>
            </div>

            <div class="col-md-3 col-md-offset-1 col-sm-12">
                <div class="divTeams" onclick="location.href='/Application/Payroll/Default.aspx'">
                    Payroll
                </div>
            </div>

            <div class="col-md-3 col-md-offset-1 col-sm-12">
                <div class="divTeams" onclick="location.href='/Application/Material_Management/Default.aspx'">
                    M. Management
                </div>
            </div>
        </div>

        <div class="row mrgnT5">

            <div class="col-md-3 col-md-offset-1 col-sm-12">
                <div class="divTeams" onclick="location.href='/Application/Operation/Default.aspx'">
                    Operations
                </div>
            </div>

            <div class="col-md-3 col-md-offset-1 col-sm-12">
                <div class="divTeams" onclick="location.href='/Application/Human_Resource/Default.aspx'">
                    Human Resource
                </div>
            </div>

            <div class="col-md-3 col-md-offset-1 col-sm-12">
                <div class="divTeams" onclick="location.href='/Application/Marketing_Sales/Default.aspx'">
                    Marketing & Sales
                </div>
            </div>
        </div>

        <div class="row mrgnT5">

            <div class="col-md-3 col-md-offset-5 col-sm-12">
                <div class="divTeams" onclick="location.href='/Application/Infrastructure/Default.aspx'">
                    Infrastructure
                </div>
            </div>
        </div>


        </div>

    </div>




</asp:Content>
