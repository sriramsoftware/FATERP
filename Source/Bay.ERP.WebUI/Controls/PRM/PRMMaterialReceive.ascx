<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMMaterialReceive.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMMaterialReceiveControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div style="width: 600px; float: left;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="PRMMaterialReceiveEntity" Width="236" AutoPostBack="true" OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span> <span style="padding-left: 200px;"></span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                            ErrorMessage="Please Select Project" ValidationGroup="PRMMaterialReceiveEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Vendor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSupplierID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlSupplierID_SelectedIndexChanged"
                            ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSupplierID" runat="server" ControlToValidate="ddlSupplierID"
                            ErrorMessage="Please Select Supplier" ValidationGroup="PRMMaterialReceiveEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Requisition&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRequisitionID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlRequisitionID_SelectedIndexChanged"
                            runat="server" ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRequisitionID" runat="server" ControlToValidate="ddlRequisitionID"
                            ErrorMessage="Please Select Requisition" ValidationGroup="PRMMaterialReceiveEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Work Order&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlWorkOrderID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlWorkOrderID_SelectedIndexChanged"
                            runat="server" ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvWorkOrderID" runat="server" ControlToValidate="ddlWorkOrderID"
                            ErrorMessage="Please Select Work Order" ValidationGroup="PRMMaterialReceiveEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        MRR No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtMRRNo">
                            Enter MRR No</label>
                        <asp:TextBox ID="txtMRRNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="PRMMaterialReceiveEntity" Width="230" />
                        <span class="RequiredField">Leave Blank For Auto Number</span>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        MRR Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtMRRDate">
                            Enter MRR Date</label>
                        <asp:TextBox ID="txtMRRDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="PRMMaterialReceiveEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvMRRDate" runat="server" ControlToValidate="txtMRRDate"
                            ErrorMessage="Please Enter MRR Date" ValidationGroup="PRMMaterialReceiveEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revMRRDate" runat="server" ControlToValidate="txtMRRDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="PRMMaterialReceiveEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                            ClientIDMode="Static" ID="txtRemarks" runat="server" ValidationGroup="PRMMaterialReceiveEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                    </div>
                    <div class="TableFormContent">
                        <asp:HyperLink ID="hypMaterialReceiveLight" runat="server" Text="Create MRR & Requisition For BackLog Entry"
                            NavigateUrl="~/PRM/PRMMaterialReceiveLight.aspx"></asp:HyperLink>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <br />
                <br />
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        &nbsp;
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chbxSelectRequisition" runat="server" AutoPostBack="true" OnCheckedChanged="chbxSelectRequisition_CheckedChanged"
                            Text="Requisition" />&nbsp;&nbsp;<asp:CheckBox ID="chbxSelectWorkOrder" runat="server"
                                AutoPostBack="true" OnCheckedChanged="chbxSelectWorkOrder_CheckedChanged" Checked="true"
                                Text="WorkOrder" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
            </div>
            <div style="width: 400px; float: left;">
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvPRMMaterialReceive" runat="server" DataSourceID="odsPRMMaterialReceive"
                            OnItemDataBound="lvPRMMaterialReceive_ItemDataBound">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="hi" style="width: 150px;">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByMRRNo"
                                                CommandName="Sort" Text="MRR No" CommandArgument="PRMMaterialReceive.MRRNo" />
                                        </td>
                                        <td class="hi">
                                            <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByMRRDate"
                                                CommandName="Sort" Text="MRR Date" CommandArgument="PRMMaterialReceive.MRRDate" />
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
                                        <asp:HyperLink ID="hypMRRNo" runat="server" Text='<%# Eval("MRRNo")%>' CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                        <br />
                                        <b>Status:</b>&nbsp;<%# Eval("MaterialReceiveApprovalStatusName")%><br />
                                        <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                                    </td>
                                    <td class="i">
                                        <%# Eval("MRRDate") != null ? ((DateTime)Eval("MRRDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
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
                                        <asp:HyperLink ID="hypMRRNo" runat="server" Text='<%# Eval("MRRNo")%>' CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                        <br />
                                        <b>Status:</b>&nbsp;<%# Eval("MaterialReceiveApprovalStatusName")%><br />
                                        <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                                    </td>
                                    <td class="i">
                                        <%# Eval("MRRDate") != null ? ((DateTime)Eval("MRRDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                    </td>
                                    <td class="rpb">
                                        &nbsp;
                                    </td>
                                </tr>
                            </AlternatingItemTemplate>
                            <EmptyDataTemplate>
                                <div class="edr">
                                    No MRR Received To Selected WO
                                </div>
                            </EmptyDataTemplate>
                        </asp:ListView>
                    </div>
                    <asp:ObjectDataSource ID="odsPRMMaterialReceive" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMMaterialReceive_DetailedDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsPRMMaterialReceive_Selecting">
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
            <br />
            <div>
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvPRMWorkOrderItemMap" runat="server" OnItemCommand="lvPRMMaterialReceive_ItemCommand">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="hi">
                                            Requisition
                                        </td>
                                        <td class="hi" style="display: none;">
                                            Req ItemID
                                        </td>
                                        <td class="hi">
                                            Item
                                        </td>
                                        <td class="hi">
                                            Unit
                                        </td>
                                        <td class="hi">
                                            Brand
                                        </td>
                                        <td class="hi">
                                            Origin Country
                                        </td>
                                        <td class="hi">
                                            Origin Country
                                        </td>
                                        <td class="hi">
                                            Ordered Qty
                                        </td>
                                        <td class="hi">
                                            Receive Date
                                        </td>
                                        <td class="hi">
                                            Receive Qty
                                        </td>
                                        <td class="hi">
                                            Challan No
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
                                                    <asp:DataPager ID="dpListView" runat="server" PageSize="100">
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
                                        <%# Eval("RequisitionNo")%>
                                        <br />
                                        <asp:LinkButton ID="lnkRequisitionFloorDetail" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Modify The Total Qty Floor Wise!" Text="Floor Wise Qty"
                                            CommandName="FloorWiseRateAndQty" CommandArgument='<%#Eval("WorkOrderItemMapID")%>' />
                                    </td>
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblRequisitonItemIDLV" Text='<%# Eval("RequisitionItemID")%>' runat="server"></asp:Label>
                                        <asp:Label ID="lblRateLV" Text='<%# Eval("Rate")%>' runat="server"></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ItemName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("UnitName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("OriginBrandName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("OriginCountryName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("OriginRegionName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequiredQty")%>
                                    </td>
                                    <td class="i">
                                        <div class="TableFormValidatorContent">
                                            <asp:TextBox ID="txtReceiveDateLV" runat="server" ValidationGroup="PRMMaterialReceiveEntity"
                                                Text='<%# System.DateTime.Now.ToString("dd-MM-yyyy")%>' CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvReceiveDateLV" runat="server" ControlToValidate="txtReceiveDateLV"
                                                ErrorMessage="Enter Receive Date" ValidationGroup="PRMMaterialReceiveEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="revReceiveDateLV" runat="server" ControlToValidate="txtReceiveDateLV"
                                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                                ValidationGroup="PRMMaterialReceiveEntity"></asp:RegularExpressionValidator>
                                        </div>
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtReceiveQtyLV" runat="server" CssClass="ktiDecimalTextBoxListview"
                                            Text="000"></asp:TextBox>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvReceiveQtyLV" runat="server" ControlToValidate="txtReceiveQtyLV"
                                                ErrorMessage="Enter Receive Qty" ValidationGroup="PRMMaterialReceiveEntity" EnableViewState="False"
                                                Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvReceiveQtyLV" runat="server" ControlToValidate="txtReceiveQtyLV"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (e.g.: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="PRMMaterialReceiveEntity"></asp:RangeValidator>
                                        </div>
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtChallanNoLV" runat="server" CssClass="ktiTextBoxListview" Text="000"></asp:TextBox>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvChallanNoLV" runat="server" ControlToValidate="txtChallanNoLV"
                                                ErrorMessage="Enter Challan No" ValidationGroup="PRMMaterialReceiveEntity" EnableViewState="False"
                                                Display="Dynamic"></asp:RequiredFieldValidator>
                                        </div>
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
                                        <%# Eval("RequisitionNo")%>
                                        <br />
                                        <asp:LinkButton ID="lnkRequisitionFloorDetail" runat="server" CssClass="CommonButtonLink"
                                            ToolTip="Please Click Here To Modify The Total Qty Floor Wise!" Text="Floor Wise Qty"
                                            CommandName="FloorWiseRateAndQty" CommandArgument='<%#Eval("WorkOrderItemMapID")%>' />
                                    </td>
                                    <td class="i" style="display: none;">
                                        <asp:Label ID="lblRequisitonItemIDLV" Text='<%# Eval("RequisitionItemID")%>' runat="server"></asp:Label>
                                        <asp:Label ID="lblRateLV" Text='<%# Eval("Rate")%>' runat="server"></asp:Label>
                                    </td>
                                    <td class="i">
                                        <%# Eval("ItemName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("UnitName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("OriginBrandName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("OriginCountryName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("OriginRegionName")%>
                                    </td>
                                    <td class="i">
                                        <%# Eval("RequiredQty")%>
                                    </td>
                                    <td class="i">
                                        <div class="TableFormValidatorContent">
                                            <asp:TextBox ID="txtReceiveDateLV" runat="server" ValidationGroup="PRMMaterialReceiveEntity"
                                                Text='<%# System.DateTime.Now.ToString("dd-MM-yyyy")%>' CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                            <asp:RequiredFieldValidator ID="rfvReceiveDateLV" runat="server" ControlToValidate="txtReceiveDateLV"
                                                ErrorMessage="Please Enter Receive Date" ValidationGroup="PRMMaterialReceiveEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RegularExpressionValidator ID="revReceiveDateLV" runat="server" ControlToValidate="txtReceiveDateLV"
                                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                                ValidationGroup="PRMMaterialReceiveEntity"></asp:RegularExpressionValidator>
                                        </div>
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtReceiveQtyLV" runat="server" CssClass="ktiDecimalTextBoxListview"
                                            Text="000"></asp:TextBox>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvReceiveQtyLV" runat="server" ControlToValidate="txtReceiveQtyLV"
                                                ErrorMessage="Please Enter Receive Qty" ValidationGroup="PRMMaterialReceiveEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                            <asp:RangeValidator ID="rvReceiveQtyLV" runat="server" ControlToValidate="txtReceiveQtyLV"
                                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                                MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                                Type="Double" ValidationGroup="PRMMaterialReceiveEntity"></asp:RangeValidator>
                                        </div>
                                    </td>
                                    <td class="i">
                                        <asp:TextBox ID="txtChallanNoLV" runat="server" CssClass="ktiTextBoxListview" Text="000"></asp:TextBox>
                                        <div class="TableFormValidatorContent">
                                            <asp:RequiredFieldValidator ID="rfvChallanNoLV" runat="server" ControlToValidate="txtChallanNoLV"
                                                ErrorMessage="Please Enter Challan No" ValidationGroup="PRMMaterialReceiveEntity"
                                                EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                        </div>
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
                </div>
            </div>
            <br />
            <br />
            <div class="TableRow" style="width: 100;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Appr. Proc. Panel&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAPPanelID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="PRMMaterialReceiveEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAPPanelID" runat="server" ControlToValidate="ddlAPPanelID"
                            ErrorMessage="Please Select Approval Process Panel" ValidationGroup="PRMMaterialReceiveEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
            </div>
            <br />
            <div style="padding-left: 160px;">
                <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMMaterialReceiveEntity" OnClick="btnSave_Click"
                    runat="server" Text="Save & Submit For Approval" UniqueKey="PRMMaterialReceiveControl_Submit_key" />
                <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                    Text="Add New" UniqueKey="PRMMaterialReceiveControl_AddNew_key" />
            </div>
            <br />
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
                                        </div>
                                        <div class="TableRow" style="width: 100;">
                                            <div class="TableFormLeble" style="text-align: left;">
                                                &nbsp;
                                            </div>
                                            <div class="TableFormContent">
                                                <asp:LinkButton ID="lnkFloorPopup" runat="server"></asp:LinkButton>
                                                <asp:Button ID="btnFloorPopupSave" runat="server" Text="Ok" />
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
