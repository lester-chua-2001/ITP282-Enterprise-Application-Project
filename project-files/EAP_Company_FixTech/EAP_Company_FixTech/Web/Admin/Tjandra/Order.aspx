<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="Order.aspx.cs" Inherits="EAP_Company_FixTech.Web.Admin.Order" %>

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
                    <p class="display-4 text-center ">Create a purchase order</p>
                </div>
            </div>

        </header>

        <main>
            <div class="container-fluid mt-4 ">
                <div class="container">

                    <div class="row">
                        <div class="col-md-6 form-group">
                            <label for="" class="font-weight-bold">Enterprise</label>
                            <asp:TextBox ID="tb_CompanyName" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                            <label for="" class="font-weight-bold">Email</label>
                            <asp:TextBox ID="tb_CompanyEmail" runat="server" CssClass="form-control mb-3" required="required"></asp:TextBox>

                            <label for="" class="font-weight-bold">Contact</label>
                            <asp:TextBox ID="tb_CompanyContact" runat="server" CssClass="form-control mb-3" required="required"></asp:TextBox>

                            <label for="" class="font-weight-bold">Address</label>
                            <asp:TextBox ID="tb_CompanyAddress" runat="server" CssClass="form-control mb-3" required="required"></asp:TextBox>

                            <div class="row mt-3">
                                <div class="col-md-12">
<%--                                    <asp:Button ID="btn_Back" runat="server" Text="Product Catalog" CssClass="btn btn-success float-left " OnClick="btn_Back_Click" />--%>
                                    <asp:Button ID="btn_CreateOrder" runat="server" Text="Create Order" CssClass="btn btn-warning float-right" OnClick="btn_CreateOrder_Click" />
                                </div>
                            </div>
                        </div>

                        <div class="col-md-6 form-group">
                            <p class="font-weight-bold">Product Catalog</p>
                            
                        <asp:GridView ID="gv_OrderItem" runat="server" AutoGenerateColumns="False" DataKeyNames="ProdID" CssClass="table table-striped table-light table-condensed table-responsive border-0" AllowPaging="True" OnPageIndexChanging="gv_OrderItem_PageIndexChanging" PageSize="1" OnSelectedIndexChanged="gv_OrderItem_SelectedIndexChanged">
                            <Columns>
                <asp:BoundField DataField="ProdId" HeaderText="Product ID" />
                <asp:BoundField DataField="ProdName" HeaderText="Name" />
                <asp:BoundField DataField="ProdDesc" HeaderText="Description" />
                <asp:BoundField DataField="ProdPrice" HeaderText="Price" />
                                <asp:TemplateField ShowHeader="False">
                                    <ItemTemplate>
                                        <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Select" Text="Select" OnClientClick="return confirm('Confirm to purchase>');"></asp:LinkButton>
                                    </ItemTemplate>
                                </asp:TemplateField>
            </Columns>
                        </asp:GridView>
                        </div>


                    </div>

                </div>
            </div>
        </main>

        
        <script > function alertMe() {
     Swal.fire('Successful!', 'Order has been created!', 'success');
 }

        </script> 
        <script src="https://cdn.jsdelivr.net/npm/sweetalert2@9" > </script >



    </asp:Content>
