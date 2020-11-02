<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="GetDeliveryOrder.aspx.cs" Inherits="EAP_Company_FixTech.Web.Admin.GetDeliveryOrder" %>

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
                <p class="display-4 text-center ">Retrieve Delivery Order</p>
            </div>
        </div>
    </header>

    <div class="container-fluid mt-4 ">
        <div class="container">

            <%--<div class="row">
                <div class="col-md-6 form-group">
                    <label for="" class="font-weight-bold">Delivery Order ID</label>
                    <asp:TextBox ID="tb_DO_ID" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                    <label for="" class="font-weight-bold">Recipient Company</label>
                    <asp:TextBox ID="tb_CompanyName" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                    <label for="" class="font-weight-bold">Company Email</label>
                    <asp:TextBox ID="tb_CompanyEmail" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                    <label for="" class="font-weight-bold">Address</label>
                    <asp:TextBox ID="tb_CompanyAddress" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                    <label for="" class="font-weight-bold">Contact</label>
                    <asp:TextBox ID="tb_CompanyContact" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                    <label for="" class="font-weight-bold">Date</label>
                    <asp:TextBox ID="tb_DO_Date" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                    <label for="" class="font-weight-bold">Customer Order ID</label>
                    <asp:TextBox ID="tb_CO_ID" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                    <label for="" class="font-weight-bold">Remarks</label>
                    <asp:TextBox ID="tb_DO_Remarks" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                    <div class="row mt-3">
                        <div class="col-md-12">
                            <asp:Button ID="btn_Back" runat="server" Text="Back" CssClass="btn btn-danger float-left " />
                        </div>
                    </div>
                </div>--%>

                <div class="col-md-6 form-group">
                    <asp:GridView ID="gvDeliveryOrderItems" runat="server" AutoGenerateColumns="False" CssClass="table table-striped table-light table-condensed table-responsive border-0" DataKeyNames="OI_ID">
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
            </div>
        </div>
    </div>
</asp:Content>
