<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeSalaryDeducationInfoOperation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeSalaryDeducationInfoOperationControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee Salary Deducation Info"></asp:Label>
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
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypSalaryDeducationCategory" runat="server"
                            Text="Salary Deducation Category" NavigateUrl="~/MD/MDSalaryDeducationCategory.aspx"
                            Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSalaryDeducationCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSalaryDeducationCategoryID" runat="server" ControlToValidate="ddlSalaryDeducationCategoryID"
                            ErrorMessage="Please Select Salary Deducation Category" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Salary Session&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSalarySessionID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSalarySessionID" runat="server" ControlToValidate="ddlSalarySessionID"
                            ErrorMessage="Please Select Salary Session" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Fiscal Year&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlFiscalYearID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFiscalYearID" runat="server" ControlToValidate="ddlFiscalYearID"
                            ErrorMessage="Please Select Fiscal Year" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeID" runat="server" ControlToValidate="ddlEmployeeID"
                            ErrorMessage="Please Select Employee" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Deduction Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtDeductionAmount">
                            Enter Deduction Amount</label>
                        <asp:TextBox ID="txtDeductionAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDeductionAmount" runat="server" ControlToValidate="txtDeductionAmount"
                            ErrorMessage="Please Enter Deduction Amount" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvDeductionAmount" runat="server" ControlToValidate="txtDeductionAmount"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Percentage Of Basic Salary&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPercentageOfBasicSalary">
                            Enter Percentage Of Basic Salary</label>
                        <asp:TextBox ID="txtPercentageOfBasicSalary" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPercentageOfBasicSalary" runat="server" ControlToValidate="txtPercentageOfBasicSalary"
                            ErrorMessage="Please Enter Percentage Of Basic Salary" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvPercentageOfBasicSalary" runat="server" ControlToValidate="txtPercentageOfBasicSalary"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Pay Cycle&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlPayCycleID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPayCycleID" runat="server" ControlToValidate="ddlPayCycleID"
                            ErrorMessage="Please Select Pay Cycle" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEffectiveDate">
                            Enter Start Date</label>
                        <asp:TextBox ID="txtEffectiveDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEffectiveDate" runat="server" ControlToValidate="txtEffectiveDate"
                            ErrorMessage="Please Enter Effective Date" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revEffectiveDate" runat="server" ControlToValidate="txtEffectiveDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeSalaryDeducationInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        End Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEndDate" runat="server" ControlToValidate="txtEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeSalaryDeducationInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Number Of Payments&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtNumberOfPayments">
                            Enter Number Of Payments</label>
                        <asp:TextBox ID="txtNumberOfPayments" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvNumberOfPayments" runat="server" ControlToValidate="txtNumberOfPayments"
                            ErrorMessage="Please Enter Number Of Payments" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvNumberOfPayments" runat="server" ControlToValidate="txtNumberOfPayments"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Note&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtNote" runat="server" ValidationGroup="HREmployeeSalaryDeducationInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Current Installment&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtNextInstallment">
                            Enter Next Installment</label>
                        <asp:TextBox ID="txtNextInstallment" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryDeducationInfoEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width: 216px;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeSalaryDeducationInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble" style="width: 216px;">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeSalaryDeducationInfoEntity"
                            OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="HREmployeeSalaryDeducationInfoControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="HREmployeeSalaryDeducationInfoControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="HREmployeeSalaryDeducationInfoControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <br />
        </div>
        <div class="TableRow" style="width: 100%; float: right;">
            <div class="TableFormLeble">
                &nbsp;</div>
            <div class="TableFormLeble" style="text-align: right; width: 617px;">
                Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
                <label class="watermarkLabel" for="txtSearchText">
                    Type Employee Code or Name</label>
                <asp:TextBox ID="txtSearchText" runat="server" AutoPostBack="true" ClientIDMode="Static"
                    CssClass="ktiTextBox" Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server"
                        AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
            </div>
        </div>
        <div class="listContentTitle">
            Employee Salary Deducation Info List
        </div>
        <div>
            <div class="lv-c">
                <asp:ListView ID="lvHREmployeeSalaryDeducationInfo" runat="server" DataSourceID="odsHREmployeeSalaryDeducationInfo"
                    OnItemCommand="lvHREmployeeSalaryDeducationInfo_ItemCommand">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                            <tr class="h">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="his">
                                    EDIT
                                </td>
                                <td class="his">
                                    DELETE
                                </td>
                                <td class="hi" style="width: 70px;">
                                    Salary Deducation Category
                                </td>
                                <td class="hi">
                                    Salary Session
                                </td>
                                <td class="hi">
                                    Fiscal Year
                                </td>
                                <td class="hi" style="width: 146px;">
                                    Employee
                                </td>
                                <td class="hi">
                                    Deduction Amount
                                </td>
                                <td class="hi" style="display: none;">
                                    Percentage Of Basic Salary
                                </td>
                                <td class="hi" style="width: 60px;">
                                    Pay Cycle
                                </td>
                                <td class="hi" style="display: none;">
                                    Date
                                </td>
                                <td class="hi" style="width: 50px;">
                                    Number Of Payments
                                </td>
                                <td class="hi">
                                    Note
                                </td>
                                <td class="hi">
                                    Current Installment
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
                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeSalaryDeducationInfoID")%>'
                                    UniqueKey="HREmployeeSalaryDeducationInfo_lvHREmployeeSalaryDeducationInfo_Edit_key" />
                            </td>
                            <td class="i">
                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Salary Deducation Info?')"
                                    CommandArgument='<%#Eval("EmployeeSalaryDeducationInfoID")%>' UniqueKey="HREmployeeSalaryDeducationInfo_lvHREmployeeSalaryDeducationInfo_Edit_key" />
                            </td>
                            <td class="i">
                                <%# Eval("SalaryDeducationCategoryName")%>
                            </td>
                            <td class="i">
                                <b>Start :</b><%# Eval("SessionStartDate") != null ? ((DateTime)Eval("SessionStartDate")).ToString("dd-MM-yyyy") : ""%><br />
                                <b>End : </b>
                                <%# Eval("SessionEndDate") != null ? ((DateTime)Eval("SessionEndDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <b>Start :</b><%# Eval("FiscalYearBeginDate") != null ? ((DateTime)Eval("FiscalYearBeginDate")).ToString("dd-MM-yyyy") : ""%><br />
                                <b>End : </b><%# Eval("FiscalYearEndDate") != null ? ((DateTime)Eval("FiscalYearEndDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("EmployeeFullName")%>
                            </td>
                            <td class="i">
                                <%# Eval("DeductionAmount")%>
                            </td>
                            <td class="i" style="display: none;">
                                <%# Eval("PercentageOfBasicSalary")%>
                            </td>
                            <td class="i">
                                <%# Eval("PayCycleName")%>
                            </td>
                            <td class="i" style="display: none;">
                                <b>Start :</b>
                                <%# Eval("EffectiveDate") != null ? ((DateTime)Eval("EffectiveDate")).ToString("dd-MM-yyyy") : ""%><br />
                                <b>End : </b>
                                <%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("NumberOfPayments")%>
                            </td>
                            <td class="i">
                                <%# Eval("Note")%>
                            </td>
                            <td class="i">
                                <%# Eval("NextInstallMent")%>
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
                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeSalaryDeducationInfoID")%>'
                                    UniqueKey="HREmployeeSalaryDeducationInfo_lvHREmployeeSalaryDeducationInfo_Edit_key" />
                            </td>
                            <td class="i">
                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Salary Deducation Info?')"
                                    CommandArgument='<%#Eval("EmployeeSalaryDeducationInfoID")%>' UniqueKey="HREmployeeSalaryDeducationInfo_lvHREmployeeSalaryDeducationInfo_Edit_key" />
                            </td>
                            <td class="i">
                                <%# Eval("SalaryDeducationCategoryName")%>
                            </td>
                            <td class="i">
                                <b>Start :</b><%# Eval("SessionStartDate") != null ? ((DateTime)Eval("SessionStartDate")).ToString("dd-MM-yyyy") : ""%><br />
                                <b>End : </b>
                                <%# Eval("SessionEndDate") != null ? ((DateTime)Eval("SessionEndDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <b>Start :</b><%# Eval("FiscalYearBeginDate") != null ? ((DateTime)Eval("FiscalYearBeginDate")).ToString("dd-MM-yyyy") : ""%><br />
                                <b>End : </b>
                                <%# Eval("FiscalYearEndDate") != null ? ((DateTime)Eval("FiscalYearEndDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("EmployeeFullName")%>
                            </td>
                            <td class="i">
                                <%# Eval("DeductionAmount")%>
                            </td>
                            <td class="i" style="display: none;">
                                <%# Eval("PercentageOfBasicSalary")%>
                            </td>
                            <td class="i">
                                <%# Eval("PayCycleName")%>
                            </td>
                            <td class="i" style="display: none;">
                                <b>Start :</b>
                                <%# Eval("EffectiveDate") != null ? ((DateTime)Eval("EffectiveDate")).ToString("dd-MM-yyyy") : ""%><br />
                                <b>End : </b>
                                <%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString("dd-MM-yyyy") : ""%>
                            </td>
                            <td class="i">
                                <%# Eval("NumberOfPayments")%>
                            </td>
                            <td class="i">
                                <%# Eval("Note")%>
                            </td>
                            <td class="i">
                                <%# Eval("NextInstallMent")%>
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
            <asp:ObjectDataSource ID="odsHREmployeeSalaryDeducationInfo" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeSalaryDeducationInfo_DetailedDataSource"
                SortParameterName="sortExpression" OnSelecting="odsHREmployeeSalaryDeducationInfo_Selecting">
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
