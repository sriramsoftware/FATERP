<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 19-Feb-2012, 06:02:47
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNDashboardItemView.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMNDashboardItemViewControl" %>
<style type="text/css">
    .modalBackgroundPopup
    {
        border-style: solid;
        border-width: 1px;
        height: 533px;
        left: 28px;
        position: fixed;
        top: -79px;
        width: 1291px;
        z-index: 100001;
    }
</style>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            $(document).ready(function () {
                $(".DashBoardItem").hover(
          function () {
              $(this).addClass("DashBoardItemHover");
          },
          function () {
              $(this).removeClass("DashBoardItemHover");
          }
        );
            });

        </script>
        <div style="width: 1005px;">
            <asp:ListView ID="lvCMNDashboardItem" runat="server" DataSourceID="odsCMNDashboardItem"
                OnItemDataBound="lvCMNDashboardItem_ItemDataBound" OnItemCommand="lvCMNDashboardItem_ItemCommand">
                <LayoutTemplate>
                    <div runat="server" id="itemPlaceholder">
                    </div>
                    <div style="clear: both;">
                    </div>
                </LayoutTemplate>
                <ItemTemplate>
                    <div class="DashBoardItem">
                        <table cellpadding="0" cellspacing="0">
                            <tr>
                                <td style="width: 50px;">
                                    <asp:HyperLink ID="hypImgDashBoardItem" runat="server">
                                        <asp:Image Style="border-width: 0px;" ID="imgDashBoardItem" AlternateText='<%# Eval("HoverMessage")%>'
                                            ToolTip='<%# Eval("HoverMessage")%>' Width='<%# Unit.Parse(Eval("ImageWidth").ToString()) %>'
                                            Height='<%# Unit.Parse(Eval("ImageHeight").ToString()) %>' runat="server" ImageUrl='<%# Eval("ImageUrl")%>' /></asp:HyperLink>
                                </td>
                                <td valign="middle" style="width: 180px;">
                                    <div id="DashboardText" class="DashBoardItemText" style="width: 180px;">
                                        <asp:HyperLink ID="hypDashBoardItem" CssClass="DashBoardItemHyperLink" runat="server"
                                            ForeColor="Green" Font-Size="10" Text='<%# Eval("Title")%>'></asp:HyperLink>
                                        <div style="padding-top: 3px;">
                                            <asp:ListView ID="lvCMNDashboardItemQuicklink" runat="server">
                                                <LayoutTemplate>
                                                    <table cellpadding="0" cellspacing="0">
                                                        <tr runat="server" id="itemPlaceholder">
                                                        </tr>
                                                    </table>
                                                </LayoutTemplate>
                                                <ItemTemplate>
                                                    <tr>
                                                        <td>
                                                            <asp:HyperLink ID="hypDashBoardItemSubLink" CssClass="DashBoardItemHyperLink" runat="server"
                                                                ForeColor="#0066cc" Font-Size="8" NavigateUrl='<%# Eval("NavigationUrl")%>' Text='<%# Eval("Name")%>'></asp:HyperLink>
                                                            <div style="padding-top: 0px;">
                                                                <asp:ListView ID="lvCMNDashboardItemQuicklink" runat="server">
                                                                    <LayoutTemplate>
                                                                        <span runat="server" id="itemPlaceholder"></span>
                                                                    </LayoutTemplate>
                                                                    <ItemTemplate>
                                                                        <span>
                                                                            <asp:HyperLink ID="hypDashBoardItemSubLink" CssClass="DashBoardItemHyperLink" runat="server"
                                                                                ForeColor="#0066cc" Font-Size="8" NavigateUrl='<%# Eval("NavigationUrl")%>' Text='<%# Eval("Name")%>'></asp:HyperLink>
                                                                        </span>
                                                                    </ItemTemplate>
                                                                </asp:ListView>
                                                            </div>
                                                        </td>
                                                    </tr>
                                                </ItemTemplate>
                                            </asp:ListView>
                                        </div>
                                    </div>
                                </td>
                            </tr>
                        </table>
                    </div>
                </ItemTemplate>
                <EmptyDataTemplate>
                    <div class="edr">
                        No Records Found To Display
                    </div>
                </EmptyDataTemplate>
            </asp:ListView>
            <asp:ObjectDataSource ID="odsCMNDashboardItem" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMNDashboardItemDataSource"
                SortParameterName="sortExpression" OnSelecting="odsCMNDashboardItem_Selecting">
                <SelectParameters>
                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                    <asp:Parameter Name="pageSize" Type="Int32" />
                    <asp:Parameter Name="sortExpression" Type="String" />
                    <asp:Parameter Name="filterExpression" Type="String" />
                </SelectParameters>
            </asp:ObjectDataSource>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
