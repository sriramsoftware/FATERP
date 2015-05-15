<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 06-Jan-2013, 04:16:20
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="INVTRFStoreIssueNoteMap.aspx.cs" Inherits="Bay.ERP.Web.UI.INVTRFStoreIssueNoteMapPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/INV/INVTRFStoreIssueNoteMap.ascx" TagName="INVTRFStoreIssueNoteMapEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div class="contentTitle">
        Create TRFStore Issue Note Map
    </div>
    <uc:INVTRFStoreIssueNoteMapEntity ID="ucINVTRFStoreIssueNoteMapEntity" runat="server" />
</asp:Content>
