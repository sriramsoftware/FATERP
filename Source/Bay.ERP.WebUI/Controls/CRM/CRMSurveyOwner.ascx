<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 24-Oct-2013, 12:51:37
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMSurveyOwner.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMSurveyOwnerControl" %>

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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Survey Owner"></asp:Label>
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
                        Survey Owner Type&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlSurveyOwnerTypeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CRMSurveyOwnerEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSurveyOwnerTypeID" runat="server" ControlToValidate="ddlSurveyOwnerTypeID"
                            ErrorMessage="Please Select Survey Owner Type" ValidationGroup="CRMSurveyOwnerEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtName">
                            Enter Name</label>
                        <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMSurveyOwnerEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ErrorMessage="Please Enter Name" ValidationGroup="CRMSurveyOwnerEntity" EnableViewState="False"
                Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Address Line1&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtAddressLine1" runat="server" ValidationGroup="CRMSurveyOwnerEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Address Line2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtAddressLine2" runat="server" ValidationGroup="CRMSurveyOwnerEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Contact No1&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtContactNo1" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMSurveyOwnerEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Contact No2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtContactNo2" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMSurveyOwnerEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Email&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMSurveyOwnerEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail" Display="Dynamic"
                            EnableViewState="True" ValidationGroup="CRMSurveyOwnerEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Web Link&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtWebLink" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CRMSurveyOwnerEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revWebLink" runat="server" ControlToValidate="txtWebLink" Display="Dynamic"
                            EnableViewState="True" ValidationGroup="CRMSurveyOwnerEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="CRMSurveyOwnerEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMSurveyOwnerEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CRMSurveyOwnerControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="CRMSurveyOwnerControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="CRMSurveyOwnerControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Survey Owner List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMSurveyOwner" runat="server" DataSourceID="odsCRMSurveyOwner" OnItemCommand="lvCRMSurveyOwner_ItemCommand" OnItemDataBound="lvCRMSurveyOwner_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Owner Type
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Name
                                    </td>
                                    <td class="hi">
                                        Address
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Contact No
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Email
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Web Link
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
                                    </td>
                                    <td class="his">
                                        Report
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
                                    <%# Eval("SurveyOwnerTypeName")%>
                                </td>
                                <td class="i">
                                <asp:HyperLink ID="hypSurveyOwner" runat="server" ClientIDMode="Static" Text='<%# Eval("Name")%>' CssClass="CommonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("AddressLine1")%>
                                </td>
                                <td class="i">
                                    <b>Contact No1&nbsp;</b>:<%# Eval("ContactNo1")%>
                                    <b>Contact No2&nbsp;</b>:<%# Eval("ContactNo2")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("WebLink")%>' ID="a"><%# Eval("WebLink") != String.Empty ? Eval("WebLink").ToString().Substring(0, Math.Min(Eval("WebLink").ToString().Length, 30)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("SurveyOwnerID")%>' UniqueKey="CRMSurveyOwner_lvCRMSurveyOwner_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMSurvey Owner?')"
                                        CommandArgument='<%#Eval("SurveyOwnerID")%>' UniqueKey="CRMSurveyOwner_lvCRMSurveyOwner_Edit_key"/>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypSurveyReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                        CommandName="SurveyReport" CommandArgument='<%#Eval("SurveyOwnerID")%>' UniqueKey="CRMServey_lvCRMServey_SurveyReport_key"></asp:HyperLink>
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
                                    <%# Eval("SurveyOwnerTypeName")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypSurveyOwner" runat="server" ClientIDMode="Static" Text='<%# Eval("Name")%>' CssClass="CommonLink"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("AddressLine1")%>
                                </td>
                                <td class="i">
                                    <b>Contact No1&nbsp;</b>:<%# Eval("ContactNo1")%>
                                    <b>Contact No2&nbsp;</b>:<%# Eval("ContactNo2")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("WebLink")%>' ID="a"><%# Eval("WebLink") != String.Empty ? Eval("WebLink").ToString().Substring(0, Math.Min(Eval("WebLink").ToString().Length, 30)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("SurveyOwnerID")%>' UniqueKey="CRMSurveyOwner_lvCRMSurveyOwner_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMSurvey Owner?')"
                                        CommandArgument='<%#Eval("SurveyOwnerID")%>' UniqueKey="CRMSurveyOwner_lvCRMSurveyOwner_Edit_key"/>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypSurveyReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                        CommandName="SurveyReport" CommandArgument='<%#Eval("SurveyOwnerID")%>' UniqueKey="CRMServey_lvCRMServey_SurveyReport_key"></asp:HyperLink>
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
                <asp:ObjectDataSource ID="odsCRMSurveyOwner" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMSurveyOwner_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMSurveyOwner_Selecting">
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
