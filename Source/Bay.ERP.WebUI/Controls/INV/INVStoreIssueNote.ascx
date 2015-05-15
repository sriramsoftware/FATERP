<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 17-Dec-2012, 12:52:14
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="INVStoreIssueNote.ascx.cs"
    Inherits="Bay.ERP.Web.UI.INVStoreIssueNoteControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Store Issue Note"></asp:Label>
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
                        Project&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreIssueNoteEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                            ErrorMessage="Please Select Project" ValidationGroup="INVStoreIssueNoteEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        SIN No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtStoreIssueNoteNo">
                            Enter Store Issue Note No</label>
                        <asp:TextBox ID="txtStoreIssueNoteNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server" ReadOnly="false"
                            ValidationGroup="INVStoreIssueNoteEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvStoreIssueNoteNo" runat="server" ControlToValidate="txtStoreIssueNoteNo"
                            ErrorMessage="Please Enter Store Issue Note No" ValidationGroup="INVStoreIssueNoteEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        SRF No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSRFNo">
                            Enter SRF No</label>
                        <asp:TextBox ID="txtSRFNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="INVStoreIssueNoteEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSRFNo" runat="server" ControlToValidate="txtSRFNo"
                            ErrorMessage="Please Enter S RFNo" ValidationGroup="INVStoreIssueNoteEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Requested By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRequestedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="INVStoreIssueNoteEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRequestedByEmployeeID" runat="server" ControlToValidate="ddlRequestedByEmployeeID"
                            ErrorMessage="Please Select Requested By Employee" ValidationGroup="INVStoreIssueNoteEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Request Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtRequestDate">
                            Enter Request Date</label>
                        <asp:TextBox ID="txtRequestDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="INVStoreIssueNoteEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRequestDate" runat="server" ControlToValidate="txtRequestDate"
                            ErrorMessage="Please Enter Request Date" ValidationGroup="INVStoreIssueNoteEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revRequestDate" runat="server" ControlToValidate="txtRequestDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="INVStoreIssueNoteEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="INVStoreIssueNoteEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        SIN Approval Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlStoreIssueNoteApprovalStatusID" CssClass="ktiSelect" ClientIDMode="Static" Enabled="false"
                            runat="server" ValidationGroup="INVStoreIssueNoteEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvStoreIssueNoteApprovalStatusID" runat="server" ControlToValidate="ddlStoreIssueNoteApprovalStatusID"
                            ErrorMessage="Please Select Store Issue Note Approval Status" ValidationGroup="INVStoreIssueNoteEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="INVStoreIssueNoteEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="INVStoreIssueNoteEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="INVStoreIssueNoteControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="INVStoreIssueNoteControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="INVStoreIssueNoteControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
             <br />
            <br />
            <div class="TableRow" style="width: 100%; padding-left:600px;">
            <div class="TableFormLeble" style="text-align: right;">
                Filter List&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Project# Or Status</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                     Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"
                        Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
            <div class="listContentTitle">
                Store Issue Note List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvINVStoreIssueNote" runat="server" DataSourceID="odsINVStoreIssueNote" OnItemCommand="lvINVStoreIssueNote_ItemCommand" OnItemDataBound="lvINVStoreIssueNote_ItemDataBound">
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
                                        Store Issue Note No
                                    </td>
                                    <td class="hi">
                                        SRF No
                                    </td>
                                    <td class="hi">
                                        Requested By
                                    </td>
                                    <td class="hi">
                                        Request Date
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Store Issue Note Approval Status
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Is Removed
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
                                    </td>
                                    <td class="his">
                                        Request Item
                                    </td>
                                    <td class="his">
                                        Issue Item
                                    </td>
                                    <td class="his">
                                        Return Item
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
                                 <asp:HyperLink ID="hypStoreIssueNoteNoLV" runat="server" Text='<%# Eval("StoreIssueNoteNo")%>' ToolTip='<%# Eval("Remarks")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("SRFNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequestDate") != null ? ((DateTime)Eval("RequestDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDStoreIssueNoteApprovalStatusName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("StoreIssueNoteID")%>' UniqueKey="INVStoreIssueNote_lvINVStoreIssueNote_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVStore Issue Note?')"
                                        CommandArgument='<%#Eval("StoreIssueNoteID")%>' UniqueKey="INVStoreIssueNote_lvINVStoreIssueNote_Delete_key"/>
                                </td>
                                 <td class="i">
                                    <asp:HyperLink ID="lnkBtnRequestItem" runat="server" CssClass="CommonButtonLink" Text="Request Item"
                                        CommandName="RequestItem" CommandArgument='<%#Eval("StoreIssueNoteID")%>'/>
                                </td>
                                 <td class="i">
                                    <asp:HyperLink ID="lnkBtnIssueItem" runat="server" CssClass="CommonButtonLink" Text="Issue Item"
                                        CommandName="IssueItem" CommandArgument='<%#Eval("StoreIssueNoteID")%>'/>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkBtnReturnItem" runat="server" CssClass="CommonButtonLink" Text="Return Item"
                                        CommandName="ReturnItem" CommandArgument='<%#Eval("StoreIssueNoteID")%>'/>
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
                                  <asp:HyperLink ID="hypStoreIssueNoteNoLV" runat="server" Text='<%# Eval("StoreIssueNoteNo")%>' ToolTip='<%# Eval("Remarks")%>'></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("SRFNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("RequestDate") != null ? ((DateTime)Eval("RequestDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MDStoreIssueNoteApprovalStatusName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("IsRemoved") != null ? (((Boolean)Eval("IsRemoved")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("StoreIssueNoteID")%>' UniqueKey="INVStoreIssueNote_lvINVStoreIssueNote_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete I NVStore Issue Note?')"
                                        CommandArgument='<%#Eval("StoreIssueNoteID")%>' UniqueKey="INVStoreIssueNote_lvINVStoreIssueNote_Delete_key"/>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkBtnRequestItem" runat="server" CssClass="CommonButtonLink" Text="Request Item"
                                        CommandName="RequestItem" CommandArgument='<%#Eval("StoreIssueNoteID")%>'/>
                                </td>
                                 <td class="i">
                                    <asp:HyperLink ID="lnkBtnIssueItem" runat="server" CssClass="CommonButtonLink" Text="Issue Item"
                                        CommandName="IssueItem" CommandArgument='<%#Eval("StoreIssueNoteID")%>'/>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="lnkBtnReturnItem" runat="server" CssClass="CommonButtonLink" Text="Return Item"
                                        CommandName="ReturnItem" CommandArgument='<%#Eval("StoreIssueNoteID")%>'/>
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
                <asp:ObjectDataSource ID="odsINVStoreIssueNote" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.INVStoreIssueNote_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsINVStoreIssueNote_Selecting">
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
