<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeDocument.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeDocumentControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
<Triggers>
        <asp:PostBackTrigger ControlID="btnSubmit" />
    </Triggers>
    <ContentTemplate>
        <div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:154px;">
                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypDocumentCategory" runat="server" Text="Document Category" NavigateUrl="~/MD/MDDocumentCategory.aspx"
                                Target="_blank"></asp:HyperLink>
                   :
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDocumentCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="HREmployeeDocumentEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDocumentCategoryID" runat="server" ControlToValidate="ddlDocumentCategoryID"
                            ErrorMessage="Please Select Document Category" ValidationGroup="HREmployeeDocumentEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>

                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:154px;">
                        Upload File&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:FileUpload ID="fuFileUploadUrl" ClientIDMode="Static" runat="server" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                </div>

                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right; width:154px;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtRemarks" CssClass="ktiTextArea" TextMode="MultiLine" ValidationGroup="HREmployeeDocumentEntity" ClientIDMode="Static" runat="server" Width="773" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                </div>

                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble" style="width:154px;">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="HREmployeeDocumentEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="HREmployeeDocumentControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click"
                            runat="server" Text="Add New" UniqueKey="HREmployeeDocumentControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click"
                            runat="server" Text="Clear" UniqueKey="HREmployeeDocumentControl_Clear_key" />
                    </div>
                </div>
                <br />
            <div class="listContentTitle">
                Employee Document List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeDocument" runat="server" DataSourceID="odsHREmployeeDocument" OnItemCommand="lvHREmployeeDocument_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Employee
                                    </td>
                                    <td class="hi">
                                        Document Category
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
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DocumentCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extension")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypOrginalFileName" runat="server" Text="File"
                                        NavigateUrl='<%# Eval("Path")%>' Target="_blank"></asp:HyperLink>
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
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeDocumentID")%>' UniqueKey="HREmployeeDocument_lvHREmployeeDocument_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Document?')"
                                        CommandArgument='<%#Eval("EmployeeDocumentID")%>' UniqueKey="HREmployeeDocument_lvHREmployeeDocument_Edit_key"/>
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
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("DocumentCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Extension")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypOrginalFileName" runat="server" Text="File"
                                        NavigateUrl='<%# Eval("Path")%>' Target="_blank"></asp:HyperLink>
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
                                        CommandName="EditItem" CommandArgument='<%#Eval("EmployeeDocumentID")%>' UniqueKey="HREmployeeDocument_lvHREmployeeDocument_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Employee Document?')"
                                        CommandArgument='<%#Eval("EmployeeDocumentID")%>' UniqueKey="HREmployeeDocument_lvHREmployeeDocument_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsHREmployeeDocument" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeDocumentDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeDocument_Selecting">
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
