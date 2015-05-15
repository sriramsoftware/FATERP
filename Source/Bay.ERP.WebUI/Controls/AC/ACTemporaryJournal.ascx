<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Feb-2013, 02:08:21
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACTemporaryJournal.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACTemporaryJournalControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
       <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
        <div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACTemporaryJournal" runat="server" DataSourceID="odsACTemporaryJournal" OnItemDataBound="lvACTemporaryJournal_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Account
                                    </td>
                                    <td class="hi">
                                        Account Group
                                    </td>
                                    <td class="hi">
                                        Transaction Date Time
                                    </td>
                                    <td class="hi">
                                        Amount
                                    </td>
                                    <td class="hi">
                                        Reference
                                    </td>
                                    <td class="hi">
                                        Note
                                    </td>
                                    <td class="hi">
                                        Debit/Credit
                                    </td>
                                     <td class="hi" style="width:250px;">
                                        Other Info
                                    </td>
                                    <td class="hi">
                                        Fiscal Year
                                    </td>
                                    <td class="hi">
                                        Is Reverse Transaction
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
                                    <%# Eval("ACAccountAccountName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ACAccountGroupName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransactionDateTime") != null ? ((DateTime)Eval("TransactionDateTime")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Amount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReferenceOrMemoOrID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Note")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ACMDDebitCreditName")%>
                                </td>
                                 <td class="i">
                                      <b>Project:</b> &nbsp;<%# Eval("BDProjectProjectName")%><br />
                                       <b>Requisition:</b> &nbsp;<asp:HyperLink ID="hypRequisitionLV" runat="server" Text='<%# Eval("RequisitionNo")%>'></asp:HyperLink> <br />
                                        <b>WorkOrder:</b> &nbsp;<asp:HyperLink ID="hypWorkOrderLV" runat="server" Text='<%# Eval("WorkOrderNo")%>'></asp:HyperLink> <br />
                                        <b>Bill:</b> &nbsp;<%# Eval("BillNo")%><br />
                                        <b>Floor:</b> &nbsp;<%# Eval("ProjectFloorName")%><br />
                                        <b>Floor Unit:</b> &nbsp;<%# Eval("ProjectFloorUnitName")%><br />
                                        <b>Item:</b> &nbsp;<%# Eval("ItemName")%>
                                    </td>
                                <td class="i">
                                    <%# Eval("ACFiscalYear")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsReverseTransaction") != null ? (((Boolean)Eval("IsReverseTransaction")) ? "Yes" : "No") : ""%>
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
                                    <%# Eval("ACAccountAccountName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ACAccountGroupName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransactionDateTime") != null ? ((DateTime)Eval("TransactionDateTime")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Amount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReferenceOrMemoOrID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Note")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ACMDDebitCreditName")%>
                                </td>
                                  <td class="i">
                                      <b>Project:</b> &nbsp;<%# Eval("BDProjectProjectName")%><br />
                                       <b>Requisition:</b> &nbsp;<asp:HyperLink ID="hypRequisitionLV" runat="server" Text='<%# Eval("RequisitionNo")%>'></asp:HyperLink> <br />
                                        <b>WorkOrder:</b> &nbsp;<asp:HyperLink ID="hypWorkOrderLV" runat="server" Text='<%# Eval("WorkOrderNo")%>'></asp:HyperLink> <br />
                                        <b>Bill:</b> &nbsp;<%# Eval("BillNo")%><br />
                                        <b>Floor:</b> &nbsp;<%# Eval("ProjectFloorName")%><br />
                                        <b>Floor Unit:</b> &nbsp;<%# Eval("ProjectFloorUnitName")%><br />
                                        <b>Item:</b> &nbsp;<%# Eval("ItemName")%>
                                    </td>
                                <td class="i">
                                    <%# Eval("ACFiscalYear")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsReverseTransaction") != null ? (((Boolean)Eval("IsReverseTransaction")) ? "Yes" : "No") : ""%>
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
                <asp:ObjectDataSource ID="odsACTemporaryJournal" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACTemporaryJournal_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACTemporaryJournal_Selecting">
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
