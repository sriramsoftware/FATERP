<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 21-Apr-2013, 01:26:57
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMAgreementSpecs.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMAgreementSpecsControl" %>
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
               
                 <div style="float: left; width: 480px;">
                    <div class="TableRow" style="text-align: left;" runat="server">
                        <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Specs Type&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtAgreementSpecsType">
                                Enter Agreement Specs Type</label>
                            <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBox" Width="230" ClientIDMode="Static" ToolTip="e.g. Wall & Floor Tiles."
                                ID="txtAgreementSpecsType" runat="server" ValidationGroup="CRMAgreementSpecsEntity" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvAgreementSpecsType" runat="server" ControlToValidate="txtAgreementSpecsType"
                                ErrorMessage="Please Enter Agreement Specs Type" ValidationGroup="CRMAgreementSpecsEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Item Name&nbsp;:
                        </div>
                        <div>
                            <asp:HiddenField ID="hdEmpID" ClientIDMode="Static" runat="server" Value="0" />
                        </div>
                        <div>
                            <asp:TextBox runat="server" ID="txtItemName" Width="230" autocomplete="off" ToolTip="Please Write The Item Name; Suggestion Will Come Automatically"
                                CssClass="ktiTextBox" ClientIDMode="Static" onkeyup="SetContextKey()" />
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
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Brand&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                ValidationGroup="CRMAgreementSpecsEntity" Width="234">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvBrandID" runat="server" ControlToValidate="ddlBrandID"
                                ErrorMessage="Please Select Brand" ValidationGroup="CRMAgreementSpecsEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Bay Qty&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtBayQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                ValidationGroup="CRMAgreementSpecsEntity" Type="Number" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvBayQty" runat="server" ControlToValidate="txtBayQty" Display="Dynamic"
                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CRMAgreementSpecsEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Bay Price&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtBayPrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="CRMAgreementSpecsEntity" Type="Number" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvBayPrice" runat="server" ControlToValidate="txtBayPrice"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="CRMAgreementSpecsEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Customer Qty&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtCustomerQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="CRMAgreementSpecsEntity" Type="Number" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvCustomerQty" runat="server" ControlToValidate="txtCustomerQty"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="CRMAgreementSpecsEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Customer Price&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtCustomerPrice" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="CRMAgreementSpecsEntity" Type="Number" Width="210" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvCustomerPrice" runat="server" ControlToValidate="txtCustomerPrice"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="CRMAgreementSpecsEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Unit&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlUnitID" ClientIDMode="Static" CssClass="ktiSelect" runat="server"
                                ValidationGroup="CRMAgreementSpecsEntity" Width="230">
                            </asp:DropDownList>
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div style="display: none;">
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                Field2&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtField2" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    ValidationGroup="CRMAgreementSpecsEntity" Width="230" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                var0&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtvar0" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    ValidationGroup="CRMAgreementSpecsEntity" Width="230" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                var1&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtvar1" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    ValidationGroup="CRMAgreementSpecsEntity" Width="230" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                var2&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtvar2" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    ValidationGroup="CRMAgreementSpecsEntity" Width="230" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                var3&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtvar3" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    ValidationGroup="CRMAgreementSpecsEntity" Width="230" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                var4&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtvar4" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    ValidationGroup="CRMAgreementSpecsEntity" Width="230" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                var5&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtvar5" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    ValidationGroup="CRMAgreementSpecsEntity" Width="230" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: right;">
                            Remarks&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                                ID="txtRemarks" runat="server" ValidationGroup="CRMAgreementSpecsEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="text-align: center;">
                        <div class="TableFormLeble">
                            &nbsp;</div>
                        <div class="TableFormContent">
                            <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMAgreementSpecsEntity" OnClick="btnSave_Click"
                                runat="server" Text="Add" UniqueKey="CRMAgreementSpecsControl_Submit_key" />
                            <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                                Text="Add New" UniqueKey="CRMAgreementSpecsControl_AddNew_key" />
                            <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                                UniqueKey="CRMAgreementSpecsControl_Clear_key" />
                        </div>
                    </div>
                    <br />
            </div>
            <br />
            <br />
            <div style="float: right; width: 430px;">
             <div class="TableRow" style="width: 100%;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Agre. Name# Value</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox" Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"/></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
        <br />
        <br />
                <div class="listContentTitle">
                    Agreement Variable Map List
                </div>
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvCRMAgreementVariableMap" runat="server" DataSourceID="odsCRMAgreementVariableMap">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="hi" style="width: 200px;">
                                            Name
                                        </td>
                                        <td class="hi" style="width: 200px;">
                                            Value
                                        </td>
                                        <td class="his" style="display: none;">
                                            EDIT
                                        </td>
                                        <td class="his" style="display: none;">
                                            DELETE
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
                                    <td class="i">
                                        <%# Eval("Name")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("Value")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("AgreementVariableMapID")%>'
                                            UniqueKey="CRMAgreementVariableMap_lvCRMAgreementVariableMap_Edit_key" />
                                    </td>
                                    <td class="i" style="display: none;">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMAgreement Variable Map?')"
                                            CommandArgument='<%#Eval("AgreementVariableMapID")%>' UniqueKey="CRMAgreementVariableMap_lvCRMAgreementVariableMap_Edit_key" />
                                    </td>
                                </tr>
                            </ItemTemplate>
                            <AlternatingItemTemplate>
                                <tr class="ar">
                                    <td class="i">
                                        <%# Eval("Name")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("Value")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("AgreementVariableMapID")%>'
                                            UniqueKey="CRMAgreementVariableMap_lvCRMAgreementVariableMap_Edit_key" />
                                    </td>
                                    <td class="i" style="display: none;">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMAgreement Variable Map?')"
                                            CommandArgument='<%#Eval("AgreementVariableMapID")%>' UniqueKey="CRMAgreementVariableMap_lvCRMAgreementVariableMap_Edit_key" />
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
                    <asp:ObjectDataSource ID="odsCRMAgreementVariableMap" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMAgreementVariableMapDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsCRMAgreementVariableMap_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
            </div>
            <div style="clear: both;">
            </div>
           
            <div class="listContentTitle"">
                Agreement Specs List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMAgreementSpecs" runat="server" DataSourceID="odsCRMAgreementSpecs"
                        OnItemCommand="lvCRMAgreementSpecs_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Item
                                    </td>
                                    <td class="hi">
                                        Brand
                                    </td>
                                    <td class="hi">
                                        Bay Qty
                                    </td>
                                    <td class="hi">
                                        Bay Price
                                    </td>
                                    <td class="hi">
                                        Customer Qty
                                    </td>
                                    <td class="hi">
                                        Customer Price
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Agreement Specs Type
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
                                    <%# Eval("Item")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BrandID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BayQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BayPrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CustomerQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CustomerPrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementSpecsType")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("AgreementSpecsID")%>'
                                        UniqueKey="CRMAgreementSpecs_lvCRMAgreementSpecs_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMAgreement Specs?')"
                                        CommandArgument='<%#Eval("AgreementSpecsID")%>' UniqueKey="CRMAgreementSpecs_lvCRMAgreementSpecs_Edit_key" />
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
                                    <%# Eval("Item")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BrandID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BayQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BayPrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CustomerQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CustomerPrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementSpecsType")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("AgreementSpecsID")%>'
                                        UniqueKey="CRMAgreementSpecs_lvCRMAgreementSpecs_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMAgreement Specs?')"
                                        CommandArgument='<%#Eval("AgreementSpecsID")%>' UniqueKey="CRMAgreementSpecs_lvCRMAgreementSpecs_Edit_key" />
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
                <asp:ObjectDataSource ID="odsCRMAgreementSpecs" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMAgreementSpecsDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMAgreementSpecs_Selecting">
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
