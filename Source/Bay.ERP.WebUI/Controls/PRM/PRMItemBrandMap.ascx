<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 16-Apr-2012, 04:09:50
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMItemBrandMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMItemBrandMapControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="float: left; width: 400px;">
            <div class="contentSubTittle">
                    Item Tree</div>
                    <div style="float: left; width: 275px;">
                <kti:BayItemTreeView ID="treeItem" runat="server" ShowCheckBoxesInAllNodes="false"
                    OnSelectedNodeChanged="treeItem_SelectedNodeChanged">
                </kti:BayItemTreeView>
            </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 600px;">
                <div id="divUpdatePanel" runat="server" visible="false">
                    <div class="contentSubTittle" style="padding-left: 158px;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypBrandList" runat="server" Text="Brand List" NavigateUrl="~/MD/MDBrand.aspx" Target="_blank"></asp:HyperLink>
                        </div>
                    <div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                &nbsp;
                            </div>
                            <div class="ktiListBox">
                                <asp:CheckBoxList ID="chbxItemBrand" runat="server">
                                </asp:CheckBoxList>
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                        <br />
                        <div class="TableRow" style="text-align: center;">
                            <div class="TableFormLeble">
                                &nbsp;</div>
                            <div class="TableFormContent">
                                <kti:SecureButton ID="btnSubmit" OnClick="btnSave_Click" runat="server" Text="Update"  UniqueKey="PRMItemBrandMapControl_Submit_key"/>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
