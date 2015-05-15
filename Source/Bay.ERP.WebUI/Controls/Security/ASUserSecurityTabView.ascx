<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:49:46
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="ASUserSecurityTabView.ascx.cs"
    Inherits="Bay.ERP.Web.UI.ASUserSecurityTabViewControl" %>
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
<%@ Register Src="~/Controls/HR/HRMember.ascx" TagName="HRMemberEntity" TagPrefix="uc" %>
<%@ Register Src="~/Controls/HR/HREmployee.ascx" TagName="HREmployeeEntity" TagPrefix="uc" %>
<%@ Register Src="~/Controls/Security/ASRoleList.ascx" TagName="ASRoleListEntity" TagPrefix="uc" %>
<%@ Register Src="~/Controls/Security/ASCreateNewRole.ascx" TagName="ASCreateNewRoleEntity" TagPrefix="uc"%>
<%@ Register Src="~/Controls/BD/BDProjectAssignedPerson.ascx" TagName="BDProjectAssignedPersonEntity" TagPrefix="uc" %>

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
             <asp:HiddenField ID="hidLastTab" runat="server" Value="0" />
                <div id="tabs">
                    <ul>
                        <li><a href="#Employee">Employee</a></li>
                        <li><a href="#HRMember">Membership</a></li>
                        <li><a href="#Role">Role</a></li>
                        <li><a href="#RoleList" style="display:none;">Role List</a></li>
                        <li><a href="#ProjectAssignedRole">Project Role</a></li>
                    </ul>
                    <div id="Employee">
                     <uc:HREmployeeEntity ID="ucHREmployeeEntity" runat="server" />
                    </div>
                    <div id="HRMember">
                         <uc:HRMemberEntity ID="ucHRMemberEntity" runat="server" />    
                     </div>
                    <div id="Role">
                       <uc:ASCreateNewRoleEntity ID="ucASCreateNewRoleEntity" runat="server" />
                       <br />
                       <uc:ASRoleListEntity ID="ucASRoleListEntity"  runat="server" />
                    </div>
                    <div id="RoleList" style="display:none;">
                       
                    </div>
                      <div id="ProjectAssignedRole">
                       <uc:BDProjectAssignedPersonEntity ID="ucBDProjectAssignedPersonEntity" runat="server" />
                    </div>
                </div>
                </div>
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
