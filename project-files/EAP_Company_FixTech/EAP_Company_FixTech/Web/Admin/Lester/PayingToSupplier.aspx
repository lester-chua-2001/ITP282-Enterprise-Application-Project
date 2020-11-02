<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="PayingToSupplier.aspx.cs" Inherits="EAP_Company_FixTech.Web.Admin.PayingToSupplier" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style>
        @import url('https://fonts.googleapis.com/css?family=Acme|Lobster|Patua+One|Rubik|Sniglet&display=swap');

        @import url('https://fonts.googleapis.com/css?family=Luckiest+Guy|Open+Sans|Pacifico|Permanent+Marker|Roboto|Volkhov&display=swap');

        @import url('https://fonts.googleapis.com/css?family=Cinzel|Cinzel+Decorative|Hind+Madurai|Lalezar|Nanum+Myeongjo&display=swap');

        /* GLOBAL */
        :root {
            --Snigle-font: "Sniglet", cursive;
            --Rubik: "Rubik", cursive;
            --Patua: "Patua One", cursive;
            --Lobster: "Lobster", cursive;
            --Roboto: 'Roboto', sans-serif;
            --OpenSans: 'Open Sans', sans-serif;
        }

        main {
            font-family: var(--OpenSans);
        }
    </style>
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
       <header>

        <div class="title">
            <div class="container-fluid ">
                <p class="display-4 text-center ">Payment</p>
            </div>
        </div>

    </header>
    <main>
        <div class="container-fluid mt-4 ">
        <div class="container-fluid ">
                <div class="container">


                    <div class="row ">
                        <div class="col-md-6">

                            <div class="form-group row mt-5">
                                <label for="inputPassword" class="col-sm-3 col-form-label">Invoice Number</label>
                                <div class="col-sm-9">
                                    <asp:TextBox ID="tb_InvoiceNum" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row mt-4">
                                <label for="inputPassword" class="col-sm-3 col-form-label">Payment Date</label>
                                <div class="col-sm-9">
                                    <asp:TextBox ID="tb_PaymentDate" runat="server"></asp:TextBox>
                                    <asp:Calendar ID="CalPaymentDate" runat="server" OnSelectionChanged="CalPaymentDate_SelectionChanged" OnDayRender="CalPaymentDate_DayRender"></asp:Calendar>
                                </div>
                            </div>
                            <div class="form-group row mt-4">
                                <label for="inputPassword" class="col-sm-3 col-form-label">Cheque Number</label>
                                <div class="col-sm-9">
                                    <asp:TextBox ID="tb_ChequeNo" runat="server" CssClass="form-control" maxlength="6"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="inputPassword" class="col-sm-3 col-form-label">Payment Amount</label>
                                <div class="col-sm-9">
                                    <asp:TextBox ID="tb_PaymentAmount" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="inputPassword" class="col-sm-3 col-form-label">Payee</label>
                                <div class="col-sm-9">
                                    <asp:TextBox ID="tb_Payee" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <label for="inputPassword" class="col-sm-3 col-form-label">Memo</label>
                                <div class="col-sm-9">
                                    <asp:TextBox ID="tb_Memo" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="col-sm-9">
                                    <asp:Button ID="btn_Back" runat="server" Text="Back" CssClass="btn btn-secondary d-inline mr-3 px-5 float-left" OnClick="btn_Back_Click"/>
                                    <asp:Button ID="btn_Pay" runat="server" Text="Pay" CssClass="btn btn-success d-inline px-5 float-right" OnClick="btn_Pay_Click"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           </div>
        </main>
</asp:Content>
