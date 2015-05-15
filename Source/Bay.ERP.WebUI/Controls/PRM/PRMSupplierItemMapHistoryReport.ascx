<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 16-Apr-2012, 04:09:50
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMSupplierItemMapHistoryReport.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMSupplierItemMapHistoryReportControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Item Name&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="PRMSupplierItemMapHistoryEntity" Width="236">
                    </asp:DropDownList>
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMSupplierItemMapHistoryEntity"
                        OnClick="btnSave_Click" runat="server" Text="Show" UniqueKey="PRMSupplierItemMapHistoryReportControl_Submit_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
