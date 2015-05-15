<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectCategoryStatusReport.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectCategoryStatusReportControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
    <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
        <div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Item Category Tree</div>
                <div>
                    <div style="width: 275px;">
                        <kti:BayProjectCategoryStatusTreeView ID="treeProjectCategoryStatus" ShowCheckBoxesInAllNodes="false" runat="server"></kti:BayProjectCategoryStatusTreeView>
                    </div>
                    <br />
                    <div>
                        <kti:SecureButton ID="btnShow" ValidationGroup="BDProjectCategoryStatusEntity" OnClick="btnShow_Click"
                            runat="server" Text="Show" UniqueKey="BDProjectCategoryStatusReportControl_Submit_key" />
                    </div>
                    </div>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
