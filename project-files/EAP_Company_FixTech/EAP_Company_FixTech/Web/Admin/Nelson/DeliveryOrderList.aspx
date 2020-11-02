<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="DeliveryOrderList.aspx.cs" Inherits="EAP_Company_FixTech.Web.Admin.DeliveryOrderList" %>
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
                <p class="display-4 text-center ">Delivery Orders</p>
            </div>
        </div>
    </header>

    <asp:GridView ID="gvDeliveryOrder" runat="server" DataKeyNames="DO_ID" AutoGenerateColumns="False" OnSelectedIndexChanged="gvDeliveryOrder_SelectedIndexChanged" BackColor="White" BorderColor="Black" BorderStyle="Solid" BorderWidth="2px" CssClass="table table-hover">
                    <HeaderStyle
                        BackColor="#606060"
                        Height="35"
                        ForeColor="White"
                        Font-Bold="True"/>
                    <Columns>
                        <asp:BoundField DataField="DO_ID" HeaderText="Delivery Order ID" />
                        <asp:BoundField DataField="DO_Date" HeaderText="Order Date" />
                        <asp:BoundField DataField="DO_CompanyName" HeaderText="Recipient Company" />
                        <asp:BoundField DataField="CO_ID" HeaderText="Customer Order ID" />
                        <asp:BoundField DataField="DO_Status" HeaderText="Delivery Status" />

                        <asp:TemplateField HeaderText="Remarks">
                            <EditItemTemplate>
                                <asp:TextBox ID="tb_DO_Remarks" runat="server" Text='<%# Bind("DO_Remarks") %>'></asp:TextBox>
                            </EditItemTemplate>
                            <ItemTemplate>
                                <asp:Label ID="lbl_DO_Remarks" runat="server" Text='<%# Bind("DO_Remarks") %>'></asp:Label>
                            </ItemTemplate>
                        </asp:TemplateField>

                        <asp:CommandField ShowSelectButton="True" SelectText="View" />
                    </Columns>
                </asp:GridView>

</asp:Content>
