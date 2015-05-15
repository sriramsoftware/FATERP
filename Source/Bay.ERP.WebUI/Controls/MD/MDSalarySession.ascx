<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 19-Dec-2013, 12:42:28
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDSalarySession.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MDSalarySessionControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Salary Session"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
        <div>
        <div >
        <div style="float:left; width:500px;">
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypFiscalYear" runat="server" Text="Fiscal Year"
                            NavigateUrl="~/AC/ACFiscalYear.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlFiscalYearID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDSalarySessionEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFiscalYearID" runat="server" ControlToValidate="ddlFiscalYearID"
                            ErrorMessage="Please Select Fiscal Year" ValidationGroup="MDSalarySessionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtName">
                            Enter Name</label>
                        <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="MDSalarySessionEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ErrorMessage="Please Enter Name" ValidationGroup="MDSalarySessionEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Session Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSessionStartDate">
                            Enter Session Start Date</label>
                        <asp:TextBox ID="txtSessionStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="MDSalarySessionEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSessionStartDate" runat="server" ControlToValidate="txtSessionStartDate"
                            ErrorMessage="Please Enter Session Start Date" ValidationGroup="MDSalarySessionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revSessionStartDate" runat="server" ControlToValidate="txtSessionStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="MDSalarySessionEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Session End Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSessionEndDate">
                            Enter Session End Date</label>
                        <asp:TextBox ID="txtSessionEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="MDSalarySessionEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSessionEndDate" runat="server" ControlToValidate="txtSessionEndDate"
                            ErrorMessage="Please Enter Session End Date" ValidationGroup="MDSalarySessionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revSessionEndDate" runat="server" ControlToValidate="txtSessionEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="MDSalarySessionEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRemarks" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="MDSalarySessionEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Session Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSalarySessionStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDSalarySessionEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSalarySessionStatusID" runat="server" ControlToValidate="ddlSalarySessionStatusID"
                            ErrorMessage="Please Select Salary Session Status" ValidationGroup="MDSalarySessionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Current Session&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsCurrentSession" runat="server" ClientIDMode="Static" ValidationGroup="MDSalarySessionEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="MDSalarySessionEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="MDSalarySessionControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="MDSalarySessionControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="MDSalarySessionControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            </div>
            <div class="contentSeperator" style="min-height:200px;">
            </div>
            <div style="float:left; width:400px;">
            <div id="dvQuick" style="width:360px;">
                <h3>Follow Steps</h3>
                <asp:HyperLink ID="hypTaskCategory" runat="server" NavigateUrl="~/AC/ACFiscalyear.aspx" Text="Step 1: Create Fiscal Year" Target="_blank"></asp:HyperLink><br /><br />
                <asp:HyperLink ID="hypSalarySession" runat="server" NavigateUrl="~/MD/MDSalarySession.aspx"  Text="Step 2: Create Salary Session"></asp:HyperLink><br /><br />
                <asp:HyperLink ID="hypTask" runat="server" NavigateUrl="~/HR/HRWorkingDay.aspx" Text="Step 3: Generate Working Day" Target="_blank"></asp:HyperLink><br /><br />
                <asp:HyperLink ID="hypTaskTemplate" runat="server" NavigateUrl="~/Default.aspx" Text="Step 4: Check Leave Approval Do Approve or Not" Target="_blank"></asp:HyperLink><br /><br />
                <asp:HyperLink ID="hypTaskSetup" runat="server" NavigateUrl="~/HR/HREmployeeMonthlyTimeSheetSummary.aspx" Text="Step 5: Genereate Time Sheet" Target="_blank"></asp:HyperLink><br /><br />
                <asp:HyperLink ID="HyperLink1" runat="server" Text="Step 6: Genereate Salary From Salary Session List" ></asp:HyperLink><br /><br />
                </div>
            </div>
            <div style="clear:both"></div>
        </div>
            <div class="listContentTitle">
                Salary Session List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvMDSalarySession" runat="server" DataSourceID="odsMDSalarySession"
                        OnItemCommand="lvMDSalarySession_ItemCommand" OnItemDataBound="lvMDSalarySession_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width: 69px;">
                                        Fiscal Year
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Name
                                    </td>
                                    <td class="hi" style="width: 100px;">
                                        Session
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Remarks
                                    </td>
                                    <td class="hi" style="width: 50px;">
                                        Salary Session Status
                                    </td>
                                    <td class="hi" style="width: 32px;">
                                        Is Current Session
                                    </td>
                                    <td class="hi" style="width: 30px;">
                                        Time Sheet Report
                                    </td>
                                    <td class="hi" style="width: 50px;">
                                        Generate Salary 
                                    </td>
                                    <td class="hi" style="width: 123px;">
                                        Salary Statement 
                                    </td>
                                    <td class="hi" style="width:115px;">
                                        Pay Advice 
                                    </td>
                                    <td class="hi" style="width: 70px;">
                                        Bank Disbursement 
                                    </td>
                                    <td class="hi" style="width: 120px;">
                                        Leave Applications 
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
                                    <%# Eval("FiscalYearBeginDate") != null ? ((DateTime)Eval("FiscalYearBeginDate")).ToString("dd-MM-yyyy") : ""%>&nbsp;to
                                    <br />
                                    <%# Eval("FiscalYearEndDate") != null ? ((DateTime)Eval("FiscalYearEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("SalarySessionName")%>
                                </td>
                                <td class="i">
                                    <b><%# Eval("SalarySessionName")%></b><br />
                                    <b>Start:</b>&nbsp;<%# Eval("SessionStartDate") != null ? ((DateTime)Eval("SessionStartDate")).ToString("dd-MM-yyyy") : ""%>&nbsp;to
                                    <br />
                                    <b>End:</b>&nbsp;<%# Eval("SessionEndDate") != null ? ((DateTime)Eval("SessionEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalarySessionStatusName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsCurrentSession") != null ? (((Boolean)Eval("IsCurrentSession")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                        CommandName="TimeSheetReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypSalaryPayment" runat="server" CssClass="CommonButtonLink" Text="Generate Salary"
                                        CommandName="SalaryPayment" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypEmployeeSalaryStatementReport" runat="server" CssClass="CommonButtonLink"
                                        Text="For Employee Report" CommandName="SalaryStatementReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>

                                        <asp:HyperLink ID="hypSecurityGaurdSalaryStatementReport" runat="server" CssClass="CommonButtonLink"
                                        Text="For Security Report" CommandName="SalaryStatementReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypEmployeeSalaryPaymentReport" runat="server" CssClass="CommonButtonLink"
                                        Text="Employee Report" CommandName="SalaryPaymentReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>

                                        <asp:HyperLink ID="hypSecurityGaurdSalaryPaymentReport" runat="server" CssClass="CommonButtonLink"
                                        Text="Security Guard Report" CommandName="SalaryPaymentReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypBankDisbursementLevel4Plus" runat="server" CssClass="CommonButtonLink"
                                        Text="Level 4+" CommandName="HREmployeeSalaryDisbursementBank" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                    <br />
                                    <asp:HyperLink ID="hypBankDisbursementLevel1To3" runat="server" CssClass="CommonButtonLink"
                                        Text="Level 1-3" CommandName="HREmployeeSalaryDisbursementBank" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypLeaveApplications" runat="server" CssClass="CommonButtonLink"
                                        Text="Leave Applications Report" CommandName="LeaveApplicationsReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("SalarySessionID")%>' UniqueKey="MDSalarySession_lvMDSalarySession_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Salary Session?')"
                                        CommandArgument='<%#Eval("SalarySessionID")%>' UniqueKey="MDSalarySession_lvMDSalarySession_Edit_key" />
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
                                    <%# Eval("FiscalYearBeginDate") != null ? ((DateTime)Eval("FiscalYearBeginDate")).ToString("dd-MM-yyyy") : ""%>&nbsp;to
                                    <br />
                                    <%# Eval("FiscalYearEndDate") != null ? ((DateTime)Eval("FiscalYearEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("SalarySessionName")%>
                                </td>
                                <td class="i">
                                <b><%# Eval("SalarySessionName")%></b><br />
                                    <b>Start:</b>&nbsp;<%# Eval("SessionStartDate") != null ? ((DateTime)Eval("SessionStartDate")).ToString("dd-MM-yyyy") : ""%>&nbsp;to
                                    <br />
                                    <b>End:</b>&nbsp;<%# Eval("SessionEndDate") != null ? ((DateTime)Eval("SessionEndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SalarySessionStatusName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsCurrentSession") != null ? (((Boolean)Eval("IsCurrentSession")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                        CommandName="TimeSheetReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypSalaryPayment" runat="server" CssClass="CommonButtonLink" Text="Generate Salary"
                                        CommandName="SalaryPayment" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                 <td class="i">
                                    <asp:HyperLink ID="hypEmployeeSalaryStatementReport" runat="server" CssClass="CommonButtonLink"
                                        Text="For Employee Report" CommandName="SalaryStatementReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>

                                        <asp:HyperLink ID="hypSecurityGaurdSalaryStatementReport" runat="server" CssClass="CommonButtonLink"
                                        Text="For Security Report" CommandName="SalaryStatementReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypEmployeeSalaryPaymentReport" runat="server" CssClass="CommonButtonLink"
                                        Text="Employee Report" CommandName="SalaryPaymentReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>

                                        <asp:HyperLink ID="hypSecurityGaurdSalaryPaymentReport" runat="server" CssClass="CommonButtonLink"
                                        Text="Security Guard Report" CommandName="SalaryPaymentReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypBankDisbursementLevel4Plus" runat="server" CssClass="CommonButtonLink"
                                        Text="Level 4+" CommandName="HREmployeeSalaryDisbursementBank" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                    <br />
                                    <asp:HyperLink ID="hypBankDisbursementLevel1To3" runat="server" CssClass="CommonButtonLink"
                                        Text="Level 1-3" CommandName="HREmployeeSalaryDisbursementBank" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypLeaveApplications" runat="server" CssClass="CommonButtonLink"
                                        Text="Leave Applications Report" CommandName="LeaveApplicationsReport" CommandArgument='<%#Eval("SalarySessionID")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("SalarySessionID")%>' UniqueKey="MDSalarySession_lvMDSalarySession_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Salary Session?')"
                                        CommandArgument='<%#Eval("SalarySessionID")%>' UniqueKey="MDSalarySession_lvMDSalarySession_Edit_key" />
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
                <asp:ObjectDataSource ID="odsMDSalarySession" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.MDSalarySession_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsMDSalarySession_Selecting">
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
