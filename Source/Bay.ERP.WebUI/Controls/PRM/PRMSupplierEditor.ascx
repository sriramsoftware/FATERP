<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Feb-2012, 05:41:59
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMSupplierEditor.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMSupplierEditorControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Vendor Code&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtSupplierCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMSupplierEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Vendor Name&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSupplierName">
                        Enter Vendor Name</label>
                    <asp:TextBox ID="txtSupplierName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMSupplierEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvSupplierName" runat="server" ControlToValidate="txtSupplierName"
                        ErrorMessage="Please Enter Vendor Name" ValidationGroup="PRMSupplierEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Relationship&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtRelationship" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMSupplierEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Phone&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtPhone" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMSupplierEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone"
                        Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Mobile No&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtMobileNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMSupplierEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Fax&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtFax" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMSupplierEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revFax" runat="server" ControlToValidate="txtFax"
                        Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Email&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMSupplierEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                        Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Web Link&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtWebLink" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="PRMSupplierEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revWebLink" runat="server" ControlToValidate="txtWebLink"
                        Display="Dynamic" EnableViewState="True" ValidationGroup="PRMSupplierEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
             <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Create Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCreateDate">
                            Enter Create Date</label>
                        <asp:TextBox ID="txtCreateDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="PRMSupplierEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            ErrorMessage="Please Enter Create Date" ValidationGroup="PRMSupplierEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCreateDate" runat="server" ControlToValidate="txtCreateDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="PRMSupplierEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Vendor Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSupplierTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="PRMSupplierEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSupplierTypeID" runat="server" ControlToValidate="ddlSupplierTypeID"
                            ErrorMessage="Please Select Vendor Type" ValidationGroup="PRMSupplierEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Vendor Status&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlSupplierStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlSupplierStatusID_SelectedIndexChanged"
                        runat="server" ValidationGroup="PRMSupplierEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvSupplierStatusID" runat="server" ControlToValidate="ddlSupplierStatusID"
                        ErrorMessage="Please Select Vendor Status" ValidationGroup="PRMSupplierEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        <asp:Label ID="lblReason" runat="server" Text="Reason :"></asp:Label>
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                            ClientIDMode="Static" ID="txtReason" runat="server" ValidationGroup="PRMSupplierEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="PRMSupplierEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            <div class="TableRow" style="width: 100; display: none;">
                <div class="TableFormLeble" style="text-align: left;">
                    Is Removed&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="PRMSupplierEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMSupplierEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="PRMSupplierEditorControl_Submit_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="PRMSupplierEditorControl_Clear_key" />
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
