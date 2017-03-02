<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="HRhome.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Human_Resource.HR_benefits.HRhome" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" />

     <div class="pad20">
        <div class="row mrgnT2">
            <div class="col-md-3 col-md-offset-1 col-sm-12" style="background-color:cornflowerblue">
                <div style="background-color: cornflowerblue; color: #000000; padding: 20px; border-radius: 4px; text-align: center; cursor: pointer;" onclick="location.href='/Application/Human_Resource/HR_Benefits/Emp_viewBen.aspx'">
                    Employee
                </div>
            </div>
    
            <div class="col-md-3 col-md-offset-1 col-sm-12" style="background-color:cornflowerblue">
                <div style="background-color: cornflowerblue; color: #000000; padding: 20px; border-radius: 4px; text-align: center; cursor: pointer;" onclick="location.href='/Application/Human_Resource/HR_Benefits/AdminManageBen.aspx'">
                    Admin
                </div>
            </div>
        </div>
     </div>
</asp:Content>
