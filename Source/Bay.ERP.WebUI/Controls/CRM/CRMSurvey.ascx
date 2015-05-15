<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 24-Oct-2013, 12:51:37
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMSurvey.ascx.cs" Inherits="Bay.ERP.Web.UI.CRMSurveyControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Survey"></asp:Label>
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
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypSurveyOwner" runat="server" Text="Survey Owner"
                            NavigateUrl="~/CRM/CRMSurveyOwner.aspx" Target="_blank"></asp:HyperLink>
                            &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSurveyOwnerID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMSurveyEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSurveyOwnerID" runat="server" ControlToValidate="ddlSurveyOwnerID"
                            ErrorMessage="Please Select Survey Owner" ValidationGroup="CRMSurveyEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Area&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAreaID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMSurveyEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAreaID" runat="server" ControlToValidate="ddlAreaID"
                            ErrorMessage="Please Select Area" ValidationGroup="CRMSurveyEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtDescription" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Plot Address&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPlotAddress">
                            Enter Plot Address</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtPlotAddress" runat="server" ValidationGroup="CRMSurveyEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPlotAddress" runat="server" ControlToValidate="txtPlotAddress"
                            ErrorMessage="Please Enter Plot Address" ValidationGroup="CRMSurveyEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Appr. Plot Size&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtApproximatePlotSize">
                            Enter Approximate Plot Size</label>
                        <asp:TextBox ID="txtApproximatePlotSize" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMSurveyEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvApproximatePlotSize" runat="server" ControlToValidate="txtApproximatePlotSize"
                            ErrorMessage="Please Enter Approximate Plot Size" ValidationGroup="CRMSurveyEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvApproximatePlotSize" runat="server" ControlToValidate="txtApproximatePlotSize"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMSurveyEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Area Unit&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAreaUnitID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="CRMSurveyEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAreaUnitID" runat="server" ControlToValidate="ddlAreaUnitID"
                            ErrorMessage="Please Select Area Unit" ValidationGroup="CRMSurveyEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Appr. Floor Size Sft&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtApproximateFloorSizeSft">
                            Enter Approximate Floor Size Sft</label>
                        <asp:TextBox ID="txtApproximateFloorSizeSft" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMSurveyEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvApproximateFloorSizeSft" runat="server" ControlToValidate="txtApproximateFloorSizeSft"
                            ErrorMessage="Please Enter Approximate Floor Size Sft" ValidationGroup="CRMSurveyEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvApproximateFloorSizeSft" runat="server" ControlToValidate="txtApproximateFloorSizeSft"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMSurveyEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Floors&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFloors">
                            Enter Floors</label>
                        <asp:TextBox ID="txtFloors" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="CRMSurveyEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFloors" runat="server" ControlToValidate="txtFloors"
                            ErrorMessage="Please Enter Floors" ValidationGroup="CRMSurveyEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvFloors" runat="server" ControlToValidate="txtFloors" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CRMSurveyEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Appr. Total Space Sft&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtApproximateTotalSpaceSft">
                            Enter Approximate Total Space Sft</label>
                        <asp:TextBox ID="txtApproximateTotalSpaceSft" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMSurveyEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvApproximateTotalSpaceSft" runat="server" ControlToValidate="txtApproximateTotalSpaceSft"
                            ErrorMessage="Please Enter Approximate Total Space Sft" ValidationGroup="CRMSurveyEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvApproximateTotalSpaceSft" runat="server" ControlToValidate="txtApproximateTotalSpaceSft"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMSurveyEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Basements&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtBasements" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        No Of Car Parking&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtNoOfCarParking" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        AC System&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtACSystem" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Generator Backup&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtGeneratorBackup" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Lifts Capacity&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtLiftsCapacity" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Toilets Per Floor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtToiletsPerFloor" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Available Floor Sft&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtAvailableFloorSft" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Avail. For Occupancy&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtAvailableForOccupancy" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Rental Rate Per Sft&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRentalRateBDTPerSft" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Selling Rate Per Sft&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtSellingRateBDTPerSft" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Handover Time&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtHandoverTime" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Building Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSurveyBuildingStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMSurveyEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSurveyBuildingStatusID" runat="server" ControlToValidate="ddlSurveyBuildingStatusID"
                            ErrorMessage="Please Select Survey Building Status" ValidationGroup="CRMSurveyEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Source Information&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSurveySourceInformationID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMSurveyEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSurveySourceInformationID" runat="server" ControlToValidate="ddlSurveySourceInformationID"
                            ErrorMessage="Please Select Survey Source Information" ValidationGroup="CRMSurveyEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Source Person&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtSourcePersonInformation" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Contact Info&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtContactInfo" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Additional Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtAdditionalRemarks" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Others Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtOthersRemarks" runat="server" ValidationGroup="CRMSurveyEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Survey Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSurveyDate">
                            Enter Survey Date</label>
                        <asp:TextBox ID="txtSurveyDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMSurveyEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSurveyDate" runat="server" ControlToValidate="txtSurveyDate"
                            ErrorMessage="Please Enter Survey Date" ValidationGroup="CRMSurveyEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revSurveyDate" runat="server" ControlToValidate="txtSurveyDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMSurveyEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMSurveyEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CRMSurveyControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="CRMSurveyControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="CRMSurveyControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Survey List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMSurvey" runat="server" DataSourceID="odsCRMSurvey" OnItemCommand="lvCRMSurvey_ItemCommand" OnItemDataBound="lvCRMServey_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Survey Owner
                                    </td>
                                    <td class="hi">
                                        Description
                                    </td>
                                    <td class="hi">
                                        Plot Address
                                    </td>
                                    <td class="hi">
                                        Approximate Plot Size
                                    </td>
                                    <td class="hi">
                                        Area Unit
                                    </td>
                                    <td class="hi">
                                        Approximate Floor Size Sft
                                    </td>
                                    <td class="hi">
                                        Floors
                                    </td>
                                    <td class="hi">
                                        Approximate Total Space Sft
                                    </td>
                                    <td class="hi">
                                        Basements
                                    </td>
                                    <td class="hi">
                                        No Of Car Parking
                                    </td>
                                    <td class="hi">
                                        A CSystem
                                    </td>
                                    <td class="hi">
                                        Generator Backup
                                    </td>
                                    <td class="hi">
                                        Lifts Capacity
                                    </td>
                                    <td class="hi">
                                        Toilets Per Floor
                                    </td>
                                    <td class="hi">
                                        Available Floor Sft
                                    </td>
                                    <td class="hi">
                                        Available For Occupancy
                                    </td>
                                    <td class="hi">
                                        Rental Rate TPer Sft
                                    </td>
                                    <td class="hi">
                                        Selling Rate TPer Sft
                                    </td>
                                    <td class="hi">
                                        Handover Time
                                    </td>
                                    <td class="hi">
                                        Survey Building Status
                                    </td>
                                    <td class="hi">
                                        Survey Source Information
                                    </td>
                                    <td class="hi">
                                        Source Person Information
                                    </td>
                                    <td class="hi">
                                        Contact Info
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Additional Remarks
                                    </td>
                                    <td class="hi">
                                        Others Remarks
                                    </td>
                                    <td class="hi">
                                        Survey Date
                                    </td>
                                    <td class="hi">
                                        Survey By
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
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
                                    <%# Eval("SurveyOwnerID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PlotAddress")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ApproximatePlotSize")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AreaUnitID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ApproximateFloorSizeSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Floors")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ApproximateTotalSpaceSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Basements")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NoOfCarParking")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ACSystem")%>
                                </td>
                                <td class="i">
                                    <%# Eval("GeneratorBackup")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LiftsCapacity")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ToiletsPerFloor")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AvailableFloorSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AvailableForOccupancy")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RentalRateBDTPerSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SellingRateBDTPerSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("HandoverTime")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SurveyBuildingStatusID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SurveySourceInformationID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SourcePersonInformation")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ContactInfo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AdditionalRemarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OthersRemarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SurveyDate") != null ? ((DateTime)Eval("SurveyDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SurveyByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SurveyID")%>' UniqueKey="CRMSurvey_lvCRMSurvey_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMSurvey?')"
                                        CommandArgument='<%#Eval("SurveyID")%>' UniqueKey="CRMSurvey_lvCRMSurvey_Edit_key" />
                                </td>
                                <%--<td class="i">
                                    <asp:HyperLink ID="hypSurveyReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                        CommandName="SurveyReport" CommandArgument='<%#Eval("SurveyID")%>' UniqueKey="CRMServey_lvCRMServey_SurveyReport_key"></asp:HyperLink>
                                </td>--%>
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
                                    <%# Eval("SurveyOwnerID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PlotAddress")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ApproximatePlotSize")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AreaUnitID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ApproximateFloorSizeSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Floors")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ApproximateTotalSpaceSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Basements")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NoOfCarParking")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ACSystem")%>
                                </td>
                                <td class="i">
                                    <%# Eval("GeneratorBackup")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LiftsCapacity")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ToiletsPerFloor")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AvailableFloorSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AvailableForOccupancy")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RentalRateBDTPerSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SellingRateBDTPerSft")%>
                                </td>
                                <td class="i">
                                    <%# Eval("HandoverTime")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SurveyBuildingStatusID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SurveySourceInformationID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SourcePersonInformation")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ContactInfo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AdditionalRemarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OthersRemarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SurveyDate") != null ? ((DateTime)Eval("SurveyDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SurveyByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SurveyID")%>' UniqueKey="CRMSurvey_lvCRMSurvey_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMSurvey?')"
                                        CommandArgument='<%#Eval("SurveyID")%>' UniqueKey="CRMSurvey_lvCRMSurvey_Edit_key" />
                                </td>
                                <%--<td class="i">
                                    <asp:HyperLink ID="hypSurveyReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                        CommandName="SurveyReport" CommandArgument='<%#Eval("SurveyID")%>' UniqueKey="CRMServey_lvCRMServey_SurveyReport_key"></asp:HyperLink>
                                </td>--%>
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
                <asp:ObjectDataSource ID="odsCRMSurvey" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMSurveyDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMSurvey_Selecting">
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
