<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 08-Sep-2013, 11:07:00
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeEvaluationResult.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeEvaluationResultControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee Evaluation Result"></asp:Label>
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
                <div class="TableFormLeble" style="text-align: left;">
                            Session&nbsp;:
                        </div>
                <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSessionCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="none" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                 </div>
                 </div>
                <div class="TableFormLeble" style="text-align: left;">
                    Employee&nbsp;:
                </div>
                <div class="TableFormContent">
                            <asp:DropDownList ID="ddlEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="OTIssueEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnShowReport" ValidationGroup="none" OnClick="btnShowReport_Click"
                            runat="server" Text="Show Report"/>
                    </div>
                </div>
                




                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Evaluation Criteria Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEvaluationCriteriaCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEvaluationCriteriaCategoryID" runat="server" ControlToValidate="ddlEvaluationCriteriaCategoryID"
                            ErrorMessage="Please Select Evaluation Criteria Category" ValidationGroup="HREmployeeEvaluationResultEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Question&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtQuestion" runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtDescription" runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee Evaluation&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeEvaluationID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeEvaluationID" runat="server" ControlToValidate="ddlEmployeeEvaluationID"
                            ErrorMessage="Please Select Employee Evaluation" ValidationGroup="HREmployeeEvaluationResultEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee Evaluation Criteria&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeEvaluationCriteriaID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeEvaluationCriteriaID" runat="server" ControlToValidate="ddlEmployeeEvaluationCriteriaID"
                            ErrorMessage="Please Select Employee Evaluation Criteria" ValidationGroup="HREmployeeEvaluationResultEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Answer Given By Employee Department Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAnswerGivenByEmployeeDepartmentName">
                            Enter Answer Given By Employee Department Name</label>
                        <asp:TextBox ID="txtAnswerGivenByEmployeeDepartmentName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEvaluationResultEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAnswerGivenByEmployeeDepartmentName" runat="server" ControlToValidate="txtAnswerGivenByEmployeeDepartmentName"
                            ErrorMessage="Please Enter Answer Given By Employee Department Name" ValidationGroup="HREmployeeEvaluationResultEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee Full Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEmployeeFullName">
                            Enter Employee Full Name</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtEmployeeFullName" runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeFullName" runat="server" ControlToValidate="txtEmployeeFullName"
                            ErrorMessage="Please Enter Employee Full Name" ValidationGroup="HREmployeeEvaluationResultEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee Code&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEmployeeCode">
                            Enter Employee Code</label>
                        <asp:TextBox ID="txtEmployeeCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEvaluationResultEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeCode" runat="server" ControlToValidate="txtEmployeeCode"
                            ErrorMessage="Please Enter Employee Code" ValidationGroup="HREmployeeEvaluationResultEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Supervisor Evaluation Criteria&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSupervisorEvaluationCriteriaID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Supervisor Department Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtSupervisorDepartmentName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEvaluationResultEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Answer Given By Supervisor Employee Full Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtAnswerGivenBySupervisorEmployeeFullName" runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Supervisor Employee Code&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtSupervisorEmployeeCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HREmployeeEvaluationResultEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee Result&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmployeeResult" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HREmployeeEvaluationResultEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvEmployeeResult" runat="server" ControlToValidate="txtEmployeeResult" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeEvaluationResultEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Result&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtResult" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HREmployeeEvaluationResultEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvResult" runat="server" ControlToValidate="txtResult" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeEvaluationResultEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Point In This Question&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPointInThisQuestion" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HREmployeeEvaluationResultEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvPointInThisQuestion" runat="server" ControlToValidate="txtPointInThisQuestion" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeEvaluationResultEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Extra1&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtExtra1" runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Extra2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtExtra2" runat="server" ValidationGroup="HREmployeeEvaluationResultEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeEvaluationResultEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeEvaluationResultControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="HREmployeeEvaluationResultControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="HREmployeeEvaluationResultControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Employee Evaluation Result List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeEvaluationResult" runat="server" DataSourceID="odsHREmployeeEvaluationResult" OnItemCommand="lvHREmployeeEvaluationResult_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Evaluation Criteria Category
                                    </td>
                                    <td class="hi">
                                        Question
                                    </td>
                                    <td class="hi">
                                        Description
                                    </td>
                                    <td class="hi">
                                        Employee Evaluation
                                    </td>
                                    <td class="hi">
                                        Employee Evaluation Criteria
                                    </td>
                                    <td class="hi">
                                        Answer Given By Employee Department Name
                                    </td>
                                    <td class="hi">
                                        Employee Full Name
                                    </td>
                                    <td class="hi">
                                        Employee Code
                                    </td>
                                    <td class="hi">
                                        Supervisor Evaluation Criteria
                                    </td>
                                    <td class="hi">
                                        Supervisor Department Name
                                    </td>
                                    <td class="hi">
                                        Answer Given By Supervisor Employee Full Name
                                    </td>
                                    <td class="hi">
                                        Supervisor Employee Code
                                    </td>
                                    <td class="hi">
                                        Employee Result
                                    </td>
                                    <td class="hi">
                                        Result
                                    </td>
                                    <td class="hi">
                                        Point In This Question
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Extra1
                                    </td>
                                    <td class="hi">
                                        Extra2
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
                                    <%# Eval("EvaluationCriteriaCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Question")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeEvaluationID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeEvaluationCriteriaID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AnswerGivenByEmployeeDepartmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorEvaluationCriteriaID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorDepartmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AnswerGivenBySupervisorEmployeeFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorEmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeResult")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Result")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PointInThisQuestion")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extra1")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extra2")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeEvaluationResultID")%>' UniqueKey="HREmployeeEvaluationResult_lvHREmployeeEvaluationResult_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Evaluation Result?')"
                                        CommandArgument='<%#Eval("EmployeeEvaluationResultID")%>' UniqueKey="HREmployeeEvaluationResult_lvHREmployeeEvaluationResult_Edit_key"/>
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
                                    <%# Eval("EvaluationCriteriaCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Question")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeEvaluationID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeEvaluationCriteriaID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AnswerGivenByEmployeeDepartmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorEvaluationCriteriaID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorDepartmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AnswerGivenBySupervisorEmployeeFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorEmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeResult")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Result")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PointInThisQuestion")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extra1")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extra2")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeEvaluationResultID")%>' UniqueKey="HREmployeeEvaluationResult_lvHREmployeeEvaluationResult_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Evaluation Result?')"
                                        CommandArgument='<%#Eval("EmployeeEvaluationResultID")%>' UniqueKey="HREmployeeEvaluationResult_lvHREmployeeEvaluationResult_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsHREmployeeEvaluationResult" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeEvaluationResultDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeEvaluationResult_Selecting">
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
