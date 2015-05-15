// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    public partial class OTConsultantIssueScheduleControl : BaseControl
    {
        #region Properties

        public String Action
        {
            get
            {
                String action = "Add";

                if (ViewState["do"] != null)
                {
                    action = ViewState["do"].ToString();
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["do"].ToString()))
                {
                    action = Helper.Url.SecureUrl["do"].ToString();

                    ViewState["do"] = action;
                }

                return action;
            }
            set
            {
                ViewState["do"] = value;
            }
        }

        public Int64 _IssueID
        {
            get
            {
                Int64 id = 0;

                if (ViewState["ID"] != null)
                {
                    Int64.TryParse(ViewState["ID"].ToString(), out id);
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_ID]))
                {
                    Int64.TryParse(Helper.Url.SecureUrl[UrlConstants.OVERVIEW_ISSUE_ID], out id);
                    ViewState["ID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public Int64? _ParentIssueID
        {
            get
            {
                Int64? id = null;

                if (ViewState["ParentIssueID"] != null)
                {
                    id = Int64.Parse(ViewState["ParentIssueID"].ToString());
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["ParentIssueID"]))
                {
                    id = Int64.Parse(Helper.Url.SecureUrl["ParentIssueID"].ToString());
                    ViewState["ParentIssueID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ID"] = value;
            }
        }

        public Int64? _ReferenceIssueID
        {
            get
            {
                Int64? id = null;

                if (ViewState["ReferenceIssueID"] != null)
                {
                    id = Int64.Parse(ViewState["ReferenceIssueID"].ToString());
                }
                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["ReferenceIssueID"]))
                {
                    id = Int64.Parse(Helper.Url.SecureUrl["ReferenceIssueID"].ToString());
                    ViewState["ReferenceIssueID"] = id;
                }

                return id;
            }
            set
            {
                ViewState["ReferenceIssueID"] = value;
            }
        }

        public OTIssueEntity _OTIssueEntity
        {
            get
            {
                OTIssueEntity entity = new OTIssueEntity();

                if (ViewState["CurrentEntity"] != null)
                {
                    entity = (OTIssueEntity)ViewState["CurrentEntity"];
                }

                return entity;
            }
            set
            {
                ViewState["CurrentEntity"] = value;
            }
        }

        private OTIssueEntity CurrentOTIssueEntity
        {
            get
            {
                if (_IssueID > 0)
                {
                    if (_OTIssueEntity.IssueID != _IssueID)
                    {
                        _OTIssueEntity = FCCOTIssue.GetFacadeCreate().GetByID(_IssueID);
                    }
                }

                return _OTIssueEntity;
            }
            set
            {
                _OTIssueEntity = value;
            }
        }

        #endregion

        #region Methods

        private void BuildDropDownList()
        {
            MiscUtil.PopulateCMConsultant(ddlConsultantID, false);
            SetResourceIDByDropdown();
        }

        private void PrepareValidator()
        {
        }

        private void SetResourceIDByDropdown()
        {
            if (ddlConsultantID.SelectedValue != "0" && ddlConsultantID.Items.Count > 0)
            {
                hfOverviewResourceID.Value = ddlConsultantID.SelectedValue.ToString();
            }
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();

            #region Decision

            //Set The Resource Category Here.
            hfOverviewResourceCategoryID.Value = MasterDataConstants.ResourceCategory.CONSULTANT.ToString();

            #endregion
        }

        private void PrepareEditView()
        {
      
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

        #region Dropdown Event

        protected void ddlConsultantID_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetResourceIDByDropdown();
        }

        #endregion

        #endregion Event
    }
}
