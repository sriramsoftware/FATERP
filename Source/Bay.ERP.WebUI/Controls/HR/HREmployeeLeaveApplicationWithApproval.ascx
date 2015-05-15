<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeLeaveApplicationWithApproval.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeLeaveApplicationWithApprovalControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Employee&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlEmployeeID" Enabled="false" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity" Width="234">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Application Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtApplicationDate">
                        Enter Application Date</label>
                    <asp:TextBox ID="txtApplicationDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="HREmployeeLeaveApplicationEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvApplicationDate" runat="server" ControlToValidate="txtApplicationDate"
                        ErrorMessage="Please Enter Application Date" ValidationGroup="HREmployeeLeaveApplicationEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revApplicationDate" runat="server" ControlToValidate="txtApplicationDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="HREmployeeLeaveApplicationEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Request Start Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtRequestStartDate">
                        Enter Request Start Date</label>
                    <asp:TextBox ID="txtRequestStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="HREmployeeLeaveApplicationEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvRequestStartDate" runat="server" ControlToValidate="txtRequestStartDate"
                        ErrorMessage="Please Enter Request Start Date" ValidationGroup="HREmployeeLeaveApplicationEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revRequestStartDate" runat="server" ControlToValidate="txtRequestStartDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="HREmployeeLeaveApplicationEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Request End Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtRequestEndDate">
                        Enter Request End Date</label>
                    <asp:TextBox ID="txtRequestEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="HREmployeeLeaveApplicationEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvRequestEndDate" runat="server" ControlToValidate="txtRequestEndDate"
                        ErrorMessage="Please Enter Request End Date" ValidationGroup="HREmployeeLeaveApplicationEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revRequestEndDate" runat="server" ControlToValidate="txtRequestEndDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="HREmployeeLeaveApplicationEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Total Leave Days&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtTotalLeaveDays">
                        Enter Total Leave Days</label>
                    <asp:TextBox ID="txtTotalLeaveDays" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity" Width="210" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvTotalLeaveDays" runat="server" ControlToValidate="txtTotalLeaveDays"
                        ErrorMessage="Please Enter Total Leave Days" ValidationGroup="HREmployeeLeaveApplicationEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvTotalLeaveDays" runat="server" ControlToValidate="txtTotalLeaveDays"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="HREmployeeLeaveApplicationEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Description&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlLeavePurpose" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity" AutoPostBack="true"
                        Width="234">
                        <asp:ListItem Selected="false" Text="Personal" Value="Personal"></asp:ListItem>
                        <asp:ListItem Text="Exchange Leave" Value="Exchange Leave"></asp:ListItem>
                        <asp:ListItem Text="Sick" Value="Sick"></asp:ListItem>
                        <asp:ListItem Text="Accident" Value="Accident"></asp:ListItem>
                        <asp:ListItem Text="Uninformed Delay" Value="Uninformed Delay"></asp:ListItem>
                        <asp:ListItem Text="Vacation" Value="Vacation"></asp:ListItem>
                        <asp:ListItem Text="Treatment" Value="Treatment"></asp:ListItem>
                        <asp:ListItem Text="Marriage Ceremony" Value="Marriage Ceremony"></asp:ListItem>
                        <asp:ListItem Text="Maternal Leave" Value="Maternal Leave"></asp:ListItem>
                        <asp:ListItem Text="Parent death" Value="Parent death"></asp:ListItem>
                    </asp:DropDownList>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Leave Location&nbsp;:
                </div>
                <div class="TableFormContent">
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLeaveLocation" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity" AutoPostBack="true"
                            Width="234">
                            <asp:ListItem Selected="false" Text="Village" Value="Village"></asp:ListItem>
                            <asp:ListItem Text="Home" Value="Home"></asp:ListItem>
                            <asp:ListItem Text="Out of Dhaka" Value="Out of Dhaka"></asp:ListItem>
                            <asp:ListItem Text="Out of country" Value="Out of country"></asp:ListItem>
                            <asp:ListItem Text="Hospital" Value="Hospital"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Backup Employee&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlBackupEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity" Width="234">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Leave Category&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlLeaveCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="HREmployeeLeaveApplicationEntity" Width="234">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeLeaveApplicationEntity"
                        OnClick="btnSave_Click" runat="server" Text="Update" UniqueKey="HREmployeeLeaveApplicationControl_Submit_key" />
                </div>
            </div>
            <br />
        </div>
        <div class="listContentTitle">
            Leave Balance
        </div>
        <div>
            <div class="lv-c">
                <asp:ListView ID="lvLeaveStatus" runat="server" DataSourceID="odsLeaveStatus" OnItemDataBound="lvLeaveStatus_ItemDataBound">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                            <tr class="h">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="hi" style="width: 75px;">
                                    <b>Status</b>
                                </td>
                                <td class="hi" style="width: 75px;">
                                    <b>Leave Earned</b>
                                </td>
                                <td class="hi" style="width: 90px;">
                                    <b>Leave Enjoyed</b>
                                </td>
                                <td class="hi" style="width: 75px;">
                                    <b>Balance</b>
                                </td>
                                <td class="hi" style="width: 75px;">
                                    <b>Others</b>
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                            </tr>
                            <tr runat="server" id="itemPlaceholder">
                            </tr>
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr class="r">
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="i">
                                <b>Casual</b>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblCasualLeaveEarned" Text='<%# Eval("CasualLeaveEarned")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblCasualLeaveEnjoyed" Text='<%# Eval("CasualLeaveEnjoyed")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblCasualleaveBalance" runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="Label1" runat="server" />
                            </td>
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="rpb">
                                &nbsp;
                            </td>
                        </tr>
                        <tr class="r">
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="i">
                                <b>Medical</b>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblMedicalLeaveEarned" Text='<%# Eval("MedicalLeaveEarned")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblMedicalLeaveEnjoyed" Text='<%# Eval("MedicalLeaveEnjoyed")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblMedicalLeaveBalance" runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="Label2" runat="server" />
                            </td>
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="rpb">
                                &nbsp;
                            </td>
                        </tr>
                        <tr class="r">
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="i">
                                <b>Earn</b>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblEarnLeaveEarned" Text='<%# Eval("EarnLeaveEarned")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblEarnLeaveEnjoyed" Text='<%# Eval("EarnLeaveEnjoyed")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblEarnLeaveBalance" runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="Label3" runat="server" />
                            </td>
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="rpb">
                                &nbsp;
                            </td>
                        </tr>
                        <tr class="r">
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="i">
                                <b>LWP</b>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblLWPLeaveEarned" Text='<%# Eval("LWPLeaveEarned")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblLWPLeaveEnjoyed" Text='<%# Eval("LWPLeaveEnjoyed")%>' runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="lblLWPLeaveBalance" runat="server" />
                            </td>
                            <td class="i">
                                <asp:Label ID="Label4" runat="server" />
                            </td>
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="rpb">
                                &nbsp;
                            </td>
                        </tr>
                        <tr class="r">
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td colspan="3" class="i" align="center">
                                <b>Leave Status</b>
                            </td>
                            <td class="i">
                                <b>Total Enjoyed</b>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblTotalLeaveEnjoyed" runat="server" />
                            </td>
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="rpb">
                                &nbsp;
                            </td>
                        </tr>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <div class="edr">
                            No Records Found To Display
                        </div>
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
            <asp:ObjectDataSource ID="odsLeaveStatus" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeLeaveStatus_DetailedDataSource"
                SortParameterName="sortExpression" OnSelecting="odsLeaveStatus_Selecting">
                <SelectParameters>
                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                    <asp:Parameter Name="pageSize" Type="Int32" />
                    <asp:Parameter Name="sortExpression" Type="String" />
                    <asp:Parameter Name="filterExpression" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
        <br />
        <div class="listContentTitle">
            Task
        </div>
        <div>
            <div class="d-lv-c">
                <asp:ListView ID="lvOTIssue_Detailed" runat="server" DataSourceID="odsOTIssue_Detailed"
                    OnItemDataBound="lvOTIssue_Detailed_ItemDataBound">
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                            <tr class="h">
                                <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByCategory"
                                        CommandName="Sort" Text="Category" CommandArgument="MDIssueCategory.Name" />
                                </td>
                                <td class="hi" style="width: 150px;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByTitle"
                                        CommandName="Sort" Text="Title" CommandArgument="OTIssue.Title" />
                                </td>
                                <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPriority"
                                        CommandName="Sort" Text="Priority" CommandArgument="MDIssuePriority.Name" />
                                </td>
                                <td class="hi" style="width: 100px;">
                                    Actual
                                </td>
                                <td class="hi" style="width: 50px;">
                                    Supervisor Agreed
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
                                            <asp:DataPager ID="dpListView" runat="server" PageSize="5">
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
                            <td class="i">
                                <%# Eval("IssueCategoryName")%>
                            </td>
                            <td class="i">
                                <%# Eval("IssueStatusName")%>:&nbsp<asp:HyperLink ID="hypIssueReport" runat="server"
                                    CssClass="CommonButtonLink" Text='<%# Eval("Title")%>' CommandName="IssueReport"
                                    CommandArgument='<%#Eval("IssueID")%>'></asp:HyperLink>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblIssuePriorityNameLV" runat="server" Text='<%# Eval("IssuePriorityName")%>'></asp:Label>
                            </td>
                            <td class="i">
                                <b>Start</b>:&nbsp<%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                <br />
                                <b>End</b>:&nbsp<%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblSupervisorAgreedLV" runat="server" Text='<%# Eval("SupervisorAgreed") != null ? (((Boolean)Eval("SupervisorAgreed")) ? "Yes" : "No") : ""%>'></asp:Label>
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
                            <td class="i">
                                <%# Eval("IssueCategoryName")%>
                            </td>
                            <td class="i">
                                <%# Eval("IssueStatusName")%>:&nbsp<asp:HyperLink ID="hypIssueReport" runat="server"
                                    CssClass="CommonButtonLink" Text='<%# Eval("Title")%>' CommandName="IssueReport"
                                    CommandArgument='<%#Eval("IssueID")%>'></asp:HyperLink>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblIssuePriorityNameLV" runat="server" Text='<%# Eval("IssuePriorityName")%>'></asp:Label>
                            </td>
                            <td class="i">
                                <b>Start</b>:&nbsp<%# Eval("ExpectedStartDate") != null ? ((DateTime)Eval("ExpectedStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                <br />
                                <b>End</b>:&nbsp<%# Eval("ExpectedEndDate") != null ? ((DateTime)Eval("ExpectedEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblSupervisorAgreedLV" runat="server" Text='<%# Eval("SupervisorAgreed") != null ? (((Boolean)Eval("SupervisorAgreed")) ? "Yes" : "No") : ""%>'></asp:Label>
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
                        <div class="d-edr">
                            No Records Found To Display
                        </div>
                    </EmptyDataTemplate>
                </asp:ListView>
            </div>
            <asp:ObjectDataSource ID="odsOTIssue_Detailed" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.OTIssue_DetailedDataSource"
                SortParameterName="sortExpression" OnSelecting="odsOTIssue_Detailed_Selecting">
                <SelectParameters>
                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                    <asp:Parameter Name="pageSize" Type="Int32" />
                    <asp:Parameter Name="sortExpression" Type="String" />
                    <asp:Parameter Name="filterExpression" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
        <br />
        <div style="width: 100%;">
            <div style="margin-left: auto; margin-right: auto; width: 550px; border: 1px Solid Gray;
                padding: 10px; padding-left: 50px;">
                <div style="width: 550px; text-align: center;">
                    <h3>
                        Approval Process Panel</h3>
                </div>
                <br />
                <div style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Action
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:DropDownList ID="ddlAction" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                            Width="236">
                        </asp:DropDownList>
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trRemarks" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Remarks
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trRejectTo" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Back To
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:DropDownList ID="ddlRejectTo" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                            Width="236">
                        </asp:DropDownList>
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trForwardTo" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Forward To
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:DropDownList ID="ddlForwardTo" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                            Width="236">
                        </asp:DropDownList>
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trForwardRemarks" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Forward Remarks
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                            ID="txtForwardRemarks" runat="server" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trComment" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Comment
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                            ID="txtComment" runat="server" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trbtnApprove" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        &nbsp;
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                    </div>
                    <div style="width: 480px; float: left; padding-left: 10px;">
                        <kti:SecureButton ID="btnApprove" ValidationGroup="None" runat="server" Text="Approve"
                            UniqueKey="REQRequisitionApprovalProcessControl_Approve_key" OnClick="btnApprove_Click" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trbtnReject" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        &nbsp;
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                    </div>
                    <div style="width: 480px; float: left; padding-left: 10px;">
                        <kti:SecureButton ID="btnReject" ValidationGroup="None" runat="server" Text="Back"
                            UniqueKey="REQRequisitionApprovalProcessControl_Reject_key" OnClick="btnReject_Click" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trbtnForward" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        &nbsp;
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                    </div>
                    <div style="width: 480px; float: left; padding-left: 10px;">
                        <kti:SecureButton ID="btnForward" ValidationGroup="None" runat="server" Text="Forward"
                            UniqueKey="REQRequisitionApprovalProcessControl_Forward_key" OnClick="btnForward_Click" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trbtnSubmitComment" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        &nbsp;
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                    </div>
                    <div style="width: 480px; float: left; padding-left: 10px;">
                        <kti:SecureButton ID="btnSubmitComment" ValidationGroup="None" runat="server" Text="Submit Comment"
                            UniqueKey="REQRequisitionApprovalProcessControl_SubmitComment_key" OnClick="btnSubmitComment_Click" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div style="width: 550px;">
                    <div style="width: 510px; margin: 10px; padding: 10px;">
                        <div style="padding-bottom: 15px;">
                            <h3 style="color: #4B4B4B;">
                                All Remarks By Panel Members:</h3>
                        </div>
                        <div>
                            <asp:ListView ID="lvAPMemberFeedbackRemarks" runat="server" OnItemDataBound="lvAPMemberFeedbackRemarks_ItemDataBound">
                                <LayoutTemplate>
                                    <div runat="server" id="itemPlaceholder">
                                    </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <div style="padding-bottom: 20px;">
                                        <div style="padding-bottom: 3px;">
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="left">
                                                        <b>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.APPROVED ? ("<span style='color: green;'>" + Eval("APFeedbackName") + "</span>") : ("") %>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.REJECTED ? ("<span style='color: Red;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.FORWARDED ? ("<span style='color: Blue;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.FORWARD_RESPONSE_RECEIVED ? ("<span style='color: Blue;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                        </b><span style='color: gray;'><i>by <b>
                                                            <%# Eval("MemberFullName")%></b></i></span>
                                                    </td>
                                                    <td align="right">
                                                        on <b>
                                                            <%# Eval("RemarksDateTime") != null ? ((DateTime)Eval("RemarksDateTime")).ToString(UIConstants.SHORT_DATE_TIME_FORMAT) : ""%></b>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <div style="border-top: 1px solid gray; height: 1px; width: 100%;">
                                        </div>
                                        <div style="text-align: justify; letter-spacing: 0px; word-spacing: 0px; line-height: 18px;
                                            color: #4B4B4B; font-size: 12px; font-family: 'Verdana'; padding-top: 3px;">
                                            <%# Eval("Remarks")%>
                                        </div>
                                        <div id="forwardInfoDiv" runat="server">
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:ListView>
                        </div>
                    </div>
                </div>
                <br />
                <br />
            </div>
        </div>
        </div>
        <script type="text/javascript">
            function uploadError(sender, args) {
            }
            function uploadComplete(sender, args) {
                var btnClick = document.getElementById("btnClick");
                btnClick.click();
            }
        </script>
        <script type="text/javascript">
            $(function () {
                function manageActionOptions(selectedAction) {
                    if (selectedAction == 1) {
                        $('#trRemarks').show();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').hide();
                        $('#trbtnApprove').show();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 2) {
                        $('#trRemarks').show();
                        $('#trRejectTo').show();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').hide();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').show();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 3) {
                        $('#trRemarks').show();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').show();
                        $('#trForwardRemarks').show();
                        $('#trComment').hide();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').show();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 4) {
                        $('#trRemarks').hide();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').show();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').show();
                    }
                }

                function CurrentPageLoad() {

                    $('#ddlAction').change(function () {

                        var selectedAction = $('#ddlAction').val();
                        manageActionOptions(selectedAction);
                    });

                    manageActionOptions($('#ddlAction').val());
                }

                CurrentPageLoad();

                var prm = Sys.WebForms.PageRequestManager.getInstance();
                prm.add_endRequest(function () {
                    $(function () {
                        CurrentPageLoad();
                    });
                });
            });
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
