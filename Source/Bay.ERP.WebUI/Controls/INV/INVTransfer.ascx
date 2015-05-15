<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 18-Dec-2012, 01:46:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVTransfer.ascx.cs" Inherits="Bay.ERP.Web.UI.INVTransferControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Transfer"></asp:Label>
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
                    <div class="TableFormLeble" style="text-align: right;">
                        TRF No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTRFNo">
                            Enter TRF No</label>
                        <asp:TextBox ID="txtTRFNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ReadOnly="true" ValidationGroup="INVTransferEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTRFNo" runat="server" ControlToValidate="txtTRFNo"
                            ErrorMessage="Please Enter T RFNo" ValidationGroup="INVTransferEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Req. By Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRequestedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVTransferEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRequestedByEmployeeID" runat="server" ControlToValidate="ddlRequestedByEmployeeID"
                            ErrorMessage="Please Select Requested By Employee" ValidationGroup="INVTransferEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Request Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtRequestDate">
                            Enter Request Date</label>
                        <asp:TextBox ID="txtRequestDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="INVTransferEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRequestDate" runat="server" ControlToValidate="txtRequestDate"
                            ErrorMessage="Please Enter Request Date" ValidationGroup="INVTransferEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revRequestDate" runat="server" ControlToValidate="txtRequestDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="INVTransferEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Transfer From Store&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlTransferFromStoreID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlTransferFromStoreID_SelectedIndexChanged"
                            runat="server" ValidationGroup="INVTransferEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTransferFromStoreID" runat="server" ControlToValidate="ddlTransferFromStoreID"
                            ErrorMessage="Please Select Transfer From Store" ValidationGroup="INVTransferEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Transfer From SU&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlTransferFromStoreUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVTransferEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTransferFromStoreUnitID" runat="server" ControlToValidate="ddlTransferFromStoreUnitID"
                            ErrorMessage="Please Select Transfer From Store Unit" ValidationGroup="INVTransferEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Transfer To Store&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlTransferToStoreID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlTransferToStoreID_SelectedIndexChanged"
                            runat="server" ValidationGroup="INVTransferEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTransferToStoreID" runat="server" ControlToValidate="ddlTransferToStoreID"
                            ErrorMessage="Please Select Transfer To Store" ValidationGroup="INVTransferEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Transfer To SU&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlTransferToStoreUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVTransferEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTransferToStoreUnitID" runat="server" ControlToValidate="ddlTransferToStoreUnitID"
                            ErrorMessage="Please Select Transfer To Store Unit" ValidationGroup="INVTransferEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="INVTransferEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlInventoryTransferStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            Enabled="false" runat="server" ValidationGroup="INVTransferEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvInventoryTransferStatusID" runat="server" ControlToValidate="ddlInventoryTransferStatusID"
                            ErrorMessage="Please Select Inventory Transfer Status" ValidationGroup="INVTransferEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="INVTransferEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="INVTransferControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="INVTransferControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="INVTransferControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <br />
            <br />
            <div class="TableRow" style="width: 100%; padding-left: 600px;">
                <div class="TableFormLeble" style="text-align: right;">
                    Filter List&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        Type From Store# Or Status</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="listContentTitle">
                Transfer List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVTransfer" runat="server" DataSourceID="odsINVTransfer" OnItemCommand="lvINVTransfer_ItemCommand"
                        OnItemDataBound="lvINVTransfer_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        TRN No
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Requested By Employee
                                    </td>
                                    <td class="hi">
                                        Request Date
                                    </td>
                                    <td class="hi">
                                        Transfer From Store
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Transfer From Store Unit
                                    </td>
                                    <td class="hi">
                                        Transfer To Store
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Transfer To Store Unit
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Inventory Transfer Status
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
                                    </td>
                                    <td class="his">
                                        Approval Status
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
                                    <asp:HyperLink ID="hypTRFNo" runat="server" CssClass="CommonLink" Text='<%# Eval("TRFNo")%>'></asp:HyperLink>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("HREmployeeMemberID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequestDate") != null ? ((DateTime)Eval("RequestDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferFromStore")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("TransferFromStoreUnit")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferToStoreName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("TransferToUnit")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDInventoryTransferStatusName")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("TransferID")%>'
                                        UniqueKey="INVTransfer_lvINVTransfer_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVTransfer?')"
                                        CommandArgument='<%#Eval("TransferID")%>' UniqueKey="INVTransfer_lvINVTransfer_Delete_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
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
                                  <asp:HyperLink ID="hypTRFNo" runat="server" CssClass="CommonLink" Text='<%# Eval("TRFNo")%>'></asp:HyperLink>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("HREmployeeMemberID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequestDate") != null ? ((DateTime)Eval("RequestDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferFromStore")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("TransferFromStoreUnit")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TransferToStoreName")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("TransferToUnit")%>
                                </td>
                                <td class="i" style="display: none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDInventoryTransferStatusName")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("TransferID")%>'
                                        UniqueKey="INVTransfer_lvINVTransfer_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVTransfer?')"
                                        CommandArgument='<%#Eval("TransferID")%>' UniqueKey="INVTransfer_lvINVTransfer_Delete_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
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
                <asp:ObjectDataSource ID="odsINVTransfer" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVTransfer_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVTransfer_Selecting">
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
