<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 03-Feb-2013, 03:00:14
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACBankAccountPayment.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACBankAccountPaymentControl" %>
<script type="text/javascript">
    function ace1_itemSelected(sender, e) {
        $("#hdEmpID").val(e.get_value());
    }
    function SetContextKey() {
        var behavior = $find("AutoCompleteEx");
        behavior.set_contextKey(window.document.getElementById("hypProjectID").value.toString());
    }
    function BindEvents() {
        $(document).ready(function () {
            $('#txtItemName').keyup(function (event) {
                var KeyID = event.keyCode;
                if (KeyID != 13) {
                    $("#hdEmpID").val("0");
                }
            });
        });
    }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
        </script>
        <asp:HiddenField ID="hypProjectID" runat="server" Value="0" ClientIDMode="Static" />
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="width: 100%; border: 1px solid #C6C6C6;">
                <div style="width: 360px; padding-top: 5px; border-right: 1px solid #C6C6C6; float: left;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Payment Date&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtPaymentDate">
                                Enter Payment Date</label>
                            <asp:TextBox ID="txtPaymentDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                ValidationGroup="ACBankAccountPaymentEntity" Width="150" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvPaymentDate" runat="server" ControlToValidate="txtPaymentDate"
                                ErrorMessage="Please Enter Payment Date" ValidationGroup="ACBankAccountPaymentEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revPaymentDate" runat="server" ControlToValidate="txtPaymentDate"
                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                ValidationGroup="ACBankAccountPaymentEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Reference&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtReference" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ReadOnly="true" Text="Auto Assigned" ValidationGroup="ACBankAccountPaymentEntity"
                                Width="150" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                </div>
                <div style="width: 360px; padding-top: 5px; border-right: 1px solid #C6C6C6; float: left;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Pay To&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlPayToID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                AutoPostBack="true" OnSelectedIndexChanged="ddlPayToID_SelectedIndexChanged"
                                ValidationGroup="ACBankAccountPaymentEntity" Width="150">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvPayToID" runat="server" ControlToValidate="ddlPayToID"
                                ErrorMessage="Please Select Pay To" ValidationGroup="ACBankAccountPaymentEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <asp:Panel ID="pnlReference" runat="server" Visible="false">
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                <asp:Label ID="lblReference" runat="server"></asp:Label>
                            </div>
                            <div class="TableFormContent">
                                <asp:DropDownList ID="ddlReferenceID" CssClass="ktiSelect" ClientIDMode="Static"
                                    runat="server" ValidationGroup="ACBankAccountPaymentEntity" Width="150">
                                </asp:DropDownList>
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RequiredFieldValidator ID="rfvVendor" runat="server" ControlToValidate="ddlReferenceID"
                                    ErrorMessage="Please Enter Vendor" ValidationGroup="ACBankAccountPaymentEntity"
                                    EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="pnlName" runat="server" Visible="false">
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                To Order of&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    ValidationGroup="ACBankAccountPaymentEntity" Width="150" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                    </asp:Panel>
                </div>
                <div style="width: 360px; padding-top: 5px; float: left;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Bank Account&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlBankAccountID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="ACBankAccountPaymentItemEntity" Width="150">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvBankAccountID" runat="server" ControlToValidate="ddlBankAccountID"
                                ErrorMessage="Please Select Bank Account" ValidationGroup="ACBankAccountPaymentItemEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <div style="clear: both;">
                </div>
            </div>
            <br />
            <br />
            <div style="width:100%; border: 1px solid #C6C6C6;">
            <div style="min-height:76px; float:left;width:887px; padding-left:5px;">
             <div style="width: 655px; float: left;">
                        <div class="TableFormLeble" style="text-align: right;">
                            <asp:HyperLink CssClass="hypTableFormLeble" ID="hypAccount" runat="server" Text="Account"
                                NavigateUrl="~/AC/ACAccount.aspx" Target="_blank"></asp:HyperLink>
                            &nbsp;:
                        </div>
                         <div>
                        <asp:HiddenField ID="hdEmpID" ClientIDMode="Static" runat="server" Value="0" />
                    </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormContent">
                                <div>
                                    <asp:TextBox runat="server" ID="txtItemName" Width="645" autocomplete="off" ToolTip="Please Write The Account Name; Suggestion Will Come Automatically" ValidationGroup="ACBankAccountPaymentItemEntity"
                                        ClientIDMode="Static" onkeyup="SetContextKey()" />
                                    <ajaxToolkit:AutoCompleteExtender runat="server" BehaviorID="AutoCompleteEx" ID="autoComplete1"
                                        OnClientItemSelected="ace1_itemSelected" TargetControlID="txtItemName" ServicePath="~/WebServices/AutoCompleteAccount.asmx"
                                        ServiceMethod="GetCompletionItemList" MinimumPrefixLength="2" CompletionInterval="1000"
                                        EnableCaching="true" CompletionSetCount="20" CompletionListCssClass="autocomplete_completionListElement"
                                        CompletionListItemCssClass="autocomplete_listItem" CompletionListHighlightedItemCssClass="autocomplete_highlightedListItem"
                                        DelimiterCharacters=";:-" ShowOnlyCurrentWordInCompletionListItem="true" UseContextKey="true">
                                        <Animations>
                            <OnShow>
                                <Sequence>
                                    <%-- Make the completion list transparent and then show it --%>
                                    <OpacityAction Opacity="0" />
                                    <HideAction Visible="true" />
                            
                                    <%--Cache the original size of the completion list the first time
                                        the animation is played and then set it to zero --%>
                                    <ScriptAction Script="
                                        // Cache the size and setup the initial size
                                        var behavior = $find('AutoCompleteEx');
                                        if (!behavior._height) {
                                            var target = behavior.get_completionList();
                                            behavior._height = target.offsetHeight - 2;
                                            target.style.height = '0px';
                                        }" />
                            
                                    <%-- Expand from 0px to the appropriate size while fading in --%>
                                    <Parallel Duration=".4">
                                        <FadeIn />
                                        <Length PropertyKey="height" StartValue="0" EndValueScript="$find('AutoCompleteEx')._height" />
                                    </Parallel>
                                </Sequence>
                            </OnShow>
                            <OnHide>
                                <%-- Collapse down to 0px and fade out --%>
                                <Parallel Duration=".4">
                                    <FadeOut />
                                    <Length PropertyKey="height" StartValueScript="$find('AutoCompleteEx')._height" EndValue="0" />
                                </Parallel>
                            </OnHide>
                                        </Animations>
                                    </ajaxToolkit:AutoCompleteExtender>
                                </div>
                                <span class="RequiredField">*</span>
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RequiredFieldValidator ID="rfvAccountID" runat="server" ControlToValidate="txtItemName"
                                    ErrorMessage="Please Select Account" ValidationGroup="ACBankAccountPaymentItemEntity"
                                    EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                     
                    <div style="width: 220px; float: left;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Amount&nbsp;:
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormContent waterMarkContainer">
                                <label class="watermarkLabel" for="txtAmount">
                                    Enter Amount</label>
                                <asp:TextBox ID="txtAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                    ValidationGroup="ACBankAccountPaymentItemEntity" Width="180" />
                                <span class="RequiredField">*</span>
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RequiredFieldValidator ID="rfvAmount" runat="server" ControlToValidate="txtAmount"
                                    ErrorMessage="Please Enter Amount" ValidationGroup="ACBankAccountPaymentItemEntity"
                                    EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="rvAmount" runat="server" ControlToValidate="txtAmount" Display="Dynamic"
                                    EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="1"
                                    MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="ACBankAccountPaymentItemEntity"></asp:RangeValidator>
                            </div>
                        </div>
                    </div>
                    <div style="clear:both;"></div>
                    <div style="width: 660px; float: left;">
                        <div class="TableRow" style="width: 100;">
                           <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtMemoDetail">
                            Enter Memo</label>
                                <asp:TextBox ID="txtMemoDetail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server" TextMode="MultiLine"  Height="65"
                                    ValidationGroup="ACBankAccountPaymentItemEntity" Width="645" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                    </div>
                    <div style="width: 220px; float: left;">
                       
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormContent">
                                <asp:Panel ID="pnlAdd" runat="server">
                                    <asp:Button ID="btnAddItem" ValidationGroup="ACBankAccountPaymentItemEntity" OnClick="btnAddItem_Click"
                                        runat="server" Text="Add Items" />
                                </asp:Panel>
                                <asp:Panel ID="pnlUpdate" runat="server" Visible="false">
                                    <asp:Button ID="btnUpdate" ValidationGroup="ACBankAccountPaymentItemEntity" OnClick="btnUpdate_Click"
                                        runat="server" Text="Update" />
                                    <asp:Button ID="btnCancel" ValidationGroup="ACBankAccountPaymentItemEntity" OnClick="btnCancel_Click"
                                        runat="server" Text="Cancel" />
                                </asp:Panel>
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                    </div>
                    <div style="clear:both;"></div>
            </div>
             <div class="contentSeperator" style="min-height:210px;">
            </div>
            <div style="min-height:76px;float: left; width:200px;">
                    <div class="TableFormContent" style="width: 100;">
                        <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACBankAccountPaymentItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                     <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACBankAccountPaymentItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                     <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRequisitionID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlRequisitionID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACBankAccountPaymentItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlWorkOrderID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlWorkOrderID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACBankAccountPaymentItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBillID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACBankAccountPaymentItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                     <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlProjectFloorID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACBankAccountPaymentItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                     <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACBankAccountPaymentItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
            </div>
            <div style="clear:both;"></div>
           
                <br />
                <div style="width:100%">
                    <div class="lv-c">
                        <asp:ListView ID="lvACBankAccountPaymentItem" runat="server" OnItemCommand="lvACBankAccountPaymentItem_ItemCommand">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        </td>
                                        <td class="hi" style="width: 260px;">
                                            Account
                                        </td>
                                        <td class="hi" style="width: 120px;">
                                            Amount
                                        </td>
                                        <td class="hi" style="width: 170px;">
                                            Other Info
                                        </td>
                                        <td class="hi" style="width: 150px;">
                                            Memo
                                        </td>
                                        <td class="his">
                                            EDIT
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
                                    <td class="i" style="display:none;">
                                        <%# Eval("ItemID")%>
                                        <%# Eval("ProjectID")%>
                                        <%# Eval("ProjectFloorID")%>
                                        <%# Eval("ProjectFloorUnitID")%>
                                        <%# Eval("BillID")%>
                                        <%# Eval("RequisitionID")%>
                                        <%# Eval("WorkOrderID")%>
                                    </td>
                                    <td style="display:none;">
                                    <asp:Label ID="lblAccountIDLV" runat="server" Text='<%# Eval("AccountID")%>'></asp:Label>
                                    <asp:Label ID="lblDimensionIDLV" runat="server" Text='<%# Eval("DimensionID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                      <asp:Label ID="lblAccountNameLV" runat="server" Font-Bold="true" Text='<%# Eval("AccountName")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                       <asp:Label ID="lblAmountLV" runat="server" Text='<%# Bay.ERP.Web.UI.MiscUtil.NumericCommaSeperatedFormat((Decimal)Eval("Amount"))%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                      <b>Project:</b> &nbsp;<%# Eval("ProjectName")%><br />
                                       <b>Requisition:</b> &nbsp;<asp:HyperLink ID="hypRequisitionLV" runat="server" Text='<%# Eval("RequisitionNo")%>'></asp:HyperLink> <br />
                                        <b>WorkOrder:</b> &nbsp;<asp:HyperLink ID="hypWorkOrderLV" runat="server" Text='<%# Eval("WorkOrderNo")%>'></asp:HyperLink> <br />
                                        <b>Bill:</b> &nbsp;<%# Eval("BillNo")%><br />
                                        <b>Floor:</b> &nbsp;<%# Eval("ProjectFloorName")%><br />
                                        <b>Floor Unit:</b> &nbsp;<%# Eval("ProjectFloorUnitName")%><br />
                                        <b>Item:</b> &nbsp;<%# Eval("ItemName")%>
                                    </td>
                                    <td class="i">
                                       <asp:Label ID="lblMemoLV" runat="server" Text='<%# Eval("Memo")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        &nbsp;
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("BankAccountPaymentItemID")%>'
                                            UniqueKey="ACBankAccountPaymentItem_lvACBankAccountPaymentItem_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Bank Account Payment Item?')"
                                            CommandArgument='<%#Eval("BankAccountPaymentItemID")%>' UniqueKey="ACBankAccountPaymentItem_lvACBankAccountPaymentItem_Delete_key" />
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
                                     <td class="i" style="display:none;">
                                        <%# Eval("ItemID")%>
                                        <%# Eval("ProjectID")%>
                                        <%# Eval("ProjectFloorID")%>
                                        <%# Eval("ProjectFloorUnitID")%>
                                        <%# Eval("BillID")%>
                                        <%# Eval("RequisitionID")%>
                                        <%# Eval("WorkOrderID")%>
                                    </td>

                                   <td style="display:none;">
                                    <asp:Label ID="lblAccountIDLV" runat="server" Text='<%# Eval("AccountID")%>'></asp:Label>
                                    <asp:Label ID="lblDimensionIDLV" runat="server" Text='<%# Eval("DimensionID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                      <asp:Label ID="lblAccountNameLV" runat="server" Font-Bold="true" Text='<%# Eval("AccountName")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                       <asp:Label ID="lblAmountLV" runat="server" Text='<%# Bay.ERP.Web.UI.MiscUtil.NumericCommaSeperatedFormat((Decimal)Eval("Amount"))%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                      <b>Project:</b> &nbsp;<%# Eval("ProjectName")%><br />
                                       <b>Requisition:</b> &nbsp;<asp:HyperLink ID="hypRequisitionLV" runat="server" Text='<%# Eval("RequisitionNo")%>'></asp:HyperLink> <br />
                                        <b>WorkOrder:</b> &nbsp;<asp:HyperLink ID="hypWorkOrderLV" runat="server" Text='<%# Eval("WorkOrderNo")%>'></asp:HyperLink> <br />
                                        <b>Bill:</b> &nbsp;<%# Eval("BillNo")%><br />
                                        <b>Floor:</b> &nbsp;<%# Eval("ProjectFloorName")%><br />
                                        <b>Floor Unit:</b> &nbsp;<%# Eval("ProjectFloorUnitName")%><br />
                                        <b>Item:</b> &nbsp;<%# Eval("ItemName")%>
                                    </td>
                                    <td class="i">
                                       <asp:Label ID="lblMemoLV" runat="server" Text='<%# Eval("Memo")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        &nbsp;
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("BankAccountPaymentItemID")%>'
                                            UniqueKey="ACBankAccountPaymentItem_lvACBankAccountPaymentItem_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Bank Account Payment Item?')"
                                            CommandArgument='<%#Eval("BankAccountPaymentItemID")%>' UniqueKey="ACBankAccountPaymentItem_lvACBankAccountPaymentItem_Delete_key" />
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
                    <div style="font-size: 13px; font-weight: bold; color: Green; padding:10px 0px 0px 257px;" ID="dvTotalValue" runat="server" visible="false">
                Total Payment Value:
                <asp:Label ID="lblTotalValue" runat="server" Text="0"></asp:Label>
            </div>
                </div>
                <br />
                <br />
                  </div>
                <br />
                <br />
                <div style="text-align: center;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Narration&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="860" ClientIDMode="Static"
                                ID="txtMemo" runat="server" ValidationGroup="ACBankAccountPaymentEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                </div>
                <br />
                <div style="text-align: center; padding-left: 234px;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Appr. Proc. Panel&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlAPPanelID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                ValidationGroup="ACBankAccountPaymentEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvAPPanelID" runat="server" ControlToValidate="ddlAPPanelID"
                                ErrorMessage="Please Select Approval Process Panel" ValidationGroup="ACBankAccountPaymentEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                </div>
                <br />
                <br />
            </div>
            <br />
            <div style="padding-left: 250px;">
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                    <asp:Button ID="btnSaveAndGenerateReport" ValidationGroup="ACBankAccountDepositEntity"
                            OnClick="btnSaveAndGenerateReport_Click" runat="server" Text="Save & Generate Report" />
                        <asp:Button ID="btnInitiateApprovalProcess" ValidationGroup="ACBankAccountPaymentEntity"
                            OnClick="btnInitiateApprovalProcess_Click" runat="server" Text="Save & Submit for Approval" />
                             <asp:HyperLink ID="hypReportLink" runat="server" Text="See Report" Visible="false" />
                    </div>
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
