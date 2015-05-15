<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Jan-2012, 11:52:45
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDAllMasterDataLink.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MDAllMasterDataLinkControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
    <div style="text-decoration:underline;"><b>Project</b></div>
        <asp:HyperLink ID="hypProjectStatus" runat="server" NavigateUrl="~/MD/MDProjectStatus.aspx" Target="_blank" CssClass="CommonButtonLink">Project Status</asp:HyperLink></br>
        <asp:HyperLink ID="hypDocumentCategory" runat="server" NavigateUrl="~/MD/MDProjectDocumentCategory.aspx" Target="_blank" CssClass="CommonButtonLink">Document Category</asp:HyperLink></br>
        <asp:HyperLink ID="hypDocument" runat="server" NavigateUrl="~/MD/MDProjectDocument.aspx" Target="_blank" CssClass="CommonButtonLink">Document</asp:HyperLink></br>
        <asp:HyperLink ID="hypDocumentStatus" runat="server" NavigateUrl="~/MD/MDProjectCollectedDocumentStatus.aspx" Target="_blank" CssClass="CommonButtonLink">Document Status</asp:HyperLink></br>
        <asp:HyperLink ID="hypDocumentTemplate" runat="server" NavigateUrl="~/BD/BDProjectDocumentTemplate.aspx" Target="_blank" CssClass="CommonButtonLink">Document Template</asp:HyperLink></br>
        <asp:HyperLink ID="hypProjectScheduleItem" runat="server" NavigateUrl="~/MD/MDProjectScheduleItem.aspx" Target="_blank" CssClass="CommonButtonLink">Project Schedule Item</asp:HyperLink></br>
         <br /><div style="text-decoration:underline;"><b>Item</b></div>
        <asp:HyperLink ID="hypBrand" runat="server" NavigateUrl="~/MD/MDBrand.aspx" Target="_blank" CssClass="CommonButtonLink">Brand</asp:HyperLink></br>
        <asp:HyperLink ID="hypItemCategory" runat="server" NavigateUrl="~/MD/MDItemCategory.aspx" Target="_blank" CssClass="CommonButtonLink">Item Category</asp:HyperLink></br>
        <asp:HyperLink ID="hypItem" runat="server" NavigateUrl="~/MD/MDItem.aspx" Target="_blank" CssClass="CommonButtonLink">Item</asp:HyperLink></br>
         <br /><div style="text-decoration:underline;"><b>Pre-BOQ</b></div>
        <asp:HyperLink ID="hypPreBOQStatus" runat="server" NavigateUrl="~/MD/MDPreBOQStatus.aspx" Target="_blank" CssClass="CommonButtonLink">PreBOQ Status</asp:HyperLink></br>
        <asp:HyperLink ID="hypPreBOQTemplate" runat="server" NavigateUrl="~/PRM/PRMPreBOQTemplate.aspx" Target="_blank" CssClass="CommonButtonLink">PreBOQ Template</asp:HyperLink></br>
         <br /><div style="text-decoration:underline;"><b>Issue</b></div>
        <asp:HyperLink ID="hypIssueCategory" runat="server" NavigateUrl="~/MD/MDIssueCategory.aspx" Target="_blank" CssClass="CommonButtonLink">Issue Category</asp:HyperLink></br>
        <asp:HyperLink ID="hypIssuePriority" runat="server" NavigateUrl="~/MD/MDIssuePriority.aspx" Target="_blank" CssClass="CommonButtonLink">Issue Priority</asp:HyperLink></br>
        <asp:HyperLink ID="hypIssueStatus" runat="server" NavigateUrl="~/MD/MDIssueStatus.aspx" Target="_blank" CssClass="CommonButtonLink">Issue Status</asp:HyperLink></br>
         <br /><div style="text-decoration:underline;"><b>Common</b></div>
        <asp:HyperLink ID="hypUnit" runat="server" NavigateUrl="~/MD/MDUnit.aspx" Target="_blank" CssClass="CommonButtonLink">Unit</asp:HyperLink></br>
        <asp:HyperLink ID="hypRegion" runat="server" NavigateUrl="~/MD/MDRegion.aspx" Target="_blank" CssClass="CommonButtonLink">Region</asp:HyperLink></br>
        <asp:HyperLink ID="hypCountry" runat="server" NavigateUrl="~/MD/MDCountry.aspx" Target="_blank" CssClass="CommonButtonLink">Country</asp:HyperLink></br>
        <asp:HyperLink ID="hypCity" runat="server" NavigateUrl="~/MD/MDCity.aspx" Target="_blank" CssClass="CommonButtonLink">City</asp:HyperLink></br>
         <br /><div style="text-decoration:underline;"><b>CM</b></div>
        <asp:HyperLink ID="hypCMConstructionToolCategory" runat="server" NavigateUrl="~/MD/MDConstructionToolCategory.aspx" Target="_blank" CssClass="CommonButtonLink">CM Tool Category</asp:HyperLink></br>
        <asp:HyperLink ID="hypToolWorkingItem" runat="server" NavigateUrl="~/MD/MDConstructionToolWorkingCondition.aspx" Target="_blank" CssClass="CommonButtonLink">CM Tool Working Condition</asp:HyperLink></br>
         <asp:HyperLink ID="hypConstructionTool" runat="server" NavigateUrl="~/CM/CMConstructionTool.aspx" Target="_blank" CssClass="CommonButtonLink">Construction Tool</asp:HyperLink></br>
        
    </ContentTemplate>
</asp:UpdatePanel>
