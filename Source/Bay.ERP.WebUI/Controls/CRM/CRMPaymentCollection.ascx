<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Apr-2013, 12:14:24
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMPaymentCollection.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMPaymentCollectionControl" %>
<script language="javascript" type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#txtTotalAmount").keyup(function () {
                var dueAmount, paidAmount, percentageAmount, availableAmount;

                dueAmount = $("#txtPaymentDueAmount").val();
                paidAmount = $("#txtTotalAmount").val();

                var percentageAAmount, percentageBAmount, percentageCAmount;
                percentageAAmount = dueAmount * .5;
                percentageBAmount = dueAmount * .42;
                percentageCAmount = dueAmount * .08;

                percentageAmount = percentageAAmount;
                availableAmount = paidAmount - percentageAmount;

                availableAmount = parseFloat(availableAmount);

                if (availableAmount >= 0) {
                    $("#txtAgreementAAmount").val(percentageAmount);
                }
                else {
                    $("#txtAgreementAAmount").val(paidAmount > 0 ? paidAmount : 0);
                }

                percentageAmount = percentageBAmount;
                paidAmount = availableAmount;
                availableAmount = paidAmount - percentageAmount;

                if (availableAmount >= 0) {
                    $("#txtAgreementBAmount").val(percentageAmount);
                }
                else {
                    $("#txtAgreementBAmount").val(paidAmount > 0 ? paidAmount : 0);
                }

                percentageAmount = percentageCAmount;
                paidAmount = availableAmount;
                availableAmount = paidAmount - percentageAmount;

                if (availableAmount >= 0) {
                    $("#txtAgreementCAmount").val(percentageAmount);
                }
                else {
                    $("#txtAgreementCAmount").val(paidAmount > 0 ? paidAmount : 0);
                }

                callme();

            });
            $("#txtAgreementAAmount").keyup(function () {
                var agreementAAmount = parseFloat($(this).val());
                var agreementBAmount = parseFloat($("#txtAgreementBAmount").val());
                var agreementCAmount = parseFloat($("#txtAgreementCAmount").val());
                var result = agreementAAmount + agreementBAmount + agreementCAmount;
                $("#txtTotalAmount").val(result);

                callme();
            });
            $("#txtAgreementBAmount").keyup(function () {
                var agreementBAmount = parseFloat($(this).val());
                var agreementAAmount = parseFloat($("#txtAgreementAAmount").val());
                var agreementCAmount = parseFloat($("#txtAgreementCAmount").val());
                var result = agreementAAmount + agreementBAmount + agreementCAmount;
                $("#txtTotalAmount").val(result);

                callme();
            });
            $("#txtAgreementCAmount").keyup(function () {
                var agreementCAmount = parseFloat($(this).val());
                var agreementAAmount = parseFloat($("#txtAgreementAAmount").val());
                var agreementBAmount = parseFloat($("#txtAgreementBAmount").val());
                var result = agreementAAmount + agreementBAmount + agreementCAmount;
                $("#txtTotalAmount").val(result);

                callme();
            });
        });
    }
</script>
<script language="javascript" type="text/javascript">
    function callme() {
        $(document).ready(function () {
            $("#txtOverDueAmount").val($("#txtPaymentDueAmount").val() - $("#txtTotalAmount").val());

            var totalPaidAmount = parseFloat($("#txtTotalAmount").val());
            var totalDueAmount = parseFloat($("#txtPaymentDueAmount").val());
            if (totalDueAmount > totalPaidAmount) {
                $("#lblPaymentCategory").css("color", '#0404B4');
                $("#lblPaymentCategory").text("Partial Payment");
                $("#ddlPaymentCategoryID").val("2");
            }
            if (totalDueAmount == totalPaidAmount) {
                $("#lblPaymentCategory").css("color", '#0B610B');
                $("#lblPaymentCategory").text("Complete Payment");
                $("#ddlPaymentCategoryID").val("1");
            }
            if (totalDueAmount < totalPaidAmount) {
                $("#lblPaymentCategory").css("color", '#FF0000');
                $("#lblPaymentCategory").text("Payment Exceded");
                $("#ddlPaymentCategoryID").val("3");
            }
            if (isNaN(totalPaidAmount)) {
                $("#lblPaymentCategory").css("color", '#A4A4A4');
                $("#lblPaymentCategory").text("None");
            }
        });
    }
