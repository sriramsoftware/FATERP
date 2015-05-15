<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 12-Jan-2014, 03:42:17
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="HREmployeePhoneBillAdjustment.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeePhoneBillAdjustmentPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeePhoneBillAdjustment.ascx" TagName="HREmployeePhoneBillAdjustmentEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content1" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>
        Employee Phone Bill Adjustment
        </h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
    <uc:HREmployeePhoneBillAdjustmentEntity ID="ucHREmployeePhoneBillAdjustmentEntity" runat="server" />    
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>