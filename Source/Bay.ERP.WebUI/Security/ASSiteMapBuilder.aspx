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




<%@ Page Language="C#" MasterPageFile="~/Template/Blank.master" AutoEventWireup="true" CodeFile="ASSiteMapBuilder.aspx.cs"
    Inherits="Bay.ERP.Web.UI.ASSiteMapBuilderPage" Title="" %>

<%@ Register Src="~/Controls/Security/ASSiteMapBuilder.ascx" TagName="ASSiteMapBuilderEntity" TagPrefix="uc" %>

<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">        
     <div style="width: auto;">
        <uc:ASSiteMapBuilderEntity ID="ucASSiteMapBuilderEntity" runat="server" />        
    </div>
</asp:Content>
