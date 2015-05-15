<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 22-Jun-2013, 02:07:01
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectLift.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectLiftControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left; width: 200px;">
                    Total Number Of Lift&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <%--<label class="watermarkLabel" for="txtNumberOfLift">
                        Enter No. Of Lift</label>--%>
                    <asp:TextBox ID="txtNumberOfLift" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectLiftEntity" Width="27" />
                    <asp:DropDownList ID="ddlLifBrandID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlLifBrandID_SelectedIndexChanged" ValidationGroup="BDProjectLiftEntity" Width="88">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlLiftBrandSupplierID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectLiftEntity" Width="88">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvNumberOfLift" runat="server" ControlToValidate="txtNumberOfLift"
                        ErrorMessage="Please Enter Number Of Lift" ValidationGroup="BDProjectLiftEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvNumberOfLift" runat="server" ControlToValidate="txtNumberOfLift"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectLiftEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left; width: 200px;">
                    No. of Passenger Lift&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <%--<label class="watermarkLabel" for="txtNumberOfPassengerLift">
                        Enter No. Of Pas. Lift</label>--%>
                    <asp:TextBox ID="txtNumberOfPassengerLift" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectLiftEntity" Width="27" />
                    <asp:DropDownList ID="ddlPassengerLiftBrandID" CssClass="ktiSelect" ClientIDMode="Static"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlPassengerLiftBrandID_SelectedIndexChanged" runat="server" ValidationGroup="BDProjectLiftEntity" Width="88">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlPassengerLiftBrandSupplierID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectLiftEntity" Width="88">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvNumberOfPassengerLift" runat="server" ControlToValidate="txtNumberOfPassengerLift"
                        ErrorMessage="Please Enter Number Of Passenger Lift" ValidationGroup="BDProjectLiftEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RangeValidator ID="rvNumberOfPassengerLift" runat="server" ControlToValidate="txtNumberOfPassengerLift"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectLiftEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left; width: 200px;">
                    Capacity of Lift 1&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtCapacityOfPassengerLift" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectLiftEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvCapacityOfPassengerLift" runat="server" ControlToValidate="txtCapacityOfPassengerLift"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectLiftEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left; width: 200px;">
                    No. of Service Lift&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtNumberOfServiceLift" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectLiftEntity" Type="Number" Width="27" />
                    <asp:DropDownList ID="ddlServiceLiftBrandID" CssClass="ktiSelect" ClientIDMode="Static"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlServiceLiftBrandID_SelectedIndexChanged" runat="server" ValidationGroup="BDProjectLiftEntity" Width="88">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlServiceLiftBrandSupplierID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectLiftEntity" Width="88">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvNumberOfServiceLift" runat="server" ControlToValidate="txtNumberOfServiceLift"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectLiftEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left; width: 200px;">
                    Capacity of Lift 2&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtCapacityOfServiceLift" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectLiftEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvCapacityOfServiceLift" runat="server" ControlToValidate="txtCapacityOfServiceLift"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectLiftEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left; width: 200px;">
                    No. of Fire Fighter Lift&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtNumberOfFireFighterLift" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="BDProjectLiftEntity" Type="Number" Width="27" />
                    <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlBrandID_SelectedIndexChanged" ValidationGroup="BDProjectLiftEntity" Width="88">
                    </asp:DropDownList>
                    <asp:DropDownList ID="ddlBrandSupplierID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectLiftEntity" Width="88">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvNumberOfFireFighterLift" runat="server" ControlToValidate="txtNumberOfFireFighterLift"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="BDProjectLiftEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble" style="width: 200px;">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:Button ID="btnSubmit" ValidationGroup="BDProjectLiftEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="BDProjectLiftControl_Submit_key" />
                    <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear" UniqueKey="BDProjectLiftControl_Clear_key" />
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
