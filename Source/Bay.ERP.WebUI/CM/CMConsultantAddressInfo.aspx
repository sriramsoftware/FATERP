<%--
 Copyright and All Rights Reserved by
 B2B Solution

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 08-Jan-2012, 04:47:08
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Consultant.master" AutoEventWireup="true" CodeFile="CMConsultantAddressInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.CMConsultantAddressInfoPage" Title="ERP" %>

<%@ Register Src="~/Controls/CM/CMConsultantAddressInfo.ascx" TagName="CMConsultantAddressInfoEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Create Artist Address Info</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:CMConsultantAddressInfoEntity ID="ucCMConsultantAddressInfoEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>