<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 06-Oct-2013, 05:27:25
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNEventInvitationInformation.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMNEventInvitationInformationControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Event Invitation Information"></asp:Label>
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
                        Member&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlInitationGivenToMemberID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMNEventInvitationInformationEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvInitationGivenToMemberID" runat="server" ControlToValidate="ddlInitationGivenToMemberID"
                            ErrorMessage="Please Select Initation Given To Member" ValidationGroup="CMNEventInvitationInformationEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                 <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Guest Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEventInvitatedPersonTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMNEventInvitationInformationEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEventInvitatedPersonTypeID" runat="server" ControlToValidate="ddlEventInvitatedPersonTypeID"
                            ErrorMessage="Please Select Event Invitated Person Type" ValidationGroup="CMNEventInvitationInformationEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Message&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" ID="txtMessage" ClientIDMode="Static" CssClass="ktiTextBox"
                        ReadOnly="false" runat="server" ValidationGroup="CMNEventInvitationInformationEntity" Width="300" Height="95" />
                </div>
                 <div class="TableFormValidatorContent">
                        </div>
            </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CMNEventInvitationInformationEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CMNEventInvitationInformationControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="CMNEventInvitationInformationControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="CMNEventInvitationInformationControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Event Invitation Information List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMNEventInvitationInformation" runat="server" DataSourceID="odsCMNEventInvitationInformation" OnItemCommand="lvCMNEventInvitationInformation_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                     <td class="hi" style="width:150px;">
                                        Event
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Initation Given By
                                    </td>
                                    <td class="hi">
                                        Date
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Message
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Initation Given To
                                    </td>
                                    <td class="hi" style="width:115px;">
                                        Is Guest Going
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
                                    <%# Eval("Title")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InitationGivenByMember")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SharedDateTime") != null ? ((DateTime)Eval("SharedDateTime")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Message")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InitationGivenToMember")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsGuestGoing") != null ? (((Boolean)Eval("IsGuestGoing")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EventInvitationInformationID")%>' UniqueKey="CMNEventInvitationInformation_lvCMNEventInvitationInformation_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MNEvent Invitation Information?')"
                                        CommandArgument='<%#Eval("EventInvitationInformationID")%>' UniqueKey="CMNEventInvitationInformation_lvCMNEventInvitationInformation_Edit_key"/>
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
                                    <%# Eval("Title")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InitationGivenByMember")%>
                                </td>
                                <td class="i">
                                    <%# Eval("SharedDateTime") != null ? ((DateTime)Eval("SharedDateTime")).ToString("dd-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Message")%>
                                </td>
                                <td class="i">
                                    <%# Eval("InitationGivenToMember")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IsGuestGoing") != null ? (((Boolean)Eval("IsGuestGoing")) ? "Yes" : "No") : ""%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("EventInvitationInformationID")%>' UniqueKey="CMNEventInvitationInformation_lvCMNEventInvitationInformation_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MNEvent Invitation Information?')"
                                        CommandArgument='<%#Eval("EventInvitationInformationID")%>' UniqueKey="CMNEventInvitationInformation_lvCMNEventInvitationInformation_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsCMNEventInvitationInformation" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMNEventInvitationInformation_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMNEventInvitationInformation_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
             <asp:Button ID="btnSendMailToGuest" OnClick="btnSendMailToGuest_Click"
                            runat="server" Text="Send Mail To Guest" />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
