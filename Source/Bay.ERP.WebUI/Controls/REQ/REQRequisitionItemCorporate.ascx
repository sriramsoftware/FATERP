<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Jul-2012, 11:50:01
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="REQRequisitionItemCorporate.ascx.cs"
    Inherits="Bay.ERP.Web.UI.REQRequisitionItemCorporateControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                 <div class="TableRow" style="width: 150;">
                <div style="text-align: right; padding-left: 700px;">
                    <b>Requisition No</b>&nbsp;: &nbsp; &nbsp;<asp:Label ID="lblRequisitonNo" Font-Bold="true"
                        runat="server"></asp:Label>
                </div>
            </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Accounts Code&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAccountsCode">
                            Enter Accounts Code</label>
                        <asp:TextBox ID="txtAccountsCode" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="REQRequisitionItemEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAccountsCode" runat="server" ControlToValidate="txtAccountsCode"
                            ErrorMessage="Please Enter Accounts Code" ValidationGroup="REQRequisitionItemEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Item&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlItemID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="REQRequisitionItemEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvItemID" runat="server" ControlToValidate="ddlItemID"
                            ErrorMessage="Please Select Item" ValidationGroup="REQRequisitionItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Brand&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBrandID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" 
                            runat="server" ValidationGroup="REQRequisitionItemEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBrandID" runat="server" ControlToValidate="ddlBrandID"
                            ErrorMessage="Please Select Brand" ValidationGroup="REQRequisitionItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                 <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Region&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRegionID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="REQRequisitionItemEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRegionID" runat="server" ControlToValidate="ddlRegionID"
                            ErrorMessage="Please Select Region" ValidationGroup="REQRequisitionItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Country&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCountryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="REQRequisitionItemEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCountryID" runat="server" ControlToValidate="ddlCountryID"
                            ErrorMessage="Please Select Country" ValidationGroup="REQRequisitionItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Vendor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="REQRequisitionItemEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSupplierID" runat="server" ControlToValidate="ddlSupplierID"
                            ErrorMessage="Please Select Supplier" ValidationGroup="REQRequisitionItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Rate&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtRate">
                            Enter Rate</label>
                        <asp:TextBox ID="txtRate" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="REQRequisitionItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRate" runat="server" ControlToValidate="txtRate"
                            ErrorMessage="Please Enter Rate" ValidationGroup="REQRequisitionItemEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvRate" runat="server" ControlToValidate="txtRate" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="REQRequisitionItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Total Required Qty&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTotalRequiredQty">
                            Enter Total Required Qty</label>
                        <asp:TextBox ID="txtTotalRequiredQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static" Text="0"
                            runat="server" ValidationGroup="REQRequisitionItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTotalRequiredQty" runat="server" ControlToValidate="txtTotalRequiredQty"
                            ErrorMessage="Please Enter Total Required Qty" ValidationGroup="REQRequisitionItemEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvTotalRequiredQty" runat="server" ControlToValidate="txtTotalRequiredQty" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="REQRequisitionItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Purchased Qty&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPurchasedQtyTillToDate" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="REQRequisitionItemEntity" Type="Number" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RangeValidator ID="rvPurchasedQtyTillToDate" runat="server" ControlToValidate="txtPurchasedQtyTillToDate" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="REQRequisitionItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Present Req. Qty&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPresentRequiredQty">
                            Enter Present Required Qty</label>
                        <asp:TextBox ID="txtPresentRequiredQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="REQRequisitionItemEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPresentRequiredQty" runat="server" ControlToValidate="txtPresentRequiredQty"
                            ErrorMessage="Please Enter Present Required Qty" ValidationGroup="REQRequisitionItemEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvPresentRequiredQty" runat="server" ControlToValidate="txtPresentRequiredQty" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                            Type="Double" ValidationGroup="REQRequisitionItemEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Required Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtRequiredDate">
                            Enter Required Date</label>
                        <asp:TextBox ID="txtRequiredDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="REQRequisitionItemEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRequiredDate" runat="server" ControlToValidate="txtRequiredDate"
                            ErrorMessage="Please Enter Required Date" ValidationGroup="REQRequisitionItemEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revRequiredDate" runat="server" ControlToValidate="txtRequiredDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="REQRequisitionItemEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="REQRequisitionItemEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="REQRequisitionItemCorporateControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="REQRequisitionItemCorporateControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="REQRequisitionItemCorporateControl_Clear_key" />
                    </div>
                </div>
                <br />
            <div class="listContentTitle">
                Requisition Item Corporate List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvREQRequisitionItem" runat="server" DataSourceID="odsREQRequisitionItem" OnItemCommand="lvREQRequisitionItem_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Requisition
                                    </td>
                                    <td class="hi">
                                        Accounts Code
                                    </td>
                                    <td class="hi">
                                        Item
                                    </td>
                                    <td class="hi">
                                        Brand
                                    </td>
                                    <td class="hi">
                                        Supplier
                                    </td>
                                    <td class="hi">
                                        Region
                                    </td>
                                    <td class="hi">
                                        Country
                                    </td>
                                    <td class="hi">
                                        Rate
                                    </td>
                                    <td class="hi">
                                        Total Required Qty
                                    </td>
                                    <td class="hi">
                                        Purchased Qty Till To Date
                                    </td>
                                    <td class="hi">
                                        Present Required Qty
                                    </td>
                                    <td class="hi">
                                        Required Date
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
                                    <%# Eval("RequisitionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AccountsCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BrandID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RegionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CountryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Rate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TotalRequiredQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PurchasedQtyTillToDate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PresentRequiredQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequiredDate") != null ? ((DateTime)Eval("RequiredDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("RequisitionItemID")%>' UniqueKey="REQRequisitionItemCorporate_lvREQRequisitionItem_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete R EQRequisition Item?')"
                                        CommandArgument='<%#Eval("RequisitionItemID")%>' UniqueKey="REQRequisitionItemCorporate_lvREQRequisitionItem_Delete_key"/>
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
                                    <%# Eval("RequisitionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AccountsCode")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BrandID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SupplierID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RegionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CountryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Rate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TotalRequiredQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PurchasedQtyTillToDate")%>
                                </td>
                                <td class="i">
                                    <%# Eval("PresentRequiredQty")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequiredDate") != null ? ((DateTime)Eval("RequiredDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("RequisitionItemID")%>' UniqueKey="REQRequisitionItemCorporate_lvREQRequisitionItem_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Requisition Item?')"
                                        CommandArgument='<%#Eval("RequisitionItemID")%>' UniqueKey="REQRequisitionItemCorporate_lvREQRequisitionItem_Delete_key"/>
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
                <asp:ObjectDataSource ID="odsREQRequisitionItem" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisitionItemDataSource"
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
    </ContentTemplate>
</asp:UpdatePanel>
