<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 02-Sep-2012, 12:46:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="KBUserTree.ascx.cs" Inherits="Bay.ERP.Web.UI.KBUserTreeControl" %>
<%@ Register Assembly="ASTreeView" Namespace="Geekees.Common.Controls" TagPrefix="ct" %>
<%@ Register Src="~/Controls/Common/CMNERPComment.ascx" TagName="CMNERPCommentEntity"
    TagPrefix="uc" %>
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit.HTMLEditor"
    TagPrefix="HTMLEditor" %>
<link href="<%=ResolveUrl("~/Scripts/ASTreeview179Custom/astreeview/astreeview.css")%>"
    type="text/css" rel="stylesheet" />
<link href="<%=ResolveUrl("~/Scripts/ASTreeview179Custom/contextmenu/contextmenu.css")%>"
    type="text/css" rel="stylesheet" />
<script src="<%=ResolveUrl("~/Scripts/ASTreeview179Custom/astreeview/astreeview_packed.js")%>"
    type="text/javascript"></script>
<script src="<%=ResolveUrl("~/Scripts/ASTreeview179Custom/contextmenu/contextmenu_packed.js")%>"
    type="text/javascript"></script>
<link href="../Styles/DMS.css" media="screen" rel="stylesheet" type="text/css" />
<style type="text/css">
    .box
    {
        background-image: url("../Images/KB/kb-box.png");
        background-position: left top;
        background-repeat: no-repeat;
        display: table;
        float: left;
        height: 246px;
        margin-left: -30px;
        margin-bottom: -92px;
        width: 187px; /*margin-bottom: 10px;*/ /*margin-left: 10px;*/
    }
    .box img
    {
        border: 0 solid Gray;
        height: 100px;
        margin: 12px 12px 4px;
        width: 110px;
    }
    .g-button-submit
    {
        background-color: #4D90FE;
        background-image: -webkit-linear-gradient(top, #4D90FE, #4787ED);
        border: 1px solid #3079ED;
        color: #FFFFFF;
        text-shadow: rgba(0, 0, 0, 0.0980392) 0 1px;
        font-size: 16px;
    }
    .g-button-submit:Hover
    {
        background-color: #4D90FE;
        background-image: -webkit-linear-gradient(top, #4D90FE, #4787ED);
        border: 1px solid #3079ED;
        color: #FFFFFF;
        text-shadow: rgba(0, 0, 0, 0.0980392) 0 1px;
        font-size: 16px;
        box-shadow: 0 1px 1px 1px rgba(0,0,0,0.2);
    }
    .title
    {
        font-size: 24px;
        line-height: 24px;
    }
    .tagKeyword
    {
        font-weight: bold;
    }
    
    /* Rating */
    .ratingStar
    {
        font-size: 0pt;
        width: 13px;
        height: 20px;
        margin: 0px;
        padding: 0px;
        cursor: pointer;
        display: block;
        background-repeat: no-repeat;
    }
    .filledRatingStar
    {
        background-image: url(../Images/FilledStar.png);
    }
    .emptyRatingStar
    {
        background-image: url(../Images/EmptyStar.png);
    }
    .savedRatingStar
    {
        background-image: url(../Images/SavedStar.png);
    }
</style>
<script type="text/javascript">

    //parameter must be "val"
    function deletedHandler(val) {

        document.getElementById("<%=txtIDContainer.ClientID %>").value = val;
        document.getElementById("<%=btnPostBackTrigger.ClientID %>").click();
    }

    //parameter must be "elem" and "newParent"
    function dndCompletedHandler(elem, newParent) {
        var curNodeValue = elem.getAttribute("treeNodeValue");
        var newParentValue = newParent.getAttribute("treeNodeValue");

        //set to the hidden fields
        document.getElementById('<%=txtCurrentNode.ClientID %>').value = curNodeValue;
        document.getElementById('<%=txtNewParentNode.ClientID %>').value = newParentValue;

        //trigger the PostBack
        document.getElementById('<%=btnPostBackDNDTrigger.ClientID %>').click();
    }

    //parameter must be "elem"
    function editedHandler(elem) {
        document.getElementById("<%=txtIDEditedContainer.ClientID %>").value = elem.getAttribute("treeNodeValue");
        document.getElementById('<%=btnPostBackEditedTrigger.ClientID %>').click();
    }
    function addedHandler(elem) {
        var message = '';
        var result = true;

        var aTag = elem.getElementsByTagName('A')[0];

        if (aTag.getAttribute('addfailed') == 'true') {
            alert(aTag.innerHTML);
            return false;
        }
        else {
            message = (">>add completed. [Node]"
        + elem.getAttribute("treeNodeValue") + "<br />");
        }
        document.getElementById("").innerHTML
    += message;
        return result;
    }



    //    function addedHandler(elem) { alert(elem.getAttribute("treeNodeValue")); }

    //    //        function addedHandler(val) {

    //    //            document.getElementById("<%=txtIDAddedContainer.ClientID %>").value = val;
    //    //            document.getElementById("<%=btnPostBackAddedTrigger.ClientID %>").click();
    //    //        }
</script>
<%--<script type="text/javascript">
    function toggleCheckBoxes(source) {

            var listView = document.getElementById('<%= lvDMSDocumentNode.FindControl("table1").ClientID %>');

            if (listView != null) {
                for (var i = 0; i < listView.rows.length; i++) {
                    var inputs = listView.rows[i].getElementsByTagName('input');
                    for (var j = 0; j < inputs.length; j++) {
                        if (inputs[j].type == "checkbox")
                            inputs[j].checked = source.checked;
                    }
                }
            }
        }
    }  
</script>--%>
<%--<script type="text/javascript">
    function toggleCheckBoxes(source) {

            var listView = document.getElementById('<%= lvDMSDocumentNode.FindControl("table1").ClientID %>');

            if (listView != null) {
                for (var i = 0; i < listView.rows.length; i++) {
                    var inputs = listView.rows[i].getElementsByTagName('input');
                    var labels = listView.rows[i].getElementsByTagName('label');
                    for (var j = 0; j < inputs.length; j++) {
                        if (inputs[j].type == "checkbox")
                        if(inputs[j].checked == true){
                            inputs[j].checked = source.checked;
                            if(labels[j]=="Yes") {
                                var btn = document.getElementById('<%= btnAddStar.ClientID %>');
                                btn.visible = false;
                            }
                            }
                    }
                }
            }
        }
</script>--%>
<script type="text/javascript">
    function toggle() {
        var ele = document.getElementById("mt_PageHeaderx123x");
        if (ele.style.display == "block") {
            ele.style.display = "none";
            text.innerHTML = "Show";
        }
        else {
            ele.style.display = "block";
            text.innerHTML = "Hide";
        }
    }

    function imgError(me) {
        // place here the alternative image
        var AlterNativeImg = "../Images/Missing.png";

        // to avoid the case that even the alternative fails        
        if (AlterNativeImg != me.src)
            me.src = AlterNativeImg;
    }

</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnClick" EventName="Click" />
    </Triggers>
    <ContentTemplate>
        <div>
            <div style="display: none;">
                <asp:Button ID="btnPostBackTrigger" runat="server" OnClick="btnPostBackTrigger_Click" />
                <asp:TextBox ID="txtIDContainer" runat="server"></asp:TextBox>
            </div>
            <div style="display: none;">
                <asp:Button ID="btnPostBackEditedTrigger" runat="server" OnClick="btnPostBackEditedTrigger_Click" />
                <asp:TextBox ID="txtIDEditedContainer" runat="server"></asp:TextBox>
            </div>
            <div style="display: none">
                <asp:TextBox ID="txtCurrentNode" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtNewParentNode" runat="server"></asp:TextBox>
                <asp:Button ID="btnPostBackDNDTrigger" runat="server" OnClick="btnPostBackDNDTrigger_Click" />
            </div>
            <div style="display: none;">
                <asp:Button ID="btnPostBackAddedTrigger" runat="server" OnClick="btnPostBackAddedTrigger_Click" />
                <asp:TextBox ID="txtIDAddedContainer" runat="server"></asp:TextBox>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left; font-size: 15px;">
                    Wiki&nbsp;
                </div>
                <div class="TableFormContent" style="padding-left: 169px;">
                    <asp:TextBox ID="txtSearch" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                        ValidationGroup="KBUserTreeEntity" Width="460" />
                    <asp:ImageButton ID="btnSearchPopup" runat="server" ImageUrl="~/Images/DownArrow.png"
                        Height="20" Width="20" ClientIDMode="Static" />
                    <asp:Button ID="btnSearch" CssClass="g-button-submit" runat="server" Text="Search"
                        OnClick="btnSearch_Click" ClientIDMode="Static" />
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    <kti:SecureButton ID="btnCreate" CssClass="Panel-button" runat="server" Text="Create Node"
                        UniqueKey="KBUserTreeControl_Create_key" ClientIDMode="Static" />
                </div>
                <div class="TableFormContent" style="float: left; padding-left: 170px;">
                    <panel id="pnlOption">
                    <a id="displayText" href="javascript:toggle();" style="display:none;">Hide</a>
                    <kti:SecureButton ID="btnCreatePost" CssClass="Panel-button" runat="server" Text="Create Page" UniqueKey="KBUserTreeControl_CreatePost_key" OnClick="btnCreatePost_Click" Visible="false"
                        ClientIDMode="Static" />
                    <kti:SecureButton ID="btnArchiveAndUnshare" CssClass="Panel-button" runat="server" Text="Archive & Unshare" UniqueKey="KBUserTreeControl_ArchiveAndUnshare_key" Visible="false" OnClick="btnArchiveAndUnshare_Click" OnClientClick="return confirm('This Will Remove All Shared Info, Are you Sure?')"
                        ClientIDMode="Static" />
                    <kti:SecureButton ID="btnShareAndPermission" CssClass="Panel-button" runat="server" Text="Share & Permission" UniqueKey="KBUserTreeControl_ShareAndPermission_key" Visible="false" OnClick="btnShareAndPermission_Click"
                        ClientIDMode="Static" />
                        <kti:SecureButton ID="btnMarkNotinUse" CssClass="Panel-button" runat="server" Text="Mark Not in Use" UniqueKey="KBUserTreeControl_MarkNotinUse_key" OnClick="btnMarkNotinUse_Click" Visible="false" OnClientClick="return confirm('This Will Remove All Shared Info, Are you Sure?')"
                        ClientIDMode="Static" />
                        <kti:SecureButton ID="btnTransferOwnership" CssClass="Panel-button" runat="server" Text="Transfer Ownership" UniqueKey="KBUserTreeControl_TransferOwnership_key" OnClick="btnTransferOwnership_Click" Visible="false" OnClientClick="return confirm('Are you sure to transfer the Ownership to you?')"
                        ClientIDMode="Static" />
                        <kti:SecureButton ID="btnCanShare" CssClass="Panel-button" runat="server" Text="Can Share" UniqueKey="KBUserTreeControl_CanShareStar_key" Visible="false" OnClick="btnCanShare_Click"
                        ClientIDMode="Static" />
                         <kti:SecureButton ID="btnUploadInfo" CssClass="Panel-button" runat="server" Text="Upload Info" UniqueKey="KBUserTreeControl_UploadInfo_key" OnClick="btnUploadInfo_Click" Visible="false"
                        ClientIDMode="Static" />
                        <%--<kti:SecureButton ID="btnUploadInfo" CssClass="Panel-button" runat="server" Text="Upload Info" UniqueKey="KBUserTreeControl_UploadInfo_key" Visible="false"
                        ClientIDMode="Static" />--%>
                        </panel>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div id="mt_PageHeaderxx" style="float: left; width: 300px; display: block;">
                <div>
                    <div style="float: left; width: 275px;">
                        <div class="contentSubTittle">
                        </div>
                    </div>
                    <div style="float: left; width: 100px; padding: 0px 10px 0px 14px;">
                    </div>
                    <div style="clear: both;">
                    </div>
                </div>
                <div style="width: 375px;">
                    <ct:ASTreeView ID="astvMyTree" runat="server" BasePath="~/Scripts/ASTreeview179/astreeview/"
                        EnableRoot="false" EnableCheckbox="false" EnableContextMenu="true" EnableDragDrop="true"
                        OnOnSelectedNodeChanged="astvMyTree_OnSelectedNodeChanged" EnableOnNodeAddedScriptReturn="true"
                        AutoPostBack="true" EnableTreeLines="false" EnableNodeIcon="true" EnableCustomizedNodeIcon="true"
                        OnNodeDeletedScript="deletedHandler(val)" OnNodeDragAndDropCompletedScript="dndCompletedHandler( elem, newParent )"
                        OnNodeEditedScript="editedHandler(elem)" OnNodeAddedScript="addedHandler(elem)"
                        EnableDebugMode="false" EnableContextMenuAdd="false" />
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 790px; padding-left: 5px;">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <br />
                <br />
                <asp:Panel ID="pnlCreatePost" runat="server" Visible="false">
                    <div class="TableRow" style="width: 100;">
                        Page Title
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtTitle">
                                Enter Title</label>
                            <asp:TextBox ID="txtTitle" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                Font-Size="24" Height="30" ValidationGroup="KBUserTreeEntity" Width="765" />
                            <span class="RequiredField">*</span>
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvTitle" runat="server" ControlToValidate="txtTitle"
                                ErrorMessage="Please Enter Title" ValidationGroup="KBUserTreeEntity" EnableViewState="False"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        Body
                        <div class="TableFormContent">
                            <HTMLEditor:Editor runat="server" OnContentChanged="ContentChanged" ID="txtDescription"
                                Height="300px" AutoFocus="true" Width="100%" />
                        </div>
                        <div class="TableFormValidatorContent">
                            <asp:RequiredFieldValidator ID="rfvDescription" runat="server" ControlToValidate="txtDescription"
                                ErrorMessage="Please Enter Description" ValidationGroup="KBUserTreeEntity" EnableViewState="False"
                                Display="Dynamic"></asp:RequiredFieldValidator>
                        </div>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        Tags
                        <div class="TableFormContent waterMarkContainer">
                            <label class="watermarkLabel" for="txtTitle">
                                Enter Tag Keyword</label>
                            <asp:TextBox TextMode="SingleLine" CssClass="ktiTextBox" Width="765" ClientIDMode="Static"
                                ID="txtTagKeyword" runat="server" ValidationGroup="KBUserTreeEntity" />
                        </div>
                        <div class="TableFormValidatorContent">
                        </div>
                    </div>
                     <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: left;">
                        Make It Public&nbsp;:
                    </div>
                    <div class="TableFormContent" style="padding-top:5px;">
                        <asp:CheckBox ID="chkIsMakeItPublic" runat="server" ClientIDMode="Static" ValidationGroup="KBUserTreeEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                    <div class="TableRow" style="text-align: center;">
                        <div class="TableFormContent">
                            <kti:SecureButton ID="btnSavePost" ValidationGroup="KBUserTreeEntity" OnClick="btnSavePost_Click"
                                runat="server" Text="Save Page" UniqueKey="KBUserTreeControl_Submit_key" />
                                <asp:Button ID="btnPreview" OnClick="btnPreview_Click"
                                runat="server" Text="Preview"/>
                        </div>
                        <div class="TableFormContent">
                        </div>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlKBSearchView" runat="server" Visible="false">
                    <div>
                        <div class="lv-c">
                            <asp:ListView ID="lvKBUserTree" runat="server" DataSourceID="odsKBUserTree">
                                <LayoutTemplate>
                                    <table class="lv" cellpadding="0" cellspacing="0">
                                        <tr class="h">
                                            <td class="rp">
                                                &nbsp;
                                            </td>
                                            <td class="hi">
                                                Title
                                            </td>
                                            <td class="hi" style="display: none;">
                                                Description
                                            </td>
                                            <td class="hi">
                                                Tag Keyword
                                            </td>
                                            <td class="hi">
                                                Created
                                            </td>
                                            <td class="hi">
                                                Create Date
                                            </td>
                                            <td class="hi">
                                                Owner
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
                                            <%# Eval("Title")%>
                                        </td>
                                        <td class="i" style="display: none;">
                                            <%# Eval("Description")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("TagKeyword")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("CreatedByMemberFullName")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("OwnerMemberFullName")%>
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
                                            <%# Eval("Title")%>
                                        </td>
                                        <td class="i" style="display: none;">
                                            <%# Eval("Description")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("TagKeyword")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("CreatedByMemberFullName")%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("CreateDate") != null ? ((DateTime)Eval("CreateDate")).ToString("mm-dd-yyyy") : ""%>
                                        </td>
                                        <td class="i">
                                            <%# Eval("OwnerMemberFullName")%>
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
                        <asp:ObjectDataSource ID="odsKBUserTree" runat="server" SelectMethod="GetPagedData"
                            SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                            StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.KBUserTree_DetailedDataSource"
                            SortParameterName="sortExpression" OnSelecting="odsKBUserTree_Selecting">
                            <SelectParameters>
                                <asp:Parameter Name="startRowIndex" Type="Int32" />
                                <asp:Parameter Name="pageSize" Type="Int32" />
                                <asp:Parameter Name="sortExpression" Type="String" />
                                <asp:Parameter Name="filterExpression" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </div>
                </asp:Panel>
                <asp:Panel ID="pnlKBDocumentView" runat="server" Visible="false">
                    <div>
                        <div class="" style="width: 100;">
                            <%--<div class="TableFormLeble" style="text-align: right;">
                                Title&nbsp;:
                            </div>--%>
                            <div class="title">
                                <asp:Label ID="lblTitle" CssClass="title" runat="server"></asp:Label>
                                <span style="float: right;">
                                    <ajaxToolkit:Rating ID="ThaiRating" runat="server" BehaviorID="RatingBehavior1" CurrentRating="0"
                                        MaxRating="1" StarCssClass="ratingStar" WaitingStarCssClass="savedRatingStar"
                                        FilledStarCssClass="filledRatingStar" EmptyStarCssClass="emptyRatingStar" OnChanged="ThaiRating_Changed" 
                                        Style="float: left;" />
                                </span>
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <%-- <div class="TableFormLeble" style="text-align: right;">
                                Description&nbsp;:
                            </div>--%>
                            <div class="TableFormContent">
                                <p>
                                    <asp:Literal ID="lblDescription" runat="server"></asp:Literal></p>
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <%-- <div class="TableFormLeble" style="text-align: right;">
                                Tag Keyword&nbsp;:
                            </div>--%>
                            <div class="tagKeyword">
                                <asp:Label ID="lblTagKeyword" Font-Bold="true" runat="server"></asp:Label>
                            </div>
                        </div>
                    </div>
                    <br />
                    <br />
                    <br />
                    <div style="float: left; padding-left: 30px; width: 100%">
                        <div class="lv-c-c">
                            <asp:ListView ID="lvKBUserTreeUploadInfo" runat="server" DataSourceID="odsKBUserTreeUploadInfo">
                                <LayoutTemplate>
                                    <table class="lv" cellpadding="0" cellspacing="0">
                                        <tr runat="server" id="itemPlaceholder">
                                        </tr>
                                    </table>
                                </LayoutTemplate>
                                <ItemTemplate>
                                    <div class="box">
                                        <div>
                                            <asp:HyperLink ID="hypProductImg" runat="server" title="Categories">
                                                <asp:Image ID="img" runat="server" ImageUrl='<%# Eval("Path")%>' AlternateText='<%# Eval("OriginalFileName")%>'
                                                    onerror="imgError(this)" ToolTip='<%# Eval("OriginalFileName")%>' />
                                            </asp:HyperLink>
                                        </div>
                                        <div class="name">
                                            <asp:HyperLink ID="hypUserTreeUploadFile" runat="server" title="Uploaded File" NavigateUrl='<%# Eval("Path")%>'
                                                Text='<%# Eval("OriginalFileName")%>' Target="_blank">
                                            </asp:HyperLink>
                                        </div>
                                    </div>
                                </ItemTemplate>
                            </asp:ListView>
                        </div>
                        <asp:ObjectDataSource ID="odsKBUserTreeUploadInfo" runat="server" SelectMethod="GetPagedData"
                            SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                            StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.KBUserTreeUploadInfoDataSource"
                            SortParameterName="sortExpression" OnSelecting="odsKBUserTreeUploadInfo_Selecting">
                            <SelectParameters>
                                <asp:Parameter Name="startRowIndex" Type="Int32" />
                                <asp:Parameter Name="pageSize" Type="Int32" />
                                <asp:Parameter Name="sortExpression" Type="String" />
                                <asp:Parameter Name="filterExpression" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </div>
                    <br />
                    <br />
                    <div style="float: left; width: 100%;">
                        <uc:CMNERPCommentEntity ID="ucCMNERPCommentEntity" runat="server" />
                    </div>
                    <br />
                    <div style="float: left; width: 100%; overflow: hidden; padding-left: 10px;">
                        <div style="overflow: hidden;">
                            <asp:ListView ID="lvKBUserTreeModifiedHistory" runat="server" DataSourceID="odsKBUserTreeModifiedHistory">
                                <LayoutTemplate>
                                    <table cellpadding="0" cellspacing="0">
                                        <tr runat="server" id="itemPlaceholder">
                                        </tr>
                                        <tr style="display: none;">
                                            <td colspan="100%">
                                                <div class="lv-FooterContainer">
                                                    <div class="lv-Footer">
                                                        <asp:DataPager ID="dpListView" runat="server" PageSize="50">
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
                                        <td style="padding-bottom: 5px;">
                                            <%# Eval("CreatedByEmployeeID")%>&nbsp;<%# Eval("ModifiedDate") != null ? ((DateTime)Eval("ModifiedDate")).ToString("mm-dd-yyyy") : ""%>&nbsp;From&nbsp;<%# Eval("IP")%>&nbsp;<asp:HyperLink
                                                ID="hypSeeHistory" runat="server" Text="See History"></asp:HyperLink>
                                        </td>
                                    </tr>
                                </ItemTemplate>
                            </asp:ListView>
                        </div>
                        <asp:ObjectDataSource ID="odsKBUserTreeModifiedHistory" runat="server" SelectMethod="GetPagedData"
                            SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                            StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.KBUserTreeModifiedHistoryDataSource"
                            SortParameterName="sortExpression" OnSelecting="odsKBUserTreeModifiedHistory_Selecting">
                            <SelectParameters>
                                <asp:Parameter Name="startRowIndex" Type="Int32" />
                                <asp:Parameter Name="pageSize" Type="Int32" />
                                <asp:Parameter Name="sortExpression" Type="String" />
                                <asp:Parameter Name="filterExpression" Type="String" />
                            </SelectParameters>
                        </asp:ObjectDataSource>
                    </div>
                    <br />
                    <div style="clear: both;">
                    </div>
                </asp:Panel>
                <div class="TableRow" style="text-align: center;">
                        <div class="TableFormContent">
                          &nbsp;
                        </div>
                        <br />
                        <div class="TableFormContent" runat="server" id="dvAdditionalInfo" visible="false">
                              <asp:LinkButton ID="hypUploadInfo" Text="Upload Info" runat="server" CssClass="hypTableFormLeble"></asp:LinkButton>
                            <br />
                            <br />
                            <asp:LinkButton ID="lnkShareInfo" Text="Share Info" runat="server" CssClass="hypTableFormLeble"></asp:LinkButton>
                        </div>
                    </div>
            </div>
            <ajaxToolkit:ModalPopupExtender ID="Panel2_ModalPopupExtender" runat="server" PopupControlID="Panel2"
                DynamicServicePath="" Enabled="True" TargetControlID="btnCreate" OkControlID="lnkTargetPopup"
                CancelControlID="btnPopupCancel" BackgroundCssClass="modalBackground">
            </ajaxToolkit:ModalPopupExtender>
            <div>
                <asp:Panel ID="Panel2" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                    <div class="modalPanelBackground">
                        <br />
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: left;">
                                &nbsp;
                            </div>
                            <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                                <asp:Button ID="btnPopupClose" CssClass="Panel-button" runat="server" Text="X"></asp:Button>
                            </div>
                        </div>
                        <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                            padding-left: 10px;">
                            <tr>
                                <th rowspan="3" class="sized">
                                    <asp:Image ID="Image1" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
                                        Width="20" Height="300" AlternateText="" />
                                </th>
                                <th class="topleft">
                                </th>
                                <td class="tbl-border-top">
                                    &nbsp;
                                </td>
                                <th class="topright">
                                </th>
                                <th rowspan="3" class="sized">
                                    <asp:Image ID="Image2" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
                                        Width="20" Height="300" AlternateText="" />
                                </th>
                            </tr>
                            <tr>
                                <td class="tbl-border-left">
                                </td>
                                <td>
                                    <div class="table-content" style="width: 500px;">
                                        <div class="page-content">
                                            <h1>
                                                Create New Node</h1>
                                            <div>
                                                <div class="TableRow" style="width: 500px;">
                                                    <div class="TableFormLeble" style="text-align: left;">
                                                        &nbsp;
                                                    </div>
                                                    <div class="TableFormContent" style="padding-top: 10px;">
                                                        <asp:Label ID="Label1" runat="server" Font-Bold="true"></asp:Label>
                                                    </div>
                                                </div>
                                                <div class="TableRow" style="width: 100;">
                                                    <div class="TableFormLeble" style="text-align: right;">
                                                        Name&nbsp;:
                                                    </div>
                                                    <div class="TableFormContent waterMarkContainer">
                                                        <label class="watermarkLabel" for="txtName">
                                                            Enter Name</label>
                                                        <asp:TextBox ID="txtName" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                                            ValidationGroup="DMSDocumentNodeEntity" Width="230" />
                                                        <span class="RequiredField">*</span>
                                                    </div>
                                                    <div class="TableFormValidatorContent">
                                                        <asp:RequiredFieldValidator ID="rfvName" runat="server" ControlToValidate="txtName"
                                                            ErrorMessage="Please Enter Name" ValidationGroup="DMSDocumentNodeEntity" EnableViewState="False"
                                                            Display="Dynamic"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <br />
                                                <div>
                                                    N.B. This Tree is shared amongs the company.<br />
                                                    Please Create Node Carefully with meaningful names according to the SOP
                                                </div>
                                                <div class="TableRow" style="text-align: center;">
                                                    <div class="TableFormLeble">
                                                        &nbsp;</div>
                                                    <div class="TableFormContent">
                                                        <asp:LinkButton ID="lnkTargetPopup" runat="server"></asp:LinkButton>
                                                        <kti:SecureButton ID="btnSubmit" CssClass="Panel-button" ValidationGroup="DMSDocumentNodeEntity"
                                                            OnClick="btnSave_Click" runat="server" Text="Create" UniqueKey="DMSDocumentNodeControl_Submit_key" />
                                                        <kti:SecureButton ID="btnPopupCancel" CssClass="Panel-button" runat="server" Text="Cancel" />
                                                    </div>
                                                </div>
                                            </div>
                                        </div>
                                        <div class="quick-links">
                                        </div>
                                        <div class="clear">
                                        </div>
                                    </div>
                                </td>
                                <td class="tbl-border-right">
                                </td>
                            </tr>
                            <tr>
                                <th class="sized bottomleft">
                                </th>
                                <td class="tbl-border-bottom">
                                    &nbsp;
                                </td>
                                <th class="sized bottomright">
                                </th>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
            </div>
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtender1" runat="server" PopupControlID="Panel1"
                DynamicServicePath="" Enabled="True" TargetControlID="lnkShareInfo" OkControlID="lnkSharedTargetPopup"
                CancelControlID="btnSharedPopupCancel" BackgroundCssClass="modalBackground">
            </ajaxToolkit:ModalPopupExtender>
            <div>
                <asp:Panel ID="Panel1" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                    <div class="modalPanelBackground">
                        <br />
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: left;">
                                &nbsp;
                            </div>
                            <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                                <asp:Button ID="Button1" CssClass="Panel-button" runat="server" Text="X"></asp:Button>
                            </div>
                        </div>
                        <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                            padding-left: 10px;">
                            <tr>
                                <th rowspan="3" class="sized">
                                    <asp:Image ID="Image3" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
                                        Width="20" Height="300" AlternateText="" />
                                </th>
                                <th class="topleft">
                                </th>
                                <td class="tbl-border-top">
                                    &nbsp;
                                </td>
                                <th class="topright">
                                </th>
                                <th rowspan="3" class="sized">
                                    <asp:Image ID="Image4" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
                                        Width="20" Height="300" AlternateText="" />
                                </th>
                            </tr>
                            <tr>
                                <td class="tbl-border-left">
                                </td>
                                <td>
                                    <div class="table-content" style="width: 500px; max-height: 300px; overflow-y: scroll;">
                                        <div class="page-content">
                                            <h1>
                                                Shared Info</h1>
                                            <div>
                                                <div class="TableRow" style="width: 500px;">
                                                    <div class="TableFormLeble" style="text-align: left;">
                                                        &nbsp;
                                                    </div>
                                                    <div class="TableFormContent" style="padding-top: 10px;">
                                                        <asp:Label ID="lblSharedMsg" runat="server" Font-Bold="true"></asp:Label>
                                                    </div>
                                                </div>
                                                <div class="TableRow" style="width: 100;">
                                                    <div class="TableFormLeble" style="text-align: right;">
                                                        Shared To&nbsp;:
                                                    </div>
                                                    <div class="TableFormContent">
                                                        <asp:DropDownList ID="ddlSharedGivenToEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                                                            runat="server" ValidationGroup="KBUserTreeSharedEntity" Width="234">
                                                        </asp:DropDownList>
                                                        <span class="RequiredField">*</span>
                                                    </div>
                                                    <div class="TableFormValidatorContent">
                                                        <asp:RequiredFieldValidator ID="rfvSharedGivenToEmployeeID" runat="server" ControlToValidate="ddlSharedGivenToEmployeeID"
                                                            ErrorMessage="Please Select Shared Given To Employee" ValidationGroup="KBUserTreeSharedEntity"
                                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <div class="TableRow" style="width: 100;">
                                                    <div class="TableFormLeble" style="text-align: right;">
                                                        Permission&nbsp;:
                                                    </div>
                                                    <div class="TableFormContent">
                                                        <asp:DropDownList ID="ddlUserTreePermissionID" CssClass="ktiSelect" ClientIDMode="Static"
                                                            runat="server" ValidationGroup="KBUserTreeSharedEntity" Width="234">
                                                        </asp:DropDownList>
                                                        <span class="RequiredField">*</span>
                                                    </div>
                                                    <div class="TableFormValidatorContent">
                                                        <asp:RequiredFieldValidator ID="rfvUserTreePermissionID" runat="server" ControlToValidate="ddlUserTreePermissionID"
                                                            ErrorMessage="Please Select User Tree Permission" ValidationGroup="KBUserTreeSharedEntity"
                                                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                                                    </div>
                                                </div>
                                                <br />
                                                <div class="TableRow" style="text-align: center;">
                                                    <div class="TableFormLeble">
                                                        &nbsp;</div>
                                                    <div class="TableFormContent">
                                                        <asp:LinkButton ID="lnkSharedTargetPopup" runat="server"></asp:LinkButton>
                                                        <asp:Button ID="btnAddShared" CssClass="Panel-button" OnClick="btnAddShared_Click"
                                                            runat="server" Text="Add" />
                                                        <asp:Button ID="btnSharedPopupCancel" CssClass="Panel-button" runat="server" Text="Cancel" />
                                                    </div>
                                                </div>
                                            </div>
                                            <div class="listContentTitle">
                                                Shared Info
                                            </div>
                                            <div>
                                                <div class="lv-c">
                                                    <asp:ListView ID="lvKBUserTreeShared" runat="server" DataSourceID="odsKBUserTreeShared"
                                                        OnItemCommand="lvKBUserTreeShared_ItemCommand">
                                                        <LayoutTemplate>
                                                            <table class="lv" cellpadding="0" cellspacing="0">
                                                                <tr class="h">
                                                                    <td class="hi">
                                                                        Shared Date
                                                                    </td>
                                                                    <td class="hi">
                                                                        Shared To
                                                                    </td>
                                                                    <td class="hi">
                                                                        Permission
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
                                                                <tr style="display: none;">
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
                                                                <td class="i">
                                                                    <%# Eval("SharedDateTime") != null ? ((DateTime)Eval("SharedDateTime")).ToString("dd-MM-yyyy") : ""%>
                                                                </td>
                                                                <td class="i">
                                                                    <%# Eval("SharedGivenToEmployeeFullName")%>
                                                                </td>
                                                                <td class="i">
                                                                    <%# Eval("KBMDUserTreeSharedPermissionName")%>
                                                                </td>
                                                                <td class="i" style="display: none;">
                                                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("UserTreeSharedID")%>'
                                                                        UniqueKey="KBUserTreeShared_lvKBUserTreeShared_Edit_key" />
                                                                </td>
                                                                <td class="i">
                                                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete K BUser Tree Shared?')"
                                                                        CommandArgument='<%#Eval("UserTreeSharedID")%>' UniqueKey="KBUserTreeShared_lvKBUserTreeShared_Edit_key" />
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
                                                                <td class="i">
                                                                    <%# Eval("SharedDateTime") != null ? ((DateTime)Eval("SharedDateTime")).ToString("dd-MM-yyyy") : ""%>
                                                                </td>
                                                                <td class="i">
                                                                    <%# Eval("SharedGivenToEmployeeFullName")%>
                                                                </td>
                                                                <td class="i">
                                                                    <%# Eval("KBMDUserTreeSharedPermissionName")%>
                                                                </td>
                                                                <td class="i" style="display: none;">
                                                                    <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                                        Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("UserTreeSharedID")%>'
                                                                        UniqueKey="KBUserTreeShared_lvKBUserTreeShared_Edit_key" />
                                                                </td>
                                                                <td class="i">
                                                                    <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                                        Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete K BUser Tree Shared?')"
                                                                        CommandArgument='<%#Eval("UserTreeSharedID")%>' UniqueKey="KBUserTreeShared_lvKBUserTreeShared_Edit_key" />
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
                                                <asp:ObjectDataSource ID="odsKBUserTreeShared" runat="server" SelectMethod="GetPagedData"
                                                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                                                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.KBUserTreeShared_DetailedDataSource"
                                                    SortParameterName="sortExpression" OnSelecting="odsKBUserTreeShared_Selecting">
                                                    <SelectParameters>
                                                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                                                        <asp:Parameter Name="pageSize" Type="Int32" />
                                                        <asp:Parameter Name="sortExpression" Type="String" />
                                                        <asp:Parameter Name="filterExpression" Type="String" />
                                                    </SelectParameters>
                                                </asp:ObjectDataSource>
                                            </div>
                                        </div>
                                        <div class="quick-links">
                                        </div>
                                        <div class="clear">
                                        </div>
                                    </div>
                                </td>
                                <td class="tbl-border-right">
                                </td>
                            </tr>
                            <tr>
                                <th class="sized bottomleft">
                                </th>
                                <td class="tbl-border-bottom">
                                    &nbsp;
                                </td>
                                <th class="sized bottomright">
                                </th>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
            </div>
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtenderSearch" runat="server" PopupControlID="Panel3"
                DynamicServicePath="" Enabled="True" TargetControlID="btnSearchPopup" OkControlID="lnkSearchTargetPopup"
                CancelControlID="btnSearchCancelPopup" BackgroundCssClass="modalBackground">
            </ajaxToolkit:ModalPopupExtender>
            <div>
                <asp:Panel ID="Panel3" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                    <div class="modalPanelBackground">
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: left;">
                                &nbsp;
                            </div>
                            <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                                <asp:Button ID="Button2" CssClass="Panel-button" runat="server" Text="X"></asp:Button>
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                Search&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:DropDownList ID="ddlSearchSelect" CssClass="ktiSelect" ClientIDMode="Static"
                                    runat="server" Width="234">
                                </asp:DropDownList>
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                Created / Owner&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtSearchCreated" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    Width="230" />
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                Title&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtSearchTitle" ClientIDMode="Static" CssClass="ktiTextBox" runat="server"
                                    Width="230" />
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                Has The Word&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtSearchDescription" ClientIDMode="Static" CssClass="ktiTextBox"
                                    runat="server" Width="230" />
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                Tag Keyword&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtSearchTagKeyword" ClientIDMode="Static" CssClass="ktiTextBox"
                                    runat="server" Width="230" />
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                Has Attachment&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:CheckBox ID="chkSearchHasAttachment" runat="server" ClientIDMode="Static" />
                            </div>
                            <div class="TableFormValidatorContent">
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: right;">
                                &nbsp;
                            </div>
                            <div class="TableFormContent">
                                <asp:LinkButton ID="lnkSearchTargetPopup" runat="server"></asp:LinkButton>
                                <asp:Button ID="btnSearchPopupSearch" CssClass="Panel-button" runat="server" Text="Search"
                                    OnClick="btnSearchPopupSearch_Click" />
                                <asp:Button ID="btnSearchCancelPopup" CssClass="Panel-button" runat="server" Text="Cancel" />
                            </div>
                        </div>
                    </div>
                </asp:Panel>
            </div>
            <ajaxToolkit:ModalPopupExtender ID="ModalPopupExtenderUploadInfo" runat="server"
                PopupControlID="Panel4" DynamicServicePath="" Enabled="True" TargetControlID="hypUploadInfo"
                OkControlID="lnkUploadPopupTarget" CancelControlID="btnUploadPopupOk" BackgroundCssClass="modalBackground">
            </ajaxToolkit:ModalPopupExtender>
            <div>
                <asp:Panel ID="Panel4" runat="server" Width="610" Height="470" BorderWidth="1" Style="display: none;">
                    <div class="modalPanelBackground">
                        <br />
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: left;">
                                &nbsp;
                            </div>
                            <div class="TableFormContent" style="text-align: right; padding-right: 14px;">
                                <asp:Button ID="Button3" CssClass="Panel-button" runat="server" Text="X"></asp:Button>
                            </div>
                        </div>
                        <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto;
                            padding-left: 10px;">
                            <tr>
                                <th rowspan="3" class="sized">
                                    <asp:Image ID="Image5" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
                                        Width="20" Height="300" AlternateText="" />
                                </th>
                                <th class="topleft">
                                </th>
                                <td class="tbl-border-top">
                                    &nbsp;
                                </td>
                                <th class="topright">
                                </th>
                                <th rowspan="3" class="sized">
                                    <asp:Image ID="Image6" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
                                        Width="20" Height="300" AlternateText="" />
                                </th>
                            </tr>
                            <tr>
                                <td class="tbl-border-left">
                                </td>
                                <td>
                                    <div class="table-content" style="width: 500px; max-height: 300px; overflow-y: scroll;">
                                        <div class="page-content">
                                            <h1>
                                                Upload File</h1>
                                            <div>
                                                <div class="TableRow" style="width: 500px;">
                                                    <div class="TableFormLeble" style="text-align: left;">
                                                        &nbsp;
                                                    </div>
                                                    <div class="TableFormContent" style="padding-top: 10px;">
                                                        <asp:Label ID="Label3" runat="server" Font-Bold="true"></asp:Label>
                                                    </div>
                                                </div>
                                                <div>
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
                                                        Upload File
                                                    </div>
                                                    <div>
                                                        <div class="lv-c">
                                                            <asp:ListView ID="lstKBUserTreeUploadInfoOperation" runat="server" DataSourceID="odsKBUserTreeUploadInfo"
                                                                OnItemCommand="lstKBUserTreeUploadInfoOperation_ItemCommand">
                                                                <LayoutTemplate>
                                                                    <table class="lv" cellpadding="0" cellspacing="0">
                                                                        <tr class="h">
                                                                            <td class="rp">
                                                                                &nbsp;
                                                                            </td>
                                                                            <td class="hi" style="width: 200px;">
                                                                                Original File Name
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
                                                                        <tr style="display:none;">
                                                                            <td colspan="100%">
                                                                                <div class="lv-FooterContainer">
                                                                                    <div class="lv-Footer">
                                                                                        <asp:DataPager ID="dpListView" runat="server" PageSize="45">
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
                                                                        <td class="i" style="display: none;">
                                                                            <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                                                Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("UserTreeUploadInfoID")%>'
                                                                                UniqueKey="KBUserTreeUploadInfo_lvKBUserTreeUploadInfo_Edit_key" />
                                                                        </td>
                                                                        <td class="i">
                                                                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                                                Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete K BUser Tree Upload Info?')"
                                                                                CommandArgument='<%#Eval("UserTreeUploadInfoID")%>' UniqueKey="KBUserTreeUploadInfo_lvKBUserTreeUploadInfo_Edit_key" />
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
                                                                        <td class="i" style="display: none;">
                                                                            <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                                                Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("UserTreeUploadInfoID")%>'
                                                                                UniqueKey="KBUserTreeUploadInfo_lvKBUserTreeUploadInfo_Edit_key" />
                                                                        </td>
                                                                        <td class="i">
                                                                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                                                Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete K BUser Tree Upload Info?')"
                                                                                CommandArgument='<%#Eval("UserTreeUploadInfoID")%>' UniqueKey="KBUserTreeUploadInfo_lvKBUserTreeUploadInfo_Edit_key" />
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
                                                        <%-- <asp:ObjectDataSource ID="odsKBUserTreeUploadInfoOperation" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.KBUserTreeUploadInfoDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsKBUserTreeUploadInfo_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>--%>
                                                    </div>
                                                </div>
                                                <br />
                                                <div class="TableRow" style="width: 100;">
                                                    <div class="TableFormLeble" style="text-align: right;">
                                                        &nbsp;
                                                    </div>
                                                    <div class="TableFormContent">
                                                        <asp:LinkButton ID="lnkUploadPopupTarget" runat="server"></asp:LinkButton>
                                                        <asp:Button ID="btnUploadPopupOk" CssClass="Panel-button" runat="server" Text="Ok" />
                                                    </div>
                                                </div>
                                                <div class="quick-links">
                                                </div>
                                                <div class="clear">
                                                </div>
                                            </div>
                                </td>
                                <td class="tbl-border-right">
                                </td>
                            </tr>
                            <tr>
                                <th class="sized bottomleft">
                                </th>
                                <td class="tbl-border-bottom">
                                    &nbsp;
                                </td>
                                <th class="sized bottomright">
                                </th>
                            </tr>
                        </table>
                    </div>
                </asp:Panel>
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
