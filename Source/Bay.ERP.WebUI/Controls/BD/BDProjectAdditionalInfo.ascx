<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 22-Jun-2013, 02:07:01
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectAdditionalInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectAdditionalInfoControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Number Of Storey&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtNumberOfStorey">
                            Enter Number Of Storey</label>
                        <asp:TextBox ID="txtNumberOfStorey" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvNumberOfStorey" runat="server" ControlToValidate="txtNumberOfStorey"
                            ErrorMessage="Please Enter Number Of Storey" ValidationGroup="BDProjectAdditionalInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvNumberOfStorey" runat="server" ControlToValidate="txtNumberOfStorey" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Number Of Block&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNumberOfBlock" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNumberOfBlock" runat="server" ControlToValidate="txtNumberOfBlock" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Typical Floor Area&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtTypicalFloorArea" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Type="Number" Width="122" />
                            <asp:DropDownList ID="ddlTypicalFloorAreaUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Width="88">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvTypicalFloorArea" runat="server" ControlToValidate="txtTypicalFloorArea" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div
                <div style="display:none;">
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Ground Coverage Achieved&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtGCArchieved" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Type="Number" Width="210" />&nbsp;%
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvGCArchieved" runat="server" ControlToValidate="txtGCArchieved" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        No. of Basement&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNumberOfBasement" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNumberOfBasement" runat="server" ControlToValidate="txtNumberOfBasement" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        No. of Residential Floor&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox ID="txtNumberOfResidentialFloor" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Type="Number" Width="35" />&nbsp;Nos
                            <label class="watermarkLabel" for="txtPositionAtBuilding" style="padding-left: 103px; padding-top: 9px;">
                            Position at building</label>
                            <asp:TextBox ID="txtPositionAtBuilding" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="142" />
                    </div>
                    
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNumberOfResidentialFloor" runat="server" ControlToValidate="txtNumberOfResidentialFloor" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        No. of Commercial Floor&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:TextBox ID="txtNumberOfCommercialFloor" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Type="Number" Width="35" />&nbsp;Nos
                            <label class="watermarkLabel" for="txtPositionAtBuildingForCommercial" style="padding-left: 103px; padding-top: 9px;">
                            Position at building</label>
                            <asp:TextBox ID="txtPositionAtBuildingForCommercial" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="142" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNumberOfCommercialFloor" runat="server" ControlToValidate="txtNumberOfCommercialFloor" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        No. of Residential Unit/Floor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNoOfResidentialUnitPerFloor" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Type="Number" Width="210" />&nbsp;Nos
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNoOfResidentialUnitPerFloor" runat="server" ControlToValidate="txtNoOfResidentialUnitPerFloor" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Facing&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtFacing" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Total No. of Unit&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtTotalNumberOfUnit" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Type="Number" Width="210" />&nbsp;Nos
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvTotalNumberOfUnit" runat="server" ControlToValidate="txtTotalNumberOfUnit" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        No. of Penthouse&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNumberOfPenthouse" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Type="Number" Width="210" />&nbsp;Nos
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNumberOfPenthouse" runat="server" ControlToValidate="txtNumberOfPenthouse" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        No. of Stair&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNumberOfStair" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Type="Number" Width="210" />&nbsp;Nos
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNumberOfStair" runat="server" ControlToValidate="txtNumberOfStair" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectAdditionalInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Cooling System&nbsp;:
                    </div>
                    <div class="TableFormContent">
                    <asp:DropDownList ID="ddlCoolingSystemID" runat="server" CssClass="ktiSelect" ClientIDMode="Static"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="230" >
                            <asp:ListItem Value="0" Text="Please Select" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="Split AC" Text="Split AC"></asp:ListItem>
                        <asp:ListItem Value="Item 2" Text="Item 2"></asp:ListItem>
                        <asp:ListItem Value="Item 3" Text="Item 3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Geyser System&nbsp;:
                    </div>
                    <div class="TableFormContent">
                    <asp:DropDownList ID="ddlGeyserSystemID" runat="server" CssClass="ktiSelect" ClientIDMode="Static"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="230" >
                            <asp:ListItem Value="0" Text="Please Select" Selected="True"></asp:ListItem>
                        <asp:ListItem Value="Gas Geyser" Text="gas geyser"></asp:ListItem>
                        <asp:ListItem Value="Central Gas Geyser" Text="Central Gas Geyser"></asp:ListItem>
                        <asp:ListItem Value="electric geyser" Text="electric geyser"></asp:ListItem>
                        <asp:ListItem Value="Item 3" Text="Item 3"></asp:ListItem>
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Facilities at Mezzanine Floor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" ID="txtFacilitiesAtMezzanineFloor" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="300" Height="97"/>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Facilities at Roof Floor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" ID="txtFacilitiesAtRoofFloor" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="300" Height="97"/>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Ground Floor Height&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtGroundFloorHeight" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="122"/>
                            <asp:DropDownList ID="ddlGroundFloorHeightUnitInFeetID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Width="88">
                        </asp:DropDownList>
                         <asp:TextBox ID="txtGroundFloorHeightInch" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="122"/>
                            <asp:DropDownList ID="ddlGroundFloorHeightUnitInInchID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Width="88">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Typical Floor Height&nbsp;:
                    </div>
                    <div class="TableFormContent">
                    <asp:TextBox ID="txtTypicalFloorHeightFeet" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="122"/>
                            <asp:DropDownList ID="ddlTypicalFloorHeightUnitFeetID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Width="88">
                        </asp:DropDownList>
                        <asp:TextBox ID="txtTypicalFloorHeight" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="122"/>
                            <asp:DropDownList ID="ddlTypicalFloorHeightUnitInchID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectAdditionalInfoEntity" Width="88">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width:300px;">
                        Approval Required&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtApprovalRequired" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProjectAdditionalInfoEntity" Width="230" style="display:none;"/>
                       <asp:HyperLink ID="hypApprovalRequired" runat="server" CssClass="CommonButtonLink" Text="Click here for Approval" 
                    CommandName="ProjectReport" CommandArgument='<%#Eval("ProjectID")%>' UniqueKey="BDProjectListControl_lvBDProject_ProjectReport_key">
                    </asp:HyperLink>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble" style="width:300px;">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSubmit" ValidationGroup="BDProjectAdditionalInfoEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="BDProjectAdditionalInfoControl_Submit_key" />
                        <asp:Button ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="BDProjectAdditionalInfoControl_Clear_key" />
                    </div>
                </div>
                <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
