<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="PurchaseOrder_ViewMore.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.PurchaseOrder_ViewMore" %>

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
                    <p class="display-4 text-center ">Purchase Order : Detailed <span class="text-success">View</span></p>
                    <hr />
                </div>
            </div>
        </div>

    </header>

    <main>

        <div class="container-fluid ">
            <div class="container">

                <div class="row">
                    <div class="col-md-6 form-group">
                        <label for="" class="font-weight-bold">Purchase Order ID</label>
                        <asp:TextBox ID="tb_PO_ID" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                        <label for="" class="font-weight-bold">Enterprise</label>
                        <asp:TextBox ID="tb_CompanyName" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                        <label for="" class="font-weight-bold">Email</label>
                        <asp:TextBox ID="tb_PO_CompanyEmail" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                        <label for="" class="font-weight-bold">Contact</label>
                        <asp:TextBox ID="tb_CompanyContact" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                        <label for="" class="font-weight-bold">Address</label>
                        <asp:TextBox ID="tb_CompanyAddress" runat="server" CssClass="form-control mb-3" ReadOnly="true"></asp:TextBox>

                        <asp:Button ID="btn_Back" runat="server" Text="Back" CssClass="btn btn-danger float-left px-5" OnClick="btn_Back_Click" />
                        <asp:Button ID="btn_CreateOrder" runat="server" Text="Create Order" CssClass="btn btn-warning float-right" OnClick="btn_CreateOrder_Click" />

                        <input type="button" id="btnAddNewClass" class="btn btn-info  float-right mx-2 " data-toggle="modal" data-target="#pnlAddClassModal" value="Email" style="padding-left: 36px; padding-right: 36px;" />

                        <asp:Panel ID="pnlAddClassModal" runat="server" role="dialog" ClientIDMode="Static" CssClass="modal fade">
                            <asp:Panel ID="pnlInner" runat="server" CssClass="modal-dialog">
                                <asp:Panel ID="pnlContent" CssClass="modal-content" runat="server">
                                    <asp:Panel runat="server" class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel">
                                            <span class="font-weight-bold">To</span> :
                                            <asp:Label ID="lbl_To" runat="server" Text="Label"></asp:Label>

                                        </h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>

                                    </asp:Panel>
                                    <asp:Panel runat="server" class="modal-body">

                                        <div id="pnlAddClass">
                                            <div class="panel panel-default">
                                                <div class="panel-heading">
                                                    <h4 class="panel-title">
                                                        <%--                                                        <a data-toggle="collapse" data-parent="#pnlAddClass" href="#pnlAddClassBody">New Class Info</a>--%>
                                                    </h4>
                                                </div>
                                                <div id="pnlAddClassBody">
                                                    <div class="panel-body">
                                                        <label for="">Subject</label>
                                                        <asp:TextBox ID="tb_subject" runat="server" CssClass="form-control"></asp:TextBox>

                                                        <label for="">Body</label>
                                                        <asp:TextBox ID="tb_body" runat="server" CssClass="form-control" Height="220px"></asp:TextBox>

                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                    </asp:Panel>
                                    <asp:Panel runat="server" class="modal-footer">
                                        <div class="container">

                                            <button type="button" class="btn btn-secondary float-left" data-dismiss="modal" style="padding-left: 36px; padding-right: 36px;">Cancel</button>
                                            <asp:Button ID="btn_send" runat="server" Text="Send" CssClass="btn btn-success float-right" Style="padding-left: 36px; padding-right: 36px;" OnClick="btn_send_Click" />
                                        </div>
                                    </asp:Panel>
                                </asp:Panel>
                            </asp:Panel>
                        </asp:Panel>



                    </div>




                    <div class="col-md-6 form-group">
                        <p class="font-weight-bold">Order Items</p>

                        <asp:GridView ID="gv_OrderItem" runat="server" AutoGenerateColumns="False" DataKeyNames="OI_ID" CssClass="table table-striped table-light table-condensed table-responsive border-0" AllowPaging="True" OnPageIndexChanging="gv_OrderItem_PageIndexChanging" PageSize="2" ShowFooter="True">
                            <Columns>
                                <asp:BoundField DataField="OI_ID" HeaderText="OI_ID" />
<%--                                <asp:BoundField DataField="OI_TotalAmount" HeaderText="Total Amount" />--%>
                                <asp:BoundField DataField="OI_Name" HeaderText="Item Name" />
                                <asp:BoundField DataField="OI_Desc" HeaderText="Item Desc" />
                                <asp:BoundField DataField="OI_Price" HeaderText="Price" DataFormatString="{0:C}" />
                        <%--        <asp:BoundField DataField="OI_Qty" HeaderText="Qty" />
                                <asp:BoundField DataField="ProdID" HeaderText="ProdID" />--%>
                            </Columns>
                        </asp:GridView>
                    </div>

                </div>


                <div class="row mt-3">
                    <div class="col-md-12">











                        <!-- Modal -->
                        <%-- <div class="modal fade" id="exampleModal" tabindex="-1" role="dialog" aria-labelledby="exampleModalLabel" aria-hidden="true">
                            <div class="modal-dialog" role="document">
                                <div class="modal-content">
                                    <div class="modal-header">
                                        <h5 class="modal-title" id="exampleModalLabel">
                                            <span class="font-weight-bold">To</span> :
                                            <asp:Label ID="lbl_To" runat="server" Text="Label"></asp:Label>

                                        </h5>
                                        <button type="button" class="close" data-dismiss="modal" aria-label="Close">
                                            <span aria-hidden="true">&times;</span>
                                        </button>
                                    </div>
                                    <div class="modal-body">

                                        <div class="form-group">
                                            <label for="exampleFormControlTextarea1">Subject</label>
                                            <asp:TextBox ID="tb_subject" runat="server" CssClass="form-control" required="required"></asp:TextBox>

                                            <label for="exampleFormControlTextarea1">Body</label>
                                            <asp:TextBox ID="tb_body" runat="server" CssClass="form-control" Height="220px" required="required"></asp:TextBox>
                                        </div>

                                    </div>
                                    <div class="modal-footer">
                                        <div class="container">

                                            <button type="button" class="btn btn-secondary float-left" data-dismiss="modal" style="padding-left: 36px; padding-right: 36px;">Cancel</button>
                                            <asp:Button ID="btn_send" runat="server" Text="Send" CssClass="btn btn-success float-right" Style="padding-left: 36px; padding-right: 36px;" OnClick="btn_send_Click" />
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>--%>
                    </div>
                </div>


            </div>
        </div>
    </main>

    <script>
        function alertMe() {
            Swal.fire(
      'Successful!',
      'Order has been created!',
      'success'
    )
        }

        function alertMe2() {
            Swal.fire(
      'Successful!',
      'Email has been sent!',
      'success'
    )
        }
    </script>

    <script src="https://cdn.jsdelivr.net/npm/sweetalert2@9"></script>



</asp:Content>
