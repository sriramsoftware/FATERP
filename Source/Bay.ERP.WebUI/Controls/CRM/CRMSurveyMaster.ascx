<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 24-Oct-2013, 12:51:37
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMSurveyMaster.ascx.cs" Inherits="Bay.ERP.Web.UI.CRMSurveyMasterControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Survey Master"></asp:Label>
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
                        Title &nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtTitle">
                            Enter Title</label>
                        <asp:TextBox CssClass="ktiTextBox" Width="230" ClientIDMode="Static"
                            ID="txtTitle" runat="server" ValidationGroup="CRMSurveyMasterEntity" />
                            <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle"
                            ErrorMessage="Please Enter Title" ValidationGroup="CRMSurveyMasterEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtStartDate">
                            Enter Survey Start Date</label>
                        <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMSurveyMasterEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" ControlToValidate="txtStartDate"
                            ErrorMessage="Please Enter Survey Start Date" ValidationGroup="CRMSurveyMasterEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revSurveyStartDate" runat="server" ControlToValidate="txtStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMSurveyMasterEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>

                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Survey End Date&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtEndDate">
                            Enter Survey End Date</label>
                        <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CRMSurveyMasterEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" ControlToValidate="txtEndDate"
                            ErrorMessage="Please Enter Survey End Date" ValidationGroup="CRMSurveyMasterEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RegularExpressionValidator ID="revSurveyEndDate" runat="server" ControlToValidate="txtEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CRMSurveyMasterEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMSurveyMasterEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CRMSurveyMasterControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="CRMSurveyMasterControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="CRMSurveyMasterControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Survey List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMSurveyMaster" runat="server" DataSourceID="odsCRMSurveyMaster" OnItemCommand="lvCRMSurveyMaster_ItemCommand" OnItemDataBound="lvCRMServeyMaster_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Survey Title
                                    </td>
                                    <td class="hi">
                                        Start Date
                                    </td>
                                    <td class="hi">
                                        End Date
                                    </td>
                                    <td class="hi">
                                        Create Date
                                    </td>
                                    <td class="hi">
                                        Create By
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
                                <asp:HyperLink ID="hypTitle" runat="server" ClientIDMode="Static" Text='<%# Eval("Title")%>'
                                    ToolTip="Please Click Here To Edit The Template Items!" CssClass="CommonLink"></asp:HyperLink>
                                    </td>
                                <td class="i">
                                    <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                  <td class="i">
                                    <%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                 <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateByEmployeeID")%>
                                    </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SurveyMasterID")%>' UniqueKey="CRMSurvey_lvCRMSurvey_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMSurvey?')"
                                        CommandArgument='<%#Eval("SurveyMasterID")%>' UniqueKey="CRMSurvey_lvCRMSurvey_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypSurveyMasterReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                        CommandName="SurveyMasterReport" CommandArgument='<%#Eval("SurveyMasterID")%>' UniqueKey="CRMServeyMaster_lvCRMServeyMaster_SurveyMasterReport_key"></asp:HyperLink>
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
                                <asp:HyperLink ID="hypTitle" runat="server" ClientIDMode="Static" Text='<%# Eval("Title")%>'
                                    ToolTip="Please Click Here To Edit The Template Items!" CssClass="CommonLink"></asp:HyperLink>
                                    </td>
                                 <td class="i">
                                    <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                  <td class="i">
                                    <%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                 <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateByEmployeeID")%>
                                    </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SurveyMasterID")%>' UniqueKey="CRMSurvey_lvCRMSurvey_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMSurvey?')"
                                        CommandArgument='<%#Eval("SurveyMasterID")%>' UniqueKey="CRMSurvey_lvCRMSurvey_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypSurveyMasterReport" runat="server" CssClass="CommonButtonLink" Text="Report"
                                        CommandName="SurveyMasterReport" CommandArgument='<%#Eval("SurveyMasterID")%>' UniqueKey="CRMServeyMaster_lvCRMServeyMaster_SurveyMasterReport_key"></asp:HyperLink>
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
                <asp:ObjectDataSource ID="odsCRMSurveyMaster" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMSurveyMasterDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMSurveyMaster_Selecting">
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
