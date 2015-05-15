<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Feb-2012, 05:48:58
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HRMemberRoles.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HRMemberRolesControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Member&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlMemberID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="HRMemberEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvMemberID" runat="server" ControlToValidate="ddlMemberID"
                        ErrorMessage="Please Select Member" ValidationGroup="HRMemberEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Roles&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlRoles" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="HRMemberEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvddlRoles" runat="server" ControlToValidate="ddlRoles"
                        ErrorMessage="Please Select Role" ValidationGroup="HRMemberEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="HRMemberEntity" OnClick="btnSave_Click"
                        runat="server" Text="Save" UniqueKey="HRMemberRolesControl_Submit_key" />
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
