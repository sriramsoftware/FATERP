<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 16-Apr-2012, 04:09:50
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDItemGroupItemCategoryMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MDItemGroupItemCategoryMapControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Item Group</div>
                <div>
                    <div>
                        <asp:ListBox ID="lstBxItemGroup" runat="server" CssClass="ktiListBox" Height="200" 
                            onselectedindexchanged="lstBxItemGroup_SelectedIndexChanged" AutoPostBack="true"></asp:ListBox>
                    </div>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 600px;">
                <div class="contentSubTittle" style="padding-left: 158px;">
                    Item Group Item Category Map</div>
                <div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            &nbsp;
                        </div>
                        <div class="ktiListBox" style="width:300px;">
                            <asp:CheckBoxList ID="chbxItemCategroy" runat="server">
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
                            <kti:SecureButton ID="btnSubmit" ValidationGroup="MDItemGroupItemCategoryMapEntity"
                                OnClick="btnSave_Click" runat="server" Text="Update" UniqueKey="MDItemGroupItemCategoryMapControl_Submit_key" />
                        </div>
                    </div>
                </div>
            <br />
        </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
