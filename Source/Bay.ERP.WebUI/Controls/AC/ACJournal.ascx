<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 30-Jan-2013, 03:35:13
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACJournal.ascx.cs" Inherits="Bay.ERP.Web.UI.ACJournalControl" %>
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
                            Transaction Date&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtTransactionDateTime">
                                Transaction Date Time</label>
                            <asp:TextBox ID="txtTransactionDateTime" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                ValidationGroup="ACJournalEntity" Width="150" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvTransactionDateTime" runat="server" ControlToValidate="txtTransactionDateTime"
                                ErrorMessage="Transaction Date Time" ValidationGroup="ACJournalEntity" EnableViewState="False"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revTransactionDateTime" runat="server" ControlToValidate="txtTransactionDateTime"
                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                ValidationGroup="ACJournalEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                </div>
                <div style="width: 360px; padding-top: 5px; border-right: 1px solid #C6C6C6; float: left;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Reference&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtReferenceOrMemoOrID" ClientIDMode="Static" CssClass="ktiTextBox"
                                ReadOnly="true" runat="server" ValidationGroup="ACJournalEntity" Width="150" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                </div>
                <div style="width: 360px; padding-top: 5px; float: left;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Reverse Transaction&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:CheckBox ID="chkIsReverseTransaction" runat="server" ClientIDMode="Static" ValidationGroup="ACJournalEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                </div>
                <div style="clear: both;">
                </div>
            </div>
            <br />
            <br />
            <div style="width: 100%; border: 1px solid #C6C6C6;">
                <div style="min-height: 76px; float: left; width: 887px; padding-left: 5px;">
                    <div style="width: 450px; float: left;">
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
                                    <asp:TextBox runat="server" ID="txtItemName" Width="440" autocomplete="off" ToolTip="Please Write The Account Name; Suggestion Will Come Automatically"
                                        ValidationGroup="ACJournalEntity" ClientIDMode="Static" onkeyup="SetContextKey()" />
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
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtItemName"
                                    ErrorMessage="Please Select Account" ValidationGroup="ACBankAccountPaymentItemEntity"
                                    EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div style="width: 160px; float: left;">
                        <div class="TableFormLeble" style="text-align: center;">
                            Amount&nbsp;:
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormContent waterMarkContainer">
                                <label class="watermarkLabel" for="txtAmount">
                                    Enter Amount</label>
                                <asp:TextBox ID="txtAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                    ValidationGroup="ACJournalEntity" Width="122" />
                                <span class="RequiredField">*</span>
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RequiredFieldValidator ID="rfvAmount" runat="server" ControlToValidate="txtAmount"
                                    ErrorMessage="Please Enter Amount" ValidationGroup="ACJournalEntity" EnableViewState="False"
                                    Display="Dynamic"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="rvAmount" runat="server" ControlToValidate="txtAmount" Display="Dynamic"
                                    EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="1"
                                    MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="ACJournalEntity"></asp:RangeValidator>
                            </div>
                        </div>
                    </div>
                    <div style="width: 160px; float: left;">
                        <div class="TableFormLeble" style="text-align: center;">
                            Debit Credit&nbsp;:
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormContent">
                                <asp:DropDownList ID="ddlMDDebitCreditID" CssClass="ktiSelect" ClientIDMode="Static"
                                    runat="server" ValidationGroup="ACJournalEntity" Width="148">
                                </asp:DropDownList>
                                <span class="RequiredField">*</span>
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RequiredFieldValidator ID="rfvMDDebitCreditID" runat="server" ControlToValidate="ddlMDDebitCreditID"
                                    ErrorMessage="Please Select Debit Credit" ValidationGroup="ACJournalEntity" EnableViewState="False"
                                    Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </div>
                    <div style="width: 220px; float: left;">
                        <div class="TableFormLeble" style="text-align: center;">
                            &nbsp;
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormContent">
                                <asp:Panel ID="pnlAdd" runat="server">
                                    <asp:Button ID="btnAddItem" ValidationGroup="ACJournalEntity" OnClick="btnAddItem_Click"
                                        runat="server" Text="Add Items" />
                                </asp:Panel>
                                <asp:Panel ID="pnlUpdate" runat="server" Visible="false">
                                    <asp:Button ID="btnUpdate" ValidationGroup="ACJournalEntity" OnClick="btnUpdate_Click"
                                        runat="server" Text="Update" />
                                    <asp:Button ID="btnCancel" ValidationGroup="ACJournalEntity" OnClick="btnCancel_Click"
                                        runat="server" Text="Cancel" />
                                </asp:Panel>
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
                <div class="contentSeperator" style="min-height: 210px;">
                </div>
                <div style="min-height: 76px; float: left; padding-left: 0px; width: 200px;">
                    <div class="TableFormContent" style="width: 100;">
                        <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="ACJournalEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true"
                            OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged" runat="server" ValidationGroup="ACJournalEntity"
                            Width="200">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRequisitionID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlRequisitionID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACJournalEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlWorkOrderID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlWorkOrderID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACJournalEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBillID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="ACJournalEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlProjectFloorID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACJournalEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACJournalEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                </div>
                <div style="clear: both;">
                </div>
                <br />
                <div style="width: 100%;">
                    <div>
                        <div class="lv-c">
                            <asp:ListView ID="lvACJournal" runat="server" OnItemCommand="lvACJournal_ItemCommand">
                                <LayoutTemplate>
                                    <table class="lv" cellpadding="0" cellspacing="0">
                                        <tr class="h">
                                            <td class="rp">
                                                &nbsp;
                                            </td>
                                            <td class="hi" style="width: 260px;">
                                                Account
                                            </td>
                                            <td class="hi">
                                                Debit
                                            </td>
                                            <td class="hi">
                                                Credit
                                            </td>
                                            <td class="hi" style="display: none;">
                                                Note
                                            </td>
                                            <td class="hi" style="width: 170px;">
                                                Other Info
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
                                        <td style="display: none;">
                                            <asp:Label ID="lblAccountIDLV" runat="server" Text='<%# Eval("AccountID")%>'></asp:Label>
                                            <asp:Label ID="lblMDDebitCreditIDLV" runat="server" Text='<%# Eval("MDDebitCreditID")%>'></asp:Label>
                                            <asp:Label ID="lblAccountGroupIDLV" runat="server" Text='<%# Eval("AccountGroupID")%>'></asp:Label>
                                            <asp:Label ID="lblClassIDLV" runat="server" Text='<%# Eval("ClassID")%>'></asp:Label>
                                            <asp:Label ID="lblClassTypeIDLV" runat="server" Text='<%# Eval("ClassTypeID")%>'></asp:Label>
                                            <asp:Label ID="lblFiscalYearIDLV" runat="server" Text='<%# Eval("FiscalYearID")%>'></asp:Label>
                                            <asp:Label ID="lblItemIDLV" runat="server" Text='<%# Eval("ItemID")%>'></asp:Label>
                                            <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                            <asp:Label ID="lblWorkOrderIDLV" runat="server" Text='<%# Eval("WorkOrderID")%>'></asp:Label>
                                            <asp:Label ID="lblBillIDLV" runat="server" Text='<%# Eval("BillID")%>'></asp:Label>
                                            <asp:Label ID="lblProjectFloorUnitIDLV" runat="server" Text='<%# Eval("ProjectFloorUnitID")%>'></asp:Label>
                                            <asp:Label ID="lblProjectFloorIDLV" runat="server" Text='<%# Eval("ProjectFloorID")%>'></asp:Label>
                                            <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'></asp:Label>
                                        </td>
                                        <td class="i">
                                            <asp:Label ID="lblAccountNameLV" runat="server" Font-Bold="true" Text='<%# Eval("ACAccountAccountName")%>'></asp:Label>
                                        </td>
                                        <td class="i">
                                            <asp:Label ID="lblDebitAmountLV" runat="server" Text='<%# (Int64.Parse(Eval("MDDebitCreditID").ToString())) == 1 ?  Bay.ERP.Web.UI.MiscUtil.NumericCommaSeperatedFormat((Decimal)Eval("Amount")) : ""%>'></asp:Label>
                                        </td>
                                        <td class="i">
                                            <asp:Label ID="lblCreditAmountLV" runat="server" Text='<%# (Int64.Parse(Eval("MDDebitCreditID").ToString())) == 2 ? Bay.ERP.Web.UI.MiscUtil.NumericCommaSeperatedFormat((Decimal)Eval("Amount")) : ""%>'></asp:Label>
                                        </td>
                                        <td class="i" style="display: none;">
                                            <asp:Label ID="lblNoteLV" runat="server" Text='<%# Eval("Note")%>'></asp:Label>
                                        </td>
                                        <td class="i">
                                            <b>Project:</b> &nbsp;<%# Eval("BDProjectProjectName")%><br />
                                            <b>Requisition:</b> &nbsp;
                                            <%# Eval("RequisitionNo")%><br />
                                            <b>WorkOrder:</b> &nbsp;<%# Eval("WorkOrderNo")%><br />
                                            <b>Bill:</b> &nbsp;<%# Eval("BillNo")%><br />
                                            <b>Floor:</b> &nbsp;<%# Eval("ProjectFloorName")%><br />
                                            <b>Floor Unit:</b> &nbsp;<%# Eval("ProjectFloorUnitName")%><br />
                                            <b>Item:</b> &nbsp;<%# Eval("ItemName")%>
                                        </td>
                                        <td class="i">
                                            <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("TemporaryJournalID")%>'
                                                UniqueKey="ACJournal_lvACJournal_Edit_key" />
                                        </td>
                                        <td class="i">
                                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CJournal?')"
                                                CommandArgument='<%#Eval("TemporaryJournalID")%>' UniqueKey="ACJournal_lvACJournal_Delete_key" />
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
                                            <asp:Label ID="lblAccountIDLV" runat="server" Text='<%# Eval("AccountID")%>'></asp:Label>
                                            <asp:Label ID="lblMDDebitCreditIDLV" runat="server" Text='<%# Eval("MDDebitCreditID")%>'></asp:Label>
                                            <asp:Label ID="lblAccountGroupIDLV" runat="server" Text='<%# Eval("AccountGroupID")%>'></asp:Label>
                                            <asp:Label ID="lblClassIDLV" runat="server" Text='<%# Eval("ClassID")%>'></asp:Label>
                                            <asp:Label ID="lblClassTypeIDLV" runat="server" Text='<%# Eval("ClassTypeID")%>'></asp:Label>
                                            <asp:Label ID="lblFiscalYearIDLV" runat="server" Text='<%# Eval("FiscalYearID")%>'></asp:Label>
                                            <asp:Label ID="lblItemIDLV" runat="server" Text='<%# Eval("ItemID")%>'></asp:Label>
                                            <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                            <asp:Label ID="lblWorkOrderIDLV" runat="server" Text='<%# Eval("WorkOrderID")%>'></asp:Label>
                                            <asp:Label ID="lblBillIDLV" runat="server" Text='<%# Eval("BillID")%>'></asp:Label>
                                            <asp:Label ID="lblProjectFloorUnitIDLV" runat="server" Text='<%# Eval("ProjectFloorUnitID")%>'></asp:Label>
                                            <asp:Label ID="lblProjectFloorIDLV" runat="server" Text='<%# Eval("ProjectFloorID")%>'></asp:Label>
                                            <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'></asp:Label>
                                        </td>
                                        <td class="i">
                                            <asp:Label ID="lblAccountNameLV" runat="server" Font-Bold="true" Text='<%# Eval("ACAccountAccountName")%>'></asp:Label>
                                        </td>
                                        <td class="i">
                                            <asp:Label ID="lblDebitAmountLV" runat="server" Text='<%# (Int64.Parse(Eval("MDDebitCreditID").ToString())) == 1 ?  Bay.ERP.Web.UI.MiscUtil.NumericCommaSeperatedFormat((Decimal)Eval("Amount")) : ""%>'></asp:Label>
                                        </td>
                                        <td class="i">
                                            <asp:Label ID="lblCreditAmountLV" runat="server" Text='<%# (Int64.Parse(Eval("MDDebitCreditID").ToString())) == 2 ? Bay.ERP.Web.UI.MiscUtil.NumericCommaSeperatedFormat((Decimal)Eval("Amount")) : ""%>'></asp:Label>
                                        </td>
                                        <td class="i" style="display: none;">
                                            <asp:Label ID="lblNoteLV" runat="server" Text='<%# Eval("Note")%>'></asp:Label>
                                        </td>
                                        <td class="i">
                                            <b>Project:</b> &nbsp;<%# Eval("BDProjectProjectName")%><br />
                                            <b>Requisition:</b> &nbsp;
                                            <%# Eval("RequisitionNo")%><br />
                                            <b>WorkOrder:</b> &nbsp;<%# Eval("WorkOrderNo")%><br />
                                            <b>Bill:</b> &nbsp;<%# Eval("BillNo")%><br />
                                            <b>Floor:</b> &nbsp;<%# Eval("ProjectFloorName")%><br />
                                            <b>Floor Unit:</b> &nbsp;<%# Eval("ProjectFloorUnitName")%><br />
                                            <b>Item:</b> &nbsp;<%# Eval("ItemName")%>
                                        </td>
                                        <td class="i">
                                            <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("TemporaryJournalID")%>'
                                                UniqueKey="ACJournal_lvACJournal_Edit_key" />
                                        </td>
                                        <td class="i">
                                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CJournal?')"
                                                CommandArgument='<%#Eval("TemporaryJournalID")%>' UniqueKey="ACJournal_lvACJournal_Delete_key" />
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
                        <div style="font-size: 13px; font-weight: bold; color: Green; padding: 10px 0px 0px 257px;"
                            id="dvTotalValue" runat="server" visible="false">
                            Total Debit:
                            <asp:Label ID="lblTotalDebitValue" runat="server" Text="0"></asp:Label>
                            <br />
                            <br />
                            Total Credit:
                            <asp:Label ID="lblTotalCreditValue" runat="server" Text="0"></asp:Label>
                        </div>
                    </div>
                </div>
                <br />
                <br />
                <div style="text-align: center;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Narration&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextBox" Width="830" ClientIDMode="Static"
                                Height="106" ID="txtNote" runat="server" ValidationGroup="ACJournalEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                </div>
            </div>
            <div style="text-align: center; padding-left: 234px;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Appr. Proc. Panel&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAPPanelID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="ACJournalEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAPPanelID" runat="server" ControlToValidate="ddlAPPanelID"
                            ErrorMessage="Please Select Approval Process Panel" ValidationGroup="ACJournalEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <br />
        </div>
        <br />
        <br />
        <div>
            <div style="padding-left: 250px;">
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSaveAndGenerateReport" ValidationGroup="ACBankAccountDepositEntity"
                            OnClick="btnSaveAndGenerateReport_Click" runat="server" Text="Save & Generate Report" />
                        <asp:Button ID="btnInitiateApprovalProcess" ValidationGroup="none" OnClick="btnInitiateApprovalProcess_Click"
                            runat="server" Text="Save & Submit for Approval" />
                        <asp:HyperLink ID="hypReportLink" runat="server" Text="See Report" Visible="false" />
                    </div>
                </div>
            </div>
        </div>
        <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
