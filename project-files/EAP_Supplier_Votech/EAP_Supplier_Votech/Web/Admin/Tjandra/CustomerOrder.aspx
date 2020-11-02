<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="CustomerOrder.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.CustomerOrder" %>

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
                    <p class="display-4 text-center "><span class="text-success">Approved</span> Customer Orders</p>
                    <hr />
                </div>
            </div>
        </div>

    </header>


    <main>
        <div class="container justify-content-center">

            <div class="container">
                <div class="mb-3 form-inline py-2 shadow bg-light">
                    <asp:TextBox ID="tb_SearchName" runat="server" CssClass="form-control mr-sm-2 ml-2" placeholder="Enter company name" CausesValidation="false"></asp:TextBox>
                    <asp:Button ID="btn_SearchName" runat="server" Text="Search" CssClass="btn btn-success my-2 my-sm-0  d-inline mr-2" OnClick="btn_SearchName_Click" />

                    <asp:DropDownList ID="ddl_Status" runat="server" CssClass="btn btn-dark dropdown-toggle mr-2" AutoPostBack="true" OnSelectedIndexChanged="ddl_Status_SelectedIndexChanged">
                        <asp:ListItem>Pending</asp:ListItem>
                        <asp:ListItem>Delivered</asp:ListItem>
                    </asp:DropDownList>

                    <asp:DropDownList ID="ddl_PaymentStatus" runat="server" CssClass="btn btn-info dropdown-toggle" AutoPostBack="true" OnSelectedIndexChanged="ddl_PaymentStatus_SelectedIndexChanged">
                        <asp:ListItem>Pending</asp:ListItem>
                        <asp:ListItem>Paid</asp:ListItem>
                    </asp:DropDownList>

                    <asp:Button ID="btn_Archived" runat="server" Text="Archived" CssClass="btn btn-warning my-2 my-sm-0 d-inline ml-2 float-right" OnClick="btn_Archived_Click" />

                    <asp:Button ID="btn_CompletedOrder" runat="server" Text="Completed" CssClass="btn btn-danger my-2 my-sm-0 d-inline ml-2 float-right" OnClick="btn_CompletedOrder_Click" />

                    <asp:Button ID="btn_Refresh" runat="server" Text="Refresh" CssClass="btn btn-primary my-2 my-sm-0 d-inline ml-2 float-right" OnClick="btn_Refresh_Click" />

                </div>

                <asp:GridView ID="gv_CustomerOrder" runat="server" AutoGenerateColumns="False" DataKeyNames="CO_ID" CssClass="table shadow table-light border-0 table-condensed table-responsive table-hover mb-5" AllowPaging="True" OnPageIndexChanging="gv_CustomerOrder_PageIndexChanging" PageSize="5" OnRowDeleting="gv_CustomerOrder_RowDeleting" OnRowCancelingEdit="gv_CustomerOrder_RowCancelingEdit" OnRowEditing="gv_CustomerOrder_RowEditing" OnRowUpdating="gv_CustomerOrder_RowUpdating" OnSelectedIndexChanged="gv_CustomerOrder_SelectedIndexChanged" BackColor="White" BorderColor="Black" BorderStyle="Solid">
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
                        <asp:TemplateField HeaderText="Note" HeaderStyle-Width="30%">
                            <EditItemTemplate>
                                <asp:TextBox ID="tb_AdminComment" runat="server" Text='<%# Bind("CO_AdminComment") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_AdminComment" runat="server" Text='<%# Bind("CO_AdminComment") %>'></asp:Label>
                            </ItemTemplate>
                            <HeaderStyle Width="30%"></HeaderStyle>
                        </asp:TemplateField>
                        <asp:BoundField DataField="CO_DeliveryStatus" HeaderText="Delivery Status" ReadOnly="True" />
                        <asp:BoundField DataField="CO_PaymentStatus" HeaderText="Payment Status" ReadOnly="True" />

                        <asp:CommandField SelectText="View" ShowSelectButton="True" />
                        <asp:CommandField ShowEditButton="True" EditText="Comment" DeleteText="Archive" />
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="LinkButton1" runat="server" CausesValidation="False" CommandName="Delete" Text="Archive" OnClientClick="return confirm('Are you sure to archive?')"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>

                    </Columns>
                </asp:GridView>






            </div>
        </div>
    </main>





</asp:Content>
