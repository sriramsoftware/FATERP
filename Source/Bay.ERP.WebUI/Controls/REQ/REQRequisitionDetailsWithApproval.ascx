<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Jan-2012, 04:11:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="REQRequisitionDetailsWithApproval.ascx.cs"
    Inherits="Bay.ERP.Web.UI.REQRequisitionDetailsWithApprovalControl" %>
 <script type="text/javascript">
     function uploadError(sender, args) {
     }
     function uploadComplete(sender, args) {
         var btnClick = document.getElementById("btnClick");
         btnClick.click();
     }
        </script>
<%--<style type="text/css">--%>
<asp:ScriptManagerProxy ID="ScriptManagerProxy1" runat="server">
</asp:ScriptManagerProxy>
<asp:UpdatePanel ID="upMauin" runat="server">
     <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnClick" EventName="Click" />
    </Triggers>
    <ContentTemplate>
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
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
        </script>
    <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
            ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="true"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <asp:HiddenField ID="hypProjectID" runat="server" Value="0" ClientIDMode="Static" />
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div class="TableRow">
                <div style="text-align: left; overflow:hidden;">
                      <b>Project Name</b>&nbsp;:&nbsp;<asp:Label ID="lblProjectName" Font-Bold="true"
                            runat="server"></asp:Label>
                        <span style="text-align:right;padding-left:570px;">
                    <b>Requisition No</b>&nbsp;:&nbsp;<asp:Label ID="lblRequisitonNo" Font-Bold="true"
                        runat="server"></asp:Label>        
                        </span>
                </div>
                <div class="TableRow">
                    <div style="text-align: left; padding-top: 4px; overflow:hidden;">
                    <b>Project Code</b>&nbsp;: &nbsp;<asp:Label ID="lblProjectCode" Font-Bold="true"
                            runat="server"></asp:Label>
                            <span style="padding-left:700px;">
                        <b>Requisition Date</b>&nbsp;: &nbsp;<asp:Label ID="lblRequisitonDate" Font-Bold="true"
                        runat="server"></asp:Label>    
                        </span>
                    
                    </div>
                </div>
                <div style="text-align: left; padding-top: 2px; padding-left:832px; overflow:hidden;">
                        <b><asp:Label runat="server" ID="lblCashPayment" Text="Cash Payment"></asp:Label></b>&nbsp;: &nbsp; &nbsp;<asp:Label ID="lblPayment" Font-Bold="true"
                            runat="server"></asp:Label>
                    </div>
                    <br />
                <div id="addPanel" runat="server">
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Item Name&nbsp;:
                        </div>
                        <div>
                            <asp:HiddenField ID="hdEmpID" ClientIDMode="Static" runat="server" Value="0" />
                        </div>
                        <div>
                            <asp:TextBox runat="server" ID="txtItemName" Width="300" autocomplete="off" ToolTip="Please Write The Item Name; Suggestion Will Come Automatically"
                                ClientIDMode="Static" onkeyup="SetContextKey()" />
                            <ajaxToolkit:AutoCompleteExtender runat="server" BehaviorID="AutoCompleteEx" ID="autoComplete1"
                                OnClientItemSelected="ace1_itemSelected" TargetControlID="txtItemName" ServicePath="~/WebServices/AutoComplete.asmx"
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
                    </div>
                    <div class="TableFormContent" style="padding-left: 160px;">
                        <kti:SecureButton ID="btnAdd" ValidationGroup="REQRequisitionItemEntity" runat="server"
                            ToolTip="Please Click Here To Add Item To This Requisition!" Text="Add" UniqueKey="REQRequisitionItemControl_Submit_key"
                            OnClick="btnAdd_Click" />
                        <div class="TableFormLeble" style="text-align: right; padding-left: 750px;">
                          <%--  <asp:HyperLink ID="hypRequisitionReport" runat="server" Text="Report"></asp:HyperLink>--%>
                        </div>
                    </div>
                </div>
                <div class="TableFormContent" style="padding-left: 160px;">
                        <div class="TableFormLeble" style="text-align: right; padding-left: 750px;">
                            <asp:HyperLink ID="hypRequisitionReport" runat="server" Text="Report"></asp:HyperLink>
                        </div>
                    </div>
                <div class="listContentTitle">
                </div>
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvREQRequisitionItem" runat="server" DataSourceID="odsREQRequisitionItem"
                            OnItemDataBound="lvREQRequisitionItem_ItemDataBound" OnItemCommand="lvREQRequisitionItem_ItemCommand">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="hx">
                                        <td class="rp" style="display:none;">
                                            &nbsp;
                                        </td>
                                        <td class="hi" style="width: 75px; text-align:center;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByAccCode" ForeColor="Gray" Font-Bold="true"
                                                CommandName="Sort" Text="Acc Code" CommandArgument="REQRequisitionItem.AccountsCode" />
                                        </td>
                                        <td class="hi" style="width: 190px; text-align:center;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByItem" ForeColor="Gray" Font-Bold="true"
                                                CommandName="Sort" Text="Item" CommandArgument="MDItem.ItemName" />
                                        </td>
                                        <td class="hi" style="width: 30px; text-align:center;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByUnit" ForeColor="Gray" Font-Bold="true"
                                                CommandName="Sort" Text="Unit" CommandArgument="MDUnit.UnitName" />
                                        </td>
                                        <td class="hi" style="display: none;">
                                        </td>
                                        <td class="hi" style="width: 90px; text-align:center;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByTotalReqQty" ForeColor="Gray" Font-Bold="true"
                                                CommandName="Sort" Text="Total Req. Qty" CommandArgument="REQRequisitionItem.TotalRequiredQty" />
                                        </td>
                                         <td class="hi" style="width: 90px; text-align:center;">
                                               <asp:Label ID="lblAvailableQtyForRequisition" runat="server" Text="Available Qty For Req" ForeColor="Gray" Font-Bold="true"></asp:Label>
                                        </td>
                                        <td class="hi" style="width: 100px; text-align:center;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPurchasedQty" ForeColor="Gray" Font-Bold="true"
                                                CommandName="Sort" Text="Approved Qty" CommandArgument="REQRequisitionItem.PurchasedQtyTillToDate" />
                                        </td>
                                        <td class="hi" style="width: 100px; text-align:center;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByPresentReqQty" ForeColor="Gray" Font-Bold="true"
                                                CommandName="Sort" Text="Present Req. Qty" CommandArgument="REQRequisitionItem.PresentRequiredQty" />
                                        </td>
                                        <td class="hi" style="width: 90px; font-weight:bold; color:Gray; font-size:12px; text-align:center;">
                                            Rate
                                        </td>
                                        <td class="hi" style="width: 95px; text-align:center;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequiredDate" ForeColor="Gray" Font-Bold="true"
                                                CommandName="Sort" Text="Required Date" CommandArgument="REQRequisitionItem.RequiredDate" />
                                        </td>
                                        <td class="hi" style="width: 125px; text-align:center;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRemarks" ForeColor="Gray" Font-Bold="true"
                                                CommandName="Sort" Text="Remarks" CommandArgument="REQRequisitionItem.Remarks" />
                                        </td>
                                        <td class="hi" style="width: 90px; font-weight:bold; color:Gray; font-size:12px; text-align:center;">
                                            DELETE
                                        </td>
                                        <td class="rpb" style="display:none;">>
                                            &nbsp;
                                        </td>
                                    </tr>
                                    <tr runat="server" id="itemPlaceholder">
                                    </tr>
                                </table>
                            </LayoutTemplate>
                            <ItemTemplate>
                                <tr class="r">
                                    <td class="rp" style="display:none;">
                                    <asp:Label ID="lblPresentRequiredQtyDBLV" runat="server" Text='<%# Eval("PresentRequiredQty")%>'></asp:Label>
                                        &nbsp;
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtAccCodeLV" runat="server" Text='<%# Eval("AccountsCode")%>' CssClass="ktiTextBoxListview"
                                            Width="70"></asp:TextBox>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="lblItemNameLV" runat="server" Text='<%# Eval("MDItemItemName")%>'></asp:Label>
                                        <br />
                                        Supplier :&nbsp;<%# Eval("SupplierName")%>
                                    </td>
                                    <td class="i">
                                      <asp:Label ID="lblUnitLV" runat="server" Text='<%# Eval("UnitName")%>'></asp:Label>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblItemLV" runat="server" Visible="false" Text='<%# Eval("ItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="txtQtyLV" runat="server" Text='<%# Decimal.Round((Decimal)Eval("TotalRequiredQty"),0)%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                     <asp:Label ID="lblAvailableQtyForReqisitionLV" runat="server" Text='<%# Eval("AvailableQtyForReqisition")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="txtPurchasedQty" runat="server" Text='<%# Eval("PurchasedQtyTillToDateNew")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <div class="TableFormValidatorContent">
                                            <asp:TextBox ID="txtPresentRequiredQty" runat="server" Text='<%# Decimal.Round((Decimal)Eval("PresentRequiredQty"),0)%>'
                                                CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvPresentRequiredQty" runat="server" ControlToValidate="txtPresentRequiredQty"
                                                ErrorMessage="Please Enter Required Qty" ValidationGroup="REQRequisitionItemEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvPresentRequiredQty" runat="server" ControlToValidate="txtPresentRequiredQty"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Minimum Value 1" MinimumValue="1"
                                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="REQRequisitionItemEntity"></asp:RangeValidator>
                                        </div>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="lblRate" runat="server" Text='<%# Eval("Rate")%>'></asp:Label>
                                        <br />
                                        <kti:SecureLinkButton ID="lnkBtnModifyPrice" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Modify The Price By Brand, Vendor, Origin Region, Origin Country!"
                                            Text="Modify Price" CommandName="ModifyPrice" CommandArgument='<%#Eval("RequisitionItemID")%>'
                                            UniqueKey="REQRequisitionDetailsWithApprovalControl_lvREQRequisitionItem_ModifyPrice_key" />
                                    </td>
                                    <td class="i">
                                        <div class="TableFormValidatorContent">
                                            <asp:TextBox ID="txtRequiredDate" runat="server" Text='<%# Eval("RequiredDate") != null ? ((DateTime)Eval("RequiredDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>'
                                                CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvRequiredDate" runat="server" ControlToValidate="txtRequiredDate"
                                                ErrorMessage="Please Enter Required Date" ValidationGroup="REQRequisitionItemEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="revRequiredDate" runat="server" ControlToValidate="txtRequiredDate"
                                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                                ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                        </div>
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtRemarksLV" runat="server" CssClass="ktiTextBoxListview" Style="width: 120px;"></asp:TextBox>
                                        <div style="display: none;">
                                            <asp:Label ID="lblBrandID" runat="server" Text='<%# Eval("BrandID")%>'></asp:Label>
                                            <asp:Label ID="lblSupplierID" runat="server" Text='<%# Eval("SupplierID")%>'></asp:Label>
                                            <asp:Label ID="lblRegionID" runat="server" Text='<%# Eval("RegionID")%>'></asp:Label>
                                            <asp:Label ID="lblCountryID" runat="server" Text='<%# Eval("CountryID")%>'></asp:Label>
                                            <asp:Label ID="lblRequisitionItemIDLV" runat="server" Text='<%# Eval("RequisitionItemID")%>'></asp:Label>
                                        </div>
                                    </td>
                                    <td class="i" id="trDelete" runat="server">
                                        <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Delete Item From This Requisition!" Text="Delete"
                                            CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition Item?')"
                                            CommandArgument='<%#Eval("RequisitionItemID")%>' UniqueKey="REQRequisitionDetailsWithApprovalControl_lvREQRequisitionItem_Delete_key" />
                                              <br />
                                             <asp:LinkButton ID="lnkRequisitionFloorDetail" runat="server" CssClass="CommonButtonLink"
                                    ToolTip="Please Click Here To Modify The Total Qty Floor Wise!" Text="Floor - Rate/Qty" CommandName="FloorWiseRateAndQty" CommandArgument='<%#Eval("RequisitionItemID")%>'/>
                                    </td>
                                    </td>
                                    <td class="rp" style="display: none;">
                                        &nbsp;
                                    </td>
                                    <td class="rpb" style="display:none;">>
                                        &nbsp;
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <AlternatingItemTemplate>
                                <tr class="ar">
                                    <td class="rp" style="display:none;">
                                    <asp:Label ID="lblPresentRequiredQtyDBLV" runat="server" Text='<%# Eval("PresentRequiredQty")%>'></asp:Label>
                                        &nbsp;
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtAccCodeLV" runat="server" Text='<%# Eval("AccountsCode")%>' CssClass="ktiTextBoxListview"
                                            Width="80"></asp:TextBox>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="lblItemNameLV" runat="server" Text='<%# Eval("MDItemItemName")%>'></asp:Label>
                                        <br />
                                       Supplier :&nbsp;<%# Eval("SupplierName")%>
                                    </td>
                                    <td class="i">
                                      <asp:Label ID="lblUnitLV" runat="server" Text='<%# Eval("UnitName")%>'></asp:Label>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblItemLV" runat="server" Visible="false" Text='<%# Eval("ItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="txtQtyLV" runat="server" Text='<%# Decimal.Round((Decimal)Eval("TotalRequiredQty"),0)%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                     <asp:Label ID="lblAvailableQtyForReqisitionLV" runat="server" Text='<%# Eval("AvailableQtyForReqisition")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="txtPurchasedQty" runat="server" Text='<%# Eval("PurchasedQtyTillToDateNew")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <div class="TableFormValidatorContent">
                                            <asp:TextBox ID="txtPresentRequiredQty" runat="server" Text='<%# Decimal.Round((Decimal)Eval("PresentRequiredQty"),0)%>'
                                                CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvPresentRequiredQty" runat="server" ControlToValidate="txtPresentRequiredQty"
                                                ErrorMessage="Please Enter Required Qty" ValidationGroup="REQRequisitionItemEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvPresentRequiredQty" runat="server" ControlToValidate="txtPresentRequiredQty"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="1" MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="REQRequisitionItemEntity"></asp:RangeValidator>
                                        </div>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="lblRate" runat="server" Text='<%# Eval("Rate")%>'></asp:Label>
                                        <br />
                                         <kti:SecureLinkButton ID="lnkBtnModifyPrice" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Modify The Price By Brand, Vendor, Origin Region, Origin Country!"
                                            Text="Modify Price" CommandName="ModifyPrice" CommandArgument='<%#Eval("RequisitionItemID")%>'
                                            UniqueKey="REQRequisitionDetailsWithApprovalControl_lvREQRequisitionItem_ModifyPrice_key" />
                                    </td>
                                    <td class="i">
                                        <div class="TableFormValidatorContent">
                                            <asp:TextBox ID="txtRequiredDate" runat="server" Text='<%# Eval("RequiredDate") != null ? ((DateTime)Eval("RequiredDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>'
                                                CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvRequiredDate" runat="server" ControlToValidate="txtRequiredDate"
                                                ErrorMessage="Please Enter Required Date" ValidationGroup="REQRequisitionItemEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="revRequiredDate" runat="server" ControlToValidate="txtRequiredDate"
                                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                                ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                        </div>
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtRemarksLV" runat="server" CssClass="ktiTextBoxListview" Style="width: 120px;"></asp:TextBox>
                                        <div style="display: none;">
                                            <asp:Label ID="lblBrandID" runat="server" Text='<%# Eval("BrandID")%>'></asp:Label>
                                            <asp:Label ID="lblSupplierID" runat="server" Text='<%# Eval("SupplierID")%>'></asp:Label>
                                            <asp:Label ID="lblRegionID" runat="server" Text='<%# Eval("RegionID")%>'></asp:Label>
                                            <asp:Label ID="lblCountryID" runat="server" Text='<%# Eval("CountryID")%>'></asp:Label>
                                            <asp:Label ID="lblRequisitionItemIDLV" runat="server" Text='<%# Eval("RequisitionItemID")%>'></asp:Label>
                                        </div>
                                    </td>                                  
                                    <td class="i" id="trDelete" runat="server">
                                        <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Delete To Remove Item From This Requisition!" Text="Delete"
                                            CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition Item?')"
                                            CommandArgument='<%#Eval("RequisitionItemID")%>' UniqueKey="REQRequisitionDetailsWithApprovalControl_lvREQRequisitionItem_Delete_key" />
                                              <br />
                                             <asp:LinkButton ID="lnkRequisitionFloorDetail" runat="server" CssClass="CommonButtonLink"
                                    ToolTip="Please Click Here To Modify The Total Qty Floor Wise!" Text="Floor - Rate/Qty" CommandName="FloorWiseRateAndQty" CommandArgument='<%#Eval("RequisitionItemID")%>'/>
                                    </td>
                                    </td>
                                    <td class="rpb" style="display:none;">>
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
                    <asp:ObjectDataSource ID="odsREQRequisitionItem" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisitionItem_DetailedDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsREQRequisitionItem_Selecting">
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
            <div style="font-size: 13px; font-weight: bold; color: Green; padding-left: 560px;">
                Grand Total:
                <asp:Label ID="lblGrandTotal" runat="server"></asp:Label>
            </div>
            <div>
            <asp:label ID="lblModifyPriceInfo" ForeColor="green" runat="server" Text="N.B. Modify Price will not work. Please change floor wise rate to change the price info." Visible="false"></asp:label>
            </div>
            <div class="TableFormContent" style="padding-top: 10px;">
                <table cellpadding="0" cellspacing="0">
                 <tr>
                    <td style="width:92%;">
                    <b>Requisition Remarks</b><br /> <hr /> <asp:HyperLink ID="hypFileUrl" runat="server" Visible="false"></asp:HyperLink>&nbsp;
                    </td>
                    </tr>
                     <br />
                    <tr>
                     <%--<td>
                            &nbsp;&nbsp;
                        </td>--%>
                       
                        <td>
                            <kti:SecureButton ID="btnSubmit" ValidationGroup="REQRequisitionItemEntity" OnClick="btnSave_Click"
                                ToolTip="Please Click 'Update' To Update All The Changes Required To Requisition Item!"
                                runat="server" Text="Update" UniqueKey="REQRequisitionDetailsWithApprovalControl_Submit_key" />
                        </td>
                        <td>
                            &nbsp;&nbsp;
                        </td>
                        <td>
                           <asp:Button ID="btnMigrateToTRF" ValidationGroup="none"
                                runat="server" Text="Migrate To TRF" />
                        </td>
                    </tr>
                </table>
            </div>
            <br />
            <br />
            <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
            <div id="divCollapsControl" class="divCollapsControl" style="float:left">
                <div style="float: left; height: 16px; width: 16px;">
                    <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                </div>
                <div style="float: left; padding-left: 3px;">
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Upload Info"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
             <br />
              <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                  <div style="width:500px; float:left; margin-bottom:20px;">
                    <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Select Document&nbsp;:
                </div>
                <div class="TableFormContent">
                    <div style="float: left;">
                        <ajaxToolkit:AsyncFileUpload runat="server" ID="afuFiles" CssClass="FileUploadClass"
                            UploaderStyle="Modern" UploadingBackColor="#CCFFFF" Width="230px" ThrobberID="myThrobber"
                            OnClientUploadError="uploadError" OnClientUploadComplete="uploadComplete" />
                        <asp:Button runat="server" ID="btnClick" ClientIDMode="Static" Text="Update grid"
                            Style="display: none" OnClick="btnClick_Click" />
                    </div>
                    <div style="float: left; padding-left: 10px; padding-top: 5px;">
                        <asp:Label runat="server" ID="myThrobber">
                            <asp:Image ID="imgUploading" runat="server" ImageAlign="AbsMiddle" AlternateText="Uploading..."
                                ImageUrl="~/Images/UploadImage/uploading.gif" /></asp:Label>
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
            </div>
            <br />
           <div class="listContentTitle">
                Upload Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvREQRequisitionUploadInfo" runat="server" DataSourceID="odsREQRequisitionUploadInfo" OnItemCommand="lvREQRequisitionUploadInfo_ItemCommand" OnItemDataBound="lvREQRequisitionUploadInfo_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width:250px;">
                                        File Name
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
                                     <asp:HyperLink ID="hypUploadedFile" NavigateUrl='<%# Eval("Path")%>' runat="server" Text='<%# Eval("OriginalFileName")%>' CssClass="CommonLink" Target="_blank"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition Upload Info?')"
                                        CommandArgument='<%#Eval("RequisitionUploadInfoID")%>'/>
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
                                     <asp:HyperLink ID="hypUploadedFile" NavigateUrl='<%# Eval("Path")%>' runat="server" Text='<%# Eval("OriginalFileName")%>' CssClass="CommonLink" Target="_blank"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition Upload Info?')"
                                        CommandArgument='<%#Eval("RequisitionUploadInfoID")%>'/>
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
                <asp:ObjectDataSource ID="odsREQRequisitionUploadInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisitionUploadInfoDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsREQRequisitionUploadInfo_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
                      </div>
                  </asp:Panel>
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
                            Back To
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
                            <kti:SecureButton ID="btnReject" ValidationGroup="None" runat="server" Text="Back"
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
                                                                <%# Eval("RemarksDateTime") != null ? ((DateTime)Eval("RemarksDateTime")).ToString(UIConstants.SHORT_DATE_TIME_FORMAT) : ""%></b>
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
        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel_TRF"
                DynamicServicePath="" Enabled="True" TargetControlID="btnMigrateToTRF" OkControlID="lnkPnlPopup"
                CancelControlID="btnPnlPriceCancel" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
            <div>
                <asp:Panel ID="Panel_TRF" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
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
                                                Migrate to TRF</h1>
                                            <div>
                                                <div class="TableRow" style="width: 500px;">
                                                    <div class="TableFormLeble" style="text-align: left;">
                                                        &nbsp;
                                                    </div>
                                                    <div class="TableFormContent" style="padding-top: 10px;">
                                                        <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
                                                    </div>
                                                </div>
                                                <div class="TableRow" style="width: 100;">
                                                    <div class="TableFormLeble" style="text-align: right;">
                                                        Transfer From Store&nbsp;:
                                                    </div>
                                                    <div class="TableFormContent">
                                                        <asp:DropDownList ID="ddlTransferFromStoreID" CssClass="ktiSelect" ClientIDMode="Static"
                                                            runat="server" ValidationGroup="INVTransferEntity" Width="236">
                                                        </asp:DropDownList>
                                                        <span class="RequiredField">*</span>
                                                    </div>
                                                    <div class="TableFormValidatorContent">
                                                        <asp:RequiredFieldValidator ID="rfvTransferToStoreID" runat="server" ControlToValidate="ddlTransferFromStoreID"
                                                            ErrorMessage="Please Select Transfer To Store" ValidationGroup="INVTransferEntity"
                                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="TableRow" style="width: 100;">
                                                    <div class="TableFormLeble" style="text-align: left;">
                                                        &nbsp;
                                                    </div>
                                                    <div class="TableFormContent">
                                                        <asp:LinkButton ID="lnkPnlPopup" runat="server"></asp:LinkButton>
                                                        <asp:Button ID="btnPnlMigrateToTRF" runat="server" Text="Migrate To TRF" ValidationGroup="INVTransferEntity" OnClick="btnPnlMigrateToTRF_Click" />
                                                        <asp:LinkButton ID="LinkButton1" runat="server" Text="Cancel" />
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
        <ajaxToolkit:ModalPopupExtender ID="Panel2_ModalPopupExtender" runat="server" PopupControlID="Panel2"
            DynamicServicePath="" Enabled="True" TargetControlID="lnkPnlPriceSavePopup" OkControlID="lnkPnlPriceSavePopup"
            CancelControlID="btnPnlPriceCancel" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
        <div>
            <asp:Panel ID="Panel2" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                <div class="modalPanelBackground">
                    <br />
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            &nbsp;
                        </div>
                        <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                            <asp:Button ID="Button1" runat="server" Text="X"></asp:Button>
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
                                            Modify Item Info</h1>
                                        <div>
                                            <div class="TableRow" style="width: 500px;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Item Name&nbsp;:
                                                </div>
                                                <div class="TableFormContent" style="padding-top: 10px;">
                                                    <asp:Label ID="lblItemName" runat="server" Font-Bold="true"></asp:Label>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Brand&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                                        AutoPostBack="true" OnSelectedIndexChanged="ddlBrandID_SelectedIndexChanged"
                                                        ValidationGroup="PRMSupplierItemMapEntity" Width="236">
                                                    </asp:DropDownList>
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvBrandID" runat="server" ControlToValidate="ddlBrandID"
                                                        ErrorMessage="Please Select Brand" ValidationGroup="PRMSupplierItemMapEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Vendor&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                                        ValidationGroup="PRMSupplierItemMapEntity" Width="236">
                                                    </asp:DropDownList>
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvSupplierID" runat="server" ControlToValidate="ddlSupplierID"
                                                        ErrorMessage="Please Select Vendor" ValidationGroup="PRMSupplierItemMapEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Origin Region&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlOriginRegionID" CssClass="ktiSelect" ClientIDMode="Static"
                                                        OnSelectedIndexChanged="ddlOriginRegionID_SelectedIndexChanged" AutoPostBack="true"
                                                        runat="server" ValidationGroup="PRMSupplierItemMapEntity" Width="236">
                                                    </asp:DropDownList>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Origin Country&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlOriginCountryID" CssClass="ktiSelect" ClientIDMode="Static"
                                                        runat="server" ValidationGroup="PRMSupplierItemMapEntity" Width="236">
                                                    </asp:DropDownList>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Net Price&nbsp;:
                                                </div>
                                                <div class="TableFormContent waterMarkContainer">
                                                    <asp:TextBox ID="txtPrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                        Width="210" />
                                                    <br />
                                                    <br />
                                                    <span>
                                                        <asp:LinkButton ID="lnkGetPrice" runat="server" OnClick="lnkGetPrice_OnClick"
                                                            ToolTip="Please Click Here To Get The Net Price According To Selected Brand, Vendor, Origin Region, Origin Country To The Item!"
                                                            UniqueKey="REQRequisitionDetailsWithApprovalControl_GetPrice_key" Text="Get Price" /></span>&nbsp;&nbsp;&nbsp;&nbsp;
                                                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;<asp:LinkButton ID="lnkSetPrice"
                                                        runat="server" OnClick="lnkSetPrice_OnClick" ToolTip="This Will Change The Item Price."
                                                        UniqueKey="REQRequisitionDetailsWithApprovalControl_GetPrice_key" OnClientClick="return confirm('Are you sure to update Price Database?')"
                                                        Text="Update Price Database" ValidationGroup="PRMSupplierItemMapEntity" /></span>
                                                </div>
                                                <br />
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvPrice" runat="server" ControlToValidate="txtPrice"
                                                        ErrorMessage="Please Enter Price" ValidationGroup="PRMSupplierItemMapEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                    <asp:RangeValidator ID="rvPrice" runat="server" ControlToValidate="txtPrice" Display="Dynamic"
                                                        EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                        MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="PRMSupplierItemMapEntity"></asp:RangeValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:LinkButton ID="lnkPnlPriceSavePopup" runat="server"></asp:LinkButton>
                                                    <kti:SecureButton ID="btnPnlPriceUpdatePopup" runat="server" Text="Set To Requisition"
                                                        OnClick="btnPnlPriceUpdatePopup_Click" UniqueKey="REQRequisitionDetailsWithApprovalControl_PnlPriceUpdatePopup" />
                                                    <kti:SecureButton ID="btnPnlPriceCancel" runat="server" Text="Cancel" UniqueKey="REQRequisitionDetailsWithApprovalControl_PnlPriceCancel" />
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
         <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender2" runat="server" PopupControlID="Panel3"
            DynamicServicePath="" Enabled="True" TargetControlID="lnkFloorPopup" OkControlID="lnkFloorPopup"
            CancelControlID="btnFloorPopupCancel" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
        <div style="display: inline-block;">
            <asp:Panel ID="Panel3" runat="server" Width="800" Height="470" BorderWidth="1" Style="display: none;">
                <div class="modalPanelBackground" style="width:800px;">
                    <br />
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            &nbsp;
                        </div>
                        <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                            <asp:Button ID="Button3" runat="server" Text="X"></asp:Button>
                        </div>
                    </div>
                    <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                        padding-left: 10px;">
                        <tr>
                            <th rowspan="3" class="sized">
                                <asp:Image ID="Image5" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
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
                                <asp:Image ID="Image6" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
                                    Width="20" Height="300" AlternateText="" />
                            </th>
                        </tr>
                        <tr>
                            <td class="tbl-border-left">
                            </td>
                            <td>
                                <div class="table-content" style="width: 700px;">
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
                                            <div class="lv-c" style="max-height: 200px; overflow-x:hidden;">
                                                <asp:ListView ID="lvREQRequisitionItemFloorDetail" runat="server" OnItemDataBound="lvREQRequisitionItemFloorDetail_ItemDataBound">
                                                    <LayoutTemplate>
                                                        <table class="lv" cellpadding="0" cellspacing="0">
                                                            <tr class="h">
                                                                <td class="hi" style="width:12px;">
                                                                    &nbsp;
                                                                </td>
                                                                <td class="hi">
                                                                    Project Floor
                                                                </td>
                                                                 <td class="hi">
                                                                    Floor
                                                                </td>
                                                                <td class="hi">
                                                                   Floor Unit
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
                                                            <td class="i" style="display:none;">
                                                                <asp:Label ID="lblProjectFloorIDLV" runat="server" Text='<%# Eval("ProjectFloorID")%>'></asp:Label>
                                                            </td>
                                                            <td class="i">
                                                                <asp:CheckBox ID="chbxSelectLV" runat="server" />
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("BDProjectFloorName")%>
                                                            </td>
                                                               <td class="i">             
                                                            <asp:DropDownList ID="ddlProjectFloorUnitIDLV" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlProjectFloorUnitIDLV_SelectedIndexChanged"
                                                                runat="server" ValidationGroup="BDProjectUnitLocationEntity" Width="90">
                                                            </asp:DropDownList>
                                                            </td>
                                                        <td class="i">             
                                                             <asp:DropDownList ID="ddProjectUnitLocationIDLV" CssClass="ktiSelect" ClientIDMode="Static"
                                                                runat="server" ValidationGroup="BDProjectUnitLocationEntity" Width="90">
                                                            </asp:DropDownList>
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
                                                            <asp:DropDownList ID="ddlProjectFloorUnitIDLV" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlProjectFloorUnitIDLV_SelectedIndexChanged"
                                                                runat="server" ValidationGroup="BDProjectUnitLocationEntity" Width="90">
                                                            </asp:DropDownList>
                                                            </td>
                                                        <td class="i">             
                                                             <asp:DropDownList ID="ddProjectUnitLocationIDLV" CssClass="ktiSelect" ClientIDMode="Static"
                                                                runat="server" ValidationGroup="BDProjectUnitLocationEntity" Width="90">
                                                            </asp:DropDownList>
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
                                            <asp:ObjectDataSource ID="odsREQRequisitionItemFloorDetail" runat="server" SelectMethod="GetPagedData"
                                                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                                                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisitionItemFloorDetail_DetailedDataSource"
                                                SortParameterName="sortExpression" OnSelecting="odsREQRequisitionItemFloorDetail_Selecting">
                                                <SelectParameters>
                                                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                                                    <asp:Parameter Name="pageSize" Type="Int32" />
                                                    <asp:Parameter Name="sortExpression" Type="String" />
                                                    <asp:Parameter Name="filterExpression" Type="String" />
                                                </SelectParameters>
                                            </asp:ObjectDataSource>
                                        </div>
                                        <div class="TableRow" style="width: 100;">
                                            <div class="TableFormLeble" style="text-align: left;">
                                                &nbsp;
                                            </div>
                                            <div class="TableFormContent">
                                                <asp:LinkButton ID="lnkFloorPopup" runat="server"></asp:LinkButton>
                                                <asp:Button ID="btnFloorPopupSave" runat="server" Text="Update" OnClick="btnFloorPopupSave_Click"/>
                                                <asp:Button ID="btnFloorPopupCancel" runat="server" Text="Cancel"/>
                                            </div>
                                            
                                        </div>
                                        <div>
                                            <asp:Label ID="lblLockMessage" runat="server" Visible="false" ForeColor="Red" Font-Bold="true" Text="Locked : Can't Change any Information."></asp:Label>
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
