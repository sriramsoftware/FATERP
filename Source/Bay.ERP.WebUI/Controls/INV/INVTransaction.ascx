<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Dec-2012, 02:43:44
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVTransaction.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVTransactionControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
             <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Project&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="INVTransactionEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Item&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="INVTransactionEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                  
                </div>
            </div>
            <div class="TableRow" style="width: 100; display:none;">
                <div class="TableFormLeble" style="text-align: left;">
                    Batch Number&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtBatchNumber">
                        Enter Batch Number</label>
                    <asp:TextBox ID="txtBatchNumber" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="INVTransactionEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                
                </div>
            </div>
            <div class="TableRow" style="width: 100; display:none;">
                <div class="TableFormLeble" style="text-align: left;">
                    Transaction Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtTransactionDate">
                        Enter Transaction Date</label>
                    <asp:TextBox ID="txtTransactionDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="INVTransactionEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvTransactionDate" runat="server" ControlToValidate="txtTransactionDate"
                        ErrorMessage="Please Enter Transaction Date" ValidationGroup="INVTransactionEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revTransactionDate" runat="server" ControlToValidate="txtTransactionDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                        ValidationGroup="INVTransactionEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100; display:none;">
                <div class="TableFormLeble" style="text-align: left;">
                    Store&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlStoreID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="INVTransactionEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Store Unit&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlStoreUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="INVTransactionEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSearch" runat="server"
                        OnClick="btnSearch_Click" Text="Search" UniqueKey="INVTransactionControl_Search_key" />
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Transaction List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVTransaction" runat="server" DataSourceID="odsINVTransaction"
                        OnItemCommand="lvINVTransaction_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi">
                                        Item
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Brand
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Region
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Country
                                    </td>
                                    <td class="hi">
                                        Batch Number
                                    </td>
                                      <td class="hi">
                                        Unit Price
                                    </td>
                                    <td class="hi">
                                        Transaction Qty
                                    </td>
                                    <td class="hi">
                                        Unit
                                    </td>
                                    <td class="hi">
                                        Transaction Date
                                    </td>
                                    <td class="hi">
                                        Transaction Direction
                                    </td>
                                    <td class="hi" style="display:none;">
                                        I PAddress
                                    </td>
                                    <td class="hi">
                                        Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Requisition Number
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Word Order Number
                                    </td>
                                    <td class="hi" style="display:none;">
                                        M RRNumber
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Bill Number
                                    </td>
                                    <td class="hi">
                                        Is Transfer
                                    </td>
                                    <td class="hi">
                                        Store
                                    </td>
                                    <td class="hi">
                                        Store Unit
                                    </td>
                                    <td class="his" style="display:none;">
                                        EDIT
                                    </td>
                                    <td class="his" style="display:none;">
                                        DELETE
                                    </td>
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="rpb">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                                <tr>
                                    <td colspan="100%">
                                        <div class="lv-FooterContainer">
                                            <div class="lv-Footer">
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="15">
                                                    <Fields>
                                                        <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="lv-PagerItem" FirstPageImageUrl="~/Images/CustomListView/Default/FT.png"
                                                            PreviousPageImageUrl="~/Images/CustomListView/Default/PT.png" ShowFirstPageButton="true"
                                                            ShowPreviousPageButton="true" ShowNextPageButton="false" ShowLastPageButton="false" />
                                                        <asp:NumericPagerField ButtonType="Button" ButtonCount="10" NumericButtonCssClass="lv-PagerItemNumeric"
                                                            CurrentPageLabelCssClass="lv-PagerItemNumericCurrent" RenderNonBreakingSpacesBetweenControls="false" />
                                                        <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="lv-PagerItem" NextPageImageUrl="~/Images/CustomListView/Default/NT.png"
                                                            LastPageImageUrl="~/Images/CustomListView/Default/LT.png" ShowFirstPageButton="false"
                                                            ShowPreviousPageButton="false" ShowNextPageButton="true" ShowLastPageButton="true"
                                                            RenderNonBreakingSpacesBetweenControls="true" />
                                                        <asp:TemplatePagerField>
                                                            <PagerTemplate>
                                                                <div class="lv-PagerCount">
                                                                    Items <span>
                                                                        <%# Container.StartRowIndex +1%></span> to <span>
                                                                            <%# (Container.StartRowIndex+Container.PageSize ) < Container.TotalRowCount ? (Container.StartRowIndex+Container.PageSize) : Container.TotalRowCount %></span>
                                                                    of <span>
                                                                        <%# Container.TotalRowCount%></span>
                                                                </div>
                                                            </PagerTemplate>
                                                        </asp:TemplatePagerField>
                                                    </Fields>
                                                </asp:DataPager>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr class="r">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                   <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDItemName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("MDBrandBrandName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("MDRegionName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("MDCountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BatchNumber")%>
                                </td>
                                 <td class="i">
                                    <%# Eval("UnitPrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransactionQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransactionDate") != null ? ((DateTime)Eval("TransactionDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransactionDirection") != null ? (((Boolean)Eval("TransactionDirection")) ? "IN" : "OUT") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IPAddress")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberFullName")%>
                                </td>
                               
                                <td class="i" style="display:none;">
                                    <%# Eval("RequisitionNumber")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("WordOrderNumber")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("MRRNumber")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("BillNumber")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsTransfer") != null ? (((Boolean)Eval("IsTransfer")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("StoreName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StoreUnitName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("TransactionID")%>'
                                        UniqueKey="INVTransaction_lvINVTransaction_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVTransaction?')"
                                        CommandArgument='<%#Eval("TransactionID")%>' UniqueKey="INVTransaction_lvINVTransaction_Delete_key" />
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <tr class="ar">
                                <td class="rp">
                                    &nbsp;
                                    </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDItemName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("MDBrandBrandName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("MDRegionName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("MDCountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BatchNumber")%>
                                </td>
                                 <td class="i">
                                    <%# Eval("UnitPrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransactionQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransactionDate") != null ? ((DateTime)Eval("TransactionDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransactionDirection") != null ? (((Boolean)Eval("TransactionDirection")) ? "IN" : "OUT") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IPAddress")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberFullName")%>
                                </td>
                               
                                <td class="i" style="display:none;">
                                    <%# Eval("RequisitionNumber")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("WordOrderNumber")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("MRRNumber")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("BillNumber")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsTransfer") != null ? (((Boolean)Eval("IsTransfer")) ? "Yes" : "No") : ""%>
                                </td>
                               <td class="i">
                                    <%# Eval("StoreName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StoreUnitName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("TransactionID")%>'
                                        UniqueKey="INVTransaction_lvINVTransaction_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVTransaction?')"
                                        CommandArgument='<%#Eval("TransactionID")%>' UniqueKey="INVTransaction_lvINVTransaction_Delete_key" />
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsINVTransaction" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVTransaction_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVTransaction_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
