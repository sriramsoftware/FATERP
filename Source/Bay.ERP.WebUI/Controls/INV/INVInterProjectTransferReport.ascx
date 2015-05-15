<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVInterProjectTransferReport.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVInterProjectTransferReportControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        From Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlFromProjectID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVTransactionEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        To Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlToProjectID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVTransactionEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtStartDate">
                            Enter Start Date</label>
                        <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="OTIssueEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtStartDate"
                            ErrorMessage="Please Enter Start Date" ValidationGroup="INVTransactionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="INVTransactionEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        End Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEndDate">
                            Enter End Date</label>
                        <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="INVTransactionEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEndDate"
                            ErrorMessage="Please Enter End Date" ValidationGroup="INVTransactionEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="INVTransactionEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSearch" ValidationGroup="INVTransactionEntity" OnClick="btnSearch_Click"
                            runat="server" Text="Show Report" />
                        <asp:Button ID="btnClearSearch" ValidationGroup="INVTransactionEntity" OnClick="btnClearSearch_Click"
                            runat="server" Text="Clear Search" />
                    </div>
                </div>
            </div>
        </div>
        <div class="listContentTitle">
            Transfer List
        </div>
        <div>
            <div class="lv-c">
                <asp:ListView ID="lvINVTransfer" runat="server" DataSourceID="odsINVTransfer_custom">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                            <tr class="h">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="hi" style="width: 120px;">
                                    TRN No
                                </td>
                                <td class="hi" style="width: 190px;">
                                    From Project
                                </td>
                                <td class="hi" style="width: 190px;">
                                    To Project
                                </td>
                                <td class="hi" style="width: 190px;">
                                    Item
                                </td>
                                <td class="hi">
                                    RequestDate
                                </td>
                                <td class="hi">
                                    Request Qty
                                </td>
                                <td class="hi">
                                    Issued Qty
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
                            <td class="i" style="display: none;">
                                <%# Eval("TransferID")%>
                                <%# Eval("ItemID")%>
                                <%# Eval("TransferFromStoreID")%>
                                <%# Eval("TransferToStoreID")%>
                                <%# Eval("SINRequestedQty")%>
                                <%# Eval("SINTransferID")%>
                                <%# Eval("SINFromStoreID")%>
                                <%# Eval("SINToStoreID")%>
                            </td>
                            <td class="i">
                                <asp:HyperLink ID="hypTRFNo" runat="server" CssClass="CommonLink" Text='<%# Eval("TRFNo")%>'></asp:HyperLink>
                            </td>
                            <td class="i">
                                <b>Project</b>&nbsp;:<%# Eval("FromProjectName")%><br />
                                <b>Store</b>&nbsp;:<%# Eval("FromStoreName")%>
                            </td>
                            <td class="i">
                                <b>Project</b>&nbsp;:<%# Eval("ToProjectName")%><br />
                                <b>Store</b>&nbsp;:<%# Eval("ToStoreName")%>
                            </td>
                            <td class="i">
                                <%# Eval("ItemName")%><br />
                                (<%# Eval("UnitName")%>)
                            </td>
                            <td class="i">
                                <%# Eval("RequestDate") != null ? ((DateTime)Eval("RequestDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("RequestQty")%>
                            </td>
                            <td class="i">
                                <%# Eval("SINIssueQty")%>
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
                            <td class="i" style="display: none;">
                                <%# Eval("TransferID")%>
                                <%# Eval("ItemID")%>
                                <%# Eval("TransferFromStoreID")%>
                                <%# Eval("TransferToStoreID")%>
                                <%# Eval("SINRequestedQty")%>
                                <%# Eval("SINTransferID")%>
                                <%# Eval("SINFromStoreID")%>
                                <%# Eval("SINToStoreID")%>
                            </td>
                            <td class="i">
                                <asp:HyperLink ID="hypTRFNo" runat="server" CssClass="CommonLink" Text='<%# Eval("TRFNo")%>'></asp:HyperLink>
                            </td>
                              <td class="i">
                                <b>Project</b>&nbsp;:<%# Eval("FromProjectName")%><br />
                                <b>Store</b>&nbsp;:<%# Eval("FromStoreName")%>
                            </td>
                            <td class="i">
                                <b>Project</b>&nbsp;:<%# Eval("ToProjectName")%><br />
                                <b>Store</b>&nbsp;:<%# Eval("ToStoreName")%>
                            </td>
                            <td class="i">
                                <%# Eval("ItemName")%><br />
                                (<%# Eval("UnitName")%>)
                            </td>
                            <td class="i">
                                <%# Eval("RequestDate") != null ? ((DateTime)Eval("RequestDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("RequestQty")%>
                            </td>
                            <td class="i">
                                <%# Eval("SINIssueQty")%>
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
            <asp:ObjectDataSource ID="odsINVTransfer_custom" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVTransaction_CustomDataSource"
                SortParameterName="sortExpression" OnSelecting="odsINVTransfer_Selecting">
                <SelectParameters>
                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                    <asp:Parameter Name="pageSize" Type="Int32" />
                    <asp:Parameter Name="sortExpression" Type="String" />
                    <asp:Parameter Name="filterExpression" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
