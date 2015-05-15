<%--
 Copyright and All Rights Reserved by
 KazcomTI, USA; 

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 20-Dec-2013, 02:17:52
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeNotice.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeNoticeControl" %>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
     <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div style="display: none;">
            <asp:Button ID="btnHidden" runat="server" Text="Hidden" Visible="true" />
        </div>
        <ajaxToolkit:ModalPopupExtender ID="MPE" runat="server" TargetControlID="btnHidden"
            PopupControlID="MessageBox" BackgroundCssClass="modalBackground" DropShadow="true"
            OkControlID="btnOk" PopupDragHandleControlID="MessageBox">
        </ajaxToolkit:ModalPopupExtender>
        <asp:Panel ID="MessageBox" CssClass="ModalPopup" runat="server">
            <div>
                <asp:Label ID="messageDetails" runat="server" Text="Recorded Inserted.">
                </asp:Label>
                <br />
                <asp:Button runat="server" ID="btnOk" Text="OK" />
            </div>
        </asp:Panel>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvHREmployeeNotice" runat="server" DataSourceID="odsHREmployeeNotice" OnItemCommand="lvHREmployeeNotice_ItemCommand" OnItemDataBound="lvHREmployeeNotice_ItemDataBound">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width: 250px;">
                                        Subject
                                    </td>
                                    <td class="hi">
                                        Remarks
                                    </td>
                                    <td class="hi">
                                        Notice Date
                                    </td>
                                    <td class="hi">
                                        Preview
                                    </td>
                                    <td class="rp" style="width:48px;">
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
                                                <asp:DataPager ID="dpListView" runat="server" PageSize="30">
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
                                    <%# Eval("TemplateName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NoticeDate") != null ? ((DateTime)Eval("NoticeDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                  <asp:HyperLink ID="hypPreview" runat="server" Text="Preview" />
                                </td>
                                <td class="rp">
                                    <asp:Label ID="lblNewOrOld"  runat="server" />
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
                                    <%# Eval("TemplateName")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Remarks")%>
                                </td>
                                <td class="i">
                                    <%# Eval("NoticeDate") != null ? ((DateTime)Eval("NoticeDate")).ToString("dd-MM-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <asp:HyperLink ID="hypPreview" runat="server" Text="Preview" />
                                </td>
                                <td class="rp">
                                    <asp:Label ID="lblNewOrOld" runat="server" />
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
                <asp:ObjectDataSource ID="odsHREmployeeNotice" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeNotice_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsHREmployeeNotice_Selecting">
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
