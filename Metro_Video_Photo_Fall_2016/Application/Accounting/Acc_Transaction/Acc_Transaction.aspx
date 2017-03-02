<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Acc_Transaction.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Accounting.Default" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div>
        <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Accounting/Acc_Transaction.aspx" />
    </div>


    <div class="row">
        <div class="col-md-12">
            <div class="pad2">
                <a href="Reports.aspx">Reports</a>
            </div>

            <div class="pad2">
                <a href="TrialBalance.aspx">Trial Balance</a>
            </div>

            <div class="pad2">
                <a href="Dashboard1.aspx">Dashboard</a>
            </div>
        </div>




    </div>






</asp:Content>



















