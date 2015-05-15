<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 10-May-2012, 05:58:01
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMBOQTemplateItemMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMBOQTemplateItemMapControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div style="float: left; width: 325px;">
                <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <kti:BayItemTreeView ID="treeItem" runat="server" ShowCheckBoxesInAllNodes="true"
                        ShowCheckedAtLastNode="false" OnSelectedNodeChanged="treeItem_SelectedNodeChanged">
                    </kti:BayItemTreeView>
                </div>
                <div class="TableRow" style="width: 100;">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMBOQTemplateItemMapEntity"
                        OnClick="btnSave_Click" runat="server" Text="Update" UniqueKey="PRMBOQTemplateItemMapControl_Submit_key" />
                </div>
                <div>
                    <asp:Label ID="lblNote" runat="server" Text="Note: By Default All the Item are checked."></asp:Label>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
