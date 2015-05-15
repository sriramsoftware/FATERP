<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 22-Jan-2013, 03:28:28
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACAccountTreeview.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACAccountTreeviewControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
               
                    <div style="float: left; width: 275px;">
                        <kti:BayAccountsTreeView ID="treeAccounts" runat="server" ToolTip="Please Select Accounts Treeview!">
                        </kti:BayAccountsTreeView>
                    </div>
                    <div style="float:left; width:200px;">
                    <asp:HyperLink ID="hypReport" runat="server" Text="Report" Font-Bold="true"></asp:HyperLink>
                    </div>
                    <div style="clear:both"></div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
