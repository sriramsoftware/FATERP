<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMPreBOQToBOQMigration.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMPreBOQToBOQMigrationControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="text-align: center; color: Green; font-weight:bold; padding-top: 10px; padding-bottom: 20px; font-size: 13px;" runat="server">
                Important Notes: Once the BOQ will be migrated to BOQ, <br /><br />
                the Project Cost will be locked and there will be no option to modify.
            </div>
            <div class="TableRow" style="text-align: center; height: 100px;">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMPreBOQEntity" OnClick="btnSave_Click"
                        runat="server" Text="Migrate BOQ to Project Cost" UniqueKey="PRMPreBOQToBOQMigrationControl_Submit_key" OnClientClick="return confirm('Are you sure to Migrate BOQ to Project Cost?')" />
                    <br /><br />
                    <asp:Label ID="lblFormLock" runat="server" Text="Note: The Form has been Locked, no information can be changed." CssClass="msgLock"></asp:Label>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
