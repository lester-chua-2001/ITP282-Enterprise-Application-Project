<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="CreateInvoice.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.Lester.CreateInvoice" %>
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

        <div class="container">
            <div class="title">
                <div class="container-fluid">
                    <p class="display-4 text-center ">Create Invoice</p>
                    <hr />
                </div>
            </div>
        </div>

    </header>
     <main>
        <div class="container justify-content-center">
              <div class="container-fluid ">
                <div class="container">


                    <div class="row ">
                        <div class="col-md-6">

                            <div class="form-group row mt-5">
                                <label for="inputPassword" class="col-sm-3 col-form-label">Customer Order Reference</label>
                                <div class="col-sm-9">
                                    <asp:TextBox ID="tb_COID" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row mt-4">
                                <label for="inputPassword" class="col-sm-3 col-form-label">Invoice Creation Date</label>
                                <div class="col-sm-9">
                                    <asp:TextBox ID="tb_CreationDate" runat="server"></asp:TextBox>
                                    <asp:Calendar ID="CalCreationDate" runat="server" OnSelectionChanged="CalCreationDate_SelectionChanged" OnDayRender="CalCreationDate_DayRender"></asp:Calendar>
                                </div>
                            </div>
                            <div class="form-group row mt-4">
                                <label for="inputPassword" class="col-sm-3 col-form-label">Invoice Total Amount</label>
                                <div class="col-sm-9">
                                    <asp:TextBox ID="tb_InvoiceTotalAmt" runat="server" CssClass="form-control"></asp:TextBox>
                                </div>
                            </div>
                            <div class="form-group row">
                                <div class="col-sm-9">
                                    <asp:Button ID="btn_Back" runat="server" Text="Back" CssClass="btn btn-secondary d-inline mr-3 px-5 float-left" OnClick="btn_Back_Click"/>
                                    <asp:Button ID="btn_CreateInvoice" runat="server" Text="Create Invoice" CssClass="btn btn-success d-inline px-5 float-right" OnClick="btn_CreateInvoice_Click"/>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
           </div>
        </main>
</asp:Content>
