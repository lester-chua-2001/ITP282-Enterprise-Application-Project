<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="PaymentDetails.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.Lester.PaymentDetails" %>
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
                    <p class="display-4 text-center ">Payment Details</p>
                    <hr />
                </div>
            </div>
        </div>

    </header>

    <main>
        <div class="container justify-content-center">
            <div class="container">
        <asp:GridView ID="gv_PaymentDetails" runat="server" AutoGenerateColumns="False">
            <Columns>
                <asp:BoundField DataField="PaymentID" HeaderText="Payment Reference Number" />
                <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" />
                <asp:BoundField DataField="ChequeNo" HeaderText="Cheque Number" />
                <asp:BoundField DataField="PaymentAmount" HeaderText="Payment Amount" />
                <asp:BoundField DataField="Payee" HeaderText="Payee" />
                <asp:BoundField DataField="Memo" HeaderText="Memo" />
                <asp:BoundField DataField="InvoiceNum" HeaderText="Invoice Number " />
            </Columns>
     </asp:GridView>
                </div>
        </div>
    </main>
</asp:Content>
