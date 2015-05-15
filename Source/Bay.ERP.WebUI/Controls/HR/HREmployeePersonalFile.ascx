<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeePersonalFile.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeePersonalFileControl" %>
<script src="<%=ResolveUrl("~/Scripts/bookmarkscroll.js")%>" type="text/javascript"></script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
            ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="true"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor2" runat="server" TargetControlID="pnlEditor2"
            ExpandControlID="divCollapsControl2" CollapseControlID="divCollapsControl2" Collapsed="true"
            ImageControlID="imgExpandCollaps2" CollapsedImage="~/Images/expand-plus.gif"
            ExpandedImage="~/Images/collapse-minus.gif" SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <div>
        <div style="border:1px;">
            <section>
        <a id="Index"><h1>Index</h1></a>
       
        <section>
            <a href="javascript:bookmarkscroll.scrollTo('CV')">
                <h1>
                    CV
                </h1>
            </a>
            </section>
             <section>
            <a href="javascript:bookmarkscroll.scrollTo('AppointmentLetter')">
                <h1>
                    Appointment Letter
                </h1>
            </a>
             </section>
             <section>
            <a href="javascript:bookmarkscroll.scrollTo('JoinLetter')">
                <h1>
                    Join Letter
                </h1>
            </a>
             </section>
             <section>
            <a href="javascript:bookmarkscroll.scrollTo('OfficeMemo')">
                <h1>
                    Office Memo
                </h1>
            </a>
             </section>


             <section>
            <a href="javascript:bookmarkscroll.scrollTo('ChangeOfDesignationLetter')">
                <h1>
                    Change of Designation letter
                </h1>
            </a>
             </section>


             <section>
             <a href="javascript:bookmarkscroll.scrollTo('SalaryEnhancementLetter')">
                <h1>
                   Salary Enhancement letter
                </h1>
            </a>
             </section>
             <section>
            <a href="javascript:bookmarkscroll.scrollTo('ConfirmationLetter')">
                <h1>
                   Confirmation Letter
                </h1>
            </a>
             </section>
             <section>
            <a href="javascript:bookmarkscroll.scrollTo('EvoluationReports')">
                <h1>
                  Evoluation Reports
                </h1>
            </a>
             </section>
             </section>
             </div>
             <hr />
            <div class="TableFormContentAgreement">
                <a id="CV" href="javascript:bookmarkscroll.scrollTo('Index')">
                    <h1 style="color: Gray">
                        CV</h1>
                </a>
                <asp:Literal ID="lblCVTextView" runat="server"></asp:Literal>
            </div>
            <br />
            <section>
            <div class="TableFormContentAgreement">
                <a id="AppointmentLetter" href="javascript:bookmarkscroll.scrollTo('Index')">
                    <h1 style="color: Gray">
                        Appointment Letter</h1>
                </a>
                <asp:Literal ID="lblAppointmentLetter" runat="server"></asp:Literal>
            </div>
            </section>
            <br />
            <section>
            <div class="TableFormContentAgreement">
            <a id="JoinLetter" href="javascript:bookmarkscroll.scrollTo('Index')">
                <h1 style="color: Gray">
                    Join Letter</h1>
             </a>
                <asp:Literal ID="lblJoinLetter" runat="server"></asp:Literal>
            </div>
            </section>
            <br />
            <section>
            <div class="TableFormContentAgreement">
            <a id="OfficeMemo" href="javascript:bookmarkscroll.scrollTo('Index')">
                <h1 style="color: Gray">
                    Office Memo</h1>
                    </a>
                <asp:Literal ID="lblOfficeMemo" runat="server"></asp:Literal>
                
            </div>
            </section>
            <br />
            <section>
            <div class="TableFormContentAgreement">
            <a id="ChangeOfDesignationLetter" href="javascript:bookmarkscroll.scrollTo('Index')" >
                <h1 style="color: Gray">
                    Change of Designation letter</h1>
                    </a>
                <asp:Literal ID="lblChangeOfDesignationLetter" runat="server"></asp:Literal>
                
            </div>
            </section>
            <br />
            <section>
            <div class="TableFormContentAgreement">
            <a id="SalaryEnhancementLetter" href="javascript:bookmarkscroll.scrollTo('Index')">
                <h1 style="color: Gray">
                    Salary Enhancement letter</h1>
                    </a>
                <asp:Literal ID="lblSalaryEnhancementLetter" runat="server"></asp:Literal>
            </div>
            </section>
            <br />
            <section>
            <div class="TableFormContentAgreement">
            <a id="ConfirmationLetter" href="javascript:bookmarkscroll.scrollTo('Index')">
                <h1 style="color: Gray">
                    Confirmation Letter</h1>
                    </a>
                <asp:Literal ID="lblConfirmationLetter" runat="server"></asp:Literal>
            </div>
            </section>
            <br />
            <section>
            <div class="TableFormContentAgreement">
            <a id="EvoluationReports" href="javascript:bookmarkscroll.scrollTo('Index')">
                <h1 style="color: Gray">
                    Evoluation Reports</h1>
             </a>
                <div>
                    <div class="lv-c">
                        <asp:ListView ID="lvHRSession" runat="server" DataSourceID="odsHRSession" OnItemDataBound="lvHRSession_ItemDataBound">
                            <LayoutTemplate>
                                <table class="lv" cellpadding="0" cellspacing="0">
                                    <tr class="h">
                                        <td class="rp">
                                            &nbsp;
                                        </td>
                                        <td class="hi" style="width: 206px;">
                                            Session Name
                                        </td>
                                        <td class="his" style="width: 147px;">
                                            Evoluation Report
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
                                        <%# Eval("SessionName")%>
                                    </td>
                                    <td class="i">
                                        <asp:HyperLink ID="hypEvoluationReport" runat="server" CssClass="CommonButtonLink"
                                            Text="Evoluation Report" />
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
                                        <%# Eval("SessionName")%>
                                    </td>
                                    <td class="i">
                                        <asp:HyperLink ID="hypEvoluationReport" runat="server" CssClass="CommonButtonLink"
                                            Text="Evoluation Report" />
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
                    <asp:ObjectDataSource ID="odsHRSession" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HRSession_DetailedDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsHRSession_Selecting">
                        <SelectParameters>
                            <asp:Parameter Name="startRowIndex" Type="Int32" />
                            <asp:Parameter Name="pageSize" Type="Int32" />
                            <asp:Parameter Name="sortExpression" Type="String" />
                            <asp:Parameter Name="filterExpression" Type="String" />
                        </SelectParameters>
                    </asp:ObjectDataSource>
                </div>
            </div>
            </section>
            <hr />
            <div style="display: none;">
                <div class="TableRow" style="width: 100;">
                    <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
                        <div id="divCollapsControl" class="divCollapsControl">
                            <div style="float: left; height: 16px; width: 16px;">
                                <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                            </div>
                            <div style="float: left; padding-left: 3px;">
                                <asp:Label ID="lvlCollapsText" runat="server" Text="Employee All Documents"></asp:Label>
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                    </asp:Panel>
                </div>
                <div class="TableRow" style="width: 100;">
                    <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                        <div>
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: right; width: 154px;">
                                    <asp:HyperLink CssClass="hypTableFormLeble" ID="hypDocumentCategory" runat="server"
                                        Text="Document Category" NavigateUrl="~/MD/MDDocumentCategory.aspx" Target="_blank"></asp:HyperLink>
                                    :
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlDocumentCategoryID" CssClass="ktiSelect" ClientIDMode="Static"
                                        runat="server" AutoPostBack="true" OnSelectedIndexChanged="ddlDocumentCategoryID_SelectedIndexChanged"
                                        ValidationGroup="HREmployeeDocumentEntity" Width="234">
                                    </asp:DropDownList>
                                </div>
                            </div>
                        </div>
                        <br />
                        <div class="listContentTitle">
                            Employee Document List
                        </div>
                        <div>
                            <div class="lv-c">
                                <asp:ListView ID="lvHREmployeeDocument" runat="server" DataSourceID="odsHREmployeeDocument">
                                    <LayoutTemplate>
                                        <table class="lv" cellpadding="0" cellspacing="0">
                                            <tr class="h">
                                                <td class="rp">
                                                    &nbsp;
                                                </td>
                                                <td class="hi">
                                                    Path
                                                </td>
                                                <td class="hi">
                                                    File Type
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
                                                <asp:HyperLink ID="hypOrginalFileName" runat="server" Text="File" NavigateUrl='<%# Eval("Path")%>'
                                                    Target="_blank"></asp:HyperLink>
                                            </td>
                                            <td class="i">
                                                <%# Eval("FileType")%>
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
                                                <%# Eval("DocumentCategoryID")%>
                                            </td>
                                            <td class="i">
                                                <asp:HyperLink ID="hypOrginalFileName" runat="server" Text="File" NavigateUrl='<%# Eval("Path")%>'
                                                    Target="_blank"></asp:HyperLink>
                                            </td>
                                            <td class="i">
                                                <%# Eval("FileType")%>
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
                            <asp:ObjectDataSource ID="odsHREmployeeDocument" runat="server" SelectMethod="GetPagedData"
                                SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                                StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.HREmployeeDocumentDataSource"
                                SortParameterName="sortExpression" OnSelecting="odsHREmployeeDocument_Selecting">
                                <SelectParameters>
                                    <asp:Parameter Name="startRowIndex" Type="Int32" />
                                    <asp:Parameter Name="pageSize" Type="Int32" />
                                    <asp:Parameter Name="sortExpression" Type="String" />
                                    <asp:Parameter Name="filterExpression" Type="String" />
                                </SelectParameters>
                            </asp:ObjectDataSource>
                        </div>
                    </asp:Panel>
                </div>
            </div>
            <div style="display: none;">
                <div class="TableRow" style="width: 100;">
                    <asp:Panel ID="pnlCPEContent2" runat="server" CssClass="pnlCPEContent">
                        <div id="divCollapsControl2" class="divCollapsControl">
                            <div style="float: left; height: 16px; width: 16px;">
                                <asp:Image ID="imgExpandCollaps2" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                            </div>
                            <div style="float: left; padding-left: 3px;">
                                <asp:Label ID="lvlCollapsText2" runat="server" Text="Evolution Report"></asp:Label>
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                    </asp:Panel>
                </div>
                <div class="TableRow" style="width: 100;">
                    <asp:Panel ID="pnlEditor2" runat="server" CssClass="pnlEditor">
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right; width: 154px;">
                                Evoluation Session:
                            </div>
                            <div class="TableFormContent">
                                <asp:DropDownList ID="ddlEvolutionSessionID" CssClass="ktiSelect" ClientIDMode="Static"
                                    runat="server" OnSelectedIndexChanged="ddlEvolutionSessionID_SelectedIndexChanged"
                                    AutoPostBack="true" ValidationGroup="HREmployeeDocumentEntity" Width="234">
                                </asp:DropDownList>
                                <asp:HyperLink ID="hypGenerateReport" runat="server" Text="Evolution Report"></asp:HyperLink>
                            </div>
                        </div>
                    </asp:Panel>
                </div>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
