<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 29-Dec-2013, 02:13:24
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeNoticeOperation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeNoticeOperationControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="HTMLEditor" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Employee Notice"></asp:Label>
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
                        To Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSendToEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeNoticeEntity" AutoPostBack="true"
                            Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSendToEmployeeID" runat="server" ControlToValidate="ddlSendToEmployeeID"
                            ErrorMessage="Please Select Send To Employee" ValidationGroup="HREmployeeNoticeEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Subject&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMemo" runat="server" ClientIDMode="Static"
                            CssClass="ktiTextBox" ValidationGroup="HREmployeeNoticeEntity" Width="210" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Template&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlTemplateID" CssClass="ktiSelect" ClientIDMode="Static" OnSelectedIndexChanged="ddlTemplateID_SelectedIndexChanged"
                            AutoPostBack="true" runat="server" ValidationGroup="HREmployeeNoticeEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvOriginRegionID" runat="server" ControlToValidate="ddlTemplateID"
                            ErrorMessage="Please Select Origin Region" ValidationGroup="HREmployeeNoticeEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Text&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <HTMLEditor:Editor runat="server" ID="txtText" Height="530px" AutoFocus="false" Width="100%"
                            ValidationGroup="HREmployeeNoticeEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvText" runat="server" ControlToValidate="txtText"
                            ErrorMessage="Please Enter Text" ValidationGroup="HREmployeeNoticeEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="HREmployeeNoticeEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Notice Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtNoticeDate">
                            Enter Notice Date</label>
                        <asp:TextBox ID="txtNoticeDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="HREmployeeNoticeEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvNoticeDate" runat="server" ControlToValidate="txtNoticeDate"
                            ErrorMessage="Please Enter Notice Date" ValidationGroup="HREmployeeNoticeEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revNoticeDate" runat="server" ControlToValidate="txtNoticeDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="HREmployeeNoticeEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <asp:Button ID="btnSubmit" ValidationGroup="HREmployeeNoticeEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeNoticeControl_Submit_key" />
                        <asp:Button ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="HREmployeeNoticeControl_AddNew_key" />
                        <asp:Button ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="HREmployeeNoticeControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <br />
            <div class="TableRow" style="width: 100%; float: right;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormLeble" style="text-align: right; width: 617px;">
                    Filter Text&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtSearchText">
                        Type Employee Name</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFiltring" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFiltering_CheckedChanged" Text="Use Filter" /></span>
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Employee Notice List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeNotice" runat="server" DataSourceID="odsHREmployeeNotice"
                        OnItemCommand="lvHREmployeeNotice_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="his" style="width:135px;">
                                        Seen By Employee
                                    </td>
                                    <td class="hi">
                                        Send To Employee
                                    </td>
                                    <td class="hi">
                                        Notice Type
                                    </td>
                                    <td class="hi">
                                        Notice Date
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
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="30">
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
                                    <%# Eval("SeenNotice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SendToEmployeeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TemplateName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NoticeDate") != null ? ((DateTime)Eval("NoticeDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeNoticeID")%>'
                                        UniqueKey="HREmployeeNotice_lvHREmployeeNotice_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Notice?')"
                                        CommandArgument='<%#Eval("EmployeeNoticeID")%>' UniqueKey="HREmployeeNotice_lvHREmployeeNotice_Edit_key" />
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
                                    <%# Eval("SeenNotice")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SendToEmployeeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("TemplateName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NoticeDate") != null ? ((DateTime)Eval("NoticeDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("EmployeeNoticeID")%>'
                                        UniqueKey="HREmployeeNotice_lvHREmployeeNotice_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Notice?')"
                                        CommandArgument='<%#Eval("EmployeeNoticeID")%>' UniqueKey="HREmployeeNotice_lvHREmployeeNotice_Edit_key" />
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
                <asp:ObjectDataSource ID="odsHREmployeeNotice" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeNotice_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeNotice_Selecting">
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
