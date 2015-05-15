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




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="ASAssignRoleToUser.aspx.cs"
    Inherits="Bay.ERP.Web.UI.ASAssignRoleToUserPage" Title="ERP" %>

<%@ Register Src="~/Controls/Security/AssignRoleToUser.ascx" TagName="AssignRoleToUserEntity" TagPrefix="uc"%>


<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>Assign Role To User</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
       <uc:AssignRoleToUserEntity ID="ucAssignRoleToUserEntity" runat="server" />
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>