<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="PRMPreBOQSetup.ascx.cs"
    Inherits="Bay.ERP.Web.UI.PRMPreBOQSetupControl" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div class="TableRow" style="width: 100;">
                <div style="padding-bottom: 5px;">
                    <b>BOQ Template&nbsp;:</b>
                </div>
                <div>
                    <asp:DropDownList ID="ddlPreBOQTemplateID" CssClass="ktiSelect" ClientIDMode="Static"
                        ToolTip="Please Select The Required Template!" runat="server" Width="236" OnSelectedIndexChanged="ddlPreBOQTemplateID_SelectedIndexChanged"
                        AutoPostBack="true">
                    </asp:DropDownList>
                </div>
                <div style="float:right;">
                <h1>Note: Becareful to Modify this page,<br /> This may delete the complete BOQ</h1>
                </div>
                <br />
                <div style="padding-bottom: 5px;">
                    <b>Items&nbsp;:</b>
                </div>
                <div>
                    <kti:BayItemTreeView ID="treeItem" runat="server" ShowCheckBoxesInAllNodes="true"
                        ShowCheckedAtLastNode="false" OnSelectedNodeChanged="treeItem_SelectedNodeChanged"
                        ToolTip="Please Unchecked The Item Which Is Not Required. By Default - Checked All Item!">
                    </kti:BayItemTreeView>
                </div>
                <br />
                <div style="padding-left: 20px;">
                    <kti:SecureButton ID="btnSubmit" runat="server" Text="Update"
                        UniqueKey="PRMPreBOQSetupControl_Submit_key" />
                        <div style="display:none;">
                        <asp:Button ID="btnSelectAll" runat="server" Text="Select All" OnClick="btnSelectAll_Click"/>
                        <asp:Button ID="btnDeselectAll" runat="server" Text="Deselect All" OnClick="btnDeselectAll_Click"/>
                        <asp:Button ID="btnClearSelection" runat="server" Text="Clear Select" OnClick="btnClearSelection_Click"/>
                        </div>
                    <br />
                    <br />
                    <asp:Label ID="lblSelectMessage" runat="server" Text="Selected None"></asp:Label>
                    <asp:Label ID="lblFormLock" runat="server" Text="Note: The Form has been Locked, no information can be changed."
                        CssClass="msgLock"></asp:Label>
                </div>
                <br />
            </div>
        </div>
        <ajaxToolkit:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server" PopupControlID="Panel1"
            DynamicServicePath="" Enabled="True" TargetControlID="btnSubmit" OkControlID="lnkTargetPopup"
            CancelControlID="btnPnlCancel" BackgroundCssClass="modalBackground">
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
                            <asp:Button ID="Button2" runat="server" Text="X"></asp:Button>
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
                                            Import Info</h1>
                                        <div>
                                            <div class="TableRow" style="width: 500px;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent" style="padding-top: 10px;">
                                                    <asp:CheckBoxList ID="chbxImportInfoList" class="ktiListBox" Style="width: 200px;"
                                                        runat="server">
                                                    </asp:CheckBoxList>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="TableRow" style="width: 100;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:LinkButton ID="lnkTargetPopup" runat="server"></asp:LinkButton>
                                                    <kti:SecureButton ID="btnPnlSavePopup" runat="server" Text="Ok" OnClick="btnSave_Click" UniqueKey="PRMPreBOQSetup_SavePopup_key"/>
                                                    <kti:SecureButton ID="btnPnlCancel" runat="server" Text="Cancel" UniqueKey="PRMPreBOQSetup_CancelPopup_key" />
                                                </div>
                                            </div>
                                            <br />
                                            <div class="TableRow" style="width: 500px;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent" style="padding-top: 10px;">
                                                    <asp:Label ID="lblPriceNote" runat="server" Text="* 'Price Info' Will Be Imported From Price Datbase!"></asp:Label>
                                                    <br />
                                                    <asp:Label ID="lblQtyNote" runat="server" Text="* 'Qty Info' Will Be Imported From Thumb Rule!"></asp:Label>
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
    </ContentTemplate>
</asp:UpdatePanel>
