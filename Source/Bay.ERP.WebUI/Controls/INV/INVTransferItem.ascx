<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 31-Dec-2012, 11:15:25
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVTransferItem.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVTransferItemControl" %>
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
            <div class="TableRow" style="width: 100;">
            <div style="text-align: left; overflow:hidden;">
                      <b>TRF No#</b>&nbsp;:&nbsp;<asp:Label ID="lblTRFNo" Font-Bold="true"
                            runat="server"></asp:Label>
                        <span style="text-align:right;padding-left:664px;">
                    <b>From Store</b>&nbsp;:&nbsp;<asp:Label ID="lblFromStore" Font-Bold="true"
                        runat="server"></asp:Label>        
                        </span>
                </div>
                <div class="TableRow">
                    <div style="text-align: left; padding-top: 4px; overflow:hidden;">
                    <b>Requested Date</b>&nbsp;: &nbsp;<asp:Label ID="lblRequestedDate" Font-Bold="true"
                            runat="server"></asp:Label>
                            <span style="padding-left:662px;">
                        <b>To Store</b>&nbsp;: &nbsp;<asp:Label ID="lblToStore" Font-Bold="true"
                        runat="server"></asp:Label>    
                        </span>
                    </div>
                    </div>
                    <br />
                     <br />
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
                        OnClientItemSelected="ace1_itemSelected" TargetControlID="txtItemName" ServicePath="~/WebServices/AutoCompleteTRF.asmx"
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
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" OnClick="btnSave_Click" runat="server" Text="Add"
                        UniqueKey="INVTransferItemControl_Submit_key" />
                 </div>
            </div>
            <br />
            <div class="listContentTitle">
                Transfer Item List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVTransferItem" runat="server" DataSourceID="odsINVTransferItem" OnItemDataBound="lvINVTransferItem_ItemDataBound"
                        OnItemCommand="lvINVTransferItem_ItemCommand" DataKeyNames="TransferItemID">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Transfer
                                    </td>
                                    <td class="hi">
                                        Item
                                    </td>
                                    <td class="hi">
                                        Brand
                                    </td>
                                    <td class="hi">
                                        Region
                                    </td>
                                    <td class="hi">
                                        Country
                                    </td>
                                     <td class="hi">
                                        Unit
                                    </td>
                                    <td class="hi">
                                        Request Qty
                                    </td>
                                    <td class="hi" style="width:120px;">
                                        Remarks
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
                                <td style="display:none;">
                                <%--<asp:Label ID="lblItemIDLV" runat="server" Text='<%# Eval("ItemID")%>'></asp:Label>
                                <asp:Label ID="lblBrandIDLV" runat="server" Text=""></asp:Label>
                                <asp:Label ID="lblRegionIDLV" runat="server" Text=""></asp:Label>
                                <asp:Label ID="lblCountryIDLV" runat="server" Text=""></asp:Label>--%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("TransferID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDItemItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDBrandBrandName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDRegionName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDCountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                                <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtRequestQtyLV" runat="server" Text='<%# Decimal.Round((Decimal)Eval("RequestQty"),0)%>'
                                            CssClass="ktiNumberTextBoxListview"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvRequestQty" runat="server" ControlToValidate="txtRequestQtyLV"
                                            ErrorMessage="Please Enter Request Qty" ValidationGroup="INVTransferItemEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RangeValidator ID="rvRequestQty" runat="server" ControlToValidate="txtRequestQtyLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="1" MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="INVTransferItemEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                 <td class="i">
                                 <asp:TextBox ID="txtRemarksLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Remarks")%>' Style="width: 120px;"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVTransfer Item?')"
                                        CommandArgument='<%#Eval("TransferItemID")%>' UniqueKey="INVTransferItem_lvINVTransferItem_Edit_key" />
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
                                    <%# Eval("TransferID")%>
                                </td>
                               <td class="i">
                                    <%# Eval("MDItemItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDBrandBrandName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDRegionName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDCountryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UnitName")%>
                                </td>
                               <td class="i">
                                    <div class="TableFormValidatorContent">
                                        <asp:TextBox ID="txtRequestQtyLV" runat="server" Text='<%# Decimal.Round((Decimal)Eval("RequestQty"),0)%>'
                                            CssClass="ktiNumberTextBoxListview"></asp:TextBox>
                                        <asp:RequiredFieldValidator ID="rfvRequestQty" runat="server" ControlToValidate="txtRequestQtyLV"
                                            ErrorMessage="Please Enter Request Qty" ValidationGroup="INVTransferItemEntity"
                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        <asp:RangeValidator ID="rvRequestQty" runat="server" ControlToValidate="txtRequestQtyLV"
                                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                            MinimumValue="1" MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="INVTransferItemEntity"></asp:RangeValidator>
                                    </div>
                                </td>
                                 <td class="i">
                                   <asp:TextBox ID="txtRemarksLV" runat="server" CssClass="ktiTextBoxListview" Text='<%# Eval("Remarks")%>' Style="width: 120px;"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVTransfer Item?')"
                                        CommandArgument='<%#Eval("TransferItemID")%>' UniqueKey="INVTransferItem_lvINVTransferItem_Edit_key" />
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
                <asp:ObjectDataSource ID="odsINVTransferItem" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVTransferItem_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVTransferItem_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
              <kti:SecureButton ID="btnUpdateAll" OnClick="btnUpdateAll_Click" ValidationGroup="INVTransferItemEntity"
                        runat="server" Text="Update All" UniqueKey="INVTransferItemControl_UpdateAll_key" />
                        <kti:SecureButton ID="btnInitiateApprovalProcess" ValidationGroup="none" OnClick="btnInitiateApprovalProcess_Click" ClientIDMode="Static" 
                                runat="server" Text="Submit for Approval" UniqueKey="INVTransferItemControl_InitiateApprovalProcess_key" />
                 </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
