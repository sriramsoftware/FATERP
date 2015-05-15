<%--
 Copyright and All Rights Reserved by
 B2B Solution

 Moshiur Rahman Reza, moshiur.rahman.reza@gmail.con
 ©2006 – 2010.

 Code Generate Time - 28-Dec-2011, 07:18:54
--%>




<%@ Control Language="C#" AutoEventWireup="true" CodeFile="BDProjectMilestoneSetup.ascx.cs"
    Inherits="Bay.ERP.Web.UI.BDProjectMilestoneSetupControl" %>

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
            <div class="TableRow" style="width: 100;">
                <kti:BayProjectIssueTreeView ID="treeProjectSchedule" runat="server" onclick="OnTreeClick(event)" ShowCheckBoxesInDocumentNodes="true" ShowCheckBoxes="All">
                </kti:BayProjectIssueTreeView>
            </div>
            <div class="TableRow" style="width: 100;">
                <kti:SecureButton ID="btnSubmit" runat="server" Text="Update" UniqueKey="BDProjectMilestoneSetupControl_Submit_key" OnClick="btnSubmit_Click"/>
            </div>
    </ContentTemplate>
</asp:UpdatePanel>
