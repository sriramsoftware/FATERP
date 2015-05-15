<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTDailyLogList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.OTDailyLogListControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div class="TableRow" style="width: 100%; padding-left: 600px;">
                <div class="TableFormLeble" style="text-align: right;">
                    Log Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtDate">
                        Enter Date</label>
                    <asp:TextBox ID="txtDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="OTDailyLogIssue" Width="230" />
                    <span class="RequiredField">*</span>
                    <span>
                        <asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true" ValidationGroup="OTDailyLogIssue"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Show Task" /></span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvDate" runat="server" ControlToValidate="txtDate"
                        ErrorMessage="Please Enter Date" ValidationGroup="REQRequisitionEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revDate" runat="server" ControlToValidate="txtDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="REQRequisitionEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="listContentTitle">
                <asp:Label ID="lblIssueList" runat="server" Text=""></asp:Label>
            </div>
            <div>
                <div class="d-lv-c">
                    <asp:ListView ID="lvOTIssue_Detailed" runat="server" DataSourceID="odsOTIssue_Detailed" InsertItemPosition="LastItem" OnItemCreated="lvOTIssue_Detailed_ItemCreated"
                        OnItemDataBound="lvOTIssue_Detailed_ItemDataBound" OnItemCommand="lvOTIssue_Detailed_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">&nbsp;
                                    </td>
                                    <td class="hi" style="width: 80px; display: none;">&nbsp;
                                    </td>
                                    <td class="hi" style="width: 30px; display: none;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByIssueNo"
                                            CommandName="Sort" Text="Issue No" CommandArgument="OTIssue.IssueID" />
                                    </td>
                                    <td class="hi" style="display: none;">Issue Identity Category
                                    </td>
                                    <td class="hi" style="width: 140px;">Project
                                    </td>
                                    <td class="hi" style="width: 350px;">Task
                                    </td>
                                    <td class="hi">Hour(hh:mm)
                                    </td>
                                    <td class="hi" style="width: 140px;">Category
                                    </td>
                                    <td class="hi" style="width: 140px;">Status
                                    </td>
                                    <td class="hi" style="display: none;">Parent Issue
                                    </td>
                                    <td class="hi" style="display: none;">Reference
                                    </td>
                                    <td class="hi" style="display: none;">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPriority"
                                            CommandName="Sort" Text="Priority" CommandArgument="MDIssuePriority.Name" />
                                    </td>
                                    <td class="hi" style="display: none;">Description
                                    </td>
                                    <td class="hi" style="width: 165px; display: none;">Member
                                    </td>
                                    <td class="hi" style="width: 100px; display: none;">Expected
                                    </td>
                                    <td class="hi" style="width: 100px; display: none;">Actual
                                    </td>
                                    <td class="hi" style="display: none;">Notify Before Min
                                    </td>
                                    <td class="hi" style="display: none;">Is Notify Completed
                                    </td>
                                    <td class="hi" style="display: none;">Remarks
                                    </td>
                                    <td class="hi" style="display: none;">Reference Issue
                                    </td>
                                    <td class="hi" style="display: none;">Is Removed
                                    </td>
                                    <td class="hi" style="width: 50px; display: none;">Supervisor Agreed
                                    </td>
                                    <td class="hi" style="display: none;">Modified By Supervisor Date Time
                                    </td>
                                    <td class="hi" style="display: none;">I P
                                    </td>
                                    <td class="his" style="width: 24px;">Edit
                                    </td>
                                    <td class="his" style="width: 70px;">Additional
                                    </td>
                                    <td class="his" style="display: none;">DELETE
                                    </td>
                                    <td class="rpb">&nbsp;
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
                                <td class="rp">&nbsp;
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Button ID="btnCompletedLV" Text="Complete" runat="server" CommandName="UpdateItem"
                                        OnClientClick="return confirm('Are you sure to Complete?')" CommandArgument='<%#Eval("IssueID")%>'
                                        ToolTip='<%# Eval("CompletionPercentage")%>'></asp:Button>
                                    <%#Decimal.Round((Decimal)Eval("CompletionPercentage"),0)%>%
                                </td>
                                <td class="i">
                                    <asp:DropDownList ID="ddlProjectIDLV" runat="server" ValidationGroup="OTDailyLogEnity" Width="150" Visible="false">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvProjectIDLV" runat="server" ControlToValidate="ddlProjectIDLV"
                                        ErrorMessage="Please Select Project" ValidationGroup="OTDailyLogEnity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblProjectLV" runat="server" Text='<%# Eval("ProjectName")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtTitleLV" CssClass="ktiTextBoxListview" runat="server" ValidationGroup="OTDailyLogEnity" TextMode="MultiLine" Visible="false" Text='<%# Eval("Title")%>' Width="357" Height="27" Font-Size="12"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvlstDescription" runat="server" ControlToValidate="txtTitleLV"
                                        ErrorMessage="Enter Title" ValidationGroup="OTDailyLogEnity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblTitleLV" runat="server" Text='<%# Eval("Title")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtDurationLV" CssClass="ktiTextBoxListview" ValidationGroup="OTDailyLogEnity" Visible="false" Text='<%#FormatTime(Eval("DTLDuration"))%>'
                                        runat="server"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvDurationLV" runat="server" ControlToValidate="txtDurationLV"
                                            ErrorMessage="Enter Duration" ValidationGroup="OTDailyLogEnity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revDTLDuration" runat="server" ControlToValidate="txtDurationLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07:25)" ValidationExpression="^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$"
                                            ValidationGroup="OTDailyLogEnity"></asp:RegularExpressionValidator>
                                    </div>
                                    <asp:Label ID="lblDurationLV" runat="server" Text='<%#FormatTime(Eval("DTLDuration"))%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:DropDownList ID="ddlIssueCategoryLV" runat="server" ValidationGroup="OTDailyLogEnity" Width="150" Visible="false">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvIssueCategoryIDLV" runat="server" ControlToValidate="ddlIssueCategoryLV"
                                        ErrorMessage="Please Select Issue Category" ValidationGroup="OTDailyLogEnity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblIssueCategoryLV" runat="server" Text='<%# Eval("IssueCategoryName")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:DropDownList ID="ddlIssueStatusLV" runat="server" ValidationGroup="OTDailyLogEnity" Width="150" Visible="false">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvddlIssueStatusIDLV" runat="server" ControlToValidate="ddlIssueStatusLV"
                                            ErrorMessage="Please Select Issue Status" ValidationGroup="OTDailyLogEnity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                    <asp:Label ID="lblIssueStatusLV" runat="server" Text='<%# Eval("IssueStatusName")%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IssueID")%>
                                    <asp:Label ID="lblIssueCategoryIDLV" runat="server" Text='<%# Eval("IssueCategoryID")%>'></asp:Label>
                                    <asp:Label ID="lblIssueStatusIDLV" runat="server" Text='<%# Eval("IssueStatusID")%>'></asp:Label>
                                    <%# Eval("ParentIssueID")%>
                                    <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ReferenceID")%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblIssuePriorityNameLV" runat="server" Text='<%# Eval("IssuePriorityName")%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <b>Created</b>:&nbsp;<%# Eval("MemberFullName")%>
                                    <b>Supervisor</b>:&nbsp;<%# Eval("SupervisorFullName")%>
                                    <b>Assigned</b>:&nbsp;<%# Eval("AssignedToFullName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <b>Create</b>:&nbsp<%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <b>Start</b>:&nbsp<%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <br />
                                    <b>End</b>:&nbsp<asp:Label ID="lblExpectedEndDateLV" runat="server" Text='<%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <b>Start</b>:&nbsp<%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <br />
                                    <b>End</b>:&nbsp<%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                    <%# Eval("ReferenceIssueID")%>
                                    <%# Eval("IsNotifyCompleted") != null ? (((Boolean)Eval("IsNotifyCompleted")) ? "Yes" : "No") : ""%>
                                    <%# Eval("NotifyBeforeMin")%>
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblSupervisorAgreedLV" runat="server" Text='<%# Eval("SupervisorAgreed") != null ? (((Boolean)Eval("SupervisorAgreed")) ? "Yes" : "No") : ""%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ModifiedBySupervisorDateTime") != null ? ((DateTime)Eval("ModifiedBySupervisorDateTime")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEditGrid" runat="server" CssClass="CommonButtonLink" Text="Edit" CommandName="EditGrid"
                                        CommandArgument='<%#Eval("IssueID")%>' /><br />
                                    <asp:LinkButton ID="lnkBtnUpdateGrid" runat="server" CssClass="CommonButtonLink" Text="Update" CommandName="UpdateGrid" Visible="false" CommandArgument='<%#Eval("IssueID")%>' /><br />
                                    <asp:LinkButton ID="lnBtnCancelGrid" runat="server" CssClass="CommonButtonLink" Text="Cancel" CommandName="CancelGridEdit" Visible="false" CommandArgument='<%#Eval("IssueID")%>' />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypEdit" runat="server" Text="Log Time" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypEditDetails" runat="server" Text="Edit" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypAssignedResource" runat="server" Text="Assigned" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Visible="false" Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue?')"
                                        CommandArgument='<%#Eval("IssueID")%>' UniqueKey="OTIssue_lvOTIssue_Edit_key" /><br />
                                </td>
                                <td class="rpb">&nbsp;
                                </td>
                            </tr>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <tr class="ar">
                                <td class="rp">&nbsp;
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Button ID="btnCompletedLV" Text="Complete" runat="server" CommandName="UpdateItem"
                                        OnClientClick="return confirm('Are you sure to Complete?')" CommandArgument='<%#Eval("IssueID")%>'
                                        ToolTip='<%# Eval("CompletionPercentage")%>'></asp:Button>
                                    <%#Decimal.Round((Decimal)Eval("CompletionPercentage"),0)%>%
                                </td>
                                <td class="i">
                                    <asp:DropDownList ID="ddlProjectIDLV" runat="server" ValidationGroup="OTDailyLogEnity" Width="150" Visible="false">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvProjectIDLV" runat="server" ControlToValidate="ddlProjectIDLV"
                                        ErrorMessage="Please Select Project" ValidationGroup="OTDailyLogEnity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblProjectLV" runat="server" Text='<%# Eval("ProjectName")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtTitleLV" CssClass="ktiTextBoxListview" runat="server" ValidationGroup="OTDailyLogEnity" TextMode="MultiLine" Visible="false" Text='<%# Eval("Title")%>' Width="357" Height="27" Font-Size="12"></asp:TextBox>
                                    <asp:RequiredFieldValidator ID="rfvlstDescription" runat="server" ControlToValidate="txtTitleLV"
                                        ErrorMessage="Enter Title" ValidationGroup="OTDailyLogEnity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblTitleLV" runat="server" Text='<%# Eval("Title")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtDurationLV" CssClass="ktiTextBoxListview" ValidationGroup="OTDailyLogEnity" Visible="false" Text='<%#FormatTime(Eval("DTLDuration"))%>'
                                        runat="server"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvDurationLV" runat="server" ControlToValidate="txtDurationLV"
                                            ErrorMessage="Enter Duration" ValidationGroup="OTDailyLogEnity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revDTLDuration" runat="server" ControlToValidate="txtDurationLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07:25)" ValidationExpression="^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$"
                                            ValidationGroup="OTDailyLogEnity"></asp:RegularExpressionValidator>
                                    </div>
                                    <asp:Label ID="lblDurationLV" runat="server" Text='<%#FormatTime(Eval("DTLDuration"))%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:DropDownList ID="ddlIssueCategoryLV" runat="server" ValidationGroup="OTDailyLogEnity" Width="150" Visible="false">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvIssueCategoryIDLV" runat="server" ControlToValidate="ddlIssueCategoryLV"
                                        ErrorMessage="Please Select Issue Category" ValidationGroup="OTDailyLogEnity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    <asp:Label ID="lblIssueCategoryLV" runat="server" Text='<%# Eval("IssueCategoryName")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:DropDownList ID="ddlIssueStatusLV" runat="server" ValidationGroup="OTDailyLogEnity" Width="150" Visible="false">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvddlIssueStatusIDLV" runat="server" ControlToValidate="ddlIssueStatusLV"
                                            ErrorMessage="Please Select Issue Status" ValidationGroup="OTDailyLogEnity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                    <asp:Label ID="lblIssueStatusLV" runat="server" Text='<%# Eval("IssueStatusName")%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("IssueID")%>
                                    <asp:Label ID="lblIssueCategoryIDLV" runat="server" Text='<%# Eval("IssueCategoryID")%>'></asp:Label>
                                    <asp:Label ID="lblIssueStatusIDLV" runat="server" Text='<%# Eval("IssueStatusID")%>'></asp:Label>
                                    <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ReferenceID")%>'></asp:Label>
                                    <%# Eval("ParentIssueID")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblIssuePriorityNameLV" runat="server" Text='<%# Eval("IssuePriorityName")%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <b>Created</b>:&nbsp;<%# Eval("MemberFullName")%>
                                    <b>Supervisor</b>:&nbsp;<%# Eval("SupervisorFullName")%>
                                    <b>Assigned</b>:&nbsp;<%# Eval("AssignedToFullName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <b>Create</b>:&nbsp<%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <b>Start</b>:&nbsp<%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <br />
                                    <b>End</b>:&nbsp<asp:Label ID="lblExpectedEndDateLV" runat="server" Text='<%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <b>Start</b>:&nbsp<%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    <br />
                                    <b>End</b>:&nbsp<%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                    <%# Eval("ReferenceIssueID")%>
                                    <%# Eval("IsNotifyCompleted") != null ? (((Boolean)Eval("IsNotifyCompleted")) ? "Yes" : "No") : ""%>
                                    <%# Eval("NotifyBeforeMin")%>
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblSupervisorAgreedLV" runat="server" Text='<%# Eval("SupervisorAgreed") != null ? (((Boolean)Eval("SupervisorAgreed")) ? "Yes" : "No") : ""%>'></asp:Label>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("ModifiedBySupervisorDateTime") != null ? ((DateTime)Eval("ModifiedBySupervisorDateTime")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEditGrid" runat="server" CssClass="CommonButtonLink" Text="Edit" CommandName="EditGrid"
                                        CommandArgument='<%#Eval("IssueID")%>' />
                                    <br />
                                    <asp:LinkButton ID="lnkBtnUpdateGrid" runat="server" CssClass="CommonButtonLink" Text="Update" CommandName="UpdateGrid" Visible="false" CommandArgument='<%#Eval("IssueID")%>' /><br />
                                    <asp:LinkButton ID="lnBtnCancelGrid" runat="server" CssClass="CommonButtonLink" Text="Cancel" CommandName="CancelGridEdit" Visible="false" CommandArgument='<%#Eval("IssueID")%>' />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypEdit" runat="server" Text="Log Time" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypEditDetails" runat="server" Text="Edit" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypAssignedResource" runat="server" Text="Assigned" CssClass="CommonButtonLink"></asp:HyperLink><br />
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Visible="false" Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue?')"
                                        CommandArgument='<%#Eval("IssueID")%>' UniqueKey="OTIssue_lvOTIssue_Edit_key" />
                                </td>
                                <td class="rpb">&nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <InsertItemTemplate>
                            <tr class="ar">
                                <td class="rp">&nbsp;
                                </td>
                                <td class="i">
                                    <asp:DropDownList ID="ddlProjectIDLV" runat="server" ValidationGroup="OTDailyLogEnity" Width="150">
                                    </asp:DropDownList>
                                    <asp:RequiredFieldValidator ID="rfvProjectIDLV" runat="server" ControlToValidate="ddlProjectIDLV"
                                        ErrorMessage="Please Select Project" ValidationGroup="OTDailyLogEnity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtTitleLV" CssClass="ktiTextBoxListview" runat="server" ValidationGroup="OTDailyLogEnity" TextMode="MultiLine" Width="354" Height="27" Font-Size="12"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvlstDescription" runat="server" ControlToValidate="txtTitleLV"
                                            ErrorMessage="Enter Title" ValidationGroup="OTDailyLogEnity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtDurationLV" CssClass="ktiTextBoxListview" ValidationGroup="OTDailyLogEnity" runat="server"></asp:TextBox>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvDurationLV" runat="server" ControlToValidate="txtDurationLV"
                                            ErrorMessage="Enter Duration" ValidationGroup="OTDailyLogEnity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revDTLDuration" runat="server" ControlToValidate="txtDurationLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07:25)" ValidationExpression="^(?:(?:([01]?\d|2[0-3]):)?([0-5]?\d):)?([0-5]?\d)$"
                                            ValidationGroup="OTDailyLogEnity"></asp:RegularExpressionValidator>
                                    </div>
                                    <asp:Label ID="lblDurationLV" runat="server" Text='<%#FormatTime(Eval("DTLDuration"))%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:DropDownList ID="ddlIssueCategoryIDLV" runat="server" ValidationGroup="OTDailyLogEnity" Width="150">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvIssueCategoryIDLV" runat="server" ControlToValidate="ddlIssueCategoryIDLV"
                                            ErrorMessage="Please Select Issue Category" ValidationGroup="OTDailyLogEnity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:DropDownList ID="ddlIssueStatusIDLV" runat="server" ValidationGroup="OTDailyLogEnity" Width="150">
                                        </asp:DropDownList>
                                        <asp:RequiredFieldValidator ID="rfvddlIssueStatusIDLV" runat="server" ControlToValidate="ddlIssueStatusIDLV"
                                            ErrorMessage="Please Select Issue Status" ValidationGroup="OTDailyLogEnity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnInsert" runat="server" CssClass="CommonButtonLink"
                                        ValidationGroup="OTDailyLogEnity" Text="Insert" CommandName="InsertItem" />
                                </td>
                                <td class="i"></td>
                                <td class="rp">&nbsp;
                                </td>
                                <td class="rpb">&nbsp;
                                </td>
                            </tr>
                        </InsertItemTemplate>
                        <EmptyDataTemplate>
                            <div class="d-edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsOTIssue_Detailed" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.OTIssue_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsOTIssue_Detailed_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <br />
            <br />
            <div style="padding-left: 450px; font-size: 15px; font-weight: bold;">
                <asp:Label ID="lblTotalTimeSpan" runat="server"></asp:Label>
            </div>
            <div style="text-align: right;">
                <asp:HyperLink ID="hypIssueWeeklyReport" CssClass="linkButton" runat="server" Text="Daily Report" NavigateUrl="~/OT/OTIssueReport.aspx" Target="_blank"></asp:HyperLink>
                <asp:HyperLink ID="hypIssueDatewiseReport" CssClass="linkButton" runat="server" Text="Weekly Report" NavigateUrl="~/OT/OTDailyLogDatewiseIndividual.aspx" Target="_blank"></asp:HyperLink>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
