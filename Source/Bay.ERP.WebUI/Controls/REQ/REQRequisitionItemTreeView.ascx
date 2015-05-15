<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="REQRequisitionItemTreeView.ascx.cs"
    Inherits="Bay.ERP.Web.UI.REQRequisitionItemTreeViewControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
       <div>
       <kti:BayRequistionItemTreeView ID="treeRequisitionItem" runat="server" ShowCheckBoxesInAllNodes="false">
                    </kti:BayRequistionItemTreeView>
       </div>
    </ContentTemplate>
</asp:UpdatePanel>
