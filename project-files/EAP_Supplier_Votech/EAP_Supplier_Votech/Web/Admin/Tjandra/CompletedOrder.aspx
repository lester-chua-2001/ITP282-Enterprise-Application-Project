<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="CompletedOrder.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.Tjandra.CompletedOrder" %>

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
                    <p class="display-4 text-center "><span class="text-success">Completed</span> Customer Orders</p>
                    <hr />
                </div>
            </div>
        </div>

    </header>

    <main>
        <div class="container justify-content-center">

            <div class="mb-3 form-inline py-2 shadow bg-light">
                <asp:TextBox ID="tb_SearchName" runat="server" CssClass="form-control mr-sm-2 ml-2" placeholder="Enter company name" CausesValidation="false"></asp:TextBox>
                <asp:Button ID="btn_SearchName" runat="server" Text="Search" CssClass="btn btn-success my-2 my-sm-0  d-inline mr-2" OnClick="btn_SearchName_Click" />

                <asp:Button ID="btn_Excel" runat="server" Text="Export to Excel" CssClass="btn btn-warning my-2 my-sm-0 d-inline ml-2 float-right" OnClick="btn_Excel_Click"/>


                <asp:Button ID="btn_Refresh" runat="server" Text="Refresh" CssClass="btn btn-primary my-2 my-sm-0 d-inline ml-2 float-right" OnClick="btn_Refresh_Click" />

            </div>

            <asp:GridView ID="gv_CompletedOrder" runat="server" AutoGenerateColumns="False" DataKeyNames="CO_ID" CssClass="table shadow table-light border-0 table-condensed table-responsive table-hover mb-5" PageSize="5" BackColor="White" BorderColor="Black" BorderStyle="Solid">
                <HeaderStyle
                    BackColor="#606060"
                    Height="35"
                    ForeColor="White"
                    Font-Bold="True" />
                <Columns>
                    <asp:BoundField DataField="CO_ID" HeaderText="Customer Order ID" ReadOnly="True">
                        <HeaderStyle Width="5%"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="CO_Date" HeaderText="Date Created" ReadOnly="True">
                        <HeaderStyle Width="25%"></HeaderStyle>
                    </asp:BoundField>

                    <asp:BoundField DataField="CO_CompanyName" HeaderText="Recipient Company" ReadOnly="True">
                        <HeaderStyle Width="15%"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="PO_ID" HeaderText="Purchase Order ID" ReadOnly="True">
                        <HeaderStyle Width="5%"></HeaderStyle>
                    </asp:BoundField>

                    <asp:BoundField DataField="CO_AdminComment" HeaderText="Note" ReadOnly="True">
                        <HeaderStyle Width="30%"></HeaderStyle>
                    </asp:BoundField>

                    <asp:BoundField DataField="CO_DeliveryStatus" HeaderText="Delivery Status" ReadOnly="True" />
                    <asp:BoundField DataField="CO_PaymentStatus" HeaderText="Payment Status" ReadOnly="True" />


                </Columns>
            </asp:GridView>










        </div>
    </main>










</asp:Content>
