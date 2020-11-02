<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="PurchaseOrder.aspx.cs" Inherits="EAP_Company_FixTech.Web.Admin.PurchaseOrder" %>

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
                <p class="display-4 text-center "><span class="text-success">All</span> Purchase Order</p>
            </div>
        </div>

    </header>

    <main>
        <div class="container-fluid mt-4 ">
            <div class="container">

                <asp:GridView ID="gv_PurchaseOrder" runat="server" AutoGenerateColumns="False" DataKeyNames="PO_ID" CssClass="table shadow table-light border-0 table-condensed table-responsive table-hover mb-5" OnRowUpdating="gv_PurchaseOrder_RowUpdating" AllowPaging="True" OnRowDeleting="gv_PurchaseOrder_RowDeleting" OnRowEditing="gv_PurchaseOrder_RowEditing" OnRowCancelingEdit="gv_PurchaseOrder_RowCancelingEdit"  OnPageIndexChanging="gv_PurchaseOrder_PageIndexChanging" PageSize="5" OnSelectedIndexChanged="gv_PurchaseOrder_SelectedIndexChanged">
                    <HeaderStyle
                        BackColor="#606060"
                        Height="35"
                        ForeColor="White"
                        Font-Bold="True" />
                    <Columns>
                        <asp:BoundField DataField="PO_ID" HeaderText="Purchase Order ID" ReadOnly="True">
                            <HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>

                        <asp:BoundField DataField="PO_Date" HeaderText="Date Created" ReadOnly="True">
                            <HeaderStyle Width="20%"></HeaderStyle>
                        </asp:BoundField>

                        <asp:TemplateField HeaderText="Note">
                            <EditItemTemplate>
                                <asp:TextBox ID="tb_AdminComment" runat="server" Text='<%# Bind("PO_AdminComment") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="Label1" runat="server" Text='<%# Bind("PO_AdminComment") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="30%" />
                        </asp:TemplateField>
                        <asp:CommandField ShowEditButton="True" />
                        <asp:CommandField ShowDeleteButton="True" />

                        <asp:CommandField SelectText="View" ShowSelectButton="True" />

                    </Columns>
                </asp:GridView>


            </div>
        </div>
    </main>















</asp:Content>
