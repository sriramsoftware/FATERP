<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectIssue.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectIssueControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
       <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <kti:BayProjectIssueTreeView ID="treeProjectSchedule" runat="server" ShowCheckBoxesInDocumentNodes="true" ShowCheckBoxes="All">
                </kti:BayProjectIssueTreeView>
            </div>
            <div class="TableRow" style="width: 100;">
                <%--<kti:SecureButton ID="btnSubmit" runat="server" Text="Update" UniqueKey="BDProjectIssueControl_Submit_key" />--%>
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
