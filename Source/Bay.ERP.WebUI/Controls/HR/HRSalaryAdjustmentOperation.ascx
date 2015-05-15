<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HRSalaryAdjustmentOperation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HRSalaryAdjustmentOperationControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Salary Adjustment"></asp:Label>
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
                        Fiscal Year&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlFiscalYearID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HRSalaryAdjustmentEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFiscalYearID" runat="server" ControlToValidate="ddlFiscalYearID"
                            ErrorMessage="Please Select Fiscal Year" ValidationGroup="HRSalaryAdjustmentEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Salary Session&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSalarySessionID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HRSalaryAdjustmentEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSalarySessionID" runat="server" ControlToValidate="ddlSalarySessionID"
                            ErrorMessage="Please Select Salary Session" ValidationGroup="HRSalaryAdjustmentEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="HRSalaryAdjustmentEntity" AutoPostBack="true" Width="234" OnSelectedIndexChanged="ddlEmployeeID_SelectedIndexChanged">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeID" runat="server" ControlToValidate="ddlEmployeeID"
                            ErrorMessage="Please Select Employee" ValidationGroup="HRSalaryAdjustmentEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Salary Level&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtSalaryLevel" Enabled="false" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="HRSalaryAdjustmentEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvSalaryLevel" runat="server" ControlToValidate="txtSalaryLevel"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="HRSalaryAdjustmentEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Designation&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDesignationID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HRSalaryAdjustmentEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
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
                            ValidationGroup="HRSalaryAdjustmentEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeCode" runat="server" ControlToValidate="txtEmployeeCode"
                            ErrorMessage="Please Enter Employee Code" ValidationGroup="HRSalaryAdjustmentEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Employee Job Type&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEmployeeJobTypeID">
                            Enter Employee Job Type</label>
                        <asp:TextBox ID="txtEmployeeJobTypeID" CssClass="ktiNumberTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HRSalaryAdjustmentEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeJobTypeID" runat="server" ControlToValidate="txtEmployeeJobTypeID"
                            ErrorMessage="Please Enter Employee Job Type" ValidationGroup="HRSalaryAdjustmentEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvEmployeeJobTypeID" runat="server" ControlToValidate="txtEmployeeJobTypeID"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="HRSalaryAdjustmentEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Adjustment Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAdjustmentAmount">
                            Enter Adjustment Amount</label>
                        <asp:TextBox ID="txtAdjustmentAmount" CssClass="ktiTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="HRSalaryAdjustmentEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAdjustmentAmount" runat="server" ControlToValidate="txtAdjustmentAmount"
                            ErrorMessage="Please Enter Adjustment Amount" ValidationGroup="HRSalaryAdjustmentEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvAdjustmentAmount" runat="server" ControlToValidate="txtAdjustmentAmount"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="HRSalaryAdjustmentEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRemarks" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="HRSalaryAdjustmentEntity" TextMode="MultiLine" Height="70" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <%--<kti:SecureButton ID="btnSubmit" ValidationGroup="HRSalaryAdjustmentEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HRSalaryAdjustmentControl_Submit_key" />--%>
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="HRSalaryAdjustmentControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="HRSalaryAdjustmentControl_Clear_key" />
                        <asp:Button ID="btnSubmit" ValidationGroup="HRSalaryAdjustmentEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HRSalaryAdjustmentControl_Submit_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
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
        <br />
            <div class="listContentTitle">
                Salary Adjustment List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHRSalaryAdjustment" runat="server" DataSourceID="odsHRSalaryAdjustment"
                        OnItemCommand="lvHRSalaryAdjustment_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Fiscal Year
                                    </td>
                                    <td class="hi">
                                        Salary Session
                                    </td>
                                    <td class="hi" style="width:200px;">
                                        Employee
                                    </td>
                                    <td class="hi" style="width:25px; display:none;">
                                        Salary Level
                                    </td>
                                    <td class="hi" style="width:160px;">
                                        Designation
                                    </td>
                                    <td class="hi">
                                        Employee Job Type
                                    </td>
                                    <td class="hi">
                                        Adjustment Amount
                                    </td>
                                    <td class="hi">
                                        Remarks
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
                                    <b>Start :</b><%# Eval("BeginDate") != null ? ((DateTime)Eval("BeginDate")).ToString("dd-MM-yyyy") : ""%><br />
                                    <b>End : </b>
                                    <%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <b>Start :</b><%# Eval("SessionStartDate") != null ? ((DateTime)Eval("SessionStartDate")).ToString("dd-MM-yyyy") : ""%><br />
                                    <b>End : </b>
                                    <%# Eval("SessionEndDate") != null ? ((DateTime)Eval("SessionEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <b>Code: </b>
                                    <%# Eval("EmployeeCode")%><br />
                                    <b>Name: </b>
                                    <%# Eval("EmployeeFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("SalaryLevel")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DesignationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeJobTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AdjustmentAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("SalaryAdjustmentID")%>' UniqueKey="HRSalaryAdjustment_lvHRSalaryAdjustment_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Salary Adjustment?')"
                                        CommandArgument='<%#Eval("SalaryAdjustmentID")%>' UniqueKey="HRSalaryAdjustment_lvHRSalaryAdjustment_Edit_key" />
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
                                    <b>Start :</b><%# Eval("BeginDate") != null ? ((DateTime)Eval("BeginDate")).ToString("dd-MM-yyyy") : ""%><br />
                                    <b>End : </b>
                                    <%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <b>Start :</b><%# Eval("SessionStartDate") != null ? ((DateTime)Eval("SessionStartDate")).ToString("dd-MM-yyyy") : ""%><br />
                                    <b>End : </b>
                                    <%# Eval("SessionEndDate") != null ? ((DateTime)Eval("SessionEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <b>Code: </b>
                                    <%# Eval("EmployeeCode")%><br />
                                    <b>Name: </b>
                                    <%# Eval("EmployeeFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("SalaryLevel")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DesignationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeJobTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AdjustmentAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("SalaryAdjustmentID")%>' UniqueKey="HRSalaryAdjustment_lvHRSalaryAdjustment_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Salary Adjustment?')"
                                        CommandArgument='<%#Eval("SalaryAdjustmentID")%>' UniqueKey="HRSalaryAdjustment_lvHRSalaryAdjustment_Edit_key" />
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
                <asp:ObjectDataSource ID="odsHRSalaryAdjustment" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HRSalaryAdjustment_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHRSalaryAdjustment_Selecting">
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
