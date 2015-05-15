<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Feb-2012, 05:48:58
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HRMemberLogin.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HRMemberLoginControl" %>
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
                        ErrorMessage="Please Select Member" ValidationGroup="HRMemberCounterMapEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    User ID&nbsp;:
                </div>
                <div class="TableFormContentCAA waterMarkContainer">
                    <asp:TextBox ID="txtUserID" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="HRMemberEntity" Width="230" MaxLength="50" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvUserID" runat="server" ControlToValidate="txtUserID"
                        ErrorMessage="Please Enter User ID" ValidationGroup="HRMemberEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Email Address&nbsp;:
                </div>
                <div class="TableFormContentCAA waterMarkContainer">
                    <asp:TextBox ID="txtEmailAddress" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="HRMemberEntity" Width="230" MaxLength="50" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvEmailAddress" runat="server" ControlToValidate="txtEmailAddress"
                        ErrorMessage="Please Enter Email Address" ValidationGroup="HRMemberEntity" EnableViewState="False"
                        Display="Dynamic" ClientIDMode="Static"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revEmailAddress" runat="server" ValidationExpression="\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*"
                        ControlToValidate="txtEmailAddress" ErrorMessage="Invalid Email Format" ValidationGroup="HRMemberEntity"
                        EnableViewState="False" Display="Dynamic" ClientIDMode="Static"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div id="divPassword" runat="server" class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Password&nbsp;:
                </div>
                <div class="TableFormContentCAA waterMarkContainer">
                    <asp:TextBox ID="txtPassword" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="HRMemberEntity" Width="230" TextMode="Password" MaxLength="25" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="Please Enter Password" ValidationGroup="HRMemberEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPassword" runat="server" ErrorMessage="Password Length is 6 to 15"
                        ControlToValidate="txtPassword" ValidationExpression="[a-zA-Z0-9~!@#$%^&*()_<>?]{6,15}"
                        ValidationGroup="HRMemberEntity" EnableViewState="False" Display="Dynamic" />
                </div>
            </div>
            <div id="divReTypePassword" runat="server" class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Confirm Password&nbsp;:
                </div>
                <div class="TableFormContentCAA waterMarkContainer">
                    <asp:TextBox ID="txtReTypePassword" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="HRMemberEntity" Width="230" TextMode="Password" MaxLength="15" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvReTypePassword" runat="server" ControlToValidate="txtReTypePassword"
                        ErrorMessage="Please Enter Confirm Password" ValidationGroup="HRMemberEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvPassword" runat="server" ClientIDMode="Static" ControlToValidate="txtReTypePassword"
                        ControlToCompare="txtPassword" ErrorMessage="The Passwords You Entered Do Not Match"
                        ValidationGroup="HRMemberEntity" EnableViewState="False" Display="Dynamic"></asp:CompareValidator>
                    <asp:RegularExpressionValidator ID="revReTypePassword" runat="server" ErrorMessage="Password Length is 6 to 15"
                        ControlToValidate="txtReTypePassword" ValidationExpression="[a-zA-Z0-9~!@#$%^&*()_<>?]{6,15}"
                        ValidationGroup="HRMemberEntity" EnableViewState="False" Display="Dynamic" />
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Lock&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:CheckBox ID="chkIsUserLocked" runat="server" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="HRMemberEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="HRMemberLoginControl_Submit_key" />                    
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="HRMemberLoginControl_Clear_key" />
                </div>
            </div>
            <br />
        </div>        
    </ContentTemplate>
</asp:UpdatePanel>
