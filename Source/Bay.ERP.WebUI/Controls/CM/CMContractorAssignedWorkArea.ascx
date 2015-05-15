<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 04-Jun-2012, 10:26:50
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMContractorAssignedWorkArea.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMContractorAssignedWorkAreaControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Contractor Assigned Work Area"></asp:Label>
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
                        <asp:DropDownList ID="ddlProjectID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="CMContractorAssignedWorkAreaEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProjectID" runat="server" ControlToValidate="ddlProjectID"
                            ErrorMessage="Please Select Project" ValidationGroup="CMContractorAssignedWorkAreaEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Contractor&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlContractorID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMContractorAssignedWorkAreaEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvContractorID" runat="server" ControlToValidate="ddlContractorID"
                            ErrorMessage="Please Select Contractor" ValidationGroup="CMContractorAssignedWorkAreaEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Work Description&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtWorkDescription">
                            Enter Work Description</label>
                        <asp:TextBox ID="txtWorkDescription" ClientIDMode="Static" CssClass="ktiTextArea"
                            runat="server" TextMode="MultiLine" ValidationGroup="CMContractorAssignedWorkAreaEntity"
                            Width="390" Height="105" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvWorkDescription" runat="server" ControlToValidate="txtWorkDescription"
                            ErrorMessage="Please Enter Work Description" ValidationGroup="CMContractorAssignedWorkAreaEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Work Area Status&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlWorkAreaStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="CMContractorAssignedWorkAreaEntity" Width="236">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvWorkAreaStatusID" runat="server" ControlToValidate="ddlWorkAreaStatusID"
                            ErrorMessage="Please Select Work Area Status" ValidationGroup="CMContractorAssignedWorkAreaEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CMContractorAssignedWorkAreaEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CMContractorAssignedWorkAreaEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        End Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CMContractorAssignedWorkAreaEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEndDate" runat="server" ControlToValidate="txtEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CMContractorAssignedWorkAreaEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Actual Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtActualStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CMContractorAssignedWorkAreaEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revActualStartDate" runat="server" ControlToValidate="txtActualStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CMContractorAssignedWorkAreaEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Actual End Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtActualEndDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="CMContractorAssignedWorkAreaEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revActualEndDate" runat="server" ControlToValidate="txtActualEndDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="CMContractorAssignedWorkAreaEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRemarks" ClientIDMode="Static" CssClass="ktiTextArea" runat="server"
                            TextMode="MultiLine" ValidationGroup="CMContractorAssignedWorkAreaEntity" Width="390"
                            Height="105" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CMContractorAssignedWorkAreaEntity"
                            OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="CMContractorAssignedWorkAreaControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="CMContractorAssignedWorkAreaControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="CMContractorAssignedWorkAreaControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Contractor Assigned Work Area List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMContractorAssignedWorkArea" runat="server" DataSourceID="odsCMContractorAssignedWorkArea"
                        OnItemCommand="lvCMContractorAssignedWorkArea_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Contractor
                                    </td>
                                    <td class="hi">
                                        Project
                                    </td>
                                    <td class="hi">
                                        Work Description
                                    </td>
                                    <td class="hi">
                                        Work Area Status
                                    </td>
                                    <td class="hi">
                                        Start Date
                                    </td>
                                    <td class="hi">
                                        End Date
                                    </td>
                                    <td class="hi">
                                        Actual Start Date
                                    </td>
                                    <td class="hi">
                                        Actual End Date
                                    </td>
                                    <td class="hi">
                                        Remarks
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
                                    <%# Eval("ContractorName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkDescription")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkAreaStatusName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ContractorAssignedWorkAreaID")%>'
                                        UniqueKey="CMContractorAssignedWorkArea_lvCMContractorAssignedWorkArea_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Contractor Assigned Work Area?')"
                                        CommandArgument='<%#Eval("ContractorAssignedWorkAreaID")%>' UniqueKey="CMContractorAssignedWorkArea_lvCMContractorAssignedWorkArea_Delete_key" />
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
                                    <%# Eval("ContractorName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkDescription")%>
                                </td>
                                <td class="i">
                                    <%# Eval("WorkAreaStatusName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("EndDate") != null ? ((DateTime)Eval("EndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualStartDate") != null ? ((DateTime)Eval("ActualStartDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ActualEndDate") != null ? ((DateTime)Eval("ActualEndDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ContractorAssignedWorkAreaID")%>'
                                        UniqueKey="CMContractorAssignedWorkArea_lvCMContractorAssignedWorkArea_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Contractor Assigned Work Area?')"
                                        CommandArgument='<%#Eval("ContractorAssignedWorkAreaID")%>' UniqueKey="CMContractorAssignedWorkArea_lvCMContractorAssignedWorkArea_Delete_key" />
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
                <asp:ObjectDataSource ID="odsCMContractorAssignedWorkArea" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMContractorAssignedWorkArea_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMContractorAssignedWorkArea_Selecting">
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
