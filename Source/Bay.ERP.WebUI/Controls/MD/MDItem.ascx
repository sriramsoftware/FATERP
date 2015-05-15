<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDItem.ascx.cs" Inherits="Bay.ERP.Web.UI.MDItemControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div style="float: left; width: 400px;">
                <div>
                    <div style="float: left; width: 275px;">
                        <div class="contentSubTittle">
                            Item Tree
                        </div>
                    </div>
                    <div style="float: left; width: 100px; padding: 0px 10px 0px 14px;">
                        <asp:LinkButton ID="lnkBtnAdvanceSearch" runat="server" Text="Advance Search" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Advance Search The Item!" UniqueKey="MDItem_AdvanceSearch_key"
                            OnClick="lnkBtnAdvanceSearch_Click" />
                        |
                        <asp:LinkButton ID="lnkBtnEditItemCategory" runat="server" Text="Edit" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Edit The Item!" UniqueKey="MDItem_EditItemCategory_key"
                            OnClick="lnkBtnEditItemCategory_Click" />
                        |
                        <asp:LinkButton ID="lnkBtnremoveItemCategory" runat="server" Text="Delete" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Delete The Item!" UniqueKey="MDItem_Remove_key"
                            OnClientClick="return confirm('Are you sure to delete Item?')" OnClick="lnkBtnremoveItemCategory_Click" />
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
                <div style="width: 375px;">
                    <kti:BayItemTreeView ID="treeItem" runat="server" ShowCheckBoxesInAllNodes="false"
                        ToolTip="Please Select Item; At Last Node Of The TreeView!">
                    </kti:BayItemTreeView>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 600px;">
                <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Item Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtItemName">
                            Enter Item Name</label>
                        <asp:TextBox ID="txtItemName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ToolTip="Please Select Item From Item TreeView After That Write The Item! e.g. Bricks Chips 3/4"
                            ValidationGroup="MDItemEntity" Width="230" />
                        <span class="RequiredField">*</span> <span>
                            <kti:SecureButton ID="btnCheckAvailability" OnClick="btnCheckAvailability_Click"
                                runat="server" Text="Availability" UniqueKey="MDItemControl_CheckAvailability_key" /></span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvItemName" runat="server" ControlToValidate="txtItemName"
                            ErrorMessage="Please Enter Item Name" ValidationGroup="MDItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypUnit" runat="server" Text="Unit"
                            NavigateUrl="~/MD/MDUnit.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlUnitID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ToolTip="Please Select The Item Unit! e.g. Cft" ValidationGroup="MDItemEntity"
                            Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Default Brand&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static" ToolTip="Please Select The Item Default Brand To Find The Item Price! e.g. BSRM"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlBrandID_SelectedIndexChanged"
                            runat="server" ValidationGroup="MDItemEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBrandID" runat="server" ControlToValidate="ddlBrandID"
                            ErrorMessage="Please Select Brand" ValidationGroup="MDItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Default Vendor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static" ToolTip="Please Select The Item Default Vendor To Find The Item Price!"
                            runat="server" ValidationGroup="MDItemEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSupplierID" runat="server" ControlToValidate="ddlSupplierID"
                            ErrorMessage="Please Select Vendor" ValidationGroup="MDItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Default Region&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRegionID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true"
                            OnSelectedIndexChanged="ddlRegionID_SelectedIndexChanged" ToolTip="Please Select The Item Default Region To Find The Item Price! e.g. Asian"
                            runat="server" ValidationGroup="MDItemEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRegionID" runat="server" ControlToValidate="ddlRegionID"
                            ErrorMessage="Please Select Region" ValidationGroup="MDItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Default Country&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCountryID" CssClass="ktiSelect" ClientIDMode="Static" ToolTip="Please Select The Item Default Country To Find The Item Price! e.g. Bangladesh"
                            runat="server" ValidationGroup="MDItemEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCountryID" runat="server" ControlToValidate="ddlCountryID"
                            ErrorMessage="Please Select Country" ValidationGroup="MDItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                            ClientIDMode="Static" ID="txtDescription" runat="server" ValidationGroup="MDItemEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div style="display:none;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; text-decoration: underline;">
                        <b>Thumb Rule</b>
                    </div>
                    <div class="TableFormContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Floor Rule Variable&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFloorRuleVariable">
                            Enter Floor Rule Variable</label>
                        <asp:TextBox ID="txtFloorRuleVariable" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            ToolTip="Please Write The Floor Rule Variable To Maintain The Variance To The Item! e.g. By Default 1.0"
                            runat="server" ValidationGroup="MDItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFloorRuleVariable" runat="server" ControlToValidate="txtFloorRuleVariable"
                            ErrorMessage="Please Enter Floor Rule Variable" ValidationGroup="MDItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvFloorRuleVariable" runat="server" ControlToValidate="txtFloorRuleVariable"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="MDItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Floor Quantity&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFloorQuantity">
                            Enter Floor Quantity</label>
                        <asp:TextBox ID="txtFloorQuantity" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            ToolTip="Please Write The Assumption Of Floor Qty To The Item! e.g. By Default 0"
                            runat="server" ValidationGroup="MDItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFloorQuantity" runat="server" ControlToValidate="txtFloorQuantity"
                            ErrorMessage="Please Enter Floor Quantity" ValidationGroup="MDItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvFloorQuantity" runat="server" ControlToValidate="txtFloorQuantity"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="MDItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Basement Rule Var.&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtBasementRuleVariable">
                            Enter Basement Rule Variable</label>
                        <asp:TextBox ID="txtBasementRuleVariable" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            ToolTip="Please Write The Basement Rule Variable To Maintain The Variance To The Item! e.g. By Default 1.0"
                            runat="server" ValidationGroup="MDItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBasementRuleVariable" runat="server" ControlToValidate="txtBasementRuleVariable"
                            ErrorMessage="Please Enter Basement Rule Variable" ValidationGroup="MDItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvBasementRuleVariable" runat="server" ControlToValidate="txtBasementRuleVariable"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="MDItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Basement Quantity&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtBasementQuantity">
                            Enter Basement Quantity</label>
                        <asp:TextBox ID="txtBasementQuantity" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            ToolTip="Please Write The Assumption Of Basement Qty To The Item! e.g. By Default Value Is 0"
                            runat="server" ValidationGroup="MDItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBasementQuantity" runat="server" ControlToValidate="txtBasementQuantity"
                            ErrorMessage="Please Enter Basement Quantity" ValidationGroup="MDItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvBasementQuantity" runat="server" ControlToValidate="txtBasementQuantity"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="MDItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Overall Rule Variable&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtOverallRuleVariable">
                            Enter Overall Rule Variable</label>
                        <asp:TextBox ID="txtOverallRuleVariable" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            ToolTip="Please Write The Overall Rule Variable To Maintain The Variance To The Item!"
                            runat="server" ValidationGroup="MDItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvOverallRuleVariable" runat="server" ControlToValidate="txtOverallRuleVariable"
                            ErrorMessage="Please Enter Overall Rule Variable" ValidationGroup="MDItemEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvOverallRuleVariable" runat="server" ControlToValidate="txtOverallRuleVariable"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="MDItemThumbRuleEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Overall Quantity&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtOverallQuantity">
                            Enter Overall Quantity</label>
                        <asp:TextBox ID="txtOverallQuantity" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            ToolTip="Please Write The Assumption Of Overall Qty To The Item! e.g. By Default Value Is 0"
                            runat="server" ValidationGroup="MDItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvOverallQuantity" runat="server" ControlToValidate="txtOverallQuantity"
                            ErrorMessage="Please Enter Overall Quantity" ValidationGroup="MDItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvOverallQuantity" runat="server" ControlToValidate="txtOverallQuantity"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="MDItemThumbRuleEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="MDItemEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypBrandMapList" runat="server" Text="Additional Brand"
                            NavigateUrl="~/MD/MDBrand.aspx" Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="ktiListBox" style="height: 200px; width: 420px;">
                        <asp:CheckBoxList ID="chbxItemBrand" runat="server" ToolTip="Please Select The Item's Available Brand! e.g. BSRM, Singer">
                        </asp:CheckBoxList>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <br />
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="MDItemEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="MDItemControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="MDItemControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="MDItemControl_Clear_key" />
                    </div>
                </div>
                <br />
            </div>
        </div>
        <ajaxToolkit:ModalPopupExtender ID="Panel2_ModalPopupExtender" runat="server" PopupControlID="Panel2"
            DynamicServicePath="" Enabled="True" TargetControlID="lnkAddQtyToProjectPopup"
            OkControlID="lnkAddQtyToProjectPopup" CancelControlID="btnPnlCancel" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
        <div>
            <asp:Panel ID="Panel2" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                <div class="modalPanelBackground">
                    <br />
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            &nbsp;
                        </div>
                        <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                            <asp:Button ID="Button1" runat="server" Text="X"></asp:Button>
                        </div>
                    </div>
                    <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                        padding-left: 10px;">
                        <tr>
                            <th rowspan="3" class="sized">
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
                                    Width="20" Height="300" AlternateText="" />
                            </th>
                            <th class="topleft">
                            </th>
                            <td class="tbl-border-top">
                                &nbsp;
                            </td>
                            <th class="topright">
                            </th>
                            <th rowspan="3" class="sized">
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
                                    Width="20" Height="300" AlternateText="" />
                            </th>
                        </tr>
                        <tr>
                            <td class="tbl-border-left">
                            </td>
                            <td>
                                <div class="table-content" style="width: 500px;">
                                    <div class="page-content">
                                        <h1>
                                            Add Item To BOQ/Project Cost</h1>
                                        <div>
                                            <div class="TableRow" style="width: 500px;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    Item Name&nbsp;:
                                                </div>
                                                <div class="TableFormContent" style="padding-top: 10px;">
                                                    <asp:Label ID="lblItemName" runat="server" Font-Bold="true"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypProject" runat="server" Text="Project"
                                                        NavigateUrl="~/BD/BDProject.aspx" Target="_blank"></asp:HyperLink>
                                                    &nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                                        ValidationGroup="ItemQtyEntryEntity" Width="236">
                                                    </asp:DropDownList>
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                                                        ErrorMessage="Please Select Project" ValidationGroup="ItemQtyEntryEntity" EnableViewState="False"
                                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    Initial Qty&nbsp;:
                                                </div>
                                                <div class="TableFormContent waterMarkContainer">
                                                    <label class="watermarkLabel" for="txtQty">
                                                        Enter Initial Qty</label>
                                                    <asp:TextBox ID="txtQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                        ValidationGroup="ItemQtyEntryEntity" Width="210" />
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvNumberOfStorey" runat="server" ControlToValidate="txtQty"
                                                        ErrorMessage="Please Enter Number Of Storey" ValidationGroup="ItemQtyEntryEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                    <asp:RangeValidator ID="rvNumberOfStorey" runat="server" ControlToValidate="txtQty"
                                                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                        Type="Double" ValidationGroup="ItemQtyEntryEntity"></asp:RangeValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:LinkButton ID="lnkAddQtyToProjectPopup" runat="server"></asp:LinkButton>
                                                    <asp:Button ID="btnAddToProject" runat="server" Text="Add Qty" ValidationGroup="ItemQtyEntryEntity"
                                                        OnClick="btnAddToProject_Click" />
                                                    <asp:Button ID="btnPnlCancel" runat="server" Text="Cancel" />
                                                </div>
                                            </div>
                                        </div>
                                    </div>
                                    <div class="quick-links">
                                    </div>
                                    <div class="clear">
                                    </div>
                                </div>
                            </td>
                            <td class="tbl-border-right">
                            </td>
                        </tr>
                        <tr>
                            <th class="sized bottomleft">
                            </th>
                            <td class="tbl-border-bottom">
                                &nbsp;
                            </td>
                            <th class="sized bottomright">
                            </th>
                        </tr>
                    </table>
                </div>
            </asp:Panel>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
