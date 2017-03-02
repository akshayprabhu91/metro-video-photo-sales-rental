<%@ Page Title="" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Metro_Video_Photo_Fall_2016.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <link href="css/animate/animate.css" rel="stylesheet" />
    <link href="css/animate/set.css" rel="stylesheet" />
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <div id="myCarousel" class="carousel slide banner-slider animated bounceInDown" data-ride="carousel">
            <div class="carousel-inner">

                <div class="item">
                    <img src="images/back1.jpg" alt="banner" />
                </div>

                <div class="item active">
                    <img src="images/back2.jpg" alt="banner" />
                </div>

                <div class="item">
                    <img src="images/back3.jpg" alt="banner" />
                </div>

                <div class="item">
                    <img src="images/back4.jpg" alt="banner" />
                </div>

            </div>
            <a class="left carousel-control" href="#myCarousel" data-slide="prev"><span class="glyphicon-chevron-left"><i class="fa fa-angle-left"></i></span></a>
            <a class="right carousel-control" href="#myCarousel" data-slide="next"><span class="glyphicon-chevron-right"><i class="fa fa-angle-right"></i></span></a>
        </div>





    <div style="text-align: center; background-image: url('Images/lower.jpg'); background-repeat: no-repeat; display: block;" id="divMainBlk">
        <div class="pad25">

            <div>
                <div class="bold font22 ">
                    Login
                </div>
                <div class="mrgnT2">
                    <span class="bold">USERNAME:</span><input type="text" id="txtUsername" name="Username" runat="server" />
                </div>

                <div class="mrgnT2">
                    <span class="bold">PASSWORD:</span><input type="password" id="txtPassword" name="Password" runat="server" />
                </div>

                <div id="divLogin" class="mrgnT2" runat="server">
                    <asp:Button runat="server" Text="Login" OnClick="Login" />
                </div>

                <%--<div id="divSignIn" style="display: none;" class="mrgnT2" runat="server">
                    <div>
                        <span class="bold">CONFIRM PASSWORD:</span>
                        <input type="password" id="txtConfirmPassword" name="Password" runat="server" />
                    </div>

                    <div class="mrgnT2">
                        <asp:Button runat="server" Text="Sign In" OnClick="SignIn" />
                    </div>
                </div>--%>
            </div>
            <div class="mrgnT5">

                <asp:Label ID="lblError" runat="server" Style="display: none;color:#ff0000;font-weight:bold;font-size:20px;"></asp:Label>

            </div>
        </div>
    </div>

    <script>

        $(document).ready(function () {

            setTimeout(scrollToDiv, 200);

        });

        function scrollToDiv() {
            $('html,body').animate({
                scrollTop: $("#divMainBlk").offset().top
            });
        }

        function CheckSelection(a) {
            if (a == 1) // show login Fields
            {
                //$("#divLogin").show();
                //$("#divSignIn").hide();
                //$("#hdnBlock").val(1);
                location.href = "/Default.aspx?type=login";
            }
            else    // show Sign In Fields
            {
                //$("#divSignIn").show();
                //$("#divLogin").hide();
                //$("#hdnBlock").val(2);
                location.href = "/Default.aspx?type=signin";
            }
        }


    </script>
</asp:Content>
