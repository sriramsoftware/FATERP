<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 08-Nov-2013, 09:51:38
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="REQRequisitionUploadInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.REQRequisitionUploadInfoControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit R EQRequisition Upload Info"></asp:Label>
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
                        Requisition&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlRequisitionID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="REQRequisitionUploadInfoEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvRequisitionID" runat="server" ControlToValidate="ddlRequisitionID"
                            ErrorMessage="Please Select Requisition" ValidationGroup="REQRequisitionUploadInfoEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Extension&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtExtension">
                            Enter Extension</label>
                        <asp:TextBox ID="txtExtension" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="REQRequisitionUploadInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvExtension" runat="server" ControlToValidate="txtExtension"
                            ErrorMessage="Please Enter Extension" ValidationGroup="REQRequisitionUploadInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="REQRequisitionUploadInfoEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Path&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtPath">
                            Enter Path</label>
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtPath" runat="server" ValidationGroup="REQRequisitionUploadInfoEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvPath" runat="server" ControlToValidate="txtPath"
                            ErrorMessage="Please Enter Path" ValidationGroup="REQRequisitionUploadInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Original File Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtOriginalFileName">
                            Enter Original File Name</label>
                        <asp:TextBox ID="txtOriginalFileName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="REQRequisitionUploadInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvOriginalFileName" runat="server" ControlToValidate="txtOriginalFileName"
                            ErrorMessage="Please Enter Original File Name" ValidationGroup="REQRequisitionUploadInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Current File Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtCurrentFileName">
                            Enter Current File Name</label>
                        <asp:TextBox ID="txtCurrentFileName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="REQRequisitionUploadInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCurrentFileName" runat="server" ControlToValidate="txtCurrentFileName"
                            ErrorMessage="Please Enter Current File Name" ValidationGroup="REQRequisitionUploadInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        File Type&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFileType">
                            Enter File Type</label>
                        <asp:TextBox ID="txtFileType" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="REQRequisitionUploadInfoEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFileType" runat="server" ControlToValidate="txtFileType"
                            ErrorMessage="Please Enter File Type" ValidationGroup="REQRequisitionUploadInfoEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="REQRequisitionUploadInfoEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="REQRequisitionUploadInfoControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="REQRequisitionUploadInfoControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="REQRequisitionUploadInfoControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                R EQRequisition Upload Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvREQRequisitionUploadInfo" runat="server" DataSourceID="odsREQRequisitionUploadInfo" OnItemCommand="lvREQRequisitionUploadInfo_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Requisition
                                    </td>
                                    <td class="hi">
                                        Extension
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Path
                                    </td>
                                    <td class="hi">
                                        Original File Name
                                    </td>
                                    <td class="hi">
                                        Current File Name
                                    </td>
                                    <td class="hi">
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
                                    <%# Eval("RequisitionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extension")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Path")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OriginalFileName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CurrentFileName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FileType")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("RequisitionUploadInfoID")%>' UniqueKey="REQRequisitionUploadInfo_lvREQRequisitionUploadInfo_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete R EQRequisition Upload Info?')"
                                        CommandArgument='<%#Eval("RequisitionUploadInfoID")%>' UniqueKey="REQRequisitionUploadInfo_lvREQRequisitionUploadInfo_Edit_key"/>
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
                                    <%# Eval("RequisitionID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extension")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Path")%>
                                </td>
                                <td class="i">
                                    <%# Eval("OriginalFileName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CurrentFileName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FileType")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("RequisitionUploadInfoID")%>' UniqueKey="REQRequisitionUploadInfo_lvREQRequisitionUploadInfo_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete R EQRequisition Upload Info?')"
                                        CommandArgument='<%#Eval("RequisitionUploadInfoID")%>' UniqueKey="REQRequisitionUploadInfo_lvREQRequisitionUploadInfo_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsREQRequisitionUploadInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.REQRequisitionUploadInfoDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsREQRequisitionUploadInfo_Selecting">
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
