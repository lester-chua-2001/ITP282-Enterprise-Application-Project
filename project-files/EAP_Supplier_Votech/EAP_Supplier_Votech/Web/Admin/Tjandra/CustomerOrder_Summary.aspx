<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="CustomerOrder_Summary.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.PurchaseOrder_Summary" EnableEventValidation="false" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Votech</title>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <meta http-equiv="X-UA-Compatible" content="ie=edge">

    <link rel="stylesheet" href="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/css/bootstrap.min.css"
        integrity="sha384-Vkoo8x4CGsO3+Hhxv8T/Q5PaXtkKtu6ug5TOeNV6gBiFeWPGFN9MuhOf23Q9Ifjh" crossorigin="anonymous">
</head>
<style>
    @import url('https://fonts.googleapis.com/css?family=Acme|Lobster|Patua+One|Rubik|Sniglet&display=swap');

    @import url('https://fonts.googleapis.com/css?family=Luckiest+Guy|Open+Sans|Pacifico|Permanent+Marker|Roboto|Volkhov&display=swap');

    @import url('https://fonts.googleapis.com/css?family=Cinzel|Cinzel+Decorative|Hind+Madurai|Lalezar|Nanum+Myeongjo&display=swap');

    /* GLOBAL */
    :root {
        --OpenSans: 'Open Sans', sans-serif;    
        --Cinzel: 'Cinzel', serif;
    }

    body {
        font-family: var(--OpenSans);
    }
</style>
<body>
    <form id="form1" runat="server">


        <div class="container mt-4">
            <div class="d-flex flex-row-reverse bd-highlight">

                <div class="p-2 bd-highlight">
                    <%--                        <asp:Button ID="btn_Export" runat="server" Text="Export to PDF" CssClass="btn btn-warning px-4 " />--%>
                    <%--                          OnClick="btn_Export_Click"--%>

                    <button onclick="ExportPdf();" class="btn btn-warning px-4 ">Export to PDF</button>
                </div>
            </div>
        </div>

        <div class="wrapper" id="myCanvas">

            <div class="container mb-5 mt-2 border shadow pl-5 pr-5 pb-5 pt-3">

                <div class="title text-primary text-center" style="font-size: 4.2rem;">
                    PURCHASE
            ORDER
                </div>

                <hr />

                <p class="font-weight-bold" style="font-size: 1.5rem;">VOTECH</p>

                <div class="row">

                    <div class="col-md-6">
                        <p>
                            <span class="font-weight-bold">Address</span> : 56 Kallang Pudding Rd, #07-506
                            <br>
                            <span style="margin-left: 4.6rem;">Singapore 349328</span>
                        </p>
                        <p><span class="font-weight-bold">Email</span> &nbsp;&nbsp;&nbsp;&nbsp;: Votech.EAP@gmail.com</p>
                        <p><span class="font-weight-bold">Contact</span> : (+65) 6874 5852</p>
                        <p><span class="font-weight-bold">Website</span> : www.votech.com.sg</p>

                    </div>

                    <div class="col-md-6 ">
                        <div class="float-right">
                            <p>
                                <span class="font-weight-bold">Date</span> :
                                <asp:Label ID="lbl_Date" runat="server" Text=""></asp:Label>
                            </p>
                            <p>
                                <span class="font-weight-bold">PO #</span> :
                                <asp:Label ID="lbl_ID" runat="server" Text=""></asp:Label>
                            </p>
                        </div>
                    </div>

                </div>

                <div class="row">
                    <div class="col-md-12">
                        <div class="card">
                            <div class="card-header text-center font-weight-bold bg-primary text-white">
                                SHIP TO
                            </div>
                            <div class="card-body">
                                <p>
                                    <p>
                                        <span class="font-weight-bold">Company</span> :
                                        <asp:Label ID="lbl_Name" runat="server" Text=""></asp:Label>
                                    </p>

                                    <p>
                                        <span class="font-weight-bold">Address</span> :<asp:Label ID="lbl_Address" runat="server" Text=""></asp:Label>
                                        <br>
                                        <%--                                        <span style="margin-left: 4.6rem;">Singapore 349328</span>--%>
                                    </p>
                                    <p>
                                        <span class="font-weight-bold">Email</span> &nbsp;&nbsp;&nbsp;&nbsp;:
                                        <asp:Label ID="lbl_Email" runat="server" Text=""></asp:Label>
                                    </p>
                                    <p>
                                        <span class="font-weight-bold">Contact</span> :
                                        <asp:Label ID="lbl_contact" runat="server" Text=""></asp:Label>
                                    </p>

                                </p>

                            </div>
                        </div>
                    </div>
                </div>

                <div class="row mt-4">
                    <div class="col-md-12">

                        <asp:GridView ID="gv_OrderItem" runat="server" DataKeyNames="OI_ID" CssClass="table table-striped table-light table-condensed table-responsive border-0" AutoGenerateColumns="False" ShowFooter="False">
                            <Columns>
                                <asp:BoundField DataField="OI_ID" HeaderText="OI_ID" />
                                <asp:BoundField DataField="OI_Name" HeaderText="Item Name" />
                                <asp:BoundField DataField="OI_Desc" HeaderText="Item Desc" />
                                <asp:BoundField DataField="OI_Price" HeaderText="Price" DataFormatString="{0:C}" />
          <%--                      <asp:BoundField DataField="OI_Qty" HeaderText="Qty" />
                                <asp:BoundField DataField="ProdID" HeaderText="ProdID" />
                                <asp:BoundField DataField="OI_TotalAmount" HeaderText="Total Amount" />--%>
                            </Columns>
                        </asp:GridView>

                    </div>
                </div>

                <div class="row mt-4">
                    <div class="col-md-12">
                        <div class="float-right">
                         <%--   <p><span class="font-weight-bold">Sub Total</span> : <asp:Label ID="lbl_Total" runat="server" Text="Label"></asp:Label></p>
                            <p><span class="font-weight-bold">Tax</span> : $59</p>
                            <p><span class="font-weight-bold">Shipping</span> : -</p>
                            <p><span class="font-weight-bold">Other</span> : -</p>--%>

                            <hr class="bg-dark">
                            <p><span class="font-weight-bold">Total</span> : $ <asp:Label ID="lbl_Total" runat="server" Text="Label"></asp:Label></p>
                            <hr class="bg-dark">
                        </div>
                    </div>
                </div>

                <div class="row">
                    <div class="col-md-12">
                        <div class="text-center">
                            <footer class="blockquote-footer">
                                If you have any questions on this purchase order or feedback,
                        please contact
                                <br>
                                <cite title="Source Title">Votech.EAP@gmail.com, (+65) 6874 5852
                                </cite>
                            </footer>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </form>
