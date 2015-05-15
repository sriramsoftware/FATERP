<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Apr-2013, 04:59:58
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMPaymentSchedule.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMPaymentScheduleControl" %>

    <script type="text/javascript">
        $("[id*=txtAgreementAAmountLV]").live("change", function () {
            if (isNaN(parseInt($(this).val()))) {
                $(this).val('0');
            } else {
                $(this).val(parseFloat($(this).val()).toString());
            }
        });
        $("[id*=txtAgreementAAmountLV]").live("keyup", function () {
            if (!jQuery.trim($(this).val()) == '') {
                if (!isNaN(parseFloat($(this).val()))) {
                    var agreementB = $(this).closest("tr").find('#txtAgreementBAmountLV').val();
                    var agreementC = $(this).closest("tr").find('#txtAgreementCAmountLV').val();
                    $(this).closest("tr").find('#txtTotalLV').val(parseFloat($(this).val()) + parseFloat(agreementB) + parseFloat(agreementC));
                }
            } else {
                $(this).val('');
            }
            });
              $("[id*=txtAgreementBAmountLV]").live("keyup", function () {
            if (!jQuery.trim($(this).val()) == '') {
                if (!isNaN(parseFloat($(this).val()))) {
                    var agreementA = $(this).closest("tr").find('#txtAgreementAAmountLV').val();
                    var agreementC = $(this).closest("tr").find('#txtAgreementCAmountLV').val();
                    $(this).closest("tr").find('#txtTotalLV').val(parseFloat($(this).val()) + parseFloat(agreementA) + parseFloat(agreementC));
                }
            } else {
                $(this).val('');
            }
        });
              $("[id*=txtAgreementCAmountLV]").live("keyup", function () {
            if (!jQuery.trim($(this).val()) == '') {
                if (!isNaN(parseFloat($(this).val()))) {
                    var agreementA = $(this).closest("tr").find('#txtAgreementAAmountLV').val();
                    var agreementB = $(this).closest("tr").find('#txtAgreementBAmountLV').val();
                    $(this).closest("tr").find('#txtTotalLV').val(parseFloat($(this).val()) + parseFloat(agreementA) + parseFloat(agreementB));
                }
            } else {
                $(this).val('');
                        }
});
            //            var grandTotal = 0;
            //            $("[id*=lblTotal]").each(function () {
            //                grandTotal = grandTotal + parseFloat($(this).html());
            //            });
            //            $("[id*=lblGrandTotal]").html(grandTotal.toString());
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
            <div class="TableRow" style="width: 100; display:none;">
                <div class="TableFormLeble" style="text-align: right;">
                    Agreement&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlAgreementID" CssClass="ktiSelect" ClientIDMode="Static"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlAgreementID_SelectedIndexChanged"
                        runat="server" ValidationGroup="CRMPaymentScheduleEntity" Width="234">
                    </asp:DropDownList>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Handover Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtHandoverDate">
                        Enter Handover Date</label>
                    <asp:TextBox ID="txtHandoverDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="CRMPaymentScheduleEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvHandoverDate" runat="server" ControlToValidate="txtHandoverDate"
                        ErrorMessage="Please Enter Handover Date" ValidationGroup="CRMPaymentScheduleEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revHandoverDate" runat="server" ControlToValidate="txtHandoverDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="CRMPaymentScheduleEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Actual Handover Dt&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtActualHandoverDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="CRMPaymentScheduleEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revActualHandoverDate" runat="server" ControlToValidate="txtActualHandoverDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="CRMPaymentScheduleEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Project Code&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtProjectCode">
                        Enter Project Code</label>
                    <asp:TextBox ID="txtProjectCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server" ReadOnly="true"
                        ValidationGroup="CRMPaymentScheduleEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvProjectCode" runat="server" ControlToValidate="txtProjectCode"
                        ErrorMessage="Please Enter Project Code" ValidationGroup="CRMPaymentScheduleEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Buyer Basic Info&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlBuyerBasicInfoID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="CRMPaymentScheduleEntity" Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvBuyerBasicInfoID" runat="server" ControlToValidate="ddlBuyerBasicInfoID"
                        ErrorMessage="Please Select Buyer Basic Info" ValidationGroup="CRMPaymentScheduleEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Common Service&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtCommonService" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="CRMPaymentScheduleEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvCommonService" runat="server" ControlToValidate="txtCommonService"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="CRMPaymentScheduleEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Utility Conn. Cost&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtUtilityConnectionCost" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="CRMPaymentScheduleEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvUtilityConnectionCost" runat="server" ControlToValidate="txtUtilityConnectionCost"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="CRMPaymentScheduleEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Reserved Fund&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtReservedFund" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="CRMPaymentScheduleEntity" Type="Number" Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvReservedFund" runat="server" ControlToValidate="txtReservedFund"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="CRMPaymentScheduleEntity"></asp:RangeValidator>
                </div>
            </div>
             <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Earnest Money&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEarnestMoney" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvEarnestMoney" runat="server" ControlToValidate="txtEarnestMoney" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentScheduleEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Reservation&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtReservation" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentScheduleEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvReservation" runat="server" ControlToValidate="txtReservation" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentScheduleEntity"></asp:RangeValidator>
                    </div>
                </div>
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Total Agree. Amount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                    <asp:TextBox ID="txtTotalAgreementAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="CRMPaymentScheduleEntity" Type="Number" Width="210" />
                        <span><asp:Label ID="lblRemainingAmount" runat="server"></asp:Label></span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvTotalAgreementAmount" runat="server" ControlToValidate="txtTotalAgreementAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentScheduleEntity"></asp:RangeValidator>
                    </div>
                </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Total Installment&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtTotalInstallment" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="CRMPaymentScheduleEntity" Type="Number" Width="210" />
                    <span>
                        <asp:Button ID="btnCreateInstallment" runat="server" Text="Generate Installment"
                            OnClick="btnCreateInstallment_Click" ClientIDMode="Static" /></span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvTotalInstallment" runat="server" ControlToValidate="txtTotalInstallment"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="CRMPaymentScheduleEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Remarks&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                        ID="txtRemarks" runat="server" ValidationGroup="CRMPaymentScheduleEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    &nbsp;
                </div>
                <div class="TableFormContent" style="float:right;">
                <asp:LinkButton ID="lnkRecalulateGrandTotal" runat="server" Text="Calculate Grand Total" OnClick="lnkRecalulateGrandTotal_Click" Visible="false"/>
                    <asp:Button ID="btnRecalculate" runat="server" Text="Remaining Amount" OnClick="btnRecalculate_Click" Visible="false"/>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <br />
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMPaymentScheduleMap" runat="server" OnItemCommand="lvCRMPaymentScheduleMap_ItemCommand" OnItemDataBound="lvCRMPaymentScheduleMap_ItemDataBound" OnItemCreated="lvCRMPaymentScheduleMap_ItemCreated" InsertItemPosition="LastItem">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width:50px;">
                                        SL.
                                    </td>
                                    <td class="hi">
                                        Installment Name
                                    </td>
                                    <td class="hi">
                                        Installment Due Date
                                    </td>
                                    <td class="hi" style="width: 125px;">
                                        Agreement A Amount
                                    </td>
                                    <td class="hi" style="width: 125px;">
                                        Agreement B Amount
                                    </td>
                                    <td class="hi" style="width: 125px;">
                                        Agreement C Amount
                                    </td>
                                    <td class="hi" style="width: 125px;">
                                        Total
                                    </td>
                                    <td class="hi" style="width: 100px;">
                                        Remarks
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
                            </table>
                        </LayoutTemplate>
                        <ItemTemplate>
                            <tr class="r">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblPaymentScheduleMapIDLV" Text='<%# Eval("PaymentScheduleMapID")%>' ClientIDMode="Static"
                                        runat="server"></asp:Label>
                                </td>
                                <td class="i">
                                    <%#Container.DataItemIndex+1 %>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtInstallmentNameLV" runat="server" Text='<%# Eval("InstallmentName")%>' ClientIDMode="Static"
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtInstallmentDueDateLV" runat="server" Text='<%# Eval("InstallmentDueDate") != null ? ((DateTime)Eval("InstallmentDueDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>' ClientIDMode="Static"
                                            CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvRequiredDate" runat="server" ControlToValidate="txtInstallmentDueDateLV"
                                            ErrorMessage="Please Enter Due Date Date" ValidationGroup="REQRequisitionItemEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revRequiredDate" runat="server" ControlToValidate="txtInstallmentDueDateLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:25-07-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                            ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAgreementAAmountLV" runat="server" Text='<%# Eval("AgreementAAmount")%>' ClientIDMode="Static"
                                        CssClass="ktiDecimalTextBoxListview" Width="112"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAgreementBAmountLV" runat="server" Text='<%# Eval("AgreementBAmount")%>' ClientIDMode="Static"
                                        CssClass="ktiDecimalTextBoxListview" Width="112"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAgreementCAmountLV" runat="server" Text='<%# Eval("AgreementCAmount")%>' ClientIDMode="Static"
                                        CssClass="ktiDecimalTextBoxListview" Width="112"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtTotalLV" ReadOnly="true" runat="server" Text='<%# Decimal.Round((Decimal)Eval("AgreementAAmount")+(Decimal)Eval("AgreementBAmount")+(Decimal)Eval("AgreementCAmount"),2)%>' ClientIDMode="Static"
                                        CssClass="ktiDecimalTextBoxListview" Width="112"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtRemarksLV" runat="server" Text='<%# Eval("Remarks")%>' CssClass="ktiTextBoxListview" ClientIDMode="Static"
                                        TextMode="MultiLine"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Payment Schedule Map?')"
                                        CommandArgument='<%#Eval("PaymentScheduleMapID")%>' UniqueKey="CRMPaymentScheduleMap_lvCRMPaymentScheduleMap_Edit_key" />
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </ItemTemplate>
                      <%--  <AlternatingItemTemplate>
                            <tr class="ar">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblPaymentScheduleMapIDLV" Text='<%# Eval("PaymentScheduleMapID")%>' ClientIDMode="Static"
                                        runat="server"></asp:Label>
                                </td>
                                <td class="i">
                                    <%#Container.DataItemIndex+1 %>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtInstallmentNameLV" runat="server" Text='<%# Eval("InstallmentName")%>' ClientIDMode="Static"
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtInstallmentDueDateLV" runat="server" Text='<%# Eval("InstallmentDueDate") != null ? ((DateTime)Eval("InstallmentDueDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>' ClientIDMode="Static"
                                            CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvRequiredDate" runat="server" ControlToValidate="txtInstallmentDueDateLV"
                                            ErrorMessage="Please Enter Due Date Date" ValidationGroup="REQRequisitionItemEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revRequiredDate" runat="server" ControlToValidate="txtInstallmentDueDateLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:25-07-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                            ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAgreementAAmountLV" runat="server" Text='<%# Eval("AgreementAAmount")%>' ClientIDMode="Static"
                                        CssClass="ktiDecimalTextBoxListview" Width="112"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAgreementBAmountLV" runat="server" Text='<%# Eval("AgreementBAmount")%>' ClientIDMode="Static"
                                        CssClass="ktiDecimalTextBoxListviewe" Width="112"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAgreementCAmountLV" runat="server" Text='<%# Eval("AgreementCAmount")%>' ClientIDMode="Static"
                                        CssClass="ktiDecimalTextBoxListview" Width="112"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtTotalLV" ReadOnly="true" runat="server" Text='<%# Decimal.Round((Decimal)Eval("AgreementAAmount")+(Decimal)Eval("AgreementBAmount")+(Decimal)Eval("AgreementCAmount"),2)%>' ClientIDMode="Static"
                                        CssClass="ktiDecimalTextBoxListview" Width="112"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtRemarksLV" runat="server" Text='<%# Eval("Remarks")%>' CssClass="ktiTextBoxListview" ClientIDMode="Static"
                                        TextMode="MultiLine"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Payment Schedule Map?')"
                                        CommandArgument='<%#Eval("PaymentScheduleMapID")%>' UniqueKey="CRMPaymentScheduleMap_lvCRMPaymentScheduleMap_Edit_key" />
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>--%>
                        <InsertItemTemplate>
                            <tr class="ar">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i">
                                    
                                </td>
                                <td class="i">
                                    <div class="TableFormContent">
                                        <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBoxListview" Width="96" ClientIDMode="Static"
                                            ID="txtInstallmentNameLV" runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvInstallmentName" runat="server" ControlToValidate="txtInstallmentNameLV"
                                            ErrorMessage="Please Enter Installment Name" ValidationGroup="CRMPaymentScheduleMapEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtInstallmentDueDateLV" runat="server" Text='<%# Eval("InstallmentDueDate") != null ? ((DateTime)Eval("InstallmentDueDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>'
                                            CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvRequiredDate" runat="server" ControlToValidate="txtInstallmentDueDateLV"
                                            ErrorMessage="Please Enter Due Date Date" ValidationGroup="CRMPaymentScheduleMapEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revRequiredDate" runat="server" ControlToValidate="txtInstallmentDueDateLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:25-07-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                            ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RegularExpressionValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormContent">
                                        <asp:TextBox ID="txtAgreementAAmountLV" CssClass="ktiDecimalTextBoxListview" ClientIDMode="Static"
                                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Type="Number" Width="112" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvAgreementAAmount" runat="server" ControlToValidate="txtAgreementAAmountLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormContent">
                                        <asp:TextBox ID="txtAgreementBAmountLV" CssClass="ktiDecimalTextBoxListview" ClientIDMode="Static"
                                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Type="Number" Width="112" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvAgreementBAmount" runat="server" ControlToValidate="txtAgreementBAmountLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    <div class="TableFormContent">
                                        <asp:TextBox ID="txtAgreementCAmountLV" CssClass="ktiDecimalTextBoxListview" ClientIDMode="Static"
                                            runat="server" ValidationGroup="CRMPaymentScheduleMapEntity" Type="Number" Width="112" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvAgreementCAmount" runat="server" ControlToValidate="txtAgreementCAmountLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="CRMPaymentScheduleMapEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                <td class="i">
                                    &nbsp;auto Calculate
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtRemarksLV" runat="server" CssClass="ktiTextBoxListview" ValidationGroup="CRMPaymentScheduleMapEntity"
                                        TextMode="MultiLine"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnInsert" runat="server" CssClass="CommonButtonLink" ValidationGroup="CRMPaymentScheduleMapEntity"
                                        Text="Insert" CommandName="InsertItem" />
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </InsertItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
            </div>
            <br />
            <br />
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMPaymentScheduleEntity" OnClick="btnSave_Click"
                        runat="server" Text="Save Payment Schedule" UniqueKey="CRMPaymentScheduleControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" UniqueKey="CRMPaymentScheduleControl_AddNew_key" />
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
