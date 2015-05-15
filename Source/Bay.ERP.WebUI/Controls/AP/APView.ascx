<%--
 Copyright and All Rights Reserved by
B2B Solutions;

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 03-Oct-2012, 03:53:48
--%>
<%@ Control Language="C#" AutoEventWireup="true" CodeFile="APView.ascx.cs" Inherits="Bay.ERP.Web.UI.APViewControl" %>
<style type="text/css">
    .apStepsContainer
    {
        width: auto;
        height: auto;
        border: 1px solid gray;
        padding: 15px;
        display: inline-block;
    }
    
    .apStepsContainer .apStep
    {
        width: 170px;
        height: 350px;
        border: 0px;
        padding: 10px;
        margin-left: 10px;
        border-width: 3px;
        border-style: solid;
        display: inline-block;
        float: left;
    }
    
    .apStepsContainer .apStepSeperator
    {
        margin-left: 0px;
        display: inline-block;
        width: 42px;
        height: 300px;
        padding-top: 115px;
        float: left;
    }
    
    .apStepsContainer .apStep .lbl
    {
        font-weight: bold;
    }
    
    .apStepsContainer .apStep .cnt
    {
        margin-top: 3px;
        margin-bottom: 10px;
    }
    
    .apStepsContainer .currentStep
    {
        border-width: 5px;
        border-style: dotted;
    }
    
    .apStepsContainer .green
    {
        border-color: Green;
    }
    
    .apStepsContainer .red
    {
        border-color: Red;
    }
    
    .apStepsContainer .yellow
    {
        border-color: yellow;
    }
    
    .apStepsContainer .gray
    {
        border-color: gray;
    }
    
    .imgRound
    {
    border-radius: 50%;
    vertical-align: middle;
    background: none repeat scroll 0 0 #FFFFFF;
    border: 2px solid #FFFFFF;
    }
</style>
<div>
    <div id="div" runat="server" class="apStepsContainer">
        <%--<div class="apStep green">
            <div class="cnt">
                <table width="100%">
                    <tr>
                        <td>
                            <asp:Image ID="imgAssignedTo" runat="server" BorderColor="Gray" BorderWidth="1" BorderStyle="Solid"
                                ImageAlign="AbsMiddle" ImageUrl="~/Images/user.png" />
                        </td>
                        <td align="center" style="font-size: 18px; font-weight: bold">
                            Step: 1
                        </td>
                    </tr>
                </table>
            </div>
            <div class="lbl">
                Assigned To</div>
            <div class="cnt">
                Mr. Asaduzzaman Islam Chowduri</div>
            <div class="lbl">
                Approval Status</div>
            <div class="cnt">
                Working On Approval</div>
            <div class="lbl">
                Assign Date</div>
            <div class="cnt">
                10-10-2012</div>
            <div class="lbl">
                Last Response</div>
            <div class="cnt">
                20-10-2012</div>
            <div class="lbl">
                Feedback Date</div>
            <div class="cnt">
                NA</div>
        </div>
        <div class="apStepSeperator">
            <asp:Image ID="imgArrow" runat="server" BorderColor="Gray" BorderWidth="0" BorderStyle="Solid"
                ImageAlign="AbsMiddle" ImageUrl="~/Images/ap-arrow-right.png" />
        </div>
        <div class="apStep red currentStep">
            <div class="cnt">
                <table width="100%">
                    <tr>
                        <td>
                            <asp:Image ID="Image1" runat="server" BorderColor="Gray" BorderWidth="1" BorderStyle="Solid"
                                ImageAlign="AbsMiddle" ImageUrl="~/Images/user.png" />
                        </td>
                        <td align="center" style="font-size: 18px; font-weight: bold">
                            Step: 2
                        </td>
                    </tr>
                </table>
            </div>
            <div class="lbl">
                Assigned To</div>
            <div class="cnt">
                Mr. Asaduzzaman Islam Chowduri</div>
            <div class="lbl">
                Approval Status</div>
            <div class="cnt">
                Working On Approval</div>
            <div class="lbl">
                Assign Date</div>
            <div class="cnt">
                10-10-2012</div>
            <div class="lbl">
                Last Response</div>
            <div class="cnt">
                20-10-2012</div>
            <div class="lbl">
                Feedback Date</div>
            <div class="cnt">
                NA</div>
        </div>
        <div class="apStepSeperator">
            <asp:Image ID="Image5" runat="server" BorderColor="Gray" BorderWidth="0" BorderStyle="Solid"
                ImageAlign="AbsMiddle" ImageUrl="~/Images/ap-arrow-right.png" />
        </div>
        <div class="apStep yellow currentStep">
            <div class="cnt">
                <table width="100%">
                    <tr>
                        <td>
                            <asp:Image ID="Image2" runat="server" BorderColor="Gray" BorderWidth="1" BorderStyle="Solid"
                                ImageAlign="AbsMiddle" ImageUrl="~/Images/user.png" />
                        </td>
                        <td align="center" style="font-size: 18px; font-weight: bold">
                            Step: 3
                        </td>
                    </tr>
                </table>
            </div>
            <div class="lbl">
                Assigned To</div>
            <div class="cnt">
                Mr. Asaduzzaman Islam Chowduri</div>
            <div class="lbl">
                Approval Status</div>
            <div class="cnt">
                Working On Approval</div>
            <div class="lbl">
                Assign Date</div>
            <div class="cnt">
                10-10-2012</div>
            <div class="lbl">
                Last Response</div>
            <div class="cnt">
                20-10-2012</div>
            <div class="lbl">
                Feedback Date</div>
            <div class="cnt">
                NA</div>
        </div>
        <div class="apStepSeperator">
            <asp:Image ID="Image6" runat="server" BorderColor="Gray" BorderWidth="0" BorderStyle="Solid"
                ImageAlign="AbsMiddle" ImageUrl="~/Images/ap-arrow-right.png" />
        </div>
        <div class="apStep gray">
            <div class="cnt">
                <table width="100%">
                    <tr>
                        <td>
                            <asp:Image ID="Image3" runat="server" BorderColor="Gray" BorderWidth="1" BorderStyle="Solid"
                                ImageAlign="AbsMiddle" ImageUrl="~/Images/user.png" />
                        </td>
                        <td align="center" style="font-size: 18px; font-weight: bold">
                            Step: 4
                        </td>
                    </tr>
                </table>
            </div>
            <div class="lbl">
                Assigned To</div>
            <div class="cnt">
                Mr. Asaduzzaman Islam Chowduri</div>
            <div class="lbl">
                Approval Status</div>
            <div class="cnt">
                Working On Approval</div>
            <div class="lbl">
                Assign Date</div>
            <div class="cnt">
                10-10-2012</div>
            <div class="lbl">
                Last Response</div>
            <div class="cnt">
                20-10-2012</div>
            <div class="lbl">
                Feedback Date</div>
            <div class="cnt">
                NA</div>
        </div>
        <div style="clear: both;">
        </div>--%>
    </div>
</div>
