<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 01-Apr-2013, 03:04:35
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectFloorUnit.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectFloorUnitControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <Triggers>
        <asp:PostBackTrigger ControlID="btnSubmit" />
    </Triggers>
    <ContentTemplate>
        <asp:Panel ID="pnlProjectFloorUnitContent" runat="server">
            <div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div style="width: 500px; float: left;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Project Floor&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlProjectFloorID" CssClass="ktiSelect" ClientIDMode="Static"
                                AutoPostBack="true" OnSelectedIndexChanged="ddlProjectFloorID_SelectedIndexChanged"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvProjectFloorID" runat="server" ControlToValidate="ddlProjectFloorID"
                                ErrorMessage="Please Select Project Floor" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Unit Type&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlProjectFloorUnitTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvProjectFloorUnitTypeID" runat="server" ControlToValidate="ddlProjectFloorUnitTypeID"
                                ErrorMessage="Please Select Project Floor Unit Type" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Unit Name&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtProjectFloorUnitName">
                                Enter Project Floor Unit Name</label>
                            <asp:TextBox ID="txtProjectFloorUnitName" ClientIDMode="Static" CssClass="ktiTextBox"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="230" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvProjectFloorUnitName" runat="server" ControlToValidate="txtProjectFloorUnitName"
                                ErrorMessage="Please Enter Project Floor Unit Name" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Unit Status&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlProjectFloorUnitStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvProjectFloorUnitStatusID" runat="server" ControlToValidate="ddlProjectFloorUnitStatusID"
                                ErrorMessage="Please Select Project Floor Unit Status" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Net Area&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtUnitArea">
                                Enter Unit Area</label>
                            <asp:TextBox ID="txtUnitArea" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvUnitArea" runat="server" ControlToValidate="txtUnitArea"
                                ErrorMessage="Please Enter Unit Area" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvUnitArea" runat="server" ControlToValidate="txtUnitArea"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Salable Area&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtTotalArea">
                                Enter Total Area</label>
                            <asp:TextBox ID="txtTotalArea" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvTotalArea" runat="server" ControlToValidate="txtTotalArea"
                                ErrorMessage="Please Enter Total Area" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvTotalArea" runat="server" ControlToValidate="txtTotalArea"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Registered Area&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtRegisteredArea" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Type="Number" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvRegisteredArea" runat="server" ControlToValidate="txtRegisteredArea"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Facing&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtFacing">
                                Enter Facing</label>
                            <asp:TextBox ID="txtFacing" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ValidationGroup="BDProjectFloorUnitEntity" Width="230" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvFacing" runat="server" ControlToValidate="txtFacing"
                                ErrorMessage="Please Enter Facing" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100; display: none;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Toilet&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtToilet">
                                Enter Toilet</label>
                            <asp:TextBox ID="txtToilet" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvToilet" runat="server" ControlToValidate="txtToilet"
                                ErrorMessage="Please Enter Toilet" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvToilet" runat="server" ControlToValidate="txtToilet" Display="Dynamic"
                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Kitchen&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtKitchen">
                                Enter Kitchen</label>
                            <asp:TextBox ID="txtKitchen" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvKitchen" runat="server" ControlToValidate="txtKitchen"
                                ErrorMessage="Please Enter Kitchen" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvKitchen" runat="server" ControlToValidate="txtKitchen"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Parking&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtParking">
                                Enter Parking</label>
                            <asp:TextBox ID="txtParking" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvParking" runat="server" ControlToValidate="txtParking"
                                ErrorMessage="Please Enter Parking" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvParking" runat="server" ControlToValidate="txtParking"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Bath Room&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtBathRoom">
                                Enter Bath Room</label>
                            <asp:TextBox ID="txtBathRoom" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvBathRoom" runat="server" ControlToValidate="txtBathRoom"
                                ErrorMessage="Please Enter Bath Room" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvBathRoom" runat="server" ControlToValidate="txtBathRoom"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Bed Room&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtBedRoom">
                                Enter Bed Room</label>
                            <asp:TextBox ID="txtBedRoom" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvBedRoom" runat="server" ControlToValidate="txtBedRoom"
                                ErrorMessage="Please Enter Bed Room" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvBedRoom" runat="server" ControlToValidate="txtBedRoom"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Servant Bed&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtServantBed">
                                Enter Servant Bed</label>
                            <asp:TextBox ID="txtServantBed" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvServantBed" runat="server" ControlToValidate="txtServantBed"
                                ErrorMessage="Please Enter Servant Bed" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvServantBed" runat="server" ControlToValidate="txtServantBed"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Servant Toilet&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtServantToilet">
                                Enter Servant Toilet</label>
                            <asp:TextBox ID="txtServantToilet" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvServantToilet" runat="server" ControlToValidate="txtServantToilet"
                                ErrorMessage="Please Enter Servant Toilet" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvServantToilet" runat="server" ControlToValidate="txtServantToilet"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Corridor&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtCorridor">
                                Enter Corridor</label>
                            <asp:TextBox ID="txtCorridor" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvCorridor" runat="server" ControlToValidate="txtCorridor"
                                ErrorMessage="Please Enter Corridor" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvCorridor" runat="server" ControlToValidate="txtCorridor"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Terrace Garden&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtTapasGarden">
                                Enter Tapas Garden</label>
                            <asp:TextBox ID="txtTapasGarden" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvTapasGarden" runat="server" ControlToValidate="txtTapasGarden"
                                ErrorMessage="Please Enter Tapas Garden" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvTapasGarden" runat="server" ControlToValidate="txtTapasGarden"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Swimming Pool&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtSwimmingPool">
                                Enter Swimming Pool</label>
                            <asp:TextBox ID="txtSwimmingPool" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvSwimmingPool" runat="server" ControlToValidate="txtSwimmingPool"
                                ErrorMessage="Please Enter Swimming Pool" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvSwimmingPool" runat="server" ControlToValidate="txtSwimmingPool"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Foyer&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtFoyer">
                                Foyer</label>
                            <asp:TextBox ID="txtFoyer" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtFoyer"
                                ErrorMessage="Please Enter Swimming Pool" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtFoyer"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Sitting Room&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtSittingRoom">
                                Sitting Room</label>
                            <asp:TextBox ID="txtSittingRoom" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtSittingRoom"
                                ErrorMessage="Please Enter Swimming Pool" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator2" runat="server" ControlToValidate="txtSittingRoom"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Dining Room&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtDiningRoom">
                                Dining Room</label>
                            <asp:TextBox ID="txtDiningRoom" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="txtDiningRoom"
                                ErrorMessage="Please Enter Swimming Pool" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator3" runat="server" ControlToValidate="txtDiningRoom"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Pantry&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtPantry">
                                Pantry</label>
                            <asp:TextBox ID="txtPantry" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="txtPantry"
                                ErrorMessage="Please Enter Swimming Pool" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator4" runat="server" ControlToValidate="txtPantry"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Breakfast Corner&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtBreakfastCorner">
                                Breakfast Corner</label>
                            <asp:TextBox ID="txtBreakfastCorner" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator5" runat="server" ControlToValidate="txtBreakfastCorner"
                                ErrorMessage="Please Enter Swimming Pool" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator5" runat="server" ControlToValidate="txtBreakfastCorner"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;display:none;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Study Room&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer" >
                            <label class="watermarkLabel" for="txtStudyRoom">
                                Study Room</label>
                            <asp:TextBox ID="txtStudyRoom" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator6" runat="server" ControlToValidate="txtStudyRoom"
                                ErrorMessage="Please Enter Swimming Pool" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator6" runat="server" ControlToValidate="txtStudyRoom"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Study&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtStudy">
                                Study</label>
                            <asp:TextBox ID="txtStudy" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator7" runat="server" ControlToValidate="txtStudy"
                                ErrorMessage="Please Enter Swimming Pool" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator7" runat="server" ControlToValidate="txtStudy"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Verandah&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtVerandah">
                                Verandah</label>
                            <asp:TextBox ID="txtVerandah" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectFloorUnitEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="RequiredFieldValidator8" runat="server" ControlToValidate="txtVerandah"
                                ErrorMessage="Please Enter Swimming Pool" ValidationGroup="BDProjectFloorUnitEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="RangeValidator8" runat="server" ControlToValidate="txtVerandah"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Gas Supply Available&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkIsIDServiceAvailable" runat="server" ClientIDMode="Static" ValidationGroup="BDProjectFloorUnitEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Electricity Supply available&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkElectricityService" runat="server" ClientIDMode="Static" ValidationGroup="BDProjectFloorUnitEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Common Generator&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkCommonGenerator" runat="server" ClientIDMode="Static" ValidationGroup="BDProjectFloorUnitEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Water Supply Available&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkWaterSupplyAvailable" runat="server" ClientIDMode="Static" ValidationGroup="BDProjectFloorUnitEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div style="display: none">
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right; width: 195px;">
                                Price Per Sft&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtPricePerSft" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                    runat="server" ValidationGroup="BDProjectFloorUnitEntity" Type="Number" Width="210" />
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RangeValidator ID="rvPricePerSft" runat="server" ControlToValidate="txtPricePerSft"
                                    Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                    MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                    Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right; width: 195px;">
                                Area Price&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtAreaPrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                    runat="server" ValidationGroup="BDProjectFloorUnitEntity" Type="Number" Width="210" />
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RangeValidator ID="rvAreaPrice" runat="server" ControlToValidate="txtAreaPrice"
                                    Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                    MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                    Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right; width: 195px;">
                                Price&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtIDPrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                    ValidationGroup="BDProjectFloorUnitEntity" Type="Number" Width="210" />
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RangeValidator ID="rvIDPrice" runat="server" ControlToValidate="txtIDPrice"
                                    Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                    MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                    Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right; width: 195px;">
                                Additional Charges&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtAdditionalCharges" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                    runat="server" ValidationGroup="BDProjectFloorUnitEntity" Type="Number" Width="210" />
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RangeValidator ID="rvAdditionalCharges" runat="server" ControlToValidate="txtAdditionalCharges"
                                    Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                    MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                    Type="Double" ValidationGroup="BDProjectFloorUnitEntity"></asp:RangeValidator>
                            </div>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Features&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                ID="txtFeatures" runat="server" ValidationGroup="BDProjectFloorUnitEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Civil Drawing&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:FileUpload ID="fuCivilDrawingImageUrl" ClientIDMode="Static" runat="server"
                                Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Electrical Drawing&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:FileUpload ID="fuElectricalDrawingImageUrl" ClientIDMode="Static" runat="server"
                                Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Interior Drawing&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:FileUpload ID="fuInteriorDrawingImageUrl" ClientIDMode="Static" runat="server"
                                Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Mechanical Drawing&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:FileUpload ID="fuMechanicalDrawingImageUrl" ClientIDMode="Static" runat="server"
                                Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Plumbing Drawing&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:FileUpload ID="fuPlumbingDrawingImageUrl" ClientIDMode="Static" runat="server"
                                Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Others Drawing&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:FileUpload ID="fuOthersDrawingImageUrl" ClientIDMode="Static" runat="server"
                                Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100; display: none;">
                        <div class="TableFormLeble" style="text-align: right; width: 195px;">
                            Is Removed&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="BDProjectFloorUnitEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="text-align: center;">
                        <div class="TableFormLeble" style="width: 195px;">
                            &nbsp;</div>
                        <div class="TableFormContent">
                            <asp:Button ID="btnSubmit" ValidationGroup="BDProjectFloorUnitEntity" OnClick="btnSave_Click"
                                runat="server" Text="Add" UniqueKey="BDProjectFloorUnitControl_Submit_key" />
                            <asp:Button ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                                Text="Add New" UniqueKey="BDProjectFloorUnitControl_AddNew_key" />
                            <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear" UniqueKey="BDProjectFloorUnitControl_Clear_key" />
                        </div>
                    </div>
                    <br />
                </div>
                <div style="float: left; width: 470px;">
                    <div>
                        <div class="lv-c">
                            <asp:ListView ID="lvProjectFloorUnitFloorwise" runat="server" DataSourceID="odsProjectFloorUnitFloorwise">
                                <LayoutTemplate>
                                    <table class="lv" cellpadding="0" cellspacing="0">
                                        <tr class="h">
                                            <td class="rp">
                                                &nbsp;
                                            </td>
                                            <td class="hi" style="display: none">
                                                Unit Type
                                            </td>
                                            <td class="hi">
                                                Unit
                                            </td>
                                            <td class="hi" style="display: none">
                                                Unit Status
                                            </td>
                                            <td class="hi">
                                                Unit Area
                                            </td>
                                            <td class="hi">
                                                Total Area
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
                                    </table>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <tr class="r">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="i" style="display: none">
                                            <%# Eval("ProjectFloorUnitTypeID")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("ProjectFloorUnitName")%>
                                        </td>
                                        <td class="i" style="display: none">
                                            <%# Eval("ProjectFloorUnitStatusID")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("UnitArea")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("TotalArea")%>
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
                                        <td class="i" style="display: none">
                                            <%# Eval("ProjectFloorUnitTypeID")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("ProjectFloorUnitName")%>
                                        </td>
                                        <td class="i" style="display: none">
                                            <%# Eval("ProjectFloorUnitStatusID")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("UnitArea")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("TotalArea")%>
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
                            <asp:ObjectDataSource ID="odsProjectFloorUnitFloorwise" runat="server" SelectMethod="GetPagedData"
                                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.BDProjectFloorUnitDataSource"
                                SortParameterName="sortExpression" OnSelecting="odsProjectFloorUnitFloorwise_Selecting">
                                <SelectParameters>
                                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                                    <asp:Parameter Name="pageSize" Type="Int32" />
                                    <asp:Parameter Name="sortExpression" Type="String" />
                                    <asp:Parameter Name="filterExpression" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </div>
                    </div>
                </div>
                <div style="clear: both;">
                </div>
                <div class="listContentTitle">
                    Project Floor Unit List
                </div>
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvBDProjectFloorUnit" runat="server" DataSourceID="odsBDProjectFloorUnit"
                            OnItemCommand="lvBDProjectFloorUnit_ItemCommand" OnItemDataBound="lvBDProjectFloorUnit_ItemDataBound">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="hi">
                                            Project Floor
                                        </td>
                                        <td class="hi">
                                            Project Floor Unit Type
                                        </td>
                                        <td class="hi">
                                            Project Floor Unit Name
                                        </td>
                                        <td class="hi">
                                            Project Floor Unit Status
                                        </td>
                                        <td class="hi" style="width: 150px;">
                                            Area
                                        </td>
                                        <td class="hi" style="width: 150px;">
                                            Other Info
                                        </td>
                                        <td class="hi" style="width: 150px;">
                                            Services Available
                                        </td>
                                        <td class="his">
                                            EDIT
                                        </td>
                                        <td class="his">
                                            DELETE
                                        </td>
                                        <td class="his">
                                            Report
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
                                        <%# Eval("ProjectFloorName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ProjectFloorUnitTypeName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ProjectFloorUnitName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ProjectFloorUnitStatusName")%>
                                    </td>
                                    <td class="i">
                                        <b>Unit Area:</b>
                                        <%# Eval("UnitArea")%>
                                        <br />
                                        <b>Total Area:</b>
                                        <%# Eval("TotalArea")%>
                                    </td>
                                    <td class="i">
                                        <b>Facing:</b>
                                        <%# Eval("Facing")%>
                                        <br />
                                        <b>Kitchen:</b>
                                        <%# Eval("Kitchen", "{0}")%>
                                        <br />
                                        <b>Parking:</b>
                                        <%# Eval("Parking", "{0}")%>
                                        <br />
                                        <b>BathRoom:</b>
                                        <%# Eval("BathRoom", "{0}")%>
                                        <br />
                                        <b>BedRoom:</b>
                                        <%# Eval("BedRoom", "{0}")%>
                                        <br />
                                        <b>ServantBed:</b>
                                        <%# Eval("ServantBed", "{0}")%>
                                        <br />
                                        <b>ServantToilet:</b>
                                        <%# Eval("ServantToilet", "{0}")%>
                                        <br />
                                        <b>Corridor:</b>
                                        <%# Eval("Corridor", "{0}")%>
                                        <br />
                                        <b>TapasGarden:</b>
                                        <%# Eval("TapasGarden", "{0}")%>
                                        <br />
                                        <b>SwimmingPool</b>:
                                        <%# Eval("SwimmingPool", "{0}")%>
                                        <br />
                                        <b>Foyer</b>:
                                        <%# Eval("Foyer", "{0:F0}")%>
                                        <br />
                                        <b>Sitting Room</b>:
                                        <%# Eval("SittingRoom", "{0:F0}")%>
                                        <br />
                                        <b>Dining Room</b>:
                                        <%# Eval("DiningRoom", "{0:F0}")%>
                                        <br />
                                        <b>Pantry</b>:
                                        <%# Eval("Pantry", "{0:F0}")%>
                                        <br />
                                        <b>Breakfast Corner</b>:
                                        <%# Eval("SwimmingPool", "{0}")%>
                                        <br />
                                        <b>Study Room</b>:
                                        <%# Eval("StudyRoom", "{0:F0}")%>
                                        <br />
                                        <b>Study</b>:
                                        <%# Eval("Study", "{0:F0}")%>
                                        <br />
                                        <b>Verandah</b>:
                                        <%# Eval("Verandah", "{0:F0}")%>
                                    </td>
                                    <td class="i">
                                        <b>Gas Supply Available:</b>
                                        <%# Eval("IsIDServiceAvailable") != null ? (((Boolean)Eval("IsIDServiceAvailable")) ? "Yes" : "No") : ""%>
                                        <br />
                                        <b>Electricity:</b>
                                        <%# Eval("ElectricityService") != null ? (((Boolean)Eval("ElectricityService")) ? "Yes" : "No") : ""%>
                                        <br />
                                        <b>Common Generator:</b>
                                        <%# Eval("CommonGenerator") != null ? (((Boolean)Eval("CommonGenerator")) ? "Yes" : "No") : ""%>
                                        <b>Water Supply Available:</b>
                                        <%# Eval("WaterSupplyAvailable") != null ? (((Boolean)Eval("WaterSupplyAvailable")) ? "Yes" : "No") : ""%>
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ProjectFloorUnitID")%>'
                                            UniqueKey="BDProjectFloorUnit_lvBDProjectFloorUnit_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Project Floor Unit?')"
                                            CommandArgument='<%#Eval("ProjectFloorUnitID")%>' UniqueKey="BDProjectFloorUnit_lvBDProjectFloorUnit_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <asp:HyperLink ID="hypProjectFloorUnitReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                            CommandName="ProjectFloorUnitReport" CommandArgument='<%#Eval("ProjectFloorUnitID")%>' UniqueKey="BDProjectFloorUnit_lvProjectFloorUnit_ProjectFloorUnitReport_key"></asp:HyperLink>
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
                                        <%# Eval("ProjectFloorName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ProjectFloorUnitTypeName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ProjectFloorUnitName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ProjectFloorUnitStatusName")%>
                                    </td>
                                    <td class="i">
                                        <b>Unit Area:</b>
                                        <%# Eval("UnitArea")%>
                                        <br />
                                        <b>Total Area:</b>
                                        <%# Eval("TotalArea")%>
                                    </td>
                                    <td class="i">
                                        <b>Facing:</b>
                                        <%# Eval("Facing")%>
                                        <br />
                                        <b>Kitchen:</b>
                                        <%# Eval("Kitchen", "{0}")%>
                                        <br />
                                        <b>Parking:</b>
                                        <%# Eval("Parking", "{0}")%>
                                        <br />
                                        <b>BathRoom:</b>
                                        <%# Eval("BathRoom", "{0}")%>
                                        <br />
                                        <b>BedRoom:</b>
                                        <%# Eval("BedRoom", "{0}")%>
                                        <br />
                                        <b>ServantBed:</b>
                                        <%# Eval("ServantBed", "{0}")%>
                                        <br />
                                        <b>ServantToilet:</b>
                                        <%# Eval("ServantToilet", "{0}")%>
                                        <br />
                                        <b>Corridor:</b>
                                        <%# Eval("Corridor", "{0}")%>
                                        <br />
                                        <b>TapasGarden:</b>
                                        <%# Eval("TapasGarden", "{0}")%>
                                        <br />
                                        <b>SwimmingPool</b>:
                                        <%# Eval("SwimmingPool", "{0}")%>
                                        <br />
                                        <b>Foyer</b>:
                                        <%# Eval("Foyer", "{0:F0}")%>
                                        <br />
                                        <b>Sitting Room</b>:
                                        <%# Eval("SittingRoom", "{0:F0}")%>
                                        <br />
                                        <b>Dining Room</b>:
                                        <%# Eval("DiningRoom", "{0:F0}")%>
                                        <br />
                                        <b>Pantry</b>:
                                        <%# Eval("Pantry", "{0:F0}")%>
                                        <br />
                                        <b>Breakfast Corner</b>:
                                        <%# Eval("SwimmingPool", "{0}")%>
                                        <br />
                                        <b>Study Room</b>:
                                        <%# Eval("StudyRoom", "{0:F0}")%>
                                        <br />
                                        <b>Study</b>:
                                        <%# Eval("Study", "{0:F0}")%>
                                        <br />
                                        <b>Verandah</b>:
                                        <%# Eval("Verandah", "{0:F0}")%>
                                    </td>
                                    <br />
                                    <td class="i">
                                        <b>Gas Supply Available:</b>
                                        <%# Eval("IsIDServiceAvailable") != null ? (((Boolean)Eval("IsIDServiceAvailable")) ? "Yes" : "No") : ""%>
                                        <br />
                                        <b>Electricity:</b>
                                        <%# Eval("ElectricityService") != null ? (((Boolean)Eval("ElectricityService")) ? "Yes" : "No") : ""%>
                                        <br />
                                        <b>Common Generator:</b>
                                        <%# Eval("CommonGenerator") != null ? (((Boolean)Eval("CommonGenerator")) ? "Yes" : "No") : ""%>
                                        <b>Water Supply Available:</b>
                                        <%# Eval("WaterSupplyAvailable") != null ? (((Boolean)Eval("WaterSupplyAvailable")) ? "Yes" : "No") : ""%>
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ProjectFloorUnitID")%>'
                                            UniqueKey="BDProjectFloorUnit_lvBDProjectFloorUnit_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Project Floor Unit?')"
                                            CommandArgument='<%#Eval("ProjectFloorUnitID")%>' UniqueKey="BDProjectFloorUnit_lvBDProjectFloorUnit_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <asp:HyperLink ID="hypProjectFloorUnitReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                            CommandName="ProjectFloorUnitReport" CommandArgument='<%#Eval("ProjectFloorUnitID")%>' UniqueKey="BDProjectFloorUnit_lvProjectFloorUnit_ProjectFloorUnitReport_key"></asp:HyperLink>
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
                    <asp:ObjectDataSource ID="odsBDProjectFloorUnit" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.BDProjectFloorUnit_DetailedDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsBDProjectFloorUnit_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
            </div>
        </asp:Panel>
    </ContentTemplate>
</asp:UpdatePanel>
