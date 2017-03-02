<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="ListObject.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.ListObject" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">


    <div class="container" style="margin-top: 20px;">
        <div class="row" style="text-align: center">
            <h3 class="text-info">Documents</h3>
        </div>
        <div class="row" style="border: 1px solid; margin: 5px; padding-top: 5px;">
            <div class="row text-center">
                <p class="text-muted">Enter Table Name, Document Number and Document Type to display the Results</p>
                <asp:Label ID="Error" Style="color: red" runat="server" Visible="false"
                    Text="An error occured or no results found. Please try again!">
                </asp:Label>
            </div>
            <div class="row" style="margin: 15px;">
                <div class="col-md-10 col-md-offset-1">
                    <div class="input-group">
                        <asp:Label ID="Label2" runat="server" Text="Label" CssClass="input-group-addon">Table Name:</asp:Label>
                        <asp:DropDownList ID="dropDownTableName" runat="server" CssClass="form-control" aria-describedby="Label2"></asp:DropDownList>
                        <asp:Label ID="Label1" runat="server" Text="Label" CssClass="input-group-addon">Or Enter:</asp:Label>
                        <asp:TextBox ID="txtTableName" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-10 col-md-offset-1" style="margin-top: 5px;">
                    <div class="input-group">
                        <asp:Label ID="Label3" runat="server" Text="Label" CssClass="input-group-addon">Doc Type:</asp:Label>
                        <asp:DropDownList ID="dropDownDocType" runat="server" CssClass="form-control" aria-describedby="Label3"></asp:DropDownList>
                        <asp:Label ID="Label4" runat="server" Text="Label" CssClass="input-group-addon">Or Enter:</asp:Label>
                        <asp:TextBox ID="txtDocType" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-10 col-md-offset-1" style="margin-top: 5px;">
                    <div class="input-group">
                        <asp:Label ID="Label5" runat="server" Text="Label" CssClass="input-group-addon">Doc Number:</asp:Label>
                        <asp:DropDownList ID="dropDownDocNumber" runat="server" CssClass="form-control" aria-describedby="Label5">
                            <asp:ListItem Value="0">0 -  Any Num</asp:ListItem>
                            <asp:ListItem>1 Enter Then Number in Text Box</asp:ListItem>
                        </asp:DropDownList>
                        <asp:Label ID="Label6" runat="server" Text="Label" CssClass="input-group-addon">Or Enter:</asp:Label>
                        <asp:TextBox ID="txtDocNum" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
            </div>
            <div class="row" style="margin: 15px;">
                <div class="col-md-10 col-md-offset-1">
                    Resultant Query:
        <asp:TextBox ID="txtQuery" runat="server" CssClass="form-control"></asp:TextBox>
                </div>
            </div>
            <div class="row" style="margin: 15px;">
                <div class="col-md-10 col-md-offset-1">
                    <asp:Button ID="DisplayResults" runat="server" Text="Display Results" CssClass="btn btn-success" OnClick="DisplayResults_Click" />
                    <asp:Button ID="Reset" runat="server" Text="Reset Command" CssClass="btn btn-danger" OnClick="Reset_Click" />
                </div>
            </div>
        </div>
    </div>
    <div class="container" style="margin-top: 15px">
        <div class="row" style="border: 1px solid; margin: 5px; padding-top: 5px;">
            <div class="row text-center">
                <p class="text-muted">Enter Document Type and Document Number to create or change a document</p>
            </div>
            <div class="row" style="margin: 15px;">
                <div class="col-md-10 col-md-offset-1">
                    <div class="input-group">
                        <asp:Label ID="Label7" runat="server" Text="Label" CssClass="input-group-addon">New Doc.Type :</asp:Label>
                        <asp:TextBox ID="txtNewDocType" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-10 col-md-offset-1" style="margin-top: 5px;">
                    <div class="input-group">
                        <asp:Label ID="Label8" runat="server" Text="Label" CssClass="input-group-addon">New Doc.Number :</asp:Label>
                        <asp:TextBox ID="txtNewDocNum" runat="server" CssClass="form-control"></asp:TextBox>
                    </div>
                </div>
                <div class="col-md-10 col-md-offset-1" style="margin-top: 5px;">
                    <asp:Button ID="btnSubmit" runat="server" EnableTheming="True" OnClick="btnSubmit_Click" Text="Submit" CssClass="btn btn-primary" />
                </div>
            </div>
        </div>

        <div class="row">
            <asp:GridView ID="docGrid" runat="server" AutoGenerateSelectButton="True"
                CssClass="footable"
                OnSelectedIndexChanged="docGrid_SelectedIndexChanged">
            </asp:GridView>
        </div>
    </div>


</asp:Content>
