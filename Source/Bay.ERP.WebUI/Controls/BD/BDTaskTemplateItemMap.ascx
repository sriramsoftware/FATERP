<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 26-May-2013, 02:32:38
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDTaskTemplateItemMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDTaskTemplateItemMapControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <kti:BayTaskTreeView ID="treeDocument" runat="server" ShowCheckBoxesInDocumentNodes="true"
                    ProjectID="0">
                </kti:BayTaskTreeView>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="BDTaskTemplateItemMapEntity" OnClick="btnSave_Click"
                        runat="server" Text="Update" UniqueKey="BDTaskTemplateItemMapControl_Submit_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
