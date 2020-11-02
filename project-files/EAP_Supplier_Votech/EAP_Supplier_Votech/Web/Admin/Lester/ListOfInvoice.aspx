<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="ListOfInvoice.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.PaymentStatus" %>

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
                    <p class="display-4 text-center ">List of Invoice</p>
                    <hr />
                </div>
            </div>
        </div>
    </header>
    <main>
        <div class="container justify-content-center">
            <div class="container">
                <div class="mb-3 form-inline py-2 shadow bg-light">
                    <asp:TextBox ID="tb_search" runat="server" CssClass="form-control mr-sm-2 ml-2" placeholder="Enter company name" CausesValidation="false"></asp:TextBox>
                    <asp:Button ID="btn_search" runat="server" Text="Search" CssClass="btn btn-success my-2 my-sm-0  d-inline mr-2" OnClick="btn_search_Click"/>
                    <asp:Button ID="btn_Refresh" runat="server" Text="Refresh" CssClass="btn btn-primary my-2 my-sm-0 d-inline ml-2 float-right" OnClick="btn_Refresh_Click" />
                </div>


                <asp:GridView ID="gv_PaymentStatus" runat="server" AutoGenerateColumns="False" OnRowUpdating="gv_PaymentStatus_RowUpdating" OnRowCancelingEdit="gv_PaymentStatus_RowCancelingEdit" OnRowEditing="gv_PaymentStatus_RowEditing" DataKeyNames="CO_ID" OnSelectedIndexChanged="gv_PaymentStatus_SelectedIndexChanged" CssClass="table shadow table-light border-0 table-condensed table-responsive table-hover mb-5">
                    <HeaderStyle
                        BackColor="#606060"
                        Height="35"
                        ForeColor="White"
                        Font-Bold="True" />
                    <Columns>
                        <asp:BoundField DataField="CO_ID" HeaderText="Customer Order ID" ReadOnly="True" />
                        <asp:BoundField DataField="InvoiceNum" HeaderText="Invoice Number Reference" ReadOnly="True" />
                        <asp:BoundField DataField="InvoiceDate" HeaderText="Invoice Creation Date" ReadOnly="True" />
                        <asp:BoundField DataField="InvoiceTotalAmt" HeaderText="Total amount to pay" ReadOnly="True" />
                        <asp:BoundField DataField="InvoiceStatus" HeaderText="Invoice Status" ReadOnly="True" />
                        <asp:BoundField DataField="CO_CompanyName" HeaderText="Company Name" ReadOnly="True" />
                        <asp:BoundField DataField="CO_Date" HeaderText="Company Purchase Order Date" ReadOnly="True" />
                        <asp:BoundField DataField="CO_CompanyEmail" HeaderText="Company Email" ReadOnly="True" />
                        <asp:BoundField DataField="CO_CompanyContact" HeaderText="Company Contact Number" />
                        <asp:TemplateField HeaderText="Payment Status">
                            <EditItemTemplate>
                                <asp:TextBox ID="txtCOPaymentStatus" runat="server" Text='<%# Bind("CO_PaymentStatus") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lblCOPaymentStatus" Text='<%# Bind("CO_PaymentStatus") %>' runat="server" />
                            </ItemTemplate>
                        </asp:TemplateField>
                        <asp:CommandField HeaderText="View Order items " SelectText="View More" ShowSelectButton="True" />
                        <asp:CommandField EditText="Update Status" HeaderText="Update Payment Status " ShowEditButton="True" />
                    </Columns>
                </asp:GridView>
            </div>
        </div>
    </main>

</asp:Content>
