<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDItemCategory.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MDItemCategoryControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Item Category Tree</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayItemCategoryTreeView ID="treeItemCategory" runat="server"></kti:BayItemCategoryTreeView>
                    </div>
                    <div style="float: left; width: 100px; padding:0px 10px 0px 14px;">
                     <asp:LinkButton ID="lnkBtnAdvanceSearch" runat="server" Text="Advance Search" CssClass="CommonButtonLink" ToolTip="Please Click Here To Advance Search The Item!" UniqueKey="MDItemCategory_AdvanceSearch_key"
                        OnClick="lnkBtnAdvanceSearch_Click" Visible="false"/>
                        &nbsp;
                        <asp:LinkButton ID="lnkBtnEditItemCategory" runat="server" Text="Edit" CssClass="CommonButtonLink" ToolTip="Please Click Here To Edit The Item Category!" OnClick="lnkBtnEditItemCategory_Click" UniqueKey="MDItemCategory_EditItemCategory_key"/>
                        |
                        <asp:LinkButton ID="lnkBtnremoveItemCategory" runat="server" Text="Delete" CssClass="CommonButtonLink" ToolTip="Please Click Here To Delete The Item Category!" OnClientClick="return confirm('Are you sure to delete Item Category?')" OnClick="lnkBtnremoveItemCategory_Click" UniqueKey="MDItemCategory_Remove_key"/>
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
                        Category Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCategoryName">
                            Enter Category Name</label>
                        <asp:TextBox ID="txtCategoryName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server" ToolTip="Please Write The Item Category! e.g. Civil Materials"
                            ValidationGroup="MDItemCategoryEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCategoryName" runat="server" ControlToValidate="txtCategoryName"
                            ErrorMessage="Please Enter Category Name" ValidationGroup="MDItemCategoryEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105" ClientIDMode="Static"
                            ID="txtDescription" runat="server" ValidationGroup="MDItemCategoryEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="MDItemCategoryEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="MDItemCategoryEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="MDItemCategoryControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="MDItemCategoryControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="MDItemCategoryControl_Clear_key" />
                    </div>
                </div>
                <br />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
