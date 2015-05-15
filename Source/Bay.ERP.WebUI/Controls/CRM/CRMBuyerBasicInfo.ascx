<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 01-Apr-2013, 02:41:21
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMBuyerBasicInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMBuyerBasicInfoControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
<Triggers>
        <asp:PostBackTrigger ControlID="btnSubmit" />
    </Triggers>
    <ContentTemplate>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Buyer Basic Info"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
        <div>
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Buyer Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBuyerTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBuyerTypeID" runat="server" ControlToValidate="ddlBuyerTypeID"
                            ErrorMessage="Please Select Buyer Type" ValidationGroup="CRMBuyerBasicInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Contact Full Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtContactFullName">
                            Enter Contact Full Name</label>
                        <asp:TextBox ID="txtContactFullName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvContactFullName" runat="server" ControlToValidate="txtContactFullName"
                            ErrorMessage="Please Enter Contact Full Name" ValidationGroup="CRMBuyerBasicInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Company Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCompanyName">
                            Enter Company Name</label>
                        <asp:TextBox ID="txtCompanyName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCompanyName" runat="server" ControlToValidate="txtCompanyName"
                            ErrorMessage="Please Enter Company Name" ValidationGroup="CRMBuyerBasicInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Designation&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDesignation" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
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
                        Interested In&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlInterestedProjectCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvInterestedProjectCategoryID" runat="server" ControlToValidate="ddlInterestedProjectCategoryID"
                            ErrorMessage="Please Select Interested Project Category" ValidationGroup="CRMBuyerBasicInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Mobile No1&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtMobileNo">
                            Enter Mobile No</label>
                        <asp:TextBox ID="txtMobileNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvMobileNo" runat="server" ControlToValidate="txtMobileNo"
                            ErrorMessage="Please Enter Mobile No" ValidationGroup="CRMBuyerBasicInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                 <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Mobile No2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMobileNo2" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Home Landphone&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtLandPhone" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revLandPhone" runat="server" ControlToValidate="txtLandPhone" Display="Dynamic"
                            EnableViewState="true" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                 <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Office Landphone&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtLandPhoneOffice" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revLandPhoneOffice" runat="server" ControlToValidate="txtLandPhoneOffice" Display="Dynamic"
                            EnableViewState="True" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                 <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Fax Number&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtFaxNumber" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revFaxNumber" runat="server" ControlToValidate="txtFaxNumber" Display="Dynamic"
                            EnableViewState="True" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Home Address&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtPresentAddress" runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Office Address&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtPresentAddressOffice" runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Email1&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic"
                            EnableViewState="true" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                 <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Email2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmail2" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmail2" runat="server" ControlToValidate="txtEmail2" Display="Dynamic"
                            EnableViewState="true" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        DOB&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDOB" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revDOB" runat="server" ControlToValidate="txtDOB"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        No Of Children&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNoOfChildren" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNoOfChildren" runat="server" ControlToValidate="txtNoOfChildren" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RangeValidator>
                    </div>
                    </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Interested Location&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlInterestedLandLocationID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        City&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCityID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Area Needed From&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAreaNeededFrom" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Type="Number" Width="90" />
                             To&nbsp;
                            <asp:TextBox ID="txtAreaNeededTo" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Type="Number" Width="90" />
                             <asp:DropDownList ID="ddlAreaUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Width="90">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvAreaNeededFrom" runat="server" ControlToValidate="txtAreaNeededFrom" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RangeValidator>
                            <asp:RangeValidator ID="rvAreaNeededTo" runat="server" ControlToValidate="txtAreaNeededTo" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Parking Needed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtParkingNeeded" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvParkingNeeded" runat="server" ControlToValidate="txtParkingNeeded" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Bedroom Needed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtToiletNeeded" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvToiletNeeded" runat="server" ControlToValidate="txtToiletNeeded" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Unit Needed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtUnitNeeded" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvUnitNeeded" runat="server" ControlToValidate="txtUnitNeeded" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                &nbsp;
                            </div>
                            <div class="ktiListBox">
                                <asp:CheckBoxList ID="chbxBuyerInterestedRoom" runat="server">
                                </asp:CheckBoxList>
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Know Us By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAdvertiseWayID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Lead Generated By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLeadGeneratedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Lead Managed By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLeadManagedByOneEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Lead Managed By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlLeadManagedByTwoEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Conversion Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtLeadConversionDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMBuyerBasicInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revLeadConversionDate" runat="server" ControlToValidate="txtLeadConversionDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMBuyerBasicInfoEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Prospect For Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProspectForProject" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="530" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="CRMBuyerBasicInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMBuyerBasicInfoEntity" OnClick="btnSave_Click"
                            runat="server" Text="Save and Add New" UniqueKey="CRMBuyerBasicInfoControl_Submit_key" />
                            <kti:SecureButton ID="btnSubmitAndCommunicate" ValidationGroup="CRMBuyerBasicInfoEntity" OnClick="btnSubmitAndCommunicate_Click"
                            runat="server" Text="Save And Communicate" UniqueKey="CRMBuyerBasicInfoControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="CRMBuyerBasicInfoControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="CRMBuyerBasicInfoControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <br />
             <div class="TableRow" style="width: 100%; float: right;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormLeble" style="text-align: right; width: 617px;">
                    Filter Text&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        Type Buyer or Name</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                </div>
            </div>
            <div class="listContentTitle">
                Buyer Basic Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMBuyerBasicInfo" runat="server" DataSourceID="odsCRMBuyerBasicInfo" OnItemCommand="lvCRMBuyerBasicInfo_ItemCommand" OnItemDataBound="lvCRMBuyerBasicInfo_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    
                                    <td class="hi">
                                        Contact Full Name
                                    </td>
                                    <td class="hi">
                                        Mobile No
                                    </td>
                                    <td class="hi">
                                        Company Name
                                    </td>
                                    <td class="hi">
                                        Interested Land Location
                                    </td>
                                    <td class="hi">
                                        City
                                    </td>
                                    <td class="hi" style="width:170px;">
                                        Apartment Size
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Parking Needed
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Toilet Needed
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Unit Needed
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Advertise Way
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Lead Generated By Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Lead Managed By One Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Lead Managed By Two Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Lead Conversion Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Prospect For Project
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Image Url
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
                                    </td>
                                    <td class="his">
                                        Children Info
                                    </td>
                                    <td class="his">
                                        Allottee
                                    </td>
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="rpb">
                                        &nbsp;
                                    </td>
                                </tr>
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                                <tr>
                                    <td colspan="100%">
                                        <div class="lv-FooterContainer">
                                            <div class="lv-Footer">
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="15">
                                                    <Fields>
                                                        <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="lv-PagerItem" FirstPageImageUrl="~/Images/CustomListView/Default/FT.png"
                                                            PreviousPageImageUrl="~/Images/CustomListView/Default/PT.png" ShowFirstPageButton="true"
                                                            ShowPreviousPageButton="true" ShowNextPageButton="false" ShowLastPageButton="false" />
                                                        <asp:NumericPagerField ButtonType="Button" ButtonCount="10" NumericButtonCssClass="lv-PagerItemNumeric"
                                                            CurrentPageLabelCssClass="lv-PagerItemNumericCurrent" RenderNonBreakingSpacesBetweenControls="false" />
                                                        <asp:NextPreviousPagerField ButtonType="Image" ButtonCssClass="lv-PagerItem" NextPageImageUrl="~/Images/CustomListView/Default/NT.png"
                                                            LastPageImageUrl="~/Images/CustomListView/Default/LT.png" ShowFirstPageButton="false"
                                                            ShowPreviousPageButton="false" ShowNextPageButton="true" ShowLastPageButton="true"
                                                            RenderNonBreakingSpacesBetweenControls="true" />
                                                        <asp:TemplatePagerField>
                                                    <PagerTemplate>
                                                                <div class="lv-PagerCount">
                                                                    Items <span>
                                                                        <%# Container.StartRowIndex +1%></span> to <span>
                                                                            <%# (Container.StartRowIndex+Container.PageSize ) < Container.TotalRowCount ? (Container.StartRowIndex+Container.PageSize) : Container.TotalRowCount %></span>
                                                                    of <span>
                                                                        <%# Container.TotalRowCount%></span>
                                                                </div>
                                                            </PagerTemplate>
                                                        </asp:TemplatePagerField>
                                                    </Fields>
                                                </asp:DataPager>
                                            </div>
                                        </div>
                                    </td>
                                </tr>
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr class="r">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i">
                                    <%# Eval("ContactFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompanyName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CRMMDLandLocationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDCityName")%>
                                </td>
                                <td class="i">
                                    <b>From: </b><%# Eval("AreaNeededFrom")%>  <b>To: </b><%# Eval("AreaNeededTo")%> <%# Eval("CRMMDAreaUnitName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ParkingNeeded")%>
                                </td>
                                
                                <td class="i" style="display:none;">
                                    <%# Eval("ToiletNeeded")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("UnitNeeded")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CRMMDAdvertiseWayName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("LeadGeneratedByMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("LeadManagedByOneMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("LeadManagedByTwoMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("LeadConversionDate") != null ? ((DateTime)Eval("LeadConversionDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                               <asp:Image ID="imgImageUrl" ImageUrl='<%# Eval("ImageUrl")%>' runat="server" Height="45" Width="45" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("BuyerBasicInfoID")%>' UniqueKey="CRMBuyerBasicInfo_lvCRMBuyerBasicInfo_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Buyer Basic Info?')"
                                        CommandArgument='<%#Eval("BuyerBasicInfoID")%>' UniqueKey="CRMBuyerBasicInfo_lvCRMBuyerBasicInfo_Delete_key"/>
                                </td>
                                 <td class="i">
                                        <asp:HyperLink ID="hypBuyerChildrenInfo" runat="server" Text="Children Info" CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Buyer's Children Info!"></asp:HyperLink>
                                    </td>
                                <td class="i">
                                        <asp:HyperLink ID="hypAlltteeInfo" runat="server" Text="Allottee Info" CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Attottee!"></asp:HyperLink>
                                    </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </ItemTemplate>
                        <AlternatingItemTemplate>
                            <tr class="ar">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                
                                <td class="i">
                                    <%# Eval("ContactFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompanyName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CRMMDLandLocationName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDCityName")%>
                                </td>
                                <td class="i">
                                    <b>From: </b><%# Eval("AreaNeededFrom")%>  <b>To: </b><%# Eval("AreaNeededTo")%> <%# Eval("CRMMDAreaUnitName")%>
                                </td>
                                 <td class="i" style="display:none;">
                                    <%# Eval("ParkingNeeded")%>
                                </td>
                                
                                <td class="i" style="display:none;">
                                    <%# Eval("ToiletNeeded")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("UnitNeeded")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CRMMDAdvertiseWayName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("LeadGeneratedByMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("LeadManagedByOneMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("LeadManagedByTwoMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("LeadConversionDate") != null ? ((DateTime)Eval("LeadConversionDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                               <asp:Image ID="imgImageUrl" ImageUrl='<%# Eval("ImageUrl")%>' runat="server" Height="45" Width="45" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("BuyerBasicInfoID")%>' UniqueKey="CRMBuyerBasicInfo_lvCRMBuyerBasicInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Buyer Basic Info?')"
                                        CommandArgument='<%#Eval("BuyerBasicInfoID")%>' UniqueKey="CRMBuyerBasicInfo_lvCRMBuyerBasicInfo_Delete_key"/>
                                </td>
                                <td class="i">
                                        <asp:HyperLink ID="hypBuyerChildrenInfo" runat="server" Text="Children Info" CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Buyer's Children Info!"></asp:HyperLink>
                                    </td>
                                <td class="i">
                                        <asp:HyperLink ID="hypAlltteeInfo" runat="server" Text="Allottee Info" CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Attottee!"></asp:HyperLink>
                                    </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsCRMBuyerBasicInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMBuyerBasicInfo_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMBuyerBasicInfo_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
