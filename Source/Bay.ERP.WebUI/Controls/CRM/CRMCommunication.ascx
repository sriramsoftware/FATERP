<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 01-Apr-2013, 02:41:21
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMCommunication.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMCommunicationControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Communication"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
        <div>
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
            <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="Label1" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Process Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProcessCategoryID" CssClass="ktiSelect" ClientIDMode="Static" AutoPostBack="true" OnSelectedIndexChanged="ddlProcessCategoryID_SelectedIndexChanged"
                            runat="server" ValidationGroup="CRMCommunicationEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProcessCategoryID" runat="server" ControlToValidate="ddlProcessCategoryID"
                            ErrorMessage="Please Select Process Category" ValidationGroup="CRMCommunicationEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                       <asp:Label ID="lblReference" runat="server" Text="Reference"></asp:Label>
                       &nbsp;:
                    </div>
                    <div class="TableFormContent">
                             <asp:DropDownList ID="ddlReferenceID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMCommunicationEntity" Width="234">
                        </asp:DropDownList>
                       <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvReferenceID" runat="server" ControlToValidate="ddlReferenceID"
                            ErrorMessage="Please Select Reference" ValidationGroup="CRMCommunicationEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Discussion Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCommuicationDiscussionTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMCommunicationEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCommuicationDiscussionTypeID" runat="server" ControlToValidate="ddlCommuicationDiscussionTypeID"
                            ErrorMessage="Please Select Commuication Discussion Type" ValidationGroup="CRMCommunicationEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Discussion Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtDiscussionDate">
                            Enter Discussion Date</label>
                        <asp:TextBox ID="txtDiscussionDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMCommunicationEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDiscussionDate" runat="server" ControlToValidate="txtDiscussionDate"
                            ErrorMessage="Please Enter Discussion Date" ValidationGroup="CRMCommunicationEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revDiscussionDate" runat="server" ControlToValidate="txtDiscussionDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMCommunicationEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Communicate By&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCommunicateByEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMCommunicationEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCommunicateByEmployeeID" runat="server" ControlToValidate="ddlCommunicateByEmployeeID"
                            ErrorMessage="Please Select Communicate By Employee" ValidationGroup="CRMCommunicationEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Topics&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTopics">
                            Enter Topics</label>
                        <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBox" Width="600" ClientIDMode="Static"
                            ID="txtTopics" runat="server" ValidationGroup="CRMCommunicationEntity" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTopics" runat="server" ControlToValidate="txtTopics"
                            ErrorMessage="Please Enter Topics" ValidationGroup="CRMCommunicationEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Note&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="600" ClientIDMode="Static"
                            ID="txtNote" runat="server" ValidationGroup="CRMCommunicationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Follow Up Needed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsFollowUpNeeded" runat="server" ClientIDMode="Static" ValidationGroup="CRMCommunicationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        I Will Call&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsIWillCall" runat="server" ClientIDMode="Static" ValidationGroup="CRMCommunicationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Next Comm. Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtNextCommunicationDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMCommunicationEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revNextCommunicationDate" runat="server" ControlToValidate="txtNextCommunicationDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMCommunicationEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Is Field1&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsField1" runat="server" ClientIDMode="Static" ValidationGroup="CRMCommunicationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Next Action&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="600" ClientIDMode="Static"
                            ID="txtNextAction" runat="server" ValidationGroup="CRMCommunicationEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlCommunicationStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMCommunicationEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvCommunicationStatusID" runat="server" ControlToValidate="ddlCommunicationStatusID"
                            ErrorMessage="Please Select Communication Status" ValidationGroup="CRMCommunicationEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMCommunicationEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CRMCommunicationControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="CRMCommunicationControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="CRMCommunicationControl_Clear_key" />
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
                        Type Buyer or Name</label>
                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                </div>
            </div>
            <div class="listContentTitle">
                Communication List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMCommunication" runat="server" DataSourceID="odsCRMCommunication" OnItemCommand="lvCRMCommunication_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Discussion Type
                                    </td>
                                    <td class="hi">
                                        Discussion Date
                                    </td>
                                    <td class="hi">
                                        Communicate By
                                    </td>
                                    <td class="hi">
                                        Buyer
                                    </td>
                                    <td class="hi">
                                        Topics
                                    </td>
                                    <td class="hi">
                                        Note
                                    </td>
                                    <td class="hi">
                                        Follow Up Needed
                                    </td>
                                    <td class="hi">
                                        I Will Call
                                    </td>
                                    <td class="hi">
                                        Next Action
                                    </td>
                                    <td class="hi">
                                        Next Comm. Date
                                    </td>
                                    <td class="hi">
                                        Status
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
                                    <%# Eval("CommuicationDiscussionTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DiscussionDate") != null ? ((DateTime)Eval("DiscussionDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommunicateByMemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommunicateToContactFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Topics")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Note")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsFollowUpNeeded") != null ? (((Boolean)Eval("IsFollowUpNeeded")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsIWillCall") != null ? (((Boolean)Eval("IsIWillCall")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("NextAction")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NextCommunicationDate") != null ? ((DateTime)Eval("NextCommunicationDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommunicationStatusName")%>
                                </td>
                                
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("CommunicationID")%>' UniqueKey="CRMCommunication_lvCRMCommunication_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Communication?')"
                                        CommandArgument='<%#Eval("CommunicationID")%>' UniqueKey="CRMCommunication_lvCRMCommunication_Delete_key"/>
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
                                    <%# Eval("CommuicationDiscussionTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DiscussionDate") != null ? ((DateTime)Eval("DiscussionDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommunicateByMemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommunicateToContactFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Topics")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Note")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsFollowUpNeeded") != null ? (((Boolean)Eval("IsFollowUpNeeded")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsIWillCall") != null ? (((Boolean)Eval("IsIWillCall")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("NextAction")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NextCommunicationDate") != null ? ((DateTime)Eval("NextCommunicationDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommunicationStatusName")%>
                                </td>
                                
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("CommunicationID")%>' UniqueKey="CRMCommunication_lvCRMCommunication_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Communication?')"
                                        CommandArgument='<%#Eval("CommunicationID")%>' UniqueKey="CRMCommunication_lvCRMCommunication_Delete_key"/>
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
                <asp:ObjectDataSource ID="odsCRMCommunication" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMCommunication_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMCommunication_Selecting">
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
