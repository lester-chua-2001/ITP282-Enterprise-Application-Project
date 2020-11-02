<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="CustomerOrder_Archived.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.CustomerOrder_Archived" %>

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
                    <p class="display-4 text-center "><span class="text-success">Archived</span> Customer Orders</p>
                    <hr />
                </div>
            </div>
        </div>

    </header>


    <main>
        <div class="container justify-content-center">

            <div class="container  px-0">
                <div class="mb-3 form-inline py-2 shadow">
                    <asp:Button ID="btn_Back" runat="server" Text="Back" CssClass="btn btn-danger my-2 my-sm-0 d-inline ml-2 float-left" OnClick="btn_Back_Click" />

                </div>
            </div>

            <asp:GridView ID="gv_CustomerOrderArchived" CssClass="table shadow table-light border-0 table-condensed table-responsive table-hover mb-5" runat="server" AutoGenerateColumns="False" DataKeyNames="CO_ID" OnSelectedIndexChanged="gv_CustomerOrderArchived_SelectedIndexChanged" BackColor="White" BorderColor="Black" BorderStyle="Solid">
                <HeaderStyle
                    BackColor="#606060"
                    Height="35"
                    ForeColor="White"
                    Font-Bold="True" />
                <Columns>
                    <asp:BoundField DataField="CO_ID" HeaderText="Customer Order ID">
                        <HeaderStyle Width="5%"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="CO_Date" HeaderText="Created Date">
                        <HeaderStyle Width="20%"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="CO_CompanyName" HeaderText="Recipient Company">
                        <HeaderStyle Width="15%"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="PO_ID" HeaderText="Purchase Order ID">
                        <HeaderStyle Width="5%"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="CO_AdminComment" HeaderText="Note">
                        <HeaderStyle Width="30%"></HeaderStyle>
                    </asp:BoundField>
                    <asp:BoundField DataField="CO_DeliveryStatus" HeaderText="Delivery Status" />
                    <asp:BoundField DataField="CO_PaymentStatus" HeaderText="Payment Status" />
                    <asp:TemplateField ShowHeader="False">
                        <ItemTemplate>
                            <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Restore" OnClientClick="return confirm('Are you sure to restore?')"></asp:LinkButton>
                        </ItemTemplate>
                    </asp:TemplateField>
                </Columns>
            </asp:GridView>
        </div>
    </main>

</asp:Content>