</script>
<script language="javascript" type="text/javascript">
    function BindEventsForCalendar() {
        $(document).ready(function () {
            $("#txtActualPaymentDate").change(function () {
                var StartDate = $.datepicker.parseDate('dd-mm-yy', $("#txtActualPaymentDate").val());
                var DueDate = $.datepicker.parseDate('dd-mm-yy', $("#txtPaymentDueDate").val());

                var actualDate = new Date(StartDate);
                var dueDate = new Date(DueDate);
                $("#txtDelayDayOnPayment").val((actualDate - dueDate) / (1000 * 60 * 60 * 24));
            });
        });
    }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
            Sys.Application.add_load(BindEventsForCalendar);
            Sys.Application.add_load(callme);
        </script>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Payment Collection"></asp:Label>
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
                        Agreement&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAgreementID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlAgreementID_SelectedIndexChanged"
                            runat="server" ValidationGroup="CRMPaymentCollectionEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAgreementID" runat="server" ControlToValidate="ddlAgreementID"
                            ErrorMessage="Please Select Agreement" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Installment&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlPaymentScheduleMapID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlPaymentScheduleMapID_SelectedIndexChanged"
                            runat="server" ValidationGroup="CRMPaymentCollectionEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPaymentScheduleMapID" runat="server" ControlToValidate="ddlPaymentScheduleMapID"
                            ErrorMessage="Please Select Payment Schedule Map" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Due Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPaymentDueAmount">
                            Enter Total Amount</label>
                        <asp:TextBox ID="txtPaymentDueAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            ReadOnly="true" runat="server" ValidationGroup="CRMPaymentCollectionEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtPaymentDueAmount"
                            ErrorMessage="Please Enter Total Amount" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="RangeValidator1" runat="server" ControlToValidate="txtPaymentDueAmount"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Due Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPaymentDueDate">
                            Enter Payment Due Date</label>
                        <asp:TextBox ID="txtPaymentDueDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBoxe"
                            ReadOnly="true" ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="txtPaymentDueDate"
                            ErrorMessage="Please Enter Actual Payment Date" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="txtPaymentDueDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMPaymentCollectionEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Paid Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTotalAmount">
                            Enter Total Amount</label>
                        <asp:TextBox ID="txtTotalAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentCollectionEntity" Width="210" />
                        <span class="RequiredField">*</span> <span>
                            <asp:Label ID="lblPaymentCategory" ForeColor="Green" runat="server" ClientIDMode="Static"
                                Font-Bold="true"></asp:Label></span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvtxtTotalAmount" runat="server" ControlToValidate="txtTotalAmount"
                            ErrorMessage="Please Enter Total Amount" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvtxtTotalAmount" runat="server" ControlToValidate="txtTotalAmount"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement A Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAgreementAAmount">
                            Enter Agreement A Amount</label>
                        <asp:TextBox ID="txtAgreementAAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentCollectionEntity" Width="210" />
                        <span class="RequiredField">*</span> <span>
                            <asp:LinkButton ID="lnkCalculateAgreementAmount" runat="server" Text="Calculate Agreement Amount"
                                OnClick="lnkCalculateAgreementAmount_Click" /></span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvtxtAgreementAAmount" runat="server" ControlToValidate="txtAgreementAAmount"
                            ErrorMessage="Please Enter Agreement A Amount" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvtxtAgreementAAmount" runat="server" ControlToValidate="txtAgreementAAmount"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement B Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAgreementBAmount">
                            Enter Agreement B Amount</label>
                        <asp:TextBox ID="txtAgreementBAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentCollectionEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvtxtAgreementBAmount" runat="server" ControlToValidate="txtAgreementBAmount"
                            ErrorMessage="Please Enter Agreement B Amount" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvtxtAgreementBAmount" runat="server" ControlToValidate="txtAgreementBAmount"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement C Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAgreementCAmount">
                            Enter Agreement C Amount</label>
                        <asp:TextBox ID="txtAgreementCAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentCollectionEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAgreementCAmount" runat="server" ControlToValidate="txtAgreementCAmount"
                            ErrorMessage="Please Enter Agreement C Amount" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvAgreementCAmount" runat="server" ControlToValidate="txtAgreementCAmount"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                    </div>
                </div>
                <ajaxToolkit:CalendarExtender ID="CEtxtEndDate" runat="server" TargetControlID="txtActualPaymentDate"
                    Format="dd-MM-yyyy">
                </ajaxToolkit:CalendarExtender>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Actual Payment Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtActualPaymentDate" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                            ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvActualPaymentDate" runat="server" ControlToValidate="txtActualPaymentDate"
                            ErrorMessage="Please Enter Actual Payment Date" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revActualPaymentDate" runat="server" ControlToValidate="txtActualPaymentDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMPaymentCollectionEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Balance Amount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtOverDueAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentCollectionEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvOverDueAmount" runat="server" ControlToValidate="txtOverDueAmount"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Delayed On Payment&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDelayDayOnPayment" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentCollectionEntity" Type="Number" Width="210" />
                        <span>Day</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvDelayDayOnPayment" runat="server" ControlToValidate="txtDelayDayOnPayment"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Delayed Over Due&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDelayDayOnOverDue" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMPaymentCollectionEntity" Type="Number" Width="210" />
                        <span>Day</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvDelayDayOnOverDue" runat="server" ControlToValidate="txtDelayDayOnOverDue"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Money Receipt No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtMoneyReceiptNo">
                            Enter Money Receipt No</label>
                        <asp:TextBox ID="txtMoneyReceiptNo" CssClass="ktiDecimalTextBox" ClientIDMode="Static" Enabled="true"
                            runat="server" ValidationGroup="CRMPaymentCollectionEntity" Width="210" />
                            <span><asp:CheckBox ID="chbxMoneyReceipt" AutoPostBack="true" OnCheckedChanged="chbxMoneyReceipt_CheckedChanged" runat="server" ClientIDMode="Static" /></span>
                        <span class="RequiredField">Left Blank To Get Auto Generated Number</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvMoneyReceiptNo" runat="server" ControlToValidate="txtMoneyReceiptNo"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Payment Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtPaymentDescription" runat="server" ValidationGroup="CRMPaymentCollectionEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div style="display: none;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Payment Received In Bank&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtPaymentReceivedInBank" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="CRMPaymentCollectionEntity" Type="Number" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvPaymentReceivedInBank" runat="server" ControlToValidate="txtPaymentReceivedInBank"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Pay Not Received Note&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                ID="txtPaymentNotReceivedNote" runat="server" ValidationGroup="CRMPaymentCollectionEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Reverse Entry&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkReverseEntry" runat="server" ClientIDMode="Static" ValidationGroup="CRMPaymentCollectionEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Last Payment&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkLastPayment" runat="server" ClientIDMode="Static" ValidationGroup="CRMPaymentCollectionEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Discount Amount&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtDiscountAmount" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Vat&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtVat" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Tax&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtTax" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Service Charge&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtServiceCharge" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Additional Fee&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtAdditionalFee" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Initial Amount In Agreement&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtInitialAmountInAgreement" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="CRMPaymentCollectionEntity" Type="Number" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvInitialAmountInAgreement" runat="server" ControlToValidate="txtInitialAmountInAgreement"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="CRMPaymentCollectionEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Gross Amount&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtGrossAmount" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Net Amount&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtNetAmount" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Extra Field&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtExtraField" runat="server" ValidationGroup="CRMPaymentCollectionEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Cash / Cheque No&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCashOrChequeNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Receive Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCashOrChequeDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revCashOrChequeDate" runat="server" ControlToValidate="txtCashOrChequeDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMPaymentCollectionEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Bank Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtBankName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Branch Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtBranchName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMPaymentCollectionEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Narration&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="CRMPaymentCollectionEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Approval Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlPaymentApprovalStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            Enabled="false" runat="server" ValidationGroup="CRMPaymentCollectionEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPaymentApprovalStatusID" runat="server" ControlToValidate="ddlPaymentApprovalStatusID"
                            ErrorMessage="Please Select Payment Approval Status" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Payment Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlPaymentCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            Enabled="false" runat="server" ValidationGroup="CRMPaymentCollectionEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPaymentCategoryID" runat="server" ControlToValidate="ddlPaymentCategoryID"
                            ErrorMessage="Please Select Payment Category" ValidationGroup="CRMPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMPaymentCollectionEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CRMPaymentCollectionControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="CRMPaymentCollectionControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="CRMPaymentCollectionControl_Clear_key" />
                    </div>
                </div>
                <br />
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                    <div runat="server" id="dvMoneyReceipt" visible="false">
                      <asp:HyperLink ID="hypAgreementAMoneyReceipt" runat="server" CssClass="hypTableFormLeble" Text="Agreement A Money Receipt"></asp:HyperLink> &nbsp;&nbsp;
                      <asp:HyperLink ID="hypAgreementBMoneyReceipt" runat="server" CssClass="hypTableFormLeble" Text="Agreement B Money Receipt"></asp:HyperLink>&nbsp;&nbsp;
                      <asp:HyperLink ID="hypAgreementCMoneyReceipt" runat="server" CssClass="hypTableFormLeble" Text="Agreement C Money Receipt"></asp:HyperLink>&nbsp;&nbsp;
                      </div>
                    </div>
                </div>
            </asp:Panel>
            <div style="display: none;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSearchAgreementTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlSearchAgreementTypeID_SelectedIndexChanged"
                            runat="server" ValidationGroup="CRMSearchPaymentCollectionEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvddlSearchAgreementTypeID" runat="server" ControlToValidate="ddlSearchAgreementTypeID"
                            ErrorMessage="Please Select Agreement Type" ValidationGroup="CRMSearchPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Agreement&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSearchAgreementID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlSearchAgreementID_SelectedIndexChanged"
                            runat="server" ValidationGroup="CRMSearchPaymentCollectionEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvddlSearchAgreementID" runat="server" ControlToValidate="ddlSearchAgreementID"
                            ErrorMessage="Please Select Agreement" ValidationGroup="CRMSearchPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Payment Schedule&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSearchPaymentScheduleID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMSearchPaymentCollectionEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvddlSearchPaymentScheduleID" runat="server" ControlToValidate="ddlSearchPaymentScheduleID"
                            ErrorMessage="Please Select Payment Schedule Map" ValidationGroup="CRMSearchPaymentCollectionEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnGetSchedule" ValidationGroup="CRMSearchPaymentCollectionEntity"
                            OnClick="btnGetSchedule_Click" runat="server" Text="Get Schedule" />
                        <asp:Button ID="btnReset" ValidationGroup="CRMSearchPaymentCollectionEntity" OnClick="btnReset_Click"
                            runat="server" Text="Reset" />
                    </div>
                </div>
                
            </div>
            
            <div class="listContentTitle">
                Payment Collection List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMPaymentCollection" runat="server" DataSourceID="odsCRMPaymentCollection"
                        OnItemCommand="lvCRMPaymentCollection_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Payment Schedule Map
                                    </td>
                                    <td class="hi">
                                        Agreement Type
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi">
                                        Installment
                                    </td>
                                    <td class="hi">
                                        Due Date
                                    </td>
                                    <td class="hi">
                                        Money Receipt No
                                    </td>
                                    <td class="hi">
                                        Installment Payment Amount
                                    </td>
                                    <td class="hi">
                                        Actual Payment Date
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Payment Description
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Installment Payment In Word
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Initial Amount In Agreement
                                    </td>
                                    <td class="hi">
                                        Over Due Amount
                                    </td>
                                    <td class="hi">
                                        Delay Day On Payment
                                    </td>
                                    <td class="hi">
                                        Delay Day On Over Due
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Payment Received In Bank
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Payment Not Received Note
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Agreement
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Reverse Entry
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Last Payment
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Discount Amount
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Vat
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Tax
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Service Charge
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Additional Fee
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Gross Amount
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Net Amount
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Payment Approval Status
                                    </td>
                                    <td class="hi">
                                        Payment Category
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Extra Field
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Remarks
                                    </td>
                                    <td class="his" style="display: none;">
                                        EDIT
                                    </td>
                                    <td class="his" style="display: none;">
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
                                <td class="i" style="display: none;">
                                    <%# Eval("PaymentScheduleMapID")%>
                                    <%# Eval("PaymentDescription")%>
                                    <%# Eval("InstallmentPaymentInWord")%>
                                    <%# Eval("InitialAmountInAgreement")%>
                                    <%# Eval("PaymentReceivedInBank")%>
                                    <%# Eval("PaymentNotReceivedNote")%>
                                    <%# Eval("AgreementID")%>
                                    <%# Eval("ReverseEntry") != null ? (((Boolean)Eval("ReverseEntry")) ? "Yes" : "No") : ""%>
                                    <%# Eval("LastPayment") != null ? (((Boolean)Eval("LastPayment")) ? "Yes" : "No") : ""%>
                                    <%# Eval("DiscountAmount")%>
                                    <%# Eval("Vat")%>
                                    <%# Eval("Tax")%>
                                    <%# Eval("ServiceCharge")%>
                                    <%# Eval("AdditionalFee")%>
                                    <%# Eval("GrossAmount")%>
                                    <%# Eval("NetAmount")%>
                                    <%# Eval("PaymentApprovalStatusID")%>
                                    <%# Eval("ExtraField")%>
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentScheduleMapInstallmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InstallmentDueDate")!= null ? ((DateTime)Eval("InstallmentDueDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("MoneyReceiptNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InstallmentPaymentAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualPaymentDate") != null ? ((DateTime)Eval("ActualPaymentDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("OverDueAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DelayDayOnPayment")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DelayDayOnOverDue")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CRMMDPaymentCategoryName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("PaymentCollectionID")%>'
                                        UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Payment Collection?')"
                                        CommandArgument='<%#Eval("PaymentCollectionID")%>' UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
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
                                <td class="i" style="display: none;">
                                    <%# Eval("PaymentScheduleMapID")%>
                                    <%# Eval("PaymentDescription")%>
                                    <%# Eval("InstallmentPaymentInWord")%>
                                    <%# Eval("InitialAmountInAgreement")%>
                                    <%# Eval("PaymentReceivedInBank")%>
                                    <%# Eval("PaymentNotReceivedNote")%>
                                    <%# Eval("AgreementID")%>
                                    <%# Eval("ReverseEntry") != null ? (((Boolean)Eval("ReverseEntry")) ? "Yes" : "No") : ""%>
                                    <%# Eval("LastPayment") != null ? (((Boolean)Eval("LastPayment")) ? "Yes" : "No") : ""%>
                                    <%# Eval("DiscountAmount")%>
                                    <%# Eval("Vat")%>
                                    <%# Eval("Tax")%>
                                    <%# Eval("ServiceCharge")%>
                                    <%# Eval("AdditionalFee")%>
                                    <%# Eval("GrossAmount")%>
                                    <%# Eval("NetAmount")%>
                                    <%# Eval("PaymentApprovalStatusName")%>
                                    <%# Eval("ExtraField")%>
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentScheduleMapInstallmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InstallmentDueDate")!= null ? ((DateTime)Eval("InstallmentDueDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("MoneyReceiptNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InstallmentPaymentAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualPaymentDate") != null ? ((DateTime)Eval("ActualPaymentDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("OverDueAmount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DelayDayOnPayment")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DelayDayOnOverDue")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CRMMDPaymentCategoryName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="SecureLinkButton1" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("PaymentCollectionID")%>'
                                        UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="SecureLinkButton2" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Payment Collection?')"
                                        CommandArgument='<%#Eval("PaymentCollectionID")%>' UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("PaymentCollectionID")%>'
                                        UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Payment Collection?')"
                                        CommandArgument='<%#Eval("PaymentCollectionID")%>' UniqueKey="CRMPaymentCollection_lvCRMPaymentCollection_Edit_key" />
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
                <asp:ObjectDataSource ID="odsCRMPaymentCollection" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMPaymentCollection_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMPaymentCollection_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
