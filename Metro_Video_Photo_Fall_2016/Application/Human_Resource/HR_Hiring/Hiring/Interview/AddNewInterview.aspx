<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="AddNewInterview.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Human_Resource.Hiring.Interview.AddNewInterview" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <div class="container" style="margin-top: 25px;">
    <div class="row">
      <div class="row">
        <asp:Label ID="Error" Style="color: red" runat="server" Visible="false"
          Text="An error occured or no results found. Please try again!">
        </asp:Label>
        <br />
      </div>
      <div class="row">
        <div class="col-md-5 col-md-offset-1">
          <div class="row" style="margin: 0 5px;">
            Table Name:
            <asp:TextBox ID="txtTableName" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Document Num: 
            <asp:TextBox ID="txtDocNum" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Document Type:
            <asp:TextBox ID="txtDocType" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Applicant ID:
            <asp:TextBox ID="txtExtRef" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Employee ID (Interviewer):
            <asp:TextBox ID="txtIntRef" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Score 1: 
            <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Score 2:
            <asp:TextBox ID="txtValue" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Interview Date:
            <asp:TextBox ID="txtValue2" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Interview Time:
            <asp:TextBox ID="txtProcNum" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Interview Score:
            <asp:TextBox ID="txtNumValue1" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Index:
            <asp:TextBox ID="txtNumValue2" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px;">
            Comment : 
            <asp:TextBox ID="txtComments" runat="server" CssClass="form-control"></asp:TextBox>
          </div>
        </div>
        <div class="col-md-5 col-md-offset-1 col-sm-offset-1">
          <div class="row" style="margin: 0 5px;">
            Resultant Query:
            <asp:TextBox ID="txtQuery" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
          </div>
          <div class="row" style="margin: 5px;">
            Validate Data:
            <asp:TextBox ID="TextBox_Details" runat="server" CssClass="form-control" TextMode="MultiLine" Style="margin-left: 0px"></asp:TextBox>
          </div>
          <div class="row" style="margin: 0 5px 5px 5px;">
            <asp:Button ID="Reset" runat="server" Font-Bold="True" Text="Reset Command" CssClass="btn btn-danger" OnClick="Button_Reset_Click" />
          </div>
          <div class="row" style="margin: 0 5px 5px 5px;">
            <asp:Button ID="btnValidate" runat="server" Font-Bold="True" Text="Validate Data" CssClass="btn btn-primary" OnClick="Button_Validate_Click"/>
            &nbsp;
            <asp:Button ID="Reset0" runat="server" Font-Bold="True" Text="Save Data" CssClass="btn btn" OnClick="Button_Save_Click" />
          </div>
          <%--<div class="row" style="margin: 0 5px 5px 5px;">
            <asp:Button ID="Button6" runat="server" Font-Bold="True" Text="Save NEW Document" OnClick="Button_Save_Click" CssClass="btn btn-warning" />
          </div>--%>
        </div>
      </div>

      <div class="row" style="margin: 15px;">
        <asp:GridView ID="changeDataGrid" runat="server" CssClass="footable">
        </asp:GridView>
      </div>
    </div>
        <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Human_Resource/Default.aspx"/>
  </div>
</asp:Content>
