<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 03-Feb-2013, 03:00:14
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACBankAccountDepositDetailsWithApproval.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACBankAccountDepositDetailsWithApprovalControl" %>
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
                            Deposit Date&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtDepositDate">
                                Enter Deposit Date</label>
                            <asp:TextBox ID="txtDepositDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                ValidationGroup="ACBankAccountDepositEntity" Width="150" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvDepositDate" runat="server" ControlToValidate="txtDepositDate"
                                ErrorMessage="Please Enter Deposit Date" ValidationGroup="ACBankAccountDepositEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RegularExpressionValidator ID="revDepositDate" runat="server" ControlToValidate="txtDepositDate"
                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                ValidationGroup="ACBankAccountDepositEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Reference&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtReference" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                ReadOnly="true" ValidationGroup="ACBankAccountDepositEntity" Width="150" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                </div>
                <div style="width: 360px; padding-top: 5px; border-right: 1px solid #C6C6C6; float: left;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Paid From&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlPaidFromID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                AutoPostBack="true" OnSelectedIndexChanged="ddlPaidFromID_SelectedIndexChanged"
                                ValidationGroup="ACBankAccountDepositEntity" Width="150">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvPaidFromID" runat="server" ControlToValidate="ddlPaidFromID"
                                ErrorMessage="Please Select Paid From" ValidationGroup="ACBankAccountDepositEntity"
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
                                    runat="server" ValidationGroup="ACBankAccountDepositEntity" Width="150">
                                </asp:DropDownList>
                                <span class="RequiredField">*</span>
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RequiredFieldValidator ID="rfvVendor" runat="server" ControlToValidate="ddlReferenceID"
                                    ErrorMessage="Please Enter Vendor" ValidationGroup="ACBankAccountDepositEntity"
                                    EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                    </asp:Panel>
                    <asp:Panel ID="pnlName" runat="server" Visible="false">
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                Name&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    ValidationGroup="ACBankAccountDepositEntity" Width="150" />
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
                                runat="server" ValidationGroup="ACBankAccountDepositEntity" Width="150">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvBankAccountID" runat="server" ControlToValidate="ddlBankAccountID"
                                ErrorMessage="Please Select Bank Account" ValidationGroup="ACBankAccountDepositEntity"
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
            <div style="min-height:76px; float:left;width:887px;padding-left:5px;">
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
                                    <asp:TextBox runat="server" ID="txtItemName" Width="645" autocomplete="off" ToolTip="Please Write The Account Name; Suggestion Will Come Automatically" ValidationGroup="ACBankAccountDepositItemEntity"
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
                                    ErrorMessage="Please Select Account" ValidationGroup="ACBankAccountDepositItemEntity"
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
                                    ValidationGroup="ACBankAccountDepositItemEntity" Width="180" />
                                <span class="RequiredField">*</span>
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RequiredFieldValidator ID="rfvAmount" runat="server" ControlToValidate="txtAmount"
                                    ErrorMessage="Please Enter Amount" ValidationGroup="ACBankAccountDepositItemEntity"
                                    EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                <asp:RangeValidator ID="rvAmount" runat="server" ControlToValidate="txtAmount" Display="Dynamic"
                                    EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                    MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="ACBankAccountDepositItemEntity"></asp:RangeValidator>
                            </div>
                        </div>
                    </div>
                    <div style="clear:both;"></div>
                    <div style="width: 660px; float: left;">
                        <div class="TableRow" style="width: 100;">
                           <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtMemoDetail">
                            Enter Memo</label>
                                <asp:TextBox ID="txtMemoDetail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server" Height="65"
                                    ValidationGroup="ACBankAccountDepositItemEntity" Width="645" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                    </div>
                    <div style="width: 220px; float: left;">
                       
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormContent">
                                <asp:Panel ID="pnlAdd" runat="server">
                                    <asp:Button ID="btnAddItem" ValidationGroup="ACBankAccountDepositItemEntity" OnClick="btnAddItem_Click"
                                        runat="server" Text="Add Items" />
                                </asp:Panel>
                                <asp:Panel ID="pnlUpdate" runat="server" Visible="false">
                                    <asp:Button ID="btnUpdate" ValidationGroup="ACBankAccountDepositItemEntity" OnClick="btnUpdate_Click"
                                        runat="server" Text="Update" />
                                    <asp:Button ID="btnCancel" ValidationGroup="ACBankAccountDepositItemEntity" OnClick="btnCancel_Click"
                                        runat="server" Text="Cancel" />
                                </asp:Panel>
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                    </div>
                    <div style="clear:both;"></div>
            </div>
             <div class="contentSeperator" style="min-height:200px;">
            </div>
            <div style="min-height:76px;float: left; padding-left:0px; width:210px;">
                    <div class="TableFormContent" style="width: 100;">
                        <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACBankAccountDepositItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                     <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACBankAccountDepositItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                     <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRequisitionID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlRequisitionID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACBankAccountDepositItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlWorkOrderID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlWorkOrderID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACBankAccountDepositItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBillID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACBankAccountDepositItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                     <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlProjectFloorID_SelectedIndexChanged"
                            runat="server" ValidationGroup="ACBankAccountDepositItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
                     <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectFloorUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="ACBankAccountDepositItemEntity" Width="200">
                        </asp:DropDownList>
                    </div>
            </div>
            <div style="clear:both;"></div>
                <br />
                <div style="width:100%;">
                    <div class="lv-c">
                        <asp:ListView ID="lvACBankAccountDepositItem" runat="server" OnItemCommand="lvACBankAccountDepositItem_ItemCommand">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="hi" style="width: 260px;">
                                            Account
                                        </td>
                                        <td class="hi" style="width: 120px;">
                                            Amount
                                        </td>
                                        <td class="hi" style="width: 150px;">
                                            Memo
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
                                       <asp:Label ID="lblMemoLV" runat="server" Text='<%# Eval("Memo")%>'></asp:Label>
                                    </td>
                                     <td class="i">
                                     <b>Project:</b> &nbsp;<%# Eval("ProjectName")%><br />
                                       <b>Requisition:</b> &nbsp; <%# Eval("RequisitionNo")%><br />
                                        <b>WorkOrder:</b> &nbsp;<%# Eval("WorkOrderNo")%><br />
                                        <b>Bill:</b> &nbsp;<%# Eval("BillNo")%><br />
                                        <b>Floor:</b> &nbsp;<%# Eval("ProjectFloorName")%><br />
                                        <b>Floor Unit:</b> &nbsp;<%# Eval("ProjectFloorUnitName")%><br />
                                        <b>Item:</b> &nbsp;<%# Eval("ItemName")%>
                                    </td>
                                    <td class="i">
                                        <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                            CommandName="EditItem" CommandArgument='<%#Eval("BankAccountDepositItemID")%>'
                                            UniqueKey="ACBankAccountDepositItem_lvACBankAccountDepositItem_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                            CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CBank Account Deposit Item?')"
                                            CommandArgument='<%#Eval("BankAccountDepositItemID")%>' UniqueKey="ACBankAccountDepositItem_lvACBankAccountDepositItem_Delete_key" />
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
                                       <asp:Label ID="lblMemoLV" runat="server" Text='<%# Eval("Memo")%>'></asp:Label>
                                    </td>
                                     <td class="i">
                                        <b>Project:</b> &nbsp;<%# Eval("ProjectName")%><br />
                                        <b>Requisition:</b> &nbsp; <%# Eval("RequisitionNo")%><br />
                                        <b>WorkOrder:</b> &nbsp;<%# Eval("WorkOrderNo")%><br />
                                        <b>Bill:</b> &nbsp;<%# Eval("BillNo")%><br />
                                        <b>Floor:</b> &nbsp;<%# Eval("ProjectFloorName")%><br />
                                        <b>Floor Unit:</b> &nbsp;<%# Eval("ProjectFloorUnitName")%><br />
                                        <b>Item:</b> &nbsp;<%# Eval("ItemName")%>
                                    </td>
                                    <td class="i">
                                        <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                            CommandName="EditItem" CommandArgument='<%#Eval("BankAccountDepositItemID")%>'
                                            UniqueKey="ACBankAccountDepositItem_lvACBankAccountDepositItem_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                            CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CBank Account Deposit Item?')"
                                            CommandArgument='<%#Eval("BankAccountDepositItemID")%>' UniqueKey="ACBankAccountDepositItem_lvACBankAccountDepositItem_Delete_key" />
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
                      <div style="font-size: 13px; font-weight: bold; color: Green; text-align:right;">
                Prepared By:
                <asp:Label ID="lblPreparedBy" runat="server"></asp:Label>
            </div>
                    <div style="font-size: 13px; font-weight: bold; color: Green; padding: 10px 0px 0px 257px;"
                        id="dvTotalValue" runat="server" visible="false">
                        Total Deposit Value:
                        <asp:Label ID="lblTotalValue" runat="server" Text="0"></asp:Label>
                    </div>
                </div>
                <br />
                </div>
                <br />
                <div style="text-align: center;">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Narration&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="860" ClientIDMode="Static"
                                ID="txtMemo" runat="server" ValidationGroup="ACBankAccountDepositEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                </div>
                </div>
                <br />
              
            </div>
            <br />
            <br />
            <div style="padding-left: 250px;">
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="ACBankAccountDepositEntity" OnClick="btnSave_Click"
                            runat="server" Text="Process Deposit" UniqueKey="ACBankAccountDepositControl_Submit_key" />
                        <%--<kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="ACBankAccountDepositControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="ACBankAccountDepositControl_Clear_key" />--%>
                    </div>
                </div>
            </div>
            <br />
             <div style="background-color: #EFEFEF;border: 1px solid;margin-bottom: 22px;padding: 8px;text-align: center;">
            <asp:HyperLink ID="hypReportLink" runat="server" Text="See Report Before Submit" Font-Bold="true"/>
            </div>
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
                                UniqueKey="ACBankAccountDepositDetailsWithApprovalControl_Approve_key" OnClick="btnApprove_Click" />
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
                                UniqueKey="ACBankAccountDepositDetailsWithApprovalControl_Reject_key" OnClick="btnReject_Click" />
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
                                UniqueKey="ACBankAccountDepositDetailsWithApprovalControl_Forward_key" OnClick="btnForward_Click" />
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
                                UniqueKey="ACBankAccountDepositDetailsWithApprovalControl_SubmitComment_key"
                                OnClick="btnSubmitComment_Click" />
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
        </div>
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
