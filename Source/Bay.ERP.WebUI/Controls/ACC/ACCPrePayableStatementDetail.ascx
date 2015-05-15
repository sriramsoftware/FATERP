<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 09-Dec-2012, 08:03:28
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACCPrePayableStatementDetail.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACCPrePayableStatementDetailControl" %>
<style type="text/css">
    .TableInfo1
    {
        width: 490px;
        float: left;
    }
    .TableInfo2
    {
        width: 950px;
    }
    .lv-Label
    {
        font-size: 12px;
        font-weight: bold;
        padding-top: 8px;
    }
    .hrdiv
    {
        color: ghostwhite;
        width: 1050px;
    }
</style>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="text-align: left; overflow: hidden;">
                <b>Ref #</b>&nbsp;:&nbsp;<asp:Label ID="lblRef" Font-Bold="true" runat="server"></asp:Label>
            </div>
            <div class="TableRow">
                <div style="text-align: left; padding-top: 4px; overflow: hidden;">
                    <b>CreateDate</b>&nbsp;:&nbsp;<asp:Label ID="lblCreateDate" Font-Bold="true" runat="server">
                    </asp:Label>
                    <span style="padding-left: 545px;"><b>Start Date</b>&nbsp;: &nbsp;<asp:Label
                    ID="lblStartDate" Font-Bold="true" runat="server"></asp:Label>
                    </span>
                    <span style="padding-left: 721px;"><b>End Date</b>&nbsp;: &nbsp;<asp:Label ID="lblEndDate"
                        Font-Bold="true" runat="server"></asp:Label>
                    </span>
                </div>
            </div>
            <br />
            <br />
            <div style="text-align: right;">
                <asp:HyperLink ID="hypEditSummary" runat="server" Text="Edit Summary"></asp:HyperLink>&nbsp;|&nbsp;
                <asp:HyperLink ID="hypPayableFromBill" runat="server" Text="Import From Bill / WO"></asp:HyperLink>
            </div>
            <br />
            <br />
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACCPrePayableStatementDetail" runat="server" DataSourceID="odsACCPrePayableStatementDetail"
                        OnItemDataBound="lvACCPrePayableStatementDetail_ItemDataBound" DataKeyNames="PrePayableStatementDetailID"
                        OnItemCommand="lvACCPrePayableStatementDetail_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                                <tr>
                                    <td colspan="100%">
                                        <div class="lv-FooterContainer">
                                            <div class="lv-Footer">
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="1">
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
                            <div style="display: none;">
                                <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'></asp:Label>
                                <asp:Label ID="lblVendorCategoryIDLV" runat="server" Text='<%# Eval("VendorCategoryID")%>'></asp:Label>
                                <asp:Label ID="lblVendorIDLV" runat="server" Text='<%# Eval("FromVendorID")%>'></asp:Label>
                                <asp:Label ID="lblWorkOrderIDLV" runat="server" Text='<%# Eval("WorkOrderID")%>'></asp:Label>
                                <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                <asp:CheckBox ID="chbxIsLockedLV" runat="server" Text='<%# Eval("IsLocked") != null ? (((Boolean)Eval("IsLocked")) ? "Yes" : "No") : ""%>'></asp:CheckBox>
                            </div>
                            <div style="text-align:right;padding:5px;">
                            <asp:Button ID="btnCalculate" OnClick="btnCalculate_OnClick" Text="Calculate" runat="server" />
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Project Name&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblProjectNameLV" runat="server" CssClass="lv-Label" Font-Size="10"></asp:Label>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Classification&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:DropDownList ID="ddlPayableClassificationIDLV" CssClass="ktiSelect" ClientIDMode="Static"
                                            runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity" Width="236">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        From Vendor&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblVendorNameLV" runat="server" CssClass="lv-Label"></asp:Label>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Payble Category&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:DropDownList ID="ddlAccountPaybleStatementDetailCategoryIDLV" CssClass="ktiSelect"
                                            ClientIDMode="Static" runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            Width="236">
                                        </asp:DropDownList>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Work Order No&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblWorkOrderNoLV" CssClass="lv-Label" ClientIDMode="Static" runat="server"
                                            Text='<%# Eval("WorkOrderNo")%>' Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        3. Paid Amount&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblPaidAmountLV" ClientIDMode="Static" CssClass="lv-Label" Text='<%# Eval("PaidAmount")%>'
                                            runat="server" Width="210" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        1. WO Amount&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblWorkOrderAmountLV" ClientIDMode="Static" CssClass="lv-Label" Text='<%# Eval("WorkOrderAmount")%>'
                                            runat="server" Width="210" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        4. Security Money&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblSecurityMoneyLV" ClientIDMode="Static" CssClass="lv-Label" Text='<%# Eval("SecurityMoney")%>'
                                            runat="server" Width="210" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        2. WO Date&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="txtWorkOrderDateLV" runat="server" ClientIDMode="Static" CssClass="lv-Label"
                                            Text='<%# Eval("WorkOrderDate") != null ? ((DateTime)Eval("WorkOrderDate")).ToString("dd-MM-yyyy") : ""%>'
                                            Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        5. TDS Amount&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <%--<asp:Label ID="lblTDSAmountLV" ClientIDMode="Static" Text='<%# Eval("TDSAmount")%>'
                                            runat="server" CssClass="lv-Label" Width="210" />--%>
                                          <asp:TextBox ID="txtTDSAmountLV" CssClass="ktiDecimalTextBox"
                                            ToolTip="TDS Amount" Text='<%# Eval("TDSAMount")%>'
                                            ClientIDMode="Static" runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            Type="Number" Width="210" /><span><asp:Button ID="btnDeduct" runat="server" Text="Deduct" OnClick="btnDeduct_Click" /></span>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    <asp:RangeValidator ID="rvtxtTDSAmountLV" runat="server" ControlToValidate="txtTDSAmountLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RangeValidator>
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    &nbsp
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        6. Pay. Against WO&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:TextBox ID="txtPayableAgainstWorkOrderLV" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                            Text='<%# Eval("PayableAgainstWorkOrder")%>' runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            Type="Number" Width="210" /><span>&nbsp;6=(1-3-4-5)</span>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvPayableAgainstWorkOrder" runat="server" ControlToValidate="txtPayableAgainstWorkOrderLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RangeValidator>
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <hr class="hrdiv" />
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        7. Bill Date&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblBillDateLV" runat="server" ClientIDMode="Static" CssClass="lv-Label"
                                            Text='<%# Eval("BillDate") != null ? ((DateTime)Eval("BillDate")).ToString("dd-MM-yyyy") : ""%>'
                                            Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        8. Net Payable&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:TextBox ID="txtNetPayableConsideringBillAndSecurityLV" CssClass="ktiDecimalTextBox"
                                            ToolTip="Payable Considering Bill And Security" Text='<%# Eval("NetPayableConsideringBillAndSecurity")%>'
                                            ClientIDMode="Static" runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            Type="Number" Width="210" />
                                        <span>8=(9-3-4-5)</span>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvNetPayableConsideringBillAndSecurity" runat="server" ControlToValidate="txtNetPayableConsideringBillAndSecurityLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RangeValidator>
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Temporary Status&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:DropDownList ID="ddlACCPayablePaymentStatusIDLV" CssClass="ktiSelect" ClientIDMode="Static"
                                            runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity" Width="236">
                                        </asp:DropDownList>
                                        <span class="RequiredField">*</span>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvACCPayablePaymentStatusID" runat="server" ControlToValidate="ddlACCPayablePaymentStatusIDLV"
                                            ErrorMessage="Please Select A CCPayable Payment Status" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Pay Only&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:TextBox ID="txtRefLV" ClientIDMode="Static" CssClass="ktiDecimalTextBox" runat="server"
                                            ValidationGroup="ACCPrePayableStatementDetailEntity" Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RangeValidator ID="rvRefLV" runat="server" ControlToValidate="txtRefLV" Display="Dynamic"
                                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RangeValidator>
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        9. App. Bill Amount&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblApprovedBillAmountLV" ClientIDMode="Static" CssClass="lv-Label"
                                            Text='<%# Eval("ApprovedBillAmount")%>' runat="server" Width="210" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        12. Party Reconcile&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:CheckBox ID="chkPartyReconcileLV" runat="server" ClientIDMode="Static" ValidationGroup="ACCPrePayableStatementDetailEntity" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        10. Bill No&nbsp;:
                                        <br />
                                        11. Requisition No&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblBillNoLV" ClientIDMode="Static" runat="server" CssClass="lv-Label"
                                            Text='<%# Eval("BillNo")%>' Width="230" />
                                        <br />
                                        <br />
                                        <asp:Label ID="lblRequisitionNoLV" ClientIDMode="Static" CssClass="lv-Label" runat="server"
                                            Text='<%# Eval("RequisitionNo")%>' />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblRequisitionDateLV" runat="server" ClientIDMode="Static" CssClass="lv-Label"
                                            Text='<%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString("dd-MM-yyyy") : ""%>'
                                            Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        13. Remarks&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                            Text='<%# Eval("Remarks")%>' ID="txtRemarksLV" runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <hr class="hrdiv" />
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                </div>
                                <div class="TableInfo2">
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px; display: none;">
                                <div class="TableInfo1">
                                </div>
                                <div class="TableInfo2" style="display: none;">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Additional Remarks&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                            Text='<%# Eval("AdditionalRemarks")%>' ID="txtAdditionalRemarksLV" runat="server"
                                            ValidationGroup="ACCPrePayableStatementDetailEntity" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Vendor Category&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblVendorCategoryNameLV" runat="server" CssClass="lv-Label"></asp:Label>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Approval Status&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:DropDownList ID="ddlACCPayableApprovalStatusIDLV" CssClass="ktiSelect" ClientIDMode="Static"
                                            runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity" Width="236">
                                        </asp:DropDownList>
                                        <span class="RequiredField">*</span>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvACCPayableApprovalStatusID" runat="server" ControlToValidate="ddlACCPayableApprovalStatusIDLV"
                                            ErrorMessage="Please Select A CCPayable Approval Status" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Show In Payable&nbsp;:
                                    </div>
                                    <div class="TableFormContent waterMarkContainer">
                                        <label class="watermarkLabel" for="txtDueDateLV">
                                            Enter Due Date</label>
                                        <asp:TextBox ID="txtDueDateLV" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                            Text='<%# Eval("DueDate") != null ? ((DateTime)Eval("DueDate")).ToString("dd-MM-yyyy") : ""%>'
                                            ValidationGroup="ACCPrePayableStatementDetailEntity" Width="230" />
                                        <span class="RequiredField">*</span>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvDueDate" runat="server" ControlToValidate="txtDueDateLV"
                                            ErrorMessage="Please Enter Due Date" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RegularExpressionValidator ID="revDueDate" runat="server" ControlToValidate="txtDueDateLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                            ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        AP Panel&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:DropDownList ID="ddlAPPanelIDLV" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                            ValidationGroup="ACCPrePayableStatementDetailEntity" Width="236">
                                        </asp:DropDownList>
                                        <span class="RequiredField">*</span>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvAPPanelID" runat="server" ControlToValidate="ddlAPPanelIDLV"
                                            ErrorMessage="Please Select A PPanel" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                </div>
                                <div class="TableInfo2" style="display: none;">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Planned Date&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:TextBox ID="txtPlannedDateLV" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                            Enabled="false" Text='<%# Eval("PlannedDate") != null ? ((DateTime)Eval("PlannedDate")).ToString("dd-MM-yyyy") : ""%>'
                                            ValidationGroup="ACCPrePayableStatementDetailEntity" Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RegularExpressionValidator ID="revPlannedDate" runat="server" ControlToValidate="txtPlannedDateLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                            ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div style="display: none;">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Is Removed&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="ACCPrePayableStatementDetailEntity" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsACCPrePayableStatementDetail" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACCPrePayableStatementDetailDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACCPrePayableStatementDetail_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <asp:Panel ID="pnlButtonOperation" runat="server" Enabled="false">
            <div class="TableRow" style="text-align: center; padding-left: 470px;">
            <asp:Label ID="lblFormLock" runat="server" Text="Note: The Pre Payable Statement has been Locked, no information can be changed." CssClass="msgLock" Visible="false"></asp:Label>
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="ACCPrePayableStatementDetailEntity"
                        OnClick="btnSave_Click" runat="server" Text="Save" UniqueKey="ACCPrePayableStatementDetailControl_Submit_key" />
                    <kti:SecureButton ID="btnRemoveFromPayable" ValidationGroup="ACCPrePayableStatementDetailEntity"
                        OnClick="btnRemoveFromPayable_Click" runat="server" Text="Remove From Payable"
                        UniqueKey="ACCPrePayableStatementDetailControl_btnRemoveFromPayable_key" />
                        <asp:Button ID="Report" ValidationGroup="ACCPrePayableStatementDetailEntity"
                        OnClick="btnReport_Click" runat="server" Text="Report"/>
                    <kti:SecureButton ID="btnGeneratePayable" ValidationGroup="ACCPrePayableStatementDetailEntity"
                        OnClick="btnGeneratePayable_Click" runat="server" Text="Post To Payable Report"
                        UniqueKey="ACCPrePayableStatementDetailControl_btnGeneratePayable_key" />
                </div>
            </div>
            </asp:Panel>
            <asp:Panel ID="pnlMoveToPayableStatement" runat="server">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Payable Statement&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlACCPrePayableStatementID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                ValidationGroup="ACCPrePayableStatement" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                              <asp:Button ID="btnMoveToPaybale" ValidationGroup="ACCPrePayableStatement" OnClick="btnMoveToPaybale_Click"
                            runat="server" Text="Move To Selected Payable"/>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvACCPrePayableStatementID" runat="server" ControlToValidate="ddlACCPrePayableStatementID"
                                ErrorMessage="Please Select Account Payable Statement" ValidationGroup="ACCPrePayableStatement"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                        </div>
            </asp:Panel>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
