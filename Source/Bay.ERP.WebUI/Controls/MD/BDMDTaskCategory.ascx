<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 26-May-2013, 02:32:38
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDMDTaskCategory.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDMDTaskCategoryControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>

            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Project Task Category Tree</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayTaskCategoryTreeView ID="treeTaskCategory" runat="server" ToolTip="Please Select Task Category!">
                        </kti:BayTaskCategoryTreeView>
                    </div>
                    <div style="float: left; width: width: 100px; padding: 0px 10px 0px 14px;">
                        <asp:LinkButton ID="lnkBtnEditItemCategory" runat="server" Text="Edit" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Edit The Item!" OnClick="lnkBtnEditItemCategory_Click"></asp:LinkButton>
                        |
                        <asp:LinkButton ID="lnkBtnremoveItemCategory" runat="server" Text="Delete" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Delete The Item!" OnClientClick="return confirm('Are you sure to delete Document Category?')"
                            OnClick="lnkBtnremoveItemCategory_Click"></asp:LinkButton>
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
             <div id="dvQuick">
                <h3>Quick Links</h3>
                <asp:HyperLink ID="hypTaskCategory" runat="server" NavigateUrl="~/MD/BDMDTaskCategory.aspx" Text="Task Category" Target="_blank"></asp:HyperLink><br />
                <asp:HyperLink ID="hypTask" runat="server" NavigateUrl="~/MD/BDMDTask.aspx" Text="Create Task" Target="_blank"></asp:HyperLink><br />
                <asp:HyperLink ID="hypTaskTemplate" runat="server" NavigateUrl="~/BD/BDTaskTemplate.aspx" Text="Task Template" Target="_blank"></asp:HyperLink><br />
                <asp:HyperLink ID="hypTaskSetup" runat="server" NavigateUrl="~/BD/BDTaskSetup.aspx" Text="Task Assign" Target="_blank"></asp:HyperLink><br />
                </div>
            <div style="float: left; width: 448px;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Department&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDepartmentID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDMDTaskCategoryEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
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
                            ValidationGroup="BDMDTaskCategoryEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ErrorMessage="Please Enter Name" ValidationGroup="BDMDTaskCategoryEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="BDMDTaskCategoryEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="BDMDTaskCategoryEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="BDMDTaskCategoryControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="BDMDTaskCategoryControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="BDMDTaskCategoryControl_Clear_key" />
                    </div>
                </div>
                <br />
                
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
