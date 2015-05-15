<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 01-Apr-2013, 02:41:21
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="CRMExistingBuyerBasicInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.CRMExistingBuyerBasicInfoPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/CRM/CRMBuyerBasicInfo.ascx" TagName="CRMExistingBuyerBasicInfoEntity" TagPrefix="uc" %>
<%@ Register Src="~/Controls/CRM/CRMOverview.ascx" TagName="CRMOverviewEntity" TagPrefix="uc" %>
<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Existing Buyer</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
      <uc:CRMOverviewEntity ID="ucCRMOverviewEntity" runat="server" />
                                                                        <div id="tab-contents">
                                                                            <br />
                                                                                 <uc:CRMExistingBuyerBasicInfoEntity ID="ucCRMExistingBuyerBasicInfoEntity" runat="server" />  
                                                                            <br />
                                                                        </div>
   
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>