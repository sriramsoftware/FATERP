<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectDocumentTemplateMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectDocumentTemplateMapControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <kti:BayProjectDocumentTreeView ID="treeDocument" runat="server" ShowCheckBoxesInDocumentNodes="true" ProjectID="0">
                </kti:BayProjectDocumentTreeView>
            </div>
            <div class="TableRow" style="width: 100;">
                <kti:SecureButton ID="btnSubmit" ValidationGroup="BDProjectDocumentTemplateMapEntity"
                    OnClick="btnSave_Click" runat="server" Text="Update" UniqueKey="BDProjectDocumentTemplateMapControl_Submit_key" />
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
