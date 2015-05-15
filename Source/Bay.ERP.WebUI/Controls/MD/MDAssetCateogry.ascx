<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 08-Oct-2013, 02:28:24
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDAssetCateogry.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MDAssetCateogryControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div2" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Asset Category Tree</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayAssetCategoryTreeView ID="treeAssetCategory" runat="server" ShowCheckBoxesInAllNodes="false">
                        </kti:BayAssetCategoryTreeView>
                    </div>
                    <div style="float: left; width: 100px; padding: 0px 10px 0px 14px;">
                        <asp:LinkButton ID="lnkBtnAdvanceSearch" runat="server" Text="Advance Search" CssClass="CommonButtonLink" Visible="false"
                            ToolTip="Please Click Here To Advance Search The Asset!" OnClick="lnkBtnAdvanceSearch_Click" />
                        |
                        <asp:LinkButton ID="lnkBtnEditAssetCategory" runat="server" Text="Edit" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Edit The Asset Category!" OnClick="lnkBtnEditAssetCategory_Click"/>
                        |
                        <asp:LinkButton ID="lnkBtnremoveItemCategory" runat="server" Text="Delete" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Delete The Asset Category!" OnClientClick="return confirm('Are you sure to delete Asset Category?')"
                            OnClick="lnkBtnremoveAssetCategory_Click"/>
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 600px;">
                <div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Category Name&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtCategoryName">
                                Enter Category Name</label>
                            <asp:TextBox ID="txtCategoryName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ValidationGroup="MDAssetCateogryEntity" Width="230" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvCategoryName" runat="server" ControlToValidate="txtCategoryName"
                                ErrorMessage="Please Enter Category Name" ValidationGroup="MDAssetCateogryEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Description&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                ID="txtDescription" runat="server" ValidationGroup="MDAssetCateogryEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100; display:none;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Is Removed&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="MDAssetCateogryEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="text-align: center;">
                        <div class="TableFormLeble">
                            &nbsp;</div>
                        <div class="TableFormContent">
                            <kti:SecureButton ID="btnSubmit" ValidationGroup="MDAssetCateogryEntity" OnClick="btnSave_Click"
                                runat="server" Text="Add" UniqueKey="MDAssetCateogryControl_Submit_key" />
                            <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                                Text="Add New" UniqueKey="MDAssetCateogryControl_AddNew_key" />
                            <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                                UniqueKey="MDAssetCateogryControl_Clear_key" />
                        </div>
                    </div>
                    <br />
                </div>
                <br />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
