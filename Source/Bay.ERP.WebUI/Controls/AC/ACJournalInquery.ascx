<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 30-Jan-2013, 03:35:13
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACJournalInquery.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACJournalInqueryControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
             <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Reference&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtReferenceOrMemoOrID" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="ACJournalEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Note&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtNote" runat="server" ValidationGroup="ACJournalEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                 <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        From Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTransactionDateTime">
                            Enter Transaction From Date</label>
                        <asp:TextBox ID="txtTransactionDateTime" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="ACJournalEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTransactionDateTime" runat="server" ControlToValidate="txtTransactionDateTime"
                            ErrorMessage="Please Enter Transaction Date Time" ValidationGroup="ACJournalEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revTransactionDateTime" runat="server" ControlToValidate="txtTransactionDateTime"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="ACJournalEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                 <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        To Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTransactionToDateTime">
                            Enter Transaction To Date</label>
                        <asp:TextBox ID="txtTransactionToDateTime" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="ACJournalEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTransactionToDateTime" runat="server" ControlToValidate="txtTransactionToDateTime"
                            ErrorMessage="Please Enter Transaction Date Time" ValidationGroup="ACJournalEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revTransactionToDateTime" runat="server" ControlToValidate="txtTransactionToDateTime"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="ACJournalEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                  <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSearch" ValidationGroup="ACJournalEntity" OnClick="btnSearch_Click"
                            runat="server" Text="Search" />
                    </div>
                </div>
                <br />
       
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACJournal" runat="server" DataSourceID="odsACJournal">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Reference No
                                    </td>
                                     <td class="hi" style="width:250px;">
                                        Account Info
                                    </td>
                                    <td class="hi">
                                        Transaction Date Time
                                    </td>
                                    <td class="hi">
                                        Amount
                                    </td>
                                    <td class="hi">
                                        Entered By Employee
                                    </td>
                                    <td class="hi">
                                        Note
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi" style="width:150px;">
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
                                    <%# Eval("ReferenceOrMemoOrID")%>
                                </td>
                                 <td class="i">
                                  <b>Account Group:</b>&nbsp;<%# Eval("ACAccountGroupName")%><br />
                                  <b>Account:</b>&nbsp;<%# Eval("AccountCode")%>'-'<%# Eval("ACAccountAccountName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransactionDateTime") != null ? ((DateTime)Eval("TransactionDateTime")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                   <b><%# Bay.ERP.Web.UI.MiscUtil.NumericCommaSeperatedFormat((Decimal)Eval("Amount"))%></b><br />
                                    (<%# Eval("ACMDDebitCreditName")%>)
                                </td>
                                <td class="i">
                                    <%# Eval("MemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Note")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                       <b>Requisition:</b> &nbsp; <%# Eval("RequisitionNo")%><br />
                                        <b>WorkOrder:</b> &nbsp;<%# Eval("WorkOrderNo")%><br />
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
                                    <%# Eval("ReferenceOrMemoOrID")%>
                                </td>
                                <td class="i">
                                  <b>Account Group:</b>&nbsp;<%# Eval("ACAccountGroupName")%><br />
                                  <b>Account:</b>&nbsp;<%# Eval("AccountCode")%>'-'<%# Eval("ACAccountAccountName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransactionDateTime") != null ? ((DateTime)Eval("TransactionDateTime")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                 <b><%# Bay.ERP.Web.UI.MiscUtil.NumericCommaSeperatedFormat((Decimal)Eval("Amount"))%></b><br />
                                    (<%# Eval("ACMDDebitCreditName")%>)
                                </td>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Note")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                       <b>Requisition:</b> &nbsp; <%# Eval("RequisitionNo")%><br />
                                        <b>WorkOrder:</b> &nbsp;<%# Eval("WorkOrderNo")%><br />
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
                <asp:ObjectDataSource ID="odsACJournal" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACJournal_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACJournal_Selecting">
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
