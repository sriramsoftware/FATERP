<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 11-Apr-2013, 01:28:07
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMAgreementList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMAgreementListControl" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="HTMLEditor" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
         <div class="TableRow" style="width: 100%; padding-left:480px;">
            <div class="TableFormLeble" style="text-align: right;">
               Filter Text&nbsp;:
            </div>
            <div class="TableFormContent waterMarkContainer">
             <label class="watermarkLabel" for="txtSearchText">
                            Type Agre. Type# Project, Floor</label>
                <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox" Width="230" /><span><asp:CheckBox ID="chbxFilter"
                        runat="server" AutoPostBack="true" OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
            </div>
            <div class="TableFormValidatorContent">
            </div>
        </div>
         <div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCRMAgreement" runat="server" DataSourceID="odsCRMAgreement" OnItemDataBound="lvCRMAgreement_ItemDataBound" OnItemCommand="lvCRMAgreement_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width:150px;">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByAgreementType"
                                        CommandName="Sort" Text="Agreement Type" CommandArgument="CRMMDAgreementType.Name" />
                                        
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByBuyerBasicInfo"
                                        CommandName="Sort" Text="Buyer Basic Info" CommandArgument="CRMBuyerBasicInfo.ContactFullName" />
                                        
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByProject"
                                        CommandName="Sort" Text="Project" CommandArgument="BDProject.ProjectName" />
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByFloorUnit"
                                        CommandName="Sort" Text="Floor Unit" CommandArgument="BDProjectFloorUnit.ProjectFloorUnitName" />
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Text
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByAgreementDate"
                                        CommandName="Sort" Text="Agreement Date" CommandArgument="CRMAgreement.AgreementDate" />
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortBySignDate"
                                        CommandName="Sort" Text="Sign Date" CommandArgument="CRMAgreement.SignDate" />
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByExecuteDate"
                                        CommandName="Sort" Text="Execute Date" CommandArgument="CRMAgreement.ExecuteDate" />
                                    </td>                                   
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Created By Employee
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByCreateDate"
                                        CommandName="Sort" Text="Create Date" CommandArgument="CRMAgreement.CreateDate" />
                                    </td>
                                    <td class="hi">
                                    <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByApprovalStatus"
                                        CommandName="Sort" Text="Approval Status" CommandArgument="CRMMDAgreementApprovalStatus.Name" />                                        
                                    </td>
                                    <td class="hi">
                                        Link
                                    </td>
                                    <td class="his">
                                        EDIT
                                    </td>
                                    <td class="his">
                                        DELETE
                                    </td>
                                     <td class="rp"  style="width: 120px;">
                                    Approval Status
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
                                    <%# Eval("CRMMDAgreementTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CRMBuyerBasicInfoContactFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectFloorUnitProjectFloorUnitName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Text")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementDate") != null ? ((DateTime)Eval("AgreementDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SignDate") != null ? ((DateTime)Eval("SignDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ExecuteDate") != null ? ((DateTime)Eval("ExecuteDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByMemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CRMMDAgreementApprovalStatusName")%>
                                </td>
                                 <td class="i">
                                <asp:HyperLink ID="hypAgreementReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Report" CommandName="RequisitionReport" CommandArgument='<%#Eval("AgreementID")%>'></asp:HyperLink>
                                    <br />
                                    <asp:HyperLink ID="hypAgreementVariableMap" runat="server" CssClass="CommonButtonLink"
                                    Text="Agreement Variable" CommandName="AgreementVariableMapReport" CommandArgument='<%#Eval("AgreementID")%>'></asp:HyperLink>
                                     <br />
                                    <asp:HyperLink ID="hypAgreementSpec" runat="server" CssClass="CommonButtonLink" Visible="false"
                                    Text="Agreement Spec" CommandName="AgreementSpec" CommandArgument='<%#Eval("AgreementID")%>'></asp:HyperLink>
                            </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("AgreementID")%>'
                                        UniqueKey="CRMAgreement_lvCRMAgreement_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMAgreement?')"
                                        CommandArgument='<%#Eval("AgreementID")%>' UniqueKey="CRMAgreement_lvCRMAgreement_Edit_key" />
                                </td>
                                 <td class="i">
                                <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
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
                                    <%# Eval("CRMMDAgreementTypeName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CRMBuyerBasicInfoContactFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectProjectName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("BDProjectFloorUnitProjectFloorUnitName")%>
                                </td>
                                <td class="i" style="display:none;">
                                    <%# Eval("Text")%>
                                </td>
                                <td class="i">
                                    <%# Eval("AgreementDate") != null ? ((DateTime)Eval("AgreementDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("SignDate") != null ? ((DateTime)Eval("SignDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("ExecuteDate") != null ? ((DateTime)Eval("ExecuteDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreatedByMemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                              
                                <td class="i">
                                    <%# Eval("CRMMDAgreementApprovalStatusName")%>
                                </td>
                                 <td class="i">
                                <asp:HyperLink ID="hypAgreementReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Report" CommandName="RequisitionReport" CommandArgument='<%#Eval("AgreementID")%>'></asp:HyperLink>
                                    <br />
                                    <asp:HyperLink ID="hypAgreementVariableMap" runat="server" CssClass="CommonButtonLink"
                                    Text="Agreement Variable" CommandName="AgreementVariableMapReport" CommandArgument='<%#Eval("AgreementID")%>'></asp:HyperLink>
                                       <br />
                                    <asp:HyperLink ID="hypAgreementSpec" runat="server" CssClass="CommonButtonLink" Visible="false"
                                    Text="Agreement Spec" CommandName="AgreementSpec" CommandArgument='<%#Eval("AgreementID")%>'></asp:HyperLink>
                            </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("AgreementID")%>'
                                        UniqueKey="CRMAgreement_lvCRMAgreement_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C RMAgreement?')"
                                        CommandArgument='<%#Eval("AgreementID")%>' UniqueKey="CRMAgreement_lvCRMAgreement_Edit_key" />
                                </td>
                                 <td class="i">
                                <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
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
                <asp:ObjectDataSource ID="odsCRMAgreement" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CRMAgreement_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCRMAgreement_Selecting">
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
