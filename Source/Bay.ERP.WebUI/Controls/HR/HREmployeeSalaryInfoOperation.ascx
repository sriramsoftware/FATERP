<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeSalaryInfoOperation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeSalaryInfoOperationControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Fiscal Year&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlFiscalYearID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="HREmployeeSalaryInfoEntity" Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvFiscalYearID" runat="server" ControlToValidate="ddlFiscalYearID"
                        ErrorMessage="Please Select Fiscal Year" ValidationGroup="HREmployeeSalaryInfoEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100; display: none;">
                <div class="TableFormLeble" style="text-align: right;">
                    Salary Session&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlSalarySessionID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="HREmployeeSalaryInfoEntity" Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvSalarySessionID" runat="server" ControlToValidate="ddlSalarySessionID"
                        ErrorMessage="Please Select Salary Session" ValidationGroup="HREmployeeSalaryInfoEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Employee&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlEmployeeID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="HREmployeeSalaryInfoEntity" Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvEmployeeID" runat="server" ControlToValidate="ddlEmployeeID"
                        ErrorMessage="Please Select Employee" ValidationGroup="HREmployeeSalaryInfoEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Is Deposite&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:CheckBox ID="chkIsDeposite" runat="server" ClientIDMode="Static" ValidationGroup="HREmployeeSalaryInfoEntity" />
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
                        runat="server" ValidationGroup="HREmployeeSalaryInfoEntity" Width="210" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvSalaryAmount" runat="server" ControlToValidate="txtSalaryAmount"
                        ErrorMessage="Please Enter Salary Amount" ValidationGroup="HREmployeeSalaryInfoEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvSalaryAmount" runat="server" ControlToValidate="txtSalaryAmount"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="HREmployeeSalaryInfoEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Pay Cycle&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlPayCycleID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="HREmployeeSalaryInfoEntity" Width="234">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Payscale&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlPayscaleID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="HREmployeeSalaryInfoEntity" Width="234">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeSalaryInfoEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="HREmployeeSalaryInfoControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" UniqueKey="HREmployeeSalaryInfoControl_AddNew_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="HREmployeeSalaryInfoControl_Clear_key" />
                </div>
            </div>
            <br />
            <div class="TableRow" style="width: 100%; float: right;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormLeble" style="text-align: right; width: 617px;">
                    Filter Text&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        Type Employee Code or Name</label>
                    <asp:TextBox ID="txtSearchText" runat="server" AutoPostBack="true" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Employee Salary Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeSalaryInfo" runat="server" DataSourceID="odsHREmployeeSalaryInfo"
                        OnItemDataBound="lvHREmployeeSalaryInfo_ItemDataBound" OnItemCommand="lvHREmployeeSalaryInfo_ItemCommand">
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
                                    <td class="hi">
                                        Fiscal Year
                                    </td>
                                    <td class="hi" style="width:40px;">
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
                                    <td class="hi" style="width:225px;">
                                        Employee 
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi">
                                        Department
                                    </td>
                                    <td class="hi">
                                        Designation
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
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeSalaryInfoID")%>'
                                        UniqueKey="HREmployeeSalaryInfo_lvHREmployeeSalaryInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Salary Info?')"
                                        CommandArgument='<%#Eval("EmployeeSalaryInfoID")%>' UniqueKey="HREmployeeSalaryInfo_lvHREmployeeSalaryInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <%# Eval("FiscalYearBeginDate") != null ? ((DateTime)Eval("FiscalYearBeginDate")).ToString("dd-MM-yyyy") : ""%><br/>
                                    <%# Eval("FiscalYearEndDate") != null ? ((DateTime)Eval("FiscalYearEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDeposite") != null ? (((Boolean)Eval("IsDeposite")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalaryAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayCycleName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayscaleName")%>
                                </td>
                                <td class="i">
                                   <b>Employee Code:</b> <%# Eval("EmployeeCode")%> <br /> 
                                   <b>Employee Name:</b><%# Eval("EmployeeFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectCode")%> <br />
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepartmentCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DesignaitonName")%>
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
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeSalaryInfoID")%>'
                                        UniqueKey="HREmployeeSalaryInfo_lvHREmployeeSalaryInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Salary Info?')"
                                        CommandArgument='<%#Eval("EmployeeSalaryInfoID")%>' UniqueKey="HREmployeeSalaryInfo_lvHREmployeeSalaryInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <%# Eval("FiscalYearBeginDate") != null ? ((DateTime)Eval("FiscalYearBeginDate")).ToString("dd-MM-yyyy") : ""%><br/>
                                    <%# Eval("FiscalYearEndDate") != null ? ((DateTime)Eval("FiscalYearEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsDeposite") != null ? (((Boolean)Eval("IsDeposite")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalaryAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayCycleName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PayscaleName")%>
                                </td>
                                <td class="i">
                                   <b>Employee Code:</b> <%# Eval("EmployeeCode")%> <br /> 
                                   <b>Employee Name:</b> <%# Eval("EmployeeFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectCode")%> <br />
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepartmentCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DesignaitonName")%>
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
                <asp:ObjectDataSource ID="odsHREmployeeSalaryInfo" runat="server" SelectMethod="GetPagedData"
                     SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeSalaryInfo_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeSalaryInfo_Selecting">
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
