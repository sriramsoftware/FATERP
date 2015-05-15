<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectCollectedDocumentInfo.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectCollectedDocumentInfoControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div style="float: left; width: 325px;">
                <div class="contentSubTittle">
                    Document Tree</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayProjectDocumentTreeView ID="treeDocument" runat="server" OnSelectedNodeChanged="treeDocument_SelectedNodeChanged">
                        </kti:BayProjectDocumentTreeView>
                    </div>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 600px;">
                <div id="divUpdatePanel" runat="server" visible="false">
                    <div class="TableRow" style="text-align: left; padding-left: 10px; padding-bottom: 5px;"
                        runat="server">
                        <asp:Label ID="lblProjectDocumentInfo" Class="contentSubTittle" EnableViewState="false"
                            runat="server">Project Document Infomation & Status</asp:Label>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Start Date&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtStartDate" runat="server" ClientIDMode="Static" CssClass="ktiDateTextBox"
                                ValidationGroup="BDProjectCollectedDocumentInfoEntity" Width="230" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RegularExpressionValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate"
                                Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                ValidationGroup="BDProjectCollectedDocumentInfoEntity"></asp:RegularExpressionValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Required Time&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtRequiredTime" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBoxSmall"
                                ValidationGroup="BDProjectCollectedDocumentInfoEntity" Width="120" />
                            <asp:DropDownList ID="ddlRequiredTimeStandardTimeUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectCollectedDocumentInfoEntity" Width="88">
                            </asp:DropDownList>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvRequiredTime" runat="server" ControlToValidate="txtRequiredTime"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                                MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="BDProjectCollectedDocumentInfoEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Reminder Before&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox ID="txtReminderBefore" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBoxSmall"
                                ValidationGroup="BDProjectCollectedDocumentInfoEntity" Width="120" />
                            <asp:DropDownList ID="ddlReminderBeforeStandardTimeUnitID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectCollectedDocumentInfoEntity" Width="88">
                            </asp:DropDownList>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RangeValidator ID="rvReminderBefore" runat="server" ControlToValidate="txtReminderBefore"
                                Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                                MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="BDProjectCollectedDocumentInfoEntity"></asp:RangeValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            <asp:HyperLink CssClass="hypTableFormLeble" ID="hypProjectCollectedDocumentStatus" runat="server" Text="Status"
                                NavigateUrl="~/MD/MDProjectCollectedDocumentStatus.aspx" Target="_blank"></asp:HyperLink>
                            &nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:DropDownList ID="ddlProjectCollectedDocumentStatusID" CssClass="ktiSelect" ClientIDMode="Static"
                                runat="server" ValidationGroup="BDProjectCollectedDocumentInfoEntity" Width="236">
                            </asp:DropDownList>
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <div class="TableFormLeble" style="text-align: left;">
                            Remarks&nbsp;:
                        </div>
                        <div class="TableFormContent">
                            <asp:TextBox TextMode="MultiLine" CssClass="ktiTextArea" Width="390" Height="97" ClientIDMode="Static"
                                ID="txtRemarks" runat="server" ValidationGroup="BDProjectCollectedDocumentInfoEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                    <div class="TableRow" style="text-align: center;">
                        <div class="TableFormLeble">
                            &nbsp;</div>
                        <div class="TableFormContent">
                            <kti:SecureButton ID="btnSubmit" ValidationGroup="BDProjectCollectedDocumentInfoEntity"
                                OnClick="btnSave_Click" runat="server" Text="Add" UniqueKey="BDProjectCollectedDocumentInfoControl_Submit_key" />
                            <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                                UniqueKey="BDProjectCollectedDocumentInfoControl_Clear_key" />
                        </div>
                    </div>
                    <br />
                    <br />
                    <div style="text-align: left; padding-left: 10px; padding-bottom: 5px;" runat="server">
                        <asp:Label ID="lblDocumentUploadInfo" Class="contentSubTittle" EnableViewState="false"
                            runat="server">Upload/Remove Documents</asp:Label>
                    </div>
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
                    <div style="padding-left: 10px;">
                        <div class="TableRow" style="text-align: left; padding-bottom: 5px;">
                            <asp:Label ID="Label1" Class="contentSubTittle" EnableViewState="false" runat="server">Uploaded File List</asp:Label>
                        </div>
                        <asp:Label ID="lblUploadedInfo" runat="server"><b></b></asp:Label>
                        <div>
                            <div class="lv-c">
                                <asp:ListView ID="lvBDProjectCollectedDocumentUploadInfo" runat="server" DataSourceID="odsBDProjectCollectedDocumentUploadInfo"
                                    OnItemCommand="lvBDProjectCollectedDocumentUploadInfo_ItemCommand">
                                    <LayoutTemplate>
                                        <table class="lv" cellpadding="0" cellspacing="0">
                                            <tr class="h">
                                                <td class="rp">
                                                    &nbsp;
                                                </td>
                                                <td class="hi" style="display: none;">
                                                    Project Collected Document Info
                                                </td>
                                                <td class="hi" style="display: none;">
                                                    Remarks
                                                </td>
                                                <td class="hi" style="display: none;">
                                                    Path
                                                </td>
                                                <td class="hi" style="width: 270px;">
                                                <asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByOriginalFileName" CommandName="Sort" Text="Original File Name" CommandArgument="OriginalFileName"/>
                                                </td>
                                                <td class="hi" style="display: none;">
                                                    Current File Name
                                                </td>
                                                <td class="hi" style="display: none;">
                                                    File Type
                                                </td>
                                                <td class="hi" style="display: none;">
                                                    Extension
                                                </td>
                                                <td class="his" style="display: none;">
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
                                                            <asp:DataPager ID="dpListView" runat="server" PageSize="5">
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
                                                <%# Eval("ProjectCollectedDocumentInfoID")%>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <%# Eval("Remarks")%>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <%# Eval("Path")%>
                                            </td>
                                            <td class="i">
                                                <asp:HyperLink ID="hypUploadedFile" NavigateUrl='<%# Eval("Path")%>' runat="server"
                                                    Target="_blank" Text='<%# Eval("OriginalFileName")%>' CssClass="CommonLink"></asp:HyperLink>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <%# Eval("CurrentFileName")%>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <%# Eval("FileType")%>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <%# Eval("Extension")%>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ProjectCollectedDocumentUploadInfoID")%>'
                                                    UniqueKey="BDProjectCollectedDocumentUploadInfo_lvBDProjectCollectedDocumentUploadInfo_Edit_key" />
                                            </td>
                                            <td class="i">
                                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Project Collected Document Upload Info?')"
                                                    CommandArgument='<%#Eval("ProjectCollectedDocumentUploadInfoID")%>' UniqueKey="BDProjectCollectedDocumentUploadInfo_lvBDProjectCollectedDocumentUploadInfo_Delete_key" />
                                            </td>
                                            <td class="rp" style="display: none;">
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
                                                <%# Eval("ProjectCollectedDocumentInfoID")%>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <%# Eval("Remarks")%>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <%# Eval("Path")%>
                                            </td>
                                            <td class="i">
                                                <asp:HyperLink ID="hypUploadedFile" NavigateUrl='<%# Eval("Path")%>' runat="server"
                                                    Text='<%# Eval("OriginalFileName")%>' CssClass="CommonLink" Target="_blank"></asp:HyperLink>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <%# Eval("CurrentFileName")%>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <%# Eval("FileType")%>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <%# Eval("Extension")%>
                                            </td>
                                            <td class="i" style="display: none;">
                                                <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                    Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("ProjectCollectedDocumentUploadInfoID")%>'
                                                    UniqueKey="BDProjectCollectedDocumentUploadInfo_lvBDProjectCollectedDocumentUploadInfo_Edit_key" />
                                            </td>
                                            <td class="i">
                                                <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                    Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Project Collected Document Upload Info?')"
                                                    CommandArgument='<%#Eval("ProjectCollectedDocumentUploadInfoID")%>' UniqueKey="BDProjectCollectedDocumentUploadInfo_lvBDProjectCollectedDocumentUploadInfo_Delete_key" />
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
                            <asp:ObjectDataSource ID="odsBDProjectCollectedDocumentUploadInfo" runat="server"
                                SelectMethod="GetPagedData" SelectCountMethod="TotalRowCount" EnablePaging="true"
                                MaximumRowsParameterName="pageSize" StartRowIndexParameterName="startRowIndex"
                                TypeName="Bay.ERP.Web.UI.BDProjectCollectedDocumentUploadInfoDataSource" SortParameterName="sortExpression"
                                OnSelecting="odsBDProjectCollectedDocumentUploadInfo_Selecting">
                                <SelectParameters>
                                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                                    <asp:Parameter Name="pageSize" Type="Int32" />
                                    <asp:Parameter Name="sortExpression" Type="String" />
                                    <asp:Parameter Name="filterExpression" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <script type="text/javascript">

            function uploadError(sender, args) {
                //addToClientTable(args.get_fileName(), "<span style='color:red;'>" + args.get_errorMessage() + "</span>");
            }
            function uploadComplete(sender, args) {
                var btnClick = document.getElementById("btnClick");
                btnClick.click();
            }
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
