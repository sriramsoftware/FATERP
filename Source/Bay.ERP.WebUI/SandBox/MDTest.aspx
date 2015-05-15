<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 30-Nov-2011, 02:42:57
--%>




<%@ Page Language="C#" MasterPageFile="~/Template/Default.master" AutoEventWireup="true" CodeFile="MDTest.aspx.cs" Inherits="Bay.ERP.Web.UI.MDTestPage" Title="Bay's ERP New" culture="auto" meta:resourcekey="PageResource1" uiculture="auto" %>


<asp:Content ID="cntHeader" ContentPlaceHolderID="cphHeader" runat="Server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="cphPageTitle" runat="Server">
    <h1>HRM</h1>
</asp:Content>
<asp:Content ID="cntContent" ContentPlaceHolderID="cphContent" runat="Server">
    <div style="width: 1100px;">
        <%--<uc:MDCityEntity ID="ucMDCityEntity" runat="server" />--%>
      
        <div id=iframehrm>
            <iframe src="http://192.168.0.4/bayhrdept/" scrolling=auto align="top" 
                height="600" width="811">
            </iframe>
                        
        </div>
    </div>
</asp:Content>
<asp:Content ID="Content4" ContentPlaceHolderID="cphQuickLinks" runat="Server">
    <div style="width: 5px;">
    </div>
</asp:Content>
