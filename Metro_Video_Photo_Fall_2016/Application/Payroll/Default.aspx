<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Payroll.Default" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>
<%@ Register Src="~/Controls/DisplayTable.ascx" TagPrefix="uc1" TagName="DisplayTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="container">
        <h2 class="text-center">Payroll</h2>
        <br /><br />

            <div class="row text-center">
                <asp:Button ID="grossPay" CssClass="btn btn-info btn-lg" runat="server" OnClick="grossPay_Click"  Text="GrossPay"/>
                
                <asp:Button ID="netPay" CssClass="btn btn-info btn-lg" runat="server" OnClick="netPay_Click"  Text="NetPay"/>
                
                <asp:Button ID="Button1" CssClass="btn btn-info btn-lg" runat="server" OnClick="Button1_Click" Text="TimeSheet" />

                <asp:Button ID="Button2" CssClass="btn btn-info btn-lg" runat="server" OnClick="Button2_Click" Text="PaySlip" />
                 <asp:Button ID="dashboard" CssClass="btn btn-info btn-lg" runat="server" OnClick="dashboard_Click" Text="PayRoll Dashboard" />
            </div>
        <br /><br />

        <div class="row text-center">
            <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Payroll/Default.aspx" />
        </div>
        </div>
        
        
  


    

</asp:Content>
