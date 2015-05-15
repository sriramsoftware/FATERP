<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 24-Oct-2013, 12:51:37
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMSurveyOwnerContactPerson.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMSurveyOwnerContactPersonControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Name&nbsp;:
                </div>
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtName">
                        Enter Name</label>
                    <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CRMSurveyOwnerContactPersonEntity" Width="230" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                        ErrorMessage="Please Enter Name" ValidationGroup="CRMSurveyOwnerContactPersonEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Designation&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtDesignation" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CRMSurveyOwnerContactPersonEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Phone&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtPhone" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CRMSurveyOwnerContactPersonEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone"
                        Display="Dynamic" EnableViewState="True" ValidationGroup="CRMSurveyOwnerContactPersonEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Mobile No&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtMobileNo" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CRMSurveyOwnerContactPersonEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Fax&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtFax" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CRMSurveyOwnerContactPersonEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revFax" runat="server" ControlToValidate="txtFax"
                        Display="Dynamic" EnableViewState="True" ValidationGroup="CRMSurveyOwnerContactPersonEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Email&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtEmail" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CRMSurveyOwnerContactPersonEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revEmail" runat="server" ControlToValidate="txtEmail"
                        Display="Dynamic" EnableViewState="True" ValidationGroup="CRMSurveyOwnerContactPersonEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Web Link&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox ID="txtWebLink" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="CRMSurveyOwnerContactPersonEntity" Width="230" />
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RegularExpressionValidator ID="revWebLink" runat="server" ControlToValidate="txtWebLink"
                        Display="Dynamic" EnableViewState="True" ValidationGroup="CRMSurveyOwnerContactPersonEntity"></asp:RegularExpressionValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Remarks&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                        ID="txtRemarks" runat="server" ValidationGroup="CRMSurveyOwnerContactPersonEntity" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="CRMSurveyOwnerContactPersonEntity"
                        OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="CRMSurveyOwnerContactPersonControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" UniqueKey="CRMSurveyOwnerContactPersonControl_AddNew_key" />
                    <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                        UniqueKey="CRMSurveyOwnerContactPersonControl_Clear_key" />
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Survey Owner Contact Person List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMSurveyOwnerContactPerson" runat="server" DataSourceID="odsCRMSurveyOwnerContactPerson"
                        OnItemCommand="lvCRMSurveyOwnerContactPerson_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Survey Owner
                                    </td>
                                    <td class="hi">
                                        Name
                                    </td>
                                    <td class="hi">
                                        Designation
                                    </td>
                                    <td class="hi">
                                        Phone
                                    </td>
                                    <td class="hi">
                                        Mobile No
                                    </td>
                                    <td class="hi">
                                        Fax
                                    </td>
                                    <td class="hi">
                                        Email
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Web Link
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
                                <td class="i" style="display:none;">
                                    <%# Eval("SurveyOwnerID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Name")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Designation")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Fax")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("WebLink")%>' ID="a"><%# Eval("WebLink") != String.Empty ? Eval("WebLink").ToString().Substring(0, Math.Min(Eval("WebLink").ToString().Length, 50)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("Remarks")%>' ID="Label1"><%# Eval("Remarks") != String.Empty ? Eval("Remarks").ToString().Substring(0, Math.Min(Eval("Remarks").ToString().Length, 10)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SurveyOwnerContactPersonID")%>'
                                        UniqueKey="CRMSurveyOwnerContactPerson_lvCRMSurveyOwnerContactPerson_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMSurvey Owner Contact Person?')"
                                        CommandArgument='<%#Eval("SurveyOwnerContactPersonID")%>' UniqueKey="CRMSurveyOwnerContactPerson_lvCRMSurveyOwnerContactPerson_Edit_key" />
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
                                <td class="i" style="display:none;">
                                    <%# Eval("SurveyOwnerID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Name")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Designation")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Phone")%>
                                </td>
                                <td class="i">
                                    <%# Eval("MobileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Fax")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Email")%>
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("WebLink")%>' ID="a"><%# Eval("WebLink") != String.Empty ? Eval("WebLink").ToString().Substring(0, Math.Min(Eval("WebLink").ToString().Length, 50)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("Remarks")%>' ID="Label1"><%# Eval("Remarks") != String.Empty ? Eval("Remarks").ToString().Substring(0, Math.Min(Eval("Remarks").ToString().Length, 10)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("SurveyOwnerContactPersonID")%>'
                                        UniqueKey="CRMSurveyOwnerContactPerson_lvCRMSurveyOwnerContactPerson_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMSurvey Owner Contact Person?')"
                                        CommandArgument='<%#Eval("SurveyOwnerContactPersonID")%>' UniqueKey="CRMSurveyOwnerContactPerson_lvCRMSurveyOwnerContactPerson_Edit_key" />
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
                <asp:ObjectDataSource ID="odsCRMSurveyOwnerContactPerson" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMSurveyOwnerContactPersonDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMSurveyOwnerContactPerson_Selecting">
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
