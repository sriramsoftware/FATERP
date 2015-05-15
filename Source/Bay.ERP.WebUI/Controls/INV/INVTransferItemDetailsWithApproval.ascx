<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 31-Dec-2012, 11:15:25
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVTransferItemDetailsWithApproval.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVTransferItemDetailsWithApprovalControl" %>
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
                        <span style="text-align:right;padding-left:750px;">
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
                    <asp:ListView ID="lvINVTransferItem" runat="server" DataSourceID="odsINVTransferItem"
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
                                        CommandArgument='<%#Eval("TransferItemID")%>' UniqueKey="INVTransferItemDetailsWithApproval_lvINVTransferItem_Edit_key" />
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
                        runat="server" Text="Update All" UniqueKey="INVTransferItemDetailsWithApproval_UpdateAll_key" />
                 </div>
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
                                                                <%# Eval("RemarksDateTime") !=  null ? ((DateTime)Eval("RemarksDateTime")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></b>
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
