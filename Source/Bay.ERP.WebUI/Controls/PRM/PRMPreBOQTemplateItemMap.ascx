<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMPreBOQTemplateItemMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMPreBOQTemplateItemMapControl" %>
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
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="BDProjectDocumentTemplateMapEntity"
                        OnClick="btnSave_Click" runat="server" Text="Update" UniqueKey="BDProjectDocumentTemplateMapControl_Submit_key" />
                </div>
                <div>
                    <asp:Label ID="lblNote" runat="server" Text="Note: By Default All the Item are checked."></asp:Label>
                </div>
            </div>
            <div class="contentSeperator" style="display:none;">
            </div>
            <div style="float: left; width: 448px; display:none;">
                <div id="divUpdatePanel" runat="server" visible="true">
                    <div id="Div2" class="TableRow" style="text-align: left; padding-left: 10px; padding-bottom: 5px;"
                        runat="server">
                        <asp:Label ID="Label1" Class="contentSubTittle" EnableViewState="false" runat="server">Rate Information</asp:Label>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Unit&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlUnitID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                ValidationGroup="EnteredEntity" Width="236">
                            </asp:DropDownList>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Rate&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                        ID="txtRemarks" runat="server" ValidationGroup="PRMPreBOQEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
                </div>
            </div>
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
