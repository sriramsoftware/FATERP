<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 19-Jan-2014, 04:39:37
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeSalaryPayment.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeSalaryPaymentControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100%; float: left;">
                <div class="TableFormLeble" style="text-align: right;">
                    Filter Text&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        Type Employee Code</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Department&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlDepartmentID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" AutoPostBack="true"
                        Width="234" OnSelectedIndexChanged="ddlDepartmentID_SelectedIndexChanged">
                        <asp:ListItem Selected="True" Text="All Employee Except Security" Value="1"></asp:ListItem>
                        <asp:ListItem Text="Security" Value="2"></asp:ListItem>
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right; width: 375px;">
                </div>
                <div class="TableFormContent">
                    <span>
                        <asp:CheckBox ID="chbxAdvanceFilter" runat="server" AutoPostBack="true" OnCheckedChanged="chbxAdvanceFilter_CheckedChanged"
                            Text="Advance" /></span> <span>
                                <asp:CheckBox ID="chbxFineFilter" runat="server" AutoPostBack="true" OnCheckedChanged="chbxFineFilter_CheckedChanged" Text="Fine" /></span>
                    <span>
                        <asp:CheckBox ID="chbxMealFilter" runat="server" AutoPostBack="true" Text="Meal" OnCheckedChanged="chbxMealFilter_CheckedChanged"/></span>
                    <span>
                        <asp:CheckBox ID="chbxAITFilter" runat="server" AutoPostBack="true" Text="AIT" OnCheckedChanged="chbxAITFilter_CheckedChanged"/></span>
                   <span>
                        <asp:CheckBox ID="chbxPFDeduct" runat="server" AutoPostBack="true" Text="PF Deduct" OnCheckedChanged="chbxPFDeduct_CheckedChanged"/></span>
                    <span>
                        <asp:CheckBox ID="chbxAdjustmentFilter" runat="server" AutoPostBack="true" Text="Adjustment" OnCheckedChanged="chbxAdjustmentFilter_CheckedChanged"/></span>
                    <span>
                        <asp:CheckBox ID="chbxAllowanceFilter" runat="server" AutoPostBack="true" Text="Allowance" OnCheckedChanged="chbxAllowanceFilter_CheckedChanged"/></span>
                    <span>
                        <asp:CheckBox ID="chbxAddEBR" runat="server" AutoPostBack="true" OnCheckedChanged="chbxAddEBR_CheckedChanged"
                            Text="Add EBR 5%" />
                            <span>
                        <asp:CheckBox ID="chbxTBRFilter" runat="server" AutoPostBack="true" OnCheckedChanged="chbxTBRFilter_CheckedChanged"
                            Text="TBR 2%" />
                    </span>
                     <span>
                        <asp:CheckBox ID="chbxTAXFilter" runat="server" AutoPostBack="true" OnCheckedChanged="chbxTAXFilter_CheckedChanged"
                            Text="TAX" />
                    </span>
                </div>
            </div>
            <br />
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right; width: 375px;">
                </div>
                <div class="TableFormContent">
                <span>
                        <asp:CheckBox ID="chbxBounusFilter" runat="server" AutoPostBack="true" Text="Bonus" OnCheckedChanged="chbxBounusFilter_CheckedChanged"/></span>
                    Calculate on <asp:TextBox ID="txtBonusPercent" runat="server"  CssClass="ktiDecimalTextBox" ClientIDMode="Static" width="25"/> &nbsp;%&nbsp; 
                    Salary Payable Calculate On&nbsp;<asp:TextBox ID="txtSalaryPayablePercent" Text="1" runat="server"  CssClass="ktiDecimalTextBox" ClientIDMode="Static" width="25"/> &nbsp;% 
                </div>
            </div>
            <div class="listContentTitle">
                Employee Salary Payment List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeSalaryPayment" runat="server" DataSourceID="odsHREmployeeSalaryPayment"
                        OnItemDataBound="lvHREmployeeSalaryPayment_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                                <tr>
                                    <td colspan="100%">
                                        <div class="lv-FooterContainer">
                                            <div class="lv-Footer">
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="1">
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
                                <div class="TableRow" style="width: 100;">
                                    <div style="display: none">
                                        <%# Eval("FirstName")%>&nbsp;<%# Eval("MiddleName")%>&nbsp;<%# Eval("LastName")%><br />
                                    </div>
                                    <div style="display: none">
                                        <asp:Label ID="employeeFirstNamelv" Text='<%# Eval("FirstName")%>' runat="server" />
                                        <asp:Label ID="employeeMiddleNamelv" Text='<%# Eval("MiddleName")%>' runat="server" />
                                        <asp:Label ID="employeeLastNamelv" Text='<%# Eval("LastName")%>' runat="server" />
                                        <asp:Label ID="designationIDlv" Text='<%# Eval("DesignationID")%>' runat="server"
                                            Width="210" />
                                        <asp:Label ID="employeeJobTypeIDlv" Text='<%# Eval("EmployeeJobTypeID")%>' runat="server"
                                            Width="210" />
                                        <asp:Label ID="projectIDlv" Text='<%# Eval("ProjectID")%>' runat="server" Width="210" />
                                        <asp:Label ID="departmentIDlv" Text='<%# Eval("DepartmentID")%>' runat="server" Width="210" />
                                        <asp:Label ID="employeeIDlv" Text='<%# Eval("EmployeeID")%>' runat="server" Width="210" />
                                        <asp:Label ID="lblServiceDays" Text='<%# Eval("ServiceDays")%>' runat="server" />
                                    </div>
                                    <div class="TableRow">
                                        <div style="text-align: left; padding-top: 4px; overflow: hidden;">
                                            <span style="padding-left: 0px;"><b>Salary For the Period of</b>&nbsp;: &nbsp;<asp:Label
                                                ID="lblStartDate" Font-Bold="true" runat="server"></asp:Label>
                                            </span><span style="padding-left: 10px;"><b>to</b>&nbsp;: &nbsp;<asp:Label ID="lblEndDate"
                                                Font-Bold="true" runat="server"></asp:Label>
                                            </span>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Employee Name&nbsp;:
                                        </div>
                                        <div class="TableFormLeble" style="width: 210px;">
                                            <asp:Label ID="employeeNamelv" runat="server" Width="210" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Employee Code&nbsp;:
                                        </div>
                                        <div class="TableFormLeble">
                                            <asp:Label ID="employeeCodeLv" Text='<%# Eval("EmployeeCode")%>' runat="server" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Designation&nbsp;:
                                        </div>
                                        <div class="TableFormLeble" style="width: 500px;">
                                            <asp:Label ID="designationNamelv" Text='<%# Eval("DesignationName")%>' runat="server"
                                                Width="210" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Job Type&nbsp;:
                                        </div>
                                        <div class="TableFormLeble" style="width: 210px;">
                                            <asp:Label ID="employeeJobTypeNamelv" Text='<%# Eval("EmployeeJobTypeName")%>' runat="server"
                                                Width="210" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Project&nbsp;:
                                        </div>
                                        <div class="TableFormLeble" style="width: 210px;">
                                            <asp:Label ID="projectCode" Text='<%# Eval("ProjectCode")%>' runat="server" Width="210" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Department&nbsp;:
                                        </div>
                                        <div class="TableFormLeble" style="width: 210px;">
                                            <asp:Label ID="Label2" Text='<%# Eval("DepartmentName")%>' runat="server" Width="210" />
                                            <div style="display:none;"><asp:Label ID="Label1" Text='<%# Eval("ServiceDays")%>' runat="server" /></div>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Salary Level&nbsp;:
                                        </div>
                                        <div class="TableFormLeble" style="width: 210px;">
                                            <asp:Label ID="lblSalaryLevel" Text='<%# Eval("SalaryLevel")%>' runat="server" Width="210" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Base Salary &nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtConsolidateSalaryAmount">
                                                Enter Base Salary Amount</label>
                                            <asp:TextBox ID="txtConsolidateSalaryAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                Text='<%# Eval("SalaryAmount")%>' runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvConsolidateSalaryAmount" runat="server" ControlToValidate="txtConsolidateSalaryAmount"
                                                ErrorMessage="Please Enter Consolidate Salary Amount" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvConsolidateSalaryAmount" runat="server" ControlToValidate="txtConsolidateSalaryAmount"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Salary Payable&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtSalaryPayable">
                                                Enter Salary Payable</label>
                                            <asp:TextBox ID="txtSalaryPayable"  CssClass="ktiDecimalTextBox"
                                                ClientIDMode="Static" runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvSalaryPayable" runat="server" ControlToValidate="txtSalaryPayable"
                                                ErrorMessage="Please Enter Salary Payable" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvSalaryPayable" runat="server" ControlToValidate="txtSalaryPayable"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Workdays&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtWorkdays">
                                                Enter Workdays</label>
                                            <asp:TextBox ID="txtWorkdays" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                Text='<%# Eval("ACTUALWORKDAYS")%>' runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvWorkdays" runat="server" ControlToValidate="txtWorkdays"
                                                ErrorMessage="Please Enter Workdays" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvWorkdays" runat="server" ControlToValidate="txtWorkdays"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Advance&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtAdvance">
                                                Enter Advance</label>
                                            <asp:TextBox ID="txtAdvance" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvAdvance" runat="server" ControlToValidate="txtAdvance"
                                                ErrorMessage="Please Enter Advance" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvAdvance" runat="server" ControlToValidate="txtAdvance"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Fine&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtFine">
                                                Enter Fine</label>
                                            <asp:TextBox ID="txtFine" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvFine" runat="server" ControlToValidate="txtFine"
                                                ErrorMessage="Please Enter Fine" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvFine" runat="server" ControlToValidate="txtFine" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Meals&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtMeals">
                                                Enter Meals</label>
                                            <asp:TextBox ID="txtMeals" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvMeals" runat="server" ControlToValidate="txtMeals"
                                                ErrorMessage="Please Enter Meals" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvMeals" runat="server" ControlToValidate="txtMeals" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            AIT&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtAIT">
                                                Enter AIT</label>
                                            <asp:TextBox ID="txtAIT" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvAIT" runat="server" ControlToValidate="txtAIT"
                                                ErrorMessage="Please Enter A IT" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvAIT" runat="server" ControlToValidate="txtAIT" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            TAX&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtTAX">
                                                Enter TAX</label>
                                            <asp:TextBox ID="txtTAX" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtTAX"
                                                ErrorMessage="Please Enter TAX" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtTAX" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            PF Deducted Amount&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtProvidentFundDeductedAmount">
                                                Enter Provident Fund Deducted Amount</label>
                                            <asp:TextBox ID="txtProvidentFundDeductedAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvProvidentFundDeductedAmount" runat="server" ControlToValidate="txtProvidentFundDeductedAmount"
                                                ErrorMessage="Please Enter Provident Fund Deducted Amount" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvProvidentFundDeductedAmount" runat="server" ControlToValidate="txtProvidentFundDeductedAmount"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Bonus&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtBonus">
                                                Enter Bonus</label>
                                            <asp:TextBox ID="txtBonus" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvBonus" runat="server" ControlToValidate="txtBonus"
                                                ErrorMessage="Please Enter Bonus" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvBonus" runat="server" ControlToValidate="txtBonus" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Adjustment&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtAdjustment">
                                                Enter Adjustment</label>
                                            <asp:TextBox ID="txtAdjustment" CssClass="ktiTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvAdjustment" runat="server" ControlToValidate="txtAdjustment"
                                                ErrorMessage="Please Enter Adjustment" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvAdjustment" runat="server" ControlToValidate="txtAdjustment"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Allowance&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtAllowance">
                                                Enter Allowance</label>
                                            <asp:TextBox ID="txtAllowance" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvAllowance" runat="server" ControlToValidate="txtAllowance"
                                                ErrorMessage="Please Enter Allowance" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvAllowance" runat="server" ControlToValidate="txtAllowance"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            TBR&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtTBR">
                                                TBR</label>
                                            <asp:TextBox ID="txtTBR" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtTBR"
                                                ErrorMessage="Please Enter Allowance" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtTBR"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Net Salary Payable&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtNetPayable">
                                                Enter Net Payable</label>
                                            <asp:TextBox ID="txtNetPayable" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span><kti:SecureButton ID="btnCalculate" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                OnClick="btnCalculate_Click" runat="server" Text="=" UniqueKey="HREmployeeSalaryPaymentControl_Submit_key" />
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvNetPayable" runat="server" ControlToValidate="txtNetPayable"
                                                ErrorMessage="Please Enter Net Payable" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvNetPayable" runat="server" ControlToValidate="txtNetPayable"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Note&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtNote">
                                                Enter Note</label>
                                            <asp:TextBox ID="txtNote" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvNote" runat="server" ControlToValidate="txtNote"
                                                ErrorMessage="Please Enter Note" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvNote" runat="server" ControlToValidate="txtNote" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Cash&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtCash">
                                                Enter Cash</label>
                                            <asp:TextBox ID="txtCash" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvCash" runat="server" ControlToValidate="txtCash"
                                                ErrorMessage="Please Enter Cash" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvCash" runat="server" ControlToValidate="txtCash" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Bank Amount&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtBankAmount">
                                                Enter Bank Amount</label>
                                            <asp:TextBox ID="txtBankAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvBankAmount" runat="server" ControlToValidate="txtBankAmount"
                                                ErrorMessage="Please Enter Bank Amount" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvBankAmount" runat="server" ControlToValidate="txtBankAmount"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Project Actual&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtProjectActual">
                                                Enter Project Actual</label>
                                            <asp:TextBox ID="txtProjectActual" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvProjectActual" runat="server" ControlToValidate="txtProjectActual"
                                                ErrorMessage="Please Enter Project Actual" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvProjectActual" runat="server" ControlToValidate="txtProjectActual"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Phone Ceiling&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtPhoneCeiling">
                                                Enter Phone Ceiling</label>
                                            <asp:TextBox ID="txtPhoneCeiling" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvPhoneCeiling" runat="server" ControlToValidate="txtPhoneCeiling"
                                                ErrorMessage="Please Enter Phone Ceiling" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvPhoneCeiling" runat="server" ControlToValidate="txtPhoneCeiling"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                            <asp:RegularExpressionValidator ID="revPhoneCeiling" runat="server" ControlToValidate="txtPhoneCeiling"
                                                Display="Dynamic" EnableViewState="False" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; ">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Phone Bill Adjust.&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtPhoneBillAdjustment">
                                                Enter Phone Bill Adjustment</label>
                                            <asp:TextBox ID="txtPhoneBillAdjustment" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvPhoneBillAdjustment" runat="server" ControlToValidate="txtPhoneBillAdjustment"
                                                ErrorMessage="Please Enter Phone Bill Adjustment" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvPhoneBillAdjustment" runat="server" ControlToValidate="txtPhoneBillAdjustment"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                            <asp:RegularExpressionValidator ID="revPhoneBillAdjustment" runat="server" ControlToValidate="txtPhoneBillAdjustment"
                                                Display="Dynamic" EnableViewState="False" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Phone Actual Bill&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtPhoneActualBill">
                                                Enter Phone Actual Bill</label>
                                            <asp:TextBox ID="txtPhoneActualBill" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvPhoneActualBill" runat="server" ControlToValidate="txtPhoneActualBill"
                                                ErrorMessage="Please Enter Phone Actual Bill" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvPhoneActualBill" runat="server" ControlToValidate="txtPhoneActualBill"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                            <asp:RegularExpressionValidator ID="revPhoneActualBill" runat="server" ControlToValidate="txtPhoneActualBill"
                                                Display="Dynamic" EnableViewState="False" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                    
                                    
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            PBR&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtPBR">
                                                Enter PBR</label>
                                            <asp:TextBox ID="txtPBR" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvPBR" runat="server" ControlToValidate="txtPBR"
                                                ErrorMessage="Please Enter P BR" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvPBR" runat="server" ControlToValidate="txtPBR" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            EBR&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtEBR">
                                                Enter EBR</label>
                                            <asp:TextBox ID="txtEBR" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvEBR" runat="server" ControlToValidate="txtEBR"
                                                ErrorMessage="Please Enter E BR" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvEBR" runat="server" ControlToValidate="txtEBR" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Phone Bill&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtPhoneBill">
                                                Enter Phone Bill</label>
                                            <asp:TextBox ID="txtPhoneBill" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvPhoneBill" runat="server" ControlToValidate="txtPhoneBill"
                                                ErrorMessage="Please Enter Phone Bill" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvPhoneBill" runat="server" ControlToValidate="txtPhoneBill"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RangeValidator>
                                            <asp:RegularExpressionValidator ID="revPhoneBill" runat="server" ControlToValidate="txtPhoneBill"
                                                Display="Dynamic" EnableViewState="False" ValidationGroup="HREmployeeSalaryPaymentEntity"></asp:RegularExpressionValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            REMARKS&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtREMARKS">
                                                Enter REMARKS</label>
                                            <asp:TextBox ID="txtREMARKS" TextMode="MultiLine" CssClass="ktiTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="605" Height="117" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvREMARKS" runat="server" ControlToValidate="txtREMARKS"
                                                ErrorMessage="Please Enter R EMARKS" ValidationGroup="HREmployeeSalaryPaymentEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Payment Status&nbsp;:
                                        </div>
                                        <div class="TableFormContent">
                                            <asp:DropDownList ID="ddlEmployeeSalaryPaymentStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeSalaryPaymentEntity" Width="234">
                                            </asp:DropDownList>
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvEmployeeSalaryPaymentStatusID" runat="server"
                                                ControlToValidate="ddlEmployeeSalaryPaymentStatusID" ErrorMessage="Please Select Employee Salary Payment Status"
                                                ValidationGroup="HREmployeeSalaryPaymentEntity" EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        </div>
                                    </div>
                                    <%--<div class="TableRow" style="width: 100;">
                                    <div class="TableFormLeble" style="text-align: right;">
                                    ,..
                                    </div>
                                    <div class="TableFormContent">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee?')"
                                        CommandArgument='<%#Eval("EmployeeID")%>' UniqueKey="HREmployeeSalaryPayment_lvHREmployeeSalaryPayment_Delete_key" />
                                    </div>
                                    </div>--%>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Process Salary
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsHREmployeeSalaryPayment" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HRMonthlySalaryPayment_CustomDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeSalaryPayment_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                        OnClick="btnSave_Click" runat="server" Text="Save" UniqueKey="HREmployeeSalaryPaymentControl_Submit_key" />
                    <kti:SecureButton ID="btnDelete" Visible="false" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                        OnClick="btnDelete_Click" OnClientClick="return confirm('Are you sure to delete All Payment?')"
                        runat="server" Text="Delete All" UniqueKey="HREmployeeSalaryPaymentControl_Submit_key" />
                    <kti:SecureButton ID="btnGenerate" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                        OnClick="btnGenerate_Click" runat="server" Text="Generate All" UniqueKey="HREmployeeSalaryPaymentControl_Submit_key" />
                        <asp:CheckBox ID="chbxRegenerate" runat="server" AutoPostBack="true" OnCheckedChanged="chbxRegenerate_CheckedChanged"
                            Text="Regenerate Again For Single Employee" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
