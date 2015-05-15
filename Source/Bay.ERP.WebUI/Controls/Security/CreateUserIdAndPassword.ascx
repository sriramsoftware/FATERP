<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CreateUserIdAndPassword.ascx.cs"
    Inherits="Bay.ERP.Web.UI.SecurityCreateUserIdAndPasswordControl" %>
<div>
    <div class="TableRow" style="text-align: left;">
        <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
    </div>
    <%----------New -------------------%>
    <div class="TableRow" style="width: 100;">
        <div class="TableFormLeble" style="text-align: right;">
            <asp:Label ID="lblMemberLoginName" runat="server" Text="Log In Name"></asp:Label>:
        </div>
        <div class="TableFormContent">
            <asp:TextBox ID="txtUsername" runat="server" Width="300px">
            </asp:TextBox>
            <span class="RequiredField">*</span>
        </div>
        <div class="TableFormValidatorContent">
            <asp:RequiredFieldValidator ID="rfvtxtUsername" runat="server" ControlToValidate="txtUsername"
                ErrorMessage="Please Provide User Name" ValidationGroup="MemberUserEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="TableRow" style="width: 100;" id="divRoles" runat="server">
        <div class="TableFormLeble" style="text-align: right;">
            <asp:Label ID="lblRole" runat="server" Text="Role Name"></asp:Label>:
        </div>
        <div class="TableFormContent">
            <asp:ListBox ID="lstRoleInfo" runat="server" Height="20px" Width="300px"></asp:ListBox>
            <span class="RequiredField"></span>
        </div>
        <div class="TableFormValidatorContent">
        </div>
    </div>
    <div id="divOldPassword" runat="server" class="TableRow" style="width: 100;">
        <div class="TableFormLeble" style="text-align: right;">
            <asp:Label ID="Label3" runat="server" Text="Old Password"></asp:Label>:
        </div>
        <div class="TableFormContent">
            <asp:TextBox ID="txtOldpassword" runat="server" Width="300px" TextMode="Password"
                ValidationGroup="MemberUserEntity">
            </asp:TextBox>
            <span class="RequiredField">*</span>
        </div>
        <div class="TableFormValidatorContent">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtPassword"
                ErrorMessage="Please Provide Password" ValidationGroup="MemberUserEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
            <asp:CompareValidator ID="CompareValidator1" runat="server" EnableViewState="False"
                ControlToCompare="txtCPassword" ControlToValidate="txtPassword" Display="Dynamic"
                ErrorMessage="Both password does not match" SetFocusOnError="True" ValidationGroup="MemberUserEntity"></asp:CompareValidator>
        </div>
    </div>
    <div class="TableRow" style="width: 100;">
        <div class="TableFormLeble" style="text-align: right;">
            <asp:Label ID="Label1" runat="server" Text="Password"></asp:Label>:
        </div>
        <div class="TableFormContent">
            <asp:TextBox ID="txtPassword" runat="server" Width="300px" TextMode="Password" ValidationGroup="MemberUserEntity">
            </asp:TextBox>
            <span class="RequiredField">*</span>
        </div>
        <div class="TableFormValidatorContent">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPassword"
                ErrorMessage="Please Provide Password" ValidationGroup="MemberUserEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="TableRow" style="width: 100;">
        <div class="TableFormLeble" style="text-align: right;">
            <asp:Label ID="Label2" runat="server" Text="Confirm Password"></asp:Label>:
        </div>
        <div class="TableFormContent">
            <asp:TextBox ID="txtCPassword" runat="server" Width="300px" TextMode="Password" ValidationGroup="MemberUserEntity">
            </asp:TextBox>
            <span class="RequiredField">*</span>
        </div>
        <div class="TableFormValidatorContent">
            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtCPassword"
                ErrorMessage="Please Retype Password" ValidationGroup="MemberUserEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
        </div>
    </div>
    <div class="TableRow" style="width: 100;">
        <div class="TableFormLeble" style="text-align: right;">
            <asp:Label ID="lblAddedBy" runat="server" Text="Added By"></asp:Label>:
        </div>
        <div class="TableFormContent">
            <asp:TextBox ID="txtAddedByMemberName" runat="server" CssClass="DisableCommonTextBox"
                ValidationGroup="MemberEntity" Width="300px" Enabled="false"></asp:TextBox>
        </div>
    </div>
    <div class="TableRow" style="width: 100;">
        <div class="TableFormLeble" style="text-align: right;">
            <asp:Label ID="lblCreateDate" runat="server" Text="Create Date"></asp:Label>:
        </div>
        <div class="TableFormContent">
            <asp:TextBox ID="txtCreateDate" runat="server" CssClass="DisableCommonTextBox" ValidationGroup="MemberEntity"
                Width="300px" Enabled="false"></asp:TextBox>
        </div>
    </div>
    <div class="TableRow" style="text-align: center;">
        <div class="TableFormLeble">
            &nbsp;</div>
        <div class="TableFormContent">
            <kti:SecureButton ID="btnSubmit" ValidationGroup="MemberUserEntity" OnClick="btnSave_Click"
                runat="server" Text="Add" UniqueKey="MemberUserEntityControl_Submit_key" />
        </div>
    </div>
    <%---------------------------------%>
</div>
<br />
<br />
<br />
<div>
    <ajaxToolkit:CollapsiblePanelExtender ID="CollapsiblePanelExtender2" runat="server"
        TargetControlID="Panel4" ExpandControlID="Image2" CollapseControlID="Image2"
        Collapsed="true" ImageControlID="Image2" CollapsedImage="~/Images/expand-plus.gif"
        ExpandedImage="~/Images/collapse-minus.gif" SuppressPostBack="false">
    </ajaxToolkit:CollapsiblePanelExtender>
    <asp:Panel ID="Panel3" runat="server">
        <div id="div2" runat="server" style="clear: both; height: 5px; font-weight: bold;
            vertical-align: middle; padding-top: 5px; padding-left: 30px;">
            <div style="float: left; width: 2%; text-align: left;">
                <asp:Image ID="Image2" ImageUrl="~/Images/expand-plus.gif" runat="server" />
            </div>
            <div>
                <asp:Label ID="Label19" runat="server" Text="Email User Id & Password"></asp:Label>
            </div>
        </div>
    </asp:Panel>
    <asp:Panel ID="Panel4" runat="server" Width="100%">
        <br />
        <br />
        <div class="TableRow">
            <div class="TableFormLeble" style="text-align: right;">
                <asp:Label ID="Label6" runat="server" Text="Select Email Address"></asp:Label>:
            </div>
            <div class="TableFormContent">
                <asp:ListBox ID="rlbEmail" runat="server" CheckBoxes="true" Width="300px" EmptyMessage="No email address found.">
                </asp:ListBox>
            </div>
        </div>
        <div class="TableRow" style="text-align: center;">
            <div class="TableFormLeble">
                &nbsp;</div>
            <div class="TableFormContent">
                <kti:SecureButton ID="btnSendEmail" OnClick="btnSendEmail_Click" runat="server" Text="Send Email"  UniqueKey="CreateUserIdAndPassword_SendEmail_key"/>
            </div>
        </div>
    </asp:Panel>
</div>
