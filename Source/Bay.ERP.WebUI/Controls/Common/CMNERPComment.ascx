<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 23-Mar-2013, 04:14:01
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMNERPComment.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMNERPCommentControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <br />
            <br />
            <div class="TableFormLeble" style="text-align: left;">
                    Comment&nbsp;:
                </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormContent waterMarkContainer">
                    <label class="watermarkLabel" for="txtComment">
                        Enter Comment</label>
                    <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="720" ClientIDMode="Static"
                        ID="txtComment" runat="server" ValidationGroup="CMNERPCommentEntity" />
                    <span class="RequiredField">*</span>
                </div>
                <div class="TableFormValidatorContent">
                    <asp:RequiredFieldValidator ID="rfvComment" runat="server" ControlToValidate="txtComment"
                        ErrorMessage="Please Enter Comment" ValidationGroup="CMNERPCommentEntity" EnableViewState="False"
                        Display="Dynamic"></asp:RequiredFieldValidator>
                </div>
            </div>
            <div class="TableRow" style="text-align: right;">
                <div class="TableFormLeble">
                    &nbsp;</div>
                <div style="float:right; padding-right:57px;">
                    <asp:Button ID="btnSubmit" ValidationGroup="CMNERPCommentEntity" OnClick="btnSave_Click"
                        runat="server" Text="Post" UniqueKey="CMNERPCommentControl_Submit_key" />
                </div>
            </div>
            <br />
            <div style="width: 100%;">
                <div style="width: 720px; margin: 10px; padding: 10px;">
                    <div style="padding-bottom: 15px;">
                        <h3 style="color: #4B4B4B;">
                            All Comments:</h3>
                    </div>
                    <div>
                        <asp:ListView ID="lvCMNERPComment" runat="server" DataSourceID="odsCMNERPComment">
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
                                                        <span style="color: green;">Comment</span> </b><span style='color: gray;'><i>by <b>
                                                            <%# Eval("MemberFullName")%></b></i></span>
                                                </td>
                                                <td align="right">
                                                    on <b>
                                                        <%# Eval("CommentDate") != null ? ((DateTime)Eval("CommentDate")).ToString("dd-MM-yyyy hh:mm:ss") : ""%></b>
                                                </td>
                                            </tr>
                                        </table>
                                    </div>
                                    <div style="border-top: 1px solid gray; height: 1px; width: 100%;">
                                    </div>
                                    <div style="float:left;">
                                    <%--<asp:Image ID="imgEmployee" runat="server" ImageUrl="~/Images/user.png" Width="40" Height="40" />--%>
                                    </div>
                                    <div style="text-align: justify; letter-spacing: 0px; word-spacing: 0px; line-height: 18px;
                                        color: #4B4B4B; font-size: 12px; font-family: 'Verdana'; padding-top: 3px; float:left;">
                                        <%# Eval("Comment")%>
                                    </div>
                                    <div style="clear:both;"></div>
                                    
                                </div>
                            </ItemTemplate>
                             <EmptyDataTemplate>
                            <div class="edr">
                                No Comment Available To Display
                            </div>
                        </EmptyDataTemplate>
                        </asp:ListView>
                    </div>
                </div>
            </div>
            <%-- <div>
                <div class="lv-c">
                    <asp:ListView ID="" runat="server" DataSourceID="odsCMNERPComment" OnItemCommand="lvCMNERPComment_ItemCommand">
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
                                        Reference
                                    </td>
                                    <td class="hi">
                                        Comment
                                    </td>
                                    <td class="hi">
                                        Comment Date
                                    </td>
                                    <td class="hi">
                                        Employee
                                    </td>
                                    <td class="hi">
                                        I P
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
                                    <%# Eval("ProcessCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Comment")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommentDate") != null ? ((DateTime)Eval("CommentDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("CommentID")%>' UniqueKey="CMNERPComment_lvCMNERPComment_Edit_key" />
                                </td>
                                <td class="i">
                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MNERPComment?')"
                                        CommandArgument='<%#Eval("CommentID")%>' UniqueKey="CMNERPComment_lvCMNERPComment_Edit_key"/>
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
                                    <%# Eval("ProcessCategoryID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("ReferenceID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("Comment")%>
                                </td>
                                <td class="i">
                                    <%# Eval("CommentDate") != null ? ((DateTime)Eval("CommentDate")).ToString("mm-dd-yyyy") : ""%>
                                </td>
                                <td class="i">
                                    <%# Eval("EmployeeID")%>
                                </td>
                                <td class="i">
                                    <%# Eval("IP")%>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink" Text="Edit"
                                        CommandName="EditItem" CommandArgument='<%#Eval("CommentID")%>' UniqueKey="CMNERPComment_lvCMNERPComment_Edit_key" />
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink" Text="Delete"
                                        CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MNERPComment?')"
                                        CommandArgument='<%#Eval("CommentID")%>' UniqueKey="CMNERPComment_lvCMNERPComment_Edit_key"/>
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
                
            </div>--%>
            <asp:ObjectDataSource ID="odsCMNERPComment" runat="server" SelectMethod="GetPagedData"
                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMNERPComment_DetailedDataSource"
                SortParameterName="sortExpression" OnSelecting="odsCMNERPComment_Selecting">
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
