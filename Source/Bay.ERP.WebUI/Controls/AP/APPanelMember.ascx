<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 03-Oct-2012, 05:32:03
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="APPanelMember.ascx.cs"
    Inherits="Bay.ERP.Web.UI.APPanelMemberControl" %>

    <style type="text/css">
     .imgRound
    {
    border-radius: 50%;
    vertical-align: middle;
    background: none repeat scroll 0 0 #FFFFFF;
    border: 2px solid #FFFFFF;
    height:85px;
    width:73px;
    }
    </style>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <ajaxToolkit:CollapsiblePanelExtender ID="cpeEditor" runat="server" TargetControlID="pnlEditor"
            ExpandControlID="divCollapsControl" CollapseControlID="divCollapsControl" Collapsed="false"
            ImageControlID="imgExpandCollaps" CollapsedImage="~/Images/expand-plus.gif" ExpandedImage="~/Images/collapse-minus.gif"
            SuppressPostBack="false">
        </ajaxToolkit:CollapsiblePanelExtender>
        <asp:Panel ID="pnlCPEContent" runat="server" CssClass="pnlCPEContent">
            <div id="divCollapsControl" class="divCollapsControl">
                <div style="float: left; height: 16px; width: 16px;">
                    <asp:Image ID="imgExpandCollaps" ImageUrl="~/Images/expand-plus.gif" runat="server" />
                </div>
                <div style="float: left; padding-left: 3px;">
                    <asp:Label ID="lvlCollapsText" runat="server" Text="Add/Edit Approval Process Panel Member"></asp:Label>
                </div>
                <div style="clear: both;">
                </div>
            </div>
        </asp:Panel>
        <div>
            <asp:Panel ID="pnlEditor" runat="server" CssClass="pnlEditor">
                <div class="TableRow" style="text-align: left;" runat="server">
                    <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Appr. Proc. Panel&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlAPPanelID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="APPanelMemberEntity" Width="234" AutoPostBack="true" OnSelectedIndexChanged="ddlAPPanelID_SelectedIndexChanged">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvAPPanelID" runat="server" ControlToValidate="ddlAPPanelID"
                            ErrorMessage="Please Select Approval Process Panel" ValidationGroup="APPanelMemberEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Department&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlDepartmentID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="APPanelMemberEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvDepartmentID" runat="server" ControlToValidate="ddlDepartmentID"
                            ErrorMessage="Please Select Department" ValidationGroup="APPanelMemberEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Panel Member&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlEmployeeID" CssClass="ktiSelect" ClientIDMode="Static" runat="server"
                            ValidationGroup="APPanelMemberEntity" Width="234">
                        </asp:DropDownList>
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvEmployeeID" runat="server" ControlToValidate="ddlEmployeeID"
                            ErrorMessage="Please Select Employee" ValidationGroup="APPanelMemberEntity" EnableViewState="False"
                            Display="Dynamic"></asp:RequiredFieldValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Sequence No&nbsp;:
                    </div>
                    <div class="TableFormContent waterMarkContainer">
                        <label class="watermarkLabel" for="txtSequenceNo">
                            Enter Sequence No</label>
                        <asp:TextBox ID="txtSequenceNo" CssClass="ktiNumberTextBox" ClientIDMode="Static"
                            runat="server" ValidationGroup="APPanelMemberEntity" Width="210" />
                        <span class="RequiredField">*</span>
                    </div>
                    <div class="TableFormValidatorContent">
                        <asp:RequiredFieldValidator ID="rfvSequenceNo" runat="server" ControlToValidate="txtSequenceNo"
                            ErrorMessage="Please Enter Sequence No" ValidationGroup="APPanelMemberEntity"
                            EnableViewState="False" Display="Dynamic"></asp:RequiredFieldValidator>
                        <asp:RangeValidator ID="rvSequenceNo" runat="server" ControlToValidate="txtSequenceNo"
                            Display="Dynamic" EnableViewState="False" ErrorMessage="Enter Number (Example: 2136)"
                            MinimumValue="-2147483648" MaximumValue="2147483647" Type="Integer" ValidationGroup="APPanelMemberEntity"></asp:RangeValidator>
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Proxy Member&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:DropDownList ID="ddlProxyEmployeeID" CssClass="ktiSelect" ClientIDMode="Static"
                            runat="server" ValidationGroup="APPanelMemberEntity" Width="234">
                        </asp:DropDownList>
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="width: 100;">
                    <div class="TableFormLeble" style="text-align: right;">
                        Proxy Enabled&nbsp;:
                    </div>
                    <div class="TableFormContent">
                        <asp:CheckBox ID="chkIsProxyEmployeeEnabled" runat="server" ClientIDMode="Static"
                            ValidationGroup="APPanelMemberEntity" />
                    </div>
                    <div class="TableFormValidatorContent">
                    </div>
                </div>
                <div class="TableRow" style="text-align: center;">
                    <div class="TableFormLeble">
                        &nbsp;</div>
                    <div class="TableFormContent">
                        <kti:SecureButton ID="btnSubmit" ValidationGroup="APPanelMemberEntity" OnClick="btnSave_Click"
                            runat="server" Text="Add" UniqueKey="APPanelMemberControl_Submit_key" />
                        <kti:SecureButton ID="btnAddNew" Visible="false" OnClick="btnAddNew_Click" runat="server"
                            Text="Add New" UniqueKey="APPanelMemberControl_AddNew_key" />
                        <kti:SecureButton ID="btnClear" OnClick="btnClear_Click" runat="server" Text="Clear"
                            UniqueKey="APPanelMemberControl_Clear_key" />
                    </div>
                </div>
                <br />
            </asp:Panel>
            
            <div>
                <div style="float: left; width: 650px;">
                <div class="listContentTitle" style="font-size: 14px;">
                Approval Process Panel Member List
            </div>
                <asp:ListView ID="lvAPPanelMember" runat="server" DataSourceID="odsAPPanelMember" OnItemDataBound="lvAPPanelMember_ItemDataBound"
                    OnItemCommand="lvAPPanelMember_ItemCommand">
                    <LayoutTemplate>
                        <div id="sortable" style="width: 620px;">
                            <div runat="server" id="itemPlaceholder">
                            </div>
                            <div style="text-align: center;">
                                <kti:SecureButton ID="btnSaveSequence" ClientIDMode="Static" OnClick="btnSaveSequence_Click"
                                    runat="server" Text="Save Sequence" UniqueKey="APPanelMemberControl_SaveSequence_key" />
                            </div>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>
                        <div class="lv-sortable-item" id='<%# Eval("APPanelMemberID")%>'>
                            <div>
                                <div style="float: left; padding-left: 10px; padding-right: 10px;">
                                    <span class="ui-icon ui-icon-arrowthick-2-n-s"></span>
                                </div>
                                <div style="float: left;">
                                    <div style="padding-bottom: 15px;">
                                        <span style="font-size: 15px;">
                                            <%# Eval("MemberFullName")%>
                                        </span>
                                    </div>
                                    <div style="padding-bottom: 7px;">
                                        <div style="float: left; width: 150px;">
                                            Department</div>
                                        <div style="float: left; width: 10px;">
                                            :</div>
                                        <div style="float: left; width: 300px;">
                                            <%# Eval("DepartmentName")%></div>
                                        <div style="clear: both;">
                                        </div>
                                    </div>
                                    <div style="padding-bottom: 7px;">
                                        <div style="float: left; width: 150px;">
                                            Sequence</div>
                                        <div style="float: left; width: 10px;">
                                            :</div>
                                        <div style="float: left; width: 250px;">
                                            <%# Eval("SequenceNo")%></div>
                                        <div style="clear: both;">
                                        </div>
                                    </div>
                                    <div style="padding-bottom: 7px;">
                                        <div style="float: left; width: 150px;">
                                            Proxy Member</div>
                                        <div style="float: left; width: 10px;">
                                            :</div>
                                        <div style="float: left; width: 300px;">
                                            <%# Eval("ProxyMemberFullName")%></div>
                                        <div style="clear: both;">
                                        </div>
                                    </div>
                                    <div style="padding-bottom: 7px;">
                                        <div style="float: left; width: 150px;">
                                            Enable Proxy Member</div>
                                        <div style="float: left; width: 10px;">
                                            :</div>
                                        <div style="float: left; width: 300px;">
                                            <%# Eval("IsProxyEmployeeEnabled") != null ? (((Boolean)Eval("IsProxyEmployeeEnabled")) ? "Yes" : "No") : ""%></div>
                                        <div style="clear: both;">
                                        </div>
                                    </div>
                                    <br />
                                    <div style="padding-bottom: 7px;">
                                        <div style="float: left; width: 460px;">
                                            <kti:SecureLinkButton ID="lnkBtnEdit" runat="server" CssClass="CommonButtonLink"
                                                Text="Edit" CommandName="EditItem" CommandArgument='<%#Eval("APPanelMemberID")%>'
                                                UniqueKey="APPanelMember_lvAPPanelMember_Edit_key" />
                                            &nbsp;
                                            <kti:SecureLinkButton ID="lnkBtnDelete" runat="server" CssClass="CommonButtonLink"
                                                Text="Delete" CommandName="DeleteItem" OnClientClick="return confirm('Are you sure to delete Approval Process Panel Member?')"
                                                CommandArgument='<%#Eval("APPanelMemberID")%>' UniqueKey="APPanelMember_lvAPPanelMember_Delete_key" />
                                        </div>
                                    </div>
                                </div>
                                <div style="float: left; width: 100px;">
                                    <asp:Image ID="Image2" runat="server" BorderColor="Gray" BorderWidth="0" BorderStyle="Solid"
                                        ImageAlign="AbsMiddle" CssClass="imgRound"/>
                                </div>
                                <div style="clear: both;">
                                </div>
                            </div>
                        </div>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <div class="edr">
                            No Records Found To Display
                        </div>
                    </EmptyDataTemplate>
                </asp:ListView>
                <asp:HiddenField ID="hydNewSequence" ClientIDMode="Static" runat="server" Value="" />
                <asp:ObjectDataSource ID="odsAPPanelMember" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.APPanelMember_CustomDataSource"
                    OnSelecting="odsAPPanelMember_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                </div>
                <div style="float: left; width: 410px; margin-left: 15px;">
                    <div class="listContentTitle" style="font-size: 14px;">
                        Panel Forward Member List (<asp:HyperLink ID="hpyModifyList" runat="server" CssClass="CommonButtonLink" Text="Modify List" NavigateUrl="~/AP/APPanelForwardMember.aspx"></asp:HyperLink>)
                    </div>
                <div>
                </div>
                     <asp:ListView ID="lvAPPanelForwardMember" runat="server" DataSourceID="odsAPPanelForwardMember">
                    <LayoutTemplate>
                        <div id="sortable-dummy" style="width: 410px;">
                            <div runat="server" id="itemPlaceholder">
                            </div>
                        </div>
                    </LayoutTemplate>
                    <ItemTemplate>                        
                        <div class="lv-sortable-item-dummy">
                            <div style="float: left;">
                                <div style="padding-bottom: 15px;">
                                    <span style="font-size: 15px;">
                                        <%# Eval("MemberFullName")%>
                                    </span>
                                </div>
                                <div style="padding-bottom: 7px;">
                                    <div style="float: left; width: 100px;">
                                        Department</div>
                                    <div style="float: left; width: 10px;">
                                        :</div>
                                    <div style="float: left; width: 200px;">
                                        <%# Eval("MDDepartmentName")%></div>
                                    <div style="clear: both;">
                                    </div>
                                </div>
                            </div>
                            <div style="float: left; width: 70px;">
                                <asp:Image ID="Image2" runat="server" BorderColor="Gray" BorderWidth="0" BorderStyle="Solid"
                                    ImageAlign="AbsMiddle" />
                            </div>
                            <div style="clear: both;">
                            </div>
                        </div>
                    </ItemTemplate>
                    <EmptyDataTemplate>
                        <div class="edr">
                            No Records Found To Display
                        </div>
                    </EmptyDataTemplate>
                </asp:ListView>
                <asp:ObjectDataSource ID="odsAPPanelForwardMember" runat="server" SelectMethod="GetPagedData"
                    SelectCountMethod="TotalRowCount" EnablePaging="true" MaximumRowsParameterName="pageSize"
                    StartRowIndexParameterName="startRowIndex" TypeName="Bay.ERP.Web.UI.APPanelForwardMember_DetailedDataSource"
                    SortParameterName="sortExpression" OnSelecting="odsAPPanelForwardMember_Selecting">
                    <SelectParameters>
                        <asp:Parameter Name="startRowIndex" Type="Int32" />
                        <asp:Parameter Name="pageSize" Type="Int32" />
                        <asp:Parameter Name="sortExpression" Type="String" />
                        <asp:Parameter Name="filterExpression" Type="String" />
                    </SelectParameters>
                </asp:ObjectDataSource>
                </div>
                <div style="clear: left;"></div>
            </div>
        </div>
        <style type="text/css">
            #sortable
            {
                border: 1px #cfe6ff solid;
                background-color: #eaf4ff;
                padding-top: 15px;
                padding-right: 15px;
                padding-left: 15px;
                padding-bottom: 10px;
            }
            
            #sortable-dummy
            {
                border: 1px #cfe6ff solid;
                background-color: #eaf4ff;
                padding-top: 15px;
                padding-right: 15px;
                padding-left: 15px;
                padding-bottom: 10px;
            }
            
            .lv-sortable-item
            {
                border: 1px #cfe6ff solid;
                cursor: move;
                background-color: #cfe6ff;
                margin-bottom: 10px;
                color: #7f7f7f;
                padding: 10px;
                font-weight: bold;
            }
            
            .lv-sortable-item-dummy
            {
                border: 1px #cfe6ff solid;
                background-color: #cfe6ff;
                margin-bottom: 10px;
                color: #7f7f7f;
                padding: 10px;
                font-weight: bold;
            }
            
        </style>
        <script type="text/javascript">

            function CurrentPageLoad() {

                $(function () {
                    $("#sortable").sortable(
                    {
                        update: function (event, ui) {
                            var order = [];
                            $('#sortable .lv-sortable-item').each(function (e) {
                                order.push('{\"id\":\"' + $(this).attr('id') + '\", \"seq\":\"' + ($(this).index() + 1) + '\"}');
                            });

                            var positions = order.join(',')
                            var jsonString = '[' + positions + ']';
                            $("#hydNewSequence").val(jsonString);
                        }
                    });

                    $("#sortable").disableSelection();
                });

                $(function () {
                    $(".lv-sortable-item .CommonButtonLink, #btnSaveSequence").button().click(function (event) {
                        //event.preventDefault();
                    });
                });
            }

            CurrentPageLoad();

            var prm = Sys.WebForms.PageRequestManager.getInstance();
            prm.add_endRequest(function () {
                $(function () {
                    CurrentPageLoad();
                });
            });
            
        </script>
    </ContentTemplate>
</asp:UpdatePanel>
