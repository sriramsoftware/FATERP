<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 08-Jan-2012, 04:47:08
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMConsultantEditor.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMConsultantEditorControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    First Name&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtFirstName">
                        Enter First Name</label>
                    <asp:TextBox ID="txtFirstName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CMContractorEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName"
                        ErrorMessage="Please Enter First Name" ValidationGroup="CMContractorEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Middle Name&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtMiddleName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CMContractorEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Last Name&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtLastName">
                        Enter Last Name</label>
                    <asp:TextBox ID="txtLastName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CMContractorEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName"
                        ErrorMessage="Please Enter Last Name" ValidationGroup="HRMemberEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
             <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtName">
                            Enter Name</label>
                        <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ErrorMessage="Please Enter Name" ValidationGroup="CMConsultantEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Image Url&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtImageUrl" runat="server" ValidationGroup="CMConsultantEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Current Position&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtCurrentPosition" runat="server" ValidationGroup="CMConsultantEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Institute Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtInstitueName" runat="server" ValidationGroup="CMConsultantEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Email Address1&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmailAddress1" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmailAddress1" runat="server" ControlToValidate="txtEmailAddress1" Display="Dynamic"
                            EnableViewState="True" ValidationGroup="CMConsultantEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Email Address2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmailAddress2" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmailAddress2" runat="server" ControlToValidate="txtEmailAddress2" Display="Dynamic"
                            EnableViewState="True" ValidationGroup="CMConsultantEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Contact No1&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtContactNo1" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Contact No2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtContactNo2" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Phone&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPhone" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone" Display="Dynamic"
                            EnableViewState="True" ValidationGroup="CMConsultantEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRemarks" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="CMConsultantEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>  
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="CMConsultantEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="CMConsultantEditorControl_Submit_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="CMConsultantEditorControl_Clear_key" />
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
