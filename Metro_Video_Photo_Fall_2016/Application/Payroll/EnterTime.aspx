<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EnterTime.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Payroll.EnterTime" %>
<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
      
    <div class="container">
        <h2 class="text-center">Enter Hours</h2>
        <div class="row">
            <div class="col-md-6">
            <h4 style="font-weight:bold;">User Details</h4>
                <br />
            <p>
                <asp:Label ID="Label14" Font-Bold="true" runat="server" Text="Doc Num"></asp:Label>:
                <asp:Label ID="Label7" runat="server"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label15"  Font-Bold="true" runat="server" Text="Emp_ID"></asp:Label>:
                <asp:Label ID="Label8" runat="server"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label16"  Font-Bold="true" runat="server" Text="Start Date"></asp:Label>:
                <asp:Label ID="Label9" runat="server"></asp:Label>
            </p>
            <p>
               <asp:Label ID="Label17"  Font-Bold="true" runat="server" Text="End Date"></asp:Label>:
               <asp:Label ID="Label10" runat="server"></asp:Label>
            </p>
            <p>
               <asp:Label ID="Label18"  Font-Bold="true" runat="server" Text="Week ID"></asp:Label>:
               <asp:Label ID="Label11" runat="server"></asp:Label>
            </p>
            <p>
                <asp:Label ID="Label19"  Font-Bold="true" runat="server" Text="Max.Hours"></asp:Label>:
                <asp:Label ID="Label12" runat="server"></asp:Label>
            </p>
        </div>
            <div class="col-md-6">
               <p class="col-md-5">
                    <strong>MONDAY</strong> <br />
                    <asp:TextBox CssClass="form-control" ID="TextBox1" runat="server"></asp:TextBox>
               </p>
                
                <p class="col-md-5">
                    <strong>TUESDAY</strong><br />
                    <asp:TextBox CssClass="form-control" ID="TextBox2" runat="server"></asp:TextBox>
                </p>
                
                <p class="col-md-5">
                    <strong>WEDNESDAY</strong><br />
                    <asp:TextBox CssClass="form-control" ID="TextBox3" runat="server"></asp:TextBox>
                </p>

                <p class="col-md-5">
                    <strong>THURSDAY</strong><br />
                    <asp:TextBox CssClass="form-control" ID="TextBox4" runat="server"></asp:TextBox>
                </p>

                <p class="col-md-5">
                    <strong>FRIDAY</strong><br />
                    <asp:TextBox CssClass="form-control" ID="TextBox5" runat="server"></asp:TextBox>
                </p>

      
       
            </div>
            </div>
        <div class="row">
            <br /><br />
            <asp:Button CssClass="pull-right btn btn-success" ID="Button1" runat="server" OnClick="Button1_Click" Text="Submit" />
            <asp:Label ID="Label20" cssClass="h3" runat="server"></asp:Label>
        </div>
    </div>
      
      

      
       
      
      <p>
        <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Payroll/Default.aspx"/>
      </p>





</asp:Content>
