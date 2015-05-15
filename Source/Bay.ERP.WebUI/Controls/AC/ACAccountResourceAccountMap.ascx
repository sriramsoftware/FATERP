<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 24-Jun-2013, 05:04:04
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ACAccountResourceAccountMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ACAccountResourceAccountMapControl" %>

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
        <div>
           
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <asp:HiddenField ID="hdEmpID" ClientIDMode="Static" runat="server" Value="0" />
                 <div class="TableRow" style="width: 100;">
                   <div class="TableFormLeble" style="text-align: right;">
                        Account&nbsp;:
                    </div>
                            <div class="TableFormContent">
                                <div>
                                    <asp:TextBox runat="server" ID="txtItemName" Width="262" autocomplete="off" ToolTip="Please Write The Account Name; Suggestion Will Come Automatically" ValidationGroup="ACBankAccountDepositItemEntity"
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
                                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="txtItemName"
                                    ErrorMessage="Please Select Account" ValidationGroup="ACBankAccountPaymentItemEntity"
                                    EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRemarks" runat="server" ClientIDMode="Static" TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                            ValidationGroup="ACAccountResourceAccountMapEntity"/>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="ACAccountResourceAccountMapEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="ACAccountResourceAccountMapControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="ACAccountResourceAccountMapControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="ACAccountResourceAccountMapControl_Clear_key" />
                    </div>
                </div>
                <br />
            <div class="listContentTitle">
                Account Resource Account Map List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvACAccountResourceAccountMap" runat="server" DataSourceID="odsACAccountResourceAccountMap" OnItemCommand="lvACAccountResourceAccountMap_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Account
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Account Resource Category
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Reference
                                    </td>
                                    <td class="hi">
                                        Remarks
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
                                    <%# Eval("AccountID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("AccountResourceCategoryID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ResourceAccountMapID")%>' UniqueKey="ACAccountResourceAccountMap_lvACAccountResourceAccountMap_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CAccount Resource Account Map?')"
                                        CommandArgument='<%#Eval("ResourceAccountMapID")%>' UniqueKey="ACAccountResourceAccountMap_lvACAccountResourceAccountMap_Edit_key"/>
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
                                    <%# Eval("AccountID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("AccountResourceCategoryID")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ResourceAccountMapID")%>' UniqueKey="ACAccountResourceAccountMap_lvACAccountResourceAccountMap_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete A CAccount Resource Account Map?')"
                                        CommandArgument='<%#Eval("ResourceAccountMapID")%>' UniqueKey="ACAccountResourceAccountMap_lvACAccountResourceAccountMap_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsACAccountResourceAccountMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ACAccountResourceAccountMapDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsACAccountResourceAccountMap_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
