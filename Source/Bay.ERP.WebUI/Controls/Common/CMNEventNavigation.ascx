<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 23-Mar-2013, 04:14:01
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNEventNavigation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMNEventNavigationControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <kti:SecureButton ID="btnArtGalleryEvent" ValidationGroup="CMNEventNavigationEntity" 
                            runat="server" Text="Art Gallery Event" OnClick="btnArtGalleryEvent_Click" UniqueKey="CMNEventNavigationControl_ArtGalleryEvent_key" />
            <kti:SecureButton ID="btnBayOfficialEvent" ValidationGroup="CMNEventNavigationEntity" 
                            runat="server" Text="Official Event" OnClick="btnBayOfficialEvent_Click" UniqueKey="CMNEventNavigationControl_OfficialEvent_key" />
            <kti:SecureButton ID="btnFrontDeskEvent" ValidationGroup="CMNEventNavigationEntity"
                runat="server" Text="Front Desk Event" OnClick="btnFrontDeskEvent_Click" UniqueKey="CMNEventNavigationControl_FrontDeskEvent_key" />
            <kti:SecureButton ID="btnWorkOrderEvent" ValidationGroup="CMNEventNavigationEntity"
                runat="server" Text="Work Order Event" OnClick="btnWorkOrderEvent_Click" UniqueKey="CMNEventNavigationControl_WorkOrderEvent_key" />
            <%--<asp:Button ID="btnBayOfficialEvent" runat="server" Text="Official Event" OnClick="btnBayOfficialEvent_Click"
                Font-Bold="true" CssClass="btnStyle" />--%>
            <%--<asp:Button ID="btnFrontDeskEvent" runat="server" Text="Front Desk Event" OnClick="btnFrontDeskEvent_Click"
                Font-Bold="true" CssClass="btnStyle" />
            <asp:Button ID="btnWorkOrderEvent" runat="server" Text="Work Order Event" OnClick="btnWorkOrderEvent_Click"
                Font-Bold="true" CssClass="btnStyle" />--%>
                
            <div style="clear: both;">
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
