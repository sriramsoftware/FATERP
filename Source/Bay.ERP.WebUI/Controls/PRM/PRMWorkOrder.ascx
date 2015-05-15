<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMWorkOrder.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMWorkOrderControl" %>

   <%-- <script type="text/javascript">
        function toggle() {
     document.load
         var text = document.getElementById("mt_UtilityToolbar");
             text.style.display = "none";
         }
</script>--%>

<script language="javascript" type="text/javascript">
    function BindKeyUpEvent() {
        $(document).ready(function () {
            $("#txtAIT").keyup(function () {
                var ait = $("#txtAIT").val();
                var amount = $("#txtTotal").val();
                var vat = $("#txtVAT").val();
                var tax = $("#txtTax").val();
                var discount = $("#txtDiscount").val();
                var CarryingCharge = $("#txtCarryingCharge").val();
                var netamount = amount - discount + parseFloat(tax) + parseFloat(vat) + parseFloat(CarryingCharge) + parseFloat(ait);
                $("#txtGrandTotal").val(netamount);
            });
            $("#txtVAT").keyup(function () {
                var ait = $("#txtAIT").val();
                var amount = $("#txtTotal").val();
                var vat = $("#txtVAT").val();
                var tax = $("#txtTax").val();
                var discount = $("#txtDiscount").val();
                var CarryingCharge = $("#txtCarryingCharge").val();
                var netamount = amount - discount + parseFloat(tax) + parseFloat(vat) + parseFloat(CarryingCharge) + parseFloat(ait);
                $("#txtGrandTotal").val(netamount.toFixed(2));
            });
            $("#txtTax").keyup(function () {
                var ait = $("#txtAIT").val();
                var amount = $("#txtTotal").val();
                var vat = $("#txtVAT").val();
                var tax = $("#txtTax").val();
                var discount = $("#txtDiscount").val();
                var CarryingCharge = $("#txtCarryingCharge").val();
                var netamount = amount - discount + parseFloat(tax) + parseFloat(vat) + parseFloat(CarryingCharge) + parseFloat(ait);
                $("#txtGrandTotal").val(netamount.toFixed(2));
            });
            $("#txtCarryingCharge").keyup(function () {
                var ait = $("#txtAIT").val();
                var amount = $("#txtTotal").val();
                var vat = $("#txtVAT").val();
                var tax = $("#txtTax").val();
                var discount = $("#txtDiscount").val();
                var CarryingCharge = $("#txtCarryingCharge").val();
                var netamount = amount - discount + parseFloat(tax) + parseFloat(vat) + parseFloat(CarryingCharge) + parseFloat(ait);
                $("#txtGrandTotal").val(netamount.toFixed(2));
            });
            $("#txtDiscount").keyup(function () {
                var ait = $("#txtAIT").val();
                var amount = $("#txtTotal").val();
                var vat = $("#txtVAT").val();
                var tax = $("#txtTax").val();
                var discount = $("#txtDiscount").val();
                var CarryingCharge = $("#txtCarryingCharge").val();
                var netamount = amount - discount + parseFloat(tax) + parseFloat(vat) + parseFloat(CarryingCharge)+ parseFloat(ait);
                $("#txtGrandTotal").val(netamount.toFixed(2));
            });
        });
    }
