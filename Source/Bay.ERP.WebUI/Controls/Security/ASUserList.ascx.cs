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
using System.Web.UI.WebControls;
using System.Collections.Generic;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Web.Security;
using System.Data;

namespace Bay.ERP.Web.UI
{
    public partial class SecurityASUserListControl : BaseControl
    {       
        #region Member Variables

        private static Int64 _ASSiteMapID = 0;

        ASSiteMapEntity _aSSiteMapEntity;

        #endregion
        
        #region Properties

        private ASSiteMapEntity CurrentASSiteMapEntity
        {
            get
            {
                if (_aSSiteMapEntity == null)
                {
                    if (!StringHelper.IsBlank(Helper.Url.SecureUrl[ASSiteMapEntity.FLD_NAME_ASSiteMapID]))
                    {
                        _ASSiteMapID = Convert.ToInt64(Helper.Url.SecureUrl[ASSiteMapEntity.FLD_NAME_ASSiteMapID]);

                        if (_ASSiteMapID > 0)
                        {
                            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapEntity.FLD_NAME_ASSiteMapID, _ASSiteMapID.ToString(), SQLMatchType.Equal);
                            _aSSiteMapEntity = FCCASSiteMap.GetFacadeCreate().GetIL(null, null, null, filterExpression, DatabaseOperationType.LoadWithFilterExpression)[0];
                        }
                    }

                    if (_aSSiteMapEntity == null)
                    {
                        _aSSiteMapEntity = new ASSiteMapEntity();
                    }
                }

                return _aSSiteMapEntity;
            }
            set
            {
                _aSSiteMapEntity = value;
            }

        }

        #endregion
        
        #region Methods

        private void BuildDropDownList()
        {
        }

        private void PrepareInitialView()
        {
            BindList();
        }

        private void BindList()
        {
            BindASSiteMapList();
        }

        private void BindASSiteMapList()
        {
            DataTable dt = new DataTable();

            DataColumn dc = new DataColumn("RoleName");

            dt.Columns.Add(dc);

            String[] allRoles = Roles.GetAllRoles();

            foreach (String r in allRoles)
            {
                DataRow dr = dt.NewRow();

                dr["RoleName"] = r;

                dt.Rows.Add(dr);
            }

            rgASSiteMap.DataSource = dt;
            rgASSiteMap.DataBind();
        }

        #endregion

        #region Event

        #region Page Event

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                PrepareInitialView();
            }
        }

        #endregion

        #region Rad Grid Event

        protected void rgASSiteMap_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            //if (e.Item is GridDataItem)
            //{
            //    DataRowView drv = e.Item.DataItem as DataRowView;

            //    GridDataItem dataItem = (GridDataItem)e.Item;

            //    LinkButton lnkBtnEdit = (LinkButton)dataItem["lnkBtnEdit"].Controls[0];
            //    LinkButton lnkBtnDelete = (LinkButton)dataItem["lnkBtnDelete"].Controls[0];

            //    lnkBtnEdit.CommandArgument = drv.Row["RoleName"].ToString();

            //    lnkBtnDelete.OnClientClick = "return ConfirmDelete('A SSite Map')";
            //    lnkBtnDelete.CommandArgument = drv.Row["RoleName"].ToString();
            //}
        }

        protected void rgASSiteMap_ItemCommand(object sender, ListViewCommandEventArgs e)
        {
            String roleName = String.Empty;

            roleName = e.CommandArgument.ToString();

            if (roleName.IsNotNullOrEmpty())
            {
                if (string.Equals(e.CommandName, "EditItem"))
                {
                    Helper.Url.Redirect("~/Security/ASApplicationAccess.aspx", string.Empty, "ASCurrentRole", roleName);
                }
                else if (string.Equals(e.CommandName, "DeleteItem"))
                {
                    try
                    {
                        Boolean result = Roles.DeleteRole(roleName);

                        if (result == true)
                        {
                            BindASSiteMapList();
                            MiscUtil.ShowMessage(lblMessage, "Role has been successfully deleted.", true);

                        }
                        else
                        {
                            MiscUtil.ShowMessage(lblMessage, "Failed to delete Role.", true);
                        }
                    }
                    catch (Exception ex)
                    {
                        MiscUtil.ShowMessage(lblMessage, ex.Message, true);
                    }
                }
            }
        }

        #endregion Rad Grid Event
        
        #endregion Event
    }
}
