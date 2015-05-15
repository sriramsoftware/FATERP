<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectOtherInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectOtherInfoControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;width: 300px;">
                    Floor Area Ratio Basic&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtFAR" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectOtherInfoEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvFAR" runat="server" ControlToValidate="txtFAR" Display="Dynamic"
                        EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                        MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="BDProjectOtherInfoEntity"></asp:RangeValidator>
                </div>
            </div>
             <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width: 300px;">
                        Floor Area Ratio Bonus&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtFARBonus" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectOtherInfoEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvFARBonus" runat="server" ControlToValidate="txtFARBonus" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectOtherInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;width: 300px;">
                    FIA Limit&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtFIA" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectOtherInfoEntity" Type="Number" Width="122" />
                        <asp:DropDownList ID="ddlFIAUnitID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectOtherInfoEntity" Width="88">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvFIA" runat="server" ControlToValidate="txtFIA" Display="Dynamic"
                        EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                        MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="BDProjectOtherInfoEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width: 300px;">
                        FIA Achieved&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtFIAAchieved" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectOtherInfoEntity" Type="Number" Width="122" />
                            <asp:DropDownList ID="ddlFIAAchievedUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectOtherInfoEntity" Width="88">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvFIAAchieved" runat="server" ControlToValidate="txtFIAAchieved" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectOtherInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width: 300px;">
                        Maximum Ground Coverage &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMGCPercentages" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectOtherInfoEntity" Type="Number" Width="210" />&nbsp;%
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvMGCPercentages" runat="server" ControlToValidate="txtMGCPercentages" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectOtherInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;width: 300px;">
                        Maximum Ground Coverage Area&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMGCArea" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectOtherInfoEntity" Type="Number" Width="122" />
                             <asp:DropDownList ID="ddlMGCAreaUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProjectOtherInfoEntity" Width="88">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvMGCArea" runat="server" ControlToValidate="txtMGCArea" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="BDProjectOtherInfoEntity"></asp:RangeValidator>
                    </div>
                </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;width: 300px;">
                    Salable Area&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtGSA" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectOtherInfoEntity" Type="Number" Width="122" />
                         <asp:DropDownList ID="ddlGSAUnitID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectOtherInfoEntity" Width="88">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvGSA" runat="server" ControlToValidate="txtGSA" Display="Dynamic"
                        EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                        MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="BDProjectOtherInfoEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;width: 300px;">
                    Ground Coverage Achieved&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtGroundCoverage" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="BDProjectOtherInfoEntity" Width="230" />&nbsp;%
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;width: 300px;">
                    Total Built Area&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtTBA" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectOtherInfoEntity" Type="Number" Width="122" />
                          <asp:DropDownList ID="ddlTBAUnitID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="BDProjectOtherInfoEntity" Width="88">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvTBA" runat="server" ControlToValidate="txtTBA" Display="Dynamic"
                        EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                        MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="BDProjectOtherInfoEntity"></asp:RangeValidator>
                </div>
            </div>

            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;width: 300px;">
                    Date Of Agreement&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtDateOfAgreement" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="BDProjectOtherInfoEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revDateOfAgreement" runat="server" ControlToValidate="txtDateOfAgreement"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="BDProjectOtherInfoEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;width: 300px;">
                    Date Of Handover&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtDateOfHandover" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="BDProjectOtherInfoEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revDateOfHandover" runat="server" ControlToValidate="txtDateOfHandover"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="BDProjectOtherInfoEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;width: 300px;">
                    Delay Clause&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105" ClientIDMode="Static"
                        ID="txtDelayClause" runat="server" ValidationGroup="BDProjectOtherInfoEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble" style="width:300px;">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:Button ID="btnSubmit" ValidationGroup="BDProjectOtherInfoEntity" OnClick="btnSave_Click"
                        runat="server" Text="Add" UniqueKey="BDProjectOtherInfoControl_Submit_key" />
                    <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="BDProjectOtherInfoControl_Clear_key" />
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
