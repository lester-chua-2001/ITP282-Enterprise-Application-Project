<%@ Page Title="" Language="C#" MasterPageFile="~/static/Master/Client/Client_Master_Page.master" AutoEventWireup="true" CodeFile="Index.aspx.cs" Inherits="Index" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="Server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">


    <!-- Chatra {literal} -->
    <%--  <script>
            (function (d, w, c) {
                w.ChatraID = 'BpRec6Z3xWdDgC3Hm';
                var s = d.createElement('script');
                w[c] = w[c] || function () {
                    (w[c].q = w[c].q || []).push(arguments);
                };
                s.async = true;
                s.src = 'https://call.chatra.io/chatra.js';
                if (d.head) d.head.appendChild(s);
            })(document, window, 'Chatra');
        </script>--%>
    <!-- /Chatra {/literal} -->



    <!-- Header -->
    <header class="bg-dark py-5 mb-5" style="background-image:url(../../../Img/home-banner.jpeg); background-repeat:no-repeat; background-size:cover; height: 400px;background-position:center;">
        <div class="container h-100">
            <div class="row h-100 align-items-center">
                <div class="col-lg-12">
                    <h1 class="display-3 text-white mt-5 mb-2">FixTech</h1>
                   
                    <p class="lead mb-5 text-white"style="width:55%">
                       &nbsp; Let us put you back in the industry
                    </p>
                </div>
            </div>
        </div>
    </header>

    <!-- Page Content -->
    <div class="container">

        <div class="row">
            <div class="col-md-8 mb-5">
                <h2>About Us</h2>
                <hr>
                <p>If you are looking for a computer repair shop in Singapore, then FixTech services is the company here to serve you</p>


                <p>FixTech is computer repair service company established in the year 2019. Since our inception in Singapore, Repair House has been dedicated to fixing and offering a diverse range of customized and efficient solutions directed towards solving the needs of its clients.
                    <br /><br /> With a core of empowered and committed employees at our shop, our company offers complete and high-quality repair services to medium and small corporate clients. Whether your personal computer (PC) needs repair services, you can depend on the Repair House team in Singapore to provide the best computer repair service for you.</p>
            </div>
            <div class="col-md-4 mb-5">
                <h2>Contact Us</h2>
                <hr>
                <address>
                    <strong>Information</strong>
                    <br>
                    56 Kallang Pudding Rd
                    <br>
                    #07-05/06, Singapore 349328

                    <br>
                </address>
                <address>
                    <i class="far fa-envelope"></i>&nbsp;(+65) 6874 5852
                    <br>
                    <i class="fas fa-phone"></i>&nbsp;
                    <a>FixTech@InfoTech.com</a>
                </address>
            </div>

        </div>
        <hr />
        <!-- /.row -->

         <div class="row mb-3 mt-5">
            <div class="col-md-12 text-center">
                <h2>SERVICES</h2>
                <p>We offer a full range of repair services provided by an experienced and specialized team</p>
            </div>
        </div>


        <div class="row justify-content-center mb-5">
            <div class="col-md-4">
                <div class="card text-center">
                    <img src="../../../Img/computer_repair.jpg" class="card-img-top" alt="..."  />
                    <div class="card-body">
                        <h5 class="card-title">Computer Repair</h5>
                        <p class="card-text text-muted">
                            We provide high-quality computer repair and service at affordable rates in the comforty and convenience.
                        </p>
                        <a href="#" class="btn btn-outline-primary px-4" style="border-radius: 0 !important;">View More</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card text-center">
                    <img src="../../../Img/mac_repair.jpg" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Mac Repair</h5>
                        <p class="card-text text-muted">
                            We provide service for Macbook, Macbookp pro, Macbook air, iMac and Mac mini. We prove repair and
                        </p>
                        <a href="#" class="btn btn-outline-primary px-4" style="border-radius: 0 !important;">View More</a>
                    </div>
                </div>
            </div>
            <div class="col-md-4">
                <div class="card text-center">
                    <img src="../../../Img/screen_repair.png" class="card-img-top" alt="...">
                    <div class="card-body">
                        <h5 class="card-title">Screen Replacement</h5>
                        <p class="card-text text-muted">
                            Our laptop screen repair service is quick. We are often able to replace a cracked or broken screen on the same
                        </p>
                        <a href="#" class="btn btn-outline-primary px-4" style="border-radius: 0 !important;">View More</a>
                    </div>
                </div>
            </div>
        </div>
        <!-- /.row -->

    </div>
    <!-- /.container -->

    <div class="container mb-4">
        <div class="row">
            <div class="col-md-12 text-center">
                <h2>WHY CHOOSE US</h2>
                <p>Some of our features</p>
            </div>
        </div>
        <div class="row mt-3">
            <div class="col-md-3">
                <div class="text-center">
<%--                    <i class="fas fa-rocket fa-3x mb-2"></i>--%>
                    <img src="../../../Img/piggy-bank.png" width="100" height="100" class="mb-3" />
                </div>
                <p>NO DIAGNOSIS CHARGE</p>

                <p class="text-muted ">
                    We provide FREE Diagnosis for your PC, Laptop and Mac issues at our
                    service
                    center.<%--you may bring
                    your PC or Laptop to our service center on working hours.--%>
                </p>
            </div>

            <div class="col-md-3">
                <div class="text-center">
                    <img src="../../../Img/bank.png" width="100" height="100" class="mb-3" />
                </div>
                <p>FIXED CHARGES</p>

                <p class="text-muted ">
                    Know what you will pay before you call us. A fixed rate for all our computer
                    repair services. <%--No matter how long it takes to fix your computer problem you pay only fixed price.--%>
                </p>
            </div>

            <div class="col-md-3">
                <div class="text-center">
                    <img src="../../../Img/calendar.png" width="100" height="100" class="mb-3" />
                </div>
                <p>WORK WARRANTY</p>

                <p class="text-muted ">
                    Our computer repair work comes with warranty from 1 to 6 months. <%--When we fix an
                    issue, it stays fixed, some cases, if there is a same issue with what we did then we solve it free
                    during warranty period.--%>
                </p>
            </div>

            <div class="col-md-3">
                <div class="text-center">
                    <img src="../../../Img/collaboration.png" width="100" height="100" class="mb-3" />
                </div>
                <p>
                    FREE REMOTE SUPPORT 30 DAYS
                </p>

                <p class="text-muted ">
                    We provide FREE remote support for up to 30 days from the day we repaired your
                    computer. <%--So, when there is recurrence in an issue, we provide remote support and solve it
                    instantaneously.--%>
                </p>
            </div>
        </div>
    </div>









</asp:Content>

