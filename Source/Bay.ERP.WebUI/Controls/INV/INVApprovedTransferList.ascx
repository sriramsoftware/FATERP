<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 18-Dec-2012, 01:46:09
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVApprovedTransferList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVApprovedTransferListControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
       
       
        <div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
          
            <div class="listContentTitle">
                Transfer List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVTransfer" runat="server" DataSourceID="odsINVTransfer" OnItemCommand="lvINVTransfer_ItemCommand" OnItemDataBound="lvINVTransfer_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        TRN No
                                    </td>
                                    <td class="hi">
                                        Requested By Employee
                                    </td>
                                    <td class="hi">
                                    
                                        Request Date
                                    </td>
                                    <td class="hi">
                                        Transfer From Store
                                    </td>
                                    <td class="hi">
                                        Transfer From Store Unit
                                    </td>
                                    <td class="hi">
                                        Transfer To Store
                                    </td>
                                    <td class="hi">
                                        Transfer To Store Unit
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Inventory Transfer Status
                                    </td>
                                     <td class="his">
                                        Approval Status
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
                                <asp:HyperLink ID="hypTRFNo" runat="server" CssClass="CommonLink" Text='<%# Eval("TRFNo")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("HREmployeeMemberID")%>
                                </td>
                                <td class="i">
                                <%# Eval("RequestDate") != null ? ((DateTime)Eval("RequestDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferFromStore")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferFromStoreUnit")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferToStoreName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferToUnit")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDInventoryTransferStatusName")%>
                                </td>
                                 <td class="i">
                                <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
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
                                <asp:HyperLink ID="hypTRFNo" runat="server" CssClass="CommonLink" Text='<%# Eval("TRFNo")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("HREmployeeMemberID")%>
                                </td>
                                <td class="i">
                                <%# Eval("RequestDate") != null ? ((DateTime)Eval("RequestDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferFromStore")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferFromStoreUnit")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferToStoreName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferToUnit")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDInventoryTransferStatusName")%>
                                </td>
                                  <td class="i">
                                <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
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
                <asp:ObjectDataSource ID="odsINVTransfer" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVTransfer_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVTransfer_Selecting">
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
