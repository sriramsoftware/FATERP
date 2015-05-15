<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 26-May-2013, 02:32:38
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProcessAssignedResource.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProcessAssignedResourceControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="width: 40%; float:left;">
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
            <div  style="width: 50%; float:right;">
                       <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>

            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Name</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                     Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged"
                        Text="Use Filter" /></span>
            </div>
            </div>

            <div class="TableFormValidatorContent" style="clear:both;">
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
                                    Type
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
                                <asp:Label ID="lblAddressLine1" runat="server" Text='<%# Eval("AddressLine1")%>'></asp:Label>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblAddressLine2" runat="server" Text='<%# Eval("AddressLine2")%>'></asp:Label>
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
                                <asp:Label ID="lblAddressLine1" runat="server" Text='<%# Eval("AddressLine1")%>'></asp:Label>
                            </td>
                            <td class="i">
                                <asp:Label ID="lblAddressLine2" runat="server" Text='<%# Eval("AddressLine2")%>'></asp:Label>
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
            <br />
            <br />
            <div style="padding-left: 300px;">
                <asp:Button ID="btnAddToList" runat="server" OnClick="btnAddToList_Click" Text="Add To List" />
            </div>
            <br />
            <div class="listContentTitle">
                Process Assigned Resource Map List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvBDProcessAssignedResourceMap" runat="server" DataSourceID="odsBDProcessAssignedResourceMap"
                        OnItemCommand="lvBDProcessAssignedResourceMap_ItemCommand">
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
                                        Address Line1
                                    </td>
                                    <td class="hi">
                                        Type
                                    </td>
                                    <td class="hi">
                                        DOB
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="his" style="display:none;">
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
                                <td class="i" style="display: none;">
                                    <%# Eval("ProcessAssignedResourceID")%>
                                    <%# Eval("ResourceCategoryID")%>
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceDesignation")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceCompany")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceMobileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceEmail")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AddressLine1")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AddressLine2")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceTypeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceDOB") != null ? ((DateTime)Eval("ResourceDOB")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'
                                        UniqueKey="BDProcessAssignedResourceMap_lvBDProcessAssignedResourceMap_Edit_key" />
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
                                    <%# Eval("ResourceName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceDesignation")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceCompany")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceMobileNo")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceEmail")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AddressLine1")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AddressLine2")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceTypeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ResourceDOB") != null ? ((DateTime)Eval("ResourceDOB")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'
                                        UniqueKey="BDProcessAssignedResourceMap_lvBDProcessAssignedResourceMap_Edit_key" />
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
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Approval Status&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlProcessAssignedResourceApprovalStatusID" CssClass="ktiSelect"
                        ClientIDMode="Static" Enabled="false" runat="server" ValidationGroup="BDProcessAssignedResourceEntity"
                        Width="234">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvProcessAssignedResourceApprovalStatusID" runat="server"
                        ControlToValidate="ddlProcessAssignedResourceApprovalStatusID" ErrorMessage="Please Select Process Assigned Resource Approval Status"
                        ValidationGroup="BDProcessAssignedResourceEntity" EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: right;">
                    Appr. Proc. Panel&nbsp;:
                </div>
                <div class="TableFormContent">
                    <asp:DropDownList ID="ddlAPPanelID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                        ValidationGroup="APPanelMemberEntity" Width="236">
                    </asp:DropDownList>
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvAPPanelID" runat="server" ControlToValidate="ddlAPPanelID"
                        ErrorMessage="Please Select Approval Process Panel" ValidationGroup="APPanelMemberEntity"
                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="text-align: center;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div class="TableFormContent">
                    <kti:SecureButton ID="btnSubmit" ValidationGroup="BDProcessAssignedResourceEntity"
                        OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="BDProcessAssignedResourceControl_Submit_key" />
                    <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                        Text="Add New" UniqueKey="BDProcessAssignedResourceControl_AddNew_key" />
                    <asp:Button ID="btnSubmitForApproval" OnClick="btnSubmitForApproval_Click" ValidationGroup="APPanelMemberEntity"
                        runat="server" Text="Submit For Approval" Visible="false" />
                </div>
            </div>
            <br />
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
