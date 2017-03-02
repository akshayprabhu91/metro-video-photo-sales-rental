<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="GrossPay.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Payroll.GrossPay1" %>
<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

     <div class="container">
         <br /><br /><br />
         <div class="row">
             
         
             

             <div class="col-md-6">
             
             <p class="col-md-4">

        <asp:DropDownList CssClass="form-control" ID="payperiod" runat="server"></asp:DropDownList>
                 </p>

        <p>
        <asp:Button ID="actionFor" runat="server" CssClass="btn btn-success btn-sm" OnClick="actionFor_Click" />

        </p>
             </div>
            

         <div class="col-md-6">


        <asp:Label runat="server" cssClass="h2" ID="head" />
             <br /><br />
             <asp:Label runat="server" CssClass="h4" ID="content" />
             <br /><br />
         <div class="form-group">
            <asp:Label ID="label1" runat="server" Text="Employee ID : " Visible="false"/>
            <asp:Label ID="label1txt" runat="server"  Visible="false" />
        </div>
        
        <div class="form-group">
        <asp:Label ID="label2" runat="server" Text="Regular Hourly Pay Rate : "   Visible="false"/>
        <asp:Label ID="label2txt" runat="server"  Visible="false"/>
        </div>
        
        <div class="form-group">
        <asp:Label ID="label3" runat="server" Text="Overtime Hourly Pay Rate : "  Visible="false"/>
        <asp:Label ID="label3txt" runat="server"  Visible="false"/>
            </div>

        
        <div class="form-group">
        <asp:Label ID="label4" runat="server" Text="Number of Regular Hours : "  Visible="false"/>
        <asp:Label ID="label4txt" runat="server"  Visible="false" />
            </div>
        
        <div class="form-group">
        <asp:Label ID="label5" runat="server" Text="Number of Overtime Hours : "  Visible="false"/>
        <asp:Label ID="label5txt" runat="server"  Visible="false" />
        </div>

         <div class="form-group">
        <asp:Label ID="label6" runat="server" Text="Gross Pay : "  Visible="false"/>
        <asp:Label ID="label6txt" runat="server"  Visible="false"/>
             </div>
        
        <div class="form-group">
        <asp:Label ID="benefits" runat="server" Text="Total Benefits : "  Visible="false"/>
        <asp:Label ID="benefitsTxt" runat="server"  Visible="false"/>
            </div>

        
        <div class="form-group">
        <asp:Label ID="deductions" runat="server" Text="Total Deductions : "  Visible="false"/>
        <asp:Label ID="deductionsTxt" runat="server"  Visible="false"/>
            </div>

        
        <div class="form-group">
        <asp:Label ID="netPay" runat="server" Text="Net Pay : "  Visible="false"/>
        <asp:Label ID="NetPaytxt" runat="server"  Visible="false" />
            </div>

             <p>
                 <asp:Label ID="PayslipMsg" CssClass="h4" runat="server"/>
             </p>

</div>
              </div>
         
        
         <div class="row">
             <p>
                 <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Payroll/Default.aspx"/>
             </p>
             <br />
         </div>
       
    
    </div>
</asp:Content>
