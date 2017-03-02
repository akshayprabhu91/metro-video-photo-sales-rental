<%@ Control Language="C#" AutoEventWireup="true" CodeBehind="Applicaiton_UserControl.ascx.cs" Inherits="Metro_Video_Photo_Fall_2016.Controls.Applicaiton_UserControl" %>

<div>
    <div class="col-md-4 col-md-offset-4 col-sm-12 pad3">
        <span>
            <asp:Button CssClass="pad2" Style="border-radius:3px;" runat="server" OnClick="RedirectToHome" Text="Home" />
        </span>

        <span style="margin-left: 40px;">
            <input type="button" class="pad2" style="border-radius:3px;" onclick="GoBack()" value="Back" />
        </span>
    </div>
</div>


<script>


    function GoBack() {
        window.history.back();
    }


</script>

