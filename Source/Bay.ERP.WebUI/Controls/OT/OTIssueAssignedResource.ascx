<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="OTIssueAssignedResource.ascx.cs"
    Inherits="Bay.ERP.Web.UI.OTIssueAssignedResourceControl" %>
<script type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#tabs").tabs();
        });
    }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
        </script>
        <%--  <script type="text/javascript">
          function toggleCheckBoxes(source) {
              var listView = document.getElementById('<%= lvResourceEmployee_Custom.FindControl("table1").ClientID %>');
              for (var i = 0; i < listView.rows.length; i++) {
                  var inputs = listView.rows[i].getElementsByTagName('input');
                  for (var j = 0; j < inputs.length; j++) {
                      if (inputs[j].type == "checkbox")
                          inputs[j].checked = source.checked;
                  }
              }
          }  
    </script>--%>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div>
                <div id="tabs">
                    <ul>
                        <li><a href="#ResourceEmployee">Employee</a></li>
                        <li><a href="#ResourceTool">Tool</a></li>
                        <li><a href="#IssueUpload">Upload Info</a></li>
                        <li><a href="#RoomAllocate">Roome Allocate</a></li>
                    </ul>
                    <div id="ResourceEmployee">
                        <div>
                            <div class="TableRow" style="width: 100%; padding-left: 480px;">
                                <div class="TableFormLeble" style="text-align: right;">
                                    Filter Text&nbsp;:
                                </div>
                                <div class="TableFormContent waterMarkContainer">
                                    <label class="watermarkLabel" for="txtSearchText">
                                        Type E.Code, Name# Or Dept.</label>
                                    <asp:TextBox ID="txtSearchText" runat="server" ClientIDMode="Static" CssClass="ktiTextBox"
                                        Width="230" /><span><asp:CheckBox ID="chbxFilter" runat="server" AutoPostBack="true"
                                            OnCheckedChanged="chbxFilter_CheckedChanged" Text="Use Filter" /></span>
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            <div>
                                <div class="lv-c">
                                    <asp:ListView ID="lvResourceEmployee_Custom" runat="server" DataSourceID="odsResourceEmployee_Custom"
                                        OnDataBound="lvResourceEmployee_Custom_DataBound" OnItemDataBound="lvOTIssueAssignedResource_ItemDataBound">
                                        <LayoutTemplate>
                                            <table class="lv" cellpadding="0" cellspacing="0">
                                                <tr class="h">
                                                    <td class="rp">
                                                        &nbsp;
                                                    </td>
                                                    <td style="width: 40px;">
                                                        <asp:CheckBox ID="chbxHeader" runat="server" Checked="false" />
                                                    </td>
                                                    <td class="hi" style="display: none;">
                                                        Resource
                                                    </td>
                                                    <td class="hi" style="display: none;">
                                                        Reference
                                                    </td>
                                                    <td class="hi">
                                                        Employee Code
                                                    </td>
                                                    <td class="hi" style="width: 295px;">
                                                        Employee Full Name
                                                    </td>
                                                    <td class="hi" style="width: 130px;">
                                                        Start Date
                                                    </td>
                                                    <td class="hi" style="width: 130px;">
                                                        End Date
                                                    </td>
                                                    <td class="hi" style="width: 120px;">
                                                        Remarks
                                                    </td>
                                                    <td class="hi">
                                                        Assign Type
                                                    </td>
                                                    <td class="hi" style="display: none;">
                                                        Resource Category Name
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
                                                <td>
                                                    <asp:CheckBox ID="chbxState" runat="server" Checked="false" />
                                                </td>
                                                <td class="i" style="display: none;">
                                                    <asp:Label ID="lblResource" runat="server" Text='<%# Eval("ResourceID")%>'></asp:Label>
                                                </td>
                                                <td class="i" style="display: none;">
                                                    <asp:Label ID="lblReferenceID" runat="server" Text='<%# Eval("ReferenceID")%>'></asp:Label>
                                                    <asp:Label ID="lblEmployeePrimaryEmailLV" runat="server" Text='<%# Eval("PrimaryEmail")%>'></asp:Label>
                                                </td>
                                                <td class="i">
                                                    <%# Eval("EmployeeCode")%>
                                                </td>
                                                <td class="i">
                                                    <%# Eval("MemberFullName")%>
                                                </td>
                                                <td class="i">
                                                    <div class="TableFormValidatorContent">
                                                        <asp:TextBox ID="txtStartDate" Width="125" runat="server" CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" ControlToValidate="txtStartDate"
                                                            ErrorMessage="Please Enter Start Date" ValidationGroup="REQRequisitionItemEntity"
                                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate"
                                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                                            ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                                    </div>
                                                </td>
                                                <td class="i">
                                                    <div class="TableFormValidatorContent">
                                                        <asp:TextBox ID="txtEndDate" Width="125" runat="server" CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" ControlToValidate="txtEndDate"
                                                            ErrorMessage="Please Enter End Date" ValidationGroup="REQRequisitionItemEntity"
                                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="revEndDate" runat="server" ControlToValidate="txtEndDate"
                                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                                            ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                                    </div>
                                                </td>
                                                <td class="i">
                                                    <asp:TextBox ID="txtRemarksLV" runat="server" CssClass="ktiTextBoxListview" Style="width: 120px;"></asp:TextBox>
                                                </td>
                                                <td class="i">
                                                    <div class="TableFormContent">
                                                        <asp:DropDownList ID="ddlIssueAssignTypeIDLV" CssClass="ktiSelect" ClientIDMode="Static"
                                                            runat="server" ValidationGroup="REQRequisitionItemEntity" Width="100">
                                                        </asp:DropDownList>
                                                    </div>
                                                </td>
                                                <td class="i" style="display: none;">
                                                    <%# Eval("ResourceCategoryName")%>
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
                                                <td>
                                                    <asp:CheckBox ID="chbxState" runat="server" Checked="false" />
                                                </td>
                                                <td class="i" style="display: none;">
                                                    <asp:Label ID="lblResource" runat="server" Text='<%# Eval("ResourceID")%>'></asp:Label>
                                                </td>
                                                <td class="i" style="display: none;">
                                                    <asp:Label ID="lblReferenceID" runat="server" Text='<%# Eval("ReferenceID")%>'></asp:Label>
                                                    <asp:Label ID="lblEmployeePrimaryEmailLV" runat="server" Text='<%# Eval("PrimaryEmail")%>'></asp:Label>
                                                </td>
                                                <td class="i">
                                                    <%# Eval("EmployeeCode")%>
                                                </td>
                                                <td class="i" style="display: none;">
                                                    <%# Eval("ResourceCategoryName")%>
                                                </td>
                                                <td class="i">
                                                    <%# Eval("MemberFullName")%>
                                                </td>
                                                <td class="i">
                                                    <div class="TableFormValidatorContent">
                                                        <asp:TextBox ID="txtStartDate" Width="125" runat="server" CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rfvStartDate" runat="server" ControlToValidate="txtStartDate"
                                                            ErrorMessage="Please Enter Start Date" ValidationGroup="REQRequisitionItemEntity"
                                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="revStartDate" runat="server" ControlToValidate="txtStartDate"
                                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                                            ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                                    </div>
                                                </td>
                                                <td class="i">
                                                    <div class="TableFormValidatorContent">
                                                        <asp:TextBox ID="txtEndDate" Width="125" runat="server" CssClass="ktiDateTextBoxListview"></asp:TextBox>
                                                        <asp:RequiredFieldValidator ID="rfvEndDate" runat="server" ControlToValidate="txtEndDate"
                                                            ErrorMessage="Please Enter End Date" ValidationGroup="REQRequisitionItemEntity"
                                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                        <asp:RegularExpressionValidator ID="revEndDate" runat="server" ControlToValidate="txtEndDate"
                                                            Display="Dynamic" ErrorMessage="Invalide Format (Ex:07-25-2010)" ValidationExpression="(0[1-9]|[12][0-9]|3[01])[- /.](0[1-9]|1[012])[- /.](19|20)\d\d$"
                                                            ValidationGroup="REQRequisitionItemEntity"></asp:RegularExpressionValidator>
                                                    </div>
                                                </td>
                                                <td class="i">
                                                    <asp:TextBox ID="txtRemarksLV" runat="server" CssClass="ktiTextBoxListview" Style="width: 120px;"></asp:TextBox>
                                                </td>
                                                <td class="i">
                                                    <div class="TableFormContent">
                                                        <asp:DropDownList ID="ddlIssueAssignTypeIDLV" CssClass="ktiSelect" ClientIDMode="Static"
                                                            runat="server" ValidationGroup="REQRequisitionItemEntity" Width="100">
                                                        </asp:DropDownList>
                                                    </div>
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
                                <asp:ObjectDataSource ID="odsResourceEmployee_Custom" runat="server" SelectMethod="GetPagedData"
                                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.ResourceEmployee_CustomDataSource"
                                    SortParameterName="sortExpression" OnSelecting="odsResourceEmployee_Custom_Selecting">
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
                    <div id="ResourceTool" style="display: inline-block;">
                        <div style="float: left; width: 275px; display: table;">
                            <kti:BayConstructionToolTreeView ID="treeConstructionTool" runat="server" ShowCheckBoxesInAllNodes="true">
                            </kti:BayConstructionToolTreeView>
                        </div>
                    </div>
                    <div id="IssueUpload">
                        <div>
                            <div id="Div2" class="TableRow" style="text-align: left;" runat="server">
                                <asp:Label ID="Label1" EnableViewState="false" runat="server"></asp:Label>
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
                            <div class="listContentTitle">
                                Uploaded Document List
                            </div>
                            <div>
                                <div class="lv-c">
                                    <asp:ListView ID="lvOTIssueUploadInfo" runat="server" DataSourceID="odsOTIssueUploadInfo"
                                        OnItemCommand="lvOTIssueUploadInfo_ItemCommand">
                                        <LayoutTemplate>
                                            <table class="lv" cellpadding="0" cellspacing="0">
                                                <tr class="h">
                                                    <td class="rp">
                                                        &nbsp;
                                                    </td>
                                                    <td class="hi" style="width: 500px;">
                                                        <%--<asp:LinkButton CssClass="ktiListViewHeaderText" runat="server" ID="lnkSortByOriginalFileName" CommandName="Sort" Text="Original File Name" CommandArgument="OriginalFileName"/>--%>
                                                        Original File Name
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
                                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue Upload Info?')"
                                                        CommandArgument='<%#Eval("IssueUploadInfoID")%>' UniqueKey="OTIssueUploadInfo_lvOTIssueUploadInfo_Delete_key" />
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
                                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete O TIssue Upload Info?')"
                                                        CommandArgument='<%#Eval("IssueUploadInfoID")%>' UniqueKey="OTIssueUploadInfo_lvOTIssueUploadInfo_Delete_key" />
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
                                <asp:ObjectDataSource ID="odsOTIssueUploadInfo" runat="server" SelectMethod="GetPagedData"
                                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.OTIssueUploadInfoDataSource"
                                    SortParameterName="sortExpression" OnSelecting="odsOTIssueUploadInfo_Selecting">
                                    <SelectParameters>
                                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                                        <asp:Parameter Name="pageSize" Type="Int32" />
                                        <asp:Parameter Name="sortExpression" Type="String" />
                                        <asp:Parameter Name="filterExpression" Type="String" />
                                    </SelectParameters>
                                </asp:ObjectDataSource>
                            </div>
                        </div>
                        <triggers>
         <asp:AsyncPostBackTrigger ControlID="btnClick" EventName="Click" />
     </triggers>
                        <script type="text/javascript">
                            function uploadError(sender, args) {
                            }
                            function uploadComplete(sender, args) {
                                var btnClick = document.getElementById("btnClick");
                                btnClick.click();
                            }
                        </script>
                    </div>
                    <div id="RoomAllocate">
                        <div>
                        <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: left;">
                                    Project&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlProjectID" OnSelectedIndexChanged="ddlProjectID_SelectedIndexChanged" CssClass="ktiSelect" ClientIDMode="Static"
                                        AutoPostBack="true" runat="server" ValidationGroup="BDProjectUnitLocationEntity"
                                        Width="234">
                                    </asp:DropDownList>
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            <asp:Panel ID="pnlProjectFloor" runat="server">
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: left;">
                                    Project Floor&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlProjectFloorID" OnSelectedIndexChanged="ddlProjectFloorID_SelectedIndexChanged" CssClass="ktiSelect" ClientIDMode="Static"
                                        AutoPostBack="true" runat="server" ValidationGroup="BDProjectUnitLocationEntity"
                                        Width="234">
                                    </asp:DropDownList>
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            </asp:Panel>
                            <asp:Panel ID="pnlProjectFloorUnit" runat="server">
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: left;">
                                    Project Floor Unit&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlProjectFloorUnitID" OnSelectedIndexChanged="ddlProjectFloorUnitID_SelectedIndexChanged" CssClass="ktiSelect" ClientIDMode="Static"
                                        runat="server" ValidationGroup="BDProjectUnitLocationEntity" Width="234" AutoPostBack="true">
                                    </asp:DropDownList>
                                </div>
                                <div class="TableFormValidatorContent">
                                </div>
                            </div>
                            </asp:Panel>
                            <asp:Panel ID="pnlProjectFlooorUnitLocationCategory" runat="server">
                            <div class="TableRow" style="width: 100;">
                                <div class="TableFormLeble" style="text-align: left;">
                                    Location Category&nbsp;:
                                </div>
                                <div class="TableFormContent">
                                    <asp:DropDownList ID="ddlFloorUnitLocationCategoryID"  CssClass="ktiSelect" ClientIDMode="Static"
                                        runat="server" ValidationGroup="BDProjectUnitLocationEntity" Width="234">
                                    </asp:DropDownList>
                                </div>
                                <div class="TableFormValidatorContent">
                                    <asp:RequiredFieldValidator ID="rfvFloorUnitLocationCategoryID" runat="server" ControlToValidate="ddlFloorUnitLocationCategoryID"
                                        ErrorMessage="Please Select Floor Unit Location Category" ValidationGroup="BDProjectUnitLocationEntity"
                                        EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                </div>
                            </div>
                            </asp:Panel>
                        </div>
                    </div>
                </div>
            </div>
            <div class="TableFormContent">
                <kti:SecureButton ID="btnSubmit" runat="server" Text="Save" UniqueKey="OTIssueAssignedResourceControl_Submit_key"
                    OnClick="btnSave_Click" />
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
