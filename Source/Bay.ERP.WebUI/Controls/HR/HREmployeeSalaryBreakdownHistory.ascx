<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeSalaryBreakdownHistory.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeSalaryBreakdownHistoryControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee Salary Breakdown History"></asp:Label>
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
                        Employee Salary Breakdown History&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEmployeeSalaryBreakdownHistoryID">
                            Enter Employee Salary Breakdown History</label>
                        <asp:TextBox ID="txtEmployeeSalaryBreakdownHistoryID" CssClass="ktiNumberTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeSalaryBreakdownHistoryID" runat="server" ControlToValidate="txtEmployeeSalaryBreakdownHistoryID"
                            ErrorMessage="Please Enter Employee Salary Breakdown History" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvEmployeeSalaryBreakdownHistoryID" runat="server" ControlToValidate="txtEmployeeSalaryBreakdownHistoryID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee Salary Break Down&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeSalaryBreakDownID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeSalaryBreakDownID" runat="server" ControlToValidate="ddlEmployeeSalaryBreakDownID"
                            ErrorMessage="Please Select Employee Salary Break Down" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee Salary Info&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEmployeeSalaryInfoID">
                            Enter Employee Salary Info</label>
                        <asp:TextBox ID="txtEmployeeSalaryInfoID" CssClass="ktiNumberTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeSalaryInfoID" runat="server" ControlToValidate="txtEmployeeSalaryInfoID"
                            ErrorMessage="Please Enter Employee Salary Info" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvEmployeeSalaryInfoID" runat="server" ControlToValidate="txtEmployeeSalaryInfoID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity"></asp:RangeValidator>
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
                            ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeID" runat="server" ControlToValidate="txtEmployeeID"
                            ErrorMessage="Please Enter Employee" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvEmployeeID" runat="server" ControlToValidate="txtEmployeeID" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Yearly Rate&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtYearlyRate">
                            Enter Yearly Rate</label>
                        <asp:TextBox ID="txtYearlyRate" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvYearlyRate" runat="server" ControlToValidate="txtYearlyRate"
                            ErrorMessage="Please Enter Yearly Rate" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvYearlyRate" runat="server" ControlToValidate="txtYearlyRate" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Monthly Rate&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtMonthlyRate">
                            Enter Monthly Rate</label>
                        <asp:TextBox ID="txtMonthlyRate" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvMonthlyRate" runat="server" ControlToValidate="txtMonthlyRate"
                            ErrorMessage="Please Enter Monthly Rate" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvMonthlyRate" runat="server" ControlToValidate="txtMonthlyRate" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Daily Rate&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtDailyRate">
                            Enter Daily Rate</label>
                        <asp:TextBox ID="txtDailyRate" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDailyRate" runat="server" ControlToValidate="txtDailyRate"
                            ErrorMessage="Please Enter Daily Rate" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvDailyRate" runat="server" ControlToValidate="txtDailyRate" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        O THourly Rate&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtOTHourlyRate">
                            Enter O THourly Rate</label>
                        <asp:TextBox ID="txtOTHourlyRate" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvOTHourlyRate" runat="server" ControlToValidate="txtOTHourlyRate"
                            ErrorMessage="Please Enter O THourly Rate" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvOTHourlyRate" runat="server" ControlToValidate="txtOTHourlyRate" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Houlry Rate&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtHoulryRate">
                            Enter Houlry Rate</label>
                        <asp:TextBox ID="txtHoulryRate" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvHoulryRate" runat="server" ControlToValidate="txtHoulryRate"
                            ErrorMessage="Please Enter Houlry Rate" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvHoulryRate" runat="server" ControlToValidate="txtHoulryRate" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity"></asp:RangeValidator>
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
                            ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            ErrorMessage="Please Enter Create Date" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Created By Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCreatedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreatedByEmployeeID" runat="server" ControlToValidate="ddlCreatedByEmployeeID"
                            ErrorMessage="Please Select Created By Employee" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeSalaryBreakdownHistoryEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeSalaryBreakdownHistoryControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="HREmployeeSalaryBreakdownHistoryControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="HREmployeeSalaryBreakdownHistoryControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Employee Salary Breakdown History List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeSalaryBreakdownHistory" runat="server" DataSourceID="odsHREmployeeSalaryBreakdownHistory" OnItemCommand="lvHREmployeeSalaryBreakdownHistory_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Employee Salary Break Down
                                    </td>
                                    <td class="hi">
                                        Employee Salary Info
                                    </td>
                                    <td class="hi">
                                        Employee
                                    </td>
                                    <td class="hi">
                                        Yearly Rate
                                    </td>
                                    <td class="hi">
                                        Monthly Rate
                                    </td>
                                    <td class="hi">
                                        Daily Rate
                                    </td>
                                    <td class="hi">
                                        O THourly Rate
                                    </td>
                                    <td class="hi">
                                        Houlry Rate
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
                                    <%# Eval("EmployeeSalaryBreakDownID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeSalaryInfoID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("YearlyRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MonthlyRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DailyRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OTHourlyRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("HoulryRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeSalaryBreakdownHistoryID")%>' UniqueKey="HREmployeeSalaryBreakdownHistory_lvHREmployeeSalaryBreakdownHistory_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Salary Breakdown History?')"
                                        CommandArgument='<%#Eval("EmployeeSalaryBreakdownHistoryID")%>' UniqueKey="HREmployeeSalaryBreakdownHistory_lvHREmployeeSalaryBreakdownHistory_Edit_key"/>
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
                                    <%# Eval("EmployeeSalaryBreakDownID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeSalaryInfoID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("YearlyRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MonthlyRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DailyRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OTHourlyRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("HoulryRate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeSalaryBreakdownHistoryID")%>' UniqueKey="HREmployeeSalaryBreakdownHistory_lvHREmployeeSalaryBreakdownHistory_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Salary Breakdown History?')"
                                        CommandArgument='<%#Eval("EmployeeSalaryBreakdownHistoryID")%>' UniqueKey="HREmployeeSalaryBreakdownHistory_lvHREmployeeSalaryBreakdownHistory_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsHREmployeeSalaryBreakdownHistory" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeSalaryBreakdownHistoryDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeSalaryBreakdownHistory_Selecting">
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
