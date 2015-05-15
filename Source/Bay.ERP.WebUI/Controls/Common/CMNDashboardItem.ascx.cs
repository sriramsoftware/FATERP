// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Feb-2012, 06:02:47




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.IO;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class CMNDashboardItemControl : BaseControl
    {       
        #region Properties

        public Int64 _DashboardItemID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public CMNDashboardItemEntity _CMNDashboardItemEntity
        {
            get
            {
                CMNDashboardItemEntity entity = new CMNDashboardItemEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (CMNDashboardItemEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private CMNDashboardItemEntity CurrentCMNDashboardItemEntity
        {
            get
            {
                if (_DashboardItemID > 0)
                {
                    if (_CMNDashboardItemEntity.DashboardItemID != _DashboardItemID)
                    {
                        _CMNDashboardItemEntity = FCCCMNDashboardItem.GetFacadeCreate().GetByID(_DashboardItemID);
                    }
                }

                return _CMNDashboardItemEntity;
            }
            set
            {
                _CMNDashboardItemEntity = value;
            }
        }

        #endregion

        #region Methods

        private void GetMaxSequenceID()
        {
            String fe = String.Empty;
            Int64 MaxSequenceID=0;
            IList<CMNDashboardItemEntity> DashboardItemList = new List<CMNDashboardItemEntity>();

            if (_DashboardItemID > 0)
            {
                rfvImageUrl.Enabled = false;
            }
            if (ddlParentDashboardItemID.SelectedValue != "0")
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemEntity.FLD_NAME_ParentDashboardItemID, ddlParentDashboardItemID.SelectedValue, SQLMatchType.Equal);
                DashboardItemList = FCCCMNDashboardItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                if (DashboardItemList != null && DashboardItemList.Count > 0)
                {
                    Int64.TryParse(DashboardItemList[DashboardItemList.Count - 1].SequenceID.ToString(), out MaxSequenceID);
                }
            }

            if (ddlParentDashboardItemID.SelectedValue == "0")
            {
                fe = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemEntity.FLD_NAME_ParentDashboardItemID, String.Empty, SQLMatchType.IsNull);
                DashboardItemList = FCCCMNDashboardItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                if (DashboardItemList != null && DashboardItemList.Count > 0)
                {
                    Int64.TryParse(DashboardItemList[DashboardItemList.Count - 1].SequenceID.ToString(), out MaxSequenceID);
                }
            }
            
            txtSequenceID.Text =(MaxSequenceID + 1).ToString();

            #region Only Display region

            if (_DashboardItemID > 0 && ddlParentDashboardItemID.SelectedValue == CurrentCMNDashboardItemEntity.ParentDashboardItemID.ToString())
            {
                txtSequenceID.Text = CurrentCMNDashboardItemEntity.SequenceID.ToString();
            }

            #endregion
        }

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMNDashboardItem(ddlParentDashboardItemID, true);
        }

        private void PrepareValidator()
        {
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            txtTitle.Text = String.Empty;
            txtTittleColor.Text = "Green";
            txtDescription.Text = String.Empty;
            txtDescriptionColor.Text = "Green";
            GetMaxSequenceID();
            txtNavigationUrl.Text = String.Empty;
            chkIsPopup.Checked = false;
            txtHoverMessage.Text = String.Empty;
            txtImageWidth.Text = "46";
            txtImageHeight.Text ="49";
            txtDashboardItemWidth.Text ="165";
            txtDashboardItemHeight.Text = "50";
            chkIsRemoved.Checked = false;

            btnSubmit.Text = "Add";
            btnAddNew.Visible = false;
            rfvImageUrl.Enabled = true;
        }

        private void PrepareEditView()
        {
            CMNDashboardItemEntity cMNDashboardItemEntity = CurrentCMNDashboardItemEntity;


            if (!cMNDashboardItemEntity.IsNew)
            {
                if (ddlParentDashboardItemID.Items.Count > 0 && cMNDashboardItemEntity.ParentDashboardItemID != null)
                {
                    ddlParentDashboardItemID.SelectedValue = cMNDashboardItemEntity.ParentDashboardItemID.ToString();
                }
                if (ddlParentDashboardItemID.Items.Count > 0 && !cMNDashboardItemEntity.ParentDashboardItemID.HasValue)
                {
                    ddlParentDashboardItemID.SelectedValue = "0";
                }

                txtTitle.Text = cMNDashboardItemEntity.Title.ToString();
                txtTittleColor.Text = cMNDashboardItemEntity.TittleColor.ToString();
                txtDescription.Text = cMNDashboardItemEntity.Description.ToString();
                txtDescriptionColor.Text = cMNDashboardItemEntity.DescriptionColor.ToString();
                txtNavigationUrl.Text = cMNDashboardItemEntity.NavigationUrl.ToString();
                chkIsPopup.Checked = cMNDashboardItemEntity.IsPopup;
                txtHoverMessage.Text = cMNDashboardItemEntity.HoverMessage.ToString();
                txtSequenceID.Text = CurrentCMNDashboardItemEntity.SequenceID.ToString();
                txtImageWidth.Text = cMNDashboardItemEntity.ImageWidth.ToString();
                txtImageHeight.Text = cMNDashboardItemEntity.ImageHeight.ToString();
                txtDashboardItemWidth.Text = cMNDashboardItemEntity.DashboardItemWidth.ToString();
                txtDashboardItemHeight.Text = cMNDashboardItemEntity.DashboardItemHeight.ToString();
                chkIsRemoved.Checked = cMNDashboardItemEntity.IsRemoved;
                rfvImageUrl.Enabled = false;
                btnSubmit.Text = "Update";
                btnAddNew.Visible = true;
            }
        }

        private void BindList()
        {
            BindCMNDashboardItemList();
        }

        private void BindCMNDashboardItemList()
        {
            lvCMNDashboardItem.DataBind();
        }

        private CMNDashboardItemEntity BuildCMNDashboardItemEntity()
        {
            CMNDashboardItemEntity cMNDashboardItemEntity = CurrentCMNDashboardItemEntity;

            if (ddlParentDashboardItemID.Items.Count > 0)
            {
                if (ddlParentDashboardItemID.SelectedValue == "0")
                {
                    cMNDashboardItemEntity.ParentDashboardItemID = null;
                }
                else
                {
                    cMNDashboardItemEntity.ParentDashboardItemID = Int64.Parse(ddlParentDashboardItemID.SelectedValue);
                }
            }

            cMNDashboardItemEntity.Title = txtTitle.Text.Trim();
            cMNDashboardItemEntity.TittleColor = txtTittleColor.Text.Trim();
            cMNDashboardItemEntity.Description = txtDescription.Text.Trim();
            cMNDashboardItemEntity.DescriptionColor = txtDescriptionColor.Text.Trim();

            #region File Upload Manipulation

            if (fuImageUrl.HasFile == true && cMNDashboardItemEntity.ImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(CurrentCMNDashboardItemEntity.ImageUrl)))
                {
                    File.Delete(Server.MapPath(CurrentCMNDashboardItemEntity.ImageUrl));
                }
                String ImageUrlpath;
                ImageUrlpath = FileUploadConstants.DashboardItem.DashboardItemImageUrl + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));

                cMNDashboardItemEntity.ImageUrl = ImageUrlpath;
            }

            if (fuImageUrl.HasFile == false && cMNDashboardItemEntity.ImageUrl.IsNotNullOrEmpty())
            {
                cMNDashboardItemEntity.ImageUrl = cMNDashboardItemEntity.ImageUrl;
            }

            if (fuImageUrl.HasFile == true && cMNDashboardItemEntity.ImageUrl.IsNullOrEmpty())
            {
                String ImageUrlpath;
                ImageUrlpath = FileUploadConstants.DashboardItem.DashboardItemImageUrl + Guid.NewGuid() + fuImageUrl.FileName;
                fuImageUrl.SaveAs(Server.MapPath(ImageUrlpath));

                cMNDashboardItemEntity.ImageUrl = ImageUrlpath;
            }
            String HoverImageUrlpath;

            if (fuHoverImageUrl.HasFile == true && cMNDashboardItemEntity.HoverImageUrl.IsNotNullOrEmpty())
            {
                if (File.Exists(Server.MapPath(cMNDashboardItemEntity.HoverImageUrl)))
                {
                    File.Delete(Server.MapPath(cMNDashboardItemEntity.HoverImageUrl));
                }
                HoverImageUrlpath = FileUploadConstants.DashboardItem.DashboardItemHoverImageUrl + Guid.NewGuid() + fuHoverImageUrl.FileName;
                fuHoverImageUrl.SaveAs(Server.MapPath(HoverImageUrlpath));
                cMNDashboardItemEntity.HoverImageUrl = HoverImageUrlpath;
            }

            if (cMNDashboardItemEntity.HoverImageUrl.IsNotNullOrEmpty()&&fuHoverImageUrl.HasFile==false)
            {
                cMNDashboardItemEntity.HoverImageUrl = cMNDashboardItemEntity.HoverImageUrl;
            }

            if (fuHoverImageUrl.HasFile == false && cMNDashboardItemEntity.HoverImageUrl.IsNullOrEmpty())
            {
                cMNDashboardItemEntity.HoverImageUrl = null;
            }

            if (fuHoverImageUrl.HasFile == true && cMNDashboardItemEntity.HoverImageUrl.IsNullOrEmpty())
            {
                HoverImageUrlpath = FileUploadConstants.DashboardItem.DashboardItemHoverImageUrl + Guid.NewGuid() + fuHoverImageUrl.FileName;
                fuHoverImageUrl.SaveAs(Server.MapPath(HoverImageUrlpath));
                cMNDashboardItemEntity.HoverImageUrl = HoverImageUrlpath;
            }

            #endregion

            cMNDashboardItemEntity.NavigationUrl = txtNavigationUrl.Text.Trim();
            cMNDashboardItemEntity.IsPopup = chkIsPopup.Checked;

            cMNDashboardItemEntity.HoverMessage = txtHoverMessage.Text.Trim();

            //Save Sequence ID 
            if (_DashboardItemID > 0 && ddlParentDashboardItemID.SelectedValue == CurrentCMNDashboardItemEntity.SequenceID.ToString())
            {
                cMNDashboardItemEntity.SequenceID = CurrentCMNDashboardItemEntity.SequenceID;
            }
            else
            {

                if (!txtSequenceID.Text.Trim().IsNullOrEmpty())
                {
                    cMNDashboardItemEntity.SequenceID = Int32.Parse(txtSequenceID.Text.Trim());
                }
            }

            if (!txtImageWidth.Text.Trim().IsNullOrEmpty())
            {
                cMNDashboardItemEntity.ImageWidth = Int32.Parse(txtImageWidth.Text.Trim());
            }

            if (!txtImageHeight.Text.Trim().IsNullOrEmpty())
            {
                cMNDashboardItemEntity.ImageHeight = Int32.Parse(txtImageHeight.Text.Trim());
            }

            if (!txtDashboardItemWidth.Text.Trim().IsNullOrEmpty())
            {
                cMNDashboardItemEntity.DashboardItemWidth = Int32.Parse(txtDashboardItemWidth.Text.Trim());
            }

            if (!txtDashboardItemHeight.Text.Trim().IsNullOrEmpty())
            {
                cMNDashboardItemEntity.DashboardItemHeight = Int32.Parse(txtDashboardItemHeight.Text.Trim());
            }

            cMNDashboardItemEntity.IsRemoved = chkIsRemoved.Checked;


            return cMNDashboardItemEntity;
        }

        private void SaveCMNDashboardItemEntity()
        {
            if (IsValid)
            {
                try
                {
                    CMNDashboardItemEntity cMNDashboardItemEntity = BuildCMNDashboardItemEntity();

                    Int64 result = -1;

                    if (cMNDashboardItemEntity.IsNew)
                    {
                        result = FCCCMNDashboardItem.GetFacadeCreate().Add(cMNDashboardItemEntity, DatabaseOperationType.Add, TransactionRequired.No);
                    }
                    else
                    {
                        String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemEntity.FLD_NAME_DashboardItemID, cMNDashboardItemEntity.DashboardItemID.ToString(), SQLMatchType.Equal);
                        result = FCCCMNDashboardItem.GetFacadeCreate().Update(cMNDashboardItemEntity, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
                    }

                    if (result > 0)
                    {
                        _DashboardItemID = 0;
                        _CMNDashboardItemEntity = new CMNDashboardItemEntity();
                        PrepareInitialView();
                        BindCMNDashboardItemList();

                        if (cMNDashboardItemEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Dashboard Item Information has been added successfully.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Dashboard Item Information has been updated successfully.", false);
                        }
                    }
                    else
                    {
                        if (cMNDashboardItemEntity.IsNew)
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to add Dashboard Item Information.", false);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to update Dashboard Item Information.", false);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                }
            }
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareValidator();
                PrepareInitialView();
                PrepareEditView();
            }
        }

        #endregion

        #region List View Event

        protected void lvCMNDashboardItem_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            Int64 DashboardItemID;

            Int64.TryParse(e.CommandArgument.ToString(), out DashboardItemID);

            if (DashboardItemID > 0)
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    _DashboardItemID = DashboardItemID;

                    PrepareEditView();

                    cpeEditor.Collapsed = false;
                    cpeEditor.ClientState = "false";
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Int64 result = -1;

                        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemEntity.FLD_NAME_DashboardItemID, DashboardItemID.ToString(), SQLMatchType.Equal);

                        CMNDashboardItemEntity cMNDashboardItemEntity = FCCCMNDashboardItem.GetFacadeCreate().GetByID(DashboardItemID);


                        result = FCCCMNDashboardItem.GetFacadeCreate().Delete(cMNDashboardItemEntity, fe, DatabaseOperationType.Delete, TransactionRequired.No);
                     
                        if (result == 0)
                        {
                            if (File.Exists(Server.MapPath(cMNDashboardItemEntity.ImageUrl)))
                            {
                                File.Delete(Server.MapPath(cMNDashboardItemEntity.ImageUrl));
                            }
                            if (File.Exists(Server.MapPath(cMNDashboardItemEntity.HoverImageUrl)))
                            {
                                File.Delete(Server.MapPath(cMNDashboardItemEntity.HoverImageUrl));
                            }
                            _DashboardItemID = 0;
                            _CMNDashboardItemEntity = new CMNDashboardItemEntity();

                            PrepareInitialView();
                            BindCMNDashboardItemList();

                            MiscUtil.ShowMessage(lblMessage, "Dashboard Item has been successfully deleted.", true);
                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Dashboard Item.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion List View Event

        #region ObjectDataSource Event

        protected void odsCMNDashboardItem_Selecting(object sender, ObjectDataSourceSelectingEventArgs e)
        {
            e.InputParameters["filterExpression"] = String.Empty;
        }

        #endregion

        #region Button Event

        protected void btnSave_Click(object sender, EventArgs e)
        {
            SaveCMNDashboardItemEntity();
        }

        protected void btnAddNew_Click(object sender, EventArgs e)
        {
            _DashboardItemID = 0;
            _CMNDashboardItemEntity = new CMNDashboardItemEntity();
            PrepareInitialView();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            PrepareInitialView();
            PrepareEditView();
        }

        #endregion

        #region Dropdown Event

        protected void ddlParentDashboardItemID_SelectedIndexChanged(object sender, EventArgs e)
        {
            GetMaxSequenceID();
        }

        #endregion

        #endregion Event
    }
}
