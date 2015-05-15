<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 13-Dec-2012, 11:43:49
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACCPostPayableStatementDetailWithApproval.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACCPostPayableStatementDetailWithApprovalControl" %>

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
        font-size:12px;
        font-weight:bold;
        padding-top:8px;
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
                <span style="text-align: right; padding-left: 570px;">
                <b>Start Date</b>&nbsp;: &nbsp;<asp:Label ID="lblStartDate" Font-Bold="true" runat="server"></asp:Label>
                </span>
            </div>
            <div class="TableRow">
                <div style="text-align: left; padding-top: 4px; overflow: hidden;">
                <b>CreateDate</b>&nbsp;:&nbsp;<asp:Label
                    ID="lblCreateDate" Font-Bold="true" runat="server"></asp:Label>
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
                                        <asp:Label ID="lblProjectNameLV" runat="server" CssClass="lv-Label" Font-Size="10" ></asp:Label>
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
                                            Text='<%# Eval("WorkOrderNo")%>'
                                            Width="230" />
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
                                        <asp:Label ID="lblWorkOrderAmountLV" ClientIDMode="Static" CssClass="lv-Label"
                                            Text='<%# Eval("WorkOrderAmount")%>' runat="server"
                                            Width="210" />
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
                                        <asp:Label ID="txtPaidAmountLV" ClientIDMode="Static" CssClass="lv-Label"
                                            Text='<%# Eval("PaidAmount")%>' runat="server"
                                            Width="210" />
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
                                        <asp:Label ID="lblSecurityMoneyLV" ClientIDMode="Static" CssClass="lv-Label"
                                            Text='<%# Eval("SecurityMoney")%>' runat="server"
                                            Width="210" />
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
                                        <asp:Label ID="lblTDSAmountLV" ClientIDMode="Static" Text='<%# Eval("TDSAmount")%>' runat="server" CssClass="lv-Label"
                                            Width="210" />
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
                                            Text='<%# Eval("ApprovedBillAmount")%>' runat="server"
                                             Width="210" />
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
                                        <asp:TextBox ID="txtNetPayableConsideringBillAndSecurityLV" CssClass="ktiDecimalTextBox" ToolTip="Payable Considering Bill And Security"
                                            Text='<%# Eval("NetPayableConsideringBillAndSecurity")%>' ClientIDMode="Static"
                                            runat="server" ValidationGroup="ACCPrePayableStatementDetailEntity" Type="Number"
                                            Width="210" />
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
                                        <asp:Label ID="lblRequisitionNoLV" ClientIDMode="Static" CssClass="lv-Label"
                                            runat="server" Text='<%# Eval("RequisitionNo")%>' />
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
                                            Text='<%# Eval("BillNo")%>'
                                            Width="230" />
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
                                <div class="TableInfo2" style="display:none;">
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
                                            ErrorMessage="Please Select A CCPayable Payment Status" ValidationGroup="ACCPrePayableStatementDetailEntity"
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
                            <div class="TableInfo2" style="display:none;">
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
                            <div style="display:none;">
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
             <div class="TableRow" style="text-align: center; padding-left: 570px;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit"
                        OnClick="btnSave_Click" runat="server" Text="Save" UniqueKey="ACCPostPayableStatementDetailWithApprovalControl_Submit_key" />
                </div>
            </div>
            <br />
            <br />
            <div style="width: 100%;">
            <div style="margin-left: auto; margin-right: auto; width: 550px; border: 1px Solid Gray;
                padding: 10px; padding-left: 50px;">
                <div style="width: 550px; text-align: center;">
                    <h3>
                        Approval Process Panel</h3>
                </div>
                <br />
                <div style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Action
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:DropDownList ID="ddlAction" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                            Width="236">
                        </asp:DropDownList>
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trRemarks" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Remarks
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trRejectTo" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Reject To
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:DropDownList ID="ddlRejectTo" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                            Width="236">
                        </asp:DropDownList>
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trForwardTo" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Forward To
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:DropDownList ID="ddlForwardTo" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                            Width="236">
                        </asp:DropDownList>
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trForwardRemarks" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Forward Remarks
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                            ID="txtForwardRemarks" runat="server" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trComment" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        Comment
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                        :</div>
                    <div style="width: 480px; float: left;">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                            ID="txtComment" runat="server" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trbtnApprove" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        &nbsp;
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                    </div>
                    <div style="width: 480px; float: left; padding-left: 10px;">
                        <kti:SecureButton ID="btnApprove" ValidationGroup="None" runat="server" Text="Approve"
                            UniqueKey="REQRequisitionApprovalProcessControl_Approve_key" OnClick="btnApprove_Click" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trbtnReject" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        &nbsp;
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                    </div>
                    <div style="width: 480px; float: left; padding-left: 10px;">
                        <kti:SecureButton ID="btnReject" ValidationGroup="None" runat="server" Text="Reject"
                            UniqueKey="REQRequisitionApprovalProcessControl_Reject_key" OnClick="btnReject_Click" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trbtnForward" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        &nbsp;
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                    </div>
                    <div style="width: 480px; float: left; padding-left: 10px;">
                        <kti:SecureButton ID="btnForward" ValidationGroup="None" runat="server" Text="Forward"
                            UniqueKey="REQRequisitionApprovalProcessControl_Forward_key" OnClick="btnForward_Click" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div id="trbtnSubmitComment" style="width: 650px;">
                    <div style="width: 120px; float: left; font-weight: bold;">
                        &nbsp;
                    </div>
                    <div style="width: 10px; float: left; font-weight: bold;">
                    </div>
                    <div style="width: 480px; float: left; padding-left: 10px;">
                        <kti:SecureButton ID="btnSubmitComment" ValidationGroup="None" runat="server" Text="Submit Comment"
                            UniqueKey="REQRequisitionApprovalProcessControl_SubmitComment_key" OnClick="btnSubmitComment_Click" />
                    </div>
                    <div style="clear: both;">
                    </div>
                    <br />
                </div>
                <div style="width: 550px;">
                    <div style="width: 510px; margin: 10px; padding: 10px;">
                        <div style="padding-bottom: 15px;">
                            <h3 style="color: #4B4B4B;">
                                All Remarks By Panel Members:</h3>
                        </div>
                        <div>
                            <asp:ListView ID="lvAPMemberFeedbackRemarks" runat="server" OnItemDataBound="lvAPMemberFeedbackRemarks_ItemDataBound">
                                <LayoutTemplate>
                                    <div runat="server" id="itemPlaceholder">
                                    </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <div style="padding-bottom: 20px;">
                                        <div style="padding-bottom: 3px;">
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="left">
                                                        <b>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.APPROVED ? ("<span style='color: green;'>" + Eval("APFeedbackName") + "</span>") : ("") %>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.REJECTED ? ("<span style='color: Red;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.FORWARDED ? ("<span style='color: Blue;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.FORWARD_RESPONSE_RECEIVED ? ("<span style='color: Blue;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                        </b><span style='color: gray;'><i>by <b>
                                                            <%# Eval("MemberFullName")%></b></i></span>
                                                    </td>
                                                    <td align="right">
                                                        on <b>
                                                            <%# Eval("RemarksDateTime") !=  null ? ((DateTime)Eval("RemarksDateTime")).ToString(UIConstants.SHORT_DATE_TIME_FORMAT) : ""%></b>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <div style="border-top: 1px solid gray; height: 1px; width: 100%;">
                                        </div>
                                        <div style="text-align: justify; letter-spacing: 0px; word-spacing: 0px; line-height: 18px;
                                            color: #4B4B4B; font-size: 12px; font-family: 'Verdana'; padding-top: 3px;">
                                            <%# Eval("Remarks")%>
                                        </div>
                                        <div id="forwardInfoDiv" runat="server">
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:ListView>
                        </div>
                    </div>
                </div>
                <br />
                <br />
            </div>
        </div>
         <script type="text/javascript">
             function uploadError(sender, args) {
             }
             function uploadComplete(sender, args) {
                 var btnClick = document.getElementById("btnClick");
                 btnClick.click();
             }
        </script>
        <script type="text/javascript">
            $(function () {
                function manageActionOptions(selectedAction) {
                    if (selectedAction == 1) {
                        $('#trRemarks').show();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').hide();
                        $('#trbtnApprove').show();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 2) {
                        $('#trRemarks').show();
                        $('#trRejectTo').show();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').hide();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').show();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 3) {
                        $('#trRemarks').show();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').show();
                        $('#trForwardRemarks').show();
                        $('#trComment').hide();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').show();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 4) {
                        $('#trRemarks').hide();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').show();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').show();
                    }
                }

                function CurrentPageLoad() {

                    $('#ddlAction').change(function () {

                        var selectedAction = $('#ddlAction').val();
                        manageActionOptions(selectedAction);
                    });

                    manageActionOptions($('#ddlAction').val());
                }

                CurrentPageLoad();

                var prm = Sys.WebForms.PageRequestManager.getInstance();
                prm.add_endRequest(function () {
                    $(function () {
                        CurrentPageLoad();
                    });
                });
            });
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
