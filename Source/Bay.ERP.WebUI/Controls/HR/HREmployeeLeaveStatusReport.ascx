<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeLeaveStatusReport.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeLeaveStatusReportControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
     <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
            <div>
                <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Fiscal Year&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlACFiscalYearID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlACFiscalYearID_SelectedIndexChanged" ValidationGroup="HREmployeeLeaveStatusReportEntity" Width="234">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:HyperLink ID="hypLeaveStatusReport" CssClass="CommonButtonLink" runat="server" Text="Leave Status Report" CommandName="LeaveStatusReport" />
                </div>
            </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
