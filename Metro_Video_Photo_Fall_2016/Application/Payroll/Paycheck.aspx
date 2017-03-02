<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Paycheck.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Payroll.WebForm1" %>
<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>
<%@ Register Src="~/Controls/DisplayTable.ascx" TagPrefix="uc1" TagName="DisplayTable" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
     <asp:ListBox ID="ListBox1" runat="server" Height="217px" Width="449px"></asp:ListBox>
     <asp:Button ID="button1" runat="server" OnClick="button1_Click" Text="Download" />
     <asp:Label ID="Label1" runat="server"></asp:Label>
     <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Payroll/Default.aspx" />
</asp:Content>
