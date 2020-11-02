<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="DeliveryOrder_View.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.DeliveryOrder_View" %>

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
                    <p class="display-4 text-center ">Delivery Order: Detailed <span class="text-success">View</span></p>
                    <hr />
                </div>
            </div>
        </div>
    </header>
    <body>
        <div class="container-fluid ">
            <div class="container">

                <div class="row">
                    <div class="col-md-6 form-group">
                        <label for="" class="font-weight-bold">Delivery Order ID</label>
                        <asp:TextBox ID="tb_DO_ID" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                        <label for="" class="font-weight-bold">Recipient Company</label>
                        <asp:TextBox ID="tb_CompanyName" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                        <label for="" class="font-weight-bold">Email</label>
                        <asp:TextBox ID="tb_CompanyEmail" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                        <label for="" class="font-weight-bold">Contact</label>
                        <asp:TextBox ID="tb_CompanyContact" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                        <label for="" class="font-weight-bold">Address</label>
                        <asp:TextBox ID="tb_CompanyAddress" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>


                        <asp:Button ID="btn_Back" runat="server" Text="Back" CssClass="btn btn-danger float-left px-5" OnClick="btn_Back_Click" />
                        <asp:Button ID="btn_MakePayment" runat="server" Text="Create Invoice" CssClass="btn btn-warning float-right" />
                    </div>
                    <div class="col-md-6 form-group">
                        <asp:GridView ID="gvDeliveryOrderItems" runat="server" AutoGenerateColumns="False" DataKeyNames="OI_ID" CssClass="table table-striped table-light table-condensed table-responsive border-0">
                            <Columns>
                                <asp:BoundField DataField="OI_ID" HeaderText="Order Item ID" />
                                <asp:BoundField DataField="OI_Name" HeaderText="Item Name" />
                                <asp:BoundField DataField="OI_Desc" HeaderText="Item Desc" />
                                <asp:BoundField DataField="OI_Qty" HeaderText="Qty" />
                                <asp:BoundField DataField="OI_Price" HeaderText="Price" />
                                <asp:BoundField DataField="OI_TotalAmount" HeaderText="Total Amount" />
                                <asp:BoundField DataField="ProdID" HeaderText="Product ID Reference" />
                            </Columns>
                        </asp:GridView>
                    </div>
    </body>
</asp:Content>
