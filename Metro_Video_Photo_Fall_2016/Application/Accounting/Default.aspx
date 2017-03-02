<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Accounting.Default1" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Accounting/Default.aspx" />


    <div class="pad20">
        <div class="row mrgnT2">
            <div class="col-md-3 col-md-offset-1 col-sm-12" style="background-color: cornflowerblue">
                <div style="background-color: cornflowerblue; color: #000000; padding: 20px; border-radius: 4px; text-align: center; cursor: pointer;" onclick="location.href='#'">
                    Payable
                </div>
            </div>

            <div class="col-md-3 col-md-offset-1 col-sm-12" style="background-color: cornflowerblue">
                <div style="background-color: cornflowerblue; color: #000000; padding: 20px; border-radius: 4px; text-align: center; cursor: pointer;" onclick="location.href='#'">
                    Receivable
                </div>
            </div>

            <div class="col-md-3 col-md-offset-1 col-sm-12" style="background-color: cornflowerblue">
                <div style="background-color: cornflowerblue; color: #000000; padding: 20px; border-radius: 4px; text-align: center; cursor: pointer;" onclick="location.href='/Application/Accounting/Acc_Transaction/Acc_Transaction.aspx'">
                    Transaction
                </div>
            </div>
        </div>
    </div>




</asp:Content>
