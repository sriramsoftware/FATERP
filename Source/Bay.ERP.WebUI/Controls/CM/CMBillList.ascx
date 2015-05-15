<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Oct-2012, 11:26:30
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMBillList.ascx.cs" Inherits="Bay.ERP.Web.UI.CMBillListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div class="TableRow" style="width: 100%; padding-left: 600px;">
                <div class="TableFormLeble" style="text-align: right;">
                    Filter Text&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        Bill No#, Vendor, Amount or Status</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="listContentTitle">
                Bill List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMBill" runat="server" DataSourceID="odsCMBill" OnItemCommand="lvCMBill_ItemCommand"
                        OnItemDataBound="lvCMBill_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByProjectName"
                                            CommandName="Sort" Text="Project Name" CommandArgument="BDProject.ProjectName" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByBillNo"
                                            CommandName="Sort" Text="Bill No" CommandArgument="CMBill.BillNo" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByBillDate"
                                            CommandName="Sort" Text="Bill Date" CommandArgument="CMBill.BillDate" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Vendor Category
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByVendor"
                                            CommandName="Sort" Text="Vendor" CommandArgument="PRMSupplier.SupplierName" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByAmount"
                                            CommandName="Sort" Text="Amount" CommandArgument="CMBill.Amount" />
                                    </td>
                                    <td class="hi">
                                        Work Order No
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByStatus"
                                            CommandName="Sort" Text="Status" CommandArgument="MDBillStatus.Name" />
                                    </td>
                                    <td class="his" style="display:none">
                                        EDIT
                                    </td>
                                    <td class="hi">
                                        Approval Status
                                    </td>
                                    <td class="his" style="width: 50px;">
                                        Report
                                    </td>
                                    <td class="hi">
                                        Requisition
                                    </td>
                                    <td class="hi">
                                        MRR No
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
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillDate") != null ? ((DateTime)Eval("BillDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("VendorCategory")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Amount")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypWorkOrderNo" runat="server" CssClass="CommonLink" Text='<%# Eval("WorkOrderNo")%>'
                                        ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("MDBillApprovalStatusName")%>
                                </td>
                                 <td class="i" style="display:none">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBillList_lvCMBill_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypReport" runat="server" CssClass="CommonButtonLink" NavigateUrl="~/SandBox/MDTest.aspx"
                                        Target="_blank" Text="Report" CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Report_key" />
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlRequisitonNoLV" runat="server"></asp:Panel>
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlMRRNoLV" runat="server"></asp:Panel>
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
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillDate") != null ? ((DateTime)Eval("BillDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("VendorCategory")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Amount")%>
                                </td>
                                <td class="i">
                                  <asp:HyperLink ID="hypWorkOrderNo" runat="server" CssClass="CommonLink" Text='<%# Eval("WorkOrderNo")%>'
                                        ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("MDBillApprovalStatusName")%>
                                </td>
                                 <td class="i" style="display:none">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBillList_lvCMBill_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypReport" runat="server" CssClass="CommonButtonLink" NavigateUrl="~/SandBox/MDTest.aspx"
                                        Target="_blank" Text="Report" CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Report_key" />
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlRequisitonNoLV" runat="server"></asp:Panel>
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlMRRNoLV" runat="server"></asp:Panel>
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
                <asp:ObjectDataSource ID="odsCMBill" runat="server" SelectMethod="GetPagedData" SelectCountMethod="TotalRowCount"
                    EnablePaging="true" MaximumRowsParameterName="pageSize" StartRowIndexParameterName="startRowIndex"
                    TypeName="Bay.ERP.Web.UI.CMBill_DetailedDataSource" SortParameterName="sortExpression"
                    OnSelecting="odsCMBill_Selecting">
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
