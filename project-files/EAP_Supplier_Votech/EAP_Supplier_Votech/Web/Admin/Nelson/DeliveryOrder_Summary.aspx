<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="DeliveryOrder_Summary.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.DeliveryOrder_Summary" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
        <asp:GridView ID="gvDeliveryOrderItems" runat="server" AutoGenerateColumns="False" DataKeyNames="OI_ID" CssClass="table table-striped table-light table-condensed table-responsive border-0">
            <Columns>
                <asp:BoundField DataField="OI_ID" HeaderText="Order Item ID" />
                <asp:BoundField DataField="OI_Name" HeaderText="Item Name" />
                <asp:BoundField DataField="OI_Desc" HeaderText="Item Desc" />
                <asp:BoundField DataField="OI_Qty" HeaderText="Qty" />
                <asp:BoundField DataField="OI_Price" HeaderText="Price" />
                <asp:BoundField DataField="OI_TotalAmount" HeaderText="Total Amount" />
                <asp:BoundField DataField="ProdID" HeaderText="ProdID" />
            </Columns>
        </asp:GridView>
    </div>
    </form>
</body>
</html>
