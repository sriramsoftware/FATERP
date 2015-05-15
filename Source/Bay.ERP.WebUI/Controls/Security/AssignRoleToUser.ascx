<%@ Control Language="C#" AutoEventWireup="true" CodeFile="AssignRoleToUser.ascx.cs"
    Inherits="Bay.ERP.Web.UI.Controls_Security_AssignRoleToUser" %>
<asp:UpdatePanel ID="UpdatePanel1" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        <asp:Label ID="lblMemberLoginName" runat="server" Text="User Login Name"></asp:Label>:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox id="txtUsername" runat="server" width="230" ClientIDMode="Static" CssClass="ktiTextBox">
                </asp:TextBox>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvUsername" runat="server" ControlToValidate="txtUsername"
                            ErrorMessage="Please Provide User Name" ValidationGroup="MemberUserEntity" EnableViewState="False"
                            Display="Dynamic">
                        </asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        <asp:Label ID="Label1" runat="server" Text="Role Name"></asp:Label>:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList id="ddlRolename" runat="server" width="236" ClientIDMode="Static" class="ktiSelect">
                </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvtxtUsername" runat="server" ControlToValidate="ddlRolename"
                            ErrorMessage="Please Select Role Name" ValidationGroup="MemberUserEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="MemberRoleEntity" OnClick="btnSave_Click"
                        runat="server" Text="Update" UniqueKey="MemberRoleControl_Submit_key" />
                    <kti:SecureButton ID="btnSendEmail" Visible="false" OnClick="btnSendEmail_Click"
                        runat="server" ValidationGroup="MemberRoleEntity" Text="Send Email" UniqueKey="MemberRoleControl_Submit_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
