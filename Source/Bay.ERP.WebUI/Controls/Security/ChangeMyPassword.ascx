<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Feb-2012, 05:48:58
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ChangeMyPassword.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ChangeMyPasswordControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    User&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlMemberID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="HRMemberEntity" Width="234">
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
                <div class="TableFormLeble" style="text-align: right;">
                    Old Password&nbsp;:
                </div>
                <div class="TableFormContentCAA waterMarkContainer">
                    <asp:TextBox ID="txtOldPassword" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="HRMemberEntity" Width="230" TextMode="Password" MaxLength="35" />
                    <span class="RequiredField">*</span>
                    <asp:Button ID="btnGetPassword" runat="server" Text="Reset Password" OnClick="btnGetPassword_Click" />
                    <asp:Label ID="lblPassword" runat="server"></asp:Label>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvOldPassword" runat="server" ControlToValidate="txtOldPassword"
                        ErrorMessage="Please Enter Old Password" ValidationGroup="HRMemberEntity" EnableViewState="true"
                        Display="Dynamic"></asp:RequiredFieldValidator>                    
                    <asp:RegularExpressionValidator ID="revOldPassword" runat="server" ErrorMessage="Password Length is 6 to 35"
                        ControlToValidate="txtOldPassword" ValidationExpression=".{6,35}$"
                        ValidationGroup="HRMemberEntity" EnableViewState="true" Display="Dynamic" />
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Password&nbsp;:
                </div>
                <div class="TableFormContentCAA waterMarkContainer">
                    <asp:TextBox ID="txtPassword" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="HRMemberEntity" Width="230" TextMode="Password" MaxLength="25" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvPassword" runat="server" ControlToValidate="txtPassword"
                        ErrorMessage="Please Enter Password" ValidationGroup="HRMemberEntity" EnableViewState="true"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revPassword" runat="server" ErrorMessage="Password Length is 6 to 15"
                        ControlToValidate="txtPassword" ValidationExpression="[a-zA-Z0-9~!@#$%^&*()_<>?]{6,15}" 
                        ValidationGroup="HRMemberEntity" EnableViewState="true" Display="Dynamic" />
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
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
                        EnableViewState="true" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:CompareValidator ID="cvPassword" runat="server" ClientIDMode="Static" ControlToValidate="txtReTypePassword"
                        ControlToCompare="txtPassword" ErrorMessage="The Passwords You Entered Do Not Match"
                        ValidationGroup="HRMemberEntity" EnableViewState="true" Display="Dynamic"></asp:CompareValidator>
                    <asp:RegularExpressionValidator ID="revReTypePassword" runat="server" ErrorMessage="Password Length is 6 to 15"
                        ControlToValidate="txtReTypePassword" ValidationExpression="[a-zA-Z0-9~!@#$%^&*()_<>?]{6,15}"
                        ValidationGroup="HRMemberEntity" EnableViewState="true" Display="Dynamic" />
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:Button ID="btnSubmit" ValidationGroup="HRMemberEntity" OnClick="btnSave_Click"
                        runat="server" Text="Change" UniqueKey="HRMemberControl_Submit_key" />                    
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="HRMemberControl_Clear_key" />
                </div>
            </div>
            <br />
        </div>        
    </ContentTemplate>
</asp:UpdatePanel>
