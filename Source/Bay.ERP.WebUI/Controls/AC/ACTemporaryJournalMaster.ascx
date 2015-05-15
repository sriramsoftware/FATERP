<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Feb-2013, 02:08:21
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACTemporaryJournalMaster.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACTemporaryJournalMasterControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>

        <div style="float: left; width: 600px;">
                <div class="TableRow" style="display:none; width:100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="ACAccountListEntity" Width="236">
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
                            ValidationGroup="ACAccountListEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtStartDate"
                            ErrorMessage="Please Enter Start Date" ValidationGroup="ACAccountListEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="ACAccountListEntity"></asp:RegularExpressionValidator>
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
                            ValidationGroup="ACAccountListEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEndDate"
                            ErrorMessage="Please Enter End Date" ValidationGroup="ACAccountListEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="ACAccountListEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSearch" ValidationGroup="ACAccountListEntity" OnClick="btnSearch_Click"
                            runat="server" Text="Show Report" />
                        <asp:Button ID="btnClearSearch" ValidationGroup="ACAccountListEntity" OnClick="btnClearSearch_Click"
                            runat="server" Text="Clear Search" />
                    </div>
                </div>
            </div>
         <div class="TableRow" style="width: 100%; padding-left:480px;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                           Type Reference,BA Name, Memo# Or Status</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                     Width="360" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"
                        Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
        <div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACTemporaryJournalMaster" runat="server" DataSourceID="odsACTemporaryJournalMaster" OnItemDataBound="lvACTemporaryJournalMaster_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width:200px;">
                                        Remarks
                                    </td>
                                    <td class="hi" style="width:250px;">
                                      Create Date
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Other Info
                                    </td>
                                    <td class="hi">
                                        Approval Status
                                    </td>
                                    <td class="hi">
                                        Report
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
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                <asp:HyperLink ID="hypCreateDate" Font-Bold="true" CssClass="CommonLink" runat="server" Text='<%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>' ></asp:HyperLink>
                                    <br />
                                    <asp:Label ID="lblDetailLV" runat="server"></asp:Label> 
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlOtherInfo" runat="server">
                                </asp:Panel>
                                </td>
                                <td class="i">
                                    <%# Eval("TemporaryJournalApprovalStatusName")%><br />
                                    <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                                </td>
                                 <td class="i">
                                <asp:HyperLink ID="hypJournalReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Report" CommandName="Report" CommandArgument='<%#Eval("TemporaryJournalMasterID")%>'></asp:HyperLink>
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
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                   <asp:HyperLink ID="hypCreateDate" Font-Bold="true" CssClass="CommonLink" runat="server" Text='<%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>' ></asp:HyperLink>
                                   <br />
                                    <asp:Label ID="lblDetailLV" runat="server"></asp:Label> 
                                </td>
                                <td class="i">
                                <asp:Panel ID="pnlOtherInfo" runat="server">
                                </asp:Panel>
                                </td>
                                <td class="i">
                                    <%# Eval("TemporaryJournalApprovalStatusName")%><br />
                                    <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                                </td>
                                 <td class="i">
                                <asp:HyperLink ID="hypJournalReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Report" CommandName="Report" CommandArgument='<%#Eval("TemporaryJournalMasterID")%>'></asp:HyperLink>
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
                <asp:ObjectDataSource ID="odsACTemporaryJournalMaster" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACTemporaryJournalMaster_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACTemporaryJournalMaster_Selecting">
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
