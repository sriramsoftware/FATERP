<%--
 Copyright and All Rights Reserved by
 TalentPlus Software Inc, USA; 
 Delphi Solutions Ltd., Bangladesh,
 TalentPlus Software FZ LLC, UAE; 
 TalentPlus Systems India Pvt Ltd., India. 

 Faisal Alam, faisal@talentPlusSoft.con
 ©2006 – 2010.

 Code Generate Time - 03-Mar-2010, 01:40:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ASCreateNewRole.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ASCreateNewRoleControl" %>
<div>
    <div class="TableRow" style="text-align: left;">
        <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
    </div>
    <div class="TableRow" style="width: 100;">
        <div class="TableFormLeble" style="text-align: right;">
            <asp:Label ID="lblRoleName" runat="server" Text="Role Name"></asp:Label>:
        </div>
        <div class="TableFormContent waterMarkContainer">
            <label class="watermarkLabel" for="txtRoleName">
                Enter Role</label>
            <asp:TextBox ID="txtRoleName" runat="server" CssClass="ktiTextBox" ClientIDMode="Static"
                ValidationGroup="ASSiteMapEntity" Width="230">
            </asp:TextBox>
            <span class="RequiredField">*</span>
        </div>
        <div class="TableFormValidatorContent">
            <asp:RequiredFieldValidator ID="rfvSiteMapName" runat="server" ControlToValidate="txtRoleName"
                ErrorMessage="Please Enter Role Name" ValidationGroup="ASSiteMapEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="TableRow" style="text-align: center;">
        <div class="TableFormLeble">
            &nbsp;</div>
        <div class="TableFormContent">
            <kti:SecureButton ID="btnSubmit" ValidationGroup="ASSiteMapEntity" OnClick="btnSave_Click"
                runat="server" Text="Add" UniqueKey="ASCreateNewRoleControl_Submit_key" />
        </div>
    </div>
</div>
