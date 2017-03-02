<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="DisplaySelectedListObject.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.DisplaySelectedListObject" %>

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
            <asp:TextBox ID="txtTabName" runat="server" CssClass="form-control"></asp:TextBox>
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
                        External Ref:
            <asp:TextBox ID="txtExtRef" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row" style="margin: 0 5px;">
                        Internal Refrence:
            <asp:TextBox ID="txtIntRef" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row" style="margin: 0 5px;">
                        Status: 
            <asp:TextBox ID="txtStatus" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row" style="margin: 0 5px;">
                        Doc.Start Date:
            <asp:TextBox ID="txtDocStartDate" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row" style="margin: 0 5px;">
                        Doc Status Date :
            <asp:TextBox ID="txtDocStatusDate" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row" style="margin: 0 5px;">
                        Process Number:
            <asp:TextBox ID="txtProcessNum" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row" style="margin: 0 5px;">
                        Quoted Amount:
            <asp:TextBox ID="txtQuotedAmt" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row" style="margin: 0 5px;">
                        Actual Amount:
            <asp:TextBox ID="txtActualAmt" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row" style="margin: 0 5px;">
                        Comment : 
            <asp:TextBox ID="txtComment" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-5 col-md-offset-1 col-sm-offset-1">
                    <div class="row" style="margin: 0 5px;">
                        Resultant Query:
            <asp:TextBox ID="txtQuery" runat="server" TextMode="MultiLine" CssClass="form-control"></asp:TextBox>
                    </div>
                    <div class="row" style="margin: 5px;">
                        <asp:Button ID="GetDocument" runat="server" Font-Bold="True" Text="Get Document" CssClass="btn btn-success" OnClick="GetDocument_Click" />
                        <asp:Button ID="Reset" runat="server" Font-Bold="True" Text="Reset Command" CssClass="btn btn-danger" OnClick="Reset_Click" />
                    </div>
                    <div class="row" style="margin: 0 5px 5px 5px;">
                        <asp:Button ID="Button2" runat="server" Font-Bold="True" Text="Load Options" CssClass="btn btn-primary" />
                        <asp:Button ID="ChangeDocument" runat="server" Font-Bold="True" Text="Change Document" CssClass="btn btn-default" OnClick="ChangeDocument_Click" />
                    </div>
                </div>
            </div>

            <div class="row" style="margin: 15px;">
                <asp:GridView ID="GridView1" runat="server" CssClass="footable">
                </asp:GridView>
            </div>
        </div>
    </div>


</asp:Content>
