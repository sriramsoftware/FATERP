<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Oct-2012, 11:26:30
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMBill_NEW.ascx.cs" Inherits="Bay.ERP.Web.UI.CMBill_NEWControl" %>
<script language="javascript" type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#txtDiscountAddition").keyup(function () {
                var amount = $("#txtTentativeAmount").val();
                var vat = $("#txtVat").val();
                var tax = $("#txtTax").val();
                var discount = $("#txtDiscountAddition").val();
                var CarryingCharge = $("#txtCarryingCharge").val();
                var netamount = amount - discount + parseFloat(tax) + parseFloat(vat) + parseFloat(CarryingCharge);
                $("#txtAmount").val(netamount);
            });
            $("#txtVat").keyup(function () {
                var amount = $("#txtTentativeAmount").val();
                var vat = $("#txtVat").val();
                var tax = $("#txtTax").val();
                var discount = $("#txtDiscountAddition").val();
                var CarryingCharge = $("#txtCarryingCharge").val();
                var netamount = amount - discount + parseFloat(tax) + parseFloat(vat) + parseFloat(CarryingCharge);
                $("#txtAmount").val(netamount);
            });
            $("#txtTax").keyup(function () {
                var amount = $("#txtTentativeAmount").val();
                var vat = $("#txtVat").val();
                var tax = $("#txtTax").val();
                var discount = $("#txtDiscountAddition").val();
                var CarryingCharge = $("#txtCarryingCharge").val();
                var netamount = amount - discount + parseFloat(tax) + parseFloat(vat) + parseFloat(CarryingCharge);
                $("#txtAmount").val(netamount);
            });
            $("#txtCarryingCharge").keyup(function () {
                var amount = $("#txtTentativeAmount").val();
                var vat = $("#txtVat").val();
                var tax = $("#txtTax").val();
                var discount = $("#txtDiscountAddition").val();
                var CarryingCharge = $("#txtCarryingCharge").val();
                var netamount = amount - discount + parseFloat(tax) + parseFloat(vat) + parseFloat(CarryingCharge);
                $("#txtAmount").val(netamount);
            });
            $("#txtTentativeAmount").keyup(function () {
                // $("#txtAmount").val($("#txtTentativeAmount").val());
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
            <div style="float: left; width: 600px;">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged"
                            ValidationGroup="CMBillEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                            ErrorMessage="Please Select Project" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Bill No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtBillNo">
                            Enter Bill No</label>
                        <asp:TextBox ID="txtBillNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMBillEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBillNo" runat="server" ControlToValidate="txtBillNo"
                            ErrorMessage="Please Enter Bill No" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Vendor Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlVendorCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" runat="server" ValidationGroup="CMBillEntity" Width="236"
                            OnSelectedIndexChanged="ddlVendorCategoryID_SelectedIndexChanged">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvVedorCategoryID" runat="server" ControlToValidate="ddlVendorCategoryID"
                            ErrorMessage="Please Select Vendor Category" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Vendor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlVendorID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            AutoPostBack="true" ValidationGroup="CMBillEntity" Width="236" OnSelectedIndexChanged="ddlVendorID_SelectedIndexChanged">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvVendor" runat="server" ControlToValidate="ddlVendorID"
                            ErrorMessage="Please Enter Vendor" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypWorkOrder" runat="server" Text="Work Order"
                            Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlWorkOrderID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlWorkOrderID_SelectedIndexChanged"
                            runat="server" ValidationGroup="CMBillEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                        <asp:CheckBox ID="chbxFinalBilled" runat="server" Text="WO-FINAL BILL" ForeColor="Black"
                            AutoPostBack="true" Enabled="true" OnCheckedChanged="chbxFinalBilled_CheckedChanged" /></span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvWorkOrderID" runat="server" ControlToValidate="ddlWorkOrderID"
                            ErrorMessage="Please Select Work Order" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAmount">
                            Enter Amount</label>
                        <asp:TextBox ID="txtTentativeAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" Font-Bold="true" ValidationGroup="CMBillEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvtxtTentativeAmount" runat="server" ControlToValidate="txtTentativeAmount"
                            ErrorMessage="Please Enter Amount" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvtxtTentativeAmount" runat="server" ControlToValidate="txtTentativeAmount"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CMBillEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Discount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtDiscountAddition" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMBillEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvDiscountAddition" runat="server" ControlToValidate="txtDiscountAddition"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CMBillEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Vat&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtVat" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="CMBillEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvVat" runat="server" ControlToValidate="txtVat" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMBillEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Tax&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtTax" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="CMBillEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvTax" runat="server" ControlToValidate="txtTax" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMBillEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Carrying Charge&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCarryingCharge" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMBillEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvCarryingCharge" runat="server" ControlToValidate="txtCarryingCharge"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="CMBillEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Net Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAmount">
                            Enter Amount</label>
                        <asp:TextBox ID="txtAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                            Font-Bold="true" ValidationGroup="CMBillEntity" Width="210" />
                        <span class="RequiredField">*</span><span><asp:LinkButton ID="lnkbtnCalculate" OnClick="lnkbtnCalculate_Click"
                            runat="server" Text="Update" /></span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAmount" runat="server" ControlToValidate="txtAmount"
                            ErrorMessage="Please Enter Amount" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvAmount" runat="server" ControlToValidate="txtAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMBillEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Addition Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtAdditionRemarks" runat="server" ValidationGroup="CMBillEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Due Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtBillDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CMBillEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revBillDate" runat="server" ControlToValidate="txtBillDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CMBillEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="106"
                            ClientIDMode="Static" ID="txtRemarks" runat="server" ValidationGroup="CMBillEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Bill Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBillStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMBillEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBillStatusID" runat="server" ControlToValidate="ddlBillStatusID"
                            ErrorMessage="Please Select Bill Status" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Approval Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBillApprovalStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            Enabled="false" runat="server" ValidationGroup="CMBillEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBillApprovalStatusID" runat="server" ControlToValidate="ddlBillApprovalStatusID"
                            ErrorMessage="Please Select Bill Approval Status" ValidationGroup="CMBillEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CMBillEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CMBillControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="CMBillControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="CMBillControl_Clear_key" />
                    </div>
                </div>
            </div>
            <div style="float: left; width: 470px;">
                <div class="TableRow" style="width: 100%;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Filter Text&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSearchText">
                            Type MRR</label>
                        <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                            Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                                OnCheckedChanged="chbxFilter_CheckedChanged" Text="Filter" /></span>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvPRMMaterialReceive" runat="server" DataSourceID="odsPRMMaterialReceive"
                            OnItemDataBound="lvPRMMaterialReceive_ItemDataBound">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="hi" style="width: 25px;">
                                            &nbsp;
                                        </td>
                                        <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByMRRNo"
                                                CommandName="Sort" Text="MRR No" CommandArgument="PRMMaterialReceive.MRRNo" />
                                        </td>
                                        <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByMRRDate"
                                                CommandName="Sort" Text="MRR Date" CommandArgument="PRMMaterialReceive.MRRDate" />
                                        </td>
                                        <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequisition"
                                                CommandName="Sort" Text="Requisition" CommandArgument="REQRequisition.RequisitionNo" />
                                        </td>
                                        <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByWorkOrder"
                                                CommandName="Sort" Text="Work Order" CommandArgument="PRMWorkOrder.WorkOrderNo" />
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
                                                    <asp:DataPager ID="dpListView" runat="server" PageSize="6">
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
                                    <td style="display: none;">
                                        <asp:Label ID="lblMaterialReceiveIDLV" Text='<%#Eval("MaterialReceiveID") %>' runat="server"></asp:Label>
                                    </td>
                                    <td class="i" style="width: 25px;">
                                        <asp:CheckBox ID="chbxSelectMRR" runat="server" />
                                    </td>
                                    <td class="i">
                                        <asp:HyperLink ID="hypMRRNo" Text='<%# Eval("MRRNo")%>' runat="server"></asp:HyperLink>
                                    </td>
                                    <td class="i">
                                        <%# Eval("MRRDate") != null ? ((DateTime)Eval("MRRDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequisitionNo")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("WorkOrderNo")%>
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
                                    <td style="display: none;">
                                        <asp:Label ID="lblMaterialReceiveIDLV" Text='<%#Eval("MaterialReceiveID") %>' runat="server"></asp:Label>
                                    </td>
                                    <td class="i" style="width: 25px;">
                                        <asp:CheckBox ID="chbxSelectMRR" runat="server" />
                                    </td>
                                    <td class="i">
                                        <asp:HyperLink ID="hypMRRNo" Text='<%# Eval("MRRNo")%>' runat="server"></asp:HyperLink>
                                    </td>
                                    <td class="i">
                                        <%# Eval("MRRDate") != null ? ((DateTime)Eval("MRRDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequisitionNo")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("WorkOrderNo")%>
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
                    <asp:ObjectDataSource ID="odsPRMMaterialReceive" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMMaterialReceive_DetailedDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsPRMMaterialReceive_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
                <br />
                <asp:CheckBox ID="chbxShowRequisitionItem" Text="Show Material Receive Item" runat="server"
                    OnCheckedChanged="chbxShowRequisitionItem_CheckedChanged" AutoPostBack="true">
                </asp:CheckBox>
                <%--<asp:Button ID="chbxShowRequisitionItem" Text="Show Details" runat="server"
                    OnClick="chbxShowRequisitionItem_CheckedChanged" AutoPostBack="true"></asp:Button>--%>
                <br />
                <br />
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvPRMMaterialReceiveItemMap" runat="server" DataSourceID="odsPRMMaterialReceiveItemMap"
                            OnItemCommand="lvPRMMaterialReceiveItemMap_ItemCommand">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="hi">
                                            Item
                                        </td>
                                        <td class="hi">
                                            Receive Qty
                                        </td>
                                        <td class="hi">
                                            Total Amount
                                        </td>
                                        <td class="hi">
                                            Bill Amount
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
                                        <asp:Label ID="lblMaterialReceiveIDLV" Text='<%# Eval("MaterialReceiveID")%>' runat="server"></asp:Label>
                                        <asp:Label ID="lblMaterialReceiveItemMapIDLV" Text='<%# Eval("MaterialReceiveItemMapID")%>'
                                            runat="server"></asp:Label>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                        <asp:Label ID="lblRequisitionItemIDLV" runat="server" Text='<%# Eval("RequisitionItemID")%>'></asp:Label>
                                        <asp:Label ID="lblWorkOrderItemMapIDLV" runat="server" Text='<%# Eval("WorkOrderItemMapID")%>'></asp:Label>
                                        <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'></asp:Label>
                                        <asp:Label ID="lblWorkOrderIDLV" runat="server" Text='<%# Eval("WorkOrderID")%>'></asp:Label>
                                        <asp:Label ID="lblItemLV" runat="server" Text='<%# Eval("ItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ItemName")%>
                                        <br />
                                        <asp:LinkButton ID="lnkRequisitionFloorDetail" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Modify The Total Qty Floor Wise!" Text="Floor Wise Qty"
                                            CommandName="FloorWiseRateAndQty" CommandArgument='<%#Eval("WorkOrderItemMapID")%>' />
                                    </td>
                                    <td class="i">
                                        <%# Eval("ReceiveQty")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("WOItemTotalRate")%>
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtBillPriceLV" runat="server" Text='<%# Eval("WOItemTotalRate")%>'
                                            CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
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
                                        <asp:Label ID="lblMaterialReceiveIDLV" Text='<%# Eval("MaterialReceiveID")%>' runat="server"></asp:Label>
                                        <asp:Label ID="lblMaterialReceiveItemMapIDLV" Text='<%# Eval("MaterialReceiveItemMapID")%>'
                                            runat="server"></asp:Label>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                        <asp:Label ID="lblRequisitionItemIDLV" runat="server" Text='<%# Eval("RequisitionItemID")%>'></asp:Label>
                                        <asp:Label ID="lblWorkOrderItemMapIDLV" runat="server" Text='<%# Eval("WorkOrderItemMapID")%>'></asp:Label>
                                        <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'></asp:Label>
                                        <asp:Label ID="lblWorkOrderIDLV" runat="server" Text='<%# Eval("WorkOrderID")%>'></asp:Label>
                                        <asp:Label ID="lblItemLV" runat="server" Text='<%# Eval("ItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ItemName")%>
                                        <br />
                                        <asp:LinkButton ID="lnkRequisitionFloorDetail" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Modify The Total Qty Floor Wise!" Text="Floor Wise Qty"
                                            CommandName="FloorWiseRateAndQty" CommandArgument='<%#Eval("WorkOrderItemMapID")%>' />
                                    </td>
                                    <td class="i">
                                        <%# Eval("ReceiveQty")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("WOItemTotalRate")%>
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtBillPriceLV" runat="server" Text='<%# Eval("WOItemTotalRate")%>'
                                            CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                    </td>
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="rpb">
                                        &nbsp;
                                    </td>
                                </tr>
                            </AlternatingItemTemplate>
                        </asp:ListView>
                    </div>
                    <asp:ObjectDataSource ID="odsPRMMaterialReceiveItemMap" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMMaterialReceiveItemMap_DetailedDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsPRMMaterialReceiveItemMap_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
            </div>
            <br />
            <br />
            <div style="float: left; width: 470px; padding-top: 10px;">
                <div class="listContentTitle">
                    Measurement Book List
                </div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMMeasurementBook" runat="server" DataSourceID="odsCMMeasurementBook"
                        OnItemDataBound="lvCMMeasurementBook_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width: 25px;">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySupplierName"
                                            CommandName="Sort" Text="Supplier" CommandArgument="PRMSupplier.SupplierName" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByBillNo"
                                            CommandName="Sort" Text="Bill No" CommandArgument="CMBill.BillNo" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByWorkOrderNo"
                                            CommandName="Sort" Text="Work Order No" CommandArgument="PRMWorkOrder.WorkOrderNo" />
                                    </td>
                                    <td class="hi">
                                        <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByItem"
                                            CommandName="Sort" Text="Item" CommandArgument="MDItem.ItemName" />
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
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="5">
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
                                <td style="display: none;">
                                    <asp:Label ID="lblMeasurementBookIDLV" runat="server" Text='<%# Eval("MeasurementBookID")%>'></asp:Label>
                                </td>
                                <td class="i" style="width: 25px;">
                                    <asp:CheckBox ID="chbxSelectMeasurementBook" runat="server" />
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderNo")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypItem" runat="server" ClientIDMode="Static" Text='<%# Eval("ItemName")%>'
                                        ToolTip="Please Click Here To Edit The Measurement Item!" CssClass="CommonLink"></asp:HyperLink>
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
                                <td style="display: none;">
                                    <asp:Label ID="lblMeasurementBookIDLV" runat="server" Text='<%# Eval("MeasurementBookID")%>'></asp:Label>
                                </td>
                                <td class="i" style="width: 25px;">
                                    <asp:CheckBox ID="chbxSelectMeasurementBook" runat="server" />
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkOrderNo")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypItem" runat="server" ClientIDMode="Static" Text='<%# Eval("ItemName")%>'
                                        ToolTip="Please Click Here To Edit The Measurement Item!" CssClass="CommonLink"></asp:HyperLink>
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsCMMeasurementBook" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMMeasurementBook_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMMeasurementBook_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
        <div style="clear: both;">
        </div>
        <br />
        <div style="width: 100%">
            <div class="listContentTitle">
                Bill List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMBill" runat="server" DataSourceID="odsCMBill" OnItemCommand="lvCMBill_ItemCommand"
                        OnItemDataBound="lvCMBill_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi">
                                        Bill No
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Vendor Category
                                    </td>
                                    <td class="hi">
                                        Due Date
                                    </td>
                                    <td class="hi">
                                        Vendor
                                    </td>
                                    <td class="hi">
                                        Amount
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Approval Status
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
                                    </td>
                                    <td class="his" style="width: 100px;">
                                        Upload Info
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
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillNo")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("VendorCategory")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillDate") != null ? ((DateTime)Eval("BillDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Amount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDBillApprovalStatusName")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MBill?')"
                                        CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Delete_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypUploadInfo" runat="server" CssClass="CommonButtonLink" Text="Upload Info"
                                        CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Upload_key" />
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
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillNo")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("VendorCategory")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillDate") != null ? ((DateTime)Eval("BillDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Amount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDBillApprovalStatusName")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MBill?')"
                                        CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Delete_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypUploadInfo" runat="server" CssClass="CommonButtonLink" Text="Upload Info"
                                        CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Upload_key" />
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsCMBill" runat="server" SelectMethod="GetPagedData" SelectCountMethod="TotalRowCount"
                    EnablePaging="true" MaximumRowsParameterName="pageSize" StartRowIndexParameterName="startRowIndex"
                    TypeName="Bay.ERP.Web.UI.CMBill_DetailedDataSource" SortParameterName="sortExpression"
                    OnSelecting="odsCMBill_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender2" runat="server" PopupControlID="Panel3"
            DynamicServicePath="" Enabled="True" TargetControlID="lnkFloorPopup" OkControlID="lnkFloorPopup"
            CancelControlID="btnFloorPopupCancel" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
        <div style="display: inline-block;">
            <asp:Panel ID="Panel3" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                <div class="modalPanelBackground">
                    <br />
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            &nbsp;
                        </div>
                        <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                            <asp:Button ID="Button2" runat="server" Text="X"></asp:Button>
                        </div>
                    </div>
                    <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                        padding-left: 10px;">
                        <tr>
                            <th rowspan="3" class="sized">
                                <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
                                    Width="20" Height="300" AlternateText="" />
                            </th>
                            <th class="topleft">
                            </th>
                            <td class="tbl-border-top">
                                &nbsp;
                            </td>
                            <th class="topright">
                            </th>
                            <th rowspan="3" class="sized">
                                <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
                                    Width="20" Height="300" AlternateText="" />
                            </th>
                        </tr>
                        <tr>
                            <td class="tbl-border-left">
                            </td>
                            <td>
                                <div class="table-content" style="width: 500px;">
                                    <div class="page-content">
                                        <h1>
                                            Modify Floor Detail Info</h1>
                                        <div>
                                            <div class="TableRow" style="width: 500px;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Item Name&nbsp;:
                                                </div>
                                                <div class="TableFormContent" style="padding-top: 10px;">
                                                    <asp:Label ID="lblFloorWiseItemName" runat="server" Font-Bold="true"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="lv-c" style="max-height: 200px; overflow-x: hidden;">
                                                <asp:ListView ID="lvREQRequisitionItemFloorDetail" runat="server" OnItemDataBound="lvREQRequisitionItemFloorDetail_ItemDataBound">
                                                    <LayoutTemplate>
                                                        <table class="lv" cellpadding="0" cellspacing="0">
                                                            <tr class="h">
                                                                <td class="hi" style="width: 12px;">
                                                                    &nbsp;
                                                                </td>
                                                                <td class="hi">
                                                                    Project Floor
                                                                </td>
                                                                <td class="hi">
                                                                    Qty
                                                                </td>
                                                                <td class="hi">
                                                                    Rate
                                                                </td>
                                                                <td class="hi">
                                                                    Remarks
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
                                                            <td class="i" style="display: none;">
                                                                <asp:Label ID="lblProjectFloorIDLV" runat="server" Text='<%# Eval("ProjectFloorID")%>'></asp:Label>
                                                            </td>
                                                            <td class="i">
                                                                <asp:CheckBox ID="chbxSelectLV" runat="server" />
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("BDProjectFloorName")%>
                                                            </td>
                                                            <td class="i">
                                                                <asp:TextBox ID="txtQtyLV" runat="server" Text='<%# Eval("Qty")%>' CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                                            </td>
                                                            <td class="i">
                                                                <asp:TextBox ID="txtRateLV" runat="server" Text='<%# Eval("Rate")%>' CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                                            </td>
                                                            <td class="i">
                                                                <asp:TextBox ID="txtRemarksLV" runat="server" Text='<%# Eval("Remarks")%>' CssClass="ktiTextBoxListview"></asp:TextBox>
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
                                                            <td class="i" style="display: none;">
                                                                <asp:Label ID="lblProjectFloorIDLV" runat="server" Text='<%# Eval("ProjectFloorID")%>'></asp:Label>
                                                            </td>
                                                            <td class="i">
                                                                <asp:CheckBox ID="chbxSelectLV" runat="server" />
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("BDProjectFloorName")%>
                                                            </td>
                                                            <td class="i">
                                                                <asp:TextBox ID="txtQtyLV" runat="server" Text='<%# Eval("Qty")%>' CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                                            </td>
                                                            <td class="i">
                                                                <asp:TextBox ID="txtRateLV" runat="server" Text='<%# Eval("Rate")%>' CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                                            </td>
                                                            <td class="i">
                                                                <asp:TextBox ID="txtRemarksLV" runat="server" Text='<%# Eval("Remarks")%>' CssClass="ktiTextBoxListview"></asp:TextBox>
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
                                        </div>
                                        <div class="TableRow" style="width: 100;">
                                            <div class="TableFormLeble" style="text-align: left;">
                                                &nbsp;
                                            </div>
                                            <div class="TableFormContent">
                                                <asp:LinkButton ID="lnkFloorPopup" runat="server"></asp:LinkButton>
                                                <asp:Button ID="btnFloorPopupSave" runat="server" Text="Ok" />
                                                <asp:Button ID="btnFloorPopupCancel" runat="server" Text="Cancel" />
                                            </div>
                                        </div>
                                        <div>
                                            <asp:Label ID="lblLockMessage" runat="server" Visible="false" ForeColor="Red" Font-Bold="true"
                                                Text="Locked : Can't Change any Information."></asp:Label>
                                        </div>
                                    </div>
                                    <div class="quick-links">
                                    </div>
                                    <div class="clear">
                                    </div>
                                </div>
                            </td>
                            <td class="tbl-border-right">
                            </td>
                        </tr>
                        <tr>
                            <th class="sized bottomleft">
                            </th>
                            <td class="tbl-border-bottom">
                                &nbsp;
                            </td>
                            <th class="sized bottomright">
                            </th>
                        </tr>
                    </table>
                </div>
            </asp:Panel>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
