<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="HREmployeeMultiSelection.ascx.cs"
    Inherits="Bay.ERP.Web.UI.HREmployeeMultiSelectionControl" %>
    <script type="text/javascript">
        function BindEvents() {
            $(document).ready(function () {
                addNewname();
            });

            function addNewname() {
                $(".someItemDiv").append('<div class="someItem"><div class="someItemContent">New loger name</div><div class="someItemCross">X</div><div></div></div>');
            }

            $(".someItemDiv").click(function () {
                addNewname();
            });
        }
                    </script>

<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
    <script type="text/javascript">
        Sys.Application.add_load(BindEvents);
     </script>
        <div>
            <div class="TableRow" style="width: 100;">
                <div class="TableFormLeble" style="text-align: left;">
                    Employee&nbsp;:
                </div>
                <div class="TableFormContent">
                   <style type="text/css">
                            .someItemDiv
                            {
                                clear:both; border: 1px Solid;
                                padding-top: 3px;
                                padding-right: 3px;
                                padding-bottom: 3px;
                                width: 300px;
                                display:inline-block;
                                height: auto;
                            }
                            .someItem
                            {                                                    
                                float: left;
                                border: 1px solid Green;
                                background-color: Aqua;
                                padding-left: 3px;
                            }
                            .someItem .someItemContent
                            {
                                float: left;
                            }
                                                
                            .someItem .someItemCross
                            {
                                float: left;
                            }
                    </style>
                    <div>
                        <div class="someItemDiv">
                            <div class="someItem">
                                <div class="someItemContent">Mosme somane</div>
                                <div class="someItemCross">X</div>
                                <div></div>
                            </div>
                            <div class="someItem">
                                <div class="someItemContent">Mosme somane</div>
                                <div class="someItemCross">X</div>
                                <div></div>
                            </div>
                            <div class="someItem">
                                <div class="someItemContent">Mosme</div>
                                <div class="someItemCross">X</div>
                                <div></div>
                            </div>
                            <div class="someItem">
                                <div class="someItemContent">Mosme somane</div>
                                <div class="someItemCross">X</div>
                                <div></div>
                            </div>
                            <div class="someItem">
                                <div class="someItemContent">Mosme somane</div>
                                <div class="someItemCross">X</div>
                                <div></div>
                            </div>
                        </div>
                    </div>

                    
                    <span>
                        <kti:SecureLinkButton ID="lnkBtnSelect" runat="server" CssClass="CommonButtonLink" UniqueKey="HREmployeeMultiSelectionControl_lnkBtnSelect"
                            Text="Select"></kti:SecureLinkButton></span>
                </div>
                <div class="TableFormValidatorContent">
                </div>
            </div>
        </div>
        <ajaxToolkit:ModalPopupExtender ID="Panel1_ModalPopupExtender" runat="server" PopupControlID="Panel1"
            DynamicServicePath="" Enabled="True" TargetControlID="lnkBtnSelect" OkControlID="lnkSavePopup"
            CancelControlID="btnCancel" BackgroundCssClass="modalBackground">
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
                            <asp:Button ID="btnClose" runat="server" Text="X"></asp:Button>
                        </div>
                    </div>
                    <table border="0" cellpadding="0" cellspacing="0" class="content-table" style="width: auto; padding-left: 10px;">
                        <tr>
                            <th rowspan="3" class="sized">
                                <asp:Image ID="imgSideShadowLeft" runat="server" ImageUrl="~/Images/shared/side_shadowleft.jpg"
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
                                <asp:Image ID="imgSideShadowRight" runat="server" ImageUrl="~/Images/shared/side_shadowright.jpg"
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
                                            Employee Info</h1>
                                        <div>
                                            <div class="ktiListBox" style="max-height:240px; min-height:240px; overflow:auto; width: 498px;">
                                                <div class="TableFormContent">
                                                    <kti:BayEmployeeTreeView ID="treeEmployee" runat="server" ShowCheckBoxesInAllNodes="false"
                                                        ShowCheckBoxAtLastNode="true" ShowCheckedAtLastNode="false">
                                                    </kti:BayEmployeeTreeView>
                                                </div>
                                            </div>
                                            <br />
                                            <div class="TableRow" style="width: 500;">
                                                <div class="TableFormLeble" style="text-align: left;">
                                                    &nbsp;
                                                </div>
                                                <div class="TableFormContent">
                                                    <asp:LinkButton ID="lnkSavePopup" runat="server"></asp:LinkButton>
                                                    <kti:SecureButton ID="btnUpdatePopup" runat="server" Text="Update" UniqueKey="HREmployeeMultiSelection_UpdatePopup_key"/>
                                                    <kti:SecureButton ID="btnCancel" runat="server" Text="Cancel" UniqueKey="HREmployeeMultiSelection_Cancel_key" />
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
