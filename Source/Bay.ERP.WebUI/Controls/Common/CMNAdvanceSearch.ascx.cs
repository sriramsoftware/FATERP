// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:49:46




using System;
using System.Web.UI.WebControls;
using System.Collections.Generic;
using System.Linq;

using Bay.ERP.Web.UI.Helper;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using System.Data;
using System.Reflection;
using System.Text.RegularExpressions;
using Bay.ERP.Common.CustomAttribute;

namespace Bay.ERP.Web.UI
{
    public partial class CMNAdvanceSearchControl : BaseControl
    {       
        #region Properties

        public String Action
        {
            get
            {
                String action = null;

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

        public String EntityName
        {
            get
            {
                String entityName = null;

                if (ViewState["EntityName"] != null)
                {
                    entityName = ViewState["EntityName"].ToString();
                }

                else if (!StringHelper.IsBlank(Helper.Url.SecureUrl["EntityName"].ToString()))
                {
                    entityName = Helper.Url.SecureUrl["EntityName"].ToString();

                    ViewState["EntityName"] = entityName;
                }

                return entityName;
            }
            set
            {
                ViewState["EntityName"] = value;
            }
        }

        public static Dictionary<string, List<string>> dict = new Dictionary<string, List<string>>();

        #endregion

        #region Methods


        private void BindSelectedValue()
        {
            if (ddlSearchWith != null && ddlSearchWith.SelectedValue != "0")
            {
               
                foreach (KeyValuePair<string, List<string>> dd in dict)
                {
                    if (ddlSearchWith.SelectedValue == dd.Value[0])
                    {

                        switch (dd.Value[1].ToString())
                        {
                            case SearchConstants.SearchDataType.Int:
                                rvSearchTextInt.Enabled = true;
                                revSearchTextDateTime.Enabled = false;
                                hdfDataType.Value = dd.Value[1].ToString();
                                break;

                            case SearchConstants.SearchDataType.DateTime:
                                rvSearchTextInt.Enabled = false;
                                revSearchTextDateTime.Enabled = true;
                                hdfDataType.Value = dd.Value[1].ToString();
                                break;

                            case SearchConstants.SearchDataType.Double:
                                rvSearchTextInt.Enabled = true;
                                revSearchTextDateTime.Enabled = false;
                                hdfDataType.Value = dd.Value[1].ToString();
                                break;

                            case SearchConstants.SearchDataType.String:
                                rvSearchTextInt.Enabled = false;
                                revSearchTextDateTime.Enabled = false;
                                hdfDataType.Value = dd.Value[1].ToString();
                                break;

                            case SearchConstants.SearchDataType.Bit:
                                //Needs modification
                                rvSearchTextInt.Enabled = false;
                                revSearchTextDateTime.Enabled = false;
                                hdfDataType.Value = dd.Value[1].ToString();
                                break;

                            default:
                                rvSearchTextInt.Enabled = false;
                                revSearchTextDateTime.Enabled = false;
                                hdfDataType.Value = dd.Value[1].ToString();
                                break;
                        }
                    }
                   
                }
            }
        }

        public static Dictionary<string, List<string>> DictionaryFromType(object atype)
        {

            if (atype == null) return new Dictionary<string, List<string>>();

            Type t = atype.GetType();
            MemberInfo[]  mems = t.GetMembers();

            dict.Clear();

            foreach (MemberInfo mem in mems)
            {

                object[] atts = mem.GetCustomAttributes(typeof(CustomSearchAttribute), true);

                if (atts != null && atts.Length > 0)
                {
                    CustomSearchAttribute csa = (CustomSearchAttribute)atts[0];

                    if (csa.AllowSearch == true)
                    {
                        List<string> myValues = new List<string>();
                        myValues.Add(csa.Value);
                        myValues.Add(csa.DataType);
                        dict.Add(csa.Title, myValues); 
                    } 
                }
            }

            return dict;
        }


        private void BuildSearchWithDropDownList()
        {
            //EntityName = "Bay.ERP.Common.BusinessEntities.BDProjectEntity";
            if (EntityName != null)
            {
                #region Create Instance

                Type oType = Type.GetType(EntityName + ", Bay.ERP.Common");
                Object obj = Activator.CreateInstance(oType);

                #endregion

                Dictionary<string, List<string>> dictAC = DictionaryFromType(obj);

                foreach (KeyValuePair<string, List<string>> dd in dictAC)
                {   
                    ddlSearchWith.Items.Add(new ListItem(dd.Key,dd.Value[0].ToString()));
                }
            }
        }

        private String BuildFilterExpression()
        {
            String fe = String.Empty;

            switch (Int64.Parse(ddlSearchCriteria.SelectedValue.ToString()))
            {
                case MasterDataConstants.AdvanceSearchCriteria.START_WITH:
                    fe = SqlExpressionBuilder.PrepareFilterExpression(ddlSearchWith.SelectedValue.ToString(), txtSearchText.Text.ToString(), SQLMatchType.LikeWithSuffixMath);
                    break;
                case MasterDataConstants.AdvanceSearchCriteria.CONTAINS:
                    fe = SqlExpressionBuilder.PrepareFilterExpression(ddlSearchWith.SelectedValue.ToString(), txtSearchText.Text.ToString(), SQLMatchType.LikeWithBothMath);
                    break;
                case MasterDataConstants.AdvanceSearchCriteria.END_WITH:
                    fe = SqlExpressionBuilder.PrepareFilterExpression(ddlSearchWith.SelectedValue.ToString(), txtSearchText.Text.ToString(), SQLMatchType.LikeWithPrefixMath);
                    break;
                case MasterDataConstants.AdvanceSearchCriteria.EQUALS:
                    fe = SqlExpressionBuilder.PrepareFilterExpression(ddlSearchWith.SelectedValue.ToString(), txtSearchText.Text.ToString(), SQLMatchType.Equal);
                    break;
            }

            return fe;
        }

        private void BuildDropDownList()
        {
            ddlSearchCriteria.Items.Add(new ListItem("Start With", MasterDataConstants.AdvanceSearchCriteria.START_WITH.ToString()));
            ddlSearchCriteria.Items.Add(new ListItem("Contains", MasterDataConstants.AdvanceSearchCriteria.CONTAINS.ToString()));
            ddlSearchCriteria.Items.Add(new ListItem("End With", MasterDataConstants.AdvanceSearchCriteria.END_WITH.ToString()));
            ddlSearchCriteria.Items.Add(new ListItem("Equals", MasterDataConstants.AdvanceSearchCriteria.EQUALS.ToString()));

            BuildSearchWithDropDownList();
        }

        private void PrepareInitialView()
        {
            BuildDropDownList();
            BindSelectedValue();
        }

        private void Search()
        {
            String fe = BuildFilterExpression();
            DataTable dtCommon = null;

            switch (Action)
            {
                case "ItemAdvanceSearch":
                    dtCommon = FCCMDItem_Custom.GetFacadeCreate().GetDT(100000,1, String.Empty, fe);
                    break;
                case "ItemCategoryAdvanceSearch":
                    dtCommon = FCCMDItemCategory.GetFacadeCreate().GetDT(1, 10000, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
                    break;
                default:
                    break;
            }

            //lvCMNAdvanceSearch.DataSource = dtCommon;
            //lvCMNAdvanceSearch.DataBind();

            lblSearch.Visible = true;
            grvCMNAdvanceSearch.DataSource = dtCommon;
            grvCMNAdvanceSearch.DataBind();
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

        #region List View Event

        protected void lvCMNAdvanceSearch_ItemDataBound(object sender, ListViewItemEventArgs e)
        {
            if (e.Item.ItemType == ListViewItemType.DataItem)
            {
                DataRowView rowView = e.Item.DataItem as DataRowView;
                PlaceHolder plhCommon = (PlaceHolder)e.Item.FindControl("plhCommon");

                if (plhCommon != null)
                {
                    foreach (object c in rowView.Row.ItemArray)
                    {
                        Literal oliteral = new Literal();

                        oliteral.Text = String.Format("<td>{0}</td>", c.ToString());
                        plhCommon.Controls.Add(oliteral);
                    }
                }

            }
        }

        #endregion List View Event

        #region Button Event

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        protected void btnClear_Click(object sender, EventArgs e)
        {
            //PrepareInitialView();
        }

        #endregion

        #region DropDown Event

        protected void ddlSearchWith_SelectedIndexChanged(object sender, EventArgs e)
        {
            BindSelectedValue();
        }

        #endregion

        #endregion Event

    }
}
