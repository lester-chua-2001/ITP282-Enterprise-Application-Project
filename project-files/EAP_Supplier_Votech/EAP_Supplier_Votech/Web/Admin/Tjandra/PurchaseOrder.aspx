<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="PurchaseOrder.aspx.cs" Inherits="EAP_Supplier_Votech.Web.PurchaseOrder" %>

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
                    <p class="display-4 text-center "><span class="text-success">Process</span> Purchase Orders</p>
                    <hr />
                </div>
            </div>
        </div>

    </header>

    <main>
        <div class="container justify-content-center">

            <div class="container">
                <div class="mb-3 form-inline py-2 shadow">
                    <asp:TextBox ID="tb_SearchName" runat="server" CssClass="form-control mr-sm-2 ml-2" placeholder="Enter company name" required="required"></asp:TextBox>
                    <asp:Button ID="btn_SearchName" runat="server" Text="Search" CssClass="btn btn-success my-2 my-sm-0  d-inline" OnClick="btn_SearchName_Click" />


                    <asp:DropDownList ID="ddl_ProcessStatus" runat="server" CssClass="btn btn-info dropdown-toggle ml-2" AutoPostBack="true" OnSelectedIndexChanged="ddl_ProcessStatus_SelectedIndexChanged">
                        <asp:ListItem>Pending</asp:ListItem>
                        <asp:ListItem>Rejected</asp:ListItem>
                        <asp:ListItem>Accepted</asp:ListItem>
                    </asp:DropDownList>


                    <asp:Button ID="btn_Refresh" runat="server" Text="Refresh" CssClass="btn btn-warning my-2 my-sm-0 d-inline ml-2 float-right" OnClick="btn_Refresh_Click" />
                </div>

                <asp:GridView ID="gv_PurchaseOrder" runat="server" AutoGenerateColumns="False" DataKeyNames="PO_ID" CssClass="table shadow table-light border-0 table-condensed table-responsive table-hover mb-5"
                    OnRowDeleting="gv_PurchaseOrder_RowDeleting"
                    OnRowCancelingEdit="gv_PurchaseOrder_RowCancelingEdit"
                    OnRowEditing="gv_PurchaseOrder_RowEditing"
                    OnRowUpdating="gv_PurchaseOrder_RowUpdating" AllowPaging="True"
                    OnPageIndexChanging="gv_PurchaseOrder_PageIndexChanging" PageSize="5" OnSelectedIndexChanged="gv_PurchaseOrder_SelectedIndexChanged">
                    <HeaderStyle
                        BackColor="#606060"
                        Height="35"
                        ForeColor="White"
                        Font-Bold="True" />
                    <Columns>
                        <asp:BoundField DataField="PO_ID" HeaderText="Purchase Order ID" SortExpression="PO_ID" ReadOnly="True" HeaderStyle-Width="5%">
                            <HeaderStyle Width="5%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="PO_Date" HeaderText="Date Created" SortExpression="PO_Date" ReadOnly="True" HeaderStyle-Width="20%">
                            <HeaderStyle Width="20%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:BoundField DataField="PO_CompanyName" HeaderText="Recipient Company" SortExpression="PO_CompanyName" ReadOnly="True" HeaderStyle-Width="15%">
                            <HeaderStyle Width="15%"></HeaderStyle>
                        </asp:BoundField>
                        <asp:TemplateField HeaderText="Note" SortExpression="PO_AdminComment" HeaderStyle-Width="30%">
                            <EditItemTemplate>
                                <asp:TextBox ID="tb_AdminComment" runat="server" Text='<%# Bind("PO_AdminComment") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_AdminComment" runat="server" Text='<%# Bind("PO_AdminComment") %>'></asp:Label>
                            </ItemTemplate>

                            <HeaderStyle Width="30%"></HeaderStyle>
                        </asp:TemplateField>
                        <asp:BoundField DataField="PO_ProcessStatus" HeaderText="Process Status" ReadOnly="True" />
                        <asp:CommandField SelectText="View" ShowSelectButton="True" />
                        <asp:CommandField ShowEditButton="True" EditText="Comment" />
                        <asp:TemplateField ShowHeader="False">
                            <ItemTemplate>
                                <asp:LinkButton ID="lbl_Delete" runat="server" CausesValidation="False" CommandName="Delete" Text="Reject" OnClientClick="return confirm('Are you sure to reject?')"></asp:LinkButton>
                            </ItemTemplate>
                        </asp:TemplateField>
                    </Columns>
                </asp:GridView>
            </div>



        </div>
    </main>

    <script>

        //OnClientClick="javascript: return confirmation();"

        //function confirmation() {
        //    Swal.fire({
        //        title: 'Are you sure?',
        //        text: "You won't be able to revert this!",
        //        icon: 'warning',
        //        showCancelButton: true,
        //        confirmButtonColor: '#3085d6',
        //        cancelButtonColor: '#d33',
        //        confirmButtonText: 'Yes, delete it!'
        //    }).then((result) => {
        //        if (result.value) {
        //            Swal.fire(
        //              'Deleted!',
        //              'Your file has been deleted.',
        //              'success'
        //            )
        //        }
        //    })
        //}
    </script>

    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@9"></script>



</asp:Content>
