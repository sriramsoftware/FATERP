<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMWorkOrderListCancellation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMWorkOrderListCancellationControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100%; padding-left: 600px;">
                <div class="TableFormLeble" style="text-align: right;">
                    Filter Text&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        WO#, Supplier, Subject or Status</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="listContentTitle">
                Work Order List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvPRMWorkOrder" runat="server" DataSourceID="odsPRMWorkOrder" OnItemCommand="lvPRMWorkOrder_ItemCommand"
                        OnItemDataBound="lvPRMWorkOrder_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                     <td class="his">
                                    Cancel
                                     </td>
                                    <td class="his" style="width: 55px;">
                                        Command
                                    </td>
                                    <td class="his" style="display: none;">
                                        DELETE
                                    </td>
                                    <td class="his" style="width: 70px;">
                                        Report
                                    </td>
                                    <td class="hi" style="width:66px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByWorkOrderNo"
                                            CommandName="Sort" Text="Work Order No" CommandArgument="PRMWorkOrder.WorkOrderNo" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBy" CommandName="Sort"
                                            Text="Supplier" CommandArgument="PRMSupplier.SupplierName" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByBodyTitle"
                                            CommandName="Sort" Text="Body Title" CommandArgument="PRMWorkOrder.BodyTitle" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySubject"
                                            CommandName="Sort" Text="Subject" CommandArgument="PRMWorkOrder.Subject" />
                                    </td>
                                    <td class="hi" style="width:100px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByStatus"
                                            CommandName="Sort" Text="WO Status" CommandArgument="MDWorkOrderStatus.Name" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Attention
                                    </td>
                                    <td class="hi" style="width:124px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByCreateDate"
                                            CommandName="Sort" Text="Date" CommandArgument="PRMWorkOrder.CreateDate" />
                                    </td>
                                    <td class="hi" style="width:62px;">
                                        Requisition
                                    </td>
                                    <td class="hi" style="width:68px;">
                                        MRR
                                    </td>
                                    <td class="hi" style="width:68px;">
                                        Bill
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Warranty
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Delay Charge
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Remarks
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Foot Note
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Prepared By
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
                                <asp:LinkButton ID="lnkBtnCencel" runat="server" CssClass="CommonButtonLink" Text="Cancel" OnClientClick="return confirm('Are you sure to Cancel Work Order?')"
                                    CommandName="CancelItem" CommandArgument='<%#Eval("WorkOrderID")%>'/>
                            </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="- Edit" CommandName="EditItem" CommandArgument='<%#Eval("WorkOrderID")%>'
                                        UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_Edit_key" />
                                    <br />
                                    <asp:HyperLink ID="hypWorkOrderPaymentTerm" runat="server" CssClass="CommonButtonLink"
                                        Text="- Pay Terms" CommandName="WorkOrderPaymentTerm" CommandArgument='<%#Eval("WorkOrderID")%>'
                                        UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_PaymentTerm_key"></asp:HyperLink>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order?')"
                                        CommandArgument='<%#Eval("WorkOrderID")%>' UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_Delete_key" />
                                </td>
                                
                                <td class="i">
                                    <asp:HyperLink ID="hypWorkOrderReport" runat="server" CssClass="CommonButtonLink"
                                        Text="- Report" CommandName="WorkOrderReport" CommandArgument='<%#Eval("WorkOrderID")%>'
                                        UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_WorkOrderReport_key"></asp:HyperLink>
                                    <br />
                                    <asp:HyperLink ID="hypWorkOrderAnnexureReport" runat="server" CssClass="CommonButtonLink"
                                        Text="- Annexure" CommandName="WorkOrderAnnexureReport" CommandArgument='<%#Eval("WorkOrderID")%>'
                                        UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_WorkOrderAnnexureReport_key"></asp:HyperLink>
                                        <br />
                                    <asp:HyperLink ID="hypWorkOrderFloorwiseReport" runat="server" CssClass="CommonButtonLink"
                                        Text="- Floor Details" CommandName="WorkOrderFloorwiseReport" CommandArgument='<%#Eval("WorkOrderID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypWorkOrderNo" runat="server" CssClass="CommonLink" Text='<%# Eval("WorkOrderNo")%>'
                                        ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("PRMSupplierSupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BodyTitle")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Subject")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDWorkOrderStatusName")%>
                                    <br />
                                    <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                                    <br />
                                    <asp:Button ID="btnResetWorkOrderLV" Text="Reset AP" runat="server" CommandName="UpdateItem"
                                        OnClientClick="return confirm('Are you sure to Reset Approval Process?')" CommandArgument='<%#Eval("WorkOrderID")%>'></asp:Button>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("AttentionFullName")%>
                                </td>
                               <td class="i">
                                  <b>Create:</b>&nbsp; <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%><br />
                                  <b>Start:</b>&nbsp; <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%><br />
                                  <b>Completion:</b>&nbsp;<%# Eval("CompletionDate") != null ? ((DateTime)Eval("CompletionDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlRequisitonNoLV" runat="server"></asp:Panel>
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlMRRNoLV" runat="server"></asp:Panel>
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlBillLV" runat="server"></asp:Panel>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Warranty")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("DelayCharge")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("FootNote")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("PreparedByFullName")%>
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
                                <asp:LinkButton ID="lnkBtnCencel" runat="server" CssClass="CommonButtonLink" Text="Cancel" OnClientClick="return confirm('Are you sure to Cancel Work Order?')"
                                    CommandName="CancelItem" CommandArgument='<%#Eval("WorkOrderID")%>'/>
                            </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="- Edit" CommandName="EditItem" CommandArgument='<%#Eval("WorkOrderID")%>'
                                        UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_Edit_key" />
                                    <br />
                                    <asp:HyperLink ID="hypWorkOrderPaymentTerm" runat="server" CssClass="CommonButtonLink"
                                        Text="- Pay Terms" CommandName="WorkOrderPaymentTerm" CommandArgument='<%#Eval("WorkOrderID")%>'
                                        UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_PaymentTerm_key"></asp:HyperLink>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order?')"
                                        CommandArgument='<%#Eval("WorkOrderID")%>' UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_Delete_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypWorkOrderReport" runat="server" CssClass="CommonButtonLink"
                                        Text="- Report" CommandName="WorkOrderReport" CommandArgument='<%#Eval("WorkOrderID")%>'
                                        UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_WorkOrderReport_key"></asp:HyperLink>
                                    <br />
                                    <asp:HyperLink ID="hypWorkOrderAnnexureReport" runat="server" CssClass="CommonButtonLink"
                                        Text="- Annexure" CommandName="WorkOrderAnnexureReport" CommandArgument='<%#Eval("WorkOrderID")%>'
                                        UniqueKey="PRMWorkOrderList_lvPRMWorkOrder_WorkOrderAnnexureReport_key"></asp:HyperLink>
                                        <br />
                                    <asp:HyperLink ID="hypWorkOrderFloorwiseReport" runat="server" CssClass="CommonButtonLink"
                                        Text="- Floor Details" CommandName="WorkOrderFloorwiseReport" CommandArgument='<%#Eval("WorkOrderID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypWorkOrderNo" runat="server" CssClass="CommonLink" Text='<%# Eval("WorkOrderNo")%>'
                                        ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("PRMSupplierSupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BodyTitle")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Subject")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDWorkOrderStatusName")%>
                                    <br />
                                      <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                                      <br />
                                    <asp:Button ID="btnResetWorkOrderLV" Text="Reset AP" runat="server" CommandName="UpdateItem"
                                        OnClientClick="return confirm('Are you sure to Reset Approval Process?')" CommandArgument='<%#Eval("WorkOrderID")%>'></asp:Button>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("AttentionFullName")%>
                                </td>
                                <td class="i">
                                 <b>Create:</b>&nbsp; <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%><br />
                                  <b>Start:</b>&nbsp; <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%><br />
                                  <b>Completion:</b>&nbsp;<%# Eval("CompletionDate") != null ? ((DateTime)Eval("CompletionDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlRequisitonNoLV" runat="server"></asp:Panel>
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlMRRNoLV" runat="server"></asp:Panel>
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlBillLV" runat="server"></asp:Panel>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Warranty")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("DelayCharge")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("FootNote")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("PreparedByFullName")%>
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
                <asp:ObjectDataSource ID="odsPRMWorkOrder" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMWorkOrder_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsPRMWorkOrder_Selecting">
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
