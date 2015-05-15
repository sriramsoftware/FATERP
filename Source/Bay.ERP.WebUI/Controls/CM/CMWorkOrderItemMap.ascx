<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMWorkOrderItemMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMWorkOrderItemMapControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <%-- <script type="text/javascript">
        Sys.Application.add_load(BindEvents);
         </script>--%>
        <%-- <div id="dialog" title="Basic dialog">
    <p>This is the default dialog which is useful for displaying information. The dialog window can be moved, resized and closed with the 'x' icon.</p>
</div>--%>
        <div>
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
                        <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Work Order Item Map"></asp:Label>
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
                    <div class="TableRow" style="width: 100; display: none;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Work Order&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:Label runat="server" ID="lblWorkOrderNo" Font-Bold="true"></asp:Label>
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Project Code&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtProjectCode" runat="server" CssClass="ktiTextBox"></asp:TextBox>
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Requisition&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlRequisitionID" CssClass="ktiSelect" ClientIDMode="Static"
                                Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="ddlRequisitionID_SelectedIndexChanged"
                                runat="server" ValidationGroup="PRMWorkOrderItemMapEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvRequisitionID" runat="server" ControlToValidate="ddlRequisitionID"
                                ErrorMessage="Please Select Requisition" ValidationGroup="PRMWorkOrderItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Requisition Item&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlRequisitionItemID" CssClass="ktiSelect" ClientIDMode="Static"
                                AutoPostBack="true" OnSelectedIndexChanged="ddlRequisitionItemID_SelectedIndexChanged"
                                runat="server" ValidationGroup="PRMWorkOrderItemMapEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvRequisitionItemID" runat="server" ControlToValidate="ddlRequisitionItemID"
                                ErrorMessage="Please Select Requisition Item" ValidationGroup="PRMWorkOrderItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Required Qty&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtRequiredQty">
                                Enter Required Qty</label>
                            <asp:TextBox ID="txtRequiredQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                runat="server" ValidationGroup="PRMWorkOrderItemMapEntity" Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvRequiredQty" runat="server" ControlToValidate="txtRequiredQty"
                                ErrorMessage="Please Enter Required Qty" ValidationGroup="PRMWorkOrderItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvRequiredQty" runat="server" ControlToValidate="txtRequiredQty"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                Type="Double" ValidationGroup="PRMWorkOrderItemMapEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Rate&nbsp;:
                        </div>
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtRate">
                                Enter Rate</label>
                            <asp:TextBox ID="txtRate" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                ToolTip="10% allowed after Requistion Rate." ValidationGroup="PRMWorkOrderItemMapEntity"
                                Width="210" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvRate" runat="server" ControlToValidate="txtRate"
                                ErrorMessage="Please Enter Rate" ValidationGroup="PRMWorkOrderItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            <asp:RangeValidator ID="rvRate" runat="server" ControlToValidate="txtRate" Display="Dynamic"
                                EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="PRMWorkOrderItemMapEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Delivery Address&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                                ClientIDMode="Static" ID="txtDeliveryAddress" runat="server" ValidationGroup="PRMWorkOrderItemMapEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Description&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtItemDescription" ClientIDMode="Static" CssClass="ktiTextBox"
                                runat="server" TextMode="SingleLine" ToolTip="Please Enter The Item Description."
                                ValidationGroup="PRMWorkOrderItemMapEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Work Order Status&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlWorkOrderStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                                Enabled="false" runat="server" ValidationGroup="PRMWorkOrderItemMapEntity" Width="236">
                            </asp:DropDownList>
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvWorkOrderStatusID" runat="server" ControlToValidate="ddlWorkOrderStatusID"
                                ErrorMessage="Please Select Work Order Status" ValidationGroup="PRMWorkOrderItemMapEntity"
                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="text-align: center;">
                        <div class="TableFormLeble">
                            &nbsp;</div>
                        <div class="TableFormContent">
                            <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMWorkOrderItemMapEntity" OnClick="btnSave_Click"
                                runat="server" Text="Add" UniqueKey="CMWorkOrderItemMapControl_Submit_key" />
                            <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                                Text="Add New" UniqueKey="CMWorkOrderItemMapControl_AddNew_key" />
                            <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                                UniqueKey="CMWorkOrderItemMapControl_Clear_key" />
                        </div>
                    </div>
                    <br />
                </asp:Panel>
                <div class="listContentTitle">
                    Work Order Item Map List
                </div>
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvPRMWorkOrderItemMap" runat="server" DataSourceID="odsPRMWorkOrderItemMap"
                            OnItemCommand="lvPRMWorkOrderItemMap_ItemCommand">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="hi">
                                            Work Order
                                        </td>
                                        <td class="hi">
                                            Requisition
                                        </td>
                                        <td class="hi">
                                            Item
                                        </td>
                                        <td class="hi">
                                            Required Qty
                                        </td>
                                        <td class="hi">
                                            Rate
                                        </td>
                                        <td class="hi">
                                            Delivery Address
                                        </td>
                                        <td class="hi">
                                            Work Order Status
                                        </td>
                                        <td class="his" style="display: none;">
                                            EDIT
                                        </td>
                                        <td class="his">
                                            DELETE
                                        </td>
                                        <td class="his" style="width: 80px;">
                                            Detail
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
                                        <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                        <asp:Label ID="lblRequisitionItemIDLV" runat="server" Text='<%# Eval("RequisitionItemID")%>'></asp:Label>
                                        <asp:Label ID="lblWorkOrderItemMapIDLV" runat="server" Text='<%# Eval("WorkOrderItemMapID")%>'></asp:Label>
                                        <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'></asp:Label>
                                        <asp:Label ID="lblWorkOrderIDLV" runat="server" Text='<%# Eval("WorkOrderID")%>'></asp:Label>
                                        <asp:Label ID="lblItemLV" runat="server" Text='<%# Eval("ItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("WorkOrderNo")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequisitionNo")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ItemName")%>
                                        <br />
                                        (<%# Eval("UnitName")%>)
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequiredQty")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("Rate")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("DeliveryAddress")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("MDWorkOrderStatusName")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("WorkOrderItemMapID")%>'
                                            UniqueKey="CMWorkOrderItemMap_lvPRMWorkOrderItemMap_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order Item Map?')"
                                            CommandArgument='<%#Eval("WorkOrderItemMapID")%>' UniqueKey="CMWorkOrderItemMap_lvPRMWorkOrderItemMap_Delete_key" />
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnItemDetail" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Add Item Detail!" Text="Detail" CommandName="ItemDetail"
                                            CommandArgument='<%#Eval("WorkOrderItemMapID")%>' UniqueKey="CMWorkOrderItemMap_lvPRMWorkOrderItemMap_Detail_key" />
                                        <br />
                                        <asp:LinkButton ID="lnkRequisitionFloorDetail" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Modify The Total Qty Floor Wise!" Text="Floor Wise Qty"
                                            CommandName="FloorWiseRateAndQty" CommandArgument='<%#Eval("WorkOrderItemMapID")%>' />
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
                                        <asp:Label ID="lblRequisitionIDLV" runat="server" Text='<%# Eval("RequisitionID")%>'></asp:Label>
                                        <asp:Label ID="lblRequisitionItemIDLV" runat="server" Text='<%# Eval("RequisitionItemID")%>'></asp:Label>
                                        <asp:Label ID="lblWorkOrderItemMapIDLV" runat="server" Text='<%# Eval("WorkOrderItemMapID")%>'></asp:Label>
                                        <asp:Label ID="lblProjectIDLV" runat="server" Text='<%# Eval("ProjectID")%>'></asp:Label>
                                        <asp:Label ID="lblWorkOrderIDLV" runat="server" Text='<%# Eval("WorkOrderID")%>'></asp:Label>
                                        <asp:Label ID="lblItemLV" runat="server" Text='<%# Eval("ItemID")%>'></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("WorkOrderNo")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequisitionNo")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ItemName")%>
                                        <br />
                                        (<%# Eval("UnitName")%>)
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequiredQty")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("Rate")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("DeliveryAddress")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("MDWorkOrderStatusName")%>
                                    </td>
                                    <td class="i" style="display: none;">
                                        <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                            Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("WorkOrderItemMapID")%>'
                                            UniqueKey="CMWorkOrderItemMap_lvPRMWorkOrderItemMap_Edit_key" />
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                            Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order Item Map?')"
                                            CommandArgument='<%#Eval("WorkOrderItemMapID")%>' UniqueKey="CMWorkOrderItemMap_lvPRMWorkOrderItemMap_Delete_key" />
                                    </td>
                                    <td class="i">
                                        <kti:SecureLinkButton ID="lnkBtnItemDetail" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Add Item Detail!" Text="Detail" CommandName="ItemDetail"
                                            CommandArgument='<%#Eval("WorkOrderItemMapID")%>' UniqueKey="CMWorkOrderItemMap_lvPRMWorkOrderItemMap_Detail_key" />
                                        <br />
                                        <asp:LinkButton ID="lnkRequisitionFloorDetail" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Modify The Total Qty Floor Wise!" Text="Floor Wise Qty"
                                            CommandName="FloorWiseRateAndQty" CommandArgument='<%#Eval("WorkOrderItemMapID")%>' />
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
                    <asp:ObjectDataSource ID="odsPRMWorkOrderItemMap" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMWorkOrderItemMap_DetailedDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsPRMWorkOrderItemMap_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
                <div class="TableFormContent" style="padding-top: 10px;">
                    <table cellpadding="0" cellspacing="0">
                        <tr>
                            <td>
                                <kti:SecureButton ID="btnCreateWorkOrderDetail" ValidationGroup="none" Visible="false"
                                    OnClick="btnCreateWorkOrderDetail_Click" UniqueKey="CMWorderItemMapControl_CreateWorkOrderDetail_key"
                                    runat="server" Text="WO Details" />
                                <kti:SecureButton ID="btnInitiateApprovalProcess" ValidationGroup="none" OnClick="btnInitiateApprovalProcess_Click"
                                    Visible="false" UniqueKey="CMWorderItemMapControl_InitiateApprovalProcess_key"
                                    runat="server" Text="Submit for Approval" />
                                <kti:SecureButton ID="btnWorkOrderPaymentTerm" ValidationGroup="none" OnClick="btnWorkOrderPaymentTerm_Click"
                                    runat="server" Text="Payment Term" UniqueKey="CMWorderItemMapControl_PaymentTerm_key" />
                                <kti:SecureButton ID="btnCancelWorkOrder" ValidationGroup="none" OnClick="btnCancelWorkOrder_Click"
                                    runat="server" Text="Cancel WO" UniqueKey="CMWorderItemMapControl_CancelWorkOrder_key" />
                            </td>
                        </tr>
                    </table>
                </div>
            </div>
        </div>
        <ajaxToolkit:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server" PopupControlID="Panel1"
            DynamicServicePath="" Enabled="True" TargetControlID="lnkSavePopup" OkControlID="lnkSavePopup"
            CancelControlID="btnClose" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
        <div style="display: inline-block;">
            <asp:Panel ID="Panel1" runat="server" Width="710" Height="470" BorderWidth="1" Style="display: none;">
                <div class="modalPanelBackground" style="width: 800px;">
                    <br />
                    <div class="TableRow" style="width: 90%;">
                        <div class="TableFormLeble" style="text-align: left;">
                            &nbsp;
                        </div>
                        <div class="TableFormContent" style="text-align: right; padding-right: 24px;">
                            <asp:Button ID="btnClose" runat="server" Text="X"></asp:Button>
                        </div>
                    </div>
                    <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                        padding-left: 10px;">
                        <tr>
                            <th rowspan="3" class="sized">
                                <asp:Image ID="imgSideShadowLeft" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
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
                                <asp:Image ID="imgSideShadowRight" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
                                    Width="20" Height="300" AlternateText="" />
                            </th>
                        </tr>
                        <tr>
                            <td class="tbl-border-left">
                            </td>
                            <td>
                                <div class="table-content" style="width: 700px; max-height: 300px; overflow-y: scroll;">
                                    <div class="page-content">
                                        <h1>
                                            Work Order Item Detail</h1>
                                        <div style="padding-right: 6px;">
                                            <div class="TableRow" style="width: 500px;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent" style="padding-top: 10px;">
                                                    &nbsp;
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    Description&nbsp;:
                                                </div>
                                                <div class="TableFormContent waterMarkContainer">
                                                    <label class="watermarkLabel" for="txtDescription">
                                                        Enter Description</label>
                                                    <asp:TextBox TextMode="MultiLine" Width="300" Height="150" ClientIDMode="Static"
                                                        ID="txtDescription" runat="server" ValidationGroup="PRMWorkOrderItemDetailEntity" />
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvDescription" runat="server" ControlToValidate="txtDescription"
                                                        ErrorMessage="Please Enter Description" ValidationGroup="PRMWorkOrderItemDetailEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    Unit&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:DropDownList ID="ddlUnitID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                                                        ValidationGroup="PRMWorkOrderItemDetailEntity" Width="236">
                                                    </asp:DropDownList>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    Rate&nbsp;:
                                                </div>
                                                <div class="TableFormContent waterMarkContainer">
                                                    <label class="watermarkLabel" for="txtPopupRate">
                                                        Enter Rate</label>
                                                    <asp:TextBox ID="txtPopupRate" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                                        runat="server" ValidationGroup="PRMWorkOrderItemDetailEntity" Width="210" />
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvtxtPopupRate" runat="server" ControlToValidate="txtPopupRate"
                                                        ErrorMessage="Please Enter Rate" ValidationGroup="PRMWorkOrderItemDetailEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                    <asp:RangeValidator ID="rgtxtPopupRate" runat="server" ControlToValidate="txtRate"
                                                        Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                        MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                        Type="Double" ValidationGroup="PRMWorkOrderItemDetailEntity"></asp:RangeValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: right;">
                                                    Qty&nbsp;:
                                                </div>
                                                <div class="TableFormContent waterMarkContainer">
                                                    <label class="watermarkLabel" for="txtQty">
                                                        Enter Qty</label>
                                                    <asp:TextBox ID="txtQty" CssClass="ktiDecimalTextBox" ClientIDMode="Static" runat="server"
                                                        ValidationGroup="PRMWorkOrderItemDetailEntity" Width="210" />
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvQty" runat="server" ControlToValidate="txtQty"
                                                        ErrorMessage="Please Enter Qty" ValidationGroup="PRMWorkOrderItemDetailEntity"
                                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                    <asp:RangeValidator ID="rvQty" runat="server" ControlToValidate="txtQty" Display="Dynamic"
                                                        EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)" MinimumValue="-79228162514264337593543950335"
                                                        MaximumValue="79228162514264337593543950335" Type="Double" ValidationGroup="PRMWorkOrderItemDetailEntity"></asp:RangeValidator>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="TableRow" style="width: 100;">
                                            <div class="TableFormLeble" style="text-align: left;">
                                                &nbsp;
                                            </div>
                                            <div class="TableFormContent">
                                                <asp:LinkButton ID="lnkSavePopup" runat="server"></asp:LinkButton>
                                                <kti:SecureButton ID="btnAddPopup" runat="server" Text="Add" OnClick="btnSavePopup_Click"
                                                    ValidationGroup="PRMWorkOrderItemDetailEntity" UniqueKey="PRMWorkOrderItemDetailControl_AddPopup_key" />
                                                <kti:SecureButton ID="btnAddNewPopup" Visible="false" OnClick="btnAddNewPopup_Click"
                                                    runat="server" Text="Add New" UniqueKey="CMWorderItemMapDetailControl_AddNewPopUp_key" />
                                                <kti:SecureButton ID="btnClearPopup" OnClick="btnClearPopup_Click" runat="server"
                                                    Text="Clear" UniqueKey="CMWorderItemMapDetailControl_ClearPopup_key" />
                                                <kti:SecureButton ID="btnCancel" runat="server" Text="Cancel" UniqueKey="CMWorderItemMapDetailControl_CancelPopup_key" />
                                            </div>
                                        </div>
                                        <div>
                                            <div class="lv-c">
                                                <asp:ListView ID="lvPRMWorkOrderItemDetail" runat="server" DataSourceID="odsPRMWorkOrderItemDetail"
                                                    OnItemCommand="lvPRMWorkOrderItemDetail_ItemCommand">
                                                    <LayoutTemplate>
                                                        <table class="lv" cellpadding="0" cellspacing="0">
                                                            <tr class="h">
                                                                <td class="rp">
                                                                    &nbsp;
                                                                </td>
                                                                <td class="hi" style="display: none;">
                                                                    Work Order Item Map
                                                                </td>
                                                                <td class="hi">
                                                                    Description
                                                                </td>
                                                                <td class="hi">
                                                                    Unit
                                                                </td>
                                                                <td class="hi">
                                                                    Rate
                                                                </td>
                                                                <td class="hi">
                                                                    Qty
                                                                </td>
                                                                <td class="his" style="display: none;">
                                                                    EDIT
                                                                </td>
                                                                <td class="his" style="display: none;">
                                                                    DELETE
                                                                </td>
                                                                <td class="rp" style="display: none;">
                                                                    &nbsp;
                                                                </td>
                                                                <td class="rpb" style="display: none;">
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
                                                                <%# Eval("WorkOrderItemMapID")%>
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("Description")%>
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("UnitName")%>
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("Rate")%>
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("Qty")%>
                                                            </td>
                                                            <td class="i" style="display: none;">
                                                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("WorkOrderItemDetailID")%>'
                                                                    UniqueKey="CMWorderItemMapDetail_lvPRMWorkOrderItemDetail_Edit_key" />
                                                            </td>
                                                            <td class="i" style="display: none;">
                                                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order Item Detail?')"
                                                                    CommandArgument='<%#Eval("WorkOrderItemDetailID")%>' UniqueKey="CMWorderItemMapDetail_lvPRMWorkOrderItemDetail_Delete_key" />
                                                            </td>
                                                            <td class="rp" style="display: none;">
                                                                &nbsp;
                                                            </td>
                                                            <td class="rpb" style="display: none;">
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
                                                                <%# Eval("WorkOrderItemMapID")%>
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("Description")%>
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("UnitName")%>
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("Rate")%>
                                                            </td>
                                                            <td class="i">
                                                                <%# Eval("Qty")%>
                                                            </td>
                                                            <td class="i" style="display: none;">
                                                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("WorkOrderItemDetailID")%>'
                                                                    UniqueKey="CMWorderItemMapDetail_lvPRMWorkOrderItemDetail_Edit_key" />
                                                            </td>
                                                            <td class="i" style="display: none;">
                                                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order Item Detail?')"
                                                                    CommandArgument='<%#Eval("WorkOrderItemDetailID")%>' UniqueKey="CMWorderItemMapDetail_lvPRMWorkOrderItemDetail_Delete_key" />
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
                                            <asp:ObjectDataSource ID="odsPRMWorkOrderItemDetail" runat="server" SelectMethod="GetPagedData"
                                                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                                                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMWorkOrderItemDetail_DetailedDataSource"
                                                SortParameterName="sortExpression" OnSelecting="odsPRMWorkOrderItemDetail_Selecting">
                                                <SelectParameters>
                                                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                                                    <asp:Parameter Name="pageSize" Type="Int32" />
                                                    <asp:Parameter Name="sortExpression" Type="String" />
                                                    <asp:Parameter Name="filterExpression" Type="String" />
                                                </SelectParameters>
                                            </asp:ObjectDataSource>
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
            <asp:Panel ID="Panel3" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
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
                                            <div class="lv-c" style="max-height: 200px; overflow-x: hidden;">
                                                <asp:ListView ID="lvREQRequisitionItemFloorDetail" runat="server" OnItemDataBound="lvREQRequisitionItemFloorDetail_ItemDataBound">
                                                    <LayoutTemplate>
                                                        <table class="lv" cellpadding="0" cellspacing="0">
                                                            <tr class="h">
                                                                <td class="hi" style="width: 12px;">
                                                                    &nbsp;
                                                                </td>
                                                                <td class="hi">
                                                                    Project Floor
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
                                                <asp:Button ID="btnFloorPopupSave" runat="server" Text="Update" OnClick="btnFloorPopupSave_Click" />
                                                <asp:Button ID="btnFloorPopupCancel" runat="server" Text="Cancel" />
                                            </div>
                                        </div>
                                        <div>
                                            <asp:Label ID="lblLockMessage" runat="server" Visible="false" ForeColor="Red" Font-Bold="true"
                                                Text="Locked : Can't Change any Information."></asp:Label>
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
    </ContentTemplate>
</asp:UpdatePanel>
