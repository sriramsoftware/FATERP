<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 13-Dec-2012, 11:43:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACCPostPayableStatementDetail.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACCPostPayableStatementDetailControl" %>
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
</style>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="text-align: left; overflow: hidden;">
                <b>Ref #</b>&nbsp;:&nbsp;<asp:Label ID="lblRef" Font-Bold="true" runat="server"></asp:Label>
                <span style="text-align: right; padding-left: 570px;"><b>Start Date</b>&nbsp;: &nbsp;<asp:Label
                    ID="lblStartDate" Font-Bold="true" runat="server"></asp:Label>
                </span>
            </div>
            <div class="TableRow">
                <div style="text-align: left; padding-top: 4px; overflow: hidden;">
                    <b>CreateDate</b>&nbsp;:&nbsp;<asp:Label ID="lblCreateDate" Font-Bold="true" runat="server"></asp:Label>
                    <span style="padding-left: 545px;"><b>End Date</b>&nbsp;: &nbsp;<asp:Label ID="lblEndDate"
                        Font-Bold="true" runat="server"></asp:Label>
                    </span>
                </div>
            </div>
            <br />
            <br />
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACCPrePayableStatementDetail" runat="server" DataSourceID="odsACCPrePayableStatementDetail"
                        OnItemDataBound="lvACCPrePayableStatementDetail_ItemDataBound" DataKeyNames="PostPayableStatementDetailID"
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
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                </div>
                                <div class="TableInfo2">
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
                                        <%-- <asp:RangeValidator ID="rvWorkOrderAmount" runat="server" ControlToValidate="txtWorkOrderAmountLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RangeValidator>--%>
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        2. WO Date&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="txtWorkOrderDateLV" runat="server" ClientIDMode="Static" CssClass="lv-Label"
                                            Text='<%# Eval("WorkOrderDate") != null ? ((DateTime)Eval("WorkOrderDate")).ToString("dd-MM-yyyy") : ""%>'
                                            Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <%--<asp:RegularExpressionValidator ID="revWorkOrderDate" runat="server" ControlToValidate="txtWorkOrderDateLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                            ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RegularExpressionValidator>--%>
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        3. Paid Amount&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="txtPaidAmountLV" ClientIDMode="Static" CssClass="lv-Label" Text='<%# Eval("PaidAmount")%>'
                                            runat="server" Width="210" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <%--<asp:RangeValidator ID="rvPaidAmount" runat="server" ControlToValidate="txtPaidAmountLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RangeValidator>--%>
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
                                        <%--<asp:RangeValidator ID="rvSecurityMoney" runat="server" ControlToValidate="txtSecurityMoneyLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RangeValidator>--%>
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        5. TDS Amount&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblTDSAmountLV" ClientIDMode="Static" Text='<%# Eval("TDSAmount")%>'
                                            runat="server" CssClass="lv-Label" Width="210" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <%--<asp:RangeValidator ID="rvTDSAmount" runat="server" ControlToValidate="txtTDSAmountLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RangeValidator>--%>
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        6. Pay. Against WO&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:TextBox ID="txtPayableAgainstWorkOrderLV" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                            Text='<%# Eval("PayableAgainstWorkOrder")%>' runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            Type="Number" Width="210" />
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
                                        <%-- <asp:RangeValidator ID="rvApprovedBillAmount" runat="server" ControlToValidate="txtApprovedBillAmountLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                            Type="Double" ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RangeValidator>--%>
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        8. Net Payable&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <%-- <label class="watermarkLabel" for="txtNetPayableConsideringBillAndSecurity">
                                            Payable Considering Bill And Security</label>--%>
                                        <asp:TextBox ID="txtNetPayableConsideringBillAndSecurityLV" CssClass="ktiDecimalTextBox"
                                            ToolTip="Payable Considering Bill And Security" Text='<%# Eval("NetPayableConsideringBillAndSecurity")%>'
                                            ClientIDMode="Static" runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            Type="Number" Width="210" />
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
                                        12. Party Reconcile&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:CheckBox ID="chkPartyReconcileLV" runat="server" ClientIDMode="Static" ValidationGroup="ACCPrePayableStatementDetailEntity" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        11. Requisition No&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblRequisitionNoLV" ClientIDMode="Static" CssClass="lv-Label" runat="server"
                                            Text='<%# Eval("RequisitionNo")%>' />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Requisition Date&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblRequisitionDateLV" runat="server" ClientIDMode="Static" CssClass="lv-Label"
                                            Text='<%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString("dd-MM-yyyy") : ""%>'
                                            Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <%--<asp:RegularExpressionValidator ID="revRequisitionDate" runat="server" ControlToValidate="txtRequisitionDateLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                            ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RegularExpressionValidator>--%>
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        10. Bill No&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblBillNoLV" ClientIDMode="Static" runat="server" CssClass="lv-Label"
                                            Text='<%# Eval("BillNo")%>' Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        7. Bill Date&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblBillDateLV" runat="server" ClientIDMode="Static" CssClass="lv-Label"
                                            Text='<%# Eval("BillDate") != null ? ((DateTime)Eval("BillDate")).ToString("dd-MM-yyyy") : ""%>'
                                            Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <%--<asp:RegularExpressionValidator ID="revBillDate" runat="server" ControlToValidate="txtBillDateLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                            ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RegularExpressionValidator>--%>
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
                                        From Vendor&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:Label ID="lblVendorNameLV" runat="server" CssClass="lv-Label"></asp:Label>
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
                                <div class="TableInfo2" style="display: none;">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Planned Date&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:TextBox ID="txtPlannedDateLV" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                            Text='<%# Eval("PlannedDate") != null ? ((DateTime)Eval("PlannedDate")).ToString("dd-MM-yyyy") : ""%>'
                                            ValidationGroup="ACCPrePayableStatementDetailEntity" Width="230" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RegularExpressionValidator ID="revPlannedDate" runat="server" ControlToValidate="txtPlannedDateLV"
                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                            ValidationGroup="ACCPrePayableStatementDetailEntity"></asp:RegularExpressionValidator>
                                    </div>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="width: 800px;">
                                <div class="TableInfo1">
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
                                <div class="TableInfo2">
                                    <div class="TableFormLeble" style="text-align: left;">
                                        Payment Status&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:DropDownList ID="ddlACCPayablePaymentStatusIDLV" CssClass="ktiSelect" ClientIDMode="Static"
                                            runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity" Width="236">
                                        </asp:DropDownList>
                                        <span class="RequiredField">*</span>
                                    </div>
                                    <div class="TableFormValidatorContent">
                                        <asp:RequiredFieldValidator ID="rfvACCPayablePaymentStatusID" runat="server" ControlToValidate="ddlACCPayablePaymentStatusIDLV"
                                            ErrorMessage="Please Select Payable Payment Status" ValidationGroup="ACCPrePayableStatementDetailEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                    </div>
                                </div>
                                <div class="TableInfo2" style="display: none;">
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
                            <div style="width: 800px;">
                                <div class="TableInfo1">
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
                                        13. Remarks&nbsp;:
                                    </div>
                                    <div class="TableFormContent">
                                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                            Text='<%# Eval("Remarks")%>' ID="txtRemarksLV" runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity" />
                                    </div>
                                    <div class="TableFormValidatorContent">
                                    </div>
                                </div>
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
                                <div style="clear: both;">
                                </div>
                            </div>
                            <div style="display: none;">
                                <div class="TableFormLeble" style="text-align: left;">
                                    Ref&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:TextBox ID="txtRefLV" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                        Text='<%# Eval("Ref")%>' ValidationGroup="ACCPrePayableStatementDetailEntity"
                                        Width="230" />
                                </div>
                                <div class="TableFormValidatorContent">
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
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACCPostPayableStatementDetailDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACCPrePayableStatementDetail_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <br />
            <div class="TableRow" style="text-align: center; padding-left: 765px;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <asp:Button ID="btnMakePayment" OnClick="btnMakePayment_Click" runat="server" Text="Make Payment"
                        Visible="true" />
                    <kti:SecureButton ID="btnSubmit" OnClick="btnSave_Click" runat="server" Text="Save"
                        UniqueKey="ACCPostPayableStatementDetailControl_Submit_key" />
                </div>
            </div>
            <br />
            <br />
            <table>
                <tr>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Appr. Proc. Panel&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlAPPanelID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                ValidationGroup="APPanelMemberEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                            <kti:SecureButton ID="btnInitiateApprovalProcess" ValidationGroup="none" OnClick="btnInitiateApprovalProcess_Click"
                                runat="server" Text="Submit for Approval" UniqueKey="ACCPostPayableStatementDetailControl_InitiateApprovalProcess_key" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvAPPanelID" runat="server" ControlToValidate="ddlAPPanelID"
                                ErrorMessage="Please Select Approval Process Panel" ValidationGroup="APPanelMemberEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </tr>
                <tr style="padding-left: 250px;">
                    <td>
                    </td>
                    <td>
                    </td>
                    <td>
                        &nbsp;&nbsp;
                    </td>
                    <td>
                        <%--<kti:SecureButton ID="btnResetApprovalProcess" ValidationGroup="none" OnClick="btnResetApprovalProcess_Click"
                            runat="server" Text="Reset Approval Process" UniqueKey="CMBillUploadInfoControl_ResetApprovalProcess_key" Visible="false" />--%>
                    </td>
                </tr>
            </table>
            <br />
            <br />
        </div>

        <ajaxToolkit:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server" PopupControlID="Panel1"
            DynamicServicePath="" Enabled="True" TargetControlID="lnkTargetPopup" OkControlID="lnkTargetPopup"
            CancelControlID="btnPnlCancel" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
        <div>
            <asp:Panel ID="Panel1" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
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
                                <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
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
                                <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
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
                                            Account Info</h1>
                                        <div>
                                            <div class="TableRow" style="width: 500px;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent" style="padding-top: 10px;">
                                                    <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    Account&nbsp;:
                                                </div>
                                                <div class="TableFormContent">

                                                    <kti:BayGroupDropDownList ID="ddlACCAccountID" runat="server" CssClass="ktiSelect"
                                                        ClientIDMode="Static" ValidationGroup="ACBankAccountEntity" Width="234" />
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvACCAccountID" runat="server" ControlToValidate="ddlACCAccountID"
                                                        ErrorMessage="Please Select A CCAccount" ValidationGroup="ACBankAccountEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    Bank Account&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlBankAccountID" CssClass="ktiSelect" ClientIDMode="Static"
                                                        runat="server" ValidationGroup="ACBankAccountPaymentItemEntity" Width="236">
                                                    </asp:DropDownList>
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvBankAccountID" runat="server" ControlToValidate="ddlBankAccountID"
                                                        ErrorMessage="Please Select Bank Account" ValidationGroup="ACBankAccountPaymentItemEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    Amount Price&nbsp;:
                                                </div>
                                                <div class="TableFormContent waterMarkContainer">
                                                    <asp:TextBox ID="txtAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                        Width="210" />
                                                    <br />
                                                    <br />
                                                </div>
                                                <br />
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvPrice" runat="server" ControlToValidate="txtAmount"
                                                        ErrorMessage="Please Enter Price" ValidationGroup="PRMSupplierItemMapEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                    <asp:RangeValidator ID="rvPrice" runat="server" ControlToValidate="txtAmount" Display="Dynamic"
                                                        EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                        MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="PRMSupplierItemMapEntity"></asp:RangeValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:LinkButton ID="lnkTargetPopup" runat="server"></asp:LinkButton>
                                                    <kti:SecureButton ID="btnPnlSavePopup" runat="server" Text="Ok" OnClick="btnPnlSavePopup_Click"
                                                        ValidationGroup="ACBankAccountPaymentItemEntity" UniqueKey="ACCPostPayableStatementDetail_SavePopup_key" />
                                                    <kti:SecureButton ID="btnPnlCancel" runat="server" Text="Cancel" UniqueKey="ACCPostPayableStatementDetail_CancelPopup_key" />
                                                </div>
                                            </div>
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
