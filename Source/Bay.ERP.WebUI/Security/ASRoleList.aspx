<%--
 Copyright and All Rights Reserved by
 TalentPlus Software Inc, USA; 
 Delphi Solutions Ltd., Bangladesh,
 TalentPlus Software FZ LLC, UAE; 
 TalentPlus Systems India Pvt Ltd., India. 

 Faisal Alam, faisal@talentPlusSoft.con
 ©2006 – 2010.

 Code Generate Time - 25-Feb-2010, 12:41:01
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ASRoleList.aspx.cs"
    Inherits="Bay.ERP.Web.UI.ASRoleListPage" Title="" ViewStateEncryptionMode="Auto" %>

<%@ Register Src="~/Controls/Security/ASRoleList.ascx" TagName="ASRoleListEntity" TagPrefix="uc" %>
<%@ Register Assembly="ASTreeView" Namespace="Geekees.Common.Controls" TagPrefix="ct" %>


<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">

    <link href="<%=ResolveUrl("~/Scripts/ASTreeview179/astreeview/astreeview.css")%>" type="text/css" rel="stylesheet" />
	<link href="<%=ResolveUrl("~/Scripts/ASTreeview179/contextmenu/contextmenu.css")%>" type="text/css" rel="stylesheet" />
	
	<script src="<%=ResolveUrl("~/Scripts/ASTreeview179/astreeview/astreeview_packed.js")%>" type="text/javascript"></script>
	<script src="<%=ResolveUrl("~/Scripts/ASTreeview179/contextmenu/contextmenu_packed.js")%>" type="text/javascript"></script>

</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>List of Role</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
       <uc:ASRoleListEntity ID="ucASRoleListEntity"  runat="server" />
      <%-- <ct:ASTreeView ID="astvMyTree" 

        runat="server"
                                   BasePath="~/Scripts/ASTreeview179/astreeview/"
                                    DataTableRootNodeValue="0"
                                    EnableRoot="false" 
                                    EnableNodeSelection="true" 
                                    EnableCheckbox="true" 
                                    EnableDragDrop="false" 
                                    EnableTreeLines="true"
                                    EnableNodeIcon="true"
                                    EnableCustomizedNodeIcon="false"
                                    AutoPostBack="false"
                                    EnableDebugMode="false"
                                    EnableContextMenu="true"
                                    EnableAjaxOnEditDelete="true"
                                    EditNodeProvider="~/ASTreeViewDemo/ASTreeViewRenameNodeHandler.aspx"
                                    DeleteNodeProvider="~/ASTreeViewDemo/ASTreeViewDeleteNodeProvider.aspx"/>--%>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
