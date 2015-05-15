<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectEditor.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectEditorControl" %>

    <script language="javascript" type="text/javascript">
        function BindEvents() {
            $(document).ready(function () {
                $("#txtLandAreaKatha").keyup(function () {
                    $("#txtLandAreaSft").val($(this).val() * 720);
                });
            });
        }
        </script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
       <script type="text/javascript">
           Sys.Application.add_load(BindEvents);
        </script>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Project Code&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtProjectCode">
                        Enter Project Code</label>
                    <asp:TextBox ID="txtProjectCode" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                        runat="server" ValidationGroup="BDProjectEntity" Width="210" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvProjectCode" runat="server" ControlToValidate="txtProjectCode"
                        ErrorMessage="Please Enter Project Code" ValidationGroup="BDProjectEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
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
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble">
                    Land Area Katha&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <%--<label class="watermarkLabel" for="txtLandAreaKatha">
                        Enter Build Area Katha</label>--%>
                    <asp:TextBox ID="txtLandAreaKatha" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvLandAreaKatha" runat="server" ControlToValidate="txtLandAreaKatha"
                        ErrorMessage="Please Enter Land Area Katha" ValidationGroup="BDProjectEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvLandAreaKatha" runat="server" ControlToValidate="txtLandAreaKatha"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble">
                    Land Area Sft&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                   <%-- <label class="watermarkLabel" for="txtLandAreaSft">
                        Enter Build Area Sft</label>--%>
                    <asp:TextBox ID="txtLandAreaSft" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvLandAreaSft" runat="server" ControlToValidate="txtLandAreaSft"
                        ErrorMessage="Please Enter Land Area Sft" ValidationGroup="BDProjectEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvLandAreaSft" runat="server" ControlToValidate="txtLandAreaSft"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                </div>
            </div>
             <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align:left;">
                        Road Width&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRoadWidth" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="122" />
                           <asp:DropDownList ID="ddlRoadWidthUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectEntity" Width="80">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvRoadWidth" runat="server" ControlToValidate="txtRoadWidth" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                    </div>
                </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble">
                    Number Of Storey&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtNoOfStoried">
                        Enter Number Of Storey</label>
                    <asp:TextBox ID="txtNoOfStoried" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                        ValidationGroup="BDProjectEntity" Width="210" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvNoOfStoried" runat="server" ControlToValidate="txtNoOfStoried"
                        ErrorMessage="Please Enter No Of Storied" ValidationGroup="BDProjectEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvNoOfStoried" runat="server" ControlToValidate="txtNoOfStoried"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                        MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble">
                    Number Of Basement&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtNoOfBasement">
                        Enter Number Of Basement</label>
                    <asp:TextBox ID="txtNoOfBasement" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                        ValidationGroup="BDProjectEntity" Width="210" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvNoOfBasement" runat="server" ControlToValidate="txtNoOfBasement"
                        ErrorMessage="Please Enter No Of Basement" ValidationGroup="BDProjectEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvNoOfBasement" runat="server" ControlToValidate="txtNoOfBasement"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                        MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Description&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" ID="txtDescription" ClientIDMode="Static" CssClass="ktiTextArea" Width="390" Height="97" runat="server"
                        ValidationGroup="BDProjectEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div style="display:none">
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Client Percentage&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtClientPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvClientPercentage" runat="server" ControlToValidate="txtClientPercentage"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Company Percentage&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtCompanyPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvCompanyPercentage" runat="server" ControlToValidate="txtCompanyPercentage"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectEntity"></asp:RangeValidator>
                </div>
            </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypProjectCategory" runat="server"
                        Text="Project Category" NavigateUrl="~/MD/MDProjectCategory.aspx" Target="_blank"></asp:HyperLink>
                    &nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectEntity" Width="236">
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
                <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypProjectStatus" runat="server"
                        Text="Project Status" NavigateUrl="~/MD/MDProjectStatus.aspx" Target="_blank"></asp:HyperLink>
                    &nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectEntity" Width="236">
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
                <div class="TableFormLeble" style="text-align: left;">
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
                        runat="server" Text="Add" UniqueKey="BDProjectEditorControl_Submit_key" />
                    <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="BDProjectEditorControl_Clear_key" />
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
