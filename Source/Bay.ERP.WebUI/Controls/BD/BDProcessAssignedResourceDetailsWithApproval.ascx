<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 26-May-2013, 02:32:38
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProcessAssignedResourceDetailsWithApproval.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProcessAssignedResourceDetailsWithApprovalControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="display: none;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Select Database&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlResourceCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            AutoPostBack="true" OnSelectedIndexChanged="ddlResourceCategoryID_SelectedIndexChanged"
                            runat="server" ValidationGroup="BDProcessAssignedResourceMapEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvResourceCategoryID" runat="server" ControlToValidate="ddlResourceCategoryID"
                            ErrorMessage="Please Select Resource Category" ValidationGroup="BDProcessAssignedResourceMapEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMContactList" runat="server" DataSourceID="odsCRMContactList_Custom"
                        OnItemDataBound="lvCRMContactList_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width: 170px;">
                                       Name
                                    </td>
                                    <td class="hi" style="width: 90px;">
                                        Designation
                                    </td>
                                    <td class="hi">
                                        Company
                                    </td>
                                    <td class="hi">
                                        Mobile No
                                    </td>
                                    <td class="hi">
                                        Email
                                    </td>
                                    <td class="hi">
                                        Address Line1
                                    </td>
                                    <td class="hi">
                                        Address Line2
                                    </td>
                                    <td class="hi">
                                        Resource Type
                                    </td>
                                    <td class="hi">
                                        DOB
                                    </td>
                                    <td class="hi">
                                        Select
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
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblResourceIDLV" runat="server" Text='<%# Eval("ResourceID")%>'></asp:Label>
                                    <asp:Label ID="lblResourceCategoryIDLV" runat="server" Text='<%# Eval("ResourceCategoryID")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceNameLV" runat="server" Text='<%# Eval("ResourceName")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceDesignationLV" runat="server" Text='<%# Eval("ResourceDesignation")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceCompanyLV" runat="server" Text='<%# Eval("ResourceCompany")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceMobileNoLV" runat="server" Text='<%# Eval("ResourceMobileNo")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceEmailLV" runat="server" Text='<%# Eval("ResourceEmail")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblAddressLine1LV" runat="server" Text='<%# Eval("AddressLine1")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblAddressLine2LV" runat="server" Text='<%# Eval("AddressLine2")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceTypeIDLV" runat="server" Text='<%# Eval("ResourceTypeID")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceDOBLV" runat="server" Text='<%# Eval("ResourceDOB") != null ? ((DateTime)Eval("ResourceDOB")).ToString("dd-MM-yyyy") : ""%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:CheckBox ID="chkSelectResourceLV" runat="server" />
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
                                <td class="i" style="display: none;">
                                    <asp:Label ID="lblResourceIDLV" runat="server" Text='<%# Eval("ResourceID")%>'></asp:Label>
                                    <asp:Label ID="lblResourceCategoryIDLV" runat="server" Text='<%# Eval("ResourceCategoryID")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceNameLV" runat="server" Text='<%# Eval("ResourceName")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceDesignationLV" runat="server" Text='<%# Eval("ResourceDesignation")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceCompanyLV" runat="server" Text='<%# Eval("ResourceCompany")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceMobileNoLV" runat="server" Text='<%# Eval("ResourceMobileNo")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceEmailLV" runat="server" Text='<%# Eval("ResourceEmail")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblAddressLine1LV" runat="server" Text='<%# Eval("AddressLine1")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblAddressLine2LV" runat="server" Text='<%# Eval("AddressLine2")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceTypeIDLV" runat="server" Text='<%# Eval("ResourceTypeID")%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:Label ID="lblResourceDOBLV" runat="server" Text='<%# Eval("ResourceDOB") != null ? ((DateTime)Eval("ResourceDOB")).ToString("dd-MM-yyyy") : ""%>'></asp:Label>
                                </td>
                                <td class="i">
                                    <asp:CheckBox ID="chkSelectResourceLV" runat="server" />
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
                <asp:ObjectDataSource ID="odsCRMContactList_Custom" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMContactList_CustomDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMContactList_Custom_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                <asp:Button ID="btnAddToList" runat="server" OnClick="btnAddToList_Click" Text="Add To List" />
            </div>
            <div class="listContentTitle">
                Process Assigned Resource Map List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvBDProcessAssignedResourceMap" runat="server" DataSourceID="odsBDProcessAssignedResourceMap"
                        InsertItemPosition="LastItem" OnItemCommand="lvBDProcessAssignedResourceMap_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                       Name
                                    </td>
                                    <td class="hi">
                                        Designation
                                    </td>
                                    <td class="hi">
                                        Company
                                    </td>
                                    <td class="hi">
                                        Mobile No
                                    </td>
                                    <td class="hi">
                                        Email
                                    </td>
                                    <td class="hi">
                                        Address Line1
                                    </td>
                                    <td class="hi">
                                        Address Line2
                                    </td>
                                    <td class="hi" style="display: none;">
                                        Resource Type
                                    </td>
                                    <td class="hi">
                                        Resource DOB
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="his">
                                        Update
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
                                <td class="i" style="display: none;">
                                    <%# Eval("ProcessAssignedResourceID")%>
                                    <%# Eval("ResourceCategoryID")%>
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceNameLV" runat="server" Text='<%# Eval("ResourceName")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceDesignationLV" runat="server" Text='<%# Eval("ResourceDesignation")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceCompanyLV" runat="server" Text='<%# Eval("ResourceCompany")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceMobileNoLV" runat="server" Text='<%# Eval("ResourceMobileNo")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceEmailLV" runat="server" Text='<%# Eval("ResourceEmail")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAddressLine1LV" runat="server" Text='<%# Eval("AddressLine1")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAddressLine2LV" runat="server" Text='<%# Eval("AddressLine2")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceDOBLV" runat="server" Text='<%# Eval("ResourceDOB") != null ? ((DateTime)Eval("ResourceDOB")).ToString("dd-MM-yyyy") : ""%>'
                                        CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="revRequiredDate" runat="server" ControlToValidate="txtResourceDOBLV"
                                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                        ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtRemarksLV" runat="server" Text='<%# Eval("Remarks")%>' CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'
                                        UniqueKey="BDProcessAssignedResourceMap_lvBDProcessAssignedResourceMap_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkUpdate" runat="server" CssClass="CommonButtonLink"
                                        Text="Update" CommandName="UpdateItem" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'/>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Process Assigned Resource Map?')"
                                        CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>' UniqueKey="BDProcessAssignedResourceMap_lvBDProcessAssignedResourceMap_Edit_key" />
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
                                <td class="i" style="display: none;">
                                    <%# Eval("ProcessAssignedResourceID")%>
                                    <%# Eval("ResourceCategoryID")%>
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceNameLV" runat="server" Text='<%# Eval("ResourceName")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceDesignationLV" runat="server" Text='<%# Eval("ResourceDesignation")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceCompanyLV" runat="server" Text='<%# Eval("ResourceCompany")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceMobileNoLV" runat="server" Text='<%# Eval("ResourceMobileNo")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceEmailLV" runat="server" Text='<%# Eval("ResourceEmail")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAddressLine1LV" runat="server" Text='<%# Eval("AddressLine1")%>' 
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAddressLine2LV" runat="server" Text='<%# Eval("AddressLine2")%>'
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceDOBLV" runat="server" Text='<%# Eval("ResourceDOB") != null ? ((DateTime)Eval("ResourceDOB")).ToString("dd-MM-yyyy") : ""%>'
                                        CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="revRequiredDate" runat="server" ControlToValidate="txtResourceDOBLV"
                                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$" 
                                        ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtRemarksLV" runat="server" Text='<%# Eval("Remarks")%>' CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i" style="display: none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'
                                        UniqueKey="BDProcessAssignedResourceMap_lvBDProcessAssignedResourceMap_Edit_key" />
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkUpdate" runat="server" CssClass="CommonButtonLink"
                                        Text="Update" CommandName="UpdateItem" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'/>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Process Assigned Resource Map?')"
                                        CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>' UniqueKey="BDProcessAssignedResourceMap_lvBDProcessAssignedResourceMap_Edit_key" />
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </AlternatingItemTemplate>
                        <InsertItemTemplate>
                            <tr class="ar">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceNameLV" runat="server" CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceDesignationLV" runat="server" CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceCompanyLV" runat="server" CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceMobileNoLV" runat="server" CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceEmailLV" runat="server" CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                 <td class="i">
                                    <asp:TextBox ID="txtAddressLine1LV" runat="server"
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtAddressLine2LV" runat="server"
                                        CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtResourceDOBLV" runat="server" CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                    <asp:RegularExpressionValidator ID="revRequiredDate" runat="server" ControlToValidate="txtResourceDOBLV"
                                        Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                        ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                </td>
                                <td class="i">
                                    <asp:TextBox ID="txtRemarksLV" runat="server" CssClass="ktiTextBoxListview"></asp:TextBox>
                                </td>
                                <td class="i">
                                    <asp:LinkButton ID="lnkBtnInsert" runat="server" CssClass="CommonButtonLink" ValidationGroup="CMMeasurementBookDetailLVEntity"
                                        Text="Insert" CommandName="InsertItem" UniqueKey="CMMeasurementBookDetail_lvCMMeasurementBookDetail_Insert_key" />
                                </td>
                                <td class="i">
                                </td>
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="rpb">
                                    &nbsp;
                                </td>
                            </tr>
                        </InsertItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                </div>
                <asp:ObjectDataSource ID="odsBDProcessAssignedResourceMap" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.BDProcessAssignedResourceMapDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsBDProcessAssignedResourceMap_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
            <br />
            <br />
            <div style="padding-left: 250px;">
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Process Category&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProcessCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="BDProcessAssignedResourceEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvProcessCategoryID" runat="server" ControlToValidate="ddlProcessCategoryID"
                            ErrorMessage="Please Select Process Category" ValidationGroup="BDProcessAssignedResourceEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Title&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtTitle">
                            Enter Title</label>
                        <asp:TextBox ID="txtTitle" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                            ValidationGroup="BDProcessAssignedResourceEntity" Width="230" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle"
                            ErrorMessage="Please Enter Title" ValidationGroup="BDProcessAssignedResourceEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Purposes&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtPurposes" runat="server" ValidationGroup="BDProcessAssignedResourceEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Remarks&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="230" ClientIDMode="Static"
                            ID="txtRemarks" runat="server" ValidationGroup="BDProcessAssignedResourceEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Start Date&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                            ValidationGroup="BDProcessAssignedResourceEntity" Width="230" />
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RegularExpressionValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate"
                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                            ValidationGroup="BDProcessAssignedResourceEntity"></asp:RegularExpressionValidator>
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="BDProcessAssignedResourceEntity"
                            OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="BDProcessAssignedResourceControl_Submit_key" />
                    </div>
                </div>
            </div>
            <br />
            <br />
            <br />
            <div style="width: 100%;">
                <div style="margin-left: auto; margin-right: auto; width: 550px; border: 1px Solid Gray;
                    padding: 10px; padding-left: 50px;">
                    <div style="width: 550px; text-align: center;">
                        <h3>
                            Approval Process Panel</h3>
                    </div>
                    <br />
                    <div style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Action
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:DropDownList ID="ddlAction" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                                Width="236">
                            </asp:DropDownList>
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trRemarks" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Remarks
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                                ID="TextBox1" runat="server" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trRejectTo" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Reject To
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:DropDownList ID="ddlRejectTo" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                                Width="236">
                            </asp:DropDownList>
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trForwardTo" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Forward To
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:DropDownList ID="ddlForwardTo" runat="server" ClientIDMode="Static" CssClass="ktiSelect"
                                Width="236">
                            </asp:DropDownList>
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trForwardRemarks" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Forward Remarks
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                                ID="txtForwardRemarks" runat="server" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trComment" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            Comment
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                            :</div>
                        <div style="width: 480px; float: left;">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="384" ClientIDMode="Static"
                                ID="txtComment" runat="server" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trbtnApprove" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            &nbsp;
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                        </div>
                        <div style="width: 480px; float: left; padding-left: 10px;">
                            <kti:SecureButton ID="btnApprove" ValidationGroup="None" runat="server" Text="Approve"
                                UniqueKey="BDProcessAssignedResourceDetailsWithApprovalControl_Approve_key" OnClick="btnApprove_Click" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trbtnReject" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            &nbsp;
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                        </div>
                        <div style="width: 480px; float: left; padding-left: 10px;">
                            <kti:SecureButton ID="btnReject" ValidationGroup="None" runat="server" Text="Reject"
                                UniqueKey="BDProcessAssignedResourceDetailsWithApprovalControl_Reject_key" OnClick="btnReject_Click" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trbtnForward" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            &nbsp;
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                        </div>
                        <div style="width: 480px; float: left; padding-left: 10px;">
                            <kti:SecureButton ID="btnForward" ValidationGroup="None" runat="server" Text="Forward"
                                UniqueKey="BDProcessAssignedResourceDetailsWithApprovalControl_Forward_key" OnClick="btnForward_Click" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                    <div id="trbtnSubmitComment" style="width: 650px;">
                        <div style="width: 120px; float: left; font-weight: bold;">
                            &nbsp;
                        </div>
                        <div style="width: 10px; float: left; font-weight: bold;">
                        </div>
                        <div style="width: 480px; float: left; padding-left: 10px;">
                            <kti:SecureButton ID="btnSubmitComment" ValidationGroup="None" runat="server" Text="Submit Comment"
                                UniqueKey="BDProcessAssignedResourceDetailsWithApprovalControl_SubmitComment_key"
                                OnClick="btnSubmitComment_Click" />
                        </div>
                        <div style="clear: both;">
                        </div>
                        <br />
                    </div>
                </div>
                <div style="width: 550px;">
                    <div style="width: 510px; margin: 10px; padding-right: 10px; padding-bottom:10px; padding-right:10px; padding-left:236px;">
                        <div style="padding-bottom: 15px;">
                            <h3 style="color: #4B4B4B;">
                                All Remarks By Panel Members:</h3>
                        </div>
                        <div>
                            <asp:ListView ID="lvAPMemberFeedbackRemarks" runat="server" OnItemDataBound="lvAPMemberFeedbackRemarks_ItemDataBound">
                                <LayoutTemplate>
                                    <div runat="server" id="itemPlaceholder">
                                    </div>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <div style="padding-bottom: 20px;">
                                        <div style="padding-bottom: 3px;">
                                            <table cellpadding="0" cellspacing="0" width="100%">
                                                <tr>
                                                    <td align="left">
                                                        <b>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.APPROVED ? ("<span style='color: green;'>" + Eval("APFeedbackName") + "</span>") : ("") %>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.REJECTED ? ("<span style='color: Red;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.FORWARDED ? ("<span style='color: Blue;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                            <%# (Int64)Eval("APFeedbackID") == MasterDataConstants.APFeedback.FORWARD_RESPONSE_RECEIVED ? ("<span style='color: Blue;'>" + Eval("APFeedbackName") + "</span>") : ("")%>
                                                        </b><span style='color: gray;'><i>by <b>
                                                            <%# Eval("MemberFullName")%></b></i></span>
                                                    </td>
                                                    <td align="right">
                                                        on <b>
                                                            <%# Eval("RemarksDateTime") !=  null ? ((DateTime)Eval("RemarksDateTime")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%></b>
                                                    </td>
                                                </tr>
                                            </table>
                                        </div>
                                        <div style="border-top: 1px solid gray; height: 1px; width: 100%;">
                                        </div>
                                        <div style="text-align: justify; letter-spacing: 0px; word-spacing: 0px; line-height: 18px;
                                            color: #4B4B4B; font-size: 12px; font-family: 'Verdana'; padding-top: 3px;">
                                            <%# Eval("Remarks")%>
                                        </div>
                                        <div id="forwardInfoDiv" runat="server">
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:ListView>
                        </div>
                    </div>
                </div>
                <br />
                <br />
            </div>
        </div>
        <script type="text/javascript">
            $(function () {
                function manageActionOptions(selectedAction) {
                    if (selectedAction == 1) {
                        $('#trRemarks').show();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').hide();
                        $('#trbtnApprove').show();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 2) {
                        $('#trRemarks').show();
                        $('#trRejectTo').show();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').hide();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').show();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 3) {
                        $('#trRemarks').show();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').show();
                        $('#trForwardRemarks').show();
                        $('#trComment').hide();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').show();
                        $('#trbtnSubmitComment').hide();
                    }
                    else if (selectedAction == 4) {
                        $('#trRemarks').hide();
                        $('#trRejectTo').hide();
                        $('#trForwardTo').hide();
                        $('#trForwardRemarks').hide();
                        $('#trComment').show();
                        $('#trbtnApprove').hide();
                        $('#trbtnReject').hide();
                        $('#trbtnForward').hide();
                        $('#trbtnSubmitComment').show();
                    }
                }

                function CurrentPageLoad() {

                    $('#ddlAction').change(function () {

                        var selectedAction = $('#ddlAction').val();
                        manageActionOptions(selectedAction);
                    });

                    manageActionOptions($('#ddlAction').val());
                }

                CurrentPageLoad();

                var prm = Sys.WebForms.PageRequestManager.getInstance();
                prm.add_endRequest(function () {
                    $(function () {
                        CurrentPageLoad();
                    });
                });
            });
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
