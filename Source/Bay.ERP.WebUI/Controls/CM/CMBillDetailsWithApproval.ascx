<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Oct-2012, 11:26:30
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMBillDetailsWithApproval.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMBillDetailsWithApprovalControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnClick" EventName="Click" />
    </Triggers>
    <ContentTemplate>
        <div>
        
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="float:left;width:600px;">
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Project&nbsp;:&nbsp;&nbsp;
                </div>
                <div class="TableFormContent" style="padding-top:9px;">
                    <asp:Label ID="lblProject" Font-Bold="true" runat="server"></asp:Label>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Bill No&nbsp;:&nbsp;&nbsp;
                </div>
                <div class="TableFormContent" style="padding-top:9px;">
                    <asp:Label ID="lblBillNo" Font-Bold="true" runat="server"></asp:Label>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Vendor&nbsp;:&nbsp;&nbsp;
                </div>
                <div class="TableFormContent" style="padding-top:9px;">
                    <asp:Label ID="lblVendor" Font-Bold="true" runat="server"></asp:Label>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Work Order&nbsp;:&nbsp;&nbsp;
                </div>
                <div class="TableFormContent" style="padding-top:9px;">
                    <asp:Label ID="lblWorkOrder" Font-Bold="true" runat="server"></asp:Label>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Amount&nbsp;:&nbsp;&nbsp;
                </div>
                <div class="TableFormContent" style="padding-top:9px;">
                    <asp:Label ID="lblAmount" Font-Bold="true" runat="server"></asp:Label>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Bill Date&nbsp;:&nbsp;&nbsp;
                </div>
                <div class="TableFormContent" style="padding-top:9px;">
                    <asp:Label ID="lblBillDate" Font-Bold="true" runat="server"></asp:Label>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100; display: none;">
                <div class="TableFormLeble" style="text-align: left;">
                    Select Document&nbsp;:
                </div>
                <div class="TableFormContent">
                    <div style="float: left;">
                        <ajaxToolkit:AsyncFileUpload runat="server" ID="afuFiles" CssClass="FileUploadClass"
                            UploaderStyle="Modern" UploadingBackColor="#CCFFFF" Width="230px" ThrobberID="myThrobber"
                            OnClientUploadError="uploadError" OnClientUploadComplete="uploadComplete" />
                        <asp:Button runat="server" ID="btnClick" ClientIDMode="Static" Text="Update grid"
                            Style="display: none" OnClick="btnClick_Click" />
                    </div>
                    <div style="float: left; padding-left: 10px; padding-top: 5px;">
                        <asp:Label runat="server" ID="myThrobber">
                            <asp:Image ID="imgUploading" runat="server" ImageAlign="AbsMiddle" AlternateText="Uploading..."
                                ImageUrl="~/Images/UploadImage/uploading.gif" /></asp:Label>
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
            </div>
            </div>
            <div style="float:left;width:400px;">
         <div class="listContentTitle">
                Bill Requisition Item Map List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMBillRequisitionItemMap" runat="server" DataSourceID="odsCMBillRequisitionItemMap">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Bill
                                    </td>
                                    <td class="hi">
                                        Requisition
                                    </td>
                                    <td class="hi">
                                        Requisition Item
                                    </td>
                                    <td class="hi">
                                        Requisition Price
                                    </td>
                                    <td class="hi">
                                        Bill Price
                                    </td>
                                    <td class="his" style="display:none;">
                                        EDIT
                                    </td>
                                    <td class="his" style="display:none;">
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
                                    <%# Eval("BillNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionPrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillPrice")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("BillRequisitionItemMapID")%>' UniqueKey="CMBillRequisitionItemMap_lvCMBillRequisitionItemMap_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MBill Requisition Item Map?')"
                                        CommandArgument='<%#Eval("BillRequisitionItemMapID")%>' UniqueKey="CMBillRequisitionItemMap_lvCMBillRequisitionItemMap_Edit_key"/>
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
                                    <%# Eval("BillNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ItemName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequisitionPrice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BillPrice")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("BillRequisitionItemMapID")%>' UniqueKey="CMBillRequisitionItemMap_lvCMBillRequisitionItemMap_Edit_key" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MBill Requisition Item Map?')"
                                        CommandArgument='<%#Eval("BillRequisitionItemMapID")%>' UniqueKey="CMBillRequisitionItemMap_lvCMBillRequisitionItemMap_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsCMBillRequisitionItemMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMBillRequisitionItemMap_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMBillRequisitionItemMap_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
        <div style="clear:both;"></div>

            <br />
            <div class="listContentTitle">
                Bill Upload Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMBillUploadInfo" runat="server" DataSourceID="odsCMBillUploadInfo"
                        OnItemCommand="lvCMBillUploadInfo_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width: 200px;">
                                        File Name
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
                                    <asp:HyperLink ID="hypUploadedFile" NavigateUrl='<%# Eval("Path")%>' runat="server"
                                        Text='<%# Eval("OriginalFileName")%>' CssClass="CommonLink" Target="_blank"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Bill Upload Info?')"
                                        CommandArgument='<%#Eval("BillUploadInfoID")%>' UniqueKey="CMBillDetailsWithApprovalControl_lvCMBillUploadInfo_Delete_key" />
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
                                    <asp:HyperLink ID="hypUploadedFile" NavigateUrl='<%# Eval("Path")%>' runat="server"
                                        Text='<%# Eval("OriginalFileName")%>' CssClass="CommonLink" Target="_blank"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Bill Upload Info?')"
                                        CommandArgument='<%#Eval("BillUploadInfoID")%>' UniqueKey="CMBillDetailsWithApprovalControl_lvCMBillUploadInfo_Delete_key" />
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
                <asp:ObjectDataSource ID="odsCMBillUploadInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMBillUploadInfoDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMBillUploadInfo_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
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
            function uploadError(sender, args) {
            }
            function uploadComplete(sender, args) {
                var btnClick = document.getElementById("btnClick");
                btnClick.click();
            }
        </script>
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
