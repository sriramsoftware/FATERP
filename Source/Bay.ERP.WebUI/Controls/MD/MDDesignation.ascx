<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 22-May-2012, 04:20:17
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDDesignation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MDDesignationControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    HR Designation</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayHRDesignationTreeView ID="treeDesignation" runat="server">
                        </kti:BayHRDesignationTreeView>
                    </div>
                    <div style="float: left; width: 100px; padding: 0px 10px 0px 14px;">
                        <asp:LinkButton ID="lnkBtnEditDesignation" runat="server" Text="Edit" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Edit The Designation!" OnClick="lnkBtnEditDesignation_Click"></asp:LinkButton>
                        |
                        <asp:LinkButton ID="lnkBtnRemoveDesignation" runat="server" Text="Delete" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Delete The Designation!" OnClientClick="return confirm('Are you sure to delete Designation?')"
                            OnClick="lnkBtnRemoveDesignation_Click"></asp:LinkButton>
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
                    <div class="TableFormLeble" style="text-align: right;">
                        Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtName">
                            Enter Name</label>
                        <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="MDDesignationEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ErrorMessage="Please Enter Name" ValidationGroup="MDDesignationEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtDescription" runat="server" ValidationGroup="MDDesignationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="MDDesignationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="MDDesignationEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="MDDesignationControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="MDDesignationControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="MDDesignationControl_Clear_key" />
                    </div>
                </div>
                <br />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
