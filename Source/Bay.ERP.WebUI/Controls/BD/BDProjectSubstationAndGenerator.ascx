<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 22-Jun-2013, 02:07:01
--%>
<script language="javascript" type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#txtTotalNumberOfGenerator").change(function () {
                var cast = parseInt($("#txtTotalNumberOfGenerator").val());
                if(cast ==1)
                {
                    document.getElementById('div2').style.display = "none";
                }
            });
    }
</script>



<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectSubstationAndGenerator.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectSubstationAndGeneratorControl" %>

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
                    <div class="TableFormLeble" style="text-align: left; width:200px;">
                        Capacity of Substation&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCapacityOfSubstation">
                            Enter Capacity Of Substation</label>
                        <asp:TextBox ID="txtCapacityOfSubstation" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectSubstationAndGeneratorEntity" Width="175" />&nbsp;KVA
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCapacityOfSubstation" runat="server" ControlToValidate="txtCapacityOfSubstation"
                            ErrorMessage="Please Enter Capacity Of Substation" ValidationGroup="BDProjectSubstationAndGeneratorEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvCapacityOfSubstation" runat="server" ControlToValidate="txtCapacityOfSubstation" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectSubstationAndGeneratorEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left; width:200px;">
                        Total Number of Gen.&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTotalNumberOfGenerator">
                            Enter Total Number Of Generator</label>
                        <asp:TextBox ID="txtTotalNumberOfGenerator" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectSubstationAndGeneratorEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTotalNumberOfGenerator" runat="server" ControlToValidate="txtTotalNumberOfGenerator"
                            ErrorMessage="Please Enter Total Number Of Generator" ValidationGroup="BDProjectSubstationAndGeneratorEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvTotalNumberOfGenerator" runat="server" ControlToValidate="txtTotalNumberOfGenerator" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectSubstationAndGeneratorEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left; width:200px;">
                        Brand&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectSubstationAndGeneratorEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBrandID" runat="server" ControlToValidate="ddlBrandID"
                            ErrorMessage="Please Select Brand" ValidationGroup="BDProjectSubstationAndGeneratorEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div id="div1" class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left; width:200px;">
                        Capacity of Generator1&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCapacityOfGenerator1">
                            Enter Capacity Of Generator1</label>
                        <asp:TextBox ID="txtCapacityOfGenerator1" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectSubstationAndGeneratorEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCapacityOfGenerator1" runat="server" ControlToValidate="txtCapacityOfGenerator1"
                            ErrorMessage="Please Enter Capacity Of Generator1" ValidationGroup="BDProjectSubstationAndGeneratorEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvCapacityOfGenerator1" runat="server" ControlToValidate="txtCapacityOfGenerator1" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectSubstationAndGeneratorEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div id="div2" class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left; width:200px;">
                        Capacity of Generator2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCapacityOfGenerator2" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectSubstationAndGeneratorEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCapacityOfGenerator2" runat="server" ControlToValidate="txtCapacityOfGenerator2" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectSubstationAndGeneratorEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div id="div3" class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left; width:200px;">
                        Capacity of Generator3&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCapacityOfGenerator3" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectSubstationAndGeneratorEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCapacityOfGenerator3" runat="server" ControlToValidate="txtCapacityOfGenerator3" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectSubstationAndGeneratorEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div id="div4" class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left; width:200px;">
                        Capacity of Generator4&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCapacityOfGenerator4" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectSubstationAndGeneratorEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCapacityOfGenerator4" runat="server" ControlToValidate="txtCapacityOfGenerator4" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectSubstationAndGeneratorEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div id="div5" class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left; width:200px;">
                        Capacity of Generator5&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCapacityOfGenerator5" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectSubstationAndGeneratorEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCapacityOfGenerator5" runat="server" ControlToValidate="txtCapacityOfGenerator5" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectSubstationAndGeneratorEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble" style="width:200px;">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSubmit" ValidationGroup="BDProjectSubstationAndGeneratorEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="BDProjectSubstationAndGeneratorControl_Submit_key" />
                        <asp:Button ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="BDProjectSubstationAndGeneratorControl_Clear_key" />
                    </div>
                </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
