<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="dashboard.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Application.Payroll.dashboard" %>
<%@ Register Src="~/Controls/Applicaiton_UserControl.ascx" TagPrefix="uc1" TagName="Applicaiton_UserControl" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    
    <div class="container">
        <h2 class="text-center">Payroll</h2>
        <br /><br />

            
        

    
        <div class="row text-center">
                            <div class='tableauPlaceholder' id='viz1480208890146' style='position: relative'>


       <noscript>
           <a href='#'>
               <img alt='PayRoll Dashboard ' src='https:&#47;&#47;public.tableau.com&#47;static&#47;images&#47;Pa&#47;PayRollDashboard&#47;Sheet6&#47;1_rss.png' style='border: none' />

           </a>

       </noscript>
       <object class='tableauViz'  style='display:none;'>
           <param name='host_url' value='https%3A%2F%2Fpublic.tableau.com%2F' /> 
           <param name='site_root' value='' />
           <param name='name' value='PayRollDashboard&#47;Sheet6' />
           <param name='tabs' value='no' />
           <param name='toolbar' value='yes' />
           <param name='static_image' value='https:&#47;&#47;public.tableau.com&#47;static&#47;images&#47;Pa&#47;PayRollDashboard&#47;Sheet6&#47;1.png' />
            <param name='animate_transition' value='yes' />
           <param name='display_static_image' value='yes' />
           <param name='display_spinner' value='yes' />
           <param name='display_overlay' value='yes' />
           <param name='display_count' value='yes' />

       </object>

   </div> 
            </div>
        <br /><br />
        <div class="row text-center">
            <uc1:Applicaiton_UserControl runat="server" ID="Applicaiton_UserControl" HomeUrl="/Application/Payroll/Default.aspx" />
        </div>
        </div>
                       
    <script type='text/javascript'>
        var divElement = document.getElementById('viz1480208890146');
        var vizElement = divElement.getElementsByTagName('object')[0];
        vizElement.style.width = '100%';
        vizElement.style.height = (divElement.offsetWidth * 0.75) + 'px';
        var scriptElement = document.createElement('script');
        scriptElement.src = 'https://public.tableau.com/javascripts/api/viz_v1.js';
        vizElement.parentNode.insertBefore(scriptElement, vizElement);

    </script>
</asp:Content>
