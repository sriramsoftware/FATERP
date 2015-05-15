<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectInfoTabView.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectInfoTabViewControl" %>
<script type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $(function () {
                $("#tabs").tabs();
            });
            var indx = $('#' + '<%= hidLastTab.ClientID %>').val();
            $("#tabs").tabs({ selected: indx });
        });
    }
</script>
<script type="text/javascript">
    function BindEventss() {
        $(document).ready(function () {

            // <!-- Tabs script -->

            //alert("Start");
            var indx = $('#' + '<%= hidLastTab.ClientID %>').val();
            //alert(indx);

            if (indx == '') {
                $("#tabs").tabs({ selected: 0 });
                //alert("if not "+indx);
                $('#' + '<%= hidLastTab.ClientID %>').val('0');
            }
            else {
                $("#tabs").tabs({ selected: indx });
                //alert("else" + indx);
                $('#' + '<%= hidLastTab.ClientID %>').val(indx);
                $("#tabs").tabs({ selected: indx });
            }

            $("#tabs").tabs({
                select: function (event, ui) {
                    //alert("Ui index"+ui.index);
                    $('#' + '<%= hidLastTab.ClientID %>').val(ui.index);
                }
            });
            // tabs script ends
            //alert("end");
        });
    }
</script>
<%@ Register Src="~/Controls/BD/BDProjectEditor.ascx" TagName="BDProjectEditorEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/BD/BDProjectOtherInfo.ascx" TagName="BDProjectOtherInfoEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/BD/BDProjectAdditionalInfo.ascx" TagName="BDProjectAdditionalInfoEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/BD/BDProjectFloor.ascx" TagName="BDProjectFloorEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/BD/BDProjectFloorUnit.ascx" TagName="BDProjectFloorUnitEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/BD/BDProjectParking.ascx" TagName="BDProjectParkingEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/BD/BDProjectLift.ascx" TagName="BDProjectLiftEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/BD/BDProjectWaterReservior.ascx" TagName="BDProjectWaterReserviorEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/BD/BDProjectSubstationAndGenerator.ascx" TagName="BDProjectSubstationAndGeneratorEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/BD/BDProjectImageGallery.ascx" TagName="BDProjectImageGalleryEntity"
    TagPrefix="uc" %>
<%@ Register Src="~/Controls/BD/BDProjectUnitLocation.ascx" TagName="BDProjectUnitLocationEntity" 
    TagPrefix="uc" %>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
            Sys.Application.add_load(BindEventss);
        </script>
        <div>
            <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
                <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
            </div>
            <div>
                <div class="i" style="text-align:right;">
                    <asp:HyperLink ID="hypProjectReport" runat="server" CssClass="CommonButtonLink" Text="Project Report" 
                    CommandName="ProjectReport" CommandArgument='<%#Eval("ProjectID")%>' UniqueKey="BDProjectListControl_lvBDProject_ProjectReport_key">
                    </asp:HyperLink>
                </div>
                <br />
                <asp:HiddenField ID="hidLastTab" runat="server" Value="0" />
                <div id="tabs">
                    <ul>
                        <li><a href="#ProjectEditor">Project Info</a></li>
                        <li><a href="#ProjectOtherTool">Other Info</a></li>
                        <li><a href="#ProjectAdditionInfo">Additional Info</a></li>
                        <li><a href="#ProjectParking">Parking</a></li>
                        <li><a href="#ProjectLift">Lift</a></li>
                        <li><a href="#ProjectWaterReservior">Water</a></li>
                        <li><a href="#ProjectSubstationAndGenerator">Substation & Generator</a></li>
                        <li><a href="#ProjectFloorInfo">Floor</a></li>
                        <li><a href="#ProjectFloorUnitInfo">Floor Unit</a></li>
                        <li><a href="#ProjectUnitLocation">Unit Location</a></li>
                        <li><a href="#ProjectImageGallery">Image Gallery</a></li>
                    </ul>
                    <div id="ProjectFloorInfo">
                        <uc:BDProjectFloorEntity ID="ucBDProjectFloorEntity" runat="server" />
                    </div>
                    <div id="ProjectFloorUnitInfo">
                        <uc:BDProjectFloorUnitEntity ID="ucBDProjectFloorUnitEntity" runat="server" />
                    </div>
                    <div id="ProjectUnitLocation">
                        <uc:BDProjectUnitLocationEntity ID="ucBDProjectUnitLocationEntity" runat="server" />    
                    </div>
                    <div id="ProjectImageGallery">
                        <uc:BDProjectImageGalleryEntity ID="ucBDProjectImageGalleryEntity" runat="server" />
                    </div>
                    <div id="ProjectParking">
                        <uc:BDProjectParkingEntity ID="ucBDProjectParkingEntity" runat="server" />
                    </div>
                    <div id="ProjectLift">
                        <uc:BDProjectLiftEntity ID="ucBDProjectLiftEntity" runat="server" />
                    </div>
                    <div id="ProjectWaterReservior">
                        <uc:BDProjectWaterReserviorEntity ID="ucBDProjectWaterReserviorEntity" runat="server" />
                    </div>
                    <div id="ProjectSubstationAndGenerator">
                        <uc:BDProjectSubstationAndGeneratorEntity ID="ucBDProjectSubstationAndGeneratorEntity"
                            runat="server" />
                    </div>
                    <div id="ProjectEditor">
                        <uc:BDProjectEditorEntity ID="ucBDProjectEditorEntity" runat="server" />
                    </div>
                    <div id="ProjectOtherTool">
                        <uc:BDProjectOtherInfoEntity ID="ucBDProjectOtherInfoEntity" runat="server" />
                    </div>
                    <div id="ProjectAdditionInfo">
                        <uc:BDProjectAdditionalInfoEntity ID="ucBDProjectAdditionalInfoEntity" runat="server" />
                    </div>
                </div>
                <%--<asp:Button ID="btnSubmit" ValidationGroup="BDProjectIntoTabViewEntity" OnClick="btnSave_Click" UniqueKey="BDProjectInfoTabViewControl_Submit_key"  runat="server" Text="Update ALL"  />--%>
            </div>
        </div>
    </ContentTemplate>
</asp:UpdatePanel>
