<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 09-Dec-2012, 08:03:28
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACCPrePayableStatementFromBill.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACCPrePayableStatementFromBillControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Approved Bill No&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlBillID" CssClass="ktiSelect" ClientIDMode="Static" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlBillID_SelectedIndexChanged"
                        ValidationGroup="CMBillEntity" Width="236">
                    </asp:DropDownList>
                    <span>
                        <asp:HyperLink ID="hypBillDetail" runat="server" Target="_blank" Text="See Bill Detail"></asp:HyperLink></span>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" OnClick="btnSave_Click"
                        runat="server" Text="Add Bill To This Payable" UniqueKey="ACCPrePayableStatementFromBillControl_Submit_key" />
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Advance Pay. WO&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlWorkOrderID" CssClass="ktiSelect" ClientIDMode="Static" runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlWorkOrderID_SelectedIndexChanged"
                        ValidationGroup="none" Width="236">
                    </asp:DropDownList>
                    <span>
                        <asp:HyperLink ID="hypWorkOrderDetail" runat="server" Target="_blank" Text="See WO Detail"></asp:HyperLink></span>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnWOSubmit" OnClick="btnWOSubmit_Click"
                        runat="server" Text="Add WO To This Payable" UniqueKey="ACCPrePayableStatementFromBillControl_WOSubmit_key" />
                </div>
            </div>
            
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
