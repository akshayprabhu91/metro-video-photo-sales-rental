<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Hiring.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Human_Resource.Hiring.Hiring" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="hrcss.css" rel="stylesheet" type="text/css" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
    </div>

    <div class="container">
        <div class="row">
            <div class="row">
                
                <p class="lead">Hiring page</p>
            </div>
            <div style="background-image: url('Images/bg1.jpg'); background-repeat: no-repeat;">
                <div class="pad20">
                    <div class="row">

                        <div class="col-md-4 col-md-offset-1 col-sm-12">
                            <div class="btn" onclick="location.href='Applications/ViewApplications.aspx'">
                                Applications
                            </div>
                        </div>

                        <div class="col-md-4 col-md-offset-2 col-sm-12">
                            <div class="btn" onclick="location.href='Jobs/ViewJobs.aspx'">
                                Jobs
                            </div>
                        </div>
                    </div>

                    <div class="row" style="padding-top: 30px">

                        <div class="col-md-4 col-md-offset-1 col-sm-12">
                            <div class="btn" onclick="location.href='Interview/ViewInterviews.aspx'">
                                Interviews
                            </div>
                        </div>

                        <div class="col-md-4 col-md-offset-2 col-sm-12">
                            <div class="btn" onclick="location.href='Skills/ViewSkills.aspx'">
                                Skills
                            </div>
                        </div>


                    </div>

                </div>

            </div>
        </div>
        <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Human_Resource/Default.aspx"/>
    </div>
    
</asp:Content>
