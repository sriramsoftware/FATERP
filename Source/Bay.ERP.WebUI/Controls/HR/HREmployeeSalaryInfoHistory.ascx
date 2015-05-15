<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeSalaryInfoHistory.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeSalaryInfoHistoryControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee Salary Info History"></asp:Label>
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
                        Employee Salary Info&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeSalaryInfoID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeSalaryInfoID" runat="server" ControlToValidate="ddlEmployeeSalaryInfoID"
                            ErrorMessage="Please Select Employee Salary Info" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Designation&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDesignationID" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvDesignationID" runat="server" ControlToValidate="txtDesignationID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryInfoHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Fiscal Year&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFiscalYearID">
                            Enter Fiscal Year</label>
                        <asp:TextBox ID="txtFiscalYearID" CssClass="ktiNumberTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFiscalYearID" runat="server" ControlToValidate="txtFiscalYearID"
                            ErrorMessage="Please Enter Fiscal Year" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvFiscalYearID" runat="server" ControlToValidate="txtFiscalYearID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryInfoHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Salary Session&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSalarySessionID">
                            Enter Salary Session</label>
                        <asp:TextBox ID="txtSalarySessionID" CssClass="ktiNumberTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSalarySessionID" runat="server" ControlToValidate="txtSalarySessionID"
                            ErrorMessage="Please Enter Salary Session" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvSalarySessionID" runat="server" ControlToValidate="txtSalarySessionID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryInfoHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEmployeeID">
                            Enter Employee</label>
                        <asp:TextBox ID="txtEmployeeID" CssClass="ktiNumberTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeID" runat="server" ControlToValidate="txtEmployeeID"
                            ErrorMessage="Please Enter Employee" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvEmployeeID" runat="server" ControlToValidate="txtEmployeeID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryInfoHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Deposite&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsDeposite" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Salary Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSalaryAmount">
                            Enter Salary Amount</label>
                        <asp:TextBox ID="txtSalaryAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSalaryAmount" runat="server" ControlToValidate="txtSalaryAmount"
                            ErrorMessage="Please Enter Salary Amount" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvSalaryAmount" runat="server" ControlToValidate="txtSalaryAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeSalaryInfoHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Pay Cycle&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPayCycleID" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvPayCycleID" runat="server" ControlToValidate="txtPayCycleID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryInfoHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Payscale&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPayscaleID" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvPayscaleID" runat="server" ControlToValidate="txtPayscaleID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryInfoHistoryEntity"></asp:RangeValidator>
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
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeCode" runat="server" ControlToValidate="txtEmployeeCode"
                            ErrorMessage="Please Enter Employee Code" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtProjectID" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvProjectID" runat="server" ControlToValidate="txtProjectID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryInfoHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Department&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDepartmentID" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvDepartmentID" runat="server" ControlToValidate="txtDepartmentID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryInfoHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Create Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCreateDate">
                            Enter Create Date</label>
                        <asp:TextBox ID="txtCreateDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            ErrorMessage="Please Enter Create Date" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeSalaryInfoHistoryEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Created By Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCreatedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreatedByEmployeeID" runat="server" ControlToValidate="ddlCreatedByEmployeeID"
                            ErrorMessage="Please Select Created By Employee" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeSalaryInfoHistoryEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeSalaryInfoHistoryControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="HREmployeeSalaryInfoHistoryControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="HREmployeeSalaryInfoHistoryControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Employee Salary Info History List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeSalaryInfoHistory" runat="server" DataSourceID="odsHREmployeeSalaryInfoHistory" OnItemCommand="lvHREmployeeSalaryInfoHistory_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Employee Salary Info
                                    </td>
                                    <td class="hi">
                                        Designation
                                    </td>
                                    <td class="hi">
                                        Fiscal Year
                                    </td>
                                    <td class="hi">
                                        Salary Session
                                    </td>
                                    <td class="hi">
                                        Employee
                                    </td>
                                    <td class="hi">
                                        Is Deposite
                                    </td>
                                    <td class="hi">
                                        Salary Amount
                                    </td>
                                    <td class="hi">
                                        Pay Cycle
                                    </td>
                                    <td class="hi">
                                        Payscale
                                    </td>
                                    <td class="hi">
                                        Employee Code
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi">
                                        Department
                                    </td>
                                    <td class="hi">
                                        Create Date
                                    </td>
                                    <td class="hi">
                                        Created By Employee
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
                                    <%# Eval("EmployeeSalaryInfoID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DesignationID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FiscalYearID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalarySessionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDeposite") != null ? (((Boolean)Eval("IsDeposite")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalaryAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayCycleID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayscaleID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepartmentID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeSalaryInfoHistoryID")%>' UniqueKey="HREmployeeSalaryInfoHistory_lvHREmployeeSalaryInfoHistory_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Salary Info History?')"
                                        CommandArgument='<%#Eval("EmployeeSalaryInfoHistoryID")%>' UniqueKey="HREmployeeSalaryInfoHistory_lvHREmployeeSalaryInfoHistory_Edit_key"/>
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
                                    <%# Eval("EmployeeSalaryInfoID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DesignationID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FiscalYearID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalarySessionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDeposite") != null ? (((Boolean)Eval("IsDeposite")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalaryAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayCycleID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayscaleID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepartmentID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeSalaryInfoHistoryID")%>' UniqueKey="HREmployeeSalaryInfoHistory_lvHREmployeeSalaryInfoHistory_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Salary Info History?')"
                                        CommandArgument='<%#Eval("EmployeeSalaryInfoHistoryID")%>' UniqueKey="HREmployeeSalaryInfoHistory_lvHREmployeeSalaryInfoHistory_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsHREmployeeSalaryInfoHistory" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeSalaryInfoHistoryDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeSalaryInfoHistory_Selecting">
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
