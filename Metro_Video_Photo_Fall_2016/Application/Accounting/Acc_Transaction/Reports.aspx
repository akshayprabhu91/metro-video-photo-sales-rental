<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Reports.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Accounting.AccountsReports.AccountReports_Main" %>

<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link rel="stylesheet" href="/Application/Accounting/StyleSheet1.css" type="text/css" media="screen" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" />
    <asp:Button ID="btn_Home" runat="server" OnClick="btn_Home_Click" Text="Accounts Home" />
    <div class="container">
        <div>
            <select id="report" class="dropdown">
                <option  value="4">Select Report</option>
                <option  value="0">Balance Sheet Report</option>
                <option  value="1">Trial Balance Report</option>
                <option  value="2">Income Report</option>
                <option  value="3">Internal Trial Balance</option>
            </select>
        </div>
        <div id="BalanceSheet" class="row pad3">
            <h1 class="text-center" style="margin-right: 55px; margin-top: 100px;">Balance Sheet Report</h1>
            <div class="col-lg-6">
                <div class='tableauPlaceholder' id='viz1480224424180' style='position: relative'>
                    <noscript>
                      <a href='#'><img alt='BalanceSheet ' src='https:&#47;&#47;public.tableau.com&#47;static&#47;images&#47;mo&#47;mokka&#47;BalanceSheet&#47;1_rss.png' style='border: none' /></a>

                  </noscript>
                    <object class='tableauViz' style='display: none;'>
                        <param name='host_url' value='https%3A%2F%2Fpublic.tableau.com%2F' />
                        <param name='site_root' value='' />
                        <param name='name' value='mokka&#47;BalanceSheet' />
                        <param name='tabs' value='no' />
                        <param name='toolbar' value='yes' />
                        <param name='static_image' value='https:&#47;&#47;public.tableau.com&#47;static&#47;images&#47;mo&#47;mokka&#47;BalanceSheet&#47;1.png' />
                        <param name='animate_transition' value='yes' />
                        <param name='display_static_image' value='yes' />
                        <param name='display_spinner' value='yes' />
                        <param name='display_overlay' value='yes' />
                        <param name='display_count' value='yes' />
                    </object>
                </div>
                <script type='text/javascript'>
                    var divElement = document.getElementById('viz1480224424180');
                    var vizElement = divElement.getElementsByTagName('object')[0]; vizElement.style.width = '100%';
                    vizElement.style.height = (divElement.offsetWidth * 0.75) + 'px';
                    var scriptElement = document.createElement('script'); scriptElement.src = 'https://public.tableau.com/javascripts/api/viz_v1.js'; vizElement.parentNode.insertBefore(scriptElement, vizElement);

                </script>
            </div>
            <div class="col-lg-6" style="width: auto">
                <asp:GridView ID="GridView1" runat="server" CssClass="mydatagrid" OnRowDataBound="GridView1_RowDataBound" ShowFooter="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </div>
            <div class="col-lg-4" style="width: auto">
                <asp:GridView ID="GridView2" runat="server" CssClass="mydatagrid" OnRowDataBound="GridView2_RowDataBound" ShowFooter="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </div>




            <div class="col-lg-4" style="width: auto">

                <asp:GridView ID="GridView3" runat="server" CssClass="mydatagrid" OnRowDataBound="GridView3_RowDataBound" ShowFooter="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
                <div class="pull-right top-right">
                    <asp:Label ID="lbllo" runat="server" class="center" Text="Assets = Liability + Ownership"></asp:Label><br />
                    <asp:Label ID="lblTotal" runat="server" Text="Liability + Ownership = "></asp:Label><br />
                    <asp:Label ID="lblAsset" runat="server" Text="Assets = "></asp:Label><br />
                </div>


            </div>

        </div>
        <div id="IncomeReport" class="row pad3">
            <h1 class="text-center" style="margin-right: 55px; margin-top: 100px;">Income Report</h1>
            <div class="col-lg-6">
                <div class='tableauPlaceholder' id='viz1480224987141' style='position: relative'>
                    <noscript><a href='#'>
                        <img alt='IncomeReport ' src='https:&#47;&#47;public.tableau.com&#47;static&#47;images&#47;In&#47;IncomeReport&#47;IncomeReport&#47;1_rss.png' style='border: none' /></a></noscript>
                    <object class='tableauViz' style='display: none;'>
                        <param name='host_url' value='https%3A%2F%2Fpublic.tableau.com%2F' />
                        <param name='site_root' value='' />
                        <param name='name' value='IncomeReport&#47;IncomeReport' />
                        <param name='tabs' value='no' />
                        <param name='toolbar' value='yes' />
                        <param name='static_image' value='https:&#47;&#47;public.tableau.com&#47;static&#47;images&#47;In&#47;IncomeReport&#47;IncomeReport&#47;1.png' />
                        <param name='animate_transition' value='yes' />
                        <param name='display_static_image' value='yes' />
                        <param name='display_spinner' value='yes' />
                        <param name='display_overlay' value='yes' />
                        <param name='display_count' value='yes' />
                    </object>
                </div>
                <script type='text/javascript'>
                    var divElement = document.getElementById('viz1480224987141');
                    var vizElement = divElement.getElementsByTagName('object')[0]; vizElement.style.width = '100%'; vizElement.style.height = (divElement.offsetWidth * 0.75) + 'px';
                    var scriptElement = document.createElement('script'); scriptElement.src = 'https://public.tableau.com/javascripts/api/viz_v1.js'; vizElement.parentNode.insertBefore(scriptElement, vizElement);

                </script>
            </div>
            <div class="col-lg-6">
                <div class="col-lg-6">
                    <asp:GridView ID="GridView4" runat="server" CssClass="mydatagrid" OnRowDataBound="GridView4_RowDataBound" ShowFooter="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </div>
                <div class="col-lg-6">
                    <asp:GridView ID="GridView5" runat="server" CssClass="mydatagrid" OnRowDataBound="GridView5_RowDataBound" ShowFooter="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </div>
                <div>
                    <asp:Label ID="lblNetValue" runat="server" Text="Net Income :"></asp:Label>
                    <asp:Label ID="lblNetIncome" runat="server" Text="Label"></asp:Label>
                </div>
            </div>

        </div>

        <div id="TrialBalance" class="row pad3">
            <h1 class="text-center" style="margin-right: 55px; margin-top: 100px;">Trial Balance Report</h1>
            <div class="col-lg-8">
                <div class='tableauPlaceholder' id='viz1480224198894' style='position: relative'>
                    <noscript><a href='#'><img alt='TrialBalanceByQuater ' src='https:&#47;&#47;public.tableau.com&#47;static&#47;images&#47;Pr&#47;Proto_Accounting1E_BalanceSheet&#47;TrialBalanceByQuater&#47;1_rss.png' style='border: none' /></a>

                    </noscript>
                    <object class='tableauViz' style='display: none;'>
                        <param name='host_url' value='https%3A%2F%2Fpublic.tableau.com%2F' />
                        <param name='site_root' value='' />
                        <param name='name' value='Proto_Accounting1E_BalanceSheet&#47;TrialBalanceByQuater' />
                        <param name='tabs' value='no' />
                        <param name='toolbar' value='yes' />
                        <param name='static_image' value='https:&#47;&#47;public.tableau.com&#47;static&#47;images&#47;Pr&#47;Proto_Accounting1E_BalanceSheet&#47;TrialBalanceByQuater&#47;1.png' />
                        <param name='animate_transition' value='yes' />
                        <param name='display_static_image' value='yes' />
                        <param name='display_spinner' value='yes' />
                        <param name='display_overlay' value='yes' />
                        <param name='display_count' value='yes' />

                    </object>
                </div>
                <script type='text/javascript'>
                    var divElement = document.getElementById('viz1480224198894');
                    var vizElement = divElement.getElementsByTagName('object')[0]; vizElement.style.width = '100%'; vizElement.style.height = (divElement.offsetWidth * 0.75) + 'px';
                    var scriptElement = document.createElement('script'); scriptElement.src = 'https://public.tableau.com/javascripts/api/viz_v1.js'; vizElement.parentNode.insertBefore(scriptElement, vizElement);

                </script>
            </div>
            <div class="col-lg-6 pad3">
                <asp:GridView ID="GridView6" runat="server" CssClass="mydatagrid" OnRowDataBound="GridView6_RowDataBound" ShowFooter="True" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2">
                    <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                    <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                    <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                    <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                    <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                    <SortedAscendingCellStyle BackColor="#FFF1D4" />
                    <SortedAscendingHeaderStyle BackColor="#B95C30" />
                    <SortedDescendingCellStyle BackColor="#F1E5CE" />
                    <SortedDescendingHeaderStyle BackColor="#93451F" />
                </asp:GridView>
            </div>
        </div>
        <div id="InternalTrialBalance">
            <h1 class="text-center" style="margin-right: 55px; margin-top: 100px;">Internal Trial Balance Report</h1>
            <div class="col-lg-12">
                <div class='tableauPlaceholder' id='viz1480269160292' style='position: relative'>
                    <noscript>
                       <a href='#'>
                           <img alt='InternalTrial ' src='https:&#47;&#47;public.tableau.com&#47;static&#47;images&#47;Pr&#47;Proto_Accounting1E_BalanceSheet&#47;InternalTrial&#47;1_rss.png' style='border: none' /></a></noscript>
                    <object class='tableauViz' style='display: none;'>
                        <param name='host_url' value='https%3A%2F%2Fpublic.tableau.com%2F' />
                        <param name='site_root' value='' />
                        <param name='name' value='Proto_Accounting1E_BalanceSheet&#47;InternalTrial' />
                        <param name='tabs' value='no' />
                        <param name='toolbar' value='yes' />
                        <param name='static_image' value='https:&#47;&#47;public.tableau.com&#47;static&#47;images&#47;Pr&#47;Proto_Accounting1E_BalanceSheet&#47;InternalTrial&#47;1.png' />
                        <param name='animate_transition' value='yes' />
                        <param name='display_static_image' value='yes' />
                        <param name='display_spinner' value='yes' />
                        <param name='display_overlay' value='yes' />
                        <param name='display_count' value='yes' />


                    </object>

                </div>
                <script type='text/javascript'>
                    var divElement = document.getElementById('viz1480269160292');
                    var vizElement = divElement.getElementsByTagName('object')[0]; vizElement.style.width = '1004px';
                    vizElement.style.height = '869px';
                    var scriptElement = document.createElement('script');
                    scriptElement.src = 'https://public.tableau.com/javascripts/api/viz_v1.js';
                    vizElement.parentNode.insertBefore(scriptElement, vizElement);

                </script>
            </div>
            <div class="row pad3">
                <div class="col-lg-6">
                    <h1>Asset Accounts</h1>
                    <asp:GridView ID="GridView7" runat="server" CssClass="col-lg-4 mydatagrid" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowDataBound="GridView7_RowDataBound" ShowFooter="True">
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </div>
                <div class="col-lg-6">
                    <h1>Revenue Accounts</h1>
                    <asp:GridView ID="GridView8" runat="server"  CssClass="mydatagrid" BackColor="#DEBA84" BorderColor="#DEBA84" BorderStyle="None" BorderWidth="1px" CellPadding="3" CellSpacing="2" OnRowDataBound="GridView8_RowDataBound" ShowFooter="True">
                        <FooterStyle BackColor="#F7DFB5" ForeColor="#8C4510" />
                        <HeaderStyle BackColor="#A55129" Font-Bold="True" ForeColor="White" />
                        <PagerStyle ForeColor="#8C4510" HorizontalAlign="Center" />
                        <RowStyle BackColor="#FFF7E7" ForeColor="#8C4510" />
                        <SelectedRowStyle BackColor="#738A9C" Font-Bold="True" ForeColor="White" />
                        <SortedAscendingCellStyle BackColor="#FFF1D4" />
                        <SortedAscendingHeaderStyle BackColor="#B95C30" />
                        <SortedDescendingCellStyle BackColor="#F1E5CE" />
                        <SortedDescendingHeaderStyle BackColor="#93451F" />
                    </asp:GridView>
                </div>
            </div>
        </div>
    </div>

    <script src="http://ajax.googleapis.com/ajax/libs/jquery/1.10.2/jquery.min.js">
    </script>
    <script>
        $(document).ready(function () {

            $('#BalanceSheet').hide();
            $('#TrialBalance').hide();
            $('#IncomeReport').hide();
            $('#InternalTrialBalance').hide();

        });

        $(document).ready(function () {
            $('#report').on('change', function () {

                if (this.value == '4') {
                    $('#BalanceSheet').hide();
                    $('#TrialBalance').hide();
                    $('#IncomeReport').hide();
                    $('#InternalTrialBalance').hide();
                }
                else if (this.value == '0') {
                    $('#BalanceSheet').show();
                    $('#TrialBalance').hide();
                    $('#IncomeReport').hide();
                    $('#InternalTrialBalance').hide();
                }
                else if (this.value == '1') {
                    $('#BalanceSheet').hide();
                    $('#TrialBalance').show();
                    $('#IncomeReport').hide();
                    $('#InternalTrialBalance').hide();
                }
                else if (this.value == '2') {
                    $('#BalanceSheet').hide();
                    $('#TrialBalance').hide();
                    $('#IncomeReport').show();
                }
                else if (this.value == '3') {
                    $('#BalanceSheet').hide();
                    $('#TrialBalance').hide();
                    $('#IncomeReport').hide();
                    $('#InternalTrialBalance').show();
                }
            })
        });
    </script>
</asp:Content>
