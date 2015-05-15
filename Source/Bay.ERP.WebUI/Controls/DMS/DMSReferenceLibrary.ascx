<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 10-Sep-2012, 10:20:04
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DMSReferenceLibrary.ascx.cs"
    Inherits="Bay.ERP.Web.UI.DMSReferenceLibraryControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <Triggers>
        <asp:PostBackTrigger ControlID="btnSubmit" />
    </Triggers>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Reference Library"></asp:Label>
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
                        Ref. Library Cat.&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlReferenceLibraryCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="DMSReferenceLibraryEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvReferenceLibraryCategoryID" runat="server" ControlToValidate="ddlReferenceLibraryCategoryID"
                            ErrorMessage="Please Select Reference Library Category" ValidationGroup="DMSReferenceLibraryEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Url&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtUrl">
                            Enter Url</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                            ClientIDMode="Static" ID="txtUrl" runat="server" ValidationGroup="DMSReferenceLibraryEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvUrl" runat="server" ControlToValidate="txtUrl"
                            ErrorMessage="Please Enter Url" ValidationGroup="DMSReferenceLibraryEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Description&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                            ClientIDMode="Static" ID="txtDescription" runat="server" ValidationGroup="DMSReferenceLibraryEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        File Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <asp:FileUpload ID="fuImageUrl" ClientIDMode="Static" runat="server" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Referenced By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlReferencedByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="DMSReferenceLibraryEntity" Width="236">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="105"
                            ClientIDMode="Static" ID="txtRemarks" runat="server" ValidationGroup="DMSReferenceLibraryEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="DMSReferenceLibraryEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="DMSReferenceLibraryControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="DMSReferenceLibraryControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="DMSReferenceLibraryControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Reference Library List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvDMSReferenceLibrary" runat="server" DataSourceID="odsDMSReferenceLibrary"
                        OnItemCommand="lvDMSReferenceLibrary_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Ref. Library Category
                                    </td>
                                    <td class="hi" style="width:200px;">
                                        Url
                                    </td>
                                    <td class="hi" style="width:200px;">
                                        Description
                                    </td>
                                    <td class="hi">
                                        File Name
                                    </td>
                                    <td class="hi">
                                        Created By Employee
                                    </td>
                                    <td class="hi">
                                        Referenced By Employee
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Extension
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Remarks
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Path
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Original File Name
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Current File Name
                                    </td>
                                    <td class="hi" style="display:none;">
                                        File Type
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
                                    <%# Eval("ReferenceLibraryCategoryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Url")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OriginalFileName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReferencedByFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Extension")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Path")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("OriginalFileName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CurrentFileName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("FileType")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ReferenceLibraryID")%>'
                                        UniqueKey="DMSReferenceLibrary_lvDMSReferenceLibrary_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Reference Library?')"
                                        CommandArgument='<%#Eval("ReferenceLibraryID")%>' UniqueKey="DMSReferenceLibrary_lvDMSReferenceLibrary_Delete_key" />
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
                                    <%# Eval("ReferenceLibraryCategoryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Url")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Description")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OriginalFileName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReferencedByFullName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Extension")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Path")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("OriginalFileName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("CurrentFileName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("FileType")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ReferenceLibraryID")%>'
                                        UniqueKey="DMSReferenceLibrary_lvDMSReferenceLibrary_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Reference Library?')"
                                        CommandArgument='<%#Eval("ReferenceLibraryID")%>' UniqueKey="DMSReferenceLibrary_lvDMSReferenceLibrary_Delete_key" />
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
                <asp:ObjectDataSource ID="odsDMSReferenceLibrary" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.DMSReferenceLibrary_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsDMSReferenceLibrary_Selecting">
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
