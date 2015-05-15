<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 13-Dec-2012, 11:43:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACCRegularPostPayableStatementDetailList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACCRegularPostPayableStatementDetailListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div>
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
             <div class="TableRow" style="width: 100%; padding-left:610px;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Vedor, WorkOrder# Or Status</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                     Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
            <div class="listContentTitle">
                Regular Payable Statement Detail List
            </div>
            <div>
               <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACCPostPayableStatementDetail" runat="server" DataSourceID="odsACCPostPayableStatementDetail" OnItemDataBound="lvACCPostPayableStatementDetail_ItemDataBound"
                        OnItemCommand="lvACCPostPayableStatementDetail_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Post Payable Statement
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi">
                                        Work Order No
                                    </td>
                                    <td class="hi">
                                        WO Amount
                                    </td>
                                    <td class="hi">
                                        WO Date
                                    </td>
                                    <td class="hi">
                                        Paid Amount
                                    </td>
                                    <td class="hi">
                                        Security Money
                                    </td>
                                    <td class="hi">
                                        TDS Amount
                                    </td>
                                    <td class="hi">
                                        Payable Against WO
                                    </td>
                                    <td class="hi">
                                        Approved Bill Amount
                                    </td>
                                    <td class="hi">
                                        Net Payable Considering Bill And Security
                                    </td>
                                    <td class="hi">
                                        Party Reconcile
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Requisition
                                    </td>
                                    <td class="hi">
                                        Requisition No
                                    </td>
                                    <td class="hi">
                                        Requisition Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Bill
                                    </td>
                                    <td class="hi">
                                        Bill No
                                    </td>
                                    <td class="hi">
                                        Bill Date
                                    </td>
                                   <%-- <td class="hi">
                                        Remarks
                                    </td>--%>
                                    <td class="hi" style="display:none;">
                                        Ref
                                    </td>
                                  <%--  <td class="hi">
                                        Vendor Category
                                    </td>--%>
                                    <td class="hi">
                                        From Vendor
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Create Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Due Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Planned Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Additional Remarks
                                    </td>
                                    <td class="hi">
                                        Payment Status
                                    </td>
                                    <td class="hi">
                                        Approval
                                    </td>
                                     <td class="hi">
                                        Approval Status
                                    </td>
                                    <%--<td class="hi">
                                        Account Payble Statement Detail Category
                                    </td>--%>
                                    <td class="hi">
                                        Classification
                                    </td>
                                    <td class="hi">
                                        Create By Employee
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
                                    <%# Eval("ACCPostPayableStatementRef")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderDate") != null ? ((DateTime)Eval("WorkOrderDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaidAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SecurityMoney")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TDSAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayableAgainstWorkOrder")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ApprovedBillAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NetPayableConsideringBillAndSecurity")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PartyReconcile") != null ? (((Boolean)Eval("PartyReconcile")) ? "Yes" : "No") : ""%>
                                </td>
                               
                                <td class="i">
                                    <%# Eval("RequisitionNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                               
                                <td class="i">
                                    <%# Eval("BillNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillDate") != null ? ((DateTime)Eval("BillDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                               <%-- <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>--%>
                               
                               <%-- <td class="i">
                                    <%# Eval("VendorCategoryID")%>
                                </td>--%>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentStatusName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayableApprovalStatusName")%>
                                </td>
                                <td class="i">
                                <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                            </td>
                                <%--<td class="i">
                                    <%# Eval("AccountPaybleStatementDetailCategoryName")%>
                                </td>--%>
                                <td class="i">
                                    <%# Eval("PayableClassificationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberFullName")%>
                                </td>
                              
                               
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("PostPayableStatementDetailID")%>'
                                        UniqueKey="ACCSecuredPostPayableStatementDetailList_lvACCSecuredPostPayableStatementDetail_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CCPost Payable Statement Detail?')"
                                        CommandArgument='<%#Eval("PostPayableStatementDetailID")%>' UniqueKey="ACCSecuredPostPayableStatementDetailList_lvACCSecuredPostPayableStatementDetail_Delete_key" />
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
                                    <%# Eval("ACCPostPayableStatementRef")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderDate") != null ? ((DateTime)Eval("WorkOrderDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaidAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SecurityMoney")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TDSAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayableAgainstWorkOrder")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ApprovedBillAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NetPayableConsideringBillAndSecurity")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PartyReconcile") != null ? (((Boolean)Eval("PartyReconcile")) ? "Yes" : "No") : ""%>
                                </td>
                               
                                <td class="i">
                                    <%# Eval("RequisitionNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                               
                                <td class="i">
                                    <%# Eval("BillNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillDate") != null ? ((DateTime)Eval("BillDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                               <%-- <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>--%>
                               
                               <%-- <td class="i">
                                    <%# Eval("VendorCategoryID")%>
                                </td>--%>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentStatusName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayableApprovalStatusName")%>
                                </td>
                                <td class="i">
                                <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                            </td>
                               <%-- <td class="i">
                                    <%# Eval("AccountPaybleStatementDetailCategoryName")%>
                                </td>--%>
                                <td class="i">
                                    <%# Eval("PayableClassificationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("PostPayableStatementDetailID")%>'
                                        UniqueKey="ACCSecuredPostPayableStatementDetailList_lvACCSecuredPostPayableStatementDetail_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CCPost Payable Statement Detail?')"
                                        CommandArgument='<%#Eval("PostPayableStatementDetailID")%>' UniqueKey="ACCSecuredPostPayableStatementDetailList_lvACCSecuredPostPayableStatementDetail_Delete_key" />
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
                <asp:ObjectDataSource ID="odsACCPostPayableStatementDetail" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACCPostPayableStatementDetail_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACCPostPayableStatementDetail_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
