<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Sep-2013, 01:19:45
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDEvaluationCriteria.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MDEvaluationCriteriaControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
<Triggers>
        <asp:PostBackTrigger ControlID="btnSubmit" />
    </Triggers>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Evaluation Criteria"></asp:Label>
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
                        Session Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEvaluationSessionCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDEvaluationCriteriaEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEvaluationSessionCategoryID" runat="server" ControlToValidate="ddlEvaluationSessionCategoryID"
                            ErrorMessage="Please Select Evaluation Session Category" ValidationGroup="MDEvaluationCriteriaEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Criteria Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEvaluationCriteriaCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDEvaluationCriteriaEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEvaluationCriteriaCategoryID" runat="server" ControlToValidate="ddlEvaluationCriteriaCategoryID"
                            ErrorMessage="Please Select Evaluation Criteria Category" ValidationGroup="MDEvaluationCriteriaEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Question&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtQuestion">
                            Enter Question</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtQuestion" runat="server" ValidationGroup="MDEvaluationCriteriaEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvQuestion" runat="server" ControlToValidate="txtQuestion"
                            ErrorMessage="Please Enter Question" ValidationGroup="MDEvaluationCriteriaEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtDescription" runat="server" ValidationGroup="MDEvaluationCriteriaEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Correct Answer&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtCorrectAnswerIfAny" runat="server" ValidationGroup="MDEvaluationCriteriaEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Correct Answer Mark&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCorrectAnswerMarkOrPoint" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="MDEvaluationCriteriaEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCorrectAnswerMarkOrPoint" runat="server" ControlToValidate="txtCorrectAnswerMarkOrPoint" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="MDEvaluationCriteriaEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Image Url&nbsp;:
                    </div>
                    <div class="TableFormContent">
                    <asp:FileUpload ID="fuImageUrl" ClientIDMode="Static" runat="server" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Question Order&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtQuestionOrderInDisplay" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="MDEvaluationCriteriaEntity" Width="210" />
                            <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvQuestionOrderInDisplay" runat="server" ControlToValidate="txtQuestionOrderInDisplay" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="MDEvaluationCriteriaEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Only Supervisor ans.&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkSupervisorWillAnswer" runat="server" ClientIDMode="Static" ValidationGroup="MDEvaluationCriteriaEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="MDEvaluationCriteriaEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Supervisor Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSupervisorTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDEvaluationCriteriaEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSupervisorTypeID" runat="server" ControlToValidate="ddlSupervisorTypeID"
                            ErrorMessage="Please Select Supervisor Type" ValidationGroup="MDEvaluationCriteriaEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="MDEvaluationCriteriaEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="MDEvaluationCriteriaControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="MDEvaluationCriteriaControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="MDEvaluationCriteriaControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Evaluation Criteria List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvMDEvaluationCriteria" runat="server" DataSourceID="odsMDEvaluationCriteria" OnItemCommand="lvMDEvaluationCriteria_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Evaluation Criteria Category
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Supervisor Type
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Evaluation Session Category
                                    </td>
                                    <td class="hi">
                                        Question
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Description
                                    </td>
                                    <td class="hi">
                                        Correct Answer If Any
                                    </td>
                                    <td class="hi">
                                        Correct Ans. Mark
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Image Url
                                    </td>
                                    <td class="hi">
                                        Question Order
                                    </td>
                                    <td class="hi">
                                        Supervisor Will Answer
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Is Removed
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Created By Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Create Date
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
                                <td class="i" style="display:none;">
                                    <%# Eval("EvaluationCriteriaCategoryID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("SupervisorTypeID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("EvaluationSessionCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Question")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CorrectAnswerIfAny")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CorrectAnswerMarkOrPoint")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ImageUrl")%>
                                </td>
                                <td class="i">
                                    <%# Eval("QuestionOrderInDisplay")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorWillAnswer") != null ? (((Boolean)Eval("SupervisorWillAnswer")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CreatedByEmployeeID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EvaluationCriteriaID")%>' UniqueKey="MDEvaluationCriteria_lvMDEvaluationCriteria_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Evaluation Criteria?')"
                                        CommandArgument='<%#Eval("EvaluationCriteriaID")%>' UniqueKey="MDEvaluationCriteria_lvMDEvaluationCriteria_Edit_key"/>
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
                                 <td class="i" style="display:none;">
                                    <%# Eval("EvaluationCriteriaCategoryID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("SupervisorTypeID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("EvaluationSessionCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Question")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CorrectAnswerIfAny")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CorrectAnswerMarkOrPoint")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ImageUrl")%>
                                </td>
                                <td class="i">
                                    <%# Eval("QuestionOrderInDisplay")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupervisorWillAnswer") != null ? (((Boolean)Eval("SupervisorWillAnswer")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CreatedByEmployeeID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EvaluationCriteriaID")%>' UniqueKey="MDEvaluationCriteria_lvMDEvaluationCriteria_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Evaluation Criteria?')"
                                        CommandArgument='<%#Eval("EvaluationCriteriaID")%>' UniqueKey="MDEvaluationCriteria_lvMDEvaluationCriteria_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsMDEvaluationCriteria" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.MDEvaluationCriteriaDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsMDEvaluationCriteria_Selecting">
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
