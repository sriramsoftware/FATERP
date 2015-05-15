<%--
 Copyright and All Rights Reserved by
 TalentPlus Software Inc, USA; 
 Delphi Solutions Ltd., Bangladesh,
 TalentPlus Software FZ LLC, UAE; 
 TalentPlus Systems India Pvt Ltd., India. 

 Faisal Alam, faisal@talentPlusSoft.con
 ©2006 – 2010.

 Code Generate Time - 17-Jun-2010, 07:39:49
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="UserList_DetailedListCustom.ascx.cs"
    Inherits="Bay.ERP.Web.UI.UserList_DetailedControlListCustom" %>
<div>
    <div class="TableRow" style="text-align: left;">
        <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
    </div>
    <fieldset style="padding: 10px;">
        <legend>Find User</legend>
        <div class="TableRow" style="width: 100;">
            <div class="TableFormLeble" style="text-align: right;">
                <asp:Label ID="lblTitle" runat="server" Text="Name"></asp:Label>:
            </div>
            <div class="TableFormContent">
                <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                    Width="230">
                </asp:TextBox>
            </div>
        </div>
        <div class="TableRow" style="width: 100;">
            <div class="TableFormLeble" style="text-align: right;">
                <asp:Label ID="Label1" runat="server" Text="User ID"></asp:Label>:
            </div>
            <div class="TableFormContent">
                <asp:TextBox ID="txtUserId" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                    Width="230">
                </asp:TextBox>
            </div>
        </div>
        <div class="TableRow" style="width: 100;">
            <div class="TableFormLeble" style="text-align: right;">
                <asp:Label ID="Label2" runat="server" Text="Role"></asp:Label>:
            </div>
            <div class="TableFormContent">
                <asp:TextBox ID="txtRole" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                    Width="230">
                </asp:TextBox>
            </div>
        </div>
        <div class="TableRow" style="text-align: center;">
            <div class="TableFormLeble">
                &nbsp;</div>
            <div class="TableFormContent">
                <kti:SecureButton ID="btnSearch" OnClick="btnSearch_Click" runat="server" Text="Find"
                    UniqueKey="ASSecurityUserList_Search_Key" />
            </div>
        </div>
    </fieldset>
    <br />
    <b>Total User :
        <asp:Label ID="lblTotalUser" runat="server"></asp:Label>
    </b>
    <br />
    <br />
    <div class="lv-c">
        <asp:ListView ID="rgUserList_Detailed" runat="server" DataSourceID="odsUserList_Detailed" OnItemDataBound="rgUserList_Detailed_ItemDataBound">
            <LayoutTemplate>
                <table class="lv" cellpadding="0" cellspacing="0">
                    <tr class="h">
                        <td class="rp">
                            &nbsp;
                        </td>
                        <td class="hi">
                            Full Name
                        </td>
                        <td class="hi">
                            User Name
                        </td>
                        <td class="hi">
                            Role Name
                        </td>
                        <td class="hi">
                            Last Login Date
                        </td>
                        <td class="his">
                            EDIT
                        </td>
                        <td class="his" style="width:200px;">
                            Block User
                        </td>
                        <td class="his">
                            DELETE
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
                        <%# Eval("FullName")%>
                    </td>
                    <td class="i">
                        <%# Eval("UserName")%>
                    </td>
                    <td class="i">
                        <%# Eval("RoleName")%>
                    </td>
                    <td class="i">
                        <%# Eval("LastLoginDate") != null ? ((DateTime)Eval("LastLoginDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                    </td>
                    <td class="i">
                        <asp:HyperLink ID="hypEditAccess" runat="server" CssClass="CommonButtonLink"
                            Text="Edit" CommandName="EditItem" UniqueKey="ASUserList_rgASSiteMap_Edit"></asp:HyperLink>
                    </td>
                    <td class="i">
                        <asp:HyperLink ID="hypBlockUser" runat="server" CssClass="CommonButtonLink"
                            Text="Block User" CommandName="BlockUser" UniqueKey="ASUserList_rgASSiteMap_BlockUser"></asp:HyperLink>
                    </td>
                    <td class="i">
                        <asp:LinkButton ID="lnkbtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                            CommandName="DeleteItem" UniqueKey="ASUserList_rgASSiteMap_Delete" OnClientClick="return confirm('Are you sure to delete User?')"></asp:LinkButton>
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
                        <%# Eval("FullName")%>
                    </td>
                    <td class="i">
                        <%# Eval("UserName")%>
                    </td>
                    <td class="i">
                        <%# Eval("RoleName")%>
                    </td>
                    <td class="i">
                        <%# Eval("LastLoginDate") != null ? ((DateTime)Eval("LastLoginDate")).ToString(UIConstants.SHORT_DATE_FORMAT) : ""%>
                    </td>
                    <td class="i">
                         <asp:HyperLink ID="hypEditAccess" runat="server" CssClass="CommonButtonLink"
                            Text="Edit" CommandName="EditItem" UniqueKey="ASUserList_rgASSiteMap_Edit"></asp:HyperLink>
                    </td>
                    <td class="i">
                        <asp:HyperLink ID="hypBlockUser" runat="server" CssClass="CommonButtonLink"
                            Text="Block User" CommandName="BlockUser" UniqueKey="ASUserList_rgASSiteMap_BlockUser"></asp:HyperLink>
                    </td>
                    <td class="i">
                        <asp:LinkButton ID="lnkbtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                            CommandName="DeleteItem" UniqueKey="ASUserList_rgASSiteMap_Delete" OnClientClick="return confirm('Are you sure to delete User?')"></asp:LinkButton>
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
    <asp:ObjectDataSource ID="odsUserList_Detailed" runat="server" SelectMethod="GetPagedData"
        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.UserList_DetailedDataSource"
        SortParameterName="sortExpression" OnSelecting="odsUserList_Detailed_Selecting">
        <SelectParameters>
            <asp:Parameter Name="pageSize" Type="Int32" />
            <asp:Parameter Name="startRowIndex" Type="Int32" />
            <asp:Parameter Name="sortExpression" Type="String" />
            <asp:Parameter Name="filterExpression" Type="String" />
        </SelectParameters>
    </asp:ObjectDataSource>
</div>
