<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 26-May-2013, 02:32:38
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDMDTask.ascx.cs" Inherits="Bay.ERP.Web.UI.BDMDTaskControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Project Task Tree</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayTaskTreeView ID="treeTask" runat="server" ToolTip="Please Select Task!" ProjectID="0">
                        </kti:BayTaskTreeView>
                    </div>
                    <div style="float: left; width: width: 100px; padding: 0px 10px 0px 14px;">
                        <asp:LinkButton ID="lnkBtnEditItemCategory" runat="server" Text="Edit" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Edit The Task!" OnClick="lnkBtnEditItemCategory_Click"></asp:LinkButton>
                        |
                        <asp:LinkButton ID="lnkBtnremoveItemCategory" runat="server" Text="Delete" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Delete The Item!" OnClientClick="return confirm('Are you sure to delete Task?')"
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
                            ValidationGroup="BDMDTaskEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ErrorMessage="Please Enter Name" ValidationGroup="BDMDTaskEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Req. Standard Time&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRequiredStandardTime" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="BDMDTaskEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvRequiredStandardTime" runat="server" ControlToValidate="txtRequiredStandardTime"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="BDMDTaskEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Reminder Time&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtReminderTime" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="BDMDTaskEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvReminderTime" runat="server" ControlToValidate="txtReminderTime"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="BDMDTaskEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Repeats&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRepeat" runat="server" ClientIDMode="Static" ValidationGroup="BDMDTaskEntity" AutoPostBack="true" OnCheckedChanged="chkIsRepeat_CheckedChanged" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div id="dvRepeatInfo" runat="server" visible="false">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Repeat Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRepeatCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDMDTaskRepeatEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRepeatCategoryID" runat="server" ControlToValidate="ddlRepeatCategoryID"
                            ErrorMessage="Please Select Repeat Category" ValidationGroup="BDMDTaskRepeatEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Repeat Every&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtRepeatEvery">
                            Enter Repeat Every</label>
                        <asp:TextBox ID="txtRepeatEvery" CssClass="ktiNumberTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="BDMDTaskRepeatEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRepeatEvery" runat="server" ControlToValidate="txtRepeatEvery"
                            ErrorMessage="Please Enter Repeat Every" ValidationGroup="BDMDTaskRepeatEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvRepeatEvery" runat="server" ControlToValidate="txtRepeatEvery" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="BDMDTaskRepeatEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Starts On&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtStartsOn">
                            Enter Starts On</label>
                        <asp:TextBox ID="txtStartsOn" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox" Enabled="false"
                            ValidationGroup="BDMDTaskRepeatEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvStartsOn" runat="server" ControlToValidate="txtStartsOn"
                            ErrorMessage="Please Enter Starts On" ValidationGroup="BDMDTaskRepeatEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revStartsOn" runat="server" ControlToValidate="txtStartsOn"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="BDMDTaskRepeatEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Ends On&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEndsOn" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="BDMDTaskRepeatEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEndsOn" runat="server" ControlToValidate="txtEndsOn"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="BDMDTaskRepeatEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="BDMDTaskEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="BDMDTaskEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="BDMDTaskEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="BDMDTaskControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="BDMDTaskControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="BDMDTaskControl_Clear_key" />
                    </div>
                </div>
                <br />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
