<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Dec-2012, 12:52:14
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVStoreIssueNoteItemMapReport.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVStoreIssueNoteItemMapReportControl" %>
<script language="javascript" type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#txtLandAreaKatha").keyup(function () {
                $("#txtLandAreaSft").val($(this).val() * 720);
            });
        });
    }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
        </script>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Item&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvItemID" runat="server" ControlToValidate="ddlItemID"
                        ErrorMessage="Please Select Item" ValidationGroup="INVStoreIssueNoteItemMapEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Employee&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlReceivedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="236">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSearch" ValidationGroup="INVStoreIssueNoteItemMapEntity"
                        UniqueKey="INVStoreIssueNoteItemMapControl_Search_key" OnClick="btnSearch_Click"
                        runat="server" Text="Search" />
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Store Issue Report
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVStoreIssueNoteItemMap" runat="server" DataSourceID="odsINVStoreIssueNoteItemMap"
                        OnItemDataBound="lvINVStoreIssueNoteItemMap_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Project Code
                                    </td>
                                    <td class="hi">
                                        Project Name
                                    </td>
                                    <td class="hi">
                                        Issued Qty
                                    </td>
                                    <td class="hi">
                                        Requested Qty
                                    </td>
                                    <td class="hi">
                                        Actual Issued Qty
                                    </td>
                                    <td class="hi">
                                        Store Name
                                    </td>
                                    <td class="hi">
                                        Item Name
                                    </td>
                                    <td class="hi">
                                        Unit Name
                                    </td>
                                    <td class="hi">
                                        Details
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
                                    <%# Eval("ProjectCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssuedQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequestedQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualIssuedQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StoreName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkItemDetails" runat="server" CssClass="CommonButtonLink" Text="Details"
                                        CommandName="ItemDetails" CommandArgument='<%#Eval("IssuedFromStoreID")%>' />
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
                                    <%# Eval("ProjectCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IssuedQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequestedQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualIssuedQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StoreName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkItemDetails" runat="server" CssClass="CommonButtonLink" Text="Details"
                                        CommandName="ItemDetails" CommandArgument='<%#Eval("IssuedFromStoreID")%>' />
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
                <asp:ObjectDataSource ID="odsINVStoreIssueNoteItemMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVStoreIssueNoteItemMap_RPTDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVStoreIssueNoteItemMap_Selecting">
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
