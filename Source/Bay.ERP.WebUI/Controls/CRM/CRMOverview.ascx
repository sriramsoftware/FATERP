<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 B2B Solutions, info@b2b-erp.com.
 ©2006 – 2010.

 Code Generate Time - 22-Jan-2013, 03:28:28
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="CRMOverview.ascx.cs"
    Inherits="Bay.ERP.Web.UI.CRMOverviewControl" %>

<%@ Register Src="~/Controls/CRM/CRMBuyerBasicInfo.ascx" TagName="CRMBuyerBasicInfoEntity" TagPrefix="uc" %>

<style type="text/css">
        #tabs
        {
            padding: 0px;
            border: 0px solid;            
            font-size: 11px;
        }        
        #tab-contents
        {
            background-image: url(../Images/reza/box-mm.png);
            background-repeat: repeat-x repeat-y;            
            background-repeat:repeat;
            border-left: 1px solid #aaaaaa;
            border-right: 1px solid #aaaaaa;
            border-bottom: 1px solid #aaaaaa;
            width: 100%;
            height: auto;
           /* min-height:400px;*/
            
        }
    </style>

<script type="text/javascript">
    function BindEvents() {
        $(document).ready(function () {
            $("#CRMOverviewtabs").tabs();
        });
    }
</script>
<asp:UpdatePanel ID="upMauin" runat="server">
    <ContentTemplate>
        <script type="text/javascript">
            Sys.Application.add_load(BindEvents);
        </script>
        <div id="Div1" class="TableRow" style="text-align: left;" runat="server">
            <asp:Label ID="lblMessage" EnableViewState="false" runat="server"></asp:Label>
        </div>
        <div>
            <div id="CRMOverviewtabs">
                <ul>
                    <li><a href="#BuyerInfo">Buyer Info</a></li>
                    <li><a href="#Communication">Communication</a></li>
                    <li><a href="#ExistingBuyerInfo">Existing Buyer</a></li>
                </ul>
                <div id="BuyerInfo">
               
                </div>
                <div id="Communication">
                 </div>
                <div id="ExistingBuyerInfo">
                </div>
                </div>
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
