<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:42:57
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="AFMAdvancePayment.aspx.cs" Inherits="Bay.ERP.Web.UI.AFMAdvancePaymentPage" Title="Bay's ERP New" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>


<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Advance Payment - WO</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <%--<uc:MDCityEntity ID="ucMDCityEntity" runat="server" />--%>
        <asp:SqlDataSource ID="SQLWOPaymentTerm" runat="server" 
            ConnectionString="<%$ ConnectionStrings:ETCON %>" 
            
            SelectCommand="SELECT        dbo.PRMWorkOrder.WorkOrderNo, dbo.PRMSupplier.SupplierName, dbo.PRMSupplier.MobileNo, dbo.PRMWorkOrder.Subject, dbo.PRMWorkOrder.BodyTitle, 
                         dbo.PRMWorkOrder.StartDate, dbo.PRMWorkOrder.CompletionDate, dbo.PRMSupplierContactPerson.Name, dbo.PRMWorkOrderPaymentTerm.PaymentPercentage, 
                         dbo.PRMWorkOrderPaymentTerm.CompletionPercentage, dbo.PRMWorkOrderPaymentTerm.PaymentDate, dbo.PRMWorkOrder.WorkOrderID
FROM            dbo.PRMWorkOrder INNER JOIN
                         dbo.PRMWorkOrderPaymentTerm ON dbo.PRMWorkOrder.WorkOrderID = dbo.PRMWorkOrderPaymentTerm.WorkOrderID INNER JOIN
                         dbo.PRMSupplier ON dbo.PRMWorkOrder.SupplierID = dbo.PRMSupplier.SupplierID LEFT OUTER JOIN
                         dbo.PRMSupplierContactPerson ON dbo.PRMWorkOrder.AttentionID = dbo.PRMSupplierContactPerson.SupplierContactPersonID
WHERE        (dbo.PRMWorkOrderPaymentTerm.CompletionPercentage = 0) AND (dbo.PRMWorkOrderPaymentTerm.PaymentPercentage &gt; 0) AND (dbo.PRMWorkOrder.WorkOrderStatusID = 3) ">
        </asp:SqlDataSource>
        <br />
        <br />
        <br />
        <br />
        <br />
        <div>
            <br />


            <br />
            <asp:GridView ID="GridView3" runat="server" AllowSorting="True" 
                AutoGenerateColumns="False" BackColor="White" BorderColor="#CCCCCC" 
                BorderStyle="None" BorderWidth="1px" 
                Caption="Advance Payment - Work Order" CellPadding="4" 
                DataSourceID="SQLWOPaymentTerm" ForeColor="Black" GridLines="Horizontal" 
                meta:resourcekey="GridView3Resource1" Width="90%" 
                DataKeyNames="WorkOrderID" onrowdatabound="GridView3_RowDataBound">
                <Columns>
                    <asp:BoundField DataField="WorkOrderNo" HeaderText="WO#" 
                        SortExpression="WorkOrderNo" />
                    <asp:BoundField DataField="SupplierName" HeaderText="Vendor" 
                        SortExpression="SupplierName" />
                    <asp:BoundField DataField="MobileNo" HeaderText="Mobile#" 
                        SortExpression="MobileNo" />
                    <asp:BoundField DataField="Subject" HeaderText="WO Subject" 
                        SortExpression="Subject" />
                    <asp:BoundField DataField="BodyTitle" HeaderText="BodyTitle" 
                        SortExpression="BodyTitle" />
                    <asp:BoundField DataField="StartDate" HeaderText="Start Date" 
                        SortExpression="StartDate" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="CompletionDate" HeaderText="End Date" 
                        SortExpression="CompletionDate" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="Name" HeaderText="Attn. Name" 
                        SortExpression="Name" />
                    <asp:BoundField DataField="PaymentPercentage" HeaderText="Payment%" 
                        SortExpression="PaymentPercentage" />
                    <asp:BoundField DataField="CompletionPercentage" 
                        HeaderText="Completion%" SortExpression="CompletionPercentage" />
                    <asp:BoundField DataField="PaymentDate" HeaderText="Payment Date" 
                        SortExpression="PaymentDate" DataFormatString="{0:d}" />
                    <asp:BoundField DataField="WorkOrderID" HeaderText="WO ID" 
                        InsertVisible="False" ReadOnly="True" SortExpression="WorkOrderID" />
                    <asp:BoundField DataField="WorkOrderNo" SortExpression="WorkOrderNo" />
                </Columns>
                <EmptyDataTemplate>
                    No Items To Display
                </EmptyDataTemplate>
                <FooterStyle BackColor="#CCCC99" ForeColor="Black" />
                <HeaderStyle BackColor="White" Font-Bold="True" ForeColor="#333333" />
                <PagerStyle BackColor="White" ForeColor="Black" HorizontalAlign="Right" />
                <RowStyle Height="30px" />
                <SelectedRowStyle BackColor="#CC3333" Font-Bold="True" ForeColor="White" />
                <SortedAscendingCellStyle BackColor="#F7F7F7" />
                <SortedAscendingHeaderStyle BackColor="#4B4B4B" />
                <SortedDescendingCellStyle BackColor="#E5E5E5" />
                <SortedDescendingHeaderStyle BackColor="#242121" />
            </asp:GridView>
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
