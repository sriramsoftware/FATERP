<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Dec-2012, 12:52:14
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVStoreIssueNoteItemMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVStoreIssueNoteItemMapControl" %>

<script language="javascript" type="text/javascript">
        function BindEvents() {
            $(document).ready(function () {
                $("#txtLandAreaKatha").keyup(function () {
                    $("#txtLandAreaSft").val($(this).val() * 720);
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
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
             <div style="float: left; width: 600px;">
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Item&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        AutoPostBack="true" OnSelectedIndexChanged="ddlItemID_SelectedIndexChanged" ValidationGroup="INVStoreIssueNoteItemMapEntity"
                        Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvItemID" runat="server" ControlToValidate="ddlItemID"
                        ErrorMessage="Please Select Item" ValidationGroup="INVStoreIssueNoteItemMapEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Folio No&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtFolioNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <asp:Panel ID="pnlRequestItemDetail" runat="server">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Request Qty&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtRequestQty">
                            Enter Request Qty</label>
                        <asp:TextBox ID="txtRequestQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRequestQty" runat="server" ControlToValidate="txtRequestQty"
                            ErrorMessage="Please Enter Request Qty" ValidationGroup="INVStoreIssueNoteItemMapEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvRequestQty" runat="server" ControlToValidate="txtRequestQty"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="1" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="INVStoreIssueNoteItemMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Amount&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server" ReadOnly="true"
                            ValidationGroup="INVStoreIssueNoteItemMapEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvAmount" runat="server" ControlToValidate="txtAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="INVStoreIssueNoteItemMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Purpose Of Works&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtPurposeOfWorks" runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="pnlIssueStoreDetail" runat="server">
            <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Batch Number&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBox" Width="230" ClientIDMode="Static" ReadOnly="true"
                            ID="txtBatchNo" runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" /><span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                     <asp:RequiredFieldValidator ID="rfvtxtBatchNo" runat="server" ControlToValidate="txtBatchNo"
                            ErrorMessage="Please Select At least Batch No" ValidationGroup="INVStoreIssueNoteItemMapEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Issue Qty&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtIssueQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static" ReadOnly="true" BackColor="Gray"
                            runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Type="Number"
                            Width="210" /><span style="padding-left:10px;"><asp:LinkButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Calculate"/></span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvIssueQty" runat="server" ControlToValidate="txtIssueQty"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="INVStoreIssueNoteItemMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Issued From Store&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlIssuedFromStoreID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlIssuedFromStoreID_SelectedIndexChanged"
                            runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Iss. From Store Unit&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlIssuedFromStoreUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvIssuedFromStoreUnitID" runat="server" ControlToValidate="ddlIssuedFromStoreUnitID"
                            ErrorMessage="Please Select Issued From Store Unit" ValidationGroup="INVStoreIssueNoteItemMapEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Issue Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtReceivedDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revReceivedDate" runat="server" ControlToValidate="txtReceivedDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="INVStoreIssueNoteItemMapEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Received By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlReceivedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            </asp:Panel>
            <asp:Panel ID="pnlReturnDetail" runat="server">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Return Qty&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtReturnQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Type="Number"
                            Width="210" /><span style="padding-left:10px;"><asp:LinkButton ID="lnkBtnReturnQty" OnClick="btnClear_Click" runat="server" Text="Calculate"/></span>
                    </div>
                    <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvtxtReturnQty" runat="server" ControlToValidate="txtReturnQty"
                            ErrorMessage="Please Enter Return Qty" ValidationGroup="INVStoreIssueNoteItemMapEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvReturnQty" runat="server" ControlToValidate="txtReturnQty"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="INVStoreIssueNoteItemMapEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Return Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtReturnDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revReturnDate" runat="server" ControlToValidate="txtReturnDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="INVStoreIssueNoteItemMapEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Return To Store&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlReturnToStoreID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlReturnToStoreID_SelectedIndexChanged"
                            runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Return To Store Unit&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlReturnToStoreUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Returned By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlReturnedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            </asp:Panel>
            <div class="TableRow" style="width: 100; display: none;">
                <div class="TableFormLeble" style="text-align: left;">
                    Actual Use&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtActualUse" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                        runat="server" ValidationGroup="INVStoreIssueNoteItemMapEntity" Type="Number"
                        Width="210" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RangeValidator ID="rvActualUse" runat="server" ControlToValidate="txtActualUse"
                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                        Type="Double" ValidationGroup="INVStoreIssueNoteItemMapEntity"></asp:RangeValidator>
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="INVStoreIssueNoteItemMapEntity"
                        OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="INVStoreIssueNoteItemMapControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" UniqueKey="INVStoreIssueNoteItemMapControl_AddNew_key" />
                </div>
            </div>
            <br />
          
            </div>
            <asp:Panel ID="pnllvTransaction" runat="server">
             <div style="float: left; width: 490px;">

             <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVTransaction" runat="server" DataSourceID="odsINVTransaction"
                        OnItemCommand="lvINVTransaction_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp" style="width:30px;">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width:40px;">
                                        Batch
                                    </td>
                                      <td class="hi" style="width:50px;">
                                        Price
                                    </td>
                                    <td class="hi" style="width:50px;">
                                        Available Qty
                                    </td>
                                    <td class="hi">
                                        Qty
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
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="10">
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
                            <td class="i" style="display:none;">
                            <asp:Label ID="lblBrandIDLV" runat="server" Text='<%#Eval("BrandID") %>'></asp:Label>
                            <asp:Label ID="lblRegionIDLV" runat="server" Text='<%#Eval("RegionID") %>'></asp:Label>
                            <asp:Label ID="lblCountryIDLV" runat="server" Text='<%#Eval("CountryID") %>'></asp:Label>
                            </td>
                                <td class="rp">
                                   <asp:CheckBox ID="chbxSelect" runat="server" AutoPostBack="true" OnCheckedChanged="chbxSelect_CheckedChanged" CommandName="EditItem" />
                                </td>
                                <td class="i">
                                   <asp:Label ID="lblBatchNumberLV" Text='<%# Eval("BatchNumber")%>' runat="server"></asp:Label>
                                </td>
                                 <td class="i">
                                   <asp:Label ID="lblUnitPriceLV" Text='<%# Eval("UnitPrice")%>' runat="server"></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblTransactionQtyLV" Text='<%# Eval("AvailableQty")%>' runat="server"></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtIssueQtyLV" runat="server" Text='<%# Eval("AvailableQty")%>' Visible="false" CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
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
                              <td class="i" style="display:none;">
                            <asp:Label ID="lblBrandIDLV" runat="server" Text='<%#Eval("BrandID") %>'></asp:Label>
                            <asp:Label ID="lblRegionIDLV" runat="server" Text='<%#Eval("RegionID") %>'></asp:Label>
                            <asp:Label ID="lblCountryIDLV" runat="server" Text='<%#Eval("CountryID") %>'></asp:Label>
                            </td>
                                <td class="rp">
                                  <asp:CheckBox ID="chbxSelect" runat="server" AutoPostBack="true" OnCheckedChanged="chbxSelect_CheckedChanged" CommandName="EditItem"/>
                                    </td>
                                <td class="i">
                                    <asp:Label ID="lblBatchNumberLV" Text='<%# Eval("BatchNumber")%>' runat="server"></asp:Label>
                                </td>
                                 <td class="i">
                                    <asp:Label ID="lblUnitPriceLV" Text='<%# Eval("UnitPrice")%>' runat="server"></asp:Label>
                                </td>
                                <td class="i">
                                  <asp:Label ID="lblTransactionQtyLV" Text='<%# Eval("AvailableQty")%>' runat="server"></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtIssueQtyLV" runat="server" Text='<%# Eval("AvailableQty")%>' Visible="false" CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
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
                <asp:ObjectDataSource ID="odsINVTransaction" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVTransactionAvailableQtyWithBatch_CustomDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVTransaction_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <br />
            <div style="padding-left:50px;">
            <asp:Label ID="lblCurrentStockQty" Font-Bold="true" ForeColor="Red" runat="server"></asp:Label>
            </div>
            
             </div>
             </asp:Panel>
              <asp:Panel ID="pnllvIssueNoteItemMap" runat="server">
               <div class="listContentTitle">
                Store Issue Note Item Map List
            </div>
               <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVStoreIssueNoteItemMap" runat="server" DataSourceID="odsINVStoreIssueNoteItemMap"
                        OnItemCommand="lvINVStoreIssueNoteItemMap_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Item
                                    </td>
                                    <td class="hi" style="width:40px;">
                                        Folio No
                                    </td>
                                    <td class="hi">
                                        Request Qty
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Issued From Store
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Issued From Store Unit
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Received Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Received By Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Return Qty
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Return Date
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Return To Store
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Return To Store Unit
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Returned By Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Actual Use
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Amount
                                    </td>
                                    <td class="hi">
                                        Purpose Of Works
                                    </td>
                                    <td class="his" style="display:none;">
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
                                    <%# Eval("MDItemItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FolioNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequestQty")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IssuedFromStoreID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IssuedFromStoreUnitID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReceivedDate") != null ? ((DateTime)Eval("ReceivedDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReceivedByMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnQty")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnDate") != null ? ((DateTime)Eval("ReturnDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnToStoreID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnToStoreUnitID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnedByMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ActualUse")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Amount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PurposeOfWorks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("StoreIssueNoteItemMapID")%>'
                                        UniqueKey="INVStoreIssueNoteItemMap_lvINVStoreIssueNoteItemMap_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVStore Issue Note Item Map?')"
                                        CommandArgument='<%#Eval("StoreIssueNoteItemMapID")%>' UniqueKey="INVStoreIssueNoteItemMap_lvINVStoreIssueNoteItemMap_Delete_key" />
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
                                    <%# Eval("MDItemItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FolioNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequestQty")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("INVStoreName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IssuedFromStoreUnitID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReceivedDate") != null ? ((DateTime)Eval("ReceivedDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReceivedByEmployeeID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnQty")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnDate") != null ? ((DateTime)Eval("ReturnDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnToStoreID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnToStoreUnitID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReturnedByMemberFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ActualUse")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Amount")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PurposeOfWorks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("StoreIssueNoteItemMapID")%>'
                                        UniqueKey="INVStoreIssueNoteItemMap_lvINVStoreIssueNoteItemMap_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVStore Issue Note Item Map?')"
                                        CommandArgument='<%#Eval("StoreIssueNoteItemMapID")%>' UniqueKey="INVStoreIssueNoteItemMap_lvINVStoreIssueNoteItemMap_Delete_key" />
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
                <asp:ObjectDataSource ID="odsINVStoreIssueNoteItemMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVStoreIssueNoteItemMap_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVStoreIssueNoteItemMap_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
             </asp:Panel>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
