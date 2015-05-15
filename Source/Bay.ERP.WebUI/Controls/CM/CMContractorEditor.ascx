<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Jan-2012, 11:52:45
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMContractorEditor.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMContractorEditorControl" %>
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
                        ValidationGroup="CMContractorEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvMemberID" runat="server" ControlToValidate="ddlMemberID"
                        ErrorMessage="Please Select Member" ValidationGroup="CMContractorEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Name Of Work&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtNameOfWork">
                        Enter Name Of Work</label>
                    <asp:TextBox ID="txtNameOfWork" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CMContractorEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvNameOfWork" runat="server" ControlToValidate="txtNameOfWork"
                        ErrorMessage="Please Enter Name Of Work" ValidationGroup="CMContractorEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtDate">
                        Enter Date</label>
                    <asp:TextBox ID="txtDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="CMContractorEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvDate" runat="server" ControlToValidate="txtDate"
                        ErrorMessage="Please Enter Date" ValidationGroup="CMContractorEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revDate" runat="server" ControlToValidate="txtDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="CMContractorEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Name&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtName">
                        Enter Name</label>
                    <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CMContractorEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                        ErrorMessage="Please Enter Name" ValidationGroup="CMContractorEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Prepared By&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlPreparedBy" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="CMContractorEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvPreparedBy" runat="server" ControlToValidate="ddlPreparedBy"
                        ErrorMessage="Please Select Prepared By" ValidationGroup="CMContractorEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100; display:none;">
                <div class="TableFormLeble" style="text-align: left;">
                    Is Removed&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="CMContractorEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="CMContractorEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="CMContractorEditorControl_Submit_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="CMContractorEditorControl_Clear_key" />
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
