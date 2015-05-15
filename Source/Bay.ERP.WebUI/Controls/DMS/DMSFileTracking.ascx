<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 10-Sep-2012, 10:20:04
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DMSFileTracking.ascx.cs"
    Inherits="Bay.ERP.Web.UI.DMSFileTrackingControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit File Tracking"></asp:Label>
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
                        File No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFileNo">
                            Enter File No</label>
                        <asp:TextBox ID="txtFileNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="DMSFileTrackingEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFileNo" runat="server" ControlToValidate="txtFileNo"
                            ErrorMessage="Please Enter File No" ValidationGroup="DMSFileTrackingEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        File Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFileName">
                            Enter File Name</label>
                        <asp:TextBox ID="txtFileName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="DMSFileTrackingEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFileName" runat="server" ControlToValidate="txtFileName"
                            ErrorMessage="Please Enter File Name" ValidationGroup="DMSFileTrackingEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Department&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDepartmentID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="DMSFileTrackingEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDepartmentID" runat="server" ControlToValidate="ddlDepartmentID"
                            ErrorMessage="Please Select Department" ValidationGroup="DMSFileTrackingEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Created Date Time&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCreatedDateTime">
                            Enter Created Date Time</label>
                        <asp:TextBox ID="txtCreatedDateTime" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="DMSFileTrackingEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCreatedDateTime" runat="server" ControlToValidate="txtCreatedDateTime"
                            ErrorMessage="Please Enter Created Date Time" ValidationGroup="DMSFileTrackingEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revCreatedDateTime" runat="server" ControlToValidate="txtCreatedDateTime"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="DMSFileTrackingEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        File Parmanent Place&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFileParmanentPlace">
                            Enter File Parmanent Place</label>
                        <asp:TextBox ID="txtFileParmanentPlace" ClientIDMode="Static" CssClass="ktiTextBox"
                            runat="server" ValidationGroup="DMSFileTrackingEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFileParmanentPlace" runat="server" ControlToValidate="txtFileParmanentPlace"
                            ErrorMessage="Please Enter File Parmanent Place" ValidationGroup="DMSFileTrackingEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        File Current Place&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFileCurrentPlace">
                            Enter File Current Place</label>
                        <asp:TextBox ID="txtFileCurrentPlace" ClientIDMode="Static" CssClass="ktiTextBox"
                            runat="server" ValidationGroup="DMSFileTrackingEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFileCurrentPlace" runat="server" ControlToValidate="txtFileCurrentPlace"
                            ErrorMessage="Please Enter File Current Place" ValidationGroup="DMSFileTrackingEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
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
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="DMSFileTrackingEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="DMSFileTrackingControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="DMSFileTrackingControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="DMSFileTrackingControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                File Tracking List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvDMSFileTracking" runat="server" DataSourceID="odsDMSFileTracking"
                        OnItemCommand="lvDMSFileTracking_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        File No
                                    </td>
                                    <td class="hi">
                                        File Name
                                    </td>
                                    <td class="hi">
                                        Department
                                    </td>
                                    <td class="hi">
                                        Created By Employee
                                    </td>
                                    <td class="hi">
                                        Created Date Time
                                    </td>
                                    <td class="hi">
                                        File Parmanent Place
                                    </td>
                                    <td class="hi">
                                        File Current Place
                                    </td>
                                    <td class="hi" style="display:none;">
                                        File Type
                                    </td>
                                    <td class="hi">
                                        Soft File Name
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Extension
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
                                    <%# Eval("FileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FileName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepartmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedDateTime") != null ? ((DateTime)Eval("CreatedDateTime")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("FileParmanentPlace")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FileCurrentPlace")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("FileType")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OriginalFileName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Extension")%>
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
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("FileTrackingID")%>'
                                        UniqueKey="DMSFileTracking_lvDMSFileTracking_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete File Tracking?')"
                                        CommandArgument='<%#Eval("FileTrackingID")%>' UniqueKey="DMSFileTracking_lvDMSFileTracking_Delete_key" />
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
                                    <%# Eval("FileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FileName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DepartmentName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedDateTime") != null ? ((DateTime)Eval("CreatedDateTime")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("FileParmanentPlace")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FileCurrentPlace")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("FileType")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OriginalFileName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Extension")%>
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
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("FileTrackingID")%>'
                                        UniqueKey="DMSFileTracking_lvDMSFileTracking_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete File Tracking?')"
                                        CommandArgument='<%#Eval("FileTrackingID")%>' UniqueKey="DMSFileTracking_lvDMSFileTracking_Delete_key" />
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
                <asp:ObjectDataSource ID="odsDMSFileTracking" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.DMSFileTracking_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsDMSFileTracking_Selecting">
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
