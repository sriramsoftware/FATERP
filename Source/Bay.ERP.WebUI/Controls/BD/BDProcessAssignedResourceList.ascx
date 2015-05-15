<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-May-2013, 10:40:06
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProcessAssignedResourceList.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProcessAssignedResourceListControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
      
       
        <div>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
            <div class="listContentTitle">
                Process Assigned Resource List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvBDProcessAssignedResource" runat="server" DataSourceID="odsBDProcessAssignedResource" OnItemCommand="lvBDProcessAssignedResource_ItemCommand" OnItemDataBound="lvBDProcessAssignedResource_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi">
                                        Process Category
                                    </td>
                                    <td class="hi">
                                        Title
                                    </td>
                                    <td class="hi">
                                        Purposes
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Start Date
                                    </td>
                                    <td class="hi">
                                        Create Date
                                    </td>
                                    <td class="hi">
                                        Create By Employee
                                    </td>
                                    <td class="hi">
                                        Approval Status
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
                                 <td class="i">
                                    <%# Eval("ProcessCategoryName")%>
                                </td>
                                <td class="i">
                                  <asp:HyperLink ID="hypTitle" runat="server" Text='<%# Eval("Title")%>' CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("Purposes")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProcessAssignedResourceStatus")%>
                                     <br />
                                     <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ProcessAssignedResourceID")%>' UniqueKey="BDProcessAssignedResource_lvBDProcessAssignedResource_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Process Assigned Resource?')"
                                        CommandArgument='<%#Eval("ProcessAssignedResourceID")%>' UniqueKey="BDProcessAssignedResource_lvBDProcessAssignedResource_Edit_key"/>
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
                                    <%# Eval("ProcessCategoryName")%>
                                </td>
                                <td class="i">
                                  <asp:HyperLink ID="hypTitle" runat="server" Text='<%# Eval("Title")%>' CssClass="CommonLink"
                                            ToolTip="Please Click Here To See The Overview!"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <%# Eval("Purposes")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("StartDate") != null ? ((DateTime)Eval("StartDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("MemberFullName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ProcessAssignedResourceStatus")%>
                                     <br />
                                     <asp:HyperLink ID="lnkShowApprovalStatus" runat="server" Text="Approval Status" />
                                </td>
                                <td class="i" style="display:none;">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("ProcessAssignedResourceID")%>' UniqueKey="BDProcessAssignedResource_lvBDProcessAssignedResource_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Process Assigned Resource?')"
                                        CommandArgument='<%#Eval("ProcessAssignedResourceID")%>' UniqueKey="BDProcessAssignedResource_lvBDProcessAssignedResource_Edit_key"/>
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
                <asp:ObjectDataSource ID="odsBDProcessAssignedResource" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.BDProcessAssignedResource_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsBDProcessAssignedResource_Selecting">
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