</script>

 <script language="javascript" type="text/javascript">
     function BindEvents() {
         $(document).ready(function () {
             $("#mt_UtilityToolbar").hide();
         });
     }
     </script>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
     <script type="text/javascript">
         Sys.Application.add_load(BindKeyUpEvent);
        </script>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Vendor&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static" 
                        runat="server" AutoPostBack="true"
                        ValidationGroup="PRMWorkOrderEntity" Width="236" 
                        onselectedindexchanged="ddlSupplierID_SelectedIndexChanged">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                    <span style="text-align: right; padding-left: 500px;">
                    <asp:HyperLink ID="hypWorkOrderItemMap" runat="server" Text="Work Order Item Map"></asp:HyperLink></span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvSupplierID" runat="server" ControlToValidate="ddlSupplierID"
                        ErrorMessage="Please Select Supplier" ValidationGroup="PRMWorkOrderEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Work Order No&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtWorkOrderNo">
                        Enter Work Order No</label>
                    <asp:TextBox ID="txtWorkOrderNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server" ReadOnly="true"
                        ValidationGroup="PRMWorkOrderEntity" Width="230" />
                    <span class="RequiredField">*</span>
                    <span style="text-align: right; padding-left: 496px;">
                    <asp:HyperLink ID="hypWorkOrderPaymentTerm" runat="server" Text="Work Order Payment Term"></asp:HyperLink></span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvWorkOrderNo" runat="server" ControlToValidate="txtWorkOrderNo"
                        ErrorMessage="Please Enter Work Order No" ValidationGroup="PRMWorkOrderEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Attention&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlAttentionID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="PRMWorkOrderEntity" Width="236" AutoPostBack="true"
                        onselectedindexchanged="ddlAttentionID_SelectedIndexChanged">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvAttentionID" runat="server" ControlToValidate="ddlAttentionID"
                        ErrorMessage="Please Select Attention" ValidationGroup="PRMWorkOrderEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <asp:Panel ID="pnlOtherAttention" runat="server">
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Other Attention&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtOtherAttention" ClientIDMode="Static" CssClass="ktiTextBox" runat="server" ToolTip="Max Character Length - 127" MaxLength="127"
                            ValidationGroup="PRMWorkOrderEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                </asp:Panel>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Create Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtCreateDate">
                        Enter Create Date</label>
                    <asp:TextBox ID="txtCreateDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="PRMWorkOrderEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvCreateDate" runat="server" ControlToValidate="txtCreateDate"
                        ErrorMessage="Please Enter Create Date" ValidationGroup="PRMWorkOrderEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCreateDate" runat="server" ControlToValidate="txtCreateDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="PRMWorkOrderEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Subject&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSubject">
                        Enter Subject</label>
                    <asp:TextBox ID="txtSubject" ClientIDMode="Static" CssClass="ktiTextArea" runat="server" TextMode="MultiLine" MaxLength="178" ToolTip="Max Character Length - 178"
                        ValidationGroup="PRMWorkOrderEntity" Width="390" Height="97" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvSubject" runat="server" ControlToValidate="txtSubject"
                        ErrorMessage="Please Enter Subject" ValidationGroup="PRMWorkOrderEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Body Title&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtBodyTitle">
                        Enter Body Title</label>
                    <asp:TextBox ID="txtBodyTitle" ClientIDMode="Static" CssClass="ktiTextArea" runat="server" TextMode="MultiLine" ToolTip="Max Character Length - 372" MaxLength="372"
                        ValidationGroup="PRMWorkOrderEntity" Width="390" Height="97" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvBodyTitle" runat="server" ControlToValidate="txtBodyTitle"
                        ErrorMessage="Please Enter Body Title" ValidationGroup="PRMWorkOrderEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Start Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtStartDate">
                        Enter Start Date</label>
                    <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="PRMWorkOrderEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" ControlToValidate="txtStartDate"
                        ErrorMessage="Please Enter Start Date" ValidationGroup="PRMWorkOrderEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="PRMWorkOrderEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Completion Date&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtCompletionDate">
                        Enter Completion Date</label>
                    <asp:TextBox ID="txtCompletionDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                        ValidationGroup="PRMWorkOrderEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvCompletionDate" runat="server" ControlToValidate="txtCompletionDate"
                        ErrorMessage="Please Enter Completion Date" ValidationGroup="PRMWorkOrderEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    <asp:RegularExpressionValidator ID="revCompletionDate" runat="server" ControlToValidate="txtCompletionDate"
                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                        ValidationGroup="PRMWorkOrderEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Warranty&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="97" MaxLength="59" ToolTip="Max Character Length - 59"
                        ClientIDMode="Static" ID="txtWarranty" runat="server" ValidationGroup="PRMWorkOrderEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Delay Charge&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="97" MaxLength="59" ToolTip="Max Character Length - 59"
                        ClientIDMode="Static" ID="txtDelayCharge" runat="server" ValidationGroup="PRMWorkOrderEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Total&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtTotal" CssClass="ktiDecimalTextBox" ClientIDMode="Static" Text="0" ReadOnly="true" 
                            runat="server" ValidationGroup="PRMWorkOrderEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvTotal" runat="server" ControlToValidate="txtTotal" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="PRMWorkOrderEntity"></asp:RangeValidator>
                    </div>
                </div>
             <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        AIT&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAIT" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="PRMWorkOrderEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvAIT" runat="server" ControlToValidate="txtAIT" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="PRMWorkOrderEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Carrying Charge&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCarryingCharge" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="PRMWorkOrderEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCarryingCharge" runat="server" ControlToValidate="txtCarryingCharge" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="PRMWorkOrderEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Discount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDiscount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="PRMWorkOrderEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvDiscount" runat="server" ControlToValidate="txtDiscount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="PRMWorkOrderEntity"></asp:RangeValidator>
                    </div>
                </div>
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        VAT&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtVAT" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="PRMWorkOrderEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvVAT" runat="server" ControlToValidate="txtVAT" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="PRMWorkOrderEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Tax&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtTax" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="PRMWorkOrderEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvTax" runat="server" ControlToValidate="txtTax" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="PRMWorkOrderEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Net Amount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtGrandTotal" CssClass="ktiDecimalTextBox" ClientIDMode="Static" ReadOnly="true"
                            runat="server" ValidationGroup="PRMWorkOrderEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvGrandTotal" runat="server" ControlToValidate="txtGrandTotal" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="PRMWorkOrderEntity"></asp:RangeValidator>
                    </div>
                </div>
             <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Additional Text&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="97" ClientIDMode="Static" ToolTip="Please Type The Text With Additional Conditions. This Will Set Before Remarks."
                            ID="txtRowText" runat="server" ValidationGroup="PRMWorkOrderEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Remarks&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="97"
                        ClientIDMode="Static" ID="txtRemarks" runat="server" ValidationGroup="PRMWorkOrderEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Foot Note&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtFootNote" ClientIDMode="Static" CssClass="ktiTextBox" runat="server" TextMode="SingleLine" Width="230"
                        ValidationGroup="PRMWorkOrderEntity"/>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Prepared By&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlPreparedByID" CssClass="ktiSelect" ClientIDMode="Static" Enabled="false"
                        runat="server" ValidationGroup="PRMWorkOrderEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvPreparedByID" runat="server" ControlToValidate="ddlPreparedByID"
                        ErrorMessage="Please Select Prepared By" ValidationGroup="PRMWorkOrderEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100; display: none;">
                <div class="TableFormLeble" style="text-align: left;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypWorkOrder" runat="server" Text="Work Order Status"
                        NavigateUrl="~/MD/MDWorkOrderStatus.aspx" Target="_blank"></asp:HyperLink>
                    &nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlWorkOrderStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                        runat="server" ValidationGroup="PRMWorkOrderEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvWorkOrderStatusID" runat="server" ControlToValidate="ddlWorkOrderStatusID"
                        ErrorMessage="Please Select Work Order Status" ValidationGroup="PRMWorkOrderEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMWorkOrderEntity" OnClick="btnSave_Click"
                        runat="server" Text="Save & Next" UniqueKey="PRMWorkOrderControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" UniqueKey="PRMWorkOrderControl_AddNew_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="PRMWorkOrderControl_Clear_key" />
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
