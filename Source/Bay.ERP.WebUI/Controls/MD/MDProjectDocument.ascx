<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 07-Dec-2011, 11:00:45
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDProjectDocument.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MDProjectDocumentControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Project Document Tree</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayProjectDocumentTreeView ID="treeProjectDocument" runat="server" ToolTip="Please Select Project Document!" ProjectID="0">
                        </kti:BayProjectDocumentTreeView>
                    </div>
                    <div style="float: left; width: 100px; padding: 0px 10px 0px 14px;">
                        <asp:LinkButton ID="lnkBtnEditItemCategory" runat="server" Text="Edit" CssClass="CommonButtonLink" ToolTip="Please Click Here To Edit The Item!"
                            OnClick="lnkBtnEditItemCategory_Click"></asp:LinkButton>
                        |
                        <asp:LinkButton ID="lnkBtnremoveItemCategory" runat="server" Text="Delete" CssClass="CommonButtonLink" ToolTip="Please Click Here To Delete The Item!"
                            OnClientClick="return confirm('Are you sure to delete Document?')" OnClick="lnkBtnremoveItemCategory_Click"></asp:LinkButton>
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 600px;">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtName">
                            Enter Name</label>
                        <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server" ToolTip="Please Write The Document! e.g. Agreement Copy"
                            ValidationGroup="MDProjectDocumentEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ErrorMessage="Please Enter Name" ValidationGroup="MDProjectDocumentEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Req. Standard Time&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRequiredStandardTime" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="MDProjectDocumentEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvRequiredStandardTime" runat="server" ControlToValidate="txtRequiredStandardTime"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="MDProjectDocumentEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Reminder Time&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtReminderTime" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="MDProjectDocumentEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvReminderTime" runat="server" ControlToValidate="txtReminderTime"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="MDProjectDocumentEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="MDProjectDocumentEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="MDProjectDocumentEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="MDProjectDocumentEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="MDProjectDocumentControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="MDProjectDocumentControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="MDProjectDocumentControl_Clear_key" />
                    </div>
                </div>
                <br />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
