<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 23-Mar-2013, 04:14:01
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KBUserTreeShared.ascx.cs"
    Inherits="Bay.ERP.Web.UI.KBUserTreeSharedControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit K BUser Tree Shared"></asp:Label>
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
                        User Tree&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlUserTreeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="KBUserTreeSharedEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvUserTreeID" runat="server" ControlToValidate="ddlUserTreeID"
                            ErrorMessage="Please Select User Tree" ValidationGroup="KBUserTreeSharedEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        User Tree Setting&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlUserTreeSettingID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="KBUserTreeSharedEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvUserTreeSettingID" runat="server" ControlToValidate="ddlUserTreeSettingID"
                            ErrorMessage="Please Select User Tree Setting" ValidationGroup="KBUserTreeSharedEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Message&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMessage" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="KBUserTreeSharedEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Shared Given By Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSharedGivenByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="KBUserTreeSharedEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSharedGivenByEmployeeID" runat="server" ControlToValidate="ddlSharedGivenByEmployeeID"
                            ErrorMessage="Please Select Shared Given By Employee" ValidationGroup="KBUserTreeSharedEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Shared Date Time&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSharedDateTime">
                            Enter Shared Date Time</label>
                        <asp:TextBox ID="txtSharedDateTime" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="KBUserTreeSharedEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSharedDateTime" runat="server" ControlToValidate="txtSharedDateTime"
                            ErrorMessage="Please Enter Shared Date Time" ValidationGroup="KBUserTreeSharedEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revSharedDateTime" runat="server" ControlToValidate="txtSharedDateTime"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|1[012])[- /.](0[1-9]|[12][0-9]|3[01])[- /.](19|20)\d\d$"
                            ValidationGroup="KBUserTreeSharedEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Shared Given To Employee&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSharedGivenToEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="KBUserTreeSharedEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSharedGivenToEmployeeID" runat="server" ControlToValidate="ddlSharedGivenToEmployeeID"
                            ErrorMessage="Please Select Shared Given To Employee" ValidationGroup="KBUserTreeSharedEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        I P&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtIP" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="KBUserTreeSharedEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        User Tree Permission&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlUserTreePermissionID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="KBUserTreeSharedEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvUserTreePermissionID" runat="server" ControlToValidate="ddlUserTreePermissionID"
                            ErrorMessage="Please Select User Tree Permission" ValidationGroup="KBUserTreeSharedEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="KBUserTreeSharedEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="KBUserTreeSharedControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="KBUserTreeSharedControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="KBUserTreeSharedControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                K BUser Tree Shared List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvKBUserTreeShared" runat="server" DataSourceID="odsKBUserTreeShared" OnItemCommand="lvKBUserTreeShared_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        User Tree
                                    </td>
                                    <td class="hi">
                                        User Tree Setting
                                    </td>
                                    <td class="hi">
                                        Message
                                    </td>
                                    <td class="hi">
                                        Shared Given By Employee
                                    </td>
                                    <td class="hi">
                                        Shared Date Time
                                    </td>
                                    <td class="hi">
                                        Shared Given To Employee
                                    </td>
                                    <td class="hi">
                                        I P
                                    </td>
                                    <td class="hi">
                                        User Tree Permission
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
                                    <%# Eval("UserTreeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UserTreeSettingID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Message")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SharedGivenByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SharedDateTime") != null ? ((DateTime)Eval("SharedDateTime")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SharedGivenToEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UserTreePermissionID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("UserTreeSharedID")%>' UniqueKey="KBUserTreeShared_lvKBUserTreeShared_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete K BUser Tree Shared?')"
                                        CommandArgument='<%#Eval("UserTreeSharedID")%>' UniqueKey="KBUserTreeShared_lvKBUserTreeShared_Edit_key"/>
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
                                    <%# Eval("UserTreeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UserTreeSettingID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Message")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SharedGivenByEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SharedDateTime") != null ? ((DateTime)Eval("SharedDateTime")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SharedGivenToEmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <%# Eval("UserTreePermissionID")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("UserTreeSharedID")%>' UniqueKey="KBUserTreeShared_lvKBUserTreeShared_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete K BUser Tree Shared?')"
                                        CommandArgument='<%#Eval("UserTreeSharedID")%>' UniqueKey="KBUserTreeShared_lvKBUserTreeShared_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsKBUserTreeShared" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.KBUserTreeSharedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsKBUserTreeShared_Selecting">
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
