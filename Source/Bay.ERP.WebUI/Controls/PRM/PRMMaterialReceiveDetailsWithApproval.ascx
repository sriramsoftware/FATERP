<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 25-Jun-2012, 05:50:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMMaterialReceiveDetailsWithApproval.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMMaterialReceiveDetailsWithApprovalControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Project&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        Enabled="false" ValidationGroup="PRMMaterialReceiveEntity" Width="236" AutoPostBack="true"
                        OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged">
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
                        Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="ddlSupplierID_SelectedIndexChanged"
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
                        Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="ddlRequisitionID_SelectedIndexChanged"
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
                        Enabled="false" AutoPostBack="true" OnSelectedIndexChanged="ddlWorkOrderID_SelectedIndexChanged"
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
                        ReadOnly="true" ValidationGroup="PRMMaterialReceiveEntity" Width="230" />
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
                        ReadOnly="true" ValidationGroup="PRMMaterialReceiveEntity" Width="230" />
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
                        ReadOnly="true" ClientIDMode="Static" ID="txtRemarks" runat="server" ValidationGroup="PRMMaterialReceiveEntity" />
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
            <br />
            <div class="TableRow" style="width: 100; text-align:right;">
                    <asp:HyperLink ID="hypReport"  CssClass="hypTableFormLeble" runat="server" Text="Report" Font-Size="10"></asp:HyperLink>
            </div>
            <br />
            <br />
            
            <div class="lv-c">
                <asp:ListView ID="lvPRMMaterialReceiveItemMap" runat="server" DataSourceID="odsPRMMaterialReceiveItemMap"
                    OnItemCommand="lvPRMMaterialReceiveItemMap_ItemCommand" DataKeyNames="MaterialReceiveItemMapID">
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
                                    Country
                                </td>
                                <td class="hi">
                                    Region
                                </td>
                                <td class="hi">
                                    Unit
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
                                <td class="his" style="display: none;">
                                    EDIT
                                </td>
                                <td class="his" style="display: none;">
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
                                <%# Eval("ItemName")%>
                            </td>
                            <td class="i">
                                <%# Eval("BrandName")%>
                            </td>
                            <td class="i">
                                <%# Eval("OriginCountry")%>
                            </td>
                            <td class="i">
                                <%# Eval("OriginRegion")%>
                            </td>
                            <td class="i">
                                <%# Eval("UnitName")%>
                            </td>
                            <td class="i">
                                <%# Eval("ReceiveDate") != null ? ((DateTime)Eval("ReceiveDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                            </td>
                            <td class="i">
                                <asp:TextBox ID="txtReceiveQtyLV" CssClass="ktiDecimalTextBoxListview" runat="server" Text='<%# Eval("ReceiveQty")%>'></asp:TextBox>
                            </td>
                            <td class="i">
                                <%# Eval("ChallanNo")%>
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("MaterialReceiveItemMapID")%>'
                                    UniqueKey="PRMMaterialReceiveItemMap_lvPRMMaterialReceiveItemMap_Edit_key" />
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Material Receive Item Map?')"
                                    CommandArgument='<%#Eval("MaterialReceiveItemMapID")%>' UniqueKey="PRMMaterialReceiveItemMap_lvPRMMaterialReceiveItemMap_Delete_key" />
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
                                <%# Eval("ItemName")%>
                            </td>
                            <td class="i">
                                <%# Eval("BrandName")%>
                            </td>
                            <td class="i">
                                <%# Eval("OriginCountry")%>
                            </td>
                            <td class="i">
                                <%# Eval("OriginRegion")%>
                            </td>
                            <td class="i">
                                <%# Eval("UnitName")%>
                            </td>
                            <td class="i">
                                <%# Eval("ReceiveDate") != null ? ((DateTime)Eval("ReceiveDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                            </td>
                            <td class="i">
                                <asp:TextBox ID="txtReceiveQtyLV" CssClass="ktiDecimalTextBoxListview" runat="server" Text='<%# Eval("ReceiveQty")%>'></asp:TextBox>
                            </td>
                            <td class="i">
                                <%# Eval("ChallanNo")%>
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("MaterialReceiveItemMapID")%>'
                                    UniqueKey="PRMMaterialReceiveItemMap_lvPRMMaterialReceiveItemMap_Edit_key" />
                            </td>
                            <td class="i" style="display: none;">
                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Material Receive Item Map?')"
                                    CommandArgument='<%#Eval("MaterialReceiveItemMapID")%>' UniqueKey="PRMMaterialReceiveItemMap_lvPRMMaterialReceiveItemMap_Delete_key" />
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
            <asp:ObjectDataSource ID="odsPRMMaterialReceiveItemMap" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.PRMMaterialReceiveItemMap_DetailedDataSource"
                SortParameterName="sortExpression" OnSelecting="odsPRMMaterialReceiveItemMap_Selecting">
                <SelectParameters>
                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                    <asp:Parameter Name="pageSize" Type="Int32" />
                    <asp:Parameter Name="sortExpression" Type="String" />
                    <asp:Parameter Name="filterExpression" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
            <br />
            <br />
            <div>
                <kti:SecureButton ID="btnSubmit" ValidationGroup="PRMMaterialReceiveEntity" OnClick="btnSave_Click"
                    runat="server" Text="Add" UniqueKey="PRMMaterialReceiveControl_Submit_key" />
                <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server" 
                    Text="Add New" UniqueKey="PRMMaterialReceiveControl_AddNew_key" />
                <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear" Visible="false"
                    UniqueKey="PRMMaterialReceiveControl_Clear_key" />
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
                                ID="TextBox1" runat="server" />
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
                                UniqueKey="PRMMaterialReceiveDetailsWithApprovalControl_Approve_key" OnClick="btnApprove_Click" />
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
                                UniqueKey="PRMMaterialReceiveDetailsWithApprovalControl_Reject_key" OnClick="btnReject_Click" />
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
                                UniqueKey="PRMMaterialReceiveDetailsWithApprovalControl_Forward_key" OnClick="btnForward_Click" />
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
                                UniqueKey="PRMMaterialReceiveDetailsWithApprovalControl_SubmitComment_key" OnClick="btnSubmitComment_Click" />
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
