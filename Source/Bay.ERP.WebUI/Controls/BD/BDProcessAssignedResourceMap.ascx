<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 26-May-2013, 02:32:38
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProcessAssignedResourceMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProcessAssignedResourceMapControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
             <asp:ListView ID="lvBDProcessAssignedResourceMap" runat="server" DataSourceID="odsBDProcessAssignedResourceMap" OnItemDataBound="lvBDProcessAssignedResourceMap_ItemDataBound"
                        OnItemCommand="lvBDProcessAssignedResourceMap_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Process Assigned Resource
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Resource Category
                                    </td>
                                    <td class="hi" style="display:none;">
                                        Reference
                                    </td>
                                    <td class="hi">
                                        Resource Name
                                    </td>
                                    <td class="hi">
                                        Resource Designation
                                    </td>
                                    <td class="hi">
                                        Resource Company
                                    </td>
                                    <td class="hi">
                                        Resource Mobile No
                                    </td>
                                    <td class="hi"  style="width:177px;">
                                        Resource Email
                                    </td>
                                    <td class="hi">
                                        Resource DOB
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        DELETE
                                    </td>
                                    <td class="his" style="width:100px;">
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
                                <td class="i" style="display:none;">
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
                                    <%# Eval("ResourceDOB") != null ? ((DateTime)Eval("ResourceDOB")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Process Assigned Resource Map?')"
                                        CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>' UniqueKey="BDProcessAssignedResourceMap_lvBDProcessAssignedResourceMap_Edit_key" />
                                </td>
                                <td class="i">
                                <asp:HyperLink ID="hypEnvelopReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Small Envelop" CommandName="EnvelopReport" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypLargeEvelopReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Large Envelop" CommandName="LargeEvelopReport" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypLegalEnvelopReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Legal Envelop" CommandName="LegalEnvelopReport" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypTransmissionSheet" runat="server" CssClass="CommonButtonLink"
                                    Text="Transmission Sheet" CommandName="TransmissionSheetReport" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'></asp:HyperLink>
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
                                <%# Eval("ResourceDOB") != null ? ((DateTime)Eval("ResourceDOB")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Process Assigned Resource Map?')"
                                        CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>' UniqueKey="BDProcessAssignedResourceMap_lvBDProcessAssignedResourceMap_Edit_key" />
                                </td>
                                <td class="i">
                                <asp:HyperLink ID="hypEnvelopReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Small Envelop" CommandName="EnvelopReport" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypLargeEvelopReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Large Envelop" CommandName="LargeEvelopReport" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypLegalEnvelopReport" runat="server" CssClass="CommonButtonLink"
                                    Text="Legal Envelop" CommandName="LegalEnvelopReport" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'></asp:HyperLink><br />
                                    <asp:HyperLink ID="hypTransmissionSheet" runat="server" CssClass="CommonButtonLink"
                                    Text="Transmission Sheet" CommandName="TransmissionSheetReport" CommandArgument='<%#Eval("ProcessAssignedResourceMapID")%>'></asp:HyperLink>
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
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
