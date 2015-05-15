<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 05-Oct-2012, 11:26:30
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMBillUploadInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMBillUploadInfoControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnClick" EventName="Click" />
    </Triggers>
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <asp:Image ID="imgScan" ImageUrl="~/Images/scan.png"  runat="server" AlternateText="Scan And Send" ImageAlign="Right"/>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Select Document&nbsp;:
                </div>
                <div class="TableFormContent">
                    <div style="float: left;">
                        <ajaxToolkit:AsyncFileUpload runat="server" ID="afuFiles" CssClass="FileUploadClass"
                            UploaderStyle="Modern" UploadingBackColor="#CCFFFF" Width="230px" ThrobberID="myThrobber"
                            OnClientUploadError="uploadError" OnClientUploadComplete="uploadComplete" />
                        <asp:Button runat="server" ID="btnClick" ClientIDMode="Static" Text="Update grid"
                            Style="display: none" OnClick="btnClick_Click" />
                    </div>
                    <div style="float: left; padding-left: 10px; padding-top: 5px;">
                        <asp:Label runat="server" ID="myThrobber">
                            <asp:Image ID="imgUploading" runat="server" ImageAlign="AbsMiddle" AlternateText="Uploading..."
                                ImageUrl="~/Images/UploadImage/uploading.gif" /></asp:Label>
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
            </div>
            <br />
            <div class="listContentTitle">
                Bill Upload Info List
            </div>
            <div>
                <div class="lv-c">
                    <asp:ListView ID="lvCMBillUploadInfo" runat="server" DataSourceID="odsCMBillUploadInfo"
                        OnItemCommand="lvCMBillUploadInfo_ItemCommand">
                        <LayoutTemplate>
                            <table class="lv" cellpadding="0" cellspacing="0">
                                <tr class="h">
                                    <td class="rp">
                                        &nbsp;
                                    </td>
                                    <td class="hi" style="width: 200px;">
                                        File Name
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
                                    <asp:HyperLink ID="hypUploadedFile" NavigateUrl='<%# Eval("Path")%>' runat="server"
                                        Text='<%# Eval("OriginalFileName")%>' CssClass="CommonLink" Target="_blank"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MBill Upload Info?')"
                                        CommandArgument='<%#Eval("BillUploadInfoID")%>' UniqueKey="CMBillUploadInfo_lvCMBillUploadInfo_Delete_key" />
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
                                    <asp:HyperLink ID="hypUploadedFile" NavigateUrl='<%# Eval("Path")%>' runat="server"
                                        Text='<%# Eval("OriginalFileName")%>' CssClass="CommonLink" Target="_blank"></asp:HyperLink>
                                </td>
                                <td class="i">
                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete C MBill Upload Info?')"
                                        CommandArgument='<%#Eval("BillUploadInfoID")%>' UniqueKey="CMBillUploadInfo_lvCMBillUploadInfo_Delete_key" />
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
                <asp:ObjectDataSource ID="odsCMBillUploadInfo" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.CMBillUploadInfoDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsCMBillUploadInfo_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
            </div>
        </div>
        <div>
            <br />
            <br />
            <table>
                <tr>
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
                </tr>
                <tr style="padding-left:200px;">
                <td>
                      
                </td>
                    <td>
                        <kti:SecureButton ID="btnInitiateApprovalProcess" ValidationGroup="none" OnClick="btnInitiateApprovalProcess_Click"
                            runat="server" Text="Submit for Approval" UniqueKey="CMBillUploadInfoControl_InitiateApprovalProcess_key" />
                            <asp:Button ID="btnAddAnotherBill" ValidationGroup="none" OnClick="btnAddAnotherBill_Click"
                            runat="server" Text="Save & Add New" />
                    </td>
                    <td>
                        &nbsp;&nbsp;
                    </td>
                    <td>
                        <%--<kti:SecureButton ID="btnResetApprovalProcess" ValidationGroup="none" OnClick="btnResetApprovalProcess_Click"
                            runat="server" Text="Reset Approval Process" UniqueKey="CMBillUploadInfoControl_ResetApprovalProcess_key" Visible="false" />--%>
                    </td>
                </tr>
            </table>
        </div>
        <script type="text/javascript">
            function uploadError(sender, args) {
            }
            function uploadComplete(sender, args) {
                var btnClick = document.getElementById("btnClick");
                btnClick.click();
            }
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
