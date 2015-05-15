<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMWorkOrderPaymentTerm.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMWorkOrderPaymentTermControl" %>
<style type="text/css">
    div.demo
    {
        padding: 8px !important;
    }
</style>
<script type="text/javascript">
    function BindSliderEvents() {
        $(function () {
            var x = $("#txtCompletionPercentage").val();
            $("#slider-range-min").slider({
                range: "min",
                value: x,
                min: 0,
                max: 100,
                slide: function (event, ui) {
                    $("#txtCompletionPercentage").val(ui.value);
                    $("#amount").val(ui.value + " % ");
                }
            });
            $("#amount").val($("#slider-range-min").slider("value") + " % ");
        });

        $(function () {
            var x = $("#txtPaymentPercentage").val();
            $("#slider-range-min-Payment").slider({
                range: "min",
                value: x,
                min: 0,
                max: 100,
                slide: function (event, ui) {
                    $("#txtPaymentPercentage").val(ui.value);
                    $("#paymentpercentage").val(ui.value + " % ");
                }
            });
            $("#paymentpercentage").val($("#slider-range-min-Payment").slider("value") + " % ");
        });
    }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindSliderEvents);
        </script>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
            ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="true"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
            <div id="divCollapsControl" class="divCollapsControl">
                <div style="float: left; height: 16px; width: 16px;">
                    <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                </div>
                <div style="float: left; padding-left: 3px;">
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Work Order Payment Term"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
        <div>
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Work Order&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:Label ID="lblWorkOrderNo" runat="server" Font-Bold="true"></asp:Label>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Payment (%)&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <div class="demo" style="width: 230px;">
                            <div id="slider-range-min-Payment">
                            </div>
                            <p style="width: 230px;">
                                <label for="paymentpercentage">
                                    Value :
                                </label>
                                <input type="text" id="paymentpercentage" style="border: 0; color: #f6931f; font-weight: bold;" />
                            </p>
                        </div>
                        <div style="display: none;">
                            <asp:TextBox ID="txtPaymentPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="PRMWorkOrderPaymentTermEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPaymentPercentage" runat="server" ControlToValidate="txtPaymentPercentage"
                            ErrorMessage="Please Enter Payment Percentage" ValidationGroup="PRMWorkOrderPaymentTermEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvPaymentPercentage" runat="server" ControlToValidate="txtPaymentPercentage"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="PRMWorkOrderPaymentTermEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Completion (%)&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <div class="demo" style="width: 230px;">
                            <div id="slider-range-min">
                            </div>
                            <p style="width: 230px;">
                                <label for="amount">
                                    Value :
                                </label>
                                <input type="text" id="amount" style="border: 0; color: #f6931f; font-weight: bold;" />
                            </p>
                        </div>
                        <div style="display: none;">
                            <asp:TextBox ID="txtCompletionPercentage" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="PRMWorkOrderPaymentTermEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCompletionPercentage" runat="server" ControlToValidate="txtCompletionPercentage"
                            ErrorMessage="Please Enter Completion Percentage" ValidationGroup="PRMWorkOrderPaymentTermEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvCompletionPercentage" runat="server" ControlToValidate="txtCompletionPercentage"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                            MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="PRMWorkOrderPaymentTermEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Completion Note&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtCompletionNote" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMWorkOrderPaymentTermEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Payment Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPaymentDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="PRMWorkOrderPaymentTermEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revPaymentDate" runat="server" ControlToValidate="txtPaymentDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="PRMWorkOrderPaymentTermEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMWorkOrderPaymentTermEntity"
                            OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="PRMWorkOrderPaymentTermControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="PRMWorkOrderPaymentTermControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="PRMWorkOrderPaymentTermControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Work Order Payment Term List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvPRMWorkOrderPaymentTerm" runat="server" DataSourceID="odsPRMWorkOrderPaymentTerm"
                        OnItemCommand="lvPRMWorkOrderPaymentTerm_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Work Order
                                    </td>
                                    <td class="hi">
                                        Payment Percentage
                                    </td>
                                    <td class="hi">
                                        Completion Percentage
                                    </td>
                                    <td class="hi">
                                        Completion Note
                                    </td>
                                    <td class="hi">
                                        Payment Date
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
                                <td class="i" style="display: none;">
                                    <%# Eval("WorkOrderID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompletionPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompletionNote")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentDate") != null ? ((DateTime)Eval("PaymentDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("WorkOrderPaymentTermID")%>'
                                        UniqueKey="PRMWorkOrderPaymentTerm_lvPRMWorkOrderPaymentTerm_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order Payment Term?')"
                                        CommandArgument='<%#Eval("WorkOrderPaymentTermID")%>' UniqueKey="PRMWorkOrderPaymentTerm_lvPRMWorkOrderPaymentTerm_Delete_key" />
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
                                <td class="i" style="display: none;">
                                    <%# Eval("WorkOrderID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompletionPercentage")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CompletionNote")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PaymentDate") != null ? ((DateTime)Eval("PaymentDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("WorkOrderPaymentTermID")%>'
                                        UniqueKey="PRMWorkOrderPaymentTerm_lvPRMWorkOrderPaymentTerm_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order Payment Term?')"
                                        CommandArgument='<%#Eval("WorkOrderPaymentTermID")%>' UniqueKey="PRMWorkOrderPaymentTerm_lvPRMWorkOrderPaymentTerm_Delete_key" />
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
                <asp:ObjectDataSource ID="odsPRMWorkOrderPaymentTerm" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMWorkOrderPaymentTermDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsPRMWorkOrderPaymentTerm_Selecting">
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
