<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Oct-2012, 11:26:30
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMBill.ascx.cs" Inherits="Bay.ERP.Web.UI.CMBillControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div style="float: left; width: 600px;">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged"
                            ValidationGroup="CMBillEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                            ErrorMessage="Please Select Project" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Bill No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtBillNo">
                            Enter Bill No</label>
                        <asp:TextBox ID="txtBillNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMBillEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBillNo" runat="server" ControlToValidate="txtBillNo"
                            ErrorMessage="Please Enter Bill No" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Vendor Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlVendorCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" runat="server" ValidationGroup="CMBillEntity" Width="236"
                            OnSelectedIndexChanged="ddlVendorCategoryID_SelectedIndexChanged">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvVedorCategoryID" runat="server" ControlToValidate="ddlVendorCategoryID"
                            ErrorMessage="Please Select Vendor Category" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Vendor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlVendorID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            AutoPostBack="true" ValidationGroup="CMBillEntity" Width="236" OnSelectedIndexChanged="ddlVendorID_SelectedIndexChanged">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvVendor" runat="server" ControlToValidate="ddlVendorID"
                            ErrorMessage="Please Enter Vendor" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        <asp:HyperLink CssClass="hypTableFormLeble" ID="hypWorkOrder" runat="server" Text="Work Order"
                            Target="_blank"></asp:HyperLink>
                        &nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlWorkOrderID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlWorkOrderID_SelectedIndexChanged"
                            runat="server" ValidationGroup="CMBillEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                        <asp:CheckBox ID="chbxFinalBilled" runat="server" Text="WO-FINAL BILL" ForeColor="Black"
                            AutoPostBack="true" Enabled="true" OnCheckedChanged="chbxFinalBilled_CheckedChanged" /></span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvWorkOrderID" runat="server" ControlToValidate="ddlWorkOrderID"
                            ErrorMessage="Please Select Work Order" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Amount&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtAmount">
                            Enter Amount</label>
                        <asp:TextBox ID="txtAmount" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                            ValidationGroup="CMBillEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAmount" runat="server" ControlToValidate="txtAmount"
                            ErrorMessage="Please Enter Amount" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvAmount" runat="server" ControlToValidate="txtAmount" Display="Dynamic"
                            EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                            MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="CMBillEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Due Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtBillDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CMBillEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revBillDate" runat="server" ControlToValidate="txtBillDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CMBillEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="106"
                            ClientIDMode="Static" ID="txtRemarks" runat="server" ValidationGroup="CMBillEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Bill Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBillStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMBillEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBillStatusID" runat="server" ControlToValidate="ddlBillStatusID"
                            ErrorMessage="Please Select Bill Status" ValidationGroup="CMBillEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Approval Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlBillApprovalStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            Enabled="false" runat="server" ValidationGroup="CMBillEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvBillApprovalStatusID" runat="server" ControlToValidate="ddlBillApprovalStatusID"
                            ErrorMessage="Please Select Bill Approval Status" ValidationGroup="CMBillEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CMBillEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CMBillControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="CMBillControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="CMBillControl_Clear_key" />
                    </div>
                </div>
            </div>
            <div style="float: left; width: 470px;">
                <div class="TableRow" style="width: 100%;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Filter Text&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSearchText">
                            Type Requisition</label>
                        <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                            Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                                OnCheckedChanged="chbxFilter_CheckedChanged" Text="Filter" /></span>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvREQRequisition" runat="server" DataSourceID="odsREQRequisition" OnItemDataBound="lvREQRequisition_ItemDataBound">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp" style="width: 30px;">
                                            &nbsp;
                                        </td>
                                        <td class="hi" style="width: 300px;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequisitionNo"
                                                CommandName="Sort" Text="Requisition No" CommandArgument="REQRequisition.RequisitionNo" />
                                        </td>
                                        <td class="hi" style="width: 100px;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByRequisitionDate"
                                                CommandName="Sort" Text="Requisition Date" CommandArgument="REQRequisition.RequisitionDate" />
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
                                                    <asp:DataPager ID="dpListView" runat="server" PageSize="6">
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
                                    <td style="display: none;">
                                        <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%#Eval("RequisitionID")%>'></asp:Label>
                                    </td>
                                    <td class="rp">
                                        <asp:CheckBox ID="chbxSelectRequisition" runat="server" />
                                    </td>
                                    <td class="i">
                                         <asp:HyperLink ID="hypRequisition" runat="server" ClientIDMode="Static" Text='<%# Eval("RequisitionNo")%>'
                                    ToolTip="Please Click Here To Edit The Template Items!" CssClass="CommonLink"></asp:HyperLink>
                                        <br />
                                    <asp:Label ID="lblRequisitionItem" runat="server"></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
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
                                    <td style="display: none;">
                                        <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%#Eval("RequisitionID")%>'></asp:Label>
                                    </td>
                                    <td class="rp">
                                        <asp:CheckBox ID="chbxSelectRequisition" runat="server" />
                                    </td>
                                   <td class="i">
                                         <asp:HyperLink ID="hypRequisition" runat="server" ClientIDMode="Static" Text='<%# Eval("RequisitionNo")%>'
                                    ToolTip="Please Click Here To Edit The Template Items!" CssClass="CommonLink"></asp:HyperLink>
                                        <br />
                                    <asp:Label ID="lblRequisitionItem" runat="server"></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequisitionDate") != null ? ((DateTime)Eval("RequisitionDate")).ToString(Bay.ERP.Web.UI.UIConstants.SHORT_DATE_FORMAT) : ""%>
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
                    <asp:ObjectDataSource ID="odsREQRequisition" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisition_DetailedDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsREQRequisition_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                    <%--<asp:ObjectDataSource ID="odsREQRequisitionWithWorkOrder" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisitionWithWorkOrder_CustomDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsREQRequisition_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>--%>
                </div>
                <br />
                <asp:CheckBox ID="chbxShowRequisitionItem" Text="Show Requisition Item" runat="server"
                    OnCheckedChanged="chbxShowRequisitionItem_CheckedChanged" AutoPostBack="true">
                </asp:CheckBox>
                <br />
                <br />
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvREQRequisitionItem" runat="server" DataSourceID="odsREQRequisitionItem">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <%--<td class="hi">
                                            Requisition
                                        </td>   --%>
                                        <td class="hi" style="width: 100px;">
                                            ItemName
                                        </td>
                                        <td class="hi" style="width: 60px;">
                                            Required Qty
                                        </td>
                                        <td class="hi" style="width: 90px;">
                                            Price
                                        </td>
                                        <td class="hi" style="width: 90px;">
                                            Bill Price
                                        </td>
                                        <td class="rp" style="display: none;">
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
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                        <asp:Label ID="lblRequisitionItemIDLV" runat="server" Text='<%# Eval("RequisitionItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("MDItemItemName")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblItemLV" runat="server" Visible="false" Text='<%# Eval("ItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="lblPresentRequiredQtyLV" runat="server" Text='<%# Decimal.Round((Decimal)Eval("PresentRequiredQty"),0)%>'></asp:Label>
                                        <a>
                                            <%# Eval("UnitName")%></a>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="lblRequisitionPriceLV" runat="server" Text='<%# Eval("Rate")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtBillPriceLV" runat="server" CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                    </td>
                                    <td class="rp" style="display: none;">
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
                                        <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                        <asp:Label ID="lblRequisitionItemIDLV" runat="server" Text='<%# Eval("RequisitionItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("MDItemItemName")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblItemLV" runat="server" Visible="false" Text='<%# Eval("ItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="lblPresentRequiredQtyLV" runat="server" Text='<%# Decimal.Round((Decimal)Eval("PresentRequiredQty"),0)%>'></asp:Label>
                                        <a>
                                            <%# Eval("UnitName")%></a>
                                    </td>
                                    <td class="i">
                                        <asp:Label ID="lblRequisitionPriceLV" runat="server" Text='<%# Eval("Rate")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtBillPriceLV" runat="server" CssClass="ktiDecimalTextBoxListview"></asp:TextBox>
                                    </td>
                                    <td class="rp" style="display: none;">
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
            <div style="clear: both;">
            </div>
            <br />
            <div style="width: 100%">
                <div class="listContentTitle">
                    Bill List
                </div>
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvCMBill" runat="server" DataSourceID="odsCMBill" OnItemCommand="lvCMBill_ItemCommand"
                            OnItemDataBound="lvCMBill_ItemDataBound">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="hi">
                                            Project
                                        </td>
                                        <td class="hi">
                                            Bill No
                                        </td>
                                        <td class="hi" style="display: none;">
                                            Vendor Category
                                        </td>
                                        <td class="hi">
                                            Due Date
                                        </td>
                                        <td class="hi">
                                            Vendor
                                        </td>
                                        <td class="hi">
                                            Amount
                                        </td>
                                        <td class="hi">
                                            Remarks
                                        </td>
                                        <td class="hi">
                                            Approval Status
                                        </td>
                                        <td class="his">
                                            EDIT
                                        </td>
                                        <td class="his">
                                            DELETE
                                        </td>
                                        <td class="his" style="width: 100px;">
                                            Upload Info
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
                                        <%# Eval("BDProjectProjectName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("BillNo")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <%# Eval("VendorCategory")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("BillDate") != null ? ((DateTime)Eval("BillDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("SupplierName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("Amount")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("Remarks")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("MDBillApprovalStatusName")%>
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MBill?')"
                                            CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Delete_key" />
                                    </td>
                                    <td class="i">
                                        <asp:HyperLink ID="hypUploadInfo" runat="server" CssClass="CommonButtonLink" Text="Upload Info"
                                            CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Upload_key" />
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
                                        <%# Eval("BDProjectProjectName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("BillNo")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <%# Eval("VendorCategory")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("BillDate") != null ? ((DateTime)Eval("BillDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("SupplierName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("Amount")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("Remarks")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("MDBillApprovalStatusName")%>
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MBill?')"
                                            CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Delete_key" />
                                    </td>
                                    <td class="i">
                                        <asp:HyperLink ID="hypUploadInfo" runat="server" CssClass="CommonButtonLink" Text="Upload Info"
                                            CommandArgument='<%#Eval("BillID")%>' UniqueKey="CMBill_lvCMBill_Upload_key" />
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
                    <asp:ObjectDataSource ID="odsCMBill" runat="server" SelectMethod="GetPagedData" SelectCountMethod="TotalRowCount"
                        EnablePaging="true" MaximumRowsParameterName="pageSize" StartRowIndexParameterName="startRowIndex"
                        TypeName="Bay.ERP.Web.UI.CMBill_DetailedDataSource" SortParameterName="sortExpression"
                        OnSelecting="odsCMBill_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
