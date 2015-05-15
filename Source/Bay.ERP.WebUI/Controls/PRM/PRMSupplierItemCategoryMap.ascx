<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 03-May-2012, 11:02:33
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMSupplierItemCategoryMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMSupplierItemCategoryMapControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle" style="padding-left:100px;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypBrandList" runat="server" Text="Item Category Map List" NavigateUrl="~/MD/MDSupplierItemCategory.aspx"
                        Target="_blank"></asp:HyperLink>
                </div>
                <div style="float: left; width: 275px; padding-left:100px;">
                    <div class="ktiListBox">
                        <asp:CheckBoxList ID="chbxItemCategory" runat="server">
                        </asp:CheckBoxList>
                    </div>
                    <br />
                    <kti:SecureButton ID="btnSubmit" OnClick="btnSave_Click" runat="server" Text="Update" UniqueKey="PRMSupplierItemCategoryMapControl_Clear_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
