<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTProjectIssueList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.OTProjectIssueListControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="contentSubTittle">
                Project Issue List</div>
            <div>
                <div style="float: left; width: 275px;">
                    <kti:BayProjectScheduleItemTreeView ID="treeProjectSchedule" runat="server" OnSelectedNodeChanged="treeProjectSchedule_SelectedNodeChanged">
                    </kti:BayProjectScheduleItemTreeView>
                </div>
                <div class="TableRow" style="width: 100;">
                    <kti:SecureButton ID="btnUpdate" 
                        OnClick="btnUpdate_Click" runat="server" Text="Update" UniqueKey="OTProjectIssueListControl_Submit_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
