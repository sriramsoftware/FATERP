<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 08-Oct-2013, 02:28:24
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="MDAsset.ascx.cs" Inherits="Bay.ERP.Web.UI.MDAssetControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <Triggers>
        <asp:PostBackTrigger ControlID="btnSubmit" />
    </Triggers>
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div style="float: left; width: 400px;">
                <div class="contentSubTittle">
                    Asset Tree</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayAssetTreeView ID="treeAsset" runat="server" ShowCheckBoxesInAllNodes="false">
                        </kti:BayAssetTreeView>
                    </div>
                    <div style="float: left; width: 100px; padding: 0px 10px 0px 14px;">
                        <asp:LinkButton ID="lnkBtnAdvanceSearch" runat="server" Text="Advance Search" CssClass="CommonButtonLink"
                            Visible="false" ToolTip="Please Click Here To Advance Search The Asset!" OnClick="lnkBtnAdvanceSearch_Click" />
                        |
                        <asp:LinkButton ID="lnkBtnEditAsset" runat="server" Text="Edit" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Edit The Asset!" OnClick="lnkBtnEditAsset_Click" />
                        |
                        <asp:LinkButton ID="lnkBtnremoveItem" runat="server" Text="Delete" CssClass="CommonButtonLink"
                            ToolTip="Please Click Here To Delete The Asset!" OnClientClick="return confirm('Are you sure to delete Asset?')"
                            OnClick="lnkBtnremoveAsset_Click" />
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div id="EntryForm" style="float: left; width: 600px;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Asset Code&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAssetCode">
                            Enter Asset Code</label>
                        <asp:TextBox ID="txtAssetCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="MDAssetEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAssetCode" runat="server" ControlToValidate="txtAssetCode"
                            ErrorMessage="Please Enter Asset Code" ValidationGroup="MDAssetEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Asset Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAssetName">
                            Enter Asset Name</label>
                        <asp:TextBox ID="txtAssetName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="MDAssetEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAssetName" runat="server" ControlToValidate="txtAssetName"
                            ErrorMessage="Please Enter Asset Name" ValidationGroup="MDAssetEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Image Url&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:FileUpload ID="fuImageUrl" ClientIDMode="Static" runat="server" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtDescription" runat="server" ValidationGroup="MDAssetEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Next Main. Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNextMaintananceDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="MDAssetEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revNextMaintananceDate" runat="server" ControlToValidate="txtNextMaintananceDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="MDAssetEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Artist/Creator&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlOwnerReferenceID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDAssetEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Insurance Info&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtInsuranceInformation" runat="server" ValidationGroup="MDAssetEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Price&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPrice">
                            Enter Price</label>
                        <asp:TextBox ID="txtPrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="MDAssetEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPrice" runat="server" ControlToValidate="txtPrice"
                            ErrorMessage="Please Enter Price" ValidationGroup="MDAssetEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvPrice" runat="server" ControlToValidate="txtPrice" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="MDAssetEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Medium&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtMedium">
                            Enter Medium</label>
                        <asp:TextBox ID="txtMedium" CssClass="ktiTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="MDAssetEntity" Width="210" />
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Width (inch)&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtWidth">
                            Enter Width (inch)</label>
                        <asp:TextBox ID="txtWidth" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="MDAssetEntity" Width="210" />
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Height (inch)&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtHeight">
                            Enter Height (inch)</label>
                        <asp:TextBox ID="txtHeight" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="MDAssetEntity" Width="210" />
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Present Book Value&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPresentBookValue">
                            Enter Book Value</label>
                        <asp:TextBox ID="txtPresentBookValue" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDAssetEntity" Width="210" />
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Current Loc. Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCurrentLocationProjectID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlCurrentLocationProjectID_SelectedIndexChanged"
                            runat="server" ValidationGroup="MDAssetEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project Floor Unit&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlProjectFloorUnitID_SelectedIndexChanged"
                            runat="server" ValidationGroup="MDAssetEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Project Unit Location&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectUnitLocationID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="MDAssetEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
                    ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="true"
                    ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
                    SuppressPostBack="false">
                </ajaxToolkit:CollapsiblePanelExtender>
                <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
                    <div id="divCollapsControl" class="divCollapsControl">
                        <div style="float: left; height: 16px; width: 16px;">
                            <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                        </div>
                        <div style="float: left; padding-left: 3px;">
                            <asp:Label ID="lvlCollapsText" runat="server" Text="More"></asp:Label>
                        </div>
                        <div style="clear: both;">
                        </div>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Unit&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlUnitID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                ValidationGroup="MDAssetEntity" Width="234">
                            </asp:DropDownList>
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Brand&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                ValidationGroup="MDAssetEntity" Width="234">
                            </asp:DropDownList>
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Vendor&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                ValidationGroup="MDAssetEntity" Width="234">
                            </asp:DropDownList>
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Used Or Handeled By&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtUsedOrHandeledBy" ClientIDMode="Static" CssClass="ktiTextBox"
                                runat="server" ValidationGroup="MDAssetEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Service Contract Info&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                ID="txtServiceContractInformation" runat="server" ValidationGroup="MDAssetEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Work Order&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlWorkOrderID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="MDAssetEntity" Width="234">
                            </asp:DropDownList>
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Asset Condition&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlAssetConditionID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="MDAssetEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvAssetConditionID" runat="server" ControlToValidate="ddlAssetConditionID"
                                ErrorMessage="Please Select Asset Condition" ValidationGroup="MDAssetEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Asset Owner Type&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlAssetOwnerTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="MDAssetEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvAssetOwnerTypeID" runat="server" ControlToValidate="ddlAssetOwnerTypeID"
                                ErrorMessage="Please Select Asset Owner Type" ValidationGroup="MDAssetEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Remarks&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                ID="txtRemarks" runat="server" ValidationGroup="MDAssetEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100; display: none;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Is Removed&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="MDAssetEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <br />
                    <br />
                </asp:Panel>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="MDAssetEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="MDAssetControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="MDAssetControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="MDAssetControl_Clear_key" /><br />
                        <br />
                        <br />
                        <%-- <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Qty&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtPushToStoreQty" CssClass="ktiNumberTextBox" ClientIDMode="Static" runat="server" ReadOnly="true" style="font-weight:bold;" Text="0"
                                Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPushToStoreQty"
                                ValidationGroup="none"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtPushToStoreQty" Display="Dynamic"
                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="none"></asp:RangeValidator>
                        </div>
                    </div>
                        <asp:Button ID="btnPushToStore" OnClick="btnPushToStore_Click" runat="server" Text="Save & Push To Store" ValidationGroup="MDAssetEntity"/>--%>
                    </div>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
