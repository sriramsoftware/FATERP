// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Feb-2010, 12:41:01




using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class ASRoleListPage : BasePage
    {
        #region Veriables

        #endregion

        #region Properties

        public override string UniqueKey
        {
            get
            {
                return "ASRoleListPage";
            }
        }

        public override string WebUserControlPaths
        {
            get
            {
                return "~/Controls/Security/ASRoleList.ascx;";
            }
        }

        #endregion

        #region Methods



        #endregion

        #region Events

        protected void Page_Load(object sender, EventArgs e)
        {
            base.Page.Title = String.Concat("List of Roles", " - ", base.Page.Title);

            ucASRoleListEntity.ContentHolderPageUrl = "~/Security/ASRoleList.aspx";

            if (!IsPostBack)
            {
                //for (int i = 0; i < 200; i++)
                //{

                //    Geekees.Common.Controls.ASTreeViewNode node = new Geekees.Common.Controls.ASTreeViewNode(i.ToString());
                   
                //    Geekees.Common.Controls.ASTreeViewNode Childnode = new Geekees.Common.Controls.ASTreeViewNode("Child");
                //    node.ChildNodes.Add(Childnode);
                //    astvMyTree.RootNode.AppendChild(node);
                //}
            }
        }

        //#region Tree Event

        //protected void btnToggleDragDrop_Click(object sender, EventArgs e)
        //{
        //    this.astvMyTree.EnableDragDrop = !this.astvMyTree.EnableDragDrop;
        //}

        //protected void btnToggleTreeLines_Click(object sender, EventArgs e)
        //{
        //    this.astvMyTree.EnableTreeLines = !this.astvMyTree.EnableTreeLines;
        //}

        //protected void btnToggleNodeIcon_Click(object sender, EventArgs e)
        //{
        //    this.astvMyTree.EnableNodeIcon = !this.astvMyTree.EnableNodeIcon;
        //}

        //protected void btnToggleCheckbox_Click(object sender, EventArgs e)
        //{
        //    this.astvMyTree.EnableCheckbox = !this.astvMyTree.EnableCheckbox;
        //}

        //protected void btnToggleDefaultNodeIcon_Click(object sender, EventArgs e)
        //{
        //    this.astvMyTree.EnableCustomizedNodeIcon =
        //            !this.astvMyTree.EnableCustomizedNodeIcon;
        //}

        //protected void btnToggleContextMenu_Click(object sender, EventArgs e)
        //{
        //    this.astvMyTree.EnableContextMenu = !this.astvMyTree.EnableContextMenu;
        //}



        //#endregion

        #endregion
    }
}
