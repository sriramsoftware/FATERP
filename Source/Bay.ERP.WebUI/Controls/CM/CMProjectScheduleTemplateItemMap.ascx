<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CMProjectScheduleTemplateItemMap.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CMProjectScheduleTemplateItemMapControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            function OnTreeClick(evt) {
                var src = window.event != window.undefined ? window.event.srcElement : evt.target;
                var isChkBoxClick = (src.tagName.toLowerCase() == "input" && src.type == "checkbox");
                if (isChkBoxClick) {
                    var parentTable = GetParentByTagName("table", src);
                    var nxtSibling = parentTable.nextSibling;
                    if (nxtSibling && nxtSibling.nodeType == 1)//check if nxt sibling is not null & is an element node
                    {
                        if (nxtSibling.tagName.toLowerCase() == "div") //if node has children
                        {
                            //check or uncheck children at all levels
                            CheckUncheckChildren(parentTable.nextSibling, src.checked);
                        }
                    }
                    //check or uncheck parents at all levels
                    CheckUncheckParents(src, src.checked);
                }
            }

            function CheckUncheckChildren(childContainer, check) {
                var childChkBoxes = childContainer.getElementsByTagName("input");
                var childChkBoxCount = childChkBoxes.length;
                for (var i = 0; i < childChkBoxCount; i++) {
                    childChkBoxes[i].checked = check;
                }
            }

            function CheckUncheckParents(srcChild, check) {
                var parentDiv = GetParentByTagName("div", srcChild);
                var parentNodeTable = parentDiv.previousSibling;

                if (parentNodeTable) {
                    var checkUncheckSwitch;

                    /*
                    if (check) //checkbox checked
                    {
                    var isAllSiblingsChecked = AreAllSiblingsChecked(srcChild);
                    if (isAllSiblingsChecked)
                    checkUncheckSwitch = true;
                    else
                    return; //do not need to check parent if any child is not checked
                    }
                    else //checkbox unchecked
                    {
                    checkUncheckSwitch = false;
                    }
                    */

                    // our change starts

                    if (check) //checkbox checked
                    {
                        var isAllSiblingsChecked = AreAllSiblingsChecked(srcChild);
                        if (isAllSiblingsChecked)
                            checkUncheckSwitch = true;
                        else
                            return; //do not need to check parent if any child is not checked
                    }
                    else //checkbox unchecked
                    {
                        var isAllSiblingsChecked = AreAllSiblingsChecked(srcChild);
                        if (isAllSiblingsChecked) {
                            checkUncheckSwitch = true;
                        }
                        else {
                            checkUncheckSwitch = false;
                        }
                    }

                    // our change ends

                    var inpElemsInParentTable = parentNodeTable.getElementsByTagName("input");
                    if (inpElemsInParentTable.length > 0) {
                        var parentNodeChkBox = inpElemsInParentTable[0];
                        parentNodeChkBox.checked = checkUncheckSwitch;
                        //do the same recursively
                        CheckUncheckParents(parentNodeChkBox, checkUncheckSwitch);
                    }
                }
            }

            function AreAllSiblingsChecked(chkBox) {
                var parentDiv = GetParentByTagName("div", chkBox);
                var childCount = parentDiv.childNodes.length;
                for (var i = 0; i < childCount; i++) {
                    if (parentDiv.childNodes[i].nodeType == 1) //check if the child node is an element node
                    {
                        if (parentDiv.childNodes[i].tagName.toLowerCase() == "table") {
                            var prevChkBox = parentDiv.childNodes[i].getElementsByTagName("input")[0];

                            //if any of sibling nodes are not checked, return false

                            // we have chnaged the requirmen... now if any one of the chield node is check then it will return true...
                            if (prevChkBox.checked) {
                                return true;
                            }
                        }
                    }
                }

                return false;
            }

            //utility function to get the container of an element by tagname
            function GetParentByTagName(parentTagName, childElementObj) {
                var parent = childElementObj.parentNode;
                while (parent.tagName.toLowerCase() != parentTagName.toLowerCase()) {
                    parent = parent.parentNode;
                }
                return parent;
            }
        </script>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div style="float: left; width: 325px;">
                <div class="contentSubTittle">
                    Project Schedule Tree</div>
                <div>
                    <div style="float: left; width: 275px;">
                        <kti:BayProjectScheduleItemTreeView ID="treeProjectSchedule" runat="server" onclick="OnTreeClick(event)"
                            OnSelectedNodeChanged="treeProjectSchedule_SelectedNodeChanged" ShowCheckBoxes="All">
                        </kti:BayProjectScheduleItemTreeView>
                    </div>
                    <div class="TableRow" style="width: 100;">
                        <kti:SecureButton ID="btnUpdate" ValidationGroup="CMProjectScheduleTemplateMapEntity"
                            OnClick="btnUpdate_Click" runat="server" Text="Update" UniqueKey="CMProjectScheduleTemplateMapControl_Submit_key" />
                    </div>
                </div>
            </div>
            <div class="contentSeperator">
            </div>
            <div style="float: left; width: 448px;">
                <div id="divUpdatePanel" runat="server" visible="false">
                    <div class="contentSubTittle">
                        Project Schedule Item Information</div>
                    <div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: left;">
                                Notify Before Min&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtNotifyBeforeMin" runat="server" ClientIDMode="Static" CssClass="ktiNumberTextBox"
                                    ValidationGroup="CMProjectScheduleTemplateItemMapEntity" Width="210" />
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RangeValidator ID="rvNotifyBeforeMin" runat="server" ControlToValidate="txtNotifyBeforeMin"
                                    Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                                    MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="CMProjectScheduleTemplateItemMapEntity"></asp:RangeValidator>
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: left;">
                                <asp:HyperLink CssClass="hypTableFormLeble" ID="hypIssuePriority" runat="server" Text="Issue Priority" NavigateUrl="~/MD/MDIssuePriority.aspx"
                                    Target="_blank"></asp:HyperLink>
                                &nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:DropDownList ID="ddlIssuePriorityID" CssClass="ktiSelect" ClientIDMode="Static"
                                    runat="server" ValidationGroup="CMProjectScheduleTemplateItemMapEntity" Width="234">
                                </asp:DropDownList>
                                <span class="RequiredField">*</span>
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RequiredFieldValidator ID="rfvIssuePriorityID" runat="server" ControlToValidate="ddlIssuePriorityID"
                                    ErrorMessage="Please Select Issue Priority" ValidationGroup="CMProjectScheduleTemplateItemMapEntity"
                                    EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                            </div>
                        </div>
                        <div class="TableRow" style="width: 100;">
                            <div class="TableFormLeble" style="text-align: left;">
                                Duration&nbsp;:
                            </div>
                            <div class="TableFormContent">
                                <asp:TextBox ID="txtDuration" CssClass="ktiDecimalTextBox" ClientIDMode="Static"
                                    runat="server" ValidationGroup="CMProjectScheduleTemplateItemMapEntity" Type="Number"
                                    Width="210" />
                            </div>
                            <div class="TableFormValidatorContent">
                                <asp:RangeValidator ID="rvDuration" runat="server" ControlToValidate="txtDuration"
                                    Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136.36)"
                                    MinimumValue="-79228162514264337593543950335" MaximumValue="79228162514264337593543950335"
                                    Type="Double" ValidationGroup="CMProjectScheduleTemplateItemMapEntity"></asp:RangeValidator>
                            </div>
                        </div>
                        <div class="TableRow" style="text-align: center;">
                            <div class="TableFormLeble">
                                &nbsp;</div>
                            <div class="TableFormContent">
                                <kti:SecureButton ID="btnSubmit" ValidationGroup="CMProjectScheduleTemplateItemMapEntity"
                                    OnClick="btnSubmit_Click" runat="server" Text="Update" UniqueKey="CMProjectScheduleTemplateItemMapControl_Submit_key" />
                                <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                                    UniqueKey="CMProjectScheduleTemplateItemMapControl_Clear_key" />
                            </div>
                        </div>
                        <br />
                    </div>
                </div>
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
