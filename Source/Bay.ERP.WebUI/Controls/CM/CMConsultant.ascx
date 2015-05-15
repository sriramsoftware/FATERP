<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 08-Jan-2012, 04:47:08
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMConsultant.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMConsultantControl" %>
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
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Artist"></asp:Label>
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
                        First Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtFirstName">
                            Enter First Name</label>
                        <asp:TextBox ID="txtFirstName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMContractorEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvFirstName" runat="server" ControlToValidate="txtFirstName"
                            ErrorMessage="Please Enter First Name" ValidationGroup="CMContractorEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Middle Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtMiddleName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMContractorEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Surname&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtLastName">
                            Enter Last Name</label>
                        <asp:TextBox ID="txtLastName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMContractorEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvLastName" runat="server" ControlToValidate="txtLastName"
                            ErrorMessage="Please Enter Last Name" ValidationGroup="HRMemberEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display:none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Name&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtName">
                            Enter Name</label>
                        <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <%--<div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                            ErrorMessage="Please Enter Name" ValidationGroup="CMConsultantEntity" EnableViewState="True"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>--%>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Image Url&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:FileUpload ID="fuImageUrl" ClientIDMode="Static" runat="server" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Current Position&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtCurrentPosition" runat="server" ValidationGroup="CMConsultantEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Institute Name&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtInstitueName" runat="server" ValidationGroup="CMConsultantEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Email Address1&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmailAddress1" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmailAddress1" runat="server" ControlToValidate="txtEmailAddress1"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="CMConsultantEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Email Address2&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtEmailAddress2" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revEmailAddress2" runat="server" ControlToValidate="txtEmailAddress2"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="CMConsultantEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Contact No1&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtContactNo1" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Address&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtContactNo2" TextMode="MultiLine" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" Height="200" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Mobile&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtPhone" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revPhone" runat="server" ControlToValidate="txtPhone"
                            Display="Dynamic" EnableViewState="True" ValidationGroup="CMConsultantEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRemarks" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="CMConsultantEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100; display: none;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Is Removed&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsRemoved" runat="server" ClientIDMode="Static" ValidationGroup="CMConsultantEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="CMConsultantEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="CMConsultantControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="CMConsultantControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="CMConsultantControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            <div class="listContentTitle">
                Artist List
            </div>
            <div>
                <div class="lv-c" style="border:none;">
                    <asp:ListView ID="lvCMConsultant" runat="server" DataSourceID="odsCMConsultant" OnItemCommand="lvCMConsultant_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width:50px;">
                                        Outsource Category
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Surname
                                    </td>
                                    <td class="hi" style="width:150px;">
                                        Name
                                    </td>
                                    <td class="hi" style="width:45px;">
                                        Image Url
                                    </td>
                                    <td class="hi">
                                        Current Position
                                    </td>
                                    <td class="hi">
                                        Institue Name
                                    </td>
                                    <td class="hi" style="width:200px;">
                                        Email Address
                                    </td>
                                    <td class="hi" style="width:120px;">
                                        Contact No
                                    </td>
                                    <td class="hi">
                                        Address
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
                                    <%# Eval("OutsourceCategoryName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("LastName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FirstName")%>&nbsp; <%# Eval("MiddleName")%>
                                </td>
                                <td class="i">
                                    <asp:Image ID="imgImageUrl" ImageUrl='<%# Eval("ImageUrl")%>' runat="server" Height="45" Width="45" />
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("CurrentPosition")%>' ID="Label1"><%# Eval("CurrentPosition") != String.Empty ? Eval("CurrentPosition").ToString().Substring(0, Math.Min(Eval("CurrentPosition").ToString().Length, 15)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    <%# Eval("InstitueName")%>
                                </td>
                                <td class="i">
                                    <b>Email 1: </b><%# Eval("EmailAddress1")%>
                                <br />
                                    <b>Email 2: </b><%# Eval("EmailAddress2")%>
                                </td>
                                <td class="i">
                                    <b>No 1: </b><%# Eval("ContactNo1")%>
                                <br />
                                    <b>Phone: </b><%# Eval("Phone")%>
                                </td>
                                 <td class="i">
                                <%# Eval("ContactNo2")%>
                                </td>
                                <br />
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("Remarks")%>' ID="a"><%# Eval("Remarks") != String.Empty ? Eval("Remarks").ToString().Substring(0, Math.Min(Eval("Remarks").ToString().Length, 10)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ConsultantID")%>'
                                        UniqueKey="CMConsultant_lvCMConsultant_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MConsultant?')"
                                        CommandArgument='<%#Eval("ConsultantID")%>' UniqueKey="CMConsultant_lvCMConsultant_Edit_key" />
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
                                    <%# Eval("OutsourceCategoryName")%>
                                </td>
                                 <td class="i">
                                    <%# Eval("LastName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("FirstName")%>&nbsp; <%# Eval("MiddleName")%>
                                </td>
                                <td class="i">
                                    <asp:Image ID="imgImageUrl" ImageUrl='<%# Eval("ImageUrl")%>' runat="server" Height="45" Width="45" />
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("CurrentPosition")%>' ID="Label1"><%# Eval("CurrentPosition") != String.Empty ? Eval("CurrentPosition").ToString().Substring(0, Math.Min(Eval("CurrentPosition").ToString().Length, 15)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    <%# Eval("InstitueName")%>
                                </td>
                                 <td class="i">
                                    <b>Email 1: </b><%# Eval("EmailAddress1")%>
                                <br />
                                    <b>Email 2: </b><%# Eval("EmailAddress2")%>
                                </td>
                                <td class="i">
                                    <b>No 1: </b><%# Eval("ContactNo1")%>
                                <br />
                                    <b>Phone: </b><%# Eval("Phone")%>
                                </td>
                                 <td class="i">
                                <%# Eval("ContactNo2")%>
                                </td>
                                <td class="i">
                                    <asp:Label runat="server" ToolTip='<%# Eval("Remarks")%>' ID="a"><%# Eval("Remarks") != String.Empty ? Eval("Remarks").ToString().Substring(0, Math.Min(Eval("Remarks").ToString().Length, 10)) : ""%></asp:Label>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ConsultantID")%>'
                                        UniqueKey="CMConsultant_lvCMConsultant_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MConsultant?')"
                                        CommandArgument='<%#Eval("ConsultantID")%>' UniqueKey="CMConsultant_lvCMConsultant_Edit_key" />
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
                <asp:ObjectDataSource ID="odsCMConsultant" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMConsultant_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMConsultant_Selecting">
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
