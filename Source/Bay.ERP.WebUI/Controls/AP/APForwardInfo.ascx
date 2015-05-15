<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 22-Oct-2012, 04:39:52
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="APForwardInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.APForwardInfoControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
            ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="true"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
            <div id="divCollapsControl" class="divCollapsControl">
                <div style="float: left; height: 16px; width: 16px;">
                    <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                </div>
                <div style="float: left; padding-left: 3px;">
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit A PForward Info"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
        <div>
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        A PMember Feedback&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAPMemberFeedbackID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="APForwardInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAPMemberFeedbackID" runat="server" ControlToValidate="ddlAPMemberFeedbackID"
                            ErrorMessage="Please Select A PMember Feedback" ValidationGroup="APForwardInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        A PApproval Process&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAPApprovalProcessID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="APForwardInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAPApprovalProcessID" runat="server" ControlToValidate="ddlAPApprovalProcessID"
                            ErrorMessage="Please Select A PApproval Process" ValidationGroup="APForwardInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        A PMember Feedback Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAPMemberFeedbackRemarksID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="APForwardInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAPMemberFeedbackRemarksID" runat="server" ControlToValidate="ddlAPMemberFeedbackRemarksID"
                            ErrorMessage="Please Select A PMember Feedback Remarks" ValidationGroup="APForwardInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Department&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDepartmentID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="APForwardInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDepartmentID" runat="server" ControlToValidate="ddlDepartmentID"
                            ErrorMessage="Please Select Department" ValidationGroup="APForwardInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="APForwardInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeID" runat="server" ControlToValidate="ddlEmployeeID"
                            ErrorMessage="Please Select Employee" ValidationGroup="APForwardInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Comment Request Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCommentRequestDate">
                            Enter Comment Request Date</label>
                        <asp:TextBox ID="txtCommentRequestDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="APForwardInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCommentRequestDate" runat="server" ControlToValidate="txtCommentRequestDate"
                            ErrorMessage="Please Enter Comment Request Date" ValidationGroup="APForwardInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCommentRequestDate" runat="server" ControlToValidate="txtCommentRequestDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="APForwardInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Comment Submit Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCommentSubmitDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="APForwardInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revCommentSubmitDate" runat="server" ControlToValidate="txtCommentSubmitDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="APForwardInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        A PMember Comment&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtAPMemberComment" runat="server" ValidationGroup="APForwardInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        A PForward Member Comment&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtAPForwardMemberComment" runat="server" ValidationGroup="APForwardInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="APForwardInfoEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="APForwardInfoControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="APForwardInfoControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="APForwardInfoControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                A PForward Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvAPForwardInfo" runat="server" DataSourceID="odsAPForwardInfo" OnItemCommand="lvAPForwardInfo_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        A PMember Feedback
                                    </td>
                                    <td class="hi">
                                        A PApproval Process
                                    </td>
                                    <td class="hi">
                                        A PMember Feedback Remarks
                                    </td>
                                    <td class="hi">
                                        Department
                                    </td>
                                    <td class="hi">
                                        Employee
                                    </td>
                                    <td class="hi">
                                        Comment Request Date
                                    </td>
                                    <td class="hi">
                                        Comment Submit Date
                                    </td>
                                    <td class="hi">
                                        A PMember Comment
                                    </td>
                                    <td class="hi">
                                        A PForward Member Comment
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
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
                                    <%# Eval("APMemberFeedbackID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("APApprovalProcessID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("APMemberFeedbackRemarksID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepartmentID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommentRequestDate") != null ? ((DateTime)Eval("CommentRequestDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommentSubmitDate") != null ? ((DateTime)Eval("CommentSubmitDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("APMemberComment")%>
                                </td>
                                <td class="i">
                                    <%# Eval("APForwardMemberComment")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("APForwardInfoID")%>' UniqueKey="APForwardInfo_lvAPForwardInfo_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A PForward Info?')"
                                        CommandArgument='<%#Eval("APForwardInfoID")%>' UniqueKey="APForwardInfo_lvAPForwardInfo_Delete_key"/>
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
                                    <%# Eval("APMemberFeedbackID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("APApprovalProcessID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("APMemberFeedbackRemarksID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepartmentID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommentRequestDate") != null ? ((DateTime)Eval("CommentRequestDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommentSubmitDate") != null ? ((DateTime)Eval("CommentSubmitDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("APMemberComment")%>
                                </td>
                                <td class="i">
                                    <%# Eval("APForwardMemberComment")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("APForwardInfoID")%>' UniqueKey="APForwardInfo_lvAPForwardInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A PForward Info?')"
                                        CommandArgument='<%#Eval("APForwardInfoID")%>' UniqueKey="APForwardInfo_lvAPForwardInfo_Delete_key"/>
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
                <asp:ObjectDataSource ID="odsAPForwardInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.APForwardInfoDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsAPForwardInfo_Selecting">
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