</body>

<script src="https://code.jquery.com/jquery-3.4.1.slim.min.js"
    integrity="sha384-J6qa4849blE2+poT4WnyKhv5vZF5SrPo0iEjwBvKU7imGFAV0wwj1yYfoRSJoZ+n" crossorigin="anonymous">
</script>
<script src="https://cdn.jsdelivr.net/npm/popper.js@1.16.0/dist/umd/popper.min.js"
    integrity="sha384-Q6E9RHvbIyZFJoft+2mJbHaEWldlvI9IOYy5n3zV9zzTtmI3UksdQRVvoxMfooAo" crossorigin="anonymous">
</script>
<script src="https://stackpath.bootstrapcdn.com/bootstrap/4.4.1/js/bootstrap.min.js"
    integrity="sha384-wfSDF2E50Y2D1uUdj0O3uMBJnjuUD4Ih7YwaYd1iqfktj0Uod8GCExl3Og8ifwB6" crossorigin="anonymous">
</script>

<script src="https://kendo.cdn.telerik.com/2017.2.621/js/jquery.min.js"></script>

<script src="https://kendo.cdn.telerik.com/2017.2.621/js/jszip.min.js"></script>
<script src="https://kendo.cdn.telerik.com/2017.2.621/js/kendo.all.min.js"></script>

<script>
    function ExportPdf() {
        kendo.drawing
            .drawDOM("#myCanvas",
            {
                paperSize: "A4",
                margin: { top: "1cm", bottom: "1cm" },
                scale: 0.8,
                height: 500
            })
                .then(function (group) {
                    kendo.drawing.pdf.saveAs(group, "Exported.pdf")
                });
    }
</script>


</html>
