<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="ListOfSupplierInvoice.aspx.cs" Inherits="EAP_Company_FixTech.Web.Admin.TrackingOfPaymentStatus" %>
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
                <p class="display-4 text-center ">List of Supplier Invoice</p>
            </div>
        </div>
     </header>
     <main>
        <div class="container-fluid mt-4 ">
            <div class="container">

            <asp:GridView ID="gv_PaymentStatus" runat="server" AutoGenerateColumns="False" onrowcommand="gv_PaymentStatus_RowCommand">
                <Columns>
                    <asp:BoundField DataField="CO_ID" HeaderText="Customer Order ID" ReadOnly="True" />
                    <asp:BoundField DataField="InvoiceNum" HeaderText="Invoice Number Reference" ReadOnly="True" />
                    <asp:BoundField DataField="InvoiceDate" HeaderText="Date when Invoice is Sent" ReadOnly="True" />
                    <asp:BoundField DataField="InvoiceTotalAmt" HeaderText="Total amount to pay" ReadOnly="True" />
                    <asp:BoundField DataField="InvoiceStatus" HeaderText="Invoice Status" ReadOnly="True" />
                    <asp:BoundField DataField="CO_CompanyName" HeaderText="Company Name" ReadOnly="True" />
                    <asp:BoundField DataField="CO_Date" HeaderText="Date when company make purchase order" ReadOnly="True" />
                    <asp:BoundField DataField="Co_CompanyEmail" HeaderText="Company Email" ReadOnly="True" />
                    <asp:BoundField DataField="CO_CompanyContact" HeaderText="Company Contact Number" />
                    <asp:TemplateField HeaderText="Payment Status">
                        <EditItemTemplate>
                            <asp:TextBox ID="txtCOPaymentStatus" runat="server" Text='<%# Bind("CO_PaymentStatus") %>'></asp:TextBox>
                        </EditItemTemplate>
                        <ItemTemplate>
                            <asp:Label ID="lblCOPaymentStatus" Text='<%# Bind("CO_PaymentStatus") %>'  runat="server"/>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="View Purchase Order Items" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="View Invoice" Text="View Invoice"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                    <asp:TemplateField HeaderText="Payment" ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton2" runat="server" CausesValidation="False" CommandName="Pay" Text="Pay"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
               </div>
           </div>
     </main>

</asp:Content>
