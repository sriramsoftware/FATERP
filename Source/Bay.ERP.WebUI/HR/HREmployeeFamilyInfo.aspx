<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Employee.master" AutoEventWireup="true" CodeFile="HREmployeeFamilyInfo.aspx.cs" Inherits="Bay.ERP.Web.UI.HREmployeeFamilyInfoPage" Title="Bay's ERP" %>

<%@ Register Src="~/Controls/HR/HREmployeeFamilyInfo.ascx" TagName="HREmployeeFamilyInfoEntity" TagPrefix="uc" %>
<%@ Register Src="~/Controls/HR/HREmployeeBasicOverview.ascx" TagName="HREmployeeBasicOverviewEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1> Create Employee Family Info</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
       
         <uc:HREmployeeBasicOverviewEntity ID="ucHREmployeeBasicOverviewEntity" runat="server" />
                                                                        <div id="tab-contents">
                                                                         <uc:HREmployeeFamilyInfoEntity ID="ucHREmployeeFamilyInfoEntity" runat="server" />
                                                                          <br />
                                                                        </div>        
    </div>
   
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>