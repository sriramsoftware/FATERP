<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 02-Sep-2012, 12:46:09
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="DMSDocumentNode.ascx.cs"
    Inherits="Bay.ERP.Web.UI.DMSDocumentNodeControl" %>
<%@ Register Assembly="ASTreeView" Namespace="Geekees.Common.Controls" TagPrefix="ct" %>
<link href="<%=ResolveUrl("~/Scripts/ASTreeview179Custom/astreeview/astreeview.css")%>"
    type="text/css" rel="stylesheet" />
<link href="<%=ResolveUrl("~/Scripts/ASTreeview179Custom/contextmenu/contextmenu.css")%>"
    type="text/css" rel="stylesheet" />
<script src="<%=ResolveUrl("~/Scripts/ASTreeview179Custom/astreeview/astreeview_packed.js")%>"
    type="text/javascript"></script>
<script src="<%=ResolveUrl("~/Scripts/ASTreeview179Custom/contextmenu/contextmenu_packed.js")%>"
    type="text/javascript"></script>
<link href="../Styles/DMS.css" media="screen" rel="stylesheet" type="text/css" />
<%@ Register Assembly="AjaxControlToolkit" Namespace="AjaxControlToolkit" TagPrefix="ajaxToolkit" %>
<style>
        .ajax__fileupload_button
        {
            background-color: green;
        }
    </style>
    <script type="text/javascript">


        function onClientUploadComplete(sender, e) {
            var id = e.get_fileId();
            onImageValidated("TRUE", e);
        }

        function onImageValidated(arg, context) {

            var test = document.getElementById("testuploaded");
            test.style.display = 'none';

            var fileList = document.getElementById("fileList");
            var item = document.createElement('div');
            item.style.padding = '4px';

            if (arg == "TRUE") {
                var url = context.get_postedUrl();
                url = url.replace('&amp;', '&');
                item.appendChild(createThumbnail(context, url));
            } else {
                item.appendChild(createFileInfo(context));
            }

            fileList.appendChild(item);

        }

        function createFileInfo(e) {
            var holder = document.createElement('div');
            holder.appendChild(document.createTextNode(e.get_fileName() + ' with size ' + e.get_fileSize() + ' bytes'));

            return holder;
        }

        function createThumbnail(e, url) {
            var holder = document.createElement('div');
            var img = document.createElement("img");
            img.style.width = '80px';
            img.style.height = '80px';
            img.setAttribute("src", url);

            holder.appendChild(createFileInfo(e));
            holder.appendChild(img);

            return holder;
        }
    
    </script>
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
        var sourceNodeText = elem.getElementsByTagName("A")[0].innerHTML;
        document.getElementById("<%=txtEditedNodeText .ClientID %>").value = sourceNodeText;
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
<asp:UpdatePanel ID="upMauin" runat="server">
    <Triggers>
        <asp:AsyncPostBackTrigger ControlID="btnClick" EventName="Click" />
        <%--<asp:AsyncPostBackTrigger ControlID="btnTreeSynClick" EventName="Click" />--%>
    </Triggers>
    <ContentTemplate>
     <script type="text/javascript">
         Sys.Application.add_load(BindEvents);
     </script>
        <div>
            <div style="display: none;">
                <asp:Button ID="btnPostBackTrigger" runat="server" OnClick="btnPostBackTrigger_Click" />
                <asp:TextBox ID="txtIDContainer" runat="server"></asp:TextBox>
            </div>
            <div style="display: none;">
                <asp:Button ID="btnPostBackEditedTrigger" runat="server" OnClick="btnPostBackEditedTrigger_Click" />
                <asp:TextBox ID="txtIDEditedContainer" runat="server"></asp:TextBox>
                <asp:TextBox ID="txtEditedNodeText" runat="server" ClientIDMode="Static"></asp:TextBox>
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
                    Drive&nbsp;
                </div>
                <div class="TableFormContent" style="padding-left: 150px;">
                    <panel id="pnlOption">
                    <kti:SecureButton ID="btnMoveToArchive" CssClass="Panel-button" runat="server" Text="Move To Archive" UniqueKey="DMSDocumentNodeControl_MoveToArchive_key" OnClick="btnMoveToArchive_Click" 
                        ClientIDMode="Static" />
                    <kti:SecureButton ID="btnAddStar" CssClass="Panel-button" runat="server" Text="Add Star" UniqueKey="DMSDocumentNodeControl_AddStar_key" OnClick="btnAddStar_Click"
                        ClientIDMode="Static" />
                        <kti:SecureButton ID="btnRemoveStar" CssClass="Panel-button" runat="server" Text="Remove Star" UniqueKey="DMSDocumentNodeControl_RemoveStar_key" OnClick="btnRemoveStar_Click" Visible="false"
                        ClientIDMode="Static" />
                       <%-- <asp:ImageButton ID="btnRemove" CssClass="Panel-button"  runat="server" ImageUrl="~/Images/DMS/Trash.png" OnClick="btnRemove_Click"></asp:ImageButton>--%>
                         <kti:SecureButton ID="btnRemove" CssClass="Panel-button" runat="server" Text="Delete Forever" UniqueKey="DMSDocumentNodeControl_MoveToArchive_key" OnClick="btnRemove_Click"
                        ClientIDMode="Static" />
                    <%--<kti:SecureButton ID="btn" runat="server" Text="Preview" UniqueKey="DMSDocumentNodeControl_AddStar_key"
                        ClientIDMode="Static" />--%>
                        </panel>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    <kti:SecureButton ID="btnCreate" CssClass="button-primary" runat="server" Text="Create"
                        UniqueKey="DMSDocumentNodeControl_Create_key" ClientIDMode="Static" />
                </div>
                <div class="TableFormContent">
                    <div class="TableRow" style="width: 100; padding-left: 130px;">
                        <div class="TableFormContent">
                            <div style="float: left;">
                                <div class="demoarea">
                                    <asp:Label runat="server" ID="Label2" Style="display: none;"><img align="absmiddle" alt="" src="uploading.gif"/></asp:Label>
                                    <ajaxToolkit:AjaxFileUpload ID="AjaxFileUpload1" runat="server" Padding-Bottom="4" Width="710" OnClientUploadStarted="AssemblyFileUpload_Started" IsInFileUploadPostBack="true"
                                        Padding-Left="2" Padding-Right="1" Padding-Top="4" ThrobberID="myThrobber" OnClientUploadComplete="onClientUploadComplete" OnAllFilesUploaded="AjaxFileUpload1_AllFilesUploaded"
                                        OnUploadComplete="AjaxFileUpload1_OnUploadComplete" MaximumNumberOfFiles="10" />
                                    <br />
                                    <div id="testuploaded" style="display: none; padding: 4px; border: gray 1px solid;">
                                        <h4>
                                            list of uploaded files:</h4>
                                        <hr />
                                        <div id="fileList">
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <div class="TableFormContent" style="display: none;">
                    <div class="TableRow" style="width: 100; padding-left: 130px;">
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
                                <%-- <asp:Button runat="server" ID="btnTreeSynClick" ClientIDMode="Static" Text="Update tree"
                                    Style="display: none" OnClick="btnTreeSynClick_Click" />--%>
                            </div>
                            <div style="float: left; padding-left: 10px;">
                                <asp:Label runat="server" ID="myThrobber">
                                    <asp:Image ID="imgUploading" runat="server" ImageAlign="AbsMiddle" AlternateText="Uploading..."
                                        ImageUrl="~/Images/UploadImage/uploading.gif" /></asp:Label>
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                    </div>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
            <div style="float: left; width: 300px;">
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
                        EnableOnNodeAddedScriptReturn="true" AutoPostBack="true" EnableTreeLines="false"
                        EnableNodeIcon="true" EnableCustomizedNodeIcon="true" OnNodeDeletedScript="deletedHandler(val)"
                        OnNodeDragAndDropCompletedScript="dndCompletedHandler( elem, newParent )" OnNodeEditedScript="editedHandler(elem)"
                        OnNodeAddedScript="addedHandler(elem)" EnableDebugMode="false" EnableContextMenuAdd="false"
                        OnOnSelectedNodeChanged="astvMyTree_OnSelectedNodeChanged" />
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 790px;">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="listContentTitle">
                </div>
                <div>
                    <asp:ListView runat="server" ID="lvDMSDocumentNode" DataSourceID="odsDMSDocumentNode"
                        OnItemDataBound="lvCMNDashboardItem_ItemDataBound" OnItemCommand="lvDMSDocumentNode_ItemCommand">
                        <LayoutTemplate>
                            <table runat="server" id="table1" class="DMStable">
                                <tr>
                                    <td style="width: 30px;" class="DMStd">
                                        <asp:CheckBox ID="cbSelectAll" runat="server" onclick="toggleCheckBoxes(this);" Visible="false" />
                                    </td>
                                    <td style="width: 400px;" class="DMStd">
                                        <b>Document Name</b>
                                    </td>
                                    <td class="DMStd" style="width: 50px;">
                                        <b>Starred</b>
                                    </td>
                                    <td class="DMStd" style="width: 50px;">
                                        <b>Owner</b>
                                    </td>
                                </tr>
                                <tr runat="server" id="itemPlaceholder">
                                </tr>
                                <tr>
                                    <td colspan="600">
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
                            <tr id="tr" runat="server">
                                <td class="DMStd">
                                    <asp:CheckBox ID="chbxDocumentNode" runat="server" onclick="toggleChildCheckBoxes(this);" />
                                </td>
                                <td style="display: none;">
                                    <asp:Label ID="lblDocumentNodeID" runat="server" Text='<%# Eval("DocumentNodeID")%>'></asp:Label>
                                </td>
                                <td class="DMStd">
                                    <asp:HyperLink ID="hypName" NavigateUrl='<%# Eval("Path")%>' runat="server" Target="_blank"
                                        Font-Size="14pt" Text='<%# Eval("Name")%>' CssClass="CommonLink"></asp:HyperLink>
                                </td>
                                <td class="DMStd">
                                    <asp:Label ID="lblIsStarred" Text='<%# Eval("IsStarred") != null ? (((Boolean)Eval("IsStarred")) ? "Yes" : "No") : ""%>'
                                        runat="server"></asp:Label>
                                </td>
                                <td class="DMStd">
                                    <%# Eval("OwnerReferenceID")%>
                                </td>
                            </tr>
                        </ItemTemplate>
                        <EmptyDataTemplate>
                            <div class="edr">
                                No Records Found To Display
                            </div>
                        </EmptyDataTemplate>
                    </asp:ListView>
                    <asp:ObjectDataSource ID="odsDMSDocumentNode" runat="server" SelectMethod="GetPagedData"
                        SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                        StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.DMSDocumentNodeDataSource"
                        SortParameterName="sortExpression" OnSelecting="odsDMSDocumentNode_Selecting">
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
                                            Create New Floder</h1>
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
        <script type="text/javascript">
                function uploadError(sender, args) {
                    //addToClientTable(args.get_fileName(), "<span style='color:red;'>" + args.get_errorMessage() + "</span>");
                }
                //            function uploadComplete(sender, args) {
                //                var btnClick = document.getElementById("btnClick");
                //                btnClick.click();
                //                //                var btnTreeSynClick = document.getElementById("btnTreeSynClick");
                //                //                btnTreeSynClick.click();
                //            }
                function onClientUploadComplete(sender, args) {
                    var btnClick = document.getElementById("btnClick");
                    btnClick.click();
                    //var btnTreeSynClick = document.getElementById("btnTreeSynClick");
                    //btnTreeSynClick.click();
                }
        </script>
        <script>
            function AssemblyFileUpload_Started(sender, args) {
                var filename = args.get_fileName();
                var ext = filename.substring(filename.lastIndexOf(".") + 1);
                if (ext != 'sql') {
                    throw {
                        name: "Invalid File Type",
                        level: "Error",
                        message: "Invalid File Type (Only .png)",
                        htmlMessage: "Invalid File Type (Only .png)"
                    }
                    return false;
                }
                return true;
            }
</script>
    </ContentTemplate>
</asp:UpdatePanel>
