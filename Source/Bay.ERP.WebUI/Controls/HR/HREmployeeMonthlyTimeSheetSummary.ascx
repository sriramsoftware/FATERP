<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeMonthlyTimeSheetSummary.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeMonthlyTimeSheetSummaryControl" %>
<style type="text/css">
    .TableInfo1
    {
        width: 490px;
        float: left;
    }
    .TableInfo2
    {
        width: 950px;
    }
    .lv-Label
    {
        font-size: 12px;
        font-weight: bold;
        padding-top: 8px;
    }
    .hrdiv
    {
        color: ghostwhite;
        width: 1050px;
    }
</style>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div>
                <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
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
                            Salary Session&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlSalarySessionID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" AutoPostBack="true"
                                Width="234" OnSelectedIndexChanged="ddlSalarySessionID_SelectedIndexChanged">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                            <asp:HyperLink ID="hypReport" Visible="false" runat="server" CssClass="CommonButtonLink"
                                Text="Time Sheet Report" CommandName="HREmployeeMonthlyTimeSheetSummaryReport"
                                UniqueKey="HREmployeeMonthlyTimeSheetSummary_lvHREmployeeDetailsForMonthlyTimeSheetSummary_Report_key"></asp:HyperLink>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvSalarySessionID" runat="server" ControlToValidate="ddlSalarySessionID"
                                ErrorMessage="Please Select Salary Session" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
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
                    <div class="TableRow">
                        <div style="text-align: left; padding-top: 4px; overflow: hidden;">
                            <span style="padding-left: 0px;"><b>Salary For the Period of</b>&nbsp;: &nbsp;<asp:Label
                                ID="lblStartDate" Font-Bold="true" runat="server"></asp:Label>
                            </span><span style="padding-left: 10px;"><b>to</b>&nbsp;: &nbsp;<asp:Label ID="lblEndDate"
                                Font-Bold="true" runat="server"></asp:Label>
                            </span>
                        </div>
                    </div>
                    <br />
                    <br />
                    <div>
                        <div class="lv-b">
                            <asp:ListView ID="lvHREmployeeDetailsForMonthlyTimeSheetSummary" runat="server" DataSourceID="odsHREmployeeDetailsForMonthlyTimeSheetSummary"
                                OnItemDataBound="lvHREmployeeDetailsForMonthlyTimeSheetSummary_ItemDataBound"
                                DataKeyNames="EmployeeID" OnItemCommand="lvHREmployeeDetailsForMonthlyTimeSheetSummary_ItemCommand">
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
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Employee&nbsp;:
                                        </div>
                                        <div class="TableFormLeble" style="width: 200px;">
                                            <div style="display: none;">
                                                <asp:Label ID="employeeIDlv" Text='<%#Eval("EmployeeID")%>' runat="server" ClientIDMode="Static" />
                                                <asp:Label ID="lbldepartmentID" Text='<%#Eval("DepartmentID")%>' runat="server" ClientIDMode="Static" />
                                            </div>
                                            <asp:Label ID="lblEmployeeName" Text='<%#Eval("EmployeeFullName")%>' ClientIDMode="Static"
                                                runat="server" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Employee Code&nbsp;:
                                        </div>
                                        <div class="TableFormLeble" style="width: 200px;">
                                            <asp:Label ID="lblEmployeeCode" Text='<%#Eval("EmployeeCode")%>' ClientIDMode="Static"
                                                runat="server" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Joining Date&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtJoinDate">
                                                No Joining Date</label>
                                            <asp:TextBox ID="txtJoinDate" CssClass="ktiNumberTextBox" Text='<%#Eval("JoinDate")%>'
                                                ClientIDMode="Static" runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                Width="210" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Service Age&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtServiceAgeMonth">
                                                No Service Age</label>
                                            <asp:TextBox ID="txtServiceAgeMonth" CssClass="ktiNumberTextBox" Text='<%#Eval("ServiceAgeMonth")%>'
                                                ClientIDMode="Static" runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                Width="210" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Project Code&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtProjectCode">
                                                No Project Code</label>
                                            <asp:TextBox ID="txtProjectCode" CssClass="ktiNumberTextBox" Text='<%#Eval("ProjectCode")%>'
                                                ClientIDMode="Static" Enabled="false" runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                Width="210" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Designation&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtDesignation">
                                                No Designation</label>
                                            <asp:TextBox ID="txtDesignation" CssClass="ktiNumberTextBox" Text='<%#Eval("DesignationName")%>'
                                                ClientIDMode="Static" runat="server" Enabled="false" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                Width="210" />
                                        </div>
                                        <div class="TableFormValidatorContent">
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Employee Job Type&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtEmployeeJobTypeID">
                                                Enter Employee Job Type</label>
                                            <asp:TextBox ID="txtEmployeeJobTypeID" CssClass="ktiNumberTextBox" Text='<%#Eval("EmploymentStatusName")%>'
                                                ClientIDMode="Static" Enabled="false" runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                Width="210" />
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Salary Level&nbsp;:
                                        </div>
                                        <div class="TableFormContent">
                                            <asp:TextBox ID="txtSalaryLevel" runat="server" ClientIDMode="Static" Text='<%#Eval("SalaryLevel")%>'
                                                CssClass="ktiNumberTextBox" Enabled="false" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                Width="210" />
                                        </div>
                                        <div class="TableFormValidatorContent">
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            On Job&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtOnJob">
                                                On Job</label>
                                            <asp:TextBox ID="txtOnJob" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvOnJob" runat="server" ControlToValidate="txtOnJob"
                                                ErrorMessage="Please Enter On Job" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvOnJob" runat="server" ControlToValidate="txtOnJob" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Holiday&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtHoliday">
                                                Enter Holiday</label>
                                            <asp:TextBox ID="txtHoliday" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvHoliday" runat="server" ControlToValidate="txtHoliday"
                                                ErrorMessage="Please Enter Holiday" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvHoliday" runat="server" ControlToValidate="txtHoliday"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            LCASUAL&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtLCASUAL">
                                                Enter LCASUAL</label>
                                            <asp:TextBox ID="txtLCASUAL" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvLCASUAL" runat="server" ControlToValidate="txtLCASUAL"
                                                ErrorMessage="Please Enter L CASUAL" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvLCASUAL" runat="server" ControlToValidate="txtLCASUAL"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            LMEDICAL&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtLMEDICAL">
                                                Enter LMEDICAL</label>
                                            <asp:TextBox ID="txtLMEDICAL" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvLMEDICAL" runat="server" ControlToValidate="txtLMEDICAL"
                                                ErrorMessage="Please Enter L MEDICAL" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvLMEDICAL" runat="server" ControlToValidate="txtLMEDICAL"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            EARNLEAVE&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtEARNLEAVE">
                                                Enter EARNLEAVE</label>
                                            <asp:TextBox ID="txtEARNLEAVE" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvEARNLEAVE" runat="server" ControlToValidate="txtEARNLEAVE"
                                                ErrorMessage="Please Enter E ARNLEAVE" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvEARNLEAVE" runat="server" ControlToValidate="txtEARNLEAVE"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            LWP&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtLWP">
                                                Enter LWP</label>
                                            <asp:TextBox ID="txtLWP" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvLWP" runat="server" ControlToValidate="txtLWP"
                                                ErrorMessage="Please Enter L WP" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvLWP" runat="server" ControlToValidate="txtLWP" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            WORKDAYS&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtACTUALWORKDAYS">
                                                Enter WORKDAYS</label>
                                            <asp:TextBox ID="txtACTUALWORKDAYS" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvACTUALWORKDAYS" runat="server" ControlToValidate="txtACTUALWORKDAYS"
                                                ErrorMessage="Please Enter A CTUALWORKDAYS" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvACTUALWORKDAYS" runat="server" ControlToValidate="txtACTUALWORKDAYS"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
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
                                                runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="605"
                                                Height="117" />
                                        </div>
                                        <div class="TableFormValidatorContent">
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            NUMBEROFMEALS&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtNUMBEROFMEALS">
                                                Enter NUMBEROFMEALS</label>
                                            <asp:TextBox ID="txtNUMBEROFMEALS" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvNUMBEROFMEALS" runat="server" ControlToValidate="txtNUMBEROFMEALS"
                                                ErrorMessage="Please Enter N UMBEROFMEALS" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvNUMBEROFMEALS" runat="server" ControlToValidate="txtNUMBEROFMEALS"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            PROJECTACTUAL&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtPROJECTACTUAL">
                                                Enter PROJECTACTUAL</label>
                                            <asp:TextBox ID="txtPROJECTACTUAL" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvPROJECTACTUAL" runat="server" ControlToValidate="txtPROJECTACTUAL"
                                                ErrorMessage="Please Enter P ROJECTACTUAL" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvPROJECTACTUAL" runat="server" ControlToValidate="txtPROJECTACTUAL"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            OTHERLEAVE&nbsp;:
                                        </div>
                                        <div class="TableFormContent waterMarkContainer">
                                            <label class="watermarkLabel" for="txtOTHERLEAVE">
                                                Enter OTHERLEAVE</label>
                                            <asp:TextBox ID="txtOTHERLEAVE" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                runat="server" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="210" />
                                            <span class="RequiredField">*</span>
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvOTHERLEAVE" runat="server" ControlToValidate="txtOTHERLEAVE"
                                                ErrorMessage="Please Enter O THERLEAVE" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvOTHERLEAVE" runat="server" ControlToValidate="txtOTHERLEAVE"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Field1&nbsp;:
                                        </div>
                                        <div class="TableFormContent">
                                            <asp:TextBox ID="txtField1" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Type="Number" Width="210" />
                                        </div>
                                        <div class="TableFormValidatorContent">
                                            <asp:RangeValidator ID="rvField1" runat="server" ControlToValidate="txtField1" Display="Dynamic"
                                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"></asp:RangeValidator>
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Field11&nbsp;:
                                        </div>
                                        <div class="TableFormContent">
                                            <asp:TextBox ID="txtField11" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                                ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="230" />
                                        </div>
                                        <div class="TableFormValidatorContent">
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Field12&nbsp;:
                                        </div>
                                        <div class="TableFormContent">
                                            <asp:TextBox ID="txtField12" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                                ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="230" />
                                        </div>
                                        <div class="TableFormValidatorContent">
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Field13&nbsp;:
                                        </div>
                                        <div class="TableFormContent">
                                            <asp:TextBox ID="txtField13" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                                ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="230" />
                                        </div>
                                        <div class="TableFormValidatorContent">
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Field14&nbsp;:
                                        </div>
                                        <div class="TableFormContent">
                                            <asp:TextBox ID="txtField14" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                                ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="230" />
                                        </div>
                                        <div class="TableFormValidatorContent">
                                        </div>
                                    </div>
                                    <div class="TableRow" style="width: 100; display: none;">
                                        <div class="TableFormLeble" style="text-align: right;">
                                            Field15&nbsp;:
                                        </div>
                                        <div class="TableFormContent">
                                            <asp:TextBox ID="txtField15" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                                ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity" Width="230" />
                                        </div>
                                        <div class="TableFormValidatorContent">
                                        </div>
                                    </div>
                                    <div class="TableRow" style="text-align: center; display: none;">
                                        <div class="TableFormLeble">
                                            &nbsp;</div>
                                        <div class="TableFormContent">
                                            <%--<kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                                OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="HREmployeeMonthlyTimeSheetSummaryControl_Submit_key" />--%>
                                            <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                                                Text="Add New" UniqueKey="HREmployeeMonthlyTimeSheetSummaryControl_AddNew_key" />
                                            <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                                                UniqueKey="HREmployeeMonthlyTimeSheetSummaryControl_Clear_key" />
                                        </div>
                                    </div>
                                    <br />
                                </ItemTemplate>
                                <EmptyDataTemplate>
                                    <div class="edr">
                                        No Records Found To Display
                                    </div>
                                </EmptyDataTemplate>
                            </asp:ListView>
                        </div>
                        <asp:ObjectDataSource ID="odsHREmployeeDetailsForMonthlyTimeSheetSummary" runat="server"
                            SelectMethod="GetPagedData" SelectCountMethod="TotalRowCount" EnablePaging="true"
                            MaximumRowsParameterName="pageSize" StartRowIndexParameterName="startRowIndex"
                            TypeName="Bay.ERP.Web.UI.HREmployeeMonthlyTimeSheet_DetailedDataSource" SortParameterName="sortExpression"
                            OnSelecting="odsHREmployeeDetailsForMonthlyTimeSheetSummary_Selecting">
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
                                OnClick="btnSave_Click" runat="server" Text="Save" UniqueKey="HREmployeeMonthlyTimeSheetSummaryControl_Submit_key" />
                            <kti:SecureButton ID="btnDelete" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                OnClick="btnDelete_Click" OnClientClick="return confirm('Are you sure to delete Time Sheet All Data For this session? Please Check your Salary Session before delete.')"
                                runat="server" Text="Delete All" UniqueKey="HREmployeeMonthlyTimeSheetSummaryControl_Submit_key" />
                            <kti:SecureButton ID="btnGenerate" ValidationGroup="HREmployeeMonthlyTimeSheetSummaryEntity"
                                OnClick="btnGenerate_Click" runat="server" Text="Generate All" UniqueKey="HREmployeeMonthlyTimeSheetSummaryControl_Submit_key" />
                            <asp:CheckBox ID="chbxRegenerate" runat="server" AutoPostBack="true" OnCheckedChanged="chbxRegenerate_CheckedChanged"
                                Text="Regenerate Again For Single Employee" />
                        </div>
                    </div>
                </asp:Panel>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
