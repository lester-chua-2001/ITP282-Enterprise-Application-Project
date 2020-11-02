<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="PurchaseOrder_ViewMore.aspx.cs" Inherits="EAP_Company_FixTech.Web.Admin.Tjandra.PurchaseOrder_ViewMore" %>

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
                <p class="display-4 text-center "><span class="text-success">View</span> Purchase Order</p>
            </div>
        </div>

    </header>

    <main>
        <div class="container mt-4">
            <asp:GridView ID="gv_OrderItems" runat="server" AutoGenerateColumns="False" DataKeyNames="OI_ID" CssClass="table shadow table-light border-0 table-condensed table-responsive table-hover mb-1" ShowFooter="True">
                <HeaderStyle
                    BackColor="#606060"
                    Height="35"
                    ForeColor="White"
                    Font-Bold="True" />
                <Columns>
                    <asp:BoundField DataField="OI_ID" HeaderText="Order Item ID" />
                    <asp:BoundField DataField="OI_Name" HeaderText="Name" />
                    <asp:BoundField DataField="OI_Desc" HeaderText="Description" />
                    <asp:BoundField DataField="OI_Price" HeaderText="Price" />
                </Columns>
            </asp:GridView>

            <div class="float-right">
                <hr />
                <p>
                    <span class="font-weight-bold">Total Amount :   </span>$       
                <asp:Label ID="lbl_Total" runat="server" Text=""></asp:Label>
                </p>
                <hr />

            </div>
        </div>
    </main>








</asp:Content>
