<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMMaterialReceiveList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMMaterialReceiveListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div style="float: left; width: 600px;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="PRMMaterialReceiveEntity" Width="236">
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
                            ErrorMessage="Please Enter Start Date" ValidationGroup="PRMMaterialReceiveEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="PRMMaterialReceiveEntity"></asp:RegularExpressionValidator>
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
                            ValidationGroup="PRMMaterialReceiveEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtEndDate"
                            ErrorMessage="Please Enter End Date" ValidationGroup="PRMMaterialReceiveEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator2" runat="server" ControlToValidate="txtEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="PRMMaterialReceiveEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSearch" ValidationGroup="PRMMaterialReceiveEntity" OnClick="btnSearch_Click"
                            runat="server" Text="Show Report" />
                        <asp:Button ID="btnClearSearch" ValidationGroup="PRMMaterialReceiveEntity" OnClick="btnClearSearch_Click"
                            runat="server" Text="Clear Search" />
                    </div>
                </div>
            </div>
            <div class="TableRow" style="width: 100; padding-left: 635px;">
                <div class="TableFormLeble" style="text-align: right;">
                    Filter Text&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        Type MRR</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Filter" /></span>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvPRMMaterialReceive" runat="server" DataSourceID="odsPRMMaterialReceive"
                        OnItemCommand="lvPRMMaterialReceive_ItemCommand" OnItemDataBound="lvPRMMaterialReceive_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width: 150px;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByMRRNo"
                                            CommandName="Sort" Text="MRR No" CommandArgument="PRMMaterialReceive.MRRNo" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByMRRDate"
                                            CommandName="Sort" Text="MRR Date" CommandArgument="PRMMaterialReceive.MRRDate" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByProject"
                                            CommandName="Sort" Text="Project" CommandArgument="BDProject.ProjectName" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplier"
                                            CommandName="Sort" Text="Supplier" CommandArgument="PRMSupplier.SupplierName" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequisition"
                                            CommandName="Sort" Text="Requisition" CommandArgument="REQRequisition.RequisitionNo" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByWorkOrder"
                                            CommandName="Sort" Text="Work Order" CommandArgument="PRMWorkOrder.WorkOrderNo" />
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Remarks
                                    </td>
                                    <td class="his" style="display: none;">
                                        EDIT
                                    </td>
                                    <td class="his" style="display: none;">
                                        DELETE
                                    </td>
                                    <td class="his">
                                        Report
                                    </td>
                                    <td class="hi" style="width: 120px;">
                                        Approval Status
                                    </td>
                                    <td class="hi">
                                        AP View
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
                                    <asp:HyperLink ID="hypMRRNo" runat="server" Text='<%# Eval("MRRNo")%>' CssClass="CommonLink"
                                        ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("MRRDate") != null ? ((DateTime)Eval("MRRDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PRMSupplierSupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderNo")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:HyperLink ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("MaterialReceiveID")%>' UniqueKey="PRMMaterialReceiveList_lvPRMMaterialReceive_Edit_key"></asp:HyperLink>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Material Receive?')"
                                        CommandArgument='<%#Eval("MaterialReceiveID")%>' UniqueKey="PRMMaterialReceiveList_lvPRMMaterialReceive_Delete_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypMateialReceiveReport" runat="server" CssClass="CommonButtonLink"
                                        Text="Report" CommandName="MateialReceiveReport" CommandArgument='<%#Eval("MaterialReceiveID")%>'
                                        UniqueKey="PRMMaterialReceiveList_lvPRMMaterialReceive_MaterialReceiveReport_key"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("MaterialReceiveApprovalStatusName")%><br />
                                    <asp:Button ID="btnResetMaterialRecieveLV" Text="Reset AP" runat="server" CommandName="ResetAP"
                                        OnClientClick="return confirm('Are you sure to Reset Approval Process?')" CommandArgument='<%#Eval("MaterialReceiveID")%>'>
                                    </asp:Button>
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
                                    <asp:HyperLink ID="hypMRRNo" runat="server" Text='<%# Eval("MRRNo")%>' CssClass="CommonLink"
                                        ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("MRRDate") != null ? ((DateTime)Eval("MRRDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PRMSupplierSupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderNo")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:HyperLink ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("MaterialReceiveID")%>' UniqueKey="PRMMaterialReceiveList_lvPRMMaterialReceive_Edit_key"></asp:HyperLink>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Material Receive?')"
                                        CommandArgument='<%#Eval("MaterialReceiveID")%>' UniqueKey="PRMMaterialReceiveList_lvPRMMaterialReceive_Delete_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypMateialReceiveReport" runat="server" CssClass="CommonButtonLink"
                                        Text="Report" CommandName="MateialReceiveReport" CommandArgument='<%#Eval("MaterialReceiveID")%>'
                                        UniqueKey="PRMMaterialReceiveList_lvPRMMaterialReceive_MaterialReceiveReport_key"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("MaterialReceiveApprovalStatusName")%><br />
                                    <asp:Button ID="btnResetMaterialRecieveLV" Text="Reset AP" runat="server" CommandName="ResetAP"
                                        OnClientClick="return confirm('Are you sure to Reset Approval Process?')" CommandArgument='<%#Eval("MaterialReceiveID")%>'>
                                    </asp:Button>
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
                <asp:ObjectDataSource ID="odsPRMMaterialReceive" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMMaterialReceive_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsPRMMaterialReceive_Selecting">
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
