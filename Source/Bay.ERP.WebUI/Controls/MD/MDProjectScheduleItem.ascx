<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDProjectScheduleItem.ascx.cs"
    Inherits="Bay.ERP.Web.UI.MDProjectScheduleItemControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Project Schedule Item Tree</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayProjectScheduleItemTreeView ID="treeProjectScheduleItem" runat="server">
                        </kti:BayProjectScheduleItemTreeView>
                    </div>
                    <div style="float: left; width: 100px; padding:0px 10px 0px 14px;">
                        <asp:LinkButton ID="lnkBtnEditItemCategory" runat="server" Text="Edit" CssClass="CommonButtonLink" ToolTip="Please Click Here To Edit The Item!"
                        OnClick="lnkBtnEditItemCategory_Click"></asp:LinkButton>
                        |
                        <asp:LinkButton ID="lnkBtnremoveItemCategory" runat="server" Text="Delete" CssClass="CommonButtonLink" ToolTip="Please Click Here To Delete The Item!"
                            OnClientClick="return confirm('Are you sure to delete Document Category?')"
                            OnClick="lnkBtnremoveItemCategory_Click"></asp:LinkButton>
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
                        Title&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTitle">
                            Enter Title</label>
                        <asp:TextBox ID="txtTitle" ClientIDMode="Static" CssClass="ktiTextBox" runat="server" ToolTip="Please Write The Schedule Item Name! e.g. Corporate"
                            ValidationGroup="MDProjectScheduleItemEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle"
                            ErrorMessage="Please Enter Title" ValidationGroup="MDProjectScheduleItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105" ClientIDMode="Static"
                            ID="txtDescription" runat="server" ValidationGroup="MDProjectScheduleItemEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypIssuePriority" runat="server" Text="Issue Priority" NavigateUrl="~/MD/MDIssuePriority.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlIssuePriorityID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDProjectScheduleItemEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvIssuePriorityID" runat="server" ControlToValidate="ddlIssuePriorityID"
                            ErrorMessage="Please Select Issue Priority" ValidationGroup="MDProjectScheduleItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Duration&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDuration" CssClass="ktiDecimalTextBox" ClientIDMode="Static" ToolTip="Please Write The Duration! e.g. 2136.36"
                            runat="server" ValidationGroup="MDProjectScheduleItemEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvDuration" runat="server" ControlToValidate="txtDuration" 
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="MDProjectScheduleItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Notify Before Min&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNotifyBeforeMin" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox" ToolTip="Please Write The Notification Time By Minute! e.g. 10"
                            ValidationGroup="MDProjectScheduleItemEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNotifyBeforeMin" runat="server" ControlToValidate="txtNotifyBeforeMin"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="MDProjectScheduleItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="MDProjectScheduleItemEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="MDProjectScheduleItemEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="MDProjectScheduleItemControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="MDProjectScheduleItemControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="MDProjectScheduleItemControl_Clear_key" />
                    </div>
                </div>
                <br />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
