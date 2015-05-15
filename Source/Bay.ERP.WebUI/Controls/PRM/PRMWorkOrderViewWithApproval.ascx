<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMWorkOrderViewWithApproval.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMWorkOrderViewWithApprovalControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Work Order No&nbsp;:
                </div>
                <div class="TableFormContent" style="padding-top: 6px;">
                    <asp:Label ID="lblWorkOrderNo" runat="server" Font-Bold="true"></asp:Label>
                </div>
            </div>
            <div class="TableRow" style="width: 100; text-align: right;">
                <asp:HyperLink ID="hypWorkOrder" CssClass="hypTableFormLeble" runat="server" Text="Work Order"></asp:HyperLink>&nbsp;|
                <asp:HyperLink ID="hypWorkOrderItem" CssClass="hypTableFormLeble" runat="server"
                    Text="Work Order Item"></asp:HyperLink>&nbsp;|
                <asp:HyperLink ID="hypWorkOrderPaymentTerm" CssClass="hypTableFormLeble" runat="server"
                    Text="Work Payment Term"></asp:HyperLink>&nbsp;|
                <asp:HyperLink ID="hypReport" CssClass="hypTableFormLeble" runat="server" Text="Report"></asp:HyperLink>
            </div>
            <div class="listContentTitle">
                Work Order Items
            </div>
            <br />
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
                                    <td class="his" style="display: none;">
                                        DELETE
                                    </td>
                                    <td class="his" style="display: none;">
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
                                <td class="i">
                                    <%# Eval("WorkOrderNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
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
                                        UniqueKey="PRMWorkOrderViewWithApproval_lvPRMWorkOrderItemMap_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order Item Map?')"
                                        CommandArgument='<%#Eval("WorkOrderItemMapID")%>' UniqueKey="PRMWorkOrderViewWithApproval_lvPRMWorkOrderItemMap_Delete_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnItemDetail" runat="server" CssClass="CommonButtonLink"
                                        ToolTip="Please Click Here To Add Item Detail!" Text="Detail" CommandName="ItemDetail"
                                        CommandArgument='<%#Eval("WorkOrderItemMapID")%>' UniqueKey="PRMWorkOrderViewWithApproval_lvPRMWorkOrderItemMap_Detail_key" />
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
                                    <%# Eval("WorkOrderNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
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
                                        UniqueKey="PRMWorkOrderViewWithApproval_lvPRMWorkOrderItemMap_Edit_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order Item Map?')"
                                        CommandArgument='<%#Eval("WorkOrderItemMapID")%>' UniqueKey="PRMWorkOrderViewWithApproval_lvPRMWorkOrderItemMap_Delete_key" />
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnItemDetail" runat="server" CssClass="CommonButtonLink"
                                        ToolTip="Please Click Here To Add Item Detail!" Text="Detail" CommandName="ItemDetail"
                                        CommandArgument='<%#Eval("WorkOrderItemMapID")%>' UniqueKey="PRMWorkOrderViewWithApproval_lvPRMWorkOrderItemMap_Detail_key" />
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
             <div style="font-size: 13px; font-weight: bold; color: Green; padding-left: 560px;">
                Grand Total:
                <asp:Label ID="lblGrandTotal" runat="server"></asp:Label>
            </div>
        </div>
        <br />
        <br />
        <div class="TableFormContent" style="padding-top: 10px;">
            <table cellpadding="0" cellspacing="0">
                <tr>
                    <td style="width: 92%;">
                        <b>Requisition Remarks</b><br />
                        <hr />
                        <asp:HyperLink ID="hypFileUrl" runat="server" Visible="false"></asp:HyperLink>&nbsp;
                    </td>
                </tr>
                <br />
                <tr>
                    <%--<td>
                            &nbsp;&nbsp;
                        </td>--%>
                    <td>
                        &nbsp;
                    </td>
                    <td>
                        &nbsp;&nbsp;
                    </td>
                    <td>
                        <asp:Button ID="btnCancelWO" ValidationGroup="none" runat="server" Text="Cancel WO" />
                    </td>
                </tr>
            </table>
        </div>
        <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel_TRF"
            DynamicServicePath="" Enabled="True" TargetControlID="btnCancelWO" OkControlID="lnkPnlPopup"
            CancelControlID="btnPnlCancel" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
        <div>
            <asp:Panel ID="Panel_TRF" runat="server" Width="610" Height="470" BorderWidth="1"
                Style="display: none;">
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
                                            WO Remarks</h1>
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
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    Remarks&nbsp;:
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="280" Height="97"
                                                        ClientIDMode="Static" ID="txtWOCancelRemarks" runat="server" ValidationGroup="PRMWorkOrderEntity" />
                                                    <span class="RequiredField">*</span>
                                                </div>
                                                <div class="TableFormValidatorContent">
                                                    <asp:RequiredFieldValidator ID="rfvtxtWOCancelRemarks" runat="server" ControlToValidate="txtWOCancelRemarks"
                                                        ErrorMessage="Please Enter Remarks" ValidationGroup="PRMWorkOrderEntity" EnableViewState="False"
                                                        Display="Dynamic"></asp:RequiredFieldValidator>
                                                </div>
                                            </div>
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:LinkButton ID="lnkPnlPopup" runat="server"></asp:LinkButton>
                                                    <asp:Button ID="btnPnlCancelWO" runat="server" Text="Save" ValidationGroup="PRMWorkOrderEntity"
                                                        OnClick="btnPnlCancelWO_Click" />
                                                    <asp:LinkButton ID="btnPnlCancel" runat="server" Text="Cancel" />
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
                        <asp:CheckBox ID="chbxAutoForwardTo" runat="server" Text="Push to AP" />
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
                            UniqueKey="PRMWorkOrderApprovalProcessControl_Approve_key" OnClick="btnApprove_Click" />
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
                            UniqueKey="PRMWorkOrderApprovalProcessControl_Reject_key" OnClick="btnReject_Click" />
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
                            UniqueKey="PRMWorkOrderApprovalProcessControl_Forward_key" OnClick="btnForward_Click" />
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
                            UniqueKey="PRMWorkOrderApprovalProcessControl_SubmitComment_key" OnClick="btnSubmitComment_Click" />
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
        <ajaxToolkit:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server" PopupControlID="Panel1"
            DynamicServicePath="" Enabled="True" TargetControlID="lnkSavePopup" OkControlID="lnkSavePopup"
            CancelControlID="btnClose" BackgroundCssClass="modalBackground">
        </ajaxToolkit:ModalPopupExtender>
        <div style="display: inline-block;">
            <asp:Panel ID="Panel1" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                <div class="modalPanelBackground" style="width: 620px;">
                    <br />
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            &nbsp;
                        </div>
                        <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
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
                                <div class="table-content" style="width: 550px; max-height: 300px; overflow-y: scroll;">
                                    <div class="page-content">
                                        <div class="TableRow" style="width: 100;">
                                            <div class="TableFormLeble" style="text-align: left;">
                                                &nbsp;
                                            </div>
                                            <div class="TableFormContent">
                                                <asp:LinkButton ID="lnkSavePopup" runat="server"></asp:LinkButton>
                                                <asp:Button ID="btnAddPopup" runat="server" Text="Add" OnClick="btnSavePopup_Click"
                                                    ValidationGroup="PRMWorkOrderItemDetailEntity" UniqueKey="PRMWorkOrderItemDetailControl_Submit_key">
                                                </asp:Button>
                                            </div>
                                        </div>
                                        <div>
                                            <h1>
                                                Work Order Item Detail</h1>
                                            <br />
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
                                                                    UniqueKey="PRMWorkOrderItemDetail_lvPRMWorkOrderItemDetail_Edit_key" />
                                                            </td>
                                                            <td class="i" style="display: none;">
                                                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order Item Detail?')"
                                                                    CommandArgument='<%#Eval("WorkOrderItemDetailID")%>' UniqueKey="PRMWorkOrderItemDetail_lvPRMWorkOrderItemDetail_Delete_key" />
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
                                                                    UniqueKey="PRMWorkOrderItemDetail_lvPRMWorkOrderItemDetail_Edit_key" />
                                                            </td>
                                                            <td class="i" style="display: none;">
                                                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Work Order Item Detail?')"
                                                                    CommandArgument='<%#Eval("WorkOrderItemDetailID")%>' UniqueKey="PRMWorkOrderItemDetail_lvPRMWorkOrderItemDetail_Delete_key" />
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
