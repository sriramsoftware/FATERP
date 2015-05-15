<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 09-Jan-2012, 01:23:18
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Consultant.master" AutoEventWireup="true" CodeFile="CMConsultantEnlistedWorkArea.aspx.cs" Inherits="Bay.ERP.Web.UI.CMConsultantEnlistedWorkAreaPage" Title="ERP" %>

<%@ Register Src="~/Controls/CM/CMConsultantEnlistedWorkArea.ascx" TagName="CMConsultantEnlistedWorkAreaEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Consultant Enlisted Work Area</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMConsultantEnlistedWorkAreaEntity ID="ucCMConsultantEnlistedWorkAreaEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>