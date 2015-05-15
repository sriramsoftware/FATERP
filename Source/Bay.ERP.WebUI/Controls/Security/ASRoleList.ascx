<%--
 Copyright and All Rights Reserved by
 TalentPlus Software Inc, USA; 
 Delphi Solutions Ltd., Bangladesh,
 TalentPlus Software FZ LLC, UAE; 
 TalentPlus Systems India Pvt Ltd., India. 

 Faisal Alam, faisal@talentPlusSoft.con
 ©2006 – 2010.

 Code Generate Time - 25-Feb-2010, 12:41:01
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ASRoleList.ascx.cs" Inherits="Bay.ERP.Web.UI.ASRoleListControl" %>
<div>
    <div class="TableRow" style="text-align: left;">
        <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
    </div>
    <div>
    <div class="lv-c">
                <asp:ListView ID="rgASSiteMap" runat="server" OnItemDataBound="rgASSiteMap_ItemDataBound" OnItemCommand="rgASSiteMap_ItemCommand">
            
                    <LayoutTemplate>
                        <table class="lv" cellpadding="0" cellspacing="0">
                            <tr class="h">
                                <td class="rp">
                                    &nbsp;
                                </td>
                                <td class="hi" style="width:200px;">
                                    Role
                                </td>
                                <td class="his" style="display:none;">
                                    EDIT
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
                        </table>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <tr class="r">
                            <td class="rp">
                                &nbsp;
                            </td>
                            <td class="i">
                                <%# Eval("RoleName")%>
                            </td>
                            <td class="i" style="display:none;">
                                <asp:LinkButton ID="lnkbtnEditAccess" runat="server" CssClass="CommonButtonLink" Text="Edit Access"
                                    CommandName="EditItem" UniqueKey="ASRoleList_rgASSiteMap_Edit" ></asp:LinkButton>
                            </td>
                            <td class="i">
                            <asp:LinkButton ID="lnkbtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                    CommandName="DeleteItem" UniqueKey="ASRoleList_rgASSiteMap_Delete" OnClientClick="return confirm('Are you sure to delete Role?')"></asp:LinkButton>
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
                                <%# Eval("RoleName")%>
                            </td>
                            <td class="i" style="display:none;">
                                <asp:LinkButton ID="lnkbtnEditAccess" runat="server" CssClass="CommonButtonLink" Text="Edit Access"
                                    CommandName="EditItem" UniqueKey="ASRoleList_rgASSiteMap_Edit"></asp:LinkButton>
                            </td>
                            <td class="i">
                            <asp:LinkButton ID="lnkbtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                    CommandName="DeleteItem" UniqueKey="ASRoleList_rgASSiteMap_Delete" OnClientClick="return confirm('Are you sure to delete Role?')"></asp:LinkButton>
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

      <%--  <telerik:RadGrid AutoGenerateColumns="false" ID="rgASSiteMap" runat="server" OnItemDataBound="rgASSiteMap_ItemDataBound"
            OnItemCommand="rgASSiteMap_ItemCommand">
            <PagerStyle Mode="NextPrevAndNumeric" />
            <MasterTableView>
                <Columns>
                    <telerik:GridBoundColumn DataField="RoleName" HeaderText="Role" UniqueName="Description">
                    </telerik:GridBoundColumn>
                    <epms:GridButtonColumnEPMS ButtonType="LinkButton" Text="Edit Access" HeaderText="EDIT"
                        UniqueName="lnkBtnEdit" UniqueKey="ASRoleList_rgASSiteMap_Edit" CommandName="EditItem">
                    </epms:GridButtonColumnEPMS>
                    <epms:GridButtonColumnEPMS ButtonType="LinkButton" Text="Delete" HeaderText="DELETE"
                        UniqueKey="ASRoleList_rgASSiteMap_Delete" UniqueName="lnkBtnDelete" CommandName="DeleteItem">
                    </epms:GridButtonColumnEPMS>
                </Columns>
            </MasterTableView>
            <ClientSettings ReorderColumnsOnClient="True" AllowDragToGroup="True" AllowColumnsReorder="True">
                <Selecting AllowRowSelect="True"></Selecting>
                <Resizing AllowRowResize="True" AllowColumnResize="True" EnableRealTimeResize="True"
                    ResizeGridOnColumnResize="False"></Resizing>
            </ClientSettings>
        </telerik:RadGrid>--%>
    </div>
</div>
