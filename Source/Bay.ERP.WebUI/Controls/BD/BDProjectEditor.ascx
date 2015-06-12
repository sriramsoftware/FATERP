<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-May-2015, 10:52:29
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectEditor.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectEditorControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Operator&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlOperatorID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectEntity" Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvOperatorID" runat="server" ControlToValidate="ddlOperatorID"
                        ErrorMessage="Please Select Operator" ValidationGroup="BDProjectEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Zone&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlZoneID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectEntity" Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvZoneID" runat="server" ControlToValidate="ddlZoneID"
                        ErrorMessage="Please Select Zone" ValidationGroup="BDProjectEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Project Code&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtProjectCode">
                        Enter Project Code</label>
                    <asp:TextBox ID="txtProjectCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="BDProjectEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvProjectCode" runat="server" ControlToValidate="txtProjectCode"
                        ErrorMessage="Please Enter Project Code" ValidationGroup="BDProjectEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Project Name&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtProjectName">
                        Enter Project Name</label>
                    <asp:TextBox ID="txtProjectName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="BDProjectEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvProjectName" runat="server" ControlToValidate="txtProjectName"
                        ErrorMessage="Please Enter Project Name" ValidationGroup="BDProjectEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <%--  <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Land Area Katha&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtLandAreaKatha" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvLandAreaKatha" runat="server" ControlToValidate="txtLandAreaKatha" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Land Area Sft&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtLandAreaSft" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvLandAreaSft" runat="server" ControlToValidate="txtLandAreaSft" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Road Width&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRoadWidth" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvRoadWidth" runat="server" ControlToValidate="txtRoadWidth" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Road Width Unit&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRoadWidthUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        No Of Storied&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNoOfStoried" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="BDProjectEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNoOfStoried" runat="server" ControlToValidate="txtNoOfStoried" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        No Of Basement&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNoOfBasement" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                            ValidationGroup="BDProjectEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvNoOfBasement" runat="server" ControlToValidate="txtNoOfBasement" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)" MinimumValue="-2147483648" MaximumValue="2147483647"
                            Type="Integer" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>--%>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Description&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtDescription" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="BDProjectEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    BSC&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtBSC" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="BDProjectEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <%-- <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Client Percentage&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtClientPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvClientPercentage" runat="server" ControlToValidate="txtClientPercentage" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>--%>
            <div class="TableRow" style="width: 100; display: none;">
                <div class="TableFormLeble" style="text-align: right;">
                    Company Percentage&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtCompanyPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        Text="0" runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvCompanyPercentage" runat="server" ControlToValidate="txtCompanyPercentage"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Project Category&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectEntity" Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvProjectCategoryID" runat="server" ControlToValidate="ddlProjectCategoryID"
                        ErrorMessage="Please Select Project Category" ValidationGroup="BDProjectEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Project Status&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectEntity" Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvProjectStatusID" runat="server" ControlToValidate="ddlProjectStatusID"
                        ErrorMessage="Please Select Project Status" ValidationGroup="BDProjectEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100; display: none;">
                <div class="TableFormLeble" style="text-align: right;">
                    Is Removed&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="BDProjectEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:Button ID="btnSubmit" ValidationGroup="BDProjectEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="BDProjectControl_Submit_key" />
          
                    <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="BDProjectControl_Clear_key" />
                </div>
            </div>
            <br />
        </div>
        </div> </div>
    </ContentTemplate>
</asp:UpdatePanel>
