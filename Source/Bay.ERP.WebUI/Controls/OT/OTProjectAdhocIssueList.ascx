<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTProjectAdhocIssueList.ascx.cs" Inherits="Bay.ERP.Web.UI.OTProjectAdhocIssueListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <%--<ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
            ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="true"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>--%>
        <%--<asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
            <div id="divCollapsControl" class="divCollapsControl">
                <div style="float: left; height: 16px; width: 16px;">
                    <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                </div>
                <div style="float: left; padding-left: 3px;">
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Search Issue"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>--%>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
        <div>
          <%--  <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Issue Identity Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlIssueIdentityCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvIssueIdentityCategoryID" runat="server" ControlToValidate="ddlIssueIdentityCategoryID"
                            ErrorMessage="Please Select Issue Identity Category" ValidationGroup="OTIssueEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Issue Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlIssueCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvIssueCategoryID" runat="server" ControlToValidate="ddlIssueCategoryID"
                            ErrorMessage="Please Select Issue Category" ValidationGroup="OTIssueEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Parent Issue&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlParentIssueID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Reference&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtReferenceID" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="OTIssueEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvReferenceID" runat="server" ControlToValidate="txtReferenceID"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="OTIssueEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Title&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTitle">
                            Enter Title</label>
                        <asp:TextBox ID="txtTitle" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="OTIssueEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle"
                            ErrorMessage="Please Enter Title" ValidationGroup="OTIssueEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtDescription" runat="server" ValidationGroup="OTIssueEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Issue Priority&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlIssuePriorityID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvIssuePriorityID" runat="server" ControlToValidate="ddlIssuePriorityID"
                            ErrorMessage="Please Select Issue Priority" ValidationGroup="OTIssueEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Completion Percentage&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCompletionPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCompletionPercentage" runat="server" ControlToValidate="txtCompletionPercentage"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="OTIssueEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Issue Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlIssueStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvIssueStatusID" runat="server" ControlToValidate="ddlIssueStatusID"
                            ErrorMessage="Please Select Issue Status" ValidationGroup="OTIssueEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Created By Member&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCreatedByMemberID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreatedByMemberID" runat="server" ControlToValidate="ddlCreatedByMemberID"
                            ErrorMessage="Please Select Created By Member" ValidationGroup="OTIssueEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Create Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCreateDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="OTIssueEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="OTIssueEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Duration&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDuration" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvDuration" runat="server" ControlToValidate="txtDuration"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="OTIssueEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Expected Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtExpectedStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="OTIssueEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revExpectedStartDate" runat="server" ControlToValidate="txtExpectedStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="OTIssueEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Expected End Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtExpectedEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="OTIssueEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revExpectedEndDate" runat="server" ControlToValidate="txtExpectedEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="OTIssueEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Actual Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtActualStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="OTIssueEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revActualStartDate" runat="server" ControlToValidate="txtActualStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="OTIssueEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Actual End Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtActualEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="OTIssueEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revActualEndDate" runat="server" ControlToValidate="txtActualEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="OTIssueEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Notify Before Min&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNotifyBeforeMin" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="OTIssueEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNotifyBeforeMin" runat="server" ControlToValidate="txtNotifyBeforeMin"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="OTIssueEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Notify Completed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsNotifyCompleted" runat="server" ClientIDMode="Static" ValidationGroup="OTIssueEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="OTIssueEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Reference Issue&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlReferenceIssueID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="OTIssueEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="OTIssueEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="OTIssueEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="OTProjectAdhocIssueListControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="OTProjectAdhocIssueListControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="OTProjectAdhocIssueListControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>--%>
            <div class="listContentTitle">
            Project Adhoc Issue List
            </div>
            <div>
                <div class="d-lv-c">
                    <asp:ListView ID="lvOTIssue_Detailed" runat="server" DataSourceID="odsOTIssue_Detailed" OnItemDataBound="lvOTIssue_Detailed_ItemDataBound" OnItemCommand="lvOTIssue_Detailed_ItemCommand">
                        <LayoutTemplate>
                            <div class="d-lv">
                                <div class="d-lv-header">
                                    Some Header will Come Here</div>
                                <div class="d-lv-container">
                                    <div runat="server" id="itemPlaceholder">
                                    </div>
                                </div>
                                <div class="d-lv-FooterContainer">
                                    <div class="d-lv-Footer">
                                        <asp:DataPager ID="dpListView" runat="server" PageSize="15">
                                            <Fields>
                                                <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="d-lv-PagerItem" FirstPageImageUrl="~/Images/CustomListView/Default/FT.png"
                                                    PreviousPageImageUrl="~/Images/CustomListView/Default/PT.png" ShowFirstPageButton="true"
                                                    ShowPreviousPageButton="true" ShowNextPageButton="false" ShowLastPageButton="false" />
                                                <asp:NumericPagerField ButtonType="Button" ButtonCount="10" NumericButtonCssClass="d-lv-PagerItemNumeric"
                                                    CurrentPageLabelCssClass="d-lv-PagerItemNumericCurrent" RenderNonBreakingSpacesBetweenControls="false" />
                                                <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="d-lv-PagerItem" NextPageImageUrl="~/Images/CustomListView/Default/NT.png"
                                                    LastPageImageUrl="~/Images/CustomListView/Default/LT.png" ShowFirstPageButton="false"
                                                    ShowPreviousPageButton="false" ShowNextPageButton="true" ShowLastPageButton="true"
                                                    RenderNonBreakingSpacesBetweenControls="true" />
                                                <asp:TemplatePagerField>
                                                    <PagerTemplate>
                                                        <div class="d-lv-PagerCount">
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
                            </div>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <div class="d-lv-row">
                                <div class="lvTemplateTwo">
                                    <div class="row-content">
                                        <div>
                                            <div class="info1Label">
                                                Title&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <asp:HyperLink ID="hypIssueReport" runat="server" CssClass="CommonButtonLink"
                                                 Text='<%# Eval("Title")%>' CommandName="IssueReport" CommandArgument='<%#Eval("IssueID")%>'></asp:HyperLink>
                                                 </div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Issue Number&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                &nbsp;</div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Issue Category&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("IssueCategoryName")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Completion %&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("CompletionPercentage")%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Priority&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("IssuePriorityName")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Status&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("IssueStatusName")%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Duration&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("Duration")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Notify&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("NotifyBeforeMin")%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                         <div>
                                            <div class="info1Label">
                                                Expected Start Date&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Actual Start Date&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                 Expected End Date&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Actual End Date&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Created By&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("MemberFullName")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                 Create Date&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Description&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("Description")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Remarks %&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("Remarks")%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Parent Issue&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("ParentIssueTitle")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Reference Issue&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("ReferenceIssueTitle")%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="seperator">
                                    </div>
                                    <div class="action">
                                        <div>
                                            <asp:HyperLink ID="hypEdit" runat="server" Text="Edit" CssClass="CommonButtonLink"></asp:HyperLink>
                                        </div>
                                        <div>
                                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue Detailed?')"
                                                CommandArgument='<%#Eval("IssueID")%>' UniqueKey="OTProjectAdhocIssueList_lvOTIssue_Detailed_Delete_key" />
                                        </div>
                                        <div>
                                            <asp:HyperLink ID="hypAddSubIssue" runat="server" Text="Add Sub Issue" CssClass="CommonButtonLink"></asp:HyperLink>
                                        </div>
                                        <div>
                                            <asp:HyperLink ID="hypAddReferenceIssue" runat="server" Text="Add Referenced Issue" CssClass="CommonButtonLink"></asp:HyperLink>
                                        </div>
                                        <div>
                                            <asp:HyperLink ID="hypAssignedResource" runat="server" Text="Assigned Resource" CssClass="CommonButtonLink"></asp:HyperLink>
                                        </div>
                                        <div>
                                            <kti:SecureLinkButton ID="lnkBtnAddToSchedule" runat="server" CssClass="CommonButtonLink"
                                                Text="Add To Schedule" CommandName="AddToSchedule" UniqueKey="OTProjectAdhocIssueList_lvOTIssue_Detailed_Add_To_Schedule_key" />
                                        </div>
                                        <div>
                                            
                                        </div>
                                    </div>
                                    <div style="clear: both;">
                                    </div>
                                </div>
                            </div>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <div class="d-lv-alternet-row">
                                <div class="lvTemplateTwo">
                                    <div class="row-content">
                                        <div>
                                            <div class="info1Label">
                                                Title&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <asp:HyperLink ID="hypIssueReport" runat="server" CssClass="CommonButtonLink"
                                                 Text='<%# Eval("Title")%>' CommandName="IssueReport" CommandArgument='<%#Eval("IssueID")%>'></asp:HyperLink>
                                                 </div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Issue Number&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                &nbsp;</div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Issue Category&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("IssueCategoryName")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Completion %&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("CompletionPercentage")%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Priority&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("IssuePriorityName")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Status&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("IssueStatusName")%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Duration&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("Duration")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Notify&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("NotifyBeforeMin")%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                         <div>
                                            <div class="info1Label">
                                                Expected Start Date&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Actual Start Date&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                 Expected End Date&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Actual End Date&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Created By&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("MemberFullName")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                 Create Date&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Description&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("Description")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Remarks %&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("Remarks")%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>

                                        <div>
                                            <div class="info1Label">
                                                Parent Issue&nbsp;:&nbsp;</div>
                                            <div class="info1">
                                                <%# Eval("ParentIssueTitle")%></div>
                                            <div class="infoSeperator">
                                            </div>
                                            <div class="info2Label">
                                                Reference Issue&nbsp;:&nbsp;</div>
                                            <div class="info2">
                                                <%# Eval("ReferenceIssueTitle")%></div>
                                            <div style="clear: both;">
                                            </div>
                                        </div>
                                    </div>
                                    <div class="seperator">
                                    </div>
                                    <div class="action">
                                        <div>
                                            <asp:HyperLink ID="hypEdit" runat="server" Text="Edit" CssClass="CommonButtonLink"></asp:HyperLink>
                                        </div>
                                        <div>
                                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue Detailed?')"
                                                CommandArgument='<%#Eval("IssueID")%>' UniqueKey="OTProjectAdhocIssueList_lvOTIssue_Detailed_Delete_key" />
                                        </div>
                                        <div>
                                            <asp:HyperLink ID="hypAddSubIssue" runat="server" Text="Add Sub Issue" CssClass="CommonButtonLink"></asp:HyperLink>
                                        </div>
                                        <div>
                                            <asp:HyperLink ID="hypAddReferenceIssue" runat="server" Text="Add Referenced Issue" CssClass="CommonButtonLink"></asp:HyperLink>
                                        </div>
                                         <div>
                                            <asp:HyperLink ID="hypAssignedResource" runat="server" Text="Assigned Resource" CssClass="CommonButtonLink"></asp:HyperLink>
                                        </div>
                                        <div>
                                            <kti:SecureLinkButton ID="lnkBtnAddToSchedule" runat="server" CssClass="CommonButtonLink"
                                                Text="Add To Schedule" CommandName="AddToSchedule" UniqueKey="OTProjectAdhocIssueList_lvOTIssue_Detailed_Add_To_Schedule_key" />
                                        </div>
                                    </div>
                                    <div style="clear: both;">
                                    </div>
                                </div>
                            </div>
                        </AlternatingItemTemplate>
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
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
