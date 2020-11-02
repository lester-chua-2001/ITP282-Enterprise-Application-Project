<%@ Page Title="" Language="C#" MasterPageFile="~/Static/Master/Admin/Admin_Master_Page.master" AutoEventWireup="true" CodeBehind="InvoiceViewDetails.aspx.cs" Inherits="EAP_Supplier_Votech.Web.Admin.Lester.InvoiceViewDetails" %>
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
                    <p class="display-4 text-center ">View Details</p>
                    <hr />
                </div>
            </div>
        </div>

    </header>
    <main>
        <div class="container justify-content-center">
          <div class="container">
              <asp:GridView ID="gvViewDetails" runat="server" AutoGenerateColumns="False">
                  <Columns>
                    <asp:BoundField DataField="OI_ID" HeaderText="Order Item Reference" />
                    <asp:BoundField DataField="OI_TotalAmount" HeaderText="Total Amount of that item" />
                    <asp:BoundField DataField="OI_Name" HeaderText="Name of Product" />
                    <asp:BoundField DataField="OI_Desc" HeaderText="Description of item" />
                    <asp:BoundField DataField="OI_Price" HeaderText="Price per item" />
                    <asp:BoundField DataField="OI_Qty" HeaderText="Quantity of item" />
                    <asp:BoundField DataField="CO_ID" HeaderText="Customer Order Reference" />
                </Columns>
              </asp:GridView>   
          </div>
        </div>
    </main>

</asp:Content>
