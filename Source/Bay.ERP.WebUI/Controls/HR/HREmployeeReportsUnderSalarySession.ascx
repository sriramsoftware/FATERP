<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeReportsUnderSalarySession.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeReportsUnderSalarySessionControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Salary Session&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlSalarySessionID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlSalarySessionID_SelectedIndexChanged"
                        ValidationGroup="HREmployeeReportsUnderSalarySessionEntity" Width="234">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:HyperLink ID="hypEmployeeTimeSheetReport" CssClass="CommonButtonLink" runat="server"
                        Text="Employee Time Sheet Report" CommandName="TimeSheetReport" />
                        <br />
                        <br />
                         <asp:HyperLink ID="hypSecurityGuardTimeSheetReport" CssClass="CommonButtonLink" runat="server"
                        Text="Security Guard Time Sheet Report" CommandName="TimeSheetReport" />
                </div>
            </div>
            <br />
            <br />
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:HyperLink ID="hypEmployeeSalaryStatementReport" CssClass="CommonButtonLink" runat="server"
                        Text="Employee Salary Statement Report" CommandName="SalaryStatementReport" />
                        <br />
                        <br />
                        <asp:HyperLink ID="hypSecurityGaurdSalaryStatementReport" CssClass="CommonButtonLink" runat="server"
                        Text="Security Guard Salary Statement Report" CommandName="SalaryStatementReport" />
                </div>
            </div>
            <br />
            <br />
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:HyperLink ID="hypEmployeeSalaryPaymentReport" runat="server" CssClass="CommonButtonLink"
                        Text="Employee Pay Advice Report" CommandName="SalaryPaymentReport"></asp:HyperLink>
                        <br />
                        <br />
                        <asp:HyperLink ID="hypSecurityGaurdSalaryPaymentReport" runat="server" CssClass="CommonButtonLink"
                        Text="Security Guard Pay Advice Report" CommandName="SalaryPaymentReport"></asp:HyperLink>
                </div>
            </div>
            <br />
            <br />
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:HyperLink ID="hypBankDisbursementLevel4Plus" runat="server" CssClass="CommonButtonLink"
                        Text="Bank Disbursement Report For Level 4+" CommandName="HREmployeeSalaryDisbursementBank"></asp:HyperLink>
                    <br />
                    <br />
                    <asp:HyperLink ID="hypBankDisbursementLevel1To3" runat="server" CssClass="CommonButtonLink"
                        Text="Bank Disbursement Report For Level 1-3" CommandName="HREmployeeSalaryDisbursementBank"></asp:HyperLink>
                </div>
            </div>
            <br />
            <br />

            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:HyperLink ID="hypLeaveApplications" runat="server" CssClass="CommonButtonLink"
                                        Text="Leave Applications Report" CommandName="LeaveApplicationsReport" ></asp:HyperLink>
                </div>
            </div>
        </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
