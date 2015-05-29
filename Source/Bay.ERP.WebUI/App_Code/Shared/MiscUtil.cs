using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Configuration;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Configuration;
using System.Web.UI.HtmlControls;
using System.Text.RegularExpressions;
using System.Diagnostics;
using System.Globalization;

using Bay.ERP.BusinessFacade;
using Bay.ERP.Common;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;
using Bay.ERP.Web.UI.Helper;
using Bay.ERP.FacadeCreator.FacadeContext;
using AjaxControlToolkit;
using System.Net.Mail;
using System.Net;
using System.Threading;
using System.Data;
using System.Linq;

namespace Bay.ERP.Web.UI
{
    public static class MiscUtil
    {
        #region DropDown Population Code

     
        #region PopulateMDPopulateMDZone

        public static void PopulateMDZone(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ZoneName";
            dropDownList.DataValueField = "ZoneID";
            dropDownList.DataSource = FCCMDZone.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDProjectStatus
        
        #region PopulateMDProjectStatus

        public static void PopulateMDProjectStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectStatusID";
            dropDownList.DataSource = FCCMDProjectStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDProjectStatus

        #region PopulateBDOperator

        public static void PopulateBDOperator(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "OperatorName";
            dropDownList.DataValueField = "OperatorID";
            dropDownList.DataSource = FCCBDOperator.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDOperator

        #region PopulateMDOperatorStatus

        public static void PopulateMDOperatorStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "OperatorStatusID";
            dropDownList.DataSource = FCCMDOperatorStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDOperator

        #region PopulateMDOperatorAddressType

        public static void PopulateMDOperatorAddressType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "OperatorAddressTypeID";
            dropDownList.DataSource = FCCMDOperatorAddressType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDOperatorAddressType

        #region PopulateMDProjectCategory

        public static void PopulateMDProjectCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectCategoryID";
            dropDownList.DataSource = FCCMDProjectCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDProjectCategory

        #region PopulateBDProject

        public static void PopulateBDProject(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            IList<BDProjectEntity> lst = FCCBDProject.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

            if (lst != null && lst.Count > 0)
            {
                foreach (BDProjectEntity entItem in lst)
                {
                    ListItem lstItem = new ListItem();
                    lstItem.Text = entItem.ProjectCode + "-" + entItem.ProjectName;
                    lstItem.Value = entItem.ProjectID.ToString();

                    dropDownList.Items.Add(lstItem);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Project", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateBDProjectByCode(DropDownList dropDownList, Boolean addPleaseSelectOption, String projectCode)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectEntity.FLD_NAME_ProjectCode, projectCode, SQLMatchType.Equal);

            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectName";
            dropDownList.DataValueField = "ProjectID";
            dropDownList.DataSource = FCCBDProject.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Project", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateBDProjectByMember(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 memberID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectName";
            dropDownList.DataValueField = "ProjectID";
            dropDownList.DataSource = FCCBDProjectByMember_Custom.GetFacadeCreate().GetIL(memberID);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateBDProjectOnlyBOQOrProjectCost(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            IList<PRMPreBOQEntity> lst = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            dropDownList.Items.Clear();

            if (lst != null && lst.Count > 0)
            {
                String compositeProjectID=String.Empty;

                foreach(PRMPreBOQEntity ent in lst)
                {
                    compositeProjectID +=ent.ProjectID + ",";
                }

                if(compositeProjectID.IsNotNullOrEmpty())
                {
                     compositeProjectID = compositeProjectID.Substring(0, compositeProjectID.Length - 1);
                }

                dropDownList.DataTextField = "ProjectName";
                dropDownList.DataValueField = "ProjectID";

                String fe= BDProjectEntity.FLD_NAME_ProjectID + " In(" + compositeProjectID + ")";
                dropDownList.DataSource = FCCBDProject.GetFacadeCreate().GetIL(null, null, String.Empty,fe, DatabaseOperationType.LoadWithFilterExpression);
                dropDownList.DataBind();

                if (addPleaseSelectOption == true)
                {
                    ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                    dropDownList.Items.Insert(0, pleaseSelectListItem);
                }
            }
        }

        public static void PopulateBDProjectForDTL(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();

            String se = SqlExpressionBuilder.PrepareSortExpression(BDProjectEntity.FLD_NAME_ProjectCode, SQLSortOrderType.Assending);
            IList<BDProjectEntity> lst = FCCBDProject.GetFacadeCreate().GetIL(null, null,se, null, DatabaseOperationType.LoadWithSortExpression);

            ListItem pleaseSelectListItem = new ListItem("Personal", "0");
            dropDownList.Items.Insert(0, pleaseSelectListItem);

            if (lst != null && lst.Count > 0)
            {
                foreach (BDProjectEntity entItem in lst)
                {
                    ListItem lstItem = new ListItem();
                    lstItem.Text = entItem.ProjectCode + "-" + entItem.ProjectName;
                    lstItem.Value = entItem.ProjectID.ToString();

                    dropDownList.Items.Add(lstItem);
                }
            }
            
            if (addPleaseSelectOption == true)
            {
                
            }
        }

        #endregion PopulateBDProject
        
        #region PopulateMDProjectDocumentCategory

        public static void PopulateMDProjectDocumentCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectDocumentCategoryID";
            dropDownList.DataSource = FCCMDProjectDocumentCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDProjectDocumentCategory

        #region PopulateMDProjectCollectedDocumentStatus

        public static void PopulateMDProjectCollectedDocumentStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectCollectedDocumentStatusID";
            dropDownList.DataSource = FCCMDProjectCollectedDocumentStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDProjectCollectedDocumentStatus

        #region PopulateBDProjectCollectedDocumentInfo

        public static void PopulateBDProjectCollectedDocumentInfo(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectID";
            dropDownList.DataValueField = "ProjectCollectedDocumentInfoID";
            dropDownList.DataSource = FCCBDProjectCollectedDocumentInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDProjectCollectedDocumentInfo

        #region PopulateBDProjectDocumentTemplate

        public static void PopulateBDProjectDocumentTemplate(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "TemplateName";
            dropDownList.DataValueField = "ProjectDocumentTemplateID";
            dropDownList.DataSource = FCCBDProjectDocumentTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDProjectDocumentTemplate

        #region PopulateMDUnit

        public static void PopulateMDUnit(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "UnitName";
            dropDownList.DataValueField = "UnitID";
            dropDownList.DataSource = FCCMDUnit.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDUnitByUnitID(DropDownList dropDownList, Boolean addPleaseSelectOption, int id)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "UnitName";
            dropDownList.DataValueField = "UnitID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(MDUnitEntity.FLD_NAME_UnitID, id.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCMDUnit.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDUnit

        #region PopulateMDUnit(IS)

        public static void PopulateMDUnitIS(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "UnitName";
            dropDownList.DataValueField = "UnitID";
            String fe = "UnitID in(25,10030,10032,10033)";
            dropDownList.DataSource = FCCMDUnit.GetFacadeCreate().GetIL(null, null, String.Empty,fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDUnit

        #region PopulateMDUnitWater(IS)

        public static void PopulateMDUnitWaterIS(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "UnitName";
            dropDownList.DataValueField = "UnitID";
            String fe = "UnitName in('Ltr','Gallon','Cft')";
            dropDownList.DataSource = FCCMDUnit.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDUnit

        #region PopulateMDCountry

        public static void PopulateMDCountry(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "CountryID";
            String se = SqlExpressionBuilder.PrepareSortExpression(MDCountryEntity.FLD_NAME_Name, SQLSortOrderType.Assending);
            //String fe = "1";
            dropDownList.DataSource = FCCMDCountry.GetFacadeCreate().GetIL(null, null,se, null, DatabaseOperationType.LoadWithSortExpression);
            dropDownList.DataBind();
            dropDownList.SelectedIndex = MasterDataConstants.MDCountryForHRM.DEFAULT_COUNTRY; // For Bangladesh=4


            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDCountryByRegionID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 regionID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "CountryID";
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDCountryEntity.FLD_NAME_RegionID, regionID.ToString(), SQLMatchType.Equal);
            String se = SqlExpressionBuilder.PrepareSortExpression(MDCountryEntity.FLD_NAME_Name, SQLSortOrderType.Assending);
            dropDownList.DataSource = FCCMDCountry.GetFacadeCreate().GetIL(null, null, se, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDCountryByItemBrandRegionID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 itemID, Int64 brandID,Int64 regionID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "CountryName";
            dropDownList.DataValueField = "OriginCountryID";
            dropDownList.DataSource = FCCPRMOriginCountryByBrandItemRegionDistinct_Custom.GetFacadeCreate().GetDT(itemID, brandID,regionID);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDCountry

        #region PopulateMDRegion

        public static void PopulateMDRegion(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "RegionID";
            dropDownList.DataSource = FCCMDRegion.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDRegionByItemBrandID(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 itemID, Int64 brandID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "RegionName";
            dropDownList.DataValueField = "OriginRegionID";
            dropDownList.DataSource = FCCPRMOriginRegionByBrandItemDistinct_Custom.GetFacadeCreate().GetDT(itemID,brandID);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDRegion

        #region PopulateMDItemCategory

        public static void PopulateMDItemCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "CategoryName";
            dropDownList.DataValueField = "ItemCategoryID";
            String fe= MDItemCategoryEntity.FLD_NAME_ParentItemCategoryID + " is not null";
            dropDownList.DataSource = FCCMDItemCategory.GetFacadeCreate().GetIL(null, null, null,fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDItemCategory

        #region PopulateMDPreBOQStatus

        public static void PopulateMDPreBOQStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "PreBOQStatusID";
            dropDownList.DataSource = FCCMDPreBOQStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDPreBOQStatus

        #region PopulatePRMPreBOQ

        public static void PopulatePRMPreBOQ(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectID";
            dropDownList.DataValueField = "PreBOQID";
            dropDownList.DataSource = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMPreBOQ

        #region PopulateMDItem

        public static void PopulateMDItem(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ItemName";
            dropDownList.DataValueField = "ItemID";
            String fe = MDItemEntity.FLD_NAME_ItemName + "<>" + "'-'";
            String se = SqlExpressionBuilder.PrepareSortExpression(MDItemEntity.FLD_NAME_ItemName, SQLSortOrderType.Assending);
            dropDownList.DataSource = FCCMDItem.GetFacadeCreate().GetIL(null, null, se, fe, DatabaseOperationType.LoadWithFilterAndSortExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Item", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDItemByWorkOrder(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 workOrderID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ItemName";
            dropDownList.DataValueField = "ItemID";
            dropDownList.DataSource = FCCPRMWorkOrderItemByWorkOrder_Custom.GetFacadeCreate().GetIL(workOrderID);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDItem

        #region PopulatePRMPreBOQTemplate

        public static void PopulatePRMPreBOQTemplate(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "TemplateName";
            dropDownList.DataValueField = "PreBOQTemplateID";
            dropDownList.DataSource = FCCPRMPreBOQTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMPreBOQTemplate

        #region PopulatePRMSupplier

        public static void PopulatePRMSupplier(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "SupplierName";
            dropDownList.DataValueField = "SupplierID";
            String se = SqlExpressionBuilder.PrepareSortExpression(PRMSupplierEntity.FLD_NAME_SupplierName, SQLSortOrderType.Assending);
            dropDownList.DataSource = FCCPRMSupplier.GetFacadeCreate().GetIL(null, null, se, null, DatabaseOperationType.LoadWithSortExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulatePRMSupplierByBrandID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 brandID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "SupplierName";
            dropDownList.DataValueField = "SupplierID";

            IList<PRMSupplierByBrand_CustomEntity> lst = FCCPRMSupplierByBrand_Custom.GetFacadeCreate().GetIL(brandID);

            dropDownList.DataSource = lst;
            dropDownList.DataBind();

            if (lst != null && lst.Count > 0)
            {
                var results = (from myrow in lst
                               where myrow.SupplierID == MasterDataConstants.ItemDefaults.DEFAULT_SUPPLIER
                               select myrow).ToList();

                if (results == null || results.Count == 0)
                {
                    ListItem additionalListItem = new ListItem("Not Available", MasterDataConstants.ItemDefaults.DEFAULT_SUPPLIER.ToString());
                    dropDownList.Items.Insert(dropDownList.Items.Count, additionalListItem);
                }
            }

            else
            {
                ListItem additionalListItem = new ListItem("Not Available", MasterDataConstants.ItemDefaults.DEFAULT_SUPPLIER.ToString());
                dropDownList.Items.Insert(dropDownList.Items.Count, additionalListItem);
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMSupplier

        #region PopulateMDSupplierAddressType

        public static void PopulateMDSupplierAddressType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SupplierAddressTypeID";
            dropDownList.DataSource = FCCMDSupplierAddressType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSupplierAddressType

        #region PopulateMDCity

        public static void PopulateMDCity(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "CityID";
            dropDownList.DataSource = FCCMDCity.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDCityByCountryID(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 countryID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "CityID";
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDCityEntity.FLD_NAME_CountryID, countryID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCMDCity.GetFacadeCreate().GetIL(null, null, null,filterExpression, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDCity

        #region PopulateMDBrand

        public static void PopulateMDBrand(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BrandName";
            dropDownList.DataValueField = "BrandID";
            String se = SqlExpressionBuilder.PrepareSortExpression(MDBrandEntity.FLD_NAME_BrandName, SQLSortOrderType.Assending);
            dropDownList.DataSource = FCCMDBrand.GetFacadeCreate().GetIL(null, null, se, null, DatabaseOperationType.LoadWithSortExpression);
            dropDownList.DataBind();
            
            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDBrandByItemID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 itemID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BrandName";
            dropDownList.DataValueField = "BrandID";
            
            DataTable lst = FCCPRMBrandByItem_Custom.GetFacadeCreate().GetDT(itemID);

            var results= (from myrow in lst.AsEnumerable()
                         where myrow.Field<Int64>("BrandID") == MasterDataConstants.ItemDefaults.DEFAULT_BRAD
                         select myrow).ToList();

            if (lst != null && lst.Rows.Count > 0)
            {
                dropDownList.DataSource = lst;
                dropDownList.DataBind();
            }

            // If result get any 
            if (results.Count==0)
            {
                ListItem AdditionalListItem = new ListItem("Not Available", MasterDataConstants.ItemDefaults.DEFAULT_BRAD.ToString());
                dropDownList.Items.Insert(dropDownList.Items.Count, AdditionalListItem);
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDBrandExceptNotAvailable(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BrandName";
            dropDownList.DataValueField = "BrandID";
            String se = SqlExpressionBuilder.PrepareSortExpression(MDBrandEntity.FLD_NAME_BrandName, SQLSortOrderType.Assending);
            String fe = MDBrandEntity.FLD_NAME_BrandID + " <> " + MasterDataConstants.ItemDefaults.DEFAULT_BRAD;
            dropDownList.DataSource = FCCMDBrand.GetFacadeCreate().GetIL(null, null, se, fe, DatabaseOperationType.LoadWithFilterAndSortExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDBrand

        #region PopulateMDProjectDocument

        public static void PopulateMDProjectDocument(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectDocumentID";
            dropDownList.DataSource = FCCMDProjectDocument.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDProjectDocument

        #region PopulateHRMember

        public static void PopulateHRMember(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();

            IList<HRMemberEntity> lstHRMember = FCCHRMember.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

            if (lstHRMember != null && lstHRMember.Count > 0)
            {
                foreach (HRMemberEntity ent in lstHRMember)
                {
                    ListItem lstItem = new ListItem();
                    lstItem.Text = ent.FirstName +" "+ (ent.MiddleName!=String.Empty ? ent.MiddleName+" " : "").ToString() + ent.LastName;
                    lstItem.Value = ent.MemberID.ToString();
                    dropDownList.Items.Add(lstItem);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateHRMemberForEventInvitationGroupWise(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();

            String se = SqlExpressionBuilder.PrepareSortExpression(HRMember_DetailedEntity.FLD_NAME_MemberID.ToString() , SQLSortOrderType.Assending);

            IList<HRMember_DetailedEntity> lst = FCCHRMember_Detailed.GetFacadeCreate().GetIL(1000, 1, se, String.Empty);

            if (lst != null && lst.Count > 0)
            {
                IList<String> lstMemberTypeID = lst.OrderBy(s => s.MemberTypeID).Select(o => o.MemberTypeName.ToString()).Distinct().ToList();

                if (lstMemberTypeID != null && lstMemberTypeID.Count > 0)
                {
                    foreach (String des in lstMemberTypeID)
                    {
                        if (des.IsNotNullOrEmpty())
                        {
                            ListItem pleaseSelectListItem = new ListItem();
                            pleaseSelectListItem.Attributes.Add("style", "font-weight: bold");
                            pleaseSelectListItem.Attributes.Add("disabled", "disabled");
                            pleaseSelectListItem.Text = HttpUtility.HtmlDecode(des);
                            pleaseSelectListItem.Value = "0";

                            dropDownList.Items.Add(pleaseSelectListItem);

                            IList<HRMember_DetailedEntity> lstSubItem = (from s in lst
                                                                       where s.MemberTypeName == des
                                                                       select s).ToList();

                            foreach (HRMember_DetailedEntity entItem in lstSubItem)
                            {
                                ListItem lstItem = new ListItem();
                                lstItem.Text = HttpUtility.HtmlDecode("&nbsp;&nbsp;&nbsp;&nbsp;" + entItem.FirstName +" "+ (entItem.MiddleName!=String.Empty ? entItem.MiddleName+" " : "").ToString() + entItem.LastName);
                                lstItem.Value = entItem.MemberID.ToString();

                                dropDownList.Items.Add(lstItem);
                            }
                        }
                    }
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateHRMember

        #region PopulateCMProjectScheduleTemplate

        public static void PopulateCMProjectScheduleTemplate(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "TemplateName";
            dropDownList.DataValueField = "ProjectScheduleTemplateID";
            dropDownList.DataSource = FCCCMProjectScheduleTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMProjectScheduleTemplate

        #region PopulateMDProjectScheduleItem

        public static void PopulateMDProjectScheduleItem(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ParentProjectScheduleItemID";
            dropDownList.DataValueField = "ProjectScheduleItemID";
            dropDownList.DataSource = FCCMDProjectScheduleItem.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDProjectScheduleItem

        #region PopulateMDIssuePriority

        public static void PopulateMDIssuePriority(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "IssuePriorityID";
            dropDownList.DataSource = FCCMDIssuePriority.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDIssuePriority

        #region PopulateMDHolidayCategory

        public static void PopulateMDHolidayCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "HolidayCategoryID";
            dropDownList.DataSource = FCCMDHolidayCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDHolidayCategory

        #region PopulateMDMemberType

        public static void PopulateMDMemberType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "MemberTypeID";
            dropDownList.DataSource = FCCMDMemberType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDMemberType

        #region PopulateMDIssueIdentityCategory

        public static void PopulateMDIssueIdentityCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "IssueIdentityCategoryID";
            dropDownList.DataSource = FCCMDIssueIdentityCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDIssueIdentityCategory

        #region PopulateMDScheduleIdentityCategory

        public static void PopulateMDScheduleIdentityCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ScheduleIdentityCategoryID";
            dropDownList.DataSource = FCCMDScheduleIdentityCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDScheduleIdentityCategory

        #region PopulateMDIssueCategory

        public static void PopulateMDIssueCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "IssueCategoryID";
            dropDownList.DataSource = FCCMDIssueCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDIssueCategoryByIssueIdentityCategory(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 issueIdentityCategory)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(MDIssueCategoryEntity.FLD_NAME_IssueIdentityCategoryID, issueIdentityCategory.ToString(), SQLMatchType.Equal);

            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "IssueCategoryID";
            dropDownList.DataSource = FCCMDIssueCategory.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDIssueCategoryForDTL(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();

            String se = SqlExpressionBuilder.PrepareSortExpression(MDIssueCategoryEntity.FLD_NAME_IssueCategoryID.ToString(), SQLSortOrderType.Decending);
            IList<MDIssueCategoryEntity> lst = FCCMDIssueCategory.GetFacadeCreate().GetIL(null, null, se, null, DatabaseOperationType.LoadWithSortExpression);

            if(lst!=null && lst.Count>0)
            {
                IList<String> lstDescription = lst.OrderBy(s => s.Description).Select(o => o.Description).Distinct().ToList();

                if (lstDescription != null && lstDescription.Count > 0)
                {
                    foreach (String des in lstDescription)
                    {
                        if (des.IsNotNullOrEmpty())
                        {   
                            ListItem pleaseSelectListItem = new ListItem();
                            pleaseSelectListItem.Attributes.Add("style", "font-weight: bold");
                            pleaseSelectListItem.Attributes.Add("disabled", "disabled");
                            pleaseSelectListItem.Text = HttpUtility.HtmlDecode(des);
                            pleaseSelectListItem.Value = "0";

                            dropDownList.Items.Add(pleaseSelectListItem);

                            IList<MDIssueCategoryEntity> lstSubItem = (from s in lst
                                                                       where s.Description == des
                                                                       select s).ToList();

                            foreach (MDIssueCategoryEntity entItem in lstSubItem)
                            {
                                ListItem lstItem = new ListItem();
                                lstItem.Text = HttpUtility.HtmlDecode("&nbsp;&nbsp;&nbsp;&nbsp;" + entItem.Name);
                                lstItem.Value = entItem.IssueCategoryID.ToString();

                                dropDownList.Items.Add(lstItem);
                            }
                        }
                    }
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDIssueCategory

        #region PopulateOTIssue

        public static void PopulateOTIssue(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Title";
            dropDownList.DataValueField = "IssueID";
            dropDownList.DataSource = FCCOTIssue.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateOTIssue

        #region PopulateMDIssueStatus

        public static void PopulateMDIssueStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "IssueStatusID";
            dropDownList.DataSource = FCCMDIssueStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDIssueStatusForDTL(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "IssueStatusID";
            String fe = "IssueStatusID in(5,6,7,8)"; //meet the quick requirement. need to change here.
            dropDownList.DataSource = FCCMDIssueStatus.GetFacadeCreate().GetIL(null, null, String.Empty,fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDIssueStatus

        #region PopulateResource

        public static void PopulateResource(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ResourceCategoryID";
            dropDownList.DataValueField = "ResourceID";
            dropDownList.DataSource = FCCResource.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateResource

        #region PopulateMDScheduleCategory

        public static void PopulateMDScheduleCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ScheduleCategoryID";
            dropDownList.DataSource = FCCMDScheduleCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDScheduleCategory

        #region PopulateMDSchedulePriority

        public static void PopulateMDSchedulePriority(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SchedulePriorityID";
            dropDownList.DataSource = FCCMDSchedulePriority.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSchedulePriority

        #region PopulateOTSchedule

        public static void PopulateOTSchedule(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ScheduleIdentityCategoryID";
            dropDownList.DataValueField = "ScheduleID";
            dropDownList.DataSource = FCCOTSchedule.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateOTSchedule

        #region PopulateMDResourceCategory

        public static void PopulateMDResourceCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ResourceCategoryID";
            dropDownList.DataSource = FCCMDResourceCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDResourceCategory

        #region PopulateMDConstructionToolCategory

        public static void PopulateMDConstructionToolCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ConstructionToolCategoryID";
            dropDownList.DataSource = FCCMDConstructionToolCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDConstructionToolCategory

        #region PopulateCMContractor

        ///Skipped By Raju Because of newly implemented idea about Contractor
        //public static void PopulateCMContractor(DropDownList dropDownList, Boolean addPleaseSelectOption)
        //{
        //    dropDownList.Items.Clear();
        //    dropDownList.DataTextField = "Name";
        //    dropDownList.DataValueField = "ContractorID";
        //    dropDownList.DataSource = FCCCMContractor.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
        //    dropDownList.DataBind();

        //    if (addPleaseSelectOption == true)
        //    {
        //        ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
        //        dropDownList.Items.Insert(0, pleaseSelectListItem);
        //    }
        //}



        public static void PopulateCMContractor(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "SupplierName";
            dropDownList.DataValueField = "SupplierID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierEntity.FLD_NAME_SupplierTypeID, MasterDataConstants.MDSupplierType.CONTRACTOR.ToString(), SQLMatchType.Equal);
            String se = SqlExpressionBuilder.PrepareSortExpression(PRMSupplierEntity.FLD_NAME_SupplierName, SQLSortOrderType.Assending);
            dropDownList.DataSource = FCCPRMSupplier.GetFacadeCreate().GetIL(null, null, se, fe, DatabaseOperationType.LoadWithFilterAndSortExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMContractor

        #region PopulateMDAddressType

        public static void PopulateMDAddressType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AddressTypeID";
            dropDownList.DataSource = FCCMDAddressType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDAddressType

        #region PopulateCMConstructionTool

        public static void PopulateCMConstructionTool(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ToolName";
            dropDownList.DataValueField = "ConstructionToolID";
            dropDownList.DataSource = FCCCMConstructionTool.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCMConstructionToolDetail(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Specification";
            dropDownList.DataValueField = "ConstructionToolDetailID";
            dropDownList.DataSource = FCCCMConstructionToolDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }
        

        #endregion PopulateCMConstructionTool

        #region PopulateMDCriterionCategory

        public static void PopulateMDCriterionCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "CriterionCategoryID";
            dropDownList.DataSource = FCCMDCriterionCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDCriterionCategory

        #region PopulateMDContractorCriterionStatus

        public static void PopulateMDContractorCriterionStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ContractorCriterionStatusID";
            dropDownList.DataSource = FCCMDContractorCriterionStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDContractorCriterionStatus

        #region PopulateCMConsultant

        //Skipped By Raju Because of newly implemented idea about consultant
        //public static void PopulateCMConsultant(DropDownList dropDownList, Boolean addPleaseSelectOption)
        //{
        //    dropDownList.Items.Clear();
        //    dropDownList.DataTextField = "Name";
        //    dropDownList.DataValueField = "ConsultantID";
        //    dropDownList.DataSource = FCCCMConsultant.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
        //    dropDownList.DataBind();

        //    if (addPleaseSelectOption == true)
        //    {
        //        ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
        //        dropDownList.Items.Insert(0, pleaseSelectListItem);
        //    }
        //}

        public static void PopulateCMConsultant(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "SupplierName";
            dropDownList.DataValueField = "SupplierID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierEntity.FLD_NAME_SupplierTypeID, MasterDataConstants.MDSupplierType.CONSULTANT.ToString(), SQLMatchType.Equal);
            String se = SqlExpressionBuilder.PrepareSortExpression(PRMSupplierEntity.FLD_NAME_SupplierName, SQLSortOrderType.Assending);
            dropDownList.DataSource = FCCPRMSupplier.GetFacadeCreate().GetIL(null, null, se, fe, DatabaseOperationType.LoadWithFilterAndSortExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMConsultant

        #region PopulateCRMArtist

        public static void PopulateCRMArtist(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ConsultantID";
            dropDownList.DataSource = FCCCMConsultant.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMConsultant

        #region PopulateCMConsultantWorkArea

        public static void PopulateCMConsultantWorkArea(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ConsultantWorkAreaID";
            dropDownList.DataSource = FCCCMConsultantWorkArea.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCMConsultantWorkAreaByCosultantID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 consultantID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ConsultantWorkAreaName";
            dropDownList.DataValueField = "ConsultantWorkAreaID";
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression("CMConsultantEnlistedWorkArea." + CMConsultantEnlistedWorkArea_CustomEntity.FLD_NAME_ConsultantID, consultantID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCCMConsultantEnlistedWorkArea_Custom.GetFacadeCreate().GetIL(filterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }
        #endregion PopulateCMConsultantWorkArea

        #region PopulateCMWorkAreaStatus

        public static void PopulateCMWorkAreaStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "WorkAreaStatusID";
            dropDownList.DataSource = FCCCMWorkAreaStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMWorkAreaStatus

        #region PopulateREQRequisition

        public static void PopulateREQRequisition(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "RequisitionNo";
            dropDownList.DataValueField = "RequisitionID";
            dropDownList.DataSource = FCCREQRequisition.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateREQApprovedRequisition(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "RequisitionNo";
            dropDownList.DataValueField = "RequisitionID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionStatusID, MasterDataConstants.RequisitionStatus.APPROVED.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCREQRequisition.GetFacadeCreate().GetIL(null, null, null,fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateREQApprovedRequisitionByProject(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 projectID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "RequisitionNo";
            dropDownList.DataValueField = "RequisitionID";
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_RequisitionStatusID, MasterDataConstants.RequisitionStatus.APPROVED.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(REQRequisitionEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            dropDownList.DataSource = FCCREQRequisition.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Requisition", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateREQRequisition

        #region PopulateMDRequisitionStatus

        public static void PopulateMDRequisitionStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "RequisitionStatusID";
            dropDownList.DataSource = FCCMDRequisitionStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDRequisitionStatus

        #region PopulateMDConstructionToolWorkingCondition

        public static void PopulateMDConstructionToolWorkingCondition(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ConstructionToolWorkingConditionID";
            dropDownList.DataSource = FCCMDConstructionToolWorkingCondition.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDConstructionToolWorkingCondition

        #region PopulateMDSupplierStatus

        public static void PopulateMDSupplierStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SupplierStatusID";
            dropDownList.DataSource = FCCMDSupplierStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSupplierStatus

        #region PopulateCMNDashboardItem

        public static void PopulateCMNDashboardItem(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Title";
            dropDownList.DataValueField = "DashboardItemID";
            dropDownList.DataSource = FCCCMNDashboardItem.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMNDashboardItem

        #region PopulateMDStandardTimeUnit

        public static void PopulateMDStandardTimeUnit(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "StandardTimeUnitID";
            dropDownList.DataSource = FCCMDStandardTimeUnit.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDStandardTimeUnit

        #region PopulateMDItemGroup

        public static void PopulateMDItemGroup(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "GroupName";
            dropDownList.DataValueField = "ItemGroupID";
            dropDownList.DataSource = FCCMDItemGroup.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDItemGroup

        #region PopulatePRMSupplierItemMap

        public static void PopulatePRMSupplierItemMap(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "SupplierID";
            dropDownList.DataValueField = "SupplierItemMapID";
            dropDownList.DataSource = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMSupplierItemMap

        #region PopulateMDSupplierType

        public static void PopulateMDSupplierType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SupplierTypeID";
            dropDownList.DataSource = FCCMDSupplierType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSupplierType

        #region PopulateMDSupplierItemCategory

        public static void PopulateMDSupplierItemCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SupplierItemCategoryID";
            dropDownList.DataSource = FCCMDSupplierItemCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSupplierItemCategory

        #region PopulatePRMBOQDetail

        public static void PopulatePRMBOQDetail(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BOQID";
            dropDownList.DataValueField = "BOQDetailID";
            dropDownList.DataSource = FCCPRMBOQDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMBOQDetail

        #region PopulateMDBOQStatus

        public static void PopulateMDBOQStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BOQStatusID";
            dropDownList.DataSource = FCCMDBOQStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDBOQStatus

        #region PopulatePRMBOQ

        public static void PopulatePRMBOQ(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "PreBOQID";
            dropDownList.DataValueField = "BOQID";
            dropDownList.DataSource = FCCPRMBOQ.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMBOQ

        #region PopulatePRMBOQTemplate

        public static void PopulatePRMBOQTemplate(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "TemplateName";
            dropDownList.DataValueField = "BOQTemplateID";
            dropDownList.DataSource = FCCPRMBOQTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMBOQTemplate

        #region PopulatePRMPreBOQDetail

        public static void PopulatePRMPreBOQDetail(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "PreBOQID";
            dropDownList.DataValueField = "PreBOQDetailID";
            dropDownList.DataSource = FCCPRMPreBOQDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMPreBOQDetail

        #region PopulateBDProjectFloor

        public static void PopulateBDProjectFloor(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectFloorID";
            dropDownList.DataSource = FCCBDProjectFloor.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateBDProjectFloorByProject(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 projectID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectFloorID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCBDProjectFloor.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Floor", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateBDProjectFloorUnitByBuyerBookSpaceID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 buyerBookSpaceID)
        {
            CRMBuyerBookSpaceEntity entity = FCCCRMBuyerBookSpace.GetFacadeCreate().GetByID(buyerBookSpaceID);
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BDProjectFloorUnitProjectFloorUnitName";
            dropDownList.DataValueField = "ProjectFloorUnitID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBookSpace_DetailedEntity.FLD_NAME_BuyerBookSpaceID, entity.BuyerBookSpaceID.ToString(), SQLMatchType.Equal);
            ///String fe2 = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorUnitEntity.fld_name_project, entity.ProjectFloorUnitID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCCRMBuyerBookSpace_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Floor", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDProjectFloor

        #region PopulateMDFloorCategory

        public static void PopulateMDFloorCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "FloorCategoryID";
            dropDownList.DataSource = FCCMDFloorCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDFloorCategory

        #region PopulateMDFloor

        public static void PopulateMDFloor(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "FloorID";
            dropDownList.DataSource = FCCMDFloor.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDFloorByFloorCategoryID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 floorCategoryID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "FloorID";
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(MDFloorEntity.FLD_NAME_FloorCategoryID, floorCategoryID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCMDFloor.GetFacadeCreate().GetIL(null, null, null, filterExpression, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDFloor

        #region PopulateMDApprovalRule

        public static void PopulateMDApprovalRule(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ApprovalRuleName";
            dropDownList.DataValueField = "ApprovalRuleID";
            dropDownList.DataSource = FCCMDApprovalRule.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDApprovalRule

        #region PopulateHREmployee

        public static void PopulateHREmployee(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            String se = SqlExpressionBuilder.PrepareSortExpression(ResourceEmployee_CustomEntity.FLD_NAME_EmployeeCode, SQLSortOrderType.Assending);
            IList<ResourceEmployee_CustomEntity> lstEmployee = FCCResourceEmployee_Custom.GetFacadeCreate().GetIL(1000000, 1, se, String.Empty);

            dropDownList.Items.Clear();

            if (lstEmployee != null && lstEmployee.Count > 0)
            {
                foreach (ResourceEmployee_CustomEntity ent in lstEmployee)
                {
                   ListItem lstItem = new ListItem();
                   lstItem.Text = ent.EmployeeCode + " - " + ent.MemberFullName;
                   lstItem.Value = ent.EmployeeID.ToString();
                   dropDownList.Items.Add(lstItem);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateHREmployee

        #region PopulateCMNApprovalProcess

        public static void PopulateCMNApprovalProcess(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ReferenceID";
            dropDownList.DataValueField = "ApprovalProcessID";
            dropDownList.DataSource = FCCCMNApprovalProcess.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMNApprovalProcess

        #region PopulateMDApprovalPanelStatus

        public static void PopulateMDApprovalPanelStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ApprovalPanelStatusID";
            dropDownList.DataSource = FCCMDApprovalPanelStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDApprovalPanelStatus

        #region PopulateMDApprovalProcessType

        public static void PopulateMDApprovalProcessType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ApprovalProcessTypeID";
            dropDownList.DataSource = FCCMDApprovalProcessType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDApprovalProcessType

        #region PopulateMDApprovalProcessStatus

        public static void PopulateMDApprovalProcessStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ApprovalProcessStatusID";
            dropDownList.DataSource = FCCMDApprovalProcessStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDApprovalProcessStatus

        #region PopulateMDApprovalProcessPriority

        public static void PopulateMDApprovalProcessPriority(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ApprovalProcessPriorityID";
            dropDownList.DataSource = FCCMDApprovalProcessPriority.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDApprovalProcessPriority

        #region PopulateMDDesignation

        public static void PopulateMDDesignation(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "DesignationID";
            dropDownList.DataSource = FCCMDDesignation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDDesignation
        
        #region PopulateMDDepartment

        public static void PopulateMDDepartment(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "DepartmentID";
            dropDownList.DataSource = FCCMDDepartment.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDDepartmentDistinct(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "DepartmentName";
            dropDownList.DataValueField = "DepartmentID";
            dropDownList.DataSource = FCCDMSFileTrackingDepartmentDistinct_Custom.GetFacadeCreate().GetIL();
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDDepartment

        #region PopulatePRMWorkOrder

        public static void PopulatePRMWorkOrder(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "WorkOrderNo";
            dropDownList.DataValueField = "WorkOrderID";
            dropDownList.DataSource = FCCPRMWorkOrder.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulatePRMWorkOrderbySupplierID(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 supplierID)
        {
            String fe = String.Empty;
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_SupplierID, supplierID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderStatusID, MasterDataConstants.WorkOrderStatus.APPROVED.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            IList<PRMWorkOrderEntity> lstWorkOrder = FCCPRMWorkOrder.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);

            dropDownList.Items.Clear();
            if (lstWorkOrder != null && lstWorkOrder.Count > 0)
            {
                foreach (PRMWorkOrderEntity ent in lstWorkOrder)
                {
                    ListItem lstItem = new ListItem();
                    if (ent.IsFinalBilled)
                    {
                        lstItem.Text = ent.WorkOrderNo + " - Finally Billed";
                    }
                    else if(ent.IsFinalBilled==false)
                    {
                        lstItem.Text = ent.WorkOrderNo;
                    }

                    lstItem.Value = ent.WorkOrderID.ToString();
                    dropDownList.Items.Add(lstItem);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("WorkOrder Not Available", "16");  // 16 in Default WO created in Database.
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulatePRMWorkOrderExceptFinalBillbySupplierID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 supplierID)
        {
            String fe = String.Empty;
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_SupplierID, supplierID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderStatusID, MasterDataConstants.WorkOrderStatus.APPROVED.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            IList<PRMWorkOrderEntity> lstWorkOrder = FCCPRMWorkOrder.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);

            dropDownList.Items.Clear();
            if (lstWorkOrder != null && lstWorkOrder.Count > 0)
            {
                foreach (PRMWorkOrderEntity ent in lstWorkOrder)
                {
                    ListItem lstItem = new ListItem();

                    if (ent.IsFinalBilled == false)
                    {
                        lstItem.Text = ent.WorkOrderNo;
                        lstItem.Value = ent.WorkOrderID.ToString();
                        dropDownList.Items.Add(lstItem);
                    }
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("WorkOrder Not Available", "16");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulatePRMApprovedWorkOrder(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "WorkOrderNo";
            dropDownList.DataValueField = "WorkOrderID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderEntity.FLD_NAME_WorkOrderStatusID, MasterDataConstants.WorkOrderStatus.APPROVED.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCPRMWorkOrder.GetFacadeCreate().GetIL(null, null, null,fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PRMApprovedAdvancePaymentWorkOrder(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "WorkOrderNo";
            dropDownList.DataValueField = "WorkOrderID";
            dropDownList.DataSource = FCCPRMApprovedAdvancePaymentWorkOrder_Custom.GetFacadeCreate().GetIL();
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMWorkOrder

        #region PopulatePRMMaterialReceive

        public static void PopulatePRMMaterialReceive(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectID";
            dropDownList.DataValueField = "MaterialReceiveID";
            dropDownList.DataSource = FCCPRMMaterialReceive.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateApprovedPRMMaterialReceive(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectID";
            dropDownList.DataValueField = "MaterialReceiveID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMMaterialReceiveEntity.FLD_NAME_MaterialReceiveApprovalStatusID, MasterDataConstants.MDMaterialReceiveApprovalStatus.APPROVED.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCPRMMaterialReceive.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMMaterialReceive

        #region PopulateREQRequisitionItem

        public static void PopulateINVStoreAvailableItem(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 storeID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ItemName";
            dropDownList.DataValueField = "ItemID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression("StoreID", storeID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCINVTransactionAvailable_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateREQRequisitionItem(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "MDItemItemName";
            dropDownList.DataValueField = "ItemID";
            String se = SqlExpressionBuilder.PrepareSortExpression("MDItem.ItemName", SQLSortOrderType.Assending);
            dropDownList.DataSource = FCCREQRequisitionItem_Detailed.GetFacadeCreate().GetIL(10000,1,se,String.Empty);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }


        public static void PopulateREQRequisitionItemRequisitionID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 requisitionID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ItemName";
            dropDownList.DataValueField = "RequisitionItemID";
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression("REQRequisition." + REQRequisitionItem_CustomEntity.FLD_NAME_RequisitionID, requisitionID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCREQRequisitionItem_Custom.GetFacadeCreate().GetIL(filterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateREQRequisitionItem

        #region PopulateMDWorkOrderStatus

        public static void PopulateMDWorkOrderStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "WorkOrderStatusID";
            dropDownList.DataSource = FCCMDWorkOrderStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDWorkOrderStatus

        #region PopulatePRMMaterialReceiveCustom

        public static void PopulatePRMSupplierByProjectID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 projectID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "SupplierName";
            dropDownList.DataValueField = "SupplierID";
            dropDownList.DataSource = FCCPRMSupplierByProjectDistinct_Custom.GetFacadeCreate().GetIL(projectID);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulatePRMRequisitionBySupplierID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 supplierID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "RequisitionNo";
            dropDownList.DataValueField = "RequisitionID";
            dropDownList.DataSource = FCCPRMRequisitionBySupplierDistinct_Custom.GetFacadeCreate().GetIL(supplierID);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulatePRMWorkOrderByRequisitonID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 requisitionID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "WorkOrderNo";
            dropDownList.DataValueField = "WorkOrderID";
            dropDownList.DataSource = FCCPRMWorkOrderByRequisitionDistinct_Custom.GetFacadeCreate().GetIL(requisitionID);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please WO", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion

        #region PopulateMDProjectAssignedPersonTeamRole

        public static void PopulateMDProjectAssignedPersonTeamRole(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectAssignedPersonTeamRoleID";
            dropDownList.DataSource = FCCMDProjectAssignedPersonTeamRole.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDProjectAssignedPersonTeamRole

        #region PopulateASSiteMap

        public static void PopulateASSiteMap(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            String se = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapEntity.FLD_NAME_ASSiteMapID, SQLSortOrderType.Assending); 
            
            dropDownList.Items.Clear();

            dropDownList.DataTextField = "SiteMapName";
            dropDownList.DataValueField = "ASSiteMapID";
            dropDownList.DataSource = FCCASSiteMap.GetFacadeCreate().GetIL(null, null, se, null, DatabaseOperationType.LoadWithSortExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateASSiteMap (Rad ComboBox)

        #region PopulateDMSDocumentNode

        public static void PopulateDMSDocumentNode(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "DocumentNodeID";
            dropDownList.DataSource = FCCDMSDocumentNode.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateDMSDocumentNode

        #region PopulateMDDocumentStorageType

        public static void PopulateMDDocumentStorageType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "DocumentStorageTypeID";
            dropDownList.DataSource = FCCMDDocumentStorageType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDDocumentStorageType

        #region PopulateMDDMSOwnerType

        public static void PopulateMDDMSOwnerType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "OwnerTypeID";
            dropDownList.DataSource = FCCMDDMSOwnerType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDDMSOwnerType

        #region PopulateDMSFileTracking

        public static void PopulateDMSFileTracking(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "FileName";
            dropDownList.DataValueField = "FileTrackingID";
            dropDownList.DataSource = FCCDMSFileTracking.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateDMSFileTrackingByDepartmentID(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 departmentID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "FileName";
            dropDownList.DataValueField = "FileTrackingID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSFileTrackingEntity.FLD_NAME_DepartmentID, departmentID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCDMSFileTracking.GetFacadeCreate().GetIL(null,null, null,fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }
        #endregion PopulateDMSFileTracking

        #region PopulateMDReferenceLibraryCategory

        public static void PopulateMDReferenceLibraryCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ReferenceLibraryCategoryID";
            dropDownList.DataSource = FCCMDReferenceLibraryCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDReferenceLibraryCategory
        
        #region PopulateAPType

        public static void PopulateAPType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "APTypeID";
            dropDownList.DataSource = FCCAPType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateAPType

        #region PopulateAPStatus

        public static void PopulateAPStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "APStatusID";
            dropDownList.DataSource = FCCAPStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateAPStatus

        #region PopulateAPApprovalProcess

        public static void PopulateAPApprovalProcess(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "APTypeID";
            dropDownList.DataValueField = "APApprovalProcessID";
            dropDownList.DataSource = FCCAPApprovalProcess.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateAPApprovalProcess

        #region PopulateAPFeedback

        public static void PopulateAPFeedback(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "APFeedbackID";
            dropDownList.DataSource = FCCAPFeedback.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateAPFeedback

        #region PopulateAPPanel

        public static void PopulateAPPanel(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "APPanelID";
            dropDownList.DataSource = FCCAPPanel.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateStartWithAPPanel(DropDownList dropDownList, Boolean addPleaseSelectOption,String startwith)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "APPanelID";
            IList<APPanelEntity> lst = FCCAPPanel.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

            if (lst != null && lst.Count > 0)
            {
                IList<APPanelEntity> lstAccountAPPanel = (from s in lst
                                                          where s.Name.StartsWith(startwith)
                                                          select s).ToList();

                lst = lstAccountAPPanel;
            }

            dropDownList.DataSource = lst;
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateAPPanel

        #region PopulateCMMeasurementBookDetail

        public static void PopulateCMMeasurementBookDetail(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ItemID";
            dropDownList.DataValueField = "MeasurementBookDetailID";
            dropDownList.DataSource = FCCCMMeasurementBookDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMMeasurementBookDetail

        #region PopulateCMMeasurementBook

        public static void PopulateCMMeasurementBook(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectID";
            dropDownList.DataValueField = "MeasurementBookID";
            dropDownList.DataSource = FCCCMMeasurementBook.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMMeasurementBook

        #region PopulateCMBill

        public static void PopulateCMBill(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BillNo";
            dropDownList.DataValueField = "BillID";
            dropDownList.DataSource = FCCCMBill.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCMBillByProject(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 projectID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BillNo";
            dropDownList.DataValueField = "BillID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCCMBill.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCMApprovedBillByProject(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 projectID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BillNo";
            dropDownList.DataValueField = "BillID";
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_BillApprovalStatusID, MasterDataConstants.BillApprovalStatus.APPROVED.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            dropDownList.DataSource = FCCCMBill.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCMApprovedBill(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BillNo";
            dropDownList.DataValueField = "BillID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_BillApprovalStatusID, MasterDataConstants.BillApprovalStatus.APPROVED.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCCMBill.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCMApprovedBillExceptACCPayable(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BillNo";
            dropDownList.DataValueField = "BillID";
            dropDownList.DataSource = FCCCMApprovedBillExceptACCPrePayable_Custom.GetFacadeCreate().GetIL();
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCMBillByWorkOrder(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 workOrderID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "BillNo";
            dropDownList.DataValueField = "BillID";

            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_ProjectID, workOrderID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(CMBillEntity.FLD_NAME_ProjectID, workOrderID.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            dropDownList.DataSource = FCCCMBill.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Bill", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMBill

        #region PopulateMDBillStatus

        public static void PopulateMDBillStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BillStatusID";
            dropDownList.DataSource = FCCMDBillStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDBillStatus

        #region PopulatePRMSupplierContactPerson

        public static void PopulatePRMSupplierContactPerson(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SupplierContactPersonID";
            dropDownList.DataSource = FCCPRMSupplierContactPerson.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulatePRMSupplierContactPersonByVendorID(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 vendorID)
        {

            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierContactPersonEntity.FLD_NAME_SupplierID, vendorID.ToString(), SQLMatchType.Equal);
            IList<PRMSupplierContactPersonEntity> lstWorkOrder = FCCPRMSupplierContactPerson.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);

            dropDownList.Items.Clear();

            if (lstWorkOrder != null && lstWorkOrder.Count > 0)
            {
                foreach (PRMSupplierContactPersonEntity ent in lstWorkOrder)
                {
                    ListItem lstItem = new ListItem();
                    lstItem.Text = ent.Name + " - " + ent.Phone;
                    lstItem.Value = ent.SupplierContactPersonID.ToString();
                    dropDownList.Items.Add(lstItem);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulatePRMSupplierContactPerson

        #region PopulateMDBillApprovalStatus

        public static void PopulateMDBillApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BillApprovalStatusID";
            dropDownList.DataSource = FCCMDBillApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDBillApprovalStatus

        #region PopulateMDMailTemplateType

        public static void PopulateMDMailTemplateType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "MailTemplateTypeID";
            dropDownList.DataSource = FCCMDMailTemplateType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDMailTemplateType

        #region PopulateMDVendorCategory

        public static void PopulateMDVendorCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "VendorCategoryID";
            dropDownList.DataSource = FCCMDVendorCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDVendorCategory

        #region PopulateMDACCPayablePaymentStatus

        public static void PopulateMDACCPayablePaymentStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ACCPayablePaymentStatusID";
            dropDownList.DataSource = FCCMDACCPayablePaymentStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDACCPayablePaymentStatus

        #region PopulateMDACCPayableApprovalStatus

        public static void PopulateMDACCPayableApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ACCPayableApprovalStatusID";
            dropDownList.DataSource = FCCMDACCPayableApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDACCPayableApprovalStatus

        #region PopulateACCPrePayableStatement

        public static void PopulateACCPrePayableStatement(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Ref";
            dropDownList.DataValueField = "PrePayableStatementID";
            String fe=ACCPrePayableStatementEntity.FLD_NAME_PrePayableStatementID+"<>" +MasterDataConstants.ACCPayableDefault.ACC_PRE_PAYABLE_STATEMENT_DEFAULT.ToString();
            dropDownList.DataSource = FCCACCPrePayableStatement.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateACCPrePayableStatementDistinct(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Ref";
            dropDownList.DataValueField = "PrePayableStatementID";
            dropDownList.DataSource = FCCACCPrePayableStatementDistinct_Custom.GetFacadeCreate().GetDT();
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACCPrePayableStatement

        #region PopulateACCPostPayableStatement

        public static void PopulateACCPostPayableStatement(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "PrePayableStatementID";
            dropDownList.DataValueField = "PostPayableStatementID";
            dropDownList.DataSource = FCCACCPostPayableStatement.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACCPostPayableStatement

        #region PopulateACCPrePayableStatementDetail

        public static void PopulateACCPrePayableStatementDetail(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "PrePayableStatementID";
            dropDownList.DataValueField = "PrePayableStatementDetailID";
            dropDownList.DataSource = FCCACCPrePayableStatementDetail.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACCPrePayableStatementDetail

        #region PopulateMDAccountPaybleStatementDetailCategory

        public static void PopulateMDAccountPaybleStatementDetailCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AccountPaybleStatementDetailCategoryID";
            dropDownList.DataSource = FCCMDAccountPaybleStatementDetailCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDAccountPaybleStatementDetailCategory

        #region PopulateMDPayableClassification

        public static void PopulateMDPayableClassification(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "PayableClassificationID";
            dropDownList.DataSource = FCCMDPayableClassification.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDPayableClassification

        #region PopulateMDStoreIssueNoteApprovalStatus

        public static void PopulateMDStoreIssueNoteApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "StoreIssueNoteApprovalStatusID";
            dropDownList.DataSource = FCCMDStoreIssueNoteApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDStoreIssueNoteApprovalStatus

        #region PopulateINVStoreIssueNote

        public static void PopulateINVStoreIssueNote(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectID";
            dropDownList.DataValueField = "StoreIssueNoteID";
            dropDownList.DataSource = FCCINVStoreIssueNote.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateINVStoreIssueNoteItemBystoreIssueNoteID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 storeIssueNoteID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "MDItemItemName";
            dropDownList.DataValueField = "ItemID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression("INVStoreIssueNoteItemMap." + INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteID, storeIssueNoteID.ToString(), SQLMatchType.Equal);
            String se = SqlExpressionBuilder.PrepareSortExpression("INVStoreIssueNoteItemMap." + INVStoreIssueNoteItemMapEntity.FLD_NAME_StoreIssueNoteItemMapID,SQLSortOrderType.Assending);
            dropDownList.DataSource = FCCINVStoreIssueNoteItemMap_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateINVStoreIssueNote

        #region PopulateINVStore

        public static void PopulateINVStore(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "StoreID";
            dropDownList.DataSource = FCCINVStore.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateINVStore

        #region PopulateINVStore

        public static void PopulateINVStoreByProject(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 projectID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "StoreID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCINVStore.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateINVStore

        #region PopulateMDInventoryStoreUnitType

        public static void PopulateMDInventoryStoreUnitType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "InventoryStoreUnitTypeID";
            dropDownList.DataSource = FCCMDInventoryStoreUnitType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDInventoryStoreUnit

        #region PopulateINVStoreUnit

        public static void PopulateINVStoreUnit(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();


            dropDownList.DataTextField = "UnitTrackNumber";
            dropDownList.DataValueField = "StoreUnitID";
            dropDownList.DataSource = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateINVStoreUnitByStore(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 storeID)
        {
            dropDownList.Items.Clear();


            dropDownList.DataTextField = "UnitTrackNumber";
            dropDownList.DataValueField = "StoreUnitID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreID, storeID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateINVStoreUnit

        #region PopulateMDInventoryTransferStatus

        public static void PopulateMDInventoryTransferStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "InventoryTransferStatusID";
            dropDownList.DataSource = FCCMDInventoryTransferStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDInventoryTransferStatus

        #region PopulateINVTransfer

        public static void PopulateINVTransfer(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "TRFNo";
            dropDownList.DataValueField = "TransferID";
            dropDownList.DataSource = FCCINVTransfer.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateINVTransfer

        #region PopulateACAccountGroup

        public static void PopulateACAccountGroup(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AccountGroupID";
            dropDownList.DataSource = FCCACAccountGroup.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

         #endregion PopulateACAccountGroup

        #region PopulateBayGroupDropDownList - Account

        public static void PopulateACAccountByAccountGroup(BayGroupDropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();

            IList<ACAccountGroupEntity> lstAccountGroup = FCCACAccountGroup.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            IList<ACAccountEntity> lstAccount = FCCACAccount.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);

            String space = "";
            String spaceGroup = "";

            LoadAccountDropDown(dropDownList, lstAccountGroup, lstAccount, null, space, spaceGroup);
            
            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateACAccountByAccountGroupByReference(BayGroupDropDownList dropDownList, Boolean addPleaseSelectOption,String inReferenceID)
        {
            dropDownList.Items.Clear();

            IList<ACAccountGroupEntity> lstAccountGroup = FCCACAccountGroup.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            String fe_account = "AccountID IN(" + inReferenceID + ")";
            IList<ACAccountEntity> lstAccount = FCCACAccount.GetFacadeCreate().GetIL(null, null, String.Empty, fe_account, DatabaseOperationType.LoadWithFilterExpression);

            String space = "";
            String spaceGroup = "";

            LoadAccountDropDown(dropDownList, lstAccountGroup, lstAccount, null, space, spaceGroup);

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        private static void LoadAccountDropDown(BayGroupDropDownList dropDownList, IList<ACAccountGroupEntity> lstAccountGroup, IList<ACAccountEntity> lstAccount,Int64? parentAccountGroupID, String space, String spaceGroup)
        {
            if (lstAccountGroup != null && lstAccountGroup.Count > 0)
            {
                IList<ACAccountGroupEntity> lstParentaccountGroup = (from s in lstAccountGroup
                                                                     where s.ParentAccountGroupID == parentAccountGroupID
                                                                     select s).ToList();

                if (lstParentaccountGroup != null && lstParentaccountGroup.Count > 0)
                {
                    foreach (ACAccountGroupEntity ent in lstParentaccountGroup)
                    {
                        String acGroupName = ent.Name;
                        acGroupName = spaceGroup + ent.Name;                        
                        dropDownList.AddItemGroup(acGroupName);
                        
                        if (lstAccount != null && lstAccount.Count > 0)
                        {
                            IList<ACAccountEntity> lstChildAccount = (from s in lstAccount
                                                                      where s.AccountGroupID == ent.AccountGroupID
                                                                      select s).ToList();

                            foreach (ACAccountEntity entACAccountEntity in lstChildAccount)
                            {
                                ListItem l = new ListItem("", "");
                                l.Text = HttpUtility.HtmlDecode(space + entACAccountEntity.AccountCode + " - " + entACAccountEntity.AccountName);
                                l.Value = entACAccountEntity.AccountID.ToString();

                                dropDownList.Items.Add(l);
                            }
                        }

                        space += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
                        spaceGroup += "&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;";
                        

                        LoadAccountDropDown(dropDownList, lstAccountGroup, lstAccount, ent.AccountGroupID, space, spaceGroup);

                        try
                        {
                            space = space.Remove(space.LastIndexOf("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"));
                            spaceGroup = spaceGroup.Remove(spaceGroup.LastIndexOf("&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;"));
                        }
                        catch (Exception ex)
                        { }
                    }
                }
            }
        }

        #endregion PopulateBayGroupDropDownList

        #region PopulateACAccountStatus

        public static void PopulateACAccountStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AccountStatusID";
            dropDownList.DataSource = FCCACAccountStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACAccountStatus

        #region PopulateACClass

        public static void PopulateACClass(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ClassID";
            dropDownList.DataSource = FCCACClass.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACClass

        #region PopulateACClassType

        public static void PopulateACClassType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ClassTypeID";
            dropDownList.DataSource = FCCACClassType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACClassType

        #region PopulateACAccount

        public static void PopulateACAccount(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "AccountName";
            dropDownList.DataValueField = "AccountID";
            dropDownList.DataSource = FCCACAccount.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACAccount

        #region PopulateACMDBankAccountType

        public static void PopulateACMDBankAccountType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BankAccountTypeID";
            dropDownList.DataSource = FCCACMDBankAccountType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACMDBankAccountType

        #region PopulateMDCurrency

        public static void PopulateMDCurrency(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "CurrencyName";
            dropDownList.DataValueField = "CurrencyID";
            dropDownList.DataSource = FCCMDCurrency.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDCurrency

        #region PopulateACFiscalYear

        public static void PopulateACFiscalYear(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {  
            IList<ACFiscalYearEntity> lstFiscalYear = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

            dropDownList.Items.Clear();

            if (lstFiscalYear != null && lstFiscalYear.Count > 0)
            {
                foreach (ACFiscalYearEntity ent in lstFiscalYear.OrderByDescending( x=> x.FiscalYearID))
                {
                    ListItem lstItem = new ListItem();

                    String StrActive = String.Empty;

                    if (ent.IsClosed)
                    {
                        StrActive = "Closed";
                    }

                    else if (ent.IsClosed==false)
                    {
                        StrActive = "Active";
                    }

                    lstItem.Text = ent.BeginDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " to " + ent.EndDate.ToString(UIConstants.SHORT_DATE_FORMAT) + " - " + StrActive;
                    lstItem.Value = ent.FiscalYearID.ToString();
                    dropDownList.Items.Add(lstItem);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACFiscalYear

        #region PopulateACTaxType

        public static void PopulateACTaxType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "TaxTypeID";
            dropDownList.DataSource = FCCACTaxType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACTaxType

        #region PopulateACDebitCreditRuleElement

        public static void PopulateACDebitCreditRuleElement(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Action";
            dropDownList.DataValueField = "DebitCreditRuleElementID";
            dropDownList.DataSource = FCCACDebitCreditRuleElement.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACDebitCreditRuleElement

        #region PopulateACMDDebitCredit

        public static void PopulateACMDDebitCredit(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "MDDebitCreditID";
            dropDownList.DataSource = FCCACMDDebitCredit.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACMDDebitCredit

        #region PopulateACDimension

        public static void PopulateACDimension(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "DimensionID";
            dropDownList.DataSource = FCCACDimension.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACDimension

        #region PopulateACDepreciationMethod

        public static void PopulateACDepreciationMethod(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "DepreciationMethodID";
            dropDownList.DataSource = FCCACDepreciationMethod.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACDepreciationMethod

        #region PopulateACJournal

        public static void PopulateACJournal(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "AccountID";
            dropDownList.DataValueField = "JournalID";
            dropDownList.DataSource = FCCACJournal.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACJournal

        #region PopulateACBankAccount

        public static void PopulateACBankAccount(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            IList<ACBankAccountEntity> lst = FCCACBankAccount.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

            if(lst!=null && lst.Count>0)
            {

                foreach (ACBankAccountEntity li in lst)
                {
                    String str = li.BankAccountName;
                    str.Split(' ').ToList().ForEach(i => Console.Write(i[0] + " "));

                    ListItem item = new ListItem();
                    item.Text = str + "-" + li.BankAccountNumber.ToString();
                    item.Value = li.BankAccountID.ToString();

                    dropDownList.Items.Add(item);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACBankAccount

        #region PopulateACBankAccountDeposit

        public static void PopulateACBankAccountDeposit(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BankAccountDepositID";
            dropDownList.DataSource = FCCACBankAccountDeposit.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACBankAccountDeposit

        #region PopulateACBankAccountPayment

        public static void PopulateACBankAccountPayment(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BankAccountPaymentID";
            dropDownList.DataSource = FCCACBankAccountPayment.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACBankAccountPayment

        #region PopulateCRMCustomer

        public static void PopulateCRMCustomer(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "FirstName";
            dropDownList.DataValueField = "CustomerID";
            dropDownList.DataSource = FCCCRMCustomer.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMCustomer

        #region PopulateCRMMDCustomerAddressType

        public static void PopulateCRMMDCustomerAddressType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "CustomerAddressTypeID";
            dropDownList.DataSource = FCCCRMMDCustomerAddressType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDCustomerAddressType

        #region PopulateACMDPayTo

        public static void PopulateACMDPayTo(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "PayToID";
            dropDownList.DataSource = FCCACMDPayTo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACMDPayTo

        #region PopulateACMDPaidFrom

        public static void PopulateACMDPaidFrom(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "PaidFromID";
            dropDownList.DataSource = FCCACMDPaidFrom.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACMDPaidFrom

        #region PopulateACMDAccountResourceCategory

        public static void PopulateACMDAccountResourceCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AccountResourceCategoryID";
            dropDownList.DataSource = FCCACMDAccountResourceCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACMDAccountResourceCategory

        #region PopulateACMDBankAccountPaymentApprovalStatus

        public static void PopulateACMDBankAccountPaymentApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BankAccountPaymentApprovalStatusID";
            dropDownList.DataSource = FCCACMDBankAccountPaymentApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACMDBankAccountPaymentApprovalStatus

        #region PopulateACMDBankAccountDepositApprovalStatus

        public static void PopulateACMDBankAccountDepositApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BankAccountDepositApprovalStatusID";
            dropDownList.DataSource = FCCACMDBankAccountDepositApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACMDBankAccountDepositApprovalStatus

        #region PopulateACMDTemporaryJournalApprovalStatus

        public static void PopulateACMDTemporaryJournalApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "TemporyJournalApprovalStatusID";
            dropDownList.DataSource = FCCACMDTemporaryJournalApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACMDTemporaryJournalApprovalStatus

        #region PopulateACMDBankAccountTransferApprovalStatus

        public static void PopulateACMDBankAccountTransferApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BankAccountTransferApprovalStatusID";
            dropDownList.DataSource = FCCACMDBankAccountTransferApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACMDBankAccountTransferApprovalStatus

        #region PopulateACMDTDSCategory

        public static void PopulateACMDTDSCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "TDSCategoryID";
            dropDownList.DataSource = FCCACMDTDSCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateACMDTDSCategory

        #region PopulateMDMaterialReceiveApprovalStatus

        public static void PopulateMDMaterialReceiveApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "MaterialReceiveApprovalStatusID";
            dropDownList.DataSource = FCCMDMaterialReceiveApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDMaterialReceiveApprovalStatus

        #region PopulateMDIssueAssignType

        public static void PopulateMDIssueAssignType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "IssueAssignTypeID";
            String se = SqlExpressionBuilder.PrepareSortExpression(MDIssueAssignTypeEntity.FLD_NAME_Name, SQLSortOrderType.Assending);
            dropDownList.DataSource = FCCMDIssueAssignType.GetFacadeCreate().GetIL(null, null, se, null, DatabaseOperationType.LoadWithSortExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDCountry

        #region PopulateCMNProcessCategory

        public static void PopulateCMNProcessCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProcessCategoryID";
            String fe = "Name";
            dropDownList.DataSource = FCCCMNProcessCategory.GetFacadeCreate().GetIL(null, null, fe, null, DatabaseOperationType.LoadWithSortExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMNProcessCategory

        #region PopulateKBUserTree

        public static void PopulateKBUserTree(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Title";
            dropDownList.DataValueField = "UserTreeID";
            String fe = "ParentUserTreeID is null";
            dropDownList.DataSource = FCCKBUserTree.GetFacadeCreate().GetIL(null, null,String.Empty,fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("ALL", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateKBUserTree

        #region PopulateKBMDUserTreeStatus

        public static void PopulateKBMDUserTreeStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "UserTreeStatusID";
            dropDownList.DataSource = FCCKBMDUserTreeStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateKBMDUserTreeStatus

        #region PopulateKBMDUserTreeSetting

        public static void PopulateKBMDUserTreeSetting(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "UserTreeSettingID";
            dropDownList.DataSource = FCCKBMDUserTreeSetting.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateKBMDUserTreeSetting

        #region PopulateKBMDUserTreeSharedPermission

        public static void PopulateKBMDUserTreeSharedPermission(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "UserTreeSharedPermissionID";
            dropDownList.DataSource = FCCKBMDUserTreeSharedPermission.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateKBMDUserTreeSharedPermission

        #region PopulateCRMBuyerBasicInfo

        public static void PopulateCRMBuyerBasicInfo(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            IList<CRMBuyerBasicInfoEntity> lst = FCCCRMBuyerBasicInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

            dropDownList.Items.Clear();

            if (lst != null && lst.Count > 0)
            {
                foreach (CRMBuyerBasicInfoEntity ent in lst.OrderBy(x => x.ContactFullName).ToList())
                {
                    ListItem li = new ListItem();
                    li.Text = ent.ContactFullName + " - " + ent.CompanyName + " - " + ent.Designation;
                    li.Value = ent.BuyerBasicInfoID.ToString();
                    dropDownList.Items.Add(li);
                }

                if (addPleaseSelectOption == true)
                {
                    ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                    dropDownList.Items.Insert(0, pleaseSelectListItem);
                }
            }
        }

        public static void PopulateCRMBuyerBasicInfo(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 id)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMBuyerBasicInfoEntity.FLD_NAME_BuyerBasicInfoID, id.ToString(), SQLMatchType.Equal);
            IList<CRMBuyerBasicInfoEntity> lst = FCCCRMBuyerBasicInfo.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);

            dropDownList.Items.Clear();

            if (lst != null && lst.Count > 0)
            {
                foreach (CRMBuyerBasicInfoEntity ent in lst.OrderBy(x => x.ContactFullName).ToList())
                {
                    ListItem li = new ListItem();
                    li.Text = ent.ContactFullName + " - " + ent.CompanyName + " - " + ent.Designation;
                    li.Value = ent.BuyerBasicInfoID.ToString();
                    dropDownList.Items.Add(li);
                }

                if (addPleaseSelectOption == true)
                {
                    ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                    dropDownList.Items.Insert(0, pleaseSelectListItem);
                }
            }
        }

        #endregion PopulateCRMBuyerBasicInfo

        #region PopulateCRMMDBuyerType

        public static void PopulateCRMMDBuyerType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BuyerTypeID";
            dropDownList.DataSource = FCCCRMMDBuyerType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDBuyerType

        #region PopulateCRMMDLandLocation

        public static void PopulateCRMMDLandLocation(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "LandLocationID";
            dropDownList.DataSource = FCCCRMMDLandLocation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDLandLocation

        #region PopulateCRMMDAreaUnit

        public static void PopulateCRMMDAreaUnit(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AreaUnitID";
            dropDownList.DataSource = FCCCRMMDAreaUnit.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDAreaUnit

        #region PopulateBDProjectFloorUnit

        public static void PopulateBDProjectFloorUnit(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectFloorUnitName";
            dropDownList.DataValueField = "ProjectFloorUnitID";
            dropDownList.DataSource = FCCBDProjectFloorUnit.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateBDProjectFloorUnitByProject(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 projectID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectFloorUnitName";
            dropDownList.DataValueField = "ProjectFloorUnitID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression("BDProjectFloor.ProjectID", projectID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCBDProjectFloorUnit_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateBDAvailableProjectFloorUnitByProject(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 projectID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectFloorUnitName";
            dropDownList.DataValueField = "ProjectFloorUnitID";
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("BDProjectFloor.ProjectID", projectID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("BDProjectFloorUnit." + BDProjectFloorUnitEntity.FLD_NAME_ProjectFloorUnitStatusID, MasterDataConstants.MDProjectFloorUnitStatus.AVAILABLE.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            dropDownList.DataSource = FCCBDProjectFloorUnit_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateBDNotAvailableProjectFloorUnitByProject(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 projectID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectFloorUnitName";
            dropDownList.DataValueField = "ProjectFloorUnitID";
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("BDProjectFloor.ProjectID", projectID.ToString(), SQLMatchType.Equal);
            String fe2 = "BDProjectFloorUnit." + BDProjectFloorUnitEntity.FLD_NAME_ProjectFloorUnitStatusID+"<>"+ MasterDataConstants.MDProjectFloorUnitStatus.AVAILABLE.ToString();
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            dropDownList.DataSource = FCCBDProjectFloorUnit_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, fe);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateBDProjectFloorUnitByFloor(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 projectFloorID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProjectFloorUnitName";
            dropDownList.DataValueField = "ProjectFloorUnitID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectFloorUnitEntity.FLD_NAME_ProjectFloorID, projectFloorID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCBDProjectFloorUnit.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Floor Unit", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDProjectFloorUnit

        #region PopulateCRMMDBookingStatus

        public static void PopulateCRMMDBookingStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BookingStatusID";
            dropDownList.DataSource = FCCCRMMDBookingStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDBookingStatus

        #region PopulateCRMMDBuyerInterestedRoomCategory

        public static void PopulateCRMMDBuyerInterestedRoomCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BuyerInterestedRoomCategoryID";
            dropDownList.DataSource = FCCCRMMDBuyerInterestedRoomCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDBuyerInterestedRoomCategory

        #region PopulateCRMMDCommuicationDiscussionType

        public static void PopulateCRMMDCommuicationDiscussionType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "CommuicationDiscussionTypeID";
            dropDownList.DataSource = FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDCommuicationDiscussionType

        #region PopulateCRMMDCommunicationStatus

        public static void PopulateCRMMDCommunicationStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "CommunicationStatusID";
            dropDownList.DataSource = FCCCRMMDCommunicationStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDCommunicationStatus

        #region PopulateCRMMDLandOwnerType

        public static void PopulateCRMMDLandOwnerType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "LandOwnerTypeID";
            dropDownList.DataSource = FCCCRMMDLandOwnerType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDLandOwnerType

        #region PopulateCRMLandBasicInfo

        public static void PopulateCRMLandBasicInfo(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            IList<CRMLandBasicInfoEntity> lst = FCCCRMLandBasicInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

            dropDownList.Items.Clear();
            if (lst != null && lst.Count > 0)
            {
                foreach (CRMLandBasicInfoEntity ent in lst.OrderBy(x => x.ContactFullName).ToList())
                {
                    ListItem li = new ListItem();
                    li.Text = ent.ContactFullName + " - " + ent.MobileNo;
                    li.Value = ent.LandBasicInfoID.ToString();
                    dropDownList.Items.Add(li);
                }
                if (addPleaseSelectOption == true)
                {
                    ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                    dropDownList.Items.Insert(0, pleaseSelectListItem);
                }
            }
        }

        #endregion PopulateCRMLandBasicInfo

        #region PopulateMDProjectFloorUnitType

        public static void PopulateMDProjectFloorUnitType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectFloorUnitTypeID";
            dropDownList.DataSource = FCCMDProjectFloorUnitType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDProjectFloorUnitType

        #region PopulateMDProjectFloorUnitStatus

        public static void PopulateMDProjectFloorUnitStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectFloorUnitStatusID";
            dropDownList.DataSource = FCCMDProjectFloorUnitStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDProjectFloorUnitStatus

        #region PopulateCRMMDAdvertiseWay

        public static void PopulateCRMMDAdvertiseWay(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AdvertiseWayID";
            dropDownList.DataSource = FCCCRMMDAdvertiseWay.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDAdvertiseWay

        #region PopulateMDEmployeeJobType

        public static void PopulateMDEmployeeJobType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EmployeeJobTypeID";
            dropDownList.DataSource = FCCMDEmployeeJobType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEmployeeJobType

        #region PopulateMDBloodGroup

        public static void PopulateMDBloodGroup(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BloodGroupID";
            dropDownList.DataSource = FCCMDBloodGroup.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDBloodGroup

        #region PopulateCRMMDAgreementType

        public static void PopulateCRMMDAgreementType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AgreementTypeID";
            dropDownList.DataSource = FCCCRMMDAgreementType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDAgreementType

        #region PopulateCRMMDAgreementApprovalStatus

        public static void PopulateCRMMDAgreementApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AgreementApprovalStatusID";
            dropDownList.DataSource = FCCCRMMDAgreementApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDAgreementApprovalStatus

        #region PopulateCRMAgreement

        public static void PopulateCRMAgreement(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression("CRMAgreement." + CRMAgreementEntity.FLD_NAME_AgreementApprovalStatusID, MasterDataConstants.CRMMDAgreementApprovalStatus.APPROVED.ToString(), SQLMatchType.Equal);
            IList<CRMAgreement_DetailedEntity> lstAgreement=FCCCRMAgreement_Detailed.GetFacadeCreate().GetIL(100000,1,String.Empty,fe);

            dropDownList.Items.Clear();

            if (lstAgreement != null && lstAgreement.Count > 0)
            {
                foreach (CRMAgreement_DetailedEntity ent in lstAgreement.OrderBy(a => a.CRMBuyerBasicInfoContactFullName).ToList())
                {
                    ListItem lstItem = new ListItem();
                    lstItem.Text = ent.CRMBuyerBasicInfoContactFullName + "-" + ent.BDProjectProjectName + " - " + ent.BDProjectFloorUnitProjectFloorUnitName;
                    lstItem.Value = ent.AgreementID.ToString();
                    dropDownList.Items.Add(lstItem);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCRMAgreementByAgreementType(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 agreementTypeID)
        {
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("CRMAgreement." + CRMAgreementEntity.FLD_NAME_AgreementApprovalStatusID, MasterDataConstants.CRMMDAgreementApprovalStatus.APPROVED.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("CRMAgreement." + CRMAgreementEntity.FLD_NAME_AgreementTypeID, agreementTypeID.ToString(), SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            IList<CRMAgreement_DetailedEntity> lstAgreement = FCCCRMAgreement_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);

            dropDownList.Items.Clear();

            if (lstAgreement != null && lstAgreement.Count > 0)
            {
                foreach (CRMAgreement_DetailedEntity ent in lstAgreement)
                {
                    ListItem lstItem = new ListItem();
                    lstItem.Text = ent.CRMBuyerBasicInfoContactFullName + "-" + ent.BDProjectProjectName + " - " + ent.BDProjectFloorUnitProjectFloorUnitName;
                    lstItem.Value = ent.AgreementID.ToString();
                    dropDownList.Items.Add(lstItem);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMAgreement

        #region PopulateCRMMDAgreementSpecsType

        public static void PopulateCRMMDAgreementSpecsType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AgreementSpecsTypeID";
            dropDownList.DataSource = FCCCRMMDAgreementSpecsType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDAgreementSpecsType

        #region PopulateCRMMDAgreementType

        public static void PopulateCRMMDAgreementTemplate(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "TemplateName";
            dropDownList.DataValueField = "AgreementTemplateID";
            dropDownList.DataSource = FCCCRMAgreementTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDAgreementType

        #region PopulateCRMPaymentScheduleMap

        public static void PopulateCRMPaymentScheduleMap(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "InstallmentName";
            dropDownList.DataValueField = "PaymentScheduleMapID";
            dropDownList.DataSource = FCCCRMPaymentScheduleMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCRMPendingPaymentScheduleMapByAgreement(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 agreementID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "InstallmentName";
            dropDownList.DataValueField = "PaymentScheduleMapID";
            String se = SqlExpressionBuilder.PrepareSortExpression(CRMPaymentScheduleMapEntity.FLD_NAME_InstallmentName, SQLSortOrderType.Assending);
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression("CRMAgreement." + CRMPaymentScheduleMapEntity.FLD_NAME_AgreementID, agreementID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression("CRMPaymentScheduleMap." + CRMPaymentScheduleMapEntity.FLD_NAME_FinalPayment, "0", SQLMatchType.Equal);
            String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

            dropDownList.DataSource = FCCCRMPaymentScheduleMap_Detailed.GetFacadeCreate().GetIL(10000,1,se,fe);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMPaymentScheduleMap

        #region PopulateCRMMDPaymentApprovalStatus

        public static void PopulateCRMMDPaymentApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "PaymentApprovalStatusID";
            dropDownList.DataSource = FCCCRMMDPaymentApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDPaymentApprovalStatus

        #region PopulateCRMMDPaymentCategory

        public static void PopulateCRMMDPaymentCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "PaymentCategoryID";
            dropDownList.DataSource = FCCCRMMDPaymentCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMMDPaymentCategory

        #region PopulateCRMPaymentSchedule

        public static void PopulateCRMPaymentSchedule(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();

            dropDownList.DataTextField = "PaymentScheduleID";
            dropDownList.DataValueField = "PaymentScheduleID";
            dropDownList.DataSource = FCCCRMPaymentSchedule.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCRMPaymentScheduleWithIDBuyerForjectAndFloor(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            IList<CRMPaymentSchedule_DetailedEntity> lst = FCCCRMPaymentSchedule_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, String.Empty);
            if (lst != null && lst.Count > 0)
            {
                foreach (CRMPaymentSchedule_DetailedEntity ent in lst.OrderBy(a => a.PaymentScheduleID).ToList())
                {
                    ListItem lstItem = new ListItem();
                    lstItem.Text = ent.PaymentScheduleID + " - " + ent.ProjectName+"  -"+ent.BuyerBasicInfoContactFullName+" - "+ent.ProjectFloorUnitName;
                    lstItem.Value = ent.PaymentScheduleID.ToString();
                    dropDownList.Items.Add(lstItem);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateCRMPaymentScheduleByAgreement(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 agreementID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "AgreementID";
            dropDownList.DataValueField = "PaymentScheduleID";
            //String fe = SqlExpressionBuilder.PrepareFilterExpression(CRMPaymentScheduleEntity.FLD_NAME_AgreementID, agreementID.ToString(), SQLMatchType.Equal);
            //dropDownList.DataSource = FCCCRMPaymentSchedule.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMPaymentSchedule

        #region PopulateMDGender

        public static void PopulateMDGender(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "GenderID";
            dropDownList.DataSource = FCCMDGender.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDGender

        #region PopulateBDMDTaskCategory

        public static void PopulateBDMDTaskCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "TaskCategoryID";
            dropDownList.DataSource = FCCBDMDTaskCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDMDTaskCategory

        #region PopulateBDMDTask

        public static void PopulateBDMDTask(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "TaskID";
            dropDownList.DataSource = FCCBDMDTask.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDMDTask

        #region PopulateBDMDRepeatCategory

        public static void PopulateBDMDRepeatCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "RepeatCategoryID";
            dropDownList.DataSource = FCCBDMDRepeatCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDMDRepeatCategory

        #region PopulateBDMDProcessCategory

        public static void PopulateBDMDProcessCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProcessCategoryID";
            dropDownList.DataSource = FCCBDMDProcessCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDMDProcessCategory

        #region PopulateBDMDProcessAssignedResourceApprovalStatus

        public static void PopulateBDMDProcessAssignedResourceApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProcessAssignedResourceApprovalStatusID";
            dropDownList.DataSource = FCCBDMDProcessAssignedResourceApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDMDProcessAssignedResourceApprovalStatus

        #region PopulateBDProcessAssignedResource

        public static void PopulateBDProcessAssignedResource(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "ProcessCategoryID";
            dropDownList.DataValueField = "ProcessAssignedResourceID";
            dropDownList.DataSource = FCCBDProcessAssignedResource.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDProcessAssignedResource

        #region PopulateBDTaskTemplate

        public static void PopulateBDTaskTemplate(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "TemplateName";
            dropDownList.DataValueField = "TaskTemplateID";
            dropDownList.DataSource = FCCBDTaskTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDTaskTemplate

        #region PopulateMDEvaluationCriteria

        public static void PopulateMDEvaluationCriteria(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Question";
            dropDownList.DataValueField = "EvaluationCriteriaID";
            dropDownList.DataSource = FCCMDEvaluationCriteria.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEvaluationCriteria

        #region PopulateMDEvaluationSessionCategory

        public static void PopulateMDEvaluationSessionCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SessionCategoryID";
            dropDownList.DataSource = FCCMDEvaluationSessionCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEvaluationSessionCategory

        #region PopulateMDEvaluationSessionStatus

        public static void PopulateMDEvaluationSessionStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EvaluationSessionStatusID";
            dropDownList.DataSource = FCCMDEvaluationSessionStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEvaluationSessionStatus

        #region PopulateHRSession

        public static void PopulateHRSession(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "SessionName";
            dropDownList.DataValueField = "SessionID";
            dropDownList.DataSource = FCCHRSession.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateHRSession

        #region PopulateMDEvaluatedBy

        public static void PopulateMDEvaluatedBy(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EvaluatedByID";
            dropDownList.DataSource = FCCMDEvaluatedBy.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEvaluatedBy

        #region PopulateMDEvaluationCriteriaCategory

        public static void PopulateMDEvaluationCriteriaCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EvaluationCriteriaCategoryID";
            dropDownList.DataSource = FCCMDEvaluationCriteriaCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEvaluationCriteriaCategory

        #region PopulateHREmployeeEvaluation

        public static void PopulateHREmployeeEvaluation(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "EmployeeFullName";
            dropDownList.DataValueField = "EmployeeEvaluationID";
            dropDownList.DataSource = FCCHREmployeeEvaluation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateHREmployeeEvaluation

        #region PopulateMDSupervisorType

        public static void PopulateMDSupervisorType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SupervisorTypeID";
            dropDownList.DataSource = FCCMDSupervisorType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSupervisorType

        #region PopulateMDFloorUnitLocationCategory

        public static void PopulateMDFloorUnitLocationCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "FloorUnitLocationCategoryID";
            dropDownList.DataSource = FCCMDFloorUnitLocationCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDFloorUnitLocationCategory

        #region PopulateMDOutsourceCategory

        public static void PopulateMDOutsourceCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "OutsourceCategoryID";
            dropDownList.DataSource = FCCMDOutsourceCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDOutsourceCategory

        #region PopulateCMNMDEventIdentityCategory

        public static void PopulateCMNMDEventIdentityCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EventIdentityCategoryID";
            dropDownList.DataSource = FCCCMNMDEventIdentityCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMNMDEventIdentityCategory

        #region PopulateCMNMDEventCategory

        public static void PopulateCMNMDEventCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EventCategoryID";
            dropDownList.DataSource = FCCCMNMDEventCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMNMDEventCategory

        #region PopulateCMNMDEventCategoryByIdentity

        public static void PopulateCMNMDEventCategoryByEventIdentity(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 eventIdentityID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EventCategoryID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNMDEventCategoryEntity.FLD_NAME_EventIdentityCategoryID, eventIdentityID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCCMNMDEventCategory.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMNMDEventCategory

        #region PopulateCMNEvent

        public static void PopulateCMNEvent(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "EventIdentityCategoryID";
            dropDownList.DataValueField = "EventID";
            dropDownList.DataSource = FCCCMNEvent.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMNEvent

        #region PopulateCMNMDEventOption

        public static void PopulateCMNMDEventOption(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EventOptionID";
            dropDownList.DataSource = FCCCMNMDEventOption.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMNMDEventOption

        #region PopulateCMNMDEventStatus

        public static void PopulateCMNMDEventStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EventStatusID";
            dropDownList.DataSource = FCCCMNMDEventStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMNMDEventStatus

        #region PopulateCMNMDSharedSetting

        public static void PopulateCMNMDSharedSetting(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SharedSettingID";
            dropDownList.DataSource = FCCCMNMDSharedSetting.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCMNMDSharedSetting

        #region PopulateMDEventLocationCategory

        public static void PopulateMDEventLocationCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EventLocationCategoryID";
            dropDownList.DataSource = FCCMDEventLocationCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEventLocationCategory

        #region PopulateMDArtGalleriaLocation

        public static void PopulateMDArtGalleriaLocation(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ArtGalleriaLocationID";
            dropDownList.DataSource = FCCMDArtGalleriaLocation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDArtGalleriaLocation

        #region PopulateMDAssetCateogry

        public static void PopulateMDAssetCateogry(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "CategoryName";
            dropDownList.DataValueField = "AssetCateogryID";
            dropDownList.DataSource = FCCMDAssetCateogry.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDAssetCateogry

        #region PopulateMDAssetOwnerType

        public static void PopulateMDAssetOwnerType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AssetOwnerTypeID";
            dropDownList.DataSource = FCCMDAssetOwnerType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDAssetOwnerType

        #region PopulateMDAssetCondition

        public static void PopulateMDAssetCondition(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AssetConditionID";
            dropDownList.DataSource = FCCMDAssetCondition.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDAssetCondition

        #region PopulateBDProjectFloorUnitLocation

        public static void PopulateBDProjectUnitLocationByProject(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 projectID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectUnitLocationID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectUnitLocationEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCBDProjectUnitLocation.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Floor", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateBDProjectUnitLocationByFloorUnit(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 projectFloorUnitID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectUnitLocationID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectUnitLocationEntity.FLD_NAME_ProjectFloorUnitID, projectFloorUnitID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCBDProjectUnitLocation.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Floor", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDProjectFloorUnitLocation

        #region PopulateCRMSurveyOwner

        public static void PopulateCRMSurveyOwner(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SurveyOwnerID";
            dropDownList.DataSource = FCCCRMSurveyOwner.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMSurveyOwner

        #region PopulateMDSurveyBuildingStatus

        public static void PopulateMDSurveyBuildingStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SurveyBuildingStatusID";
            dropDownList.DataSource = FCCMDSurveyBuildingStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSurveyBuildingStatus

        #region PopulateMDSurveySourceInformation

        public static void PopulateMDSurveySourceInformation(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SurveySourceInformationID";
            dropDownList.DataSource = FCCMDSurveySourceInformation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSurveySourceInformation

        #region PopulateMDSurveyOwnerType

        public static void PopulateMDSurveyOwnerType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SurveyOwnerTypeID";
            dropDownList.DataSource = FCCMDSurveyOwnerType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSurveyOwnerType

        #region PopulateMDMailTextType

        public static void PopulateMDMailTextType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "MailTextTypeID";
            dropDownList.DataSource = FCCMDMailTextType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDMailTextType

        #region PopulateMDEventInvitatedPersonType

        public static void PopulateMDEventInvitatedPersonType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EventInvitatedPersonTypeID";
            dropDownList.DataSource = FCCMDEventInvitatedPersonType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEventInvitatedPersonType

        #region PopulateBDProjectUnitLocation

        public static void PopulateBDProjectUnitLocation(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ProjectUnitLocationID";
            dropDownList.DataSource = FCCBDProjectUnitLocation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateBDProjectUnitLocation

        #region PopulateCRMSurveyMaster

        public static void PopulateCRMSurveyMaster(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Title";
            dropDownList.DataValueField = "SurveyMasterID";
            dropDownList.DataSource = FCCCRMSurveyMaster.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMSurveyOwner

        #region PopulateCRMSurveyMaster

        public static void PopulateMDArea(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AreaID";
            dropDownList.DataSource = FCCMDArea.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateCRMSurveyOwner

        #region PopulateMDAttendanceLeaveAndHolidayCategory

        public static void PopulateMDAttendanceLeaveAndHolidayCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AttendanceLeaveAndHolidayCategoryID";
            dropDownList.DataSource = FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        public static void PopulateMDAttendanceLeaveAndHolidayCategory(DropDownList dropDownList, Boolean addPleaseSelectOption,Int64 sortByID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AttendanceLeaveAndHolidayCategoryID";
            String fe = SqlExpressionBuilder.PrepareSortExpression(sortByID.ToString(), SQLSortOrderType.Assending);
            dropDownList.DataSource = FCCMDAttendanceLeaveAndHolidayCategory.GetFacadeCreate().GetIL(null, null, fe, null, DatabaseOperationType.LoadWithSortExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDAttendanceLeaveAndHolidayCategory

        #region PopulateMDSalaryRateDuration

        public static void PopulateMDSalaryRateDuration(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SalaryRateDurationID";
            dropDownList.DataSource = FCCMDSalaryRateDuration.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSalaryRateDuration

        #region PopulateMDSalarySessionStatus

        public static void PopulateMDSalarySessionStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SalarySessionStatusID";
            dropDownList.DataSource = FCCMDSalarySessionStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSalarySessionStatus

        #region PopulateMDEmployeeAdditionalInformationCategory

        public static void PopulateMDEmployeeAdditionalInformationCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EmployeeAdditionalInformationCategoryID";
            dropDownList.DataSource = FCCMDEmployeeAdditionalInformationCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEmployeeAdditionalInformationCategory

        #region PopulateMDEmployeeAddressType

        public static void PopulateMDEmployeeAddressType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EmployeeAddressTypeID";
            dropDownList.DataSource = FCCMDEmployeeAddressType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEmployeeAddressType

        #region HREmployeeNoticeTemplate 

        public static void PopulateHREmployeeNoticeTemplate(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "TemplateName";
            dropDownList.DataValueField = "EmployeeNoticeTemplateID";
            dropDownList.DataSource = FCCHREmployeeNoticeTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion

        #region PopulateMDBankAccountCategory

        public static void PopulateMDBankAccountCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "BankAccountCategoryID";
            dropDownList.DataSource = FCCMDBankAccountCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDBankAccountCategory

        #region PopulateMDMaritalStatus

        public static void PopulateMDMaritalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "MaritalStatusID";
            dropDownList.DataSource = FCCMDMaritalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDMaritalStatus

        #region PopulateMDDesignationByEmployeeID

        public static void PopulateMDDesignationByEmployeeID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 employeeID)
        {
            HREmployeeEntity entity = FCCHREmployee.GetFacadeCreate().GetByID(employeeID);

            String fe = SqlExpressionBuilder.PrepareFilterExpression(MDDesignationEntity.FLD_NAME_DesignationID, entity.DesignationID.ToString(), SQLMatchType.Equal);
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "DesignationID";
            dropDownList.DataSource = FCCMDDesignation.GetFacadeCreate().GetIL(null, null, null, fe, DatabaseOperationType.LoadWithFilterExpression);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDDesignation

        #region PopulateMDReligion

        public static void PopulateMDReligion(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ReligionID";
            dropDownList.DataSource = FCCMDReligion.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDReligion

        #region MDEmploymentStatus

        public static void PopulateMDEmploymentStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EmploymentStatusID";
            dropDownList.DataSource = FCCMDEmploymentStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }



        #endregion MDEmploymentStatus

        #region PopulateMDEmployeeContactType

        public static void PopulateMDEmployeeContactType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EmployeeContactTypeID";
            dropDownList.DataSource = FCCMDEmployeeContactType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEmployeeContactType

        #region PopulateMDDocumentCategory

        public static void PopulateMDDocumentCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "DocumentCategoryID";
            dropDownList.DataSource = FCCMDDocumentCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDDocumentCategory

        #region PopulateMDDrivingLicenseCategory

        public static void PopulateMDDrivingLicenseCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "DrivingLicenseCategoryID";
            dropDownList.DataSource = FCCMDDrivingLicenseCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDDrivingLicenseCategory

        #region PopulateMDEducationalDegree

        public static void PopulateMDEducationalDegree(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EducationalDegreeID";
            dropDownList.DataSource = FCCMDEducationalDegree.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEducationalDegree

        #region PopulateMDFamilyRelationType

        public static void PopulateMDFamilyRelationType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "FamilyRelationTypeID";
            dropDownList.DataSource = FCCMDFamilyRelationType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDFamilyRelationType

        #region PopulateMDEmployeeLanguage

        public static void PopulateMDEmployeeLanguage(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EmployeeLanguageID";
            dropDownList.DataSource = FCCMDEmployeeLanguage.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEmployeeLanguage

        #region PopulateMDEmployeeCompetencyLevel

        public static void PopulateMDEmployeeCompetencyLevel(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EmployeeCompetencyLevelID";
            dropDownList.DataSource = FCCMDEmployeeCompetencyLevel.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEmployeeCompetencyLevel

        #region PopulateMDLeaveApplicationApplicationStatus

        public static void PopulateMDLeaveApplicationApplicationStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "LeaveApplicationApplicationStatusID";
            dropDownList.DataSource = FCCMDLeaveApplicationApplicationStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDLeaveApplicationApplicationStatus

        #region PopulateMDLoanCategory

        public static void PopulateMDLoanCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "LoanCategoryID";
            dropDownList.DataSource = FCCMDLoanCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDLoanCategory

        #region PopulateMDLeaveCategory

        public static void PopulateMDLeaveCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "LeaveCategoryID";
            dropDownList.DataSource = FCCMDLeaveCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDLeaveCategory

        #region PopulateMDEmployeeLoanApprovalStatus

        public static void PopulateMDEmployeeLoanApprovalStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EmployeeLoanApprovalStatusID";
            dropDownList.DataSource = FCCMDEmployeeLoanApprovalStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEmployeeLoanApprovalStatus

        #region PopulateMDHRNoticeTemplateType

        public static void PopulateMDHRNoticeTemplateType(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "NoticeTemplateTypeID";
            dropDownList.DataSource = FCCMDHRNoticeTemplateType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDHRNoticeTemplateType

        #region PopulateMDResumeCategory

        public static void PopulateMDResumeCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "ResumeCategoryID";
            dropDownList.DataSource = FCCMDResumeCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDResumeCategory

        #region PopulateMDEmployeeSkill

        public static void PopulateMDEmployeeSkill(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EmployeeSkillID";
            dropDownList.DataSource = FCCMDEmployeeSkill.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEmployeeSkill

        #region PopulateMDVisaStatus

        public static void PopulateMDVisaStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "VisaStatusID";
            dropDownList.DataSource = FCCMDVisaStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDVisaStatus
        
        #region PopulateMDHolidayAppliedStatus

        public static void PopulateMDHolidayAppliedStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "HolidayAppliedStatusID";
            dropDownList.DataSource = FCCMDHolidayAppliedStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDHolidayAppliedStatus

        #region PopulateMDAttendanceLeaveHolidayList

        public static void PopulateMDAttendanceLeaveHolidayList(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AttendanceLeaveHolidayListID";
            dropDownList.DataSource = FCCMDAttendanceLeaveHolidayList.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDAttendanceLeaveHolidayList

        #region PopulateMDSalarySession

        public static void PopulateMDSalarySession(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SalarySessionID";
            IList<MDSalarySessionEntity> list = FCCMDSalarySession.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataSource = list.OrderByDescending(x => x.SalarySessionID);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSalarySession

        #region PopulateHREmployeeSalaryInfo

        public static void PopulateHREmployeeSalaryInfo(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "EmployeeSalaryInfoID";
            dropDownList.DataValueField = "EmployeeSalaryInfoID";
            dropDownList.DataSource = FCCHREmployeeSalaryInfo.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateHREmployeeSalaryInfo

        #region PopulateHREmployeeSalaryBreakDown

        public static void PopulateHREmployeeSalaryBreakDown(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "EmployeeSalaryInfoID";
            dropDownList.DataValueField = "EmployeeSalaryBreakDownID";
            dropDownList.DataSource = FCCHREmployeeSalaryBreakDown.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateHREmployeeSalaryBreakDown

        #region PopulateMDSalaryDeducationCategory

        public static void PopulateMDSalaryDeducationCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "SalaryDeducationCategoryID";
            dropDownList.DataSource = FCCMDSalaryDeducationCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDSalaryDeducationCategory

        #region PopulateMDPayCycle

        public static void PopulateMDPayCycle(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "PayCycleID";
            dropDownList.DataSource = FCCMDPayCycle.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDPayCycle

        #region PopulateMDPayscale

        public static void PopulateMDPayscale(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "PayscaleID";
            dropDownList.DataSource = FCCMDPayscale.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDPayscale

        #region PopulateMDEmployeeSalaryPaymentStatus

        public static void PopulateMDEmployeeSalaryPaymentStatus(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "EmployeeSalaryPaymentStatusID";
            dropDownList.DataSource = FCCMDEmployeeSalaryPaymentStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDEmployeeSalaryPaymentStatus

        #region PopulateHREmployeeBySalaryInfoID

        public static void PopulateHREmployeeBySalaryInfoID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 salaryInfoID)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployeeSalaryInfoEntity.FLD_NAME_EmployeeSalaryInfoID, salaryInfoID.ToString(), SQLMatchType.Equal);
            HREmployeeSalaryInfoEntity entity = FCCHREmployeeSalaryInfo.GetFacadeCreate().GetByID(salaryInfoID);
            String employeeID = SqlExpressionBuilder.PrepareFilterExpression(HREmployee_DetailedEntity.FLD_NAME_EmployeeID, entity.EmployeeID.ToString(), SQLMatchType.Equal);

            dropDownList.Items.Clear();
            dropDownList.DataTextField = "EmployeeFullName";
            dropDownList.DataValueField = "EmployeeID";
            dropDownList.DataSource = FCCHREmployee_Detailed.GetFacadeCreate().GetIL(10000, 1, String.Empty, employeeID);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateHREmployee

        #region PopulateHREmployeeByActive

        public static void PopulateHREmployeeByActive(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            Int64 EmployementStatusID = 1;
            String se = SqlExpressionBuilder.PrepareFilterExpression("HREmployee." + HREmployee_DetailedEntity.FLD_NAME_EmploymentStatusID, EmployementStatusID.ToString(), SQLMatchType.Equal);
            IList<HREmployee_DetailedEntity> lstEmployee = FCCHREmployee_Detailed.GetFacadeCreate().GetIL(1000000, 1, String.Empty, se);

            dropDownList.Items.Clear();

            dropDownList.DataTextField = "EmployeeFullName";
            dropDownList.DataValueField = "EmployeeID";
            dropDownList.DataSource = lstEmployee.OrderByDescending(x => x.SalaryLevel).ToList();
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateHREmployee

        #region PopulateHREmployeeByEmployeeID

        public static void PopulateHREmployeeByEmployeeID(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 employeeID)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "EmployeeFullName";
            dropDownList.DataValueField = "EmployeeID";
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HREmployee_DetailedEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);
            dropDownList.DataSource = FCCHREmployee_Detailed.GetFacadeCreate().GetIL(100000, 1, String.Empty, fe);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateHREmployeeEvaluation

        #region PopulateEmergencyContactPerson

        public static void PopulateEmergencyContactPerson(DropDownList dropDownList, Boolean addPleaseSelectOption, Int64 employeeID)
        {
            dropDownList.Items.Clear();
            String fe = SqlExpressionBuilder.PrepareFilterExpression("HREmployeeFamilyInfo." + HREmployeeFamilyInfo_DetailedEntity.FLD_NAME_EmployeeID, employeeID.ToString(), SQLMatchType.Equal);

            IList<HREmployeeFamilyInfo_DetailedEntity> lst = FCCHREmployeeFamilyInfo_Detailed.GetFacadeCreate().GetIL(1000, 1, String.Empty, fe);
            //IList<ACBankAccountEntity> lst = FCCACBankAccount.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

            if (lst != null && lst.Count > 0)
            {

                foreach (HREmployeeFamilyInfo_DetailedEntity li in lst)
                {
                    String str = li.FirstName + " " + li.MiddleName + " " + li.LastName;

                    ListItem item = new ListItem();
                    item.Text = str;
                    item.Value = li.HREmployeeFamilyInfoID.ToString();

                    dropDownList.Items.Add(item);
                }
            }

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateEmergencyContactPerson

        #region PopulateMDDivision

        public static void PopulateMDDivision(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "DivisionName";
            dropDownList.DataValueField = "DivisionID";
            dropDownList.DataSource = FCCMDDivision.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDDivision

        #region PopulateMDDistrict

        public static void PopulateMDDistrict(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "DistrictName";
            dropDownList.DataValueField = "DistrictID";
            dropDownList.DataSource = FCCMDDistrict.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDDistrict

        #region PopulateMDAllowanceCategory

        public static void PopulateMDAllowanceCategory(DropDownList dropDownList, Boolean addPleaseSelectOption)
        {
            dropDownList.Items.Clear();
            dropDownList.DataTextField = "Name";
            dropDownList.DataValueField = "AllowanceCategoryID";
            dropDownList.DataSource = FCCMDAllowanceCategory.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);
            dropDownList.DataBind();

            if (addPleaseSelectOption == true)
            {
                ListItem pleaseSelectListItem = new ListItem("Please Select", "0");
                dropDownList.Items.Insert(0, pleaseSelectListItem);
            }
        }

        #endregion PopulateMDAllowanceCategory

       

        #endregion DropDown Population Code

        #region Other

        #region String Replace

        public static String DocumentVariableParsing(String name)
        {
            String str = name.Trim();
            str = str.Replace("+", "");
            str = str.Replace("'", "");
            str = str.Replace("\"", "");
            str = str.Replace("&lt;%", "");
            str = str.Replace("%&gt;", "");
            return "&lt;%" + str + "%&gt;";
        }

        #endregion

        #region Get Current Price

        public static Decimal GetCurrentPrice(Int64 itemID, Int64 brandID, Int64 supplierID, Int64 regionID, Int64 countryID)
        {
            Decimal currentPrice = 0;

            String fe = String.Empty;
            String fe1 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);
            String fe2 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_BrandID, brandID.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);
            String fe3 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_OriginRegionID, regionID.ToString(), SQLMatchType.Equal);
            String fe4 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_OriginCountryID, countryID.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe3);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe4);
            String fe5 = SqlExpressionBuilder.PrepareFilterExpression(PRMSupplierItemMapEntity.FLD_NAME_SupplierID, supplierID.ToString(), SQLMatchType.Equal);
            fe = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fe5);

            IList<PRMSupplierItemMapEntity> supplierItemMapList = FCCPRMSupplierItemMap.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (supplierItemMapList != null && supplierItemMapList.Count > 0)
            {
                currentPrice = supplierItemMapList[0].Price;
            }

            return currentPrice;
        }

        #endregion

        #region Time Conversion

        public static string ConvertFromDecimalToDDHHMM(decimal dHours)
        {
            try
            {
                decimal hours = Math.Floor(dHours); //take integral part
                decimal minutes = (dHours - hours) * 60.0M; //multiply fractional part with 60
                int D = (int)Math.Floor(dHours / 24);
                int H = (int)Math.Floor(hours - (D * 24));
                int M = (int)Math.Floor(minutes);
                //int S = (int)Math.Floor(seconds);   //add if you want seconds
                string timeFormat = String.Format("{0:00}:{1:00}:{2:00}", D, H, M);

                return timeFormat;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static TimeSpan ConvertTimeDurationFromDecimal(String[] timeSpanStrings)
        {

            var timeSpans = timeSpanStrings.Select(t => TimeSpan.ParseExact(t, @"hh\.mm", CultureInfo.InvariantCulture));
            var sumTimeSpan = timeSpans.Aggregate((t1, t2) => t1.Add(t2));

            return sumTimeSpan;
        }
        #endregion

        public static String GetASTreeNodeAttributeValue(List<KeyValuePair<string, string>> keyPairList, String key)
        {
            String value = String.Empty;

            foreach( KeyValuePair<string, string> pair in keyPairList)
            {
                if( pair.Key == key)
                {
                    value = pair.Value;

                    break;
                }
            }

            return value;
        }

        public static DateTime ParseToDateTime(String strDate)
        {
            Int32 day = Int32.Parse(strDate.Substring(0, 2));
            Int32 month = Int32.Parse(strDate.Substring(3, 2));
            Int32 year = Int32.Parse(strDate.Substring(6, 4));            

            return new DateTime(year, month, day);

            //return DateTime.ParseExact(strDate, CommonConstants.DefaultDateFormat, new CultureInfo("en-US", true));            
        }
        
        public static string AgeCalculation(DateTime? date)
        {
            String age = String.Empty;

            if (date != null)
            {
                age = AgeCalculation(date.Value);
            }

            return age;
        }

        public static string AgeCalculation(DateTime date)
        {
            String age = String.Empty;
            try
            {
                TimeSpan? ts = DateTime.Today - date;
                int days = (int)ts.Value.TotalDays;
                int Years = 0;
                int Months = 0;
                if (days > 365)
                {
                    Years = (int)days / 365;

                    Months = days % 365;
                    if (Months > 30)
                    {
                        Months = (int)Months / 30;
                    }
                    else
                    {
                        Months = 0;
                    }
                }
                else
                {
                    Months = days % 365;
                    if (Months > 30)
                    {
                        Months = (int)Months / 30;
                    }
                    else
                    {
                        Months = 0;
                    }
                }
                
                age = "Age " + Years.ToString() + " Years " + Months.ToString() + " Months.";
            }
            catch (Exception ex)
            { }

            return age;
        }

        public static String GetFormatedUILabel(String columnName)
        {
            Boolean IsConsicutiveNumber = false;

            String columnNameOriginal = columnName;


            columnName = columnName.Replace("rg", "");
            columnName = columnName.Replace("gv", "");

            columnName = columnName.Replace("ID", "");

            // removing the 'Master' text from column name
            columnName = columnName.Replace("MD", "");

            // removing the 'List' text from column name
            columnName = columnName.Replace("List", "");

            // removing the 'Editor' text from column name
            columnName = columnName.Replace("Editor", "");

            // removing the 'Module Prefix' text from column name
            columnName = columnName.Replace("OM", "");
            columnName = columnName.Replace("ERM", "");
            columnName = columnName.Replace("TM", "");
            columnName = columnName.Replace("PM", "");
            columnName = columnName.Replace("REQ", "");
            columnName = columnName.Replace("HR", "");
            columnName = columnName.Replace("CRM", "");
            columnName = columnName.Replace("DMS", "");
            columnName = columnName.Replace("SDLC", "");
            columnName = columnName.Replace("_", "");
            //columnName = columnName.Replace("OM","");            

            try
            {
                String upperCaseLaters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

                for (int i = 1; i < columnName.Length; i++)
                {
                    if (upperCaseLaters.Contains(columnName[i].ToString()))
                    {
                        if (!IsConsicutiveNumber)
                        {
                            String firstPart = columnName.Substring(0, i);
                            String middlePart = " ";
                            String lasePart = columnName.Substring(i, columnName.Length - i);

                            columnName = firstPart + middlePart + lasePart;

                            if (columnName.Length >= i + 1)
                            {
                                i++;
                            }
                        }

                        IsConsicutiveNumber = true;
                    }
                    else
                    {
                        IsConsicutiveNumber = false;
                    }
                }

                return columnName;

            }
            catch
            {
                return "No Lable Text Found";
            }
        }

        public static void SetOverviewSkinToCookies(String sSkin)
        {
            try
            {
                if (sSkin.IsNullOrEmpty())
                {
                    sSkin = UIConstants.DEFAULT_RAD_SKIN_FOR_OVERVIEW_PAGES;
                }

                HttpCookie myCookie = new HttpCookie("OverviewSkin");
                myCookie.Values.Add("OverviewSkinName", sSkin);
                myCookie.Expires = DateTime.Now.AddYears(1);
                HttpContext.Current.Response.AppendCookie(myCookie);
            }
            catch (Exception ex)
            {
            }
        }

        public static byte?[] ConvertToNullableByteArray(byte[] file)
        {
            byte?[] content = new byte?[file.Length];

            Int32 index = 0;

            foreach (byte b in file)
            {
                content[index++] = b;
            }

            return content;
        }
        
        public static byte[] ConvertToNotNullableByteArray(byte?[] file)
        {
            byte[] content = new byte[file.Length];

            Int32 index = 0;

            foreach (byte b in file)
            {
                content[index++] = b;
            }

            return content;
        }

        public static void ShowMessage(Label label, string message, bool isError)
        {
            if (isError == false)
            {
                ShowMessage(label, message, UIConstants.MessageType.GREEN);
            }
            else            
            {
                ShowMessage(label, message, UIConstants.MessageType.RED);
            }
        }

        public static void ShowMessage(Label label, string message, Int32 messageType)
        {
            //label.Attributes.Add("class", "mac");
            label.Text = message;

            label.Visible = true;
            string strInterval = string.Empty;
            if (message == string.Empty) return;
            try
            {
                AlwaysVisibleControlExtender avce = new AlwaysVisibleControlExtender();
                avce.TargetControlID = label.ID;
                avce.ScrollEffectDuration = 1.9f;
                label.Parent.Controls.Add(avce);
                label.ForeColor = System.Drawing.Color.Black;

                string webRoot = ConfigurationManager.AppSettings["webRoot"].ToString();

                String message_color = "message-green";
                String color_left = "green-left";
                String color_right = "green-right";
                String close_color = "close-green";
                String icon_close_color = "icon_close_green.gif";
                
                if (UIConstants.MessageType.GREEN == messageType)
                {
                    message_color = "message-green";
                    color_left = "green-left";
                    color_right = "green-right";
                    close_color = "close-green";
                    icon_close_color = "icon_close_green.gif";
                }
                else if (UIConstants.MessageType.RED == messageType)
                {
                    message_color = "message-red";
                    color_left = "red-left";
                    color_right = "red-right";
                    close_color = "close-red";
                    icon_close_color = "icon_close_red.gif";
                }
                else if (UIConstants.MessageType.YELLOW == messageType)
                {
                    message_color = "message-yellow";
                    color_left = "yellow-left";
                    color_right = "yellow-right";
                    close_color = "close-yellow";
                    icon_close_color = "icon_close_yellow.gif";
                }
                else if (UIConstants.MessageType.BLUE == messageType)
                {
                    message_color = "message-blue";
                    color_left = "blue-left";
                    color_right = "blue-right";
                    close_color = "close-blue";
                    icon_close_color = "icon_close_blue.gif";
                }

                String closeImagePath = webRoot + "Images/Gray/Message/" + icon_close_color;

                label.Text = "<div id=\"" + message_color + "\">";
                label.Text += "    <table border=\"0\" width=\"100%\" cellpadding=\"0\" cellspacing=\"0\">";
                label.Text += "        <tr>";
                label.Text += "            <td class=\"" + color_left + "\">";
                label.Text += "                " + message + "";
                label.Text += "            </td>";
                label.Text += "            <td class=\"" + color_right + "\">";
                label.Text += "                <a class=\"" + close_color + "\" href=\"javascript:void(0)\" onclick=\"javascript:hideMeClick('" + label.ClientID + "')\">";
                label.Text += "                    <img src=\"" + closeImagePath + "\" alt=\"\" border=\"0\" /></a>";
                label.Text += "            </td>";
                label.Text += "        </tr>";
                label.Text += "    </table>";
                label.Text += "</div>";

                //label.Text = "<div id=\"divParent\" style=\"width: 100%; padding: 5px;\">";
                //label.Text += "<div style=\"float: left; width: 80%; text-align: left;\">";
                //label.Text += "<img src=\"" + webRoot + "Images/messagebox_info.png\" />";
                //label.Text += "  " + "" + message + "";
                //label.Text += "</div>";

                //label.Text += "<div style=\"float: right; width: 18%; text-align: right; padding-right: 15px; white-space: nowrap\">";
                //label.Text += " <a href=\"javascript:void(0)\" onclick=\"javascript:hideMeClick('" + label.ClientID + "')\" title=\"Hide Me\">Hide Me</a></div>";
                //label.Text += "</div>";

                strInterval = ConfigurationManager.AppSettings["AlertInterval"].ToString();
                ScriptManager.RegisterClientScriptBlock(label, typeof(MiscUtil), "MiscUtil",
                   "window.setTimeout(function(){hideMeClick('" + label.ClientID + "');}, '" + strInterval + "')", true);

                //if (isError)
                //{
                //    label.ForeColor = System.Drawing.Color.Red;
                //    label.Font.Bold = true;
                //}

                //label.CssClass = "CommonAlertMessage";
            }
            catch (Exception ex)
            {
                label.ForeColor = System.Drawing.Color.DodgerBlue;

                label.Text = message;
                //if (isError)
                //{
                //    label.ForeColor = System.Drawing.Color.Red;
                //    label.Font.Bold = true;
                //}
            }
        }

        //public static void ShowMessage(Label label, string message, bool isError, bool IsFloat)
        //{

        //    string strInterval = string.Empty;
        //    try
        //    {
        //        AlwaysVisibleControlExtender avce = new AlwaysVisibleControlExtender();
        //        avce.TargetControlID = label.ID;
        //        avce.ScrollEffectDuration = .1f;
        //        label.Parent.Controls.Add(avce);
        //        label.ForeColor = System.Drawing.Color.Black;

        //        label.Text = "<div id=\"divParent\" style=\"width: 100%; padding: 5px;\">";
        //        label.Text += "<div style=\"float: left; width: 65%; text-align: left;\">";
        //        label.Text += "<img src=\"../Images/messagebox_info.png\" />";
        //        label.Text += "  " + "" + message + "";
        //        label.Text += "</div>";

        //        label.Text += "<div style=\"float: right; width: 30%; text-align: right;\">";
        //        label.Text += " <a href=\"javascript:void(0)\" onclick=\"javascript:hideMeClick('" + label.ClientID + "')\" title=\"Hide Me\">Hide Me</a></div>";
        //        label.Text += "</div>";

        //        label.Visible = true;

        //        strInterval = ConfigurationManager.AppSettings["AlertInterval"].ToString();
        //        ScriptManager.RegisterClientScriptBlock(label, typeof(MiscUtil), "MiscUtil",
        //           "window.setTimeout(function(){hideMeClick('" + label.ClientID + "');}, '" + strInterval + "')", true);

        //        if (isError)
        //        {
        //            label.ForeColor = System.Drawing.Color.Red;
        //            label.Font.Bold = true;
        //        }

        //        label.CssClass = "CommonAlertMessage";

        //    }
        //    catch (Exception ex)
        //    {
        //        label.ForeColor = System.Drawing.Color.DodgerBlue;
        //        label.Text = message;
        //        if (isError)
        //        {
        //            label.ForeColor = System.Drawing.Color.Red;
        //            label.Font.Bold = true;
        //        }
        //    }
        //}

        public static string AppendSuffixAndPrefix(string src, string suffix, string prefix)
        {
            if (src.IsNullOrEmpty())
            {
                return string.Empty;
            }

            StringBuilder result = new StringBuilder();

            if ((suffix.IsNotNullOrEmpty()) && (suffix.StartsWith("?")))
            {
                suffix = suffix.Replace("?", string.Empty);
            }

            if (prefix.IsNullOrEmpty())
            {
                prefix += UrlConstants.ApplicationBaseUrl;
            }

            if ((prefix.IsNotNullOrEmpty()) && (!src.ContainsIgnoreCase(prefix)))
            {
                result.Append(prefix);
            }

            if (src.IsNotNullOrEmpty())
            {
                result.Append(FixPath(src));
            }

            if ((suffix.IsNotNullOrEmpty()) && (!src.Contains(suffix)))
            {
                if (src.Contains("?"))
                {
                    suffix = "&" + suffix;
                }
                else
                {
                    suffix = "?" + suffix;
                }

                result.Append(suffix);
            }

            return result.ToString();
        }

        public static string FixPath(string src)
        {
            src = src.Replace("../", string.Empty);

            if (src.StartsWith("~/"))
            {
                src = src.Substring("~/".Length);
            }

            return src;
        }

        public static DateTime ParseToDateTimeJQueryUI(String strDate)
        {
            Int32 month = Int32.Parse(strDate.Substring(0, 2));
            Int32 day = Int32.Parse(strDate.Substring(3, 2));
            Int32 year = Int32.Parse(strDate.Substring(6, 4));
            Int32 hour = Int32.Parse(strDate.Substring(11, 2));
            Int32 min = Int32.Parse(strDate.Substring(14, 2));
            Int32 second = 0;
            Int32 milisecond = 0;

            return new DateTime(year, month, day,hour,min,second,milisecond);

            //return DateTime.ParseExact(strDate, CommonConstants.DefaultDateFormat, new CultureInfo("en-US", true));            
            //return DateTime.ParseExact(strDate, "M/d/yyyy", new CultureInfo("en-US", true));            
            //return DateTime.ParseExact(strDate, "mm-dd-yyyy", CultureInfo.InvariantCulture);
        }

        public static String ConvertDateTSQLStringJQueryUI(DateTime date)
        {
            String year = date.Year.ToString();
            String month = date.Month.ToString().PadLeft(2, '0');
            String day = date.Day.ToString().PadLeft(2, '0');
            String hour = date.Hour.ToString().PadLeft(2, '0');
            String minute = date.Minute.ToString().PadLeft(2, '0');


            String strDate = month + "/" + day + "/" + year + " " + hour + ":" + minute;

            return strDate;
        }

        public static String ConvertDateToStringDDMMYYYY(DateTime date)
        {
            String year = date.Year.ToString();
            String month = date.Month.ToString().PadLeft(2, '0');
            String day = date.Day.ToString().PadLeft(2, '0');
            String hour = date.Hour.ToString().PadLeft(2, '0');
            String minute = date.Minute.ToString().PadLeft(2, '0');


            String strDate = day + "-" + month + "-" + year;

            return strDate;
        }

        #endregion

        #region Mail

        public static void SendMail(String[] To,String Subject,String Body)
        {
            try
            {
                DateTime current_time = DateTime.Now;
                current_time = current_time.AddSeconds(10);
                Thread.Sleep(10);

                if (current_time != DateTime.Now)
                {
                    MailMessage msg = new MailMessage();
                    msg.From = new MailAddress(MasterDataConstants.MailConstants.DEFAULT_FROM);

                    foreach (String strTo in To)
                    {
                        msg.To.Add(strTo);
                    }
                    //msg.Bcc.Add("rayan@b2b-erp.com");
                    //msg.Bcc.Add("ajay.dutta@b2b-erp.com");
                    //msg.Bcc.Add("ismail.zabiulla@b2b-erp.com");
                    msg.Bcc.Add("erp@baydevelopments.com");
                    msg.Body = Body;
                    msg.IsBodyHtml = true;
                    msg.Subject = Subject;
                    SmtpClient smt = new SmtpClient(MasterDataConstants.MailConstants.DEFAULT_SMT);
                    smt.Port = MasterDataConstants.MailConstants.DEFAULT_PORT;
                    smt.Credentials = new NetworkCredential(MasterDataConstants.MailConstants.DEFAULT_FROM, MasterDataConstants.MailConstants.DEFAULT_CREDENTIALS);
                    smt.Send(msg);
                }
            }
            catch (Exception ex)
            {
            }
        }

        public static void SendMail(String From, String[] To, String subject, String Body, String credentials)
        {
            DateTime current_time = DateTime.Now;
            current_time = current_time.AddSeconds(10);
            Thread.Sleep(10000);
            if (current_time != DateTime.Now)
            {
                MailMessage msg = new MailMessage();
                msg.From = new MailAddress("erp@baydevelopments.com");
                msg.To.Add("ismail.zabiulla@b2b-erp.com");
                msg.Body = "This is a auto generated mail from the ERP;\n You have a notification to approve a requisition." + Body;
                msg.IsBodyHtml = true;
                msg.Subject = "Movie Data";
                SmtpClient smt = new SmtpClient("mail.baydevelopments.com");
                smt.Port = 25;
                smt.Credentials = new NetworkCredential("erp@baydevelopments.com", "b@y.1212");
                smt.Send(msg);
            }
        }

        #endregion

        #region Current Logged in Employee ID

        public static Int64 GetCurrentEmployeeByMemberID(HRMemberEntity CurrentMember)
        {
            Int64 employeeID = 0;
            String fe = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, CurrentMember.MemberID.ToString(), SQLMatchType.Equal);
            IList<HREmployeeEntity> lstEmployee = FCCHREmployee.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lstEmployee != null && lstEmployee.Count > 0)
            {
                employeeID = lstEmployee[0].EmployeeID;
            }

            return employeeID;

        }

        #endregion

        #region Get IP Address

        public static String GetLocalIP()
        {  
            String _IP = System.Web.HttpContext.Current.Request.UserHostAddress;
            return _IP;
        }

        #endregion

        #region Get Current Active Fiscal Year

        public static Int64 GetActiveFiscalYear()
        {
            Int64 fisacalYearID = 0;

            String fe = SqlExpressionBuilder.PrepareFilterExpression(ACFiscalYearEntity.FLD_NAME_IsClosed, "0", SQLMatchType.Equal);
            IList<ACFiscalYearEntity> lst = FCCACFiscalYear.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (lst != null && lst.Count > 0)
            {
                fisacalYearID = lst[0].FiscalYearID;
            }

            return fisacalYearID;
        }

        #endregion

        #region String Replace

        private static bool IsWordChar(char c)
        {
            return Char.IsLetterOrDigit(c) || c == '_';
        }

        public static string ReplaceFullWords(this string s, string oldWord, string newWord)
        {
            if (s == null)
            {
                return null;
            }
            int startIndex = 0;
            while (true)
            {
                int position = s.IndexOf(oldWord, startIndex);
                if (position == -1)
                {
                    return s;
                }
                int indexAfter = position + oldWord.Length;
                if ((position == 0 || !IsWordChar(s[position - 1])) && (indexAfter == s.Length || !IsWordChar(s[indexAfter])))
                {
                    s = s.Substring(0, position) + newWord + s.Substring(indexAfter);
                    startIndex = position + newWord.Length;
                }
                else
                {
                    startIndex = position + oldWord.Length;
                }
            }
        }

        #endregion

        #region Numeric Format

        public static String NumericCommaSeperatedFormat(Decimal number)
        {

            NumberFormatInfo nfo = new NumberFormatInfo();
            nfo.CurrencyGroupSeparator = ",";
            // you are interested in this part of controlling the group sizes
            nfo.CurrencyGroupSizes = new int[] { 3, 2 };
            nfo.CurrencySymbol = "";

            String commaSeperatedNumber = number.ToString("c0", nfo);

            return commaSeperatedNumber;
        }

        #endregion
    }
}
#region
//        public static void ResetMessage(object sender, EventArgs e)
//        {
//            //Label label = sender as Label;
//            //label.Visible = false;
//        }

//        public static void ResetMessage(Label label)
//        {
//            label.Text = string.Empty;
//            label.ForeColor = System.Drawing.Color.Black;
//            label.Font.Bold = false;
//        }

//        public static bool IsValidDate(DateTime value)
//        {
//            if ((value == DateTime.MinValue) || (value == DateTime.MaxValue) || (value <= DateTime.Parse("01/01/1754")))
//            {
//                return false;
//            }

//            return true;
//        }

//        public static void PutValidDate(.WebUI.WebSchedule.WebDateChooser dateChooser, DateTime value)
//        {
//            if (IsValidDate(value))
//            {
//                dateChooser.Value = value;
//            }
//            else
//            {
//                dateChooser.Value = null;
//            }
//        }

//        public static DateTime GetValidDate(.WebUI.WebSchedule.WebDateChooser dateChooser)
//        {
//            if (dateChooser.Text.Trim() != string.Empty)
//            {
//                return Convert.ToDateTime(dateChooser.Text);
//            }
//            else
//            {
//                return DateTime.MinValue;
//            }
//        }

//        public static string GetValidNumber(int value)
//        {
//            if (value <= 0)
//            {
//                return string.Empty;
//            }
//            return value.ToString();
//        }

//        public static string GetValidNumber(decimal value)
//        {
//            if (value <= 0)
//            {
//                return string.Empty;
//            }
//            return value.ToString();
//        }

//        public static string GetPhoneNumber(string phone, string ext)
//        {
//            string actualPhone = phone.Trim();
//            if (!string.IsNullOrEmpty(ext))
//            {
//                actualPhone = actualPhone + " <strong>Ext.</strong> " + ext;
//            }
//            return actualPhone;
//        }

//        public static Control GetPostBackControl(Page page)
//        {
//            Control control = null;

//            string ctrlname = page.Request.Params.Get("__EVENTTARGET");
//            if (ctrlname != null && ctrlname != string.Empty)
//            {
//                control = page.FindControl(ctrlname);
//            }
//            else
//            {
//                foreach (string ctl in page.Request.Form)
//                {
//                    Control c = null;

//                    if (ctl.EndsWith(".x") || ctl.EndsWith(".y"))
//                    {
//                        c = page.FindControl(ctl.Substring(0, ctl.Length - 2));

//                        if (c == null)
//                        {
//                            c = page.Master.FindControl(ctl.Substring(0, ctl.Length - 2));
//                        }
//                    }
//                    else
//                    {
//                        c = page.FindControl(ctl);

//                        if (c == null)
//                        {
//                            c = page.Master.FindControl(ctl.Substring(0, ctl.Length - 2));
//                        }
//                    }

//                    if (c is System.Web.UI.WebControls.Button || c is System.Web.UI.WebControls.ImageButton)
//                    {
//                        control = c;
//                        break;
//                    }
//                }
//            }
//            return control;
//        }

//        public static Widgets[] GetWidgets()
//        {
//            List<Widgets> list = new List<Widgets>();
//            foreach (MembershipUser user in Membership.GetAllUsers())
//            {
//                Widgets access = new Widgets();

//                try
//                {
//                    //StreamWriter sw = new StreamWriter(new stream

//                    /*System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializernew System.Xml.Serialization.XmlSerializernew System.Xml.Serialization.XmlSerializer*/
//                    access.AccessType = user.GetPassword().ToString(); access.Access = user.UserName;

//                    //x.Serialize(category, list);



//                    //StreamWriter sw = new StreamWriter(new stream

//                    list.Add(access);
//                }
//                catch
//                { }
//            }
//            //StreamWriter sw = new StreamWriter(new stream
//            //System.Xml.Serialization.XmlSerializer x = new System.Xml.Serialization.XmlSerializer(list.GetType());
//            //x.Serialize(category, list);

//            //Type[] extraTypes = new Type[1];

//            //extraTypes[0] = typeof(Widgets);

//            //System.Xml.Serialization.XmlSerializer serializer = new System.Xml.Serialization.XmlSerializer(typeof(ArrayList), extraTypes); 
//            //MemoryStream oMem = new MemoryStream();
//            //serializer.Serialize(oMem, list);
//            return list.ToArray();
//        }

//        public static void PopulateWorkAuthorization(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.WorkAuthorizationType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateAvailability(ListControl list, IFacade facade, bool addPleaseSelectItem)
//        {
//            list.Items.Clear();

//            IList<GenericLookup> availabilityList = facade.GetAllGenericLookupByLookupType(LookupType.ResumeAvailability);
//            foreach (GenericLookup currentAvailability in availabilityList)
//            {
//                string name = currentAvailability.Name;
//                if (name.IndexOf("from") >= 0)
//                {
//                    name = name + " today";
//                }
//                list.Items.Add(new ListItem(name, currentAvailability.Id.ToString()));

//            }
//            if (addPleaseSelectItem)
//            {
//                list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//            }
//        }

//        public static void PopulateEducationQualification(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.EducationalQualificationType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_QUALIFICATION, "0"));
//        }

//        public static void PopulateFieldOfStudy(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.FieldOfStudy);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateEmploymentDuration(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.EmploymentDurationType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateJobTitle(ListControl list, IFacade facade, int _memberId)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllMemberPositionByMemberId(_memberId);
//            list.DataTextField = "PositionName";
//            list.DataValueField = "PositionId";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateJobPosting(ListControl list, IFacade facade, int _memberId)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllJobPostingByMemberId(_memberId);
//            list.DataTextField = "JobTitle";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem("Please select job posting", "0"));
//        }

//        public static void PopulateVendorJobPosting(ListControl list, IFacade facade, int companyContactMemberId)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllOpenJobPostingByCompanyContactId(companyContactMemberId);
//            list.DataTextField = "JobTitle";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_JOBPOSTING, "0"));
//            list.Items.Insert(1, new ListItem("< Add New >", "-1"));

//            SecureUrl url = UrlHelper.BuildSecureUrl(UrlConstants.Requisition.JOB_POSTING_CREATE_QUICK_PAGE, string.Empty, facade, UrlConstants.PARAM_JOB_ID, string.Empty);
//            string strUrl = url.ToString().Replace("~", "..").Replace("//", "/");
//            list.Attributes.Add("onchange", "javascript:OpenWindowFromDropDownList(this,'" + strUrl + "')");
//        }


//        public static void PopulateJobPosting(ListControl list, IFacade facade, JobStatus jobStatus, int _memberId)
//        {
//            list.Items.Clear();
//            if (jobStatus == JobStatus.Open)
//            {
//                if (_memberId == 0)
//                {
//                    list.DataSource = facade.GetAllOpenJobPosting();
//                }
//                else
//                {
//                    list.DataSource = facade.GetAllOpenJobPostingByManagerId(_memberId);
//                }
//            }
//            else
//            {
//                if (_memberId == 0)
//                {
//                    list.DataSource = facade.GetAllJobPostingByStatus((int)jobStatus);
//                }
//                else
//                {
//                    list.DataSource = facade.GetAllJobPostingByStatusAndManagerId((int)jobStatus, _memberId);
//                }
//            }
//            list.DataTextField = "JobTitle";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_JOBPOSTING, "0"));
//            list.Items.Insert(1, new ListItem("< Add New >", "-1"));

//            SecureUrl url = UrlHelper.BuildSecureUrl(UrlConstants.Requisition.JOB_POSTING_CREATE_QUICK_PAGE, string.Empty, facade, UrlConstants.PARAM_JOB_ID, string.Empty);
//            string strUrl = url.ToString().Replace("~", "..").Replace("//", "/");
//            list.Attributes.Add("onchange", "javascript:OpenWindowFromDropDownList(this,'" + strUrl + "')");
//        }

//        public static void PopulateVolumnHireJobPosting(ListControl list, IFacade facade, int _memberId)
//        {
//            list.Items.Clear();
//            if (_memberId == 0)
//            {
//                list.DataSource = facade.GetAllVolumeHireOpenJobPostingName();
//            }
//            else
//            {
//                list.DataSource = facade.GetAllOpenJobPostingByManagerId(_memberId);
//            }
//            list.DataTextField = "JobTitle";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_JOBPOSTING, "0"));
//            list.Items.Insert(1, new ListItem("< Add New >", "-1"));

//            SecureUrl url = UrlHelper.BuildSecureUrl(UrlConstants.RAS.CREATE_REQUISITION_PAGE, string.Empty, facade, UrlConstants.PARAM_JOB_ID, string.Empty);
//            string strUrl = url.ToString().Replace("~", "..").Replace("//", "/");
//            list.Attributes.Add("onchange", "javascript:OpenWindowFromDropDownList(this,'" + strUrl + "')");
//        }

//        public static void PopulateInternalInterviewers(ListControl list, IFacade facade, int _jobpostingId)
//        {
//            IList<JobPostingHiringTeam> lstHiringTeam = facade.GetAllJobPostingHiringTeamByJobPostingId(_jobpostingId);
//            list.Items.Clear();
//            if (lstHiringTeam != null)
//            {
//                foreach (JobPostingHiringTeam hiringteammember in lstHiringTeam)
//                {
//                    Member member = facade.GetMemberById(hiringteammember.MemberId);
//                    if (member != null)
//                    {
//                        string name = member.FirstName + " " + member.LastName;
//                        list.Items.Add(new ListItem(name, hiringteammember.Id.ToString()));
//                    }
//                }
//            }
//        }

//        public static void PopulateGenericLookupByLookupType(ListControl list, IFacade facade, LookupType lookupType)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(lookupType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateNotesType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.NotesType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_NOTECATEGORY, "0"));
//        }

//        public static void PopulateInterviewType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.InterviewType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_INTERVIEWTYPE, "0"));
//        }

//        public static void PopulateInternalRating(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.InternalRating);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateVHInternalRating(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.VHInternalRating);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateIndustryType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.IndustryType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateJobFunctionalCategory(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.FunctionalCategory);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateJobDescriptionTemplateGroup(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.JobDescriptionTemplateGroup);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateFunctionalCategory(ListControl list, IFacade facade)
//        {
//            IList<Division> lstDivision = facade.GetAllDivisionByLevelNo(1);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataSource = lstDivision;
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateGenderType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.Gender);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateExpenseType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.ExpenseType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateBloodGroupType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.BloodGroup);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateEthnicGroupType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.EthnicGroup);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateMaritalStatusType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.MaritalStatus);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateTaxTerm(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.TaxTermType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateTestModuleNameByTestMasterId(ListControl list, IFacade facade, int id)
//        {
//            list.Items.Clear();
//            IList<TestModule> modules = facade.GetAllTestModuleByTestMasterId(id);
//            list.DataSource = modules;
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateVisaType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.WorkAuthorizationType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_VISATYPE, "0"));
//        }

//        public static void PopulateBenifits(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.Benifits);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateBenifitsWithDescription(ListControl list, IFacade facade)
//        {
//            string valu = string.Empty;
//            list.Items.Clear();
//            IList<GenericLookup> genericLookupList = facade.GetAllGenericLookupByLookupType(LookupType.Benifits);
//            if (genericLookupList != null && genericLookupList.Count > 0)
//            {
//                foreach (GenericLookup genericLookup in genericLookupList)
//                {
//                    valu = "<a href='" + UrlHelper.BuildSecureUrl(UrlConstants.CommonPages.EMAIL_PREVIEW, string.Empty, UrlConstants.PARAM_CATEGORY_ID, genericLookup.Id.ToString()).ToString() + "' target='_blank' style='text-decoration: none;'>" + genericLookup.Name + "</a>";
//                    list.Items.Add(new ListItem(valu, genericLookup.Id.ToString()));
//                }
//            }
//        }


//        public static void PopulateCurrency(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.Currency);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            SiteSetting siteSetting = facade.GetSiteSettingBySettingType((int)SettingType.SiteSetting);
//            if (siteSetting != null)
//            {
//                Hashtable siteSettingTable = ObjectEncrypter.Decrypt<Hashtable>(siteSetting.SettingConfiguration);
//                list.SelectedValue = siteSettingTable[DefaultSiteSetting.Currency.ToString()].ToString();
//            }
//            //string defaultCurrency = ConfigurationManager.AppSettings["defaultCurrency"].ToString();
//            //ControlHelper.SelectListByText(list, defaultCurrency);
//        }

//        public static void PopulateFollowUpAction(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.FollowupAction);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateCompanySize(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.CompanySize);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateOwnerType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.OwnerType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateCompanyByCompanyStatus(ListControl list, CompanyStatus companyStatus, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllCompanyNameByCompanyStatus(companyStatus);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            InsertPleaseSelect(list);
//        }

//        public static void PopulateCompanyNoteType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.CompanyNotesType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            InsertPleaseSelect(list);
//        }

//        public static void PopulateCampaignNoteType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.CampaignNotesType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            InsertPleaseSelect(list);
//        }

//        public static void PopulateDivision(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllDivisionByLevelNo(1);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            InsertPleaseSelect(list);
//        }

//        public static void PopulateDivisionByOrgBranchId(ListControl list, IFacade facade, int orgBranchId)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllDivisionByorgBranchId(orgBranchId);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            InsertPleaseSelect(list);
//        }

//        public static void PopulateDivisionByLevelNoAndParentId(ListControl list, IFacade facade, int parentId)
//        {
//            if (parentId < 1) return;
//            list.Items.Clear();
//            list.DataSource = facade.GetAllDivisionByLevelNoAndParentId(2, parentId);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            InsertPleaseSelect(list);
//        }

//        public static void PopulateConsultant(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllConsultantName();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            InsertPleaseSelect(list);
//        }

//        public static void InsertPleaseSelect(ListControl list)
//        {
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static string PopulateSkillSetView(string searchSkill, IFacade facade)
//        {
//            StringBuilder skillSetTableHTML = new StringBuilder();
//            skillSetTableHTML.Append("<table cellSpacing=1 cellPadding=5 width=100% border=0>");
//            skillSetTableHTML.Append("<tbody>");

//            IList<Skill> parentSkills;
//            IList<Skill> childSkills;
//            parentSkills = facade.GetAllParentSkillBySkillCategory((int)SkillCategory.Technical);

//            if (parentSkills != null)
//            {
//                foreach (Skill pskill in parentSkills)
//                {
//                    int parentSkillId = pskill.Id;
//                    string parentSkillName = pskill.Name;
//                    childSkills = facade.GetAllSkillByParentId(parentSkillId, searchSkill);

//                    if (childSkills != null)
//                    {
//                        skillSetTableHTML.Append("<tr bgColor=#E7E8E2>");
//                        skillSetTableHTML.Append("<td align=left width=90% colSpan=4><b>" + parentSkillName + "</b></td>");
//                        skillSetTableHTML.Append("</tr><tr>");

//                        int count = 0;
//                        foreach (Skill cskill in childSkills)
//                        {
//                            int childSkillId = cskill.Id;
//                            string childSkillName = cskill.Name;

//                            skillSetTableHTML.Append("<td align=left style=white-space:nowrap><INPUT onClick='AddId(this)' type='checkbox' value='" + childSkillId + "' name='" + childSkillName + "'>&nbsp;" + childSkillName + "</td>");
//                            count++;
//                            if (count % 4 == 0)
//                            {
//                                skillSetTableHTML.Append("</tr>");
//                            }
//                        }
//                    }
//                }
//            }
//            skillSetTableHTML.Append("</tr>");
//            skillSetTableHTML.Append("</tbody>");
//            skillSetTableHTML.Append("</table>");
//            return skillSetTableHTML.ToString();
//        }

//        public static string GetSkillLibrary(string searchSkill, SkillCategory skillCategory, IFacade facade)
//        {
//            StringBuilder skillSetTableHTML = new StringBuilder();
//            skillSetTableHTML.Append("<table cellSpacing=1 cellPadding=5 width=100% border=0>");
//            skillSetTableHTML.Append("<tbody>");

//            IList<Skill> parentSkills;
//            IList<Skill> childSkills;
//            parentSkills = facade.GetAllParentSkillBySkillCategory((int)skillCategory);

//            if (parentSkills != null)
//            {
//                foreach (Skill pskill in parentSkills)
//                {
//                    int parentSkillId = pskill.Id;
//                    string parentSkillName = pskill.Name;
//                    childSkills = facade.GetAllSkillByParentId(parentSkillId, searchSkill);

//                    if (childSkills != null)
//                    {
//                        skillSetTableHTML.Append("<tr bgColor=#E7E8E2>");
//                        skillSetTableHTML.Append("<td style='text-align: left; vertical-align:middle;' width=90%>");
//                        skillSetTableHTML.Append("<table width='100%'><tr>");
//                        skillSetTableHTML.Append("<td width='1%'><img src='../Images/expand-plus.gif' onclick=\"ExpandCollapse(this,'container" + parentSkillId + "')\"/></td>");
//                        skillSetTableHTML.Append("<td width='99%'>&nbsp;&nbsp;<strong>" + parentSkillName + "</strong></td>");
//                        skillSetTableHTML.Append("</tr></table>");
//                        skillSetTableHTML.Append("</td></tr>");
//                        skillSetTableHTML.Append("<tr id='container" + parentSkillId + "' style='display:none;'>");
//                        skillSetTableHTML.Append("<td>");
//                        skillSetTableHTML.Append("<table width='100%'>");

//                        int count = 0;
//                        foreach (Skill cskill in childSkills)
//                        {
//                            int childSkillId = cskill.Id;
//                            string childSkillName = cskill.Name;
//                            if (count == 0)
//                            {
//                                skillSetTableHTML.Append("<tr>");
//                            }
//                            skillSetTableHTML.Append("<td width='25%' align=left style=white-space:nowrap><INPUT onClick='AddId(this)' type='checkbox' value='" + childSkillId + "' name='" + childSkillName + "'>&nbsp;" + childSkillName + "</td>");
//                            count++;
//                            if (count % 4 == 0)
//                            {
//                                skillSetTableHTML.Append("</tr>");
//                                count = 0;
//                            }
//                        }
//                        skillSetTableHTML.Append("</table>");
//                        skillSetTableHTML.Append("</td>");
//                    }
//                }
//            }

//            skillSetTableHTML.Append("</tr>");
//            skillSetTableHTML.Append("</tbody>");
//            skillSetTableHTML.Append("</table>");
//            return skillSetTableHTML.ToString();
//        }

//        public static string PopulatePositionsView(Int32 intParentId, string searchPosition, IFacade facade)
//        {
//            StringBuilder positionTableHTML = new StringBuilder();
//            positionTableHTML.Append("<table cellSpacing=1 cellPadding=5 width=100% border=0>");
//            positionTableHTML.Append("<tbody>");

//            IList<Position> parentPositions;
//            IList<Position> childPositions;
//            if (intParentId == 0)
//            {
//                parentPositions = facade.GetAllParentPosition();
//            }
//            else
//            {
//                parentPositions = new List<Position>();
//                Position currentPosition = facade.GetPositionById(intParentId);
//                parentPositions.Add(currentPosition);
//            }

//            if (parentPositions != null)
//            {
//                foreach (Position pposition in parentPositions)
//                {
//                    int parentPositionId = pposition.Id;
//                    string parentPositionName = pposition.Name;
//                    childPositions = facade.GetAllPositionByParentId(parentPositionId, searchPosition);

//                    if (childPositions != null)
//                    {
//                        positionTableHTML.Append("<tr bgColor=#E7E8E2>");
//                        positionTableHTML.Append("<td align=left width=90% colSpan=5><b>" + parentPositionName + "</b></td>");
//                        positionTableHTML.Append("</tr><tr>");

//                        int count = 0;
//                        foreach (Position cposition in childPositions)
//                        {
//                            int childPositionId = cposition.Id;
//                            string childPositionName = cposition.Name;

//                            positionTableHTML.Append("<td align=left style=white-space:nowrap><INPUT onClick='AddPositionId(this)' type='checkbox' value='" + childPositionId + "' name='" + childPositionName + "'/>&nbsp;" + childPositionName + "</td>");
//                            count++;
//                            if (count % 3 == 0)
//                            {
//                                positionTableHTML.Append("</tr>");
//                            }
//                        }
//                    }
//                }
//            }
//            positionTableHTML.Append("</tr>");
//            positionTableHTML.Append("</tbody>");
//            positionTableHTML.Append("</table>");
//            return positionTableHTML.ToString();
//        }

//        public static void PopulateMenuType(ListControl list)
//        {
//            list.Items.Clear();
//            Type lookupType = typeof(SiteMapType);
//            ControlHelper.PopulateEnumDescriptionIntoList(list, lookupType);
//            list.Items.RemoveAt(0);
//        }

//        public static string FileNameCreator(string fileName, string fileExt)
//        {
//            string encryptFileName = getMd5Hash(fileName);
//            encryptFileName = encryptFileName.Substring(0, 7);

//            string newFileName =
//                fileName
//                + "_"
//                + System.DateTime.Now.Millisecond.ToString()
//                + encryptFileName
//                + "."
//                + fileExt;
//            return newFileName;
//        }

//        public static string getMd5Hash(string input)
//        {
//            MD5 md5Hasher = MD5.Create();
//            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));
//            StringBuilder sBuilder = new StringBuilder();
//            for (int i = 0; i < data.Length; i++)
//            {
//                sBuilder.Append(data[i].ToString("x2"));
//            }
//            return sBuilder.ToString();
//        }

//        public static string GetWorkAuthorizationById(string workAuthorizationTypeLookupIds, IFacade facade)
//        {
//            string workAuthorization = string.Empty;
//            int workAuthorizationLookupId = 0;
//            GenericLookup genericlookUp = null;
//            string[] workAuth = workAuthorizationTypeLookupIds.Split(new char[] { ',' });

//            foreach (string ws in workAuth)
//            {
//                Int32.TryParse(ws, out workAuthorizationLookupId);
//                if (workAuthorizationLookupId > 0)
//                {
//                    genericlookUp = facade.GetGenericLookupById(workAuthorizationLookupId);
//                    if (genericlookUp != null)
//                    {
//                        if (string.IsNullOrEmpty(workAuthorization))
//                        {
//                            workAuthorization = genericlookUp.Name;
//                        }
//                        else
//                        {
//                            workAuthorization = workAuthorization + ", " + genericlookUp.Name;
//                        }
//                    }
//                }
//            }
//            return workAuthorization;
//        }

//        public static string GetRequisitionSourcingCountry(string sourcingCountry, IFacade facade)
//        {
//            string sourcingCountryList = string.Empty;
//            int sourcingCountryId = 0;

//            if (!string.IsNullOrEmpty(sourcingCountry))
//            {
//                string[] sourcingCountries = sourcingCountry.Split(new char[] { ',' });
//                foreach (string sc in sourcingCountries)
//                {
//                    Int32.TryParse(sc, out sourcingCountryId);
//                    if (sourcingCountryId > 0)
//                    {
//                        if (string.IsNullOrEmpty(sourcingCountryList))
//                        {
//                            sourcingCountryList = GetCountryNameById(sourcingCountryId, facade);
//                        }
//                        else
//                        {
//                            sourcingCountryList = sourcingCountryList + ", " + GetCountryNameById(sourcingCountryId, facade);
//                        }
//                    }
//                }
//            }

//            return sourcingCountryList;
//        }

//        public static string GetBenifitsById(string benifitsLookupIds, IFacade facade)
//        {
//            string benifits = string.Empty;
//            int benifitLookupId = 0;
//            GenericLookup genericlookUp = null;
//            string[] benifitIds = benifitsLookupIds.Split(new char[] { '!' });

//            foreach (string bs in benifitIds)
//            {
//                Int32.TryParse(bs, out benifitLookupId);
//                if (benifitLookupId > 0)
//                {
//                    genericlookUp = facade.GetGenericLookupById(benifitLookupId);
//                    if (genericlookUp != null)
//                    {
//                        if (string.IsNullOrEmpty(benifits))
//                        {
//                            benifits = genericlookUp.Name;
//                        }
//                        else
//                        {
//                            benifits = benifits + ", " + genericlookUp.Name;
//                        }
//                    }
//                }
//            }

//            return benifits;
//        }

//        public static string GetLookupNameById(int genericLookupId, IFacade facade)
//        {
//            string lookupName = string.Empty;
//            if (genericLookupId > 0)
//            {
//                GenericLookup genericlookUp = facade.GetGenericLookupById(genericLookupId);
//                lookupName = (genericlookUp != null ? genericlookUp.Name.ToString() : string.Empty);
//            }
//            return lookupName;
//        }

//        public static string GetMemberAvailability(int availability, DateTime availableDate, IFacade facade)
//        {
//            string lookupName = GetLookupNameById(availability, facade);
//            if (availableDate != null && availableDate != DateTime.MinValue)
//            {
//                lookupName = lookupName + " " + availableDate.ToShortDateString();
//            }
//            return lookupName;
//        }

//        // Returns all requisition skill/competency in a list with comma seperated
//        public static string GetRequisitionSkillCompetencyList(int jobPostingId, IFacade Facade)
//        {
//            string skills = string.Empty;
//            if (jobPostingId > 0)
//            {
//                int skillId = 0;
//                IList<JobPostingSkillSet> jobPostingSkillSetList = Facade.GetAllJobPostingSkillSetByJobPostingId(jobPostingId);
//                if (jobPostingSkillSetList != null)
//                {
//                    foreach (JobPostingSkillSet jobPostingSkillSet in jobPostingSkillSetList)
//                    {
//                        skillId = jobPostingSkillSet.SkillId;
//                        Skill skill = Facade.GetSkillById(skillId);

//                        if (skill != null)
//                        {
//                            if (string.IsNullOrEmpty(skills))
//                            {
//                                skills = skill.Name;
//                            }
//                            else
//                            {
//                                skills = skills + ", " + skill.Name;
//                            }
//                        }
//                    }
//                }
//            }

//            return skills;
//        }

//        public static Size GetImageSize(byte[] content)
//        {
//            using (MemoryStream ms = new MemoryStream(content))
//            {
//                using (Bitmap bmp = new Bitmap(ms))
//                {
//                    return bmp.Size;
//                }
//            }
//        }

//        public static string GetParentOrganizationLogoPath(IFacade facade, bool isVirtual)
//        {
//            IList<OrganizationBranchOffice> organizationBranchOfficeList = facade.GetAllOrganizationBranchOfficeByOrganizationId(0);
//            string logoUrl = string.Empty;
//            if (organizationBranchOfficeList != null && organizationBranchOfficeList.Count > 0)
//            {
//                if (organizationBranchOfficeList[0].Logo != "")
//                {
//                    logoUrl = organizationBranchOfficeList[0].Logo;
//                    if (!isVirtual)
//                    {
//                        logoUrl = Path.Combine(UrlConstants.GetPhysicalOrgBranchUploadDirectory(), logoUrl);
//                    }
//                    else
//                    {
//                        logoUrl = Path.Combine(UrlConstants.ORGBRANCH_LOGO_DIR, logoUrl);
//                    }
//                    //Size size = MiscUtil.GetImageSize(logoUrl);

//                    //SecureUrl secureUrl = UrlHelper.BuildSecureUrl("../" + UrlConstants.DRAW_MEDIA_PAGE, string.Empty, UrlConstants.PARAM_IMG_FILE, logoUrl, UIConstants.SHOW_THUMB, bool.TrueString);

//                    //imgCompanyLogo.Src = secureUrl.ToString();
//                }
//            }
//            return logoUrl;
//        }

//        public static Size GetImageSize(string fileName)
//        {
//            Size size = new Size();

//            try
//            {
//                if (File.Exists(fileName))
//                {
//                    using (Bitmap bmp = new Bitmap(fileName))
//                    {
//                        size = bmp.Size;
//                    }
//                }
//            }
//            catch (FileNotFoundException)
//            {
//            }
//            catch (Exception)
//            {

//            }
//            return size;
//        }

//        public static ImageFormat GetImageFormat(string contentType)
//        {
//            contentType = StringHelper.ToLower(contentType);

//            ImageFormat format;

//            if (contentType.IndexOf("bmp") > -1)
//            {
//                format = System.Drawing.Imaging.ImageFormat.Bmp;
//            }
//            else if (contentType.IndexOf("emf") > -1)
//            {
//                format = System.Drawing.Imaging.ImageFormat.Emf;
//            }
//            else if (contentType.IndexOf("exif") > -1)
//            {
//                format = System.Drawing.Imaging.ImageFormat.Exif;
//            }
//            else if (contentType.IndexOf("gif") > -1)
//            {
//                format = System.Drawing.Imaging.ImageFormat.Gif;
//            }
//            else if (contentType.IndexOf("icon") > -1)
//            {
//                format = System.Drawing.Imaging.ImageFormat.Icon;
//            }
//            else if (contentType.IndexOf("png") > -1)
//            {
//                format = System.Drawing.Imaging.ImageFormat.Png;
//            }
//            else if (contentType.IndexOf("tiff") > -1)
//            {
//                format = System.Drawing.Imaging.ImageFormat.Tiff;
//            }
//            else if (contentType.IndexOf("wmf") > -1)
//            {
//                format = System.Drawing.Imaging.ImageFormat.Wmf;
//            }
//            else
//            {
//                format = System.Drawing.Imaging.ImageFormat.Jpeg;
//            }

//            return format;
//        }

//        public static string GetOnlyFileName(string fileName)
//        {
//            int fileStart = fileName.LastIndexOf("\\");

//            if (fileStart > 0)
//            {
//                return fileName.Substring(fileStart + 1);
//            }
//            else
//            {
//                fileStart = fileName.LastIndexOf("/");

//                if (fileStart > 0)
//                {
//                    return fileName.Substring(fileStart + 1);
//                }
//                else
//                {
//                    return fileName;
//                }
//            }
//        }

//        public static string GetOnBoardingStepTeamHtml(int stepId, IFacade facade)
//        {
//            StringBuilder teamBuilder = new StringBuilder();
//            IList<Member> memberList = facade.GetAllMemberByOnBoardingStepId(stepId);
//            if (memberList != null)
//            {
//                foreach (Member member in memberList)
//                {
//                    if (teamBuilder.IsNullOrEmpty())
//                    {
//                        teamBuilder.Append(GetFirstAndLastName(member.FirstName, member.LastName));
//                    }
//                    else
//                    {
//                        teamBuilder.Append("<br />");
//                        teamBuilder.Append(GetFirstAndLastName(member.FirstName, member.LastName));
//                    }
//                }
//            }
//            return teamBuilder.ToString();
//        }

//        public static string GetMemberGroupTeamHtml(int groupId, IFacade facade)
//        {
//            StringBuilder teamBuilder = new StringBuilder();
//            IList<Member> memberList = facade.GetAllMemberGroupManagerByMemberGroupId(groupId);
//            if (memberList != null)
//            {
//                foreach (Member member in memberList)
//                {
//                    if (teamBuilder.IsNullOrEmpty())
//                    {
//                        teamBuilder.Append(GetFirstAndLastName(member.FirstName, member.LastName));
//                    }
//                    else
//                    {
//                        teamBuilder.Append("<br />");
//                        teamBuilder.Append(GetFirstAndLastName(member.FirstName, member.LastName));
//                    }
//                }
//            }
//            return teamBuilder.ToString();
//        }

//        public static bool IsValidImageFile(FileUpload file)
//        {
//            try
//            {
//                using (Bitmap bmp = new Bitmap(file.PostedFile.InputStream))
//                {
//                    return true;
//                }
//            }
//            catch (ArgumentException)
//            {
//                //throws exception if not valid image
//            }

//            return false;
//        }

//        public static string ReplaceCharsFromFileName(string strText, char[] chrItems)
//        {
//            if (chrItems == null)
//            {
//                chrItems = new char[9];
//                chrItems[0] = '/';
//                chrItems[1] = '\\';
//                chrItems[2] = ':';
//                chrItems[3] = '*';
//                chrItems[4] = '?';
//                chrItems[5] = '\"';
//                chrItems[6] = '<';
//                chrItems[7] = '>';
//                chrItems[8] = '|';
//            }

//            for (int i = 0; i < chrItems.Length; i++)
//            {
//                strText = strText.Replace(chrItems[i], ' ');
//            }
//            return strText;
//        }

//        public static Size CalculateThumbSize(Size originalSize)
//        {
//            const double SZ_96 = 96;

//            double widthRatio = originalSize.Width / SZ_96;
//            double heightRatio = originalSize.Height / SZ_96;
//            double ratio = Math.Max(widthRatio, heightRatio);

//            if (ratio < 1) ratio = 1;

//            int thumbWidth = Convert.ToInt32((originalSize.Width / ratio));
//            int thumbHeight = Convert.ToInt32((originalSize.Height / ratio));

//            return new Size(thumbWidth, thumbHeight);
//        }

//        public static string GetCode(ModuleType moduleType, int id)
//        {
//            string generatedCode = string.Empty;

//            switch (moduleType)
//            {
//                case ModuleType.Candidate:
//                    generatedCode = "CAN" + id.ToString();
//                    break;
//                case ModuleType.Consultant:
//                    generatedCode = "CON" + id.ToString();
//                    break;
//                case ModuleType.Employee:
//                    generatedCode = "EMP" + id.ToString();
//                    break;
//                case ModuleType.Requisition:
//                    generatedCode = "REQ" + id.ToString();
//                    break;
//                case ModuleType.ProjectManagement:
//                    generatedCode = "PMP" + id.ToString();
//                    break;
//                case ModuleType.TimeSheet:
//                    generatedCode = "TMS" + id.ToString();
//                    break;
//                case ModuleType.SearchQuery:
//                    generatedCode = "QRY" + id.ToString().PadLeft(5, '0');
//                    break;
//                case ModuleType.Invoice:
//                    generatedCode = "INV" + id.ToString().PadLeft(5, '0');
//                    break;
//                default:
//                    generatedCode = string.Empty;
//                    break;
//            }

//            return generatedCode;
//        }

//        public static bool IsNewFile(string file)
//        {
//            return file.Contains(UrlConstants.TempDirectory);
//        }

//        public static void CopyFiles(StringDictionary files, string directory)
//        {
//            string fileName;
//            string filePath;
//            string newPath;

//            foreach (DictionaryEntry entry in files)
//            {
//                fileName = Path.GetFileName((string)entry.Value);
//                filePath = (string)entry.Value;

//                if (IsNewFile(filePath))
//                {
//                    if (!Directory.Exists(directory))
//                    {
//                        Directory.CreateDirectory(directory);
//                    }

//                    newPath = Path.Combine(directory, fileName);

//                    try
//                    {
//                        File.Copy(filePath, newPath, true);
//                        File.Delete(filePath);
//                    }
//                    catch
//                    {
//                    }
//                }
//            }
//        }

//        public static void CopyEmailFiles(StringDictionary files, string directory)
//        {
//            string[] fileName;
//            string[] filePath;
//            string newPath;

//            foreach (DictionaryEntry entry in files)
//            {
//                fileName = Path.GetFileName((string)entry.Value).Split((char)Convert.ToChar("?"));
//                filePath = ((string)entry.Value).Split((char)Convert.ToChar("?"));

//                if (IsNewFile(filePath[0]))
//                {
//                    if (!Directory.Exists(directory))
//                    {
//                        Directory.CreateDirectory(directory);
//                    }

//                    newPath = Path.Combine(directory, fileName[0]);

//                    try
//                    {
//                        File.Copy(filePath[0], newPath, true);
//                        File.Delete(filePath[0]);
//                    }
//                    catch
//                    {
//                    }
//                }
//            }
//        }

//        public static void PopulatePublishedTest(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            IList<TestMaster> testMasterList = facade.GetAllTestMasterByTypeAndPublishStatus((int)AssessmentType.Online, (int)AssessmentPusblishStatus.Published);
//            list.DataSource = testMasterList;
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateDailyWorkSchedule(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            IList<GenericLookup> genericLookupList = facade.GetAllGenericLookupByLookupType(LookupType.DailyWorkSchedule);
//            list.DataSource = genericLookupList;
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateDaysOfMonth(ListControl list)
//        {
//            list.Items.Clear();
//            for (int i = 1; i <= 31; i++)
//            {
//                list.Items.Add(new ListItem(i.ToString(), i.ToString()));
//            }

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateRatio(ListControl list)
//        {
//            list.Items.Clear();
//            list.Items.Add(new ListItem("1.00", "1.00"));
//            list.Items.Add(new ListItem("1.25", "1.25"));
//            list.Items.Add(new ListItem("1.50", "1.50"));
//            list.Items.Add(new ListItem("1.75", "1.75"));
//            list.Items.Add(new ListItem("2.00", "2.00"));
//            list.Items.Add(new ListItem("2.25", "2.25"));
//            list.Items.Add(new ListItem("2.50", "2.50"));

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        #region Member

//        public static void PopulateDocumentType(DropDownList ddlDocumentType, IFacade facade)
//        {
//            ddlDocumentType.Items.Clear();

//            ddlDocumentType.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.DocumentType);
//            ddlDocumentType.DataTextField = "Name";
//            ddlDocumentType.DataValueField = "Id";
//            ddlDocumentType.DataBind();

//            ddlDocumentType.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateMemberListByRole(ListControl list, string roleName, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllMemberNameByRoleName(roleName);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            //Please dont add this here. Add "All" from local page
//            //list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_ALL);
//        }

//        #endregion

//        public static void PopulateSalesLifeCycle(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.SalesLifeCycle);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateSalesProbability(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.SalesProbability);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateSalesStatus(ListControl list)
//        {
//            list.Items.Clear();

//            list.Items.Add(new ListItem(EnumHelper.GetDescription(SalesStatus.BadLead), StringHelper.Convert((int)SalesStatus.BadLead)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(SalesStatus.Lead), StringHelper.Convert((int)SalesStatus.Lead)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(SalesStatus.LostOpportunity), StringHelper.Convert((int)SalesStatus.LostOpportunity)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(SalesStatus.Opportunity), StringHelper.Convert((int)SalesStatus.Opportunity)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(SalesStatus.SuccessfullSales), StringHelper.Convert((int)SalesStatus.SuccessfullSales)));
//        }

//        public static void PopulateLeadPriority(ListControl list)
//        {
//            list.Items.Clear();

//            list.Items.Add(new ListItem(EnumHelper.GetDescription(LeadPriority.High), StringHelper.Convert((int)LeadPriority.High)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(LeadPriority.Low), StringHelper.Convert((int)LeadPriority.Low)));

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateLeadSource(ListControl list)
//        {
//            list.Items.Clear();

//            list.Items.Add(new ListItem(EnumHelper.GetDescription(LeadSource.Internal), StringHelper.Convert((int)LeadSource.Internal)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(LeadSource.External), StringHelper.Convert((int)LeadSource.External)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(LeadSource.Other), StringHelper.Convert((int)LeadSource.Other)));

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateCompanyStatus(ListControl list)
//        {
//            string allValues = StringHelper.Convert((int)CompanyStatus.Company) + ", " +
//                                StringHelper.Convert((int)CompanyStatus.ProspectiveClient) + ", " +
//                                StringHelper.Convert((int)CompanyStatus.Client) + ", " +
//                                StringHelper.Convert((int)CompanyStatus.Vendor) + ", " +
//                                StringHelper.Convert((int)CompanyStatus.Partner);

//            list.Items.Clear();

//            list.Items.Add(new ListItem(UIConstants.DROP_DOWNL_ITEM_ALL, allValues));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.Company), StringHelper.Convert((int)CompanyStatus.Company)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.ProspectiveClient), StringHelper.Convert((int)CompanyStatus.ProspectiveClient)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.Client), StringHelper.Convert((int)CompanyStatus.Client)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.Vendor), StringHelper.Convert((int)CompanyStatus.Vendor)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.Partner), StringHelper.Convert((int)CompanyStatus.Partner)));
//        }

//        public static void PopulateCompanyStatusForVendorGroup(ListControl list)
//        {
//            string allValues = StringHelper.Convert((int)CompanyStatus.Vendor) + ", " +
//                                StringHelper.Convert((int)CompanyStatus.Partner);

//            list.Items.Clear();
//            list.Items.Add(new ListItem(UIConstants.DROP_DOWNL_ITEM_ALL, allValues));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.Vendor), StringHelper.Convert((int)CompanyStatus.Vendor)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.Partner), StringHelper.Convert((int)CompanyStatus.Partner)));
//        }

//        public static void PopulateCompanyStatusForChangeRequest(ListControl list)
//        {
//            list.Items.Clear();

//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.Client), StringHelper.Convert((int)CompanyStatus.Client)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.ProspectiveClient), StringHelper.Convert((int)CompanyStatus.ProspectiveClient)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.Vendor), StringHelper.Convert((int)CompanyStatus.Vendor)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(CompanyStatus.Partner), StringHelper.Convert((int)CompanyStatus.Partner)));

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateMemberCampaign(ListControl list, IFacade facade, int memberId)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllCampaignByMemberId(memberId);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateCampaign(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllCampaign();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateDataCheckList(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.Items.Add(new ListItem(EnumHelper.GetDescription(DataCheckList.CompanyData), StringHelper.Convert((int)DataCheckList.CompanyData)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(DataCheckList.ManagementData), StringHelper.Convert((int)DataCheckList.ManagementData)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(DataCheckList.FinancialData), StringHelper.Convert((int)DataCheckList.FinancialData)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(DataCheckList.References), StringHelper.Convert((int)DataCheckList.References)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(DataCheckList.InsuranceData), StringHelper.Convert((int)DataCheckList.InsuranceData)));
//            list.Items.Add(new ListItem(EnumHelper.GetDescription(DataCheckList.CompanyDocuments), StringHelper.Convert((int)DataCheckList.CompanyDocuments)));
//        }

//        public static string GetMemberNameById(int id, IFacade facade)
//        {
//            string memberName = string.Empty;
//            if (id > 0)
//            {
//                Member member = facade.GetMemberById(id);
//                memberName = (member != null) ? member.FirstName + " " + member.LastName : string.Empty;
//            }
//            return memberName;
//        }

//        public static string GetCompanyNameById(int id, IFacade facade)
//        {
//            string companyName = string.Empty;
//            if (id > 0)
//            {
//                Company company = facade.GetCompanyById(id);
//                companyName = (company != null) ? company.CompanyName : string.Empty;
//            }
//            return companyName;
//        }

//        public static void PopulateTaskCategoryList(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllTaskCategory();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateHoursList(ListControl list)
//        {
//            list.Items.Clear();
//            list.Items.Add(new ListItem("12:00 AM", "0"));
//            list.Items.Add(new ListItem("1:00 AM", "1"));
//            list.Items.Add(new ListItem("2:00 AM", "2"));
//            list.Items.Add(new ListItem("3:00 AM", "3"));
//            list.Items.Add(new ListItem("4:00 AM", "4"));
//            list.Items.Add(new ListItem("5:00 AM", "5"));
//            list.Items.Add(new ListItem("6:00 AM", "6"));
//            list.Items.Add(new ListItem("7:00 AM", "7"));
//            list.Items.Add(new ListItem("8:00 AM", "8"));
//            list.Items.Add(new ListItem("9:00 AM", "9"));
//            list.Items.Add(new ListItem("10:00 AM", "10"));
//            list.Items.Add(new ListItem("11:00 AM", "11"));
//            list.Items.Add(new ListItem("12:00 PM", "12"));
//            list.Items.Add(new ListItem("1:00 PM", "13"));
//            list.Items.Add(new ListItem("2:00 PM", "14"));
//            list.Items.Add(new ListItem("3:00 PM", "15"));
//            list.Items.Add(new ListItem("4:00 PM", "16"));
//            list.Items.Add(new ListItem("5:00 PM", "17"));
//            list.Items.Add(new ListItem("6:00 PM", "18"));
//            list.Items.Add(new ListItem("7:00 PM", "19"));
//            list.Items.Add(new ListItem("8:00 PM", "20"));
//            list.Items.Add(new ListItem("9:00 PM", "21"));
//            list.Items.Add(new ListItem("10:00 PM", "22"));
//            list.Items.Add(new ListItem("11:00 PM", "23"));
//        }

//        public static void PopulateProjectStatusCategory(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.ProjectStatusCategory);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateLastTenYear(ListControl list)
//        {
//            list.Items.Clear();

//            DateTime date = DateTime.Today;

//            for (int i = date.Year; i >= date.Year - 10; i--)
//            {
//                list.Items.Add(i.ToString());
//            }

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static string GetFullName(string strFirstName, string strLastName)
//        {
//            string strFullName = strFirstName.Trim();
//            if (!String.IsNullOrEmpty(strLastName))
//            {
//                strFullName = strFullName + " " + strLastName;
//            }
//            return strFullName;
//        }

//        public static string GetFullName(string strFirstName, string strMiddleName, string strLastName)
//        {
//            string strFullName = strFirstName.Trim();
//            strMiddleName = strMiddleName.Trim();
//            if (!String.IsNullOrEmpty(strMiddleName))
//            {
//                strFullName = strFullName + " " + strMiddleName;
//            }

//            strLastName = strLastName.Trim();
//            if (!String.IsNullOrEmpty(strLastName))
//            {
//                strFullName = strFullName + " " + strLastName;
//            }
//            return strFullName;
//        }

//        public static string GetFullName(string strFirstName, string strMiddleName, string strLastName, string strNickName)
//        {
//            string strFullName = strFirstName.Trim();
//            strMiddleName = strMiddleName.Trim();
//            if (!String.IsNullOrEmpty(strMiddleName))
//            {
//                strFullName = strFullName + " " + strMiddleName;
//            }

//            strLastName = strLastName.Trim();
//            if (!String.IsNullOrEmpty(strLastName))
//            {
//                strFullName = strFullName + " " + strLastName;
//            }

//            if (!strNickName.IsNullOrEmpty())
//            {
//                strFullName = strFullName + "(" + strNickName + ")";
//            }
//            return strFullName;
//        }

//        public static string GetFirstAndLastName(string strFirstName, string strLastName)
//        {
//            string strFullName = strFirstName.Trim();
//            if (!String.IsNullOrEmpty(strLastName))
//            {
//                strFullName = strFullName + " " + strLastName;
//            }
//            return strFullName;
//        }

//        public static string GetLocation(string strCityName, string strState)
//        {
//            string strLocation = strCityName.Trim();
//            strState = strState.Trim();
//            if (strState.IsNotNullOrEmpty() && strLocation.IsNotNullOrEmpty())
//            {
//                strLocation = strLocation + ", " + strState;
//            }
//            else if (strState.IsNotNullOrEmpty())
//            {
//                strLocation = strState;
//            }

//            return strLocation;
//        }

//        public static string FormatExperience(string strExperience)
//        {
//            if (strExperience.Length > 5)
//            {
//                strExperience = strExperience.Substring(0, 5);
//            }
//            if (strExperience.IsNotNullOrEmpty())
//            {
//                string[] strValues = strExperience.Split(new char[] { '.' });
//                string formatValue = strValues[0];
//                if (strValues.Length == 2)
//                {
//                    int valueAfterDecimal = strValues[1].ToInteger();
//                    if (valueAfterDecimal > 11)
//                    {
//                        string strValueAfterDecimal = strValues[1].Substring(0, 1);
//                        formatValue = formatValue + ".0" + strValueAfterDecimal;//String.Format("{0:00}", strValueAfterDecimal.ToInteger());
//                    }
//                    else
//                    {
//                        formatValue = strExperience;
//                    }

//                }
//                strExperience = formatValue;
//            }
//            return strExperience;

//        }

//        public static string GetLocation(string strCityName, int stateId, IFacade facade)
//        {
//            string strState = GetStateCodeById(stateId, facade);
//            return GetLocation(strCityName, strState);
//        }

//        public static string GetLocation(string strCityName, int stateId, int countryId, IFacade facade)
//        {
//            string strState = GetStateCodeById(stateId, facade);
//            string strCountry = GetCountryNameById(countryId, facade);
//            return GetLocationWithCountry(strCityName, strState, strCountry);
//        }

//        public static string GetCurrentPageUrl()
//        {
//            string rootUrl = HttpContext.Current.Request.AppRelativeCurrentExecutionFilePath + HttpContext.Current.Request.Url.Query;
//            return rootUrl;
//        }

//        public static void SetApplicantOverviewLink(HyperLink lnk, int applicantId, string applicantName, bool isCandidate)
//        {
//            if (isCandidate)
//            {
//                ControlHelper.SetHyperLink(lnk, UrlConstants.Candidate.OVERVIEW, string.Empty, applicantName, UrlConstants.PARAM_MEMBER_ID, StringHelper.Convert(applicantId), UrlConstants.PARAM_BACK, GetCurrentPageUrl());
//            }
//            else
//            {
//                ControlHelper.SetHyperLink(lnk, UrlConstants.Consultant.OVERVIEW, string.Empty, applicantName, UrlConstants.PARAM_MEMBER_ID, StringHelper.Convert(applicantId), UrlConstants.PARAM_BACK, GetCurrentPageUrl());
//            }
//        }

//        public static string GetLocation(string strCity, string strState, string strZipCode)
//        {
//            string strCurrentLocation = string.Empty;

//            if (strCity != "")
//            {
//                strCurrentLocation = strCity;
//                if (strState != "")
//                {
//                    strCurrentLocation = strCurrentLocation + ", " + strState;
//                }
//                if (strZipCode != "")
//                {
//                    strCurrentLocation = strCurrentLocation + " " + strZipCode;
//                }
//            }
//            else if (strState != "")
//            {
//                strCurrentLocation = strState;
//                if (strZipCode != "")
//                {
//                    strCurrentLocation = strCurrentLocation + " " + strZipCode;
//                }
//            }
//            else if (strZipCode != "")
//            {
//                strCurrentLocation = strZipCode;
//            }
//            return strCurrentLocation;
//        }

//        public static string GetLocationWithCountry(string strCity, string strState, string strCountry)
//        {
//            string strCurrentLocation = string.Empty;

//            if (strCity != "")
//            {
//                strCurrentLocation = strCity;
//                if (strState != "")
//                {
//                    strCurrentLocation = strCurrentLocation + ", " + strState;
//                }
//                if (strCountry != "")
//                {
//                    strCurrentLocation = strCurrentLocation + ", " + strCountry;
//                }
//            }
//            else if (strState != "")
//            {
//                strCurrentLocation = strState;
//                if (strCountry != "")
//                {
//                    strCurrentLocation = strCurrentLocation + ", " + strCountry;
//                }
//            }
//            else if (strCountry != "")
//            {
//                strCurrentLocation = strCountry;
//            }
//            return strCurrentLocation;
//        }

//        public static string GetInternalRatingImage(string rating)
//        {
//            switch (rating)
//            {
//                case "-1":
//                    return UrlConstants.InternelRating.OneStar;
//                case "0":
//                    return UrlConstants.InternelRating.None;
//                case "1":
//                    return UrlConstants.InternelRating.One;
//                case "2":
//                    return UrlConstants.InternelRating.Two;
//                case "3":
//                    return UrlConstants.InternelRating.Three;
//                case "4":
//                    return UrlConstants.InternelRating.Four;
//                case "5":
//                    return UrlConstants.InternelRating.Five;
//                default:
//                    return UrlConstants.InternelRating.None;
//            }
//        }

//        public static string GetVHOnBoardingStatusImage(string status)
//        {
//            switch (status)
//            {
//                case "1":
//                    return UrlConstants.VHOnBoardingStatus.Pending;
//                case "2":
//                    return UrlConstants.VHOnBoardingStatus.InProgress;
//                case "3":
//                    return UrlConstants.VHOnBoardingStatus.Completed;
//                case "4":
//                    return UrlConstants.VHOnBoardingStatus.Failed;
//                default:
//                    return UrlConstants.VHOnBoardingStatus.Pending;
//            }
//        }

//        public static string GetAttendanceTypeImage(int intAttendanceType)
//        {
//            AttendanceType attendanceType = (AttendanceType)intAttendanceType;
//            switch (attendanceType)
//            {
//                case AttendanceType.AbsentWithoutReason:
//                    return UrlConstants.AttendanceType.AbsentWithoutReason;
//                case AttendanceType.AnnualVacation:
//                    return UrlConstants.AttendanceType.AnnualVacation;
//                case AttendanceType.EducationTraining:
//                    return UrlConstants.AttendanceType.EducationTraining;
//                case AttendanceType.HolidayCompany:
//                    return UrlConstants.AttendanceType.HolidayCompany;
//                case AttendanceType.HolidayGovernment:
//                    return UrlConstants.AttendanceType.HolidayGovernment;
//                case AttendanceType.HolidayReligious:
//                    return UrlConstants.AttendanceType.HolidayReligious;
//                case AttendanceType.JuryDuty:
//                    return UrlConstants.AttendanceType.JuryDuty;
//                case AttendanceType.LateStart:
//                    return UrlConstants.AttendanceType.LateStart;
//                case AttendanceType.LeaveEarly:
//                    return UrlConstants.AttendanceType.LeaveEarly;
//                case AttendanceType.NoWork:
//                    return UrlConstants.AttendanceType.NoWork;
//                case AttendanceType.ParentalLeave:
//                    return UrlConstants.AttendanceType.ParentalLeave;
//                case AttendanceType.Present:
//                    return UrlConstants.AttendanceType.Present;
//                case AttendanceType.SickLeave:
//                    return UrlConstants.AttendanceType.SickLeave;
//                case AttendanceType.Suspended:
//                    return UrlConstants.AttendanceType.Suspended;
//                case AttendanceType.Tardy:
//                    return UrlConstants.AttendanceType.Tardy;
//                case AttendanceType.UnpaidLeave:
//                    return UrlConstants.AttendanceType.UnpaidLeave;
//                case AttendanceType.WorkersCompensation:
//                    return UrlConstants.AttendanceType.WorkersCompensation;
//                default:
//                    return UrlConstants.AttendanceType.Present;

//            }
//        }

//        public static string GetRequistionPreviewPageLink(int jobpostingid, string jobtitle)
//        {
//            SecureUrl url = UrlHelper.BuildSecureUrl(UrlConstants.Requisition.JOB_POSTING_INTERNAL_PREVIEW_PAGE, "", UrlConstants.PARAM_ID, jobpostingid.ToString());
//            string strLink = "<a href='../" + url.ToString().Replace("~/", "") + "' target='_blank'>" + jobtitle + "</a>";
//            strLink = strLink.Replace("//", "/");
//            return strLink;
//        }

//        #region JobPosting

//        public static void AddJobPostingChangeHistory(int jobPostingId, string changeLog, int changeBy, IFacade facade)
//        {
//            JobPostingChangeArchive jobPostingChangeArchive = new JobPostingChangeArchive();
//            jobPostingChangeArchive.JobPostingId = jobPostingId;
//            jobPostingChangeArchive.ChangedHistory = changeLog;
//            jobPostingChangeArchive.IsRemove = false;
//            jobPostingChangeArchive.CreatorId = changeBy;
//            jobPostingChangeArchive.UpdatorId = changeBy;
//            facade.AddJobPostingChangeArchive(jobPostingChangeArchive);
//        }

//        public static void GetJobPostingAssignedManagers(int jobId, System.Web.UI.Control ctrlAssignedManagers, System.EventHandler clickEvent, int rowNo, int currentUserId, IFacade Facade)
//        {
//            if (jobId > 0)
//            {
//                IList<JobPostingHiringTeam> jobPostingHiringTeamList = Facade.GetAllJobPostingHiringTeamByJobPostingId(jobId);
//                if (jobPostingHiringTeamList != null)
//                {
//                    foreach (JobPostingHiringTeam jobPostingHiringTeam in jobPostingHiringTeamList)
//                    {
//                        if (jobPostingHiringTeam != null)
//                        {
//                            if (jobPostingHiringTeam.MemberId > 0)
//                            {
//                                Member member = Facade.GetMemberById(jobPostingHiringTeam.MemberId);
//                                if (member != null)
//                                {
//                                    Label lblManagerName = new Label();
//                                    lblManagerName.Text = member.FirstName + " " + member.LastName + " ";
//                                    lblManagerName.ID = "lblAssignedManager," + jobId + "," + member.Id.ToString();
//                                    ctrlAssignedManagers.Controls.Add(lblManagerName);

//                                    LinkButton lnkButton = new LinkButton();
//                                    if (member.Id == currentUserId)
//                                    {
//                                        lnkButton.Text = "Self Un-Assign</br>";
//                                    }
//                                    else
//                                    {
//                                        lnkButton.Text = "Un-Assign</br>";
//                                    }
//                                    lnkButton.ID = "lnkAssignedManager," + jobId + "," + rowNo + "," + member.Id.ToString();
//                                    lnkButton.CommandArgument = jobPostingHiringTeam.Id.ToString();
//                                    lnkButton.Click += clickEvent;
//                                    ctrlAssignedManagers.Controls.Add(lnkButton);
//                                }
//                            }
//                        }
//                    }
//                }
//            }
//        }

//        #endregion

//        #region JobPostingDocument

//        public static string GetJobPostingDocumentPath(Page request, int CurrentJobPostingId, string strFileName, string strDocumenType, bool isVirtual)
//        {
//            string strFilePath = String.Empty;
//            if (isVirtual)
//            {
//                strFilePath = "../" + UrlConstants.REQUISITION_DOC_DIR;
//            }
//            else
//            {
//                strFilePath = request.Server.MapPath("../" + UrlConstants.REQUISITION_DOC_DIR);
//            }
//            strFilePath = strFilePath + "/" + CurrentJobPostingId.ToString();
//            if (!isVirtual)
//            {
//                if (!Directory.Exists(strFilePath))
//                {
//                    Directory.CreateDirectory(strFilePath);
//                }
//            }
//            strFilePath = strFilePath + "/" + strDocumenType;
//            if (!isVirtual)
//            {
//                if (!Directory.Exists(strFilePath))
//                {
//                    Directory.CreateDirectory(strFilePath);
//                }
//            }
//            strFilePath = strFilePath + "/" + strFileName;
//            if (isVirtual)
//            {
//                string strPhysicalPath = request.Server.MapPath(strFilePath);
//                if (File.Exists(strPhysicalPath))
//                {
//                    return strFilePath;
//                }
//                else
//                {
//                    return strFileName;
//                }
//            }
//            else
//            {
//                return strFilePath;
//            }

//        }

//        #endregion

//        public static void PopulateOrganizationList(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllOrganizationBranchOffice();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateOrganizationPositionListByOrganizationId(ListControl list, IFacade facade, int organizationId)
//        {
//            list.Items.Clear();
//            IList<OrganizationBranchOfficePositionMap> organizationBranchOfficePositionMapList = facade.GetAllOrganizationBranchOfficePositionMapByOrgBranchId(organizationId);
//            if (organizationBranchOfficePositionMapList != null && organizationBranchOfficePositionMapList.Count > 0)
//            {
//                foreach (OrganizationBranchOfficePositionMap organizationBranchOfficePositionMap in organizationBranchOfficePositionMapList)
//                {
//                    Position position = facade.GetPositionById(organizationBranchOfficePositionMap.PositionId);
//                    if (position != null)
//                    {
//                        list.Items.Add(new ListItem(position.Name, position.Id.ToString()));
//                    }
//                }
//            }

//            organizationBranchOfficePositionMapList = facade.GetAllOrganizationBranchOfficePositionMapDirectPositionByOrgBranchId(organizationId);
//            if (organizationBranchOfficePositionMapList != null && organizationBranchOfficePositionMapList.Count > 0)
//            {
//                foreach (OrganizationBranchOfficePositionMap organizationBranchOfficePositionMap in organizationBranchOfficePositionMapList)
//                {
//                    Position position = facade.GetPositionById(organizationBranchOfficePositionMap.PositionId);
//                    if (position != null)
//                    {
//                        list.Items.Add(new ListItem(position.Name, position.Id.ToString()));
//                    }
//                }
//            }
//        }

//        public static void PopulateTimeDropDownList(DropDownList list)
//        {
//            DateTime dtTime = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day);
//            if (dtTime != null)
//            {
//                do
//                {
//                    list.Items.Add(dtTime.ToShortTimeString());
//                    dtTime = dtTime.AddMinutes(30);
//                }
//                while (dtTime.ToShortTimeString().IndexOf("11:30 PM") == -1);
//                list.Items.Add("11:30 PM");
//            }
//        }

//        public static void PopulateWeekDays(CheckBoxList list)
//        {
//            list.Items.Clear();
//            for (int i = 0; i < ContextConstants.DAYSINWEEK.Length; i++)
//            {
//                list.Items.Add(ContextConstants.DAYSINWEEK[i]);
//            }
//        }

//        public static void LoadSelectedWeekDays(CheckBoxList list, string days)
//        {
//            if (days.IsNotNullOrEmpty())
//            {
//                string[] weaklyHolidays = StringHelper.Separate(',', days);
//                foreach (string day in weaklyHolidays)
//                {
//                    ListItem searchItem = list.Items.FindByText(day);
//                    if (searchItem != null)
//                    {
//                        searchItem.Selected = true;
//                    }
//                }
//            }
//        }

//        public static string GetSelectedWeekDays(CheckBoxList list)
//        {
//            string checkedValue = string.Empty;
//            foreach (ListItem currentItem in list.Items)
//            {
//                if (currentItem.Selected)
//                {
//                    checkedValue = StringHelper.Concate(',', checkedValue, currentItem.Value);
//                }
//            }
//            return checkedValue;
//        }

//        public static void PopulateInsuranceType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.Insurance);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        // Returns all member skills in a list with comma seperated
//        public static string GetMemberSkillSetList(int memberId, IFacade Facade)
//        {
//            string skills = string.Empty;
//            int skillId = 0;
//            IList<MemberSkillMap> memberSkillMapList = Facade.GetAllMemberSkillMapByMemberId(memberId);

//            if (memberSkillMapList != null)
//            {
//                foreach (MemberSkillMap memberSkillMap in memberSkillMapList)
//                {
//                    skillId = memberSkillMap.SkillId;
//                    Skill skill = Facade.GetSkillById(skillId);

//                    if (skill != null)
//                    {
//                        if (string.IsNullOrEmpty(skills))
//                        {
//                            skills = skill.Name;
//                        }
//                        else
//                        {
//                            skills = skills + ", " + skill.Name;
//                        }
//                    }
//                }
//            }
//            return skills;
//        }

//        // This is used in interview pages
//        public static string GetMemberMatchingData(int memberId, int questionNo, IFacade facade)
//        {
//            string matchingData = string.Empty;
//            Member member;
//            MemberExtendedInformation memberExtendedInformation;
//            switch (questionNo)
//            {
//                case 1: //JobTitle
//                    memberExtendedInformation = facade.GetMemberExtendedInformationByMemberId(memberId);
//                    matchingData = memberExtendedInformation != null ? memberExtendedInformation.CurrentPosition : string.Empty;
//                    break;
//                case 2: //Location
//                    member = facade.GetMemberById(memberId);
//                    matchingData = member != null ? member.PermanentCity.ToString() : string.Empty;
//                    break;
//                case 3: //Industry Experience                    
//                    memberExtendedInformation = facade.GetMemberExtendedInformationByMemberId(memberId);
//                    matchingData = memberExtendedInformation != null ? GetLookupNameById(memberExtendedInformation.IndustryTypeLookupId, facade) : string.Empty;
//                    break;
//                case 4: //Educational degree
//                    memberExtendedInformation = facade.GetMemberExtendedInformationByMemberId(memberId);
//                    matchingData = memberExtendedInformation != null ? GetLookupNameById(memberExtendedInformation.HighestEducationLookupId, facade) : string.Empty;
//                    break;
//                case 5: //Work Status
//                    memberExtendedInformation = facade.GetMemberExtendedInformationByMemberId(memberId);
//                    matchingData = memberExtendedInformation != null ? GetLookupNameById(memberExtendedInformation.WorkAuthorizationLookupId, facade) : string.Empty;
//                    break;
//                case 6: //Salary
//                    memberExtendedInformation = facade.GetMemberExtendedInformationByMemberId(memberId);
//                    matchingData = memberExtendedInformation != null ? memberExtendedInformation.ExpectedYearlyRate.ToString() : string.Empty;
//                    break;
//                case 7: //Communication
//                    break;
//                case 8: //Genaral Impression
//                    break;
//                case 9: //Skill set
//                    matchingData = GetMemberSkillSetList(memberId, facade);
//                    break;
//                default: matchingData = string.Empty;
//                    break;
//            }

//            return string.IsNullOrEmpty(matchingData) ? "(Not Mentioned)" : "(" + matchingData + ")";
//        }

//        public static void PopulateProficiencyLevel(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.Proficiency);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static string GetStateNameById(int stateId, IFacade facade)
//        {
//            string stateName = string.Empty;
//            if (stateId > 0)
//            {
//                State state = facade.GetStateById(stateId);
//                stateName = state != null ? state.Name : string.Empty;
//            }
//            return stateName;
//        }

//        public static string GetStateCodeById(int stateId, IFacade facade)
//        {
//            string stateCode = string.Empty;
//            if (stateId > 0)
//            {
//                State state = facade.GetStateById(stateId);
//                stateCode = state != null ? state.StateCode : string.Empty;
//            }
//            return stateCode;
//        }

//        public static string GetCountryNameById(int countryId, IFacade facade)
//        {
//            string countryName = string.Empty;
//            if (countryId > 0)
//            {
//                Country country = facade.GetCountryById(countryId);
//                countryName = (country != null ? country.Name : string.Empty);
//            }
//            return countryName;
//        }

//        public static string GetCountryCodeById(int countryId, IFacade facade)
//        {
//            string countryCode = string.Empty;
//            if (countryId > 0)
//            {
//                Country country = facade.GetCountryById(countryId);
//                countryCode = (country != null ? country.CountryCode : string.Empty);
//            }
//            return countryCode;
//        }

//        public static string GetCurrency(int currencyId, IFacade facade)
//        {
//            string currency = string.Empty;
//            if (currencyId > 0)
//            {
//                GenericLookup genericLookup = facade.GetGenericLookupById(currencyId);
//                currency = (genericLookup != null ? genericLookup.Name : string.Empty);
//            }
//            return currency;
//        }

//        public static CustomSiteMap GetSiteMap(string url, IFacade facade)
//        {
//            url = url.Replace("~/", "").Trim();
//            url = url.Replace("//", "/").Trim();
//            return facade.GetCustomSiteMapByUrl(url);
//        }

//        #region Client

//        public static void PopulateClients(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllClients();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_CLIENT);
//        }

//        #endregion

//        #region Hot List

//        public static void PopulateMemberGroupByMemberId(ListControl list, IFacade facade, int memberId)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllMemberGroupNameByManagerId(memberId);

//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_HOTLIST);
//            list.Items.Insert(1, new ListItem("< Add New >", " 1 "));
//        }

//        public static void PopulateMemberGroupForTimeSheetByMemberId(ListControl list, IFacade facade, int memberId)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllMemberGroupNameByManagerId(memberId);

//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_CLIENT_MANAGER);
//        }

//        public static void PopulateMemberGroupByMemberId(ListControl list, IFacade facade, int memberId, MemberGroupType groupType)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllMemberGroupNameByManagerId(memberId, (int)groupType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_HOTLIST, "0"));
//            list.Items.Insert(1, new ListItem("< Add New >", "-1"));
//        }

//        public static void PopulateMemberManagerByMemberId(ListControl list, IFacade facade, int memberId)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetMemberManagerListByMemberId(memberId);

//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_INTERNAL_MANAGER);

//        }

//        public static string GetResumeSourceByMemberId(IFacade facade, int resumeSourceId, int resumeSourceType, int creatorId)
//        {
//            try
//            {
//                ResumeSource resumeSource = (ResumeSource)resumeSourceType;
//                string strResumeSource = EnumHelper.GetDescription(resumeSource);
//                string strResumeSourceName = string.Empty;
//                if (resumeSourceId > 0)
//                {
//                    if (resumeSource == ResumeSource.ResumeParser)
//                    {
//                        WebParserDomain webParserDomain = facade.GetWebParserDomainById(resumeSourceId);
//                        if (webParserDomain != null)
//                        {
//                            strResumeSource = webParserDomain.DomainName;
//                        }
//                        strResumeSourceName = GetMemberNameById(creatorId, facade);
//                    }
//                    else if (resumeSource == ResumeSource.Client || resumeSource == ResumeSource.Company || resumeSource == ResumeSource.ProspectiveClient || resumeSource == ResumeSource.Vendor || resumeSource == ResumeSource.Partner)
//                    {
//                        strResumeSourceName = GetCompanyNameById(resumeSourceId, facade);
//                    }
//                    else if (resumeSource != ResumeSource.SelfRegistration)
//                    {
//                        strResumeSourceName = GetMemberNameById(resumeSourceId, facade);
//                    }
//                }
//                if (strResumeSourceName.IsNotNullOrEmpty())
//                {
//                    strResumeSource = strResumeSource + " (" + strResumeSourceName + ")";
//                }
//                return strResumeSource;
//            }
//            catch
//            {
//                return string.Empty;
//            }
//        }

//        public static string GetResumeSource(string strResumeSourceName, string resumeSourceType)
//        {
//            if (strResumeSourceName.IsNotNullOrEmpty())
//            {
//                return resumeSourceType + " (" + strResumeSourceName + ")";
//            }
//            else
//            {
//                return resumeSourceType;
//            }
//        }

//        public static void PopulateMasterHotlist(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            IList<MemberGroup> memberGroupList = facade.GetAllMemberGroup();
//            if (memberGroupList != null)
//            {
//                list.DataSource = memberGroupList;
//                list.DataTextField = "Name";
//                list.DataValueField = "Id";
//                list.DataBind();
//            }
//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_HOTLIST);
//        }

//        public static void PopulateMasterHotlist(ListControl list, IFacade facade, MemberGroupType groupType)
//        {
//            list.Items.Clear();
//            IList<MemberGroup> memberGroupList = facade.GetAllMemberGroup((int)groupType);
//            if (memberGroupList != null)
//            {
//                list.DataSource = memberGroupList;
//                list.DataTextField = "Name";
//                list.DataValueField = "Id";
//                list.DataBind();
//            }
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_HOTLIST, "0"));
//            list.Items.Insert(1, new ListItem("< Add New >", " 1 "));

//        }


//        #endregion

//        #region MemberDocument

//        public static string GetMemberDocumentPath(Page request, int memberId, string strFileName, string strDocumenType, bool isVirtual)
//        {
//            string strFilePath = String.Empty;
//            if (isVirtual)
//            {
//                strFilePath = "../" + UrlConstants.MEMBER_DOC_DIR;
//            }
//            else
//            {
//                if (request == null)
//                {
//                    strFilePath = HttpContext.Current.Server.MapPath("~/" + UrlConstants.MEMBER_DOC_DIR);
//                }
//                else
//                {
//                    strFilePath = request.Server.MapPath("../" + UrlConstants.MEMBER_DOC_DIR);
//                }
//            }
//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + memberId.ToString();
//                if (!Directory.Exists(strFilePath))
//                {
//                    Directory.CreateDirectory(strFilePath);
//                }
//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + memberId.ToString();
//            }


//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + strDocumenType;
//                if (!Directory.Exists(strFilePath))
//                {
//                    Directory.CreateDirectory(strFilePath);
//                }
//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + strDocumenType;
//            }

//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + strFileName;
//                return strFilePath;

//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + strFileName;
//                string strPhysicalPath = string.Empty;
//                if (request == null)
//                {
//                    strPhysicalPath = HttpContext.Current.Server.MapPath(strFilePath);
//                }
//                else
//                {
//                    strPhysicalPath = request.Server.MapPath(strFilePath);
//                }
//                if (File.Exists(strPhysicalPath))
//                {
//                    return strFilePath;
//                }
//                else
//                {
//                    return strFileName;
//                }
//            }
//        }

//        public static string GetMemberDocumentPath(int memberId, string strFileName, int documenType, bool isVirtual, IFacade facade)
//        {
//            string strDocumentType = GetLookupNameById(documenType, facade);
//            return GetMemberDocumentPath(null, memberId, strFileName, strDocumentType, isVirtual);
//        }

//        public static string GetHowToDocumentPath(Page request, int helpContentId, string strFileName, bool isVirtual)
//        {
//            string strFilePath = String.Empty;
//            if (isVirtual)
//            {
//                strFilePath = "../" + UrlConstants.HELP_CONTENT_DOC_DIR;
//            }
//            else
//            {
//                strFilePath = request.Server.MapPath("../" + UrlConstants.HELP_CONTENT_DOC_DIR);
//            }
//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + helpContentId.ToString();
//                if (!Directory.Exists(strFilePath))
//                {
//                    Directory.CreateDirectory(strFilePath);
//                }
//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + helpContentId.ToString();
//            }

//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + strFileName;
//                return strFilePath;

//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + strFileName;
//                string strPhysicalPath = request.Server.MapPath(strFilePath);
//                if (File.Exists(strPhysicalPath))
//                {
//                    return strFilePath;
//                }
//                else
//                {
//                    return strFileName;
//                }
//            }
//        }

//        #endregion

//        #region TaskDocument

//        public static string GetTaskDocumentPath(Page request, string strFileName, string strCommonTaskID, bool isVirtual)
//        {
//            string strFilePath = String.Empty;
//            if (isVirtual)
//            {
//                strFilePath = "../" + UrlConstants.TaskManagement.TASK_DOC_DIR;
//            }
//            else
//            {
//                strFilePath = request.Server.MapPath("../" + UrlConstants.TaskManagement.TASK_DOC_DIR);
//            }
//            //if (!isVirtual)
//            //{
//            //    strFilePath = strFilePath + "\\" + memberId.ToString();
//            //    if (!Directory.Exists(strFilePath))
//            //    {
//            //        Directory.CreateDirectory(strFilePath);
//            //    }
//            //}
//            //else
//            //{
//            //    strFilePath = strFilePath + "/" + memberId.ToString();
//            //}


//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + strCommonTaskID;
//                if (!Directory.Exists(strFilePath))
//                {
//                    Directory.CreateDirectory(strFilePath);
//                }
//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + strCommonTaskID;
//            }

//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + strFileName;
//                return strFilePath;

//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + strFileName;
//                string strPhysicalPath = request.Server.MapPath(strFilePath);
//                if (File.Exists(strPhysicalPath))
//                {
//                    return strFilePath;
//                }
//                else
//                {
//                    return strFileName;
//                }
//            }
//        }

//        #endregion

//        #region TaskDocument

//        public static string GetExpenseDocumentPath(Page request, string strFileName, string strExpenseID, bool isVirtual)
//        {
//            string strFilePath = String.Empty;
//            if (isVirtual)
//            {
//                strFilePath = "../" + UrlConstants.LocalAccounts.EXPENSE_DOC_DIR;
//            }
//            else
//            {
//                strFilePath = request.Server.MapPath("../" + UrlConstants.LocalAccounts.EXPENSE_DOC_DIR);
//            }
//            //if (!isVirtual)
//            //{
//            //    strFilePath = strFilePath + "\\" + memberId.ToString();
//            //    if (!Directory.Exists(strFilePath))
//            //    {
//            //        Directory.CreateDirectory(strFilePath);
//            //    }
//            //}
//            //else
//            //{
//            //    strFilePath = strFilePath + "/" + memberId.ToString();
//            //}


//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + strExpenseID;
//                if (!Directory.Exists(strFilePath))
//                {
//                    Directory.CreateDirectory(strFilePath);
//                }
//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + strExpenseID;
//            }

//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + strFileName;
//                return strFilePath;

//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + strFileName;
//                string strPhysicalPath = request.Server.MapPath(strFilePath);
//                if (File.Exists(strPhysicalPath))
//                {
//                    return strFilePath;
//                }
//                else
//                {
//                    return strFileName;
//                }
//            }
//        }

//        #endregion


//        #region SalesColleteralDocument
//        public static string GetSalesDocumentPath(Page request, string strFileName, bool isVirtual)
//        {
//            string strFilePath = String.Empty;
//            if (isVirtual)
//            {
//                strFilePath = "../" + "Resources/ProductDocuments/";
//            }
//            else
//            {
//                strFilePath = request.Server.MapPath("../" + "Resources/ProductDocuments/");
//            }

//            if (!isVirtual)
//            {

//                if (!Directory.Exists(strFilePath))
//                {
//                    Directory.CreateDirectory(strFilePath);
//                }
//            }
//            else
//            {
//                //strFilePath = strFilePath + "/";
//            }

//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + strFileName;
//                return strFilePath;

//            }
//            else
//            {
//                strFilePath = strFilePath + strFileName;
//                string strPhysicalPath = request.Server.MapPath(strFilePath);
//                if (File.Exists(strPhysicalPath))
//                {
//                    return strFilePath;
//                }
//                else
//                {
//                    return strFileName;
//                }
//            }
//        }
//        #endregion

//        #region TestQuestionDocument

//        public static string GetTestQuestionDocumentPath(Page page, string strFileName, string strTestQuestionId, bool isVirtual)
//        {
//            string strFilePath = String.Empty;
//            if (isVirtual)
//            {
//                strFilePath = "../" + UrlConstants.Assessment.TEST_QUESTION_DIR;
//            }
//            else
//            {
//                strFilePath = page.Server.MapPath("../" + UrlConstants.Assessment.TEST_QUESTION_DIR);
//            }

//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + strTestQuestionId;
//                if (!Directory.Exists(strFilePath))
//                {
//                    Directory.CreateDirectory(strFilePath);
//                }
//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + strTestQuestionId;
//            }

//            if (!isVirtual)
//            {
//                strFilePath = strFilePath + "\\" + strFileName;
//                return strFilePath;

//            }
//            else
//            {
//                strFilePath = strFilePath + "/" + strFileName;
//                string strPhysicalPath = page.Server.MapPath(strFilePath);
//                if (File.Exists(strPhysicalPath))
//                {
//                    return strFilePath;
//                }
//                else
//                {
//                    return strFileName;
//                }
//            }
//        }

//        #endregion

//        //public static bool AddToPreselectedList(int jobpostingid, int memberid, int creatorId, IFacade facade)
//        //{
//        //    int jobCartId = 0;
//        //    MemberJobCart memberJobCart = facade.GetMemberJobCartByMemberIdAndJobPostringId(memberid, jobpostingid);
//        //    if (memberJobCart == null)
//        //    {
//        //        MemberJobCart newJobCart = new MemberJobCart();
//        //        newJobCart.JobPostingId = jobpostingid;
//        //        newJobCart.MemberId = memberid;
//        //        newJobCart.IsPrivate = false;
//        //        newJobCart.UpdateDate = DateTime.Now;
//        //        newJobCart.UpdatorId = creatorId;
//        //        newJobCart.CreatorId = creatorId;
//        //        newJobCart.ApplyDate = DateTime.Now;
//        //        newJobCart = facade.AddMemberJobCart(newJobCart);
//        //        jobCartId = newJobCart.Id;
//        //    }
//        //    else if (memberJobCart.IsRemoved)
//        //    {
//        //        memberJobCart.IsRemoved = false;
//        //        memberJobCart.UpdatorId = creatorId;
//        //        memberJobCart.UpdateDate = DateTime.Now;
//        //        facade.UpdateMemberJobCart(memberJobCart);
//        //        jobCartId = memberJobCart.Id;
//        //    }
//        //    else
//        //    {
//        //        jobCartId = memberJobCart.Id;
//        //    }
//        //    if (jobCartId != 0)
//        //    {
//        //        MemberJobCartDetail jobCartDetail = facade.GetMemberJobCartDetailByMemberJobCartIdAndSelectionStepId(jobCartId, (int)MemberSelectionStep.PreSelectd);
//        //        if (jobCartDetail == null)
//        //        {
//        //            jobCartDetail = new MemberJobCartDetail();
//        //            AddToHiringLevel((int)MemberSelectionStep.PreSelectd, jobCartDetail, creatorId, jobCartId, false, facade);
//        //            return true;
//        //        }
//        //        else if (jobCartDetail.IsRemoved)
//        //        {
//        //            AddToHiringLevel((int)MemberSelectionStep.PreSelectd, jobCartDetail, creatorId, jobCartId, false, facade);
//        //            return true;
//        //        }
//        //    }
//        //    return false;
//        //}

//        //public static bool AddToLevelIList(int jobpostingid, int memberid, int creatorId, IFacade facade)
//        //{
//        //    int jobCartId = 0;
//        //    MemberJobCart memberJobCart = facade.GetMemberJobCartByMemberIdAndJobPostringId(memberid, jobpostingid);
//        //    if (memberJobCart == null)
//        //    {
//        //        MemberJobCart newJobCart = new MemberJobCart();
//        //        newJobCart.JobPostingId = jobpostingid;
//        //        newJobCart.MemberId = memberid;
//        //        newJobCart.IsPrivate = false;
//        //        newJobCart.UpdateDate = DateTime.Now;
//        //        newJobCart.UpdatorId = creatorId;
//        //        newJobCart.CreatorId = creatorId;
//        //        newJobCart.ApplyDate = DateTime.Now;
//        //        newJobCart = facade.AddMemberJobCart(newJobCart);
//        //        jobCartId = newJobCart.Id;
//        //    }
//        //    else if (memberJobCart.IsRemoved)
//        //    {
//        //        memberJobCart.IsRemoved = false;
//        //        memberJobCart.UpdatorId = creatorId;
//        //        memberJobCart.UpdateDate = DateTime.Now;
//        //        facade.UpdateMemberJobCart(memberJobCart);
//        //        jobCartId = memberJobCart.Id;
//        //    }
//        //    else
//        //    {
//        //        jobCartId = memberJobCart.Id;
//        //    }
//        //    if (jobCartId != 0)
//        //    {
//        //        MemberJobCartDetail jobCartDetail = facade.GetMemberJobCartDetailByMemberJobCartIdAndSelectionStepId(jobCartId, (int)MemberSelectionStep.PreSelectd);
//        //        if (jobCartDetail != null && !jobCartDetail.IsRemoved)
//        //        {
//        //            AddToHiringLevel((int)MemberSelectionStep.PreSelectd, jobCartDetail, creatorId, jobCartId, true, facade);
//        //        }
//        //        jobCartDetail = facade.GetMemberJobCartDetailByMemberJobCartIdAndSelectionStepId(jobCartId, (int)MemberSelectionStep.LevelIInterview);
//        //        if (jobCartDetail == null)
//        //        {
//        //            jobCartDetail = new MemberJobCartDetail();
//        //            AddToHiringLevel((int)MemberSelectionStep.LevelIInterview, jobCartDetail, creatorId, jobCartId, false, facade);
//        //            return true;
//        //        }
//        //    }
//        //    return false;
//        //}

//        //public static bool AddToLevelIIList(int jobpostingid, int memberid, int creatorId, IFacade facade)
//        //{
//        //    int jobCartId = 0;
//        //    MemberJobCart memberJobCart = facade.GetMemberJobCartByMemberIdAndJobPostringId(memberid, jobpostingid);
//        //    if (memberJobCart == null)
//        //    {
//        //        MemberJobCart newJobCart = new MemberJobCart();
//        //        newJobCart.JobPostingId = jobpostingid;
//        //        newJobCart.MemberId = memberid;
//        //        newJobCart.IsPrivate = false;
//        //        newJobCart.UpdateDate = DateTime.Now;
//        //        newJobCart.UpdatorId = creatorId;
//        //        newJobCart.CreatorId = creatorId;
//        //        newJobCart.ApplyDate = DateTime.Now;
//        //        newJobCart = facade.AddMemberJobCart(newJobCart);
//        //        jobCartId = newJobCart.Id;
//        //    }
//        //    else if (memberJobCart.IsRemoved)
//        //    {
//        //        memberJobCart.IsRemoved = false;
//        //        memberJobCart.UpdatorId = creatorId;
//        //        memberJobCart.UpdateDate = DateTime.Now;
//        //        facade.UpdateMemberJobCart(memberJobCart);
//        //        jobCartId = memberJobCart.Id;
//        //    }
//        //    else
//        //    {
//        //        jobCartId = memberJobCart.Id;
//        //    }
//        //    if (jobCartId != 0)
//        //    {
//        //        MemberJobCartDetail jobCartDetail = facade.GetMemberJobCartDetailByMemberJobCartIdAndSelectionStepId(jobCartId, (int)MemberSelectionStep.PreSelectd);
//        //        if (jobCartDetail != null && !jobCartDetail.IsRemoved)
//        //        {
//        //            AddToHiringLevel((int)MemberSelectionStep.PreSelectd, jobCartDetail, creatorId, jobCartId, true, facade);
//        //        }
//        //        jobCartDetail = facade.GetMemberJobCartDetailByMemberJobCartIdAndSelectionStepId(jobCartId, (int)MemberSelectionStep.LevelIInterview);
//        //        if (jobCartDetail != null && !jobCartDetail.IsRemoved)
//        //        {
//        //            AddToHiringLevel((int)MemberSelectionStep.LevelIInterview, jobCartDetail, creatorId, jobCartId, true, facade);
//        //        }
//        //        jobCartDetail = facade.GetMemberJobCartDetailByMemberJobCartIdAndSelectionStepId(jobCartId, (int)MemberSelectionStep.LevelIIInterview);
//        //        if (jobCartDetail == null)
//        //        {
//        //            jobCartDetail = new MemberJobCartDetail();
//        //            AddToHiringLevel((int)MemberSelectionStep.LevelIIInterview, jobCartDetail, creatorId, jobCartId, false, facade);
//        //            return true;
//        //        }
//        //    }
//        //    return false;
//        //}

//        //public static bool AddToLevelIIIList(int jobpostingid, int memberid, int creatorId, IFacade facade)
//        //{
//        //    int jobCartId = 0;
//        //    MemberJobCart memberJobCart = facade.GetMemberJobCartByMemberIdAndJobPostringId(memberid, jobpostingid);
//        //    if (memberJobCart == null)
//        //    {
//        //        MemberJobCart newJobCart = new MemberJobCart();
//        //        newJobCart.JobPostingId = jobpostingid;
//        //        newJobCart.MemberId = memberid;
//        //        newJobCart.IsPrivate = false;
//        //        newJobCart.UpdateDate = DateTime.Now;
//        //        newJobCart.UpdatorId = creatorId;
//        //        newJobCart.CreatorId = creatorId;
//        //        newJobCart.ApplyDate = DateTime.Now;
//        //        newJobCart = facade.AddMemberJobCart(newJobCart);
//        //        jobCartId = newJobCart.Id;
//        //    }
//        //    else if (memberJobCart.IsRemoved)
//        //    {
//        //        memberJobCart.IsRemoved = false;
//        //        memberJobCart.UpdatorId = creatorId;
//        //        memberJobCart.UpdateDate = DateTime.Now;
//        //        facade.UpdateMemberJobCart(memberJobCart);
//        //        jobCartId = memberJobCart.Id;
//        //    }
//        //    else
//        //    {
//        //        jobCartId = memberJobCart.Id;
//        //    }
//        //    if (jobCartId != 0)
//        //    {
//        //        MemberJobCartDetail jobCartDetail = facade.GetMemberJobCartDetailByMemberJobCartIdAndSelectionStepId(jobCartId, (int)MemberSelectionStep.PreSelectd);
//        //        if (jobCartDetail != null && !jobCartDetail.IsRemoved)
//        //        {
//        //            AddToHiringLevel((int)MemberSelectionStep.PreSelectd, jobCartDetail, creatorId, jobCartId, true, facade);
//        //        }
//        //        jobCartDetail = facade.GetMemberJobCartDetailByMemberJobCartIdAndSelectionStepId(jobCartId, (int)MemberSelectionStep.LevelIInterview);
//        //        if (jobCartDetail != null && !jobCartDetail.IsRemoved)
//        //        {
//        //            AddToHiringLevel((int)MemberSelectionStep.LevelIInterview, jobCartDetail, creatorId, jobCartId, true, facade);
//        //        }
//        //        jobCartDetail = facade.GetMemberJobCartDetailByMemberJobCartIdAndSelectionStepId(jobCartId, (int)MemberSelectionStep.LevelIIInterview);
//        //        if (jobCartDetail != null && !jobCartDetail.IsRemoved)
//        //        {
//        //            AddToHiringLevel((int)MemberSelectionStep.LevelIIInterview, jobCartDetail, creatorId, jobCartId, true, facade);
//        //        }
//        //        jobCartDetail = facade.GetMemberJobCartDetailByMemberJobCartIdAndSelectionStepId(jobCartId, (int)MemberSelectionStep.LevelIIIInterview);
//        //        if (jobCartDetail == null)
//        //        {
//        //            jobCartDetail = new MemberJobCartDetail();
//        //            AddToHiringLevel((int)MemberSelectionStep.LevelIIIInterview, jobCartDetail, creatorId, jobCartId, false, facade);
//        //            return true;
//        //        }
//        //    }
//        //    return false;
//        //}

//        //public static void AddToHiringLevel(int level, MemberJobCartDetail memberJobCartDetail, int creatorId, int jobCartId, bool isRemoved, IFacade facade)
//        //{
//        //    if (memberJobCartDetail.IsNew)
//        //    {
//        //        memberJobCartDetail.AddedBy = creatorId;
//        //        memberJobCartDetail.AddedDate = DateTime.Now;
//        //        memberJobCartDetail.CreateDate = DateTime.Now;
//        //        memberJobCartDetail.CreatorId = creatorId;
//        //        memberJobCartDetail.UpdateDate = DateTime.Now;
//        //        memberJobCartDetail.UpdatorId = creatorId;
//        //        memberJobCartDetail.MemberJobCartId = jobCartId;
//        //        memberJobCartDetail.SelectionStepLookupId = level;
//        //        memberJobCartDetail.IsRemoved = isRemoved;
//        //        facade.AddMemberJobCartDetail(memberJobCartDetail);
//        //    }
//        //    else if (!memberJobCartDetail.IsNew)
//        //    {
//        //        memberJobCartDetail.IsRemoved = isRemoved;
//        //        memberJobCartDetail.UpdatorId = creatorId;
//        //        memberJobCartDetail.UpdateDate = DateTime.Now;
//        //        facade.UpdateMemberJobCartDetail(memberJobCartDetail);
//        //    }
//        //}

//        public static bool AddToHotList(int hotlistid, int memberid, int creatorId, IFacade facade)
//        {
//            bool isSuccess = false;
//            MemberGroupMap memberGroupMap = facade.GetMemberGroupMapByMemberIdandMemberGroupId(memberid, hotlistid);
//            if (memberGroupMap == null)
//            {
//                MemberGroupMap newMemberGroupMap = new MemberGroupMap();
//                newMemberGroupMap.CreateDate = DateTime.Now;
//                newMemberGroupMap.CreatorId = creatorId;
//                newMemberGroupMap.UpdateDate = DateTime.Now;
//                newMemberGroupMap.UpdatorId = creatorId;
//                newMemberGroupMap.MemberGroupId = hotlistid;
//                newMemberGroupMap.MemberId = memberid;
//                facade.AddMemberGroupMap(newMemberGroupMap);
//                isSuccess = true;
//            }
//            else if (memberGroupMap.IsRemoved)
//            {
//                memberGroupMap.IsRemoved = false;
//                memberGroupMap.UpdateDate = DateTime.Now;
//                memberGroupMap.UpdatorId = creatorId;
//                facade.UpdateMemberGroupMap(memberGroupMap);
//                isSuccess = true;
//            }
//            return isSuccess;
//        }

//        //public static bool RemoveFromHotList(int hotlistid, int memberid,int creatorId, IFacade facade)
//        //{
//        //    if (facade.DeleteMemberGroupMapByMemberIdandMemberGroupId(memberid, hotlistid, creatorId))
//        //    {
//        //        return true;
//        //    }
//        //    else
//        //    {
//        //        return false;
//        //    }
//        //}

//        public static bool AddToMyList(int managerId, int memberId, int creatorId, IFacade facade)
//        {
//            if (managerId > 0 && memberId > 0)
//            {
//                MemberManager memberManager = facade.GetMemberManagerByMemberIdAndManagerId(memberId, managerId);
//                if (memberManager == null)
//                {
//                    memberManager = new MemberManager();
//                    memberManager.ManagerId = managerId;
//                    memberManager.MemberId = memberId;
//                    memberManager.IsPrimaryManager = false;
//                    memberManager.UpdatorId = creatorId;
//                    memberManager.CreatorId = creatorId;
//                    memberManager.UpdateDate = DateTime.Now;
//                    memberManager.CreateDate = DateTime.Now;
//                    facade.AddMemberManager(memberManager);
//                    return true;
//                }
//                else if (memberManager.IsRemoved)
//                {
//                    memberManager.IsRemoved = false;
//                    memberManager.UpdateDate = DateTime.Now;
//                    memberManager.UpdatorId = creatorId;
//                    facade.UpdateMemberManager(memberManager);
//                    return true;
//                }
//            }
//            return false;
//        }

//        public static void PopulateFollowupAction(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.FollowupAction);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static string GetSkillNameById(int skillId, IFacade facade)
//        {
//            string skillName = string.Empty;

//            Skill skill = facade.GetSkillById(skillId);
//            skillName = (skill != null ? skill.Name : string.Empty);

//            return skillName;
//        }

//        public static string GetTestNameById(int testId, IFacade facade)
//        {
//            string testName = string.Empty;

//            TestMaster testMaster = facade.GetTestMasterById(testId);
//            testName = (testMaster != null ? testMaster.Name : string.Empty);

//            return testName;
//        }

//        public static bool AddActivity(string memberRole, int memberId, int creatorId, ActivityType activityType, IFacade facade)
//        {
//            MemberActivityType memberActivityType = facade.GetMemberActivityType((int)activityType);
//            if (memberActivityType != null && memberRole.Trim() != string.Empty && memberId != 0 && creatorId != 0)
//            {
//                MemberActivity memberActivity = new MemberActivity();

//                if (memberRole.ToLower() == ContextConstants.ROLE_CANDIDATE.ToLower())
//                {
//                    memberActivity.ActivityOn = (int)MemberType.Candidate;
//                }
//                else if (memberRole.ToLower() == ContextConstants.ROLE_CONSULTANT.ToLower())
//                {
//                    memberActivity.ActivityOn = (int)MemberType.Consultant;
//                }
//                else if (memberRole.ToLower() == ContextConstants.ROLE_EMPLOYEE.ToLower())
//                {
//                    memberActivity.ActivityOn = (int)MemberType.Employee;
//                }
//                else
//                {
//                    return false;
//                }
//                memberActivity.ActivityOnObjectId = memberId;
//                memberActivity.CreateDate = DateTime.Now;
//                memberActivity.CreatorId = creatorId;
//                memberActivity.UpdateDate = DateTime.Now;
//                memberActivity.UpdatorId = creatorId;
//                memberActivity.MemberActivityTypeId = memberActivityType.Id;
//                memberActivity = facade.AddMemberActivity(memberActivity);
//                if (memberActivity.Id != 0)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public static bool AddActivityOnObject(MemberType memberType, int objectId, int creatorId, ActivityType activityType, IFacade facade)
//        {
//            MemberActivityType memberActivityType = facade.GetMemberActivityType((int)activityType);

//            if (memberActivityType != null && objectId != 0 && creatorId != 0)
//            {
//                MemberActivity memberActivity = new MemberActivity();

//                memberActivity.ActivityOn = (int)memberType;

//                memberActivity.ActivityOnObjectId = objectId;
//                memberActivity.CreateDate = DateTime.Now;
//                memberActivity.CreatorId = creatorId;
//                memberActivity.UpdateDate = DateTime.Now;
//                memberActivity.UpdatorId = creatorId;
//                memberActivity.MemberActivityTypeId = memberActivityType.Id;
//                memberActivity = facade.AddMemberActivity(memberActivity);

//                if (memberActivity.Id != 0)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public static bool AddActivityOnObject(ActivityOnObjectType objectType, int objectId, int creatorId, ActivityType activityType, IFacade facade)
//        {
//            MemberActivityType memberActivityType = facade.GetMemberActivityType((int)activityType);

//            if (memberActivityType != null && objectId != 0 && creatorId != 0)
//            {
//                MemberActivity memberActivity = new MemberActivity();

//                memberActivity.ActivityOn = (int)objectType;

//                memberActivity.ActivityOnObjectId = objectId;
//                memberActivity.CreateDate = DateTime.Now;
//                memberActivity.CreatorId = creatorId;
//                memberActivity.UpdateDate = DateTime.Now;
//                memberActivity.UpdatorId = creatorId;
//                memberActivity.MemberActivityTypeId = memberActivityType.Id;
//                memberActivity = facade.AddMemberActivity(memberActivity);

//                if (memberActivity.Id != 0)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public static bool AddActivityOnObject(ActivityOnObjectType activityOnObjectType, int activityOnObjectId, ActivityOnObjectType activityRelatedObjectType, int activityRelatedObjectId, int creatorId, ActivityType activityType, IFacade facade)
//        {
//            MemberActivityType memberActivityType = facade.GetMemberActivityType((int)activityType);

//            if (memberActivityType != null && activityOnObjectId != 0 && creatorId != 0)
//            {
//                MemberActivity memberActivity = new MemberActivity();

//                memberActivity.ActivityOn = (int)activityOnObjectType;

//                memberActivity.ActivityOnObjectId = activityOnObjectId;
//                memberActivity.CreateDate = DateTime.Now;
//                memberActivity.CreatorId = creatorId;
//                memberActivity.UpdateDate = DateTime.Now;
//                memberActivity.UpdatorId = creatorId;
//                memberActivity.MemberActivityTypeId = memberActivityType.Id;
//                memberActivity.ActivityRelatedObjectType = (int)activityRelatedObjectType;
//                memberActivity.ActivityRelatedObjectId = activityRelatedObjectId;
//                memberActivity = facade.AddMemberActivity(memberActivity);

//                if (memberActivity.Id != 0)
//                {
//                    return true;
//                }
//                else
//                {
//                    return false;
//                }
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public static void PopulateTemplates(ListControl list, int creatorId, int contentCategory, IFacade facade)
//        {
//            list.Items.Clear();
//            ArrayList dataSource = null;
//            if (contentCategory > 0)
//            {
//                dataSource = facade.GetAllContentByContentCategoryAndCreatorId((ContentCategory)contentCategory, creatorId);
//            }
//            else if (creatorId > 0)
//            {
//                dataSource = facade.GetAllContentByCreatorId(creatorId);
//            }
//            else
//            {
//                dataSource = facade.GetAllMasterContent(creatorId);
//            }
//            if (dataSource != null && dataSource.Count > 0)
//            {
//                list.DataSource = dataSource;
//                list.DataTextField = "Name";
//                list.DataValueField = "Id";
//                list.DataBind();
//            }
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateMyTemplates(ListControl list, IFacade facade, int creatorId)
//        {
//            list.Items.Clear();
//            ArrayList dataSource = facade.GetAllContentByCreatorId(creatorId);
//            if (dataSource != null && dataSource.Count > 0)
//            {
//                list.DataSource = dataSource;
//                list.DataTextField = "Name";
//                list.DataValueField = "Id";
//                list.DataBind();
//            }
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateMasterTemplates(ListControl list, IFacade facade, int creatorId)
//        {
//            list.Items.Clear();
//            ArrayList dataSource = facade.GetAllMasterContent(creatorId);
//            if (dataSource != null && dataSource.Count > 0)
//            {
//                for (int i = 0; i < dataSource.Count; i++)
//                {
//                    string obj = dataSource[0].ToString();
//                    list.DataSource = dataSource;
//                    list.DataTextField = "Name";
//                    list.DataValueField = "Id";
//                    list.DataBind();
//                }
//            }
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateSubmissionStage(ListControl list, IFacade facade)
//        {
//            try
//            {
//                list.Items.Clear();
//                list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.MemberSubmissionStage);
//                list.DataTextField = "Name";
//                list.DataValueField = "Id";
//                list.DataBind();
//            }
//            catch { }
//        }

//        public static void PopulateCompanyContactEmails(ListControl list, int companyId, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllCompanyContactByComapnyId(companyId);
//            list.DataTextField = "Email";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateCompanyContactLoginEmails(ListControl list, int companyId, IFacade facade, bool loginOnly)
//        {
//            list.Items.Clear();

//            IList<CompanyContact> contactList = facade.GetAllCompanyContactByComapnyId(companyId);

//            if (contactList != null && contactList.Count > 0)
//            {
//                foreach (CompanyContact contact in contactList)
//                {
//                    if (contact.MemberId > 0)
//                    {
//                        Member member = facade.GetMemberById(contact.MemberId);

//                        if (member != null)
//                        {
//                            MembershipUser user = Membership.GetUser(member.UserId);

//                            if (user != null)
//                            {
//                                list.Items.Add(new ListItem(user.Email, StringHelper.Convert(contact.Id)));
//                            }
//                        }
//                    }
//                    else
//                    {
//                        if (!loginOnly)
//                        {
//                            list.Items.Add(new ListItem(contact.Email, StringHelper.Convert(contact.Id)));
//                        }
//                    }
//                }
//            }

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static string GetMemberSignature(int memberId, IFacade facade)
//        {
//            string signature = string.Empty;
//            MemberSignature memberSignature = facade.GetActiveMemberSignatureByMemberId(memberId);
//            signature = (memberSignature != null ? memberSignature.Signature : string.Empty);
//            return signature;
//        }

//        public static string GetMemberEmail(int memberId, IFacade facade)
//        {
//            Member member = facade.GetMemberById(memberId);
//            return (member != null ? member.PrimaryEmail : string.Empty);
//        }

//        public static string GetMemberSignatureLogo(int memberId, IFacade facade)
//        {
//            string signatureLogo = string.Empty;
//            if (memberId > 0)
//            {
//                MemberSignature memberSignature = facade.GetActiveMemberSignatureByMemberId(memberId);
//                if (memberSignature != null && memberSignature.Logo.IsNotNullOrEmpty())
//                {
//                    signatureLogo = "../" + UrlConstants.MEMBER_DOC_DIR + "/" + memberId.ToString() + "/Signature/" + (memberSignature != null ? memberSignature.Logo : string.Empty);
//                }
//            }
//            return signatureLogo;
//        }

//        public static string GetMemberSignatureLogo(int memberId, string logoPath)
//        {
//            string signatureLogo = string.Empty;
//            if (logoPath.Trim() != string.Empty)
//            {
//                signatureLogo = "../" + UrlConstants.MEMBER_DOC_DIR + "/" + memberId.ToString() + "/Signature/" + logoPath;
//            }
//            return signatureLogo;
//        }

//        public static void PopulateGuestHouse(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGuestHouse();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateGuestHouseDetail(ListControl list, int guestHouseId, IFacade facade)
//        {
//            if (guestHouseId > 0)
//            {
//                list.Items.Clear();

//                list.DataSource = facade.GetAllGuestHouseDetailByGuestHouseId(guestHouseId);
//                try
//                {
//                    list.DataTextField = "SeatNumber";
//                    list.DataValueField = "Id";
//                    list.DataBind();

//                }
//                catch
//                {
//                }
//                if (list.Items.Count > 0)
//                {
//                    list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//                }

//            }

//            //list.Items.Clear();
//            //IList<State> stateList = facade.GetAllStateByCountryId(countryId);
//            //if (stateList != null)
//            //{
//            //    try
//            //    {
//            //        list.DataSource = stateList;
//            //        list.DataTextField = "Name";
//            //        list.DataValueField = "Id";
//            //        list.DataBind();
//            //    }
//            //    catch
//            //    {
//            //    }
//            //}
//            //list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_STATE, "0"));
//        }

//        public static void PopulateCompanyGroup(ListControl list, CompanyGroupType groupType, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllCompanyGroupByGroupType((int)groupType);
//            list.DataTextField = "GroupName";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static string GetQueryStringPrefix(string url)
//        {
//            if (!url.Contains("?"))
//            {
//                return "?";
//            }
//            else
//            {
//                return "&";
//            }
//        }

//        public static string GetClientNameByJobId(int jobId, IFacade facade)
//        {
//            string requisitionClientName = string.Empty;
//            JobPosting jobPosting = facade.GetJobPostingById(jobId);
//            int clientId = 0;
//            if (jobPosting != null)
//            {
//                clientId = (jobPosting.ClientId > 0 ? jobPosting.ClientId : (jobPosting.ClientId2 > 0 ? jobPosting.ClientId2 : (jobPosting.ClientId3 > 0 ? jobPosting.ClientId3 : 0)));
//                if (clientId > 0)
//                {
//                    Company company = facade.GetCompanyById(clientId);
//                    requisitionClientName = (company != null ? company.CompanyName : string.Empty);
//                }
//            }
//            return requisitionClientName;
//        }

//        public static void PopulateTrainingCourseModule(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllTrainingCourseModule();
//            list.DataTextField = "Title";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateTrainingCourse(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllTrainingCourse();
//            list.DataTextField = "Subject";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateHROfferLetter(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetHROfferLetterList();

//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateHROfferLetterWithEmail(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            IList<HROfferLetter> hROfferLetterList = facade.GetAllHROfferLetter();

//            if (hROfferLetterList != null && hROfferLetterList.Count > 0)
//            {
//                foreach (HROfferLetter hROfferLetter in hROfferLetterList)
//                {
//                    Member member = facade.GetMemberById(hROfferLetter.MemberId);

//                    string memberInfo = string.Empty;

//                    if (member != null && member.Id > 0)
//                    {
//                        memberInfo = " " + member.FirstName + " " + member.LastName + " ( " + member.PrimaryEmail + " ) " + hROfferLetter.IssueDate.ToShortDateString();
//                    }

//                    list.Items.Add(new ListItem(hROfferLetter.Position + memberInfo, hROfferLetter.Id.ToString()));
//                }
//            }

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateHROfferLetterByMemberId(ListControl list, IFacade facade, int memberId)
//        {
//            list.Items.Clear();

//            IList<HROfferLetter> hROfferLetterList = facade.GetAllHROfferLetterByMemberId(memberId);

//            if (hROfferLetterList != null && hROfferLetterList.Count > 0)
//            {
//                foreach (HROfferLetter hROfferLetter in hROfferLetterList)
//                {
//                    Member member = facade.GetMemberById(hROfferLetter.MemberId);

//                    string memberEmail = string.Empty;

//                    if (member != null && member.Id > 0)
//                    {
//                        memberEmail = " ( " + member.PrimaryEmail + " )";
//                    }

//                    list.Items.Add(new ListItem(hROfferLetter.Position + memberEmail, hROfferLetter.Id.ToString()));
//                }
//            }

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateHRTemplate(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllHRTemplate();

//            list.DataTextField = "Title";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateJobStatusList(DropDownList ddlJobStatus, int currentJobStatusValue)
//        {
//            ListItem removedItem;
//            ControlHelper.PopulateEnumIntoList(ddlJobStatus, typeof(JobStatus));
//            for (int i = ddlJobStatus.Items.Count - 1; i >= 0; i--)
//            {
//                if (Int32.Parse(ddlJobStatus.Items[i].Value) > 4)
//                {
//                    removedItem = ddlJobStatus.Items.FindByValue(ddlJobStatus.Items[i].Value);
//                    ddlJobStatus.Items.Remove(removedItem);
//                }
//            }
//            removedItem = ddlJobStatus.Items.FindByValue(currentJobStatusValue.ToString());
//            if (removedItem != null)
//            {
//                ddlJobStatus.Items.Remove(removedItem);
//            }
//            ddlJobStatus.Items.Insert(0, new ListItem("Select status", "0"));
//        }

//        public static void PopulateTrainingProgram(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllTrainingProgram();
//            list.DataTextField = "Title";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static string FindDateDiffFrmEndtoStart(DateTime dtEndDate, DateTime dtStartDate)
//        {
//            string result;
//            int[] arr = { 31, 28, 29, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
//            int Year, Day, Month, StartYear, EndYear, StartDay, EndDay, StartMonth, EndMonth;

//            StartYear = dtStartDate.Year;
//            EndYear = dtEndDate.Year;
//            StartMonth = dtStartDate.Month;
//            EndMonth = dtEndDate.Month;
//            string[] Startday = dtStartDate.ToShortDateString().Split('/');
//            string[] Endnday = dtEndDate.ToShortDateString().Split('/');
//            StartDay = (int)Convert.ToInt16(Startday[1]);
//            EndDay = (int)Convert.ToInt16(Endnday[1]);

//            if (EndDay < StartDay)
//            {
//                if (EndMonth == 1)
//                    EndDay += arr[EndMonth - 1];
//                else if (EndMonth == 2)
//                {
//                    if (DateTime.IsLeapYear(EndYear))
//                        EndDay += arr[EndMonth];
//                    else
//                        EndDay += arr[EndMonth - 1];
//                }
//                else
//                    EndDay += arr[EndMonth];

//                EndMonth--;
//            }

//            if (EndMonth < StartMonth)
//            {
//                EndMonth += 12;
//                EndYear--;
//            }

//            Year = EndYear - StartYear;
//            Month = EndMonth - StartMonth;
//            Day = EndDay - StartDay;

//            result = (Year > 0 ? Year.ToString() + " Year(s) " : string.Empty) + (Month > 0 ? Month.ToString() + " Month(s) " : string.Empty) + (Day > 0 ? Day.ToString() + " Day(s)" : string.Empty);

//            return result;
//        }

//        public static void PopulateTrainingProgramTraineeMap(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            IList<TrainingProgramTraineeMap> traineeMapList = facade.GetAllTrainingProgramTraineeMap();
//            if (traineeMapList != null & traineeMapList.Count > 0)
//            {
//                foreach (TrainingProgramTraineeMap traineeMap in traineeMapList)
//                {
//                    list.Items.Add(new ListItem(GetMemberNameById(traineeMap.MemberId, facade), traineeMap.Id.ToString()));
//                }
//            }
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateCompanyColumns(ListControl list)
//        {
//            list.Items.Clear();

//            list.DataSource = new ArrayList{
//                                            new { Key = "CompanyName", Value = "Company Name" },
//                                            new { Key = "Address1", Value = "Address 1" },
//                                            new { Key = "Address2", Value = "Address 2" },
//                                            new { Key = "City", Value = "City" },
//                                            new { Key = "State", Value = "State" },
//                                            new { Key = "Country", Value = "Country" },
//                                            new { Key = "CompanySize", Value = "Company Size" },
//                                            new { Key = "IndustryType", Value = "Industry Type" },
//                                            new { Key = "OwnerType", Value = "Owner Type" },
//                                            new { Key = "TickerSymbol", Value = "Ticker Symbol" },
//                                            new { Key = "OfficePhone", Value = "Office Phone" },
//                                            new { Key = "TollFreePhone", Value = "Toll Free Phone" },
//                                            new { Key = "FaxNumber", Value = "Fax Number" },
//                                            new { Key = "PrimaryEmail", Value = "Primary Email" },
//                                            new { Key = "SecondaryEmail", Value = "Secondary Email" },
//                                            new { Key = "EINNumber", Value = "EIN Number" },
//                                            new { Key = "AnnualRevenue", Value = "Annual Revenue" },
//                                            new { Key = "NumberOfEmployee", Value = "Number of Employee" },
//                                            new { Key = "IsEndClient", Value = "Is End Client" },
//                                            new { Key = "IsTier1Client", Value = "Is Tier1 Client" },
//                                            new { Key = "IsTier2Client", Value = "Is Tier2 Client" },
//                                            new { Key = "IsVolumeHireClient", Value = "Is Volume Hire Client" },
//                                            new { Key = "CreatorId", Value = "CreatorId" },
//                                            new { Key = "UpdatorId", Value = "UpdatorId" },
//                                            new { Key = "CreateDate", Value = "Create Date" },
//                                            new { Key = "UpdateDate", Value = "Update Date" }
//                                        };

//            list.DataTextField = "Value";
//            list.DataValueField = "Key";
//            list.DataBind();
//        }

//        public static void PopulateLeadColumns(ListControl list)
//        {
//            list.Items.Clear();

//            list.DataSource = new ArrayList{
//                                            new { Key = "CompanyName", Value = "Company Name" },
//                                            new { Key = "Description", Value = "Description" },
//                                            new { Key = "LeadPriority", Value = "Lead Priority" },
//                                            new { Key = "SalesProbability", Value = "Sales Probability" },
//                                            new { Key = "ExpectedRevenue", Value = "Expected Revenue" },
//                                            new { Key = "SalesLifeTime", Value = "Sales Life Time" },
//                                            new { Key = "Status", Value = "Status" },                                            
//                                            new { Key = "Source", Value = "Source" },
//                                            new { Key = "CreatorId", Value = "Creator" },
//                                            new { Key = "UpdatorId", Value = "Updator" },
//                                            new { Key = "CreateDate", Value = "Create Date" },
//                                            new { Key = "UpdateDate", Value = "Update Date" }
//                                        };

//            list.DataTextField = "Value";
//            list.DataValueField = "Key";
//            list.DataBind();
//        }

//        public static void SavePdfFromHtmlStringToFile(string filePath, string htmlString)
//        {
//            PdfConverter pdfConverter = new PdfConverter();
//            UnicodeEncoding unicodeEncoding = new UnicodeEncoding();
//            pdfConverter.PdfDocumentOptions.PdfPageSize = PdfPageSize.A4;
//            pdfConverter.PdfDocumentOptions.PdfCompressionLevel = PdfCompressionLevel.Normal;
//            pdfConverter.PdfDocumentOptions.ShowHeader = false;
//            pdfConverter.PdfDocumentOptions.ShowFooter = false;
//            pdfConverter.PdfDocumentOptions.LeftMargin = 15;
//            pdfConverter.PdfDocumentOptions.RightMargin = 5;
//            pdfConverter.PdfDocumentOptions.TopMargin = 15;
//            pdfConverter.PdfDocumentOptions.BottomMargin = 5;
//            pdfConverter.PdfDocumentOptions.GenerateSelectablePdf = true;
//            pdfConverter.PdfDocumentOptions.ShowHeader = false;
//            pdfConverter.PdfHeaderOptions.DrawHeaderLine = false;
//            pdfConverter.PdfFooterOptions.FooterTextColor = Color.Black;
//            pdfConverter.PdfFooterOptions.DrawFooterLine = true;
//            pdfConverter.PdfFooterOptions.PageNumberText = "Page";
//            pdfConverter.PdfFooterOptions.ShowPageNumber = true;
//            pdfConverter.LicenseKey = ContextConstants.EPHTMLTOPDFKEY;
//            pdfConverter.SavePdfFromHtmlStringToFile(htmlString, filePath);

//        }

//        public static string CreateUserName(string userName, IFacade facade)
//        {
//            string memberId = facade.GetNewMermberIdentityId();
//            userName += memberId + "@tps360bulkhire.com";
//            return userName;
//        }
//        public static string CreateUserNameForCompactApplicant(string userName, IFacade facade)
//        {
//            string memberId = facade.GetNewMermberIdentityId();
//            userName += memberId + "@tpsapplicant.com";
//            return userName;
//        }


//        public static void PopulatePayCycle(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.PayCycle);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulatePayScaleFrequency(ListControl list, bool isAddPleaseSelectItem)
//        {
//            list.Items.Clear();
//            ControlHelper.PopulateEnumDescriptionIntoList(list, typeof(TimeSheetDuration), isAddPleaseSelectItem);
//            //list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.PayCycle);
//            //list.DataTextField = "Name";
//            //list.DataValueField = "Id";
//            //list.DataBind();

//            //list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateSalaryType(ListControl list, bool isAddPleaseSelectItem)
//        {
//            list.Items.Clear();
//            ControlHelper.PopulateEnumDescriptionIntoList(list, typeof(PaymentType), isAddPleaseSelectItem);
//        }

//        public static bool IsUserAdmin(string userName)
//        {
//            return Roles.IsUserInRole(userName, ContextConstants.ROLE_ADMIN);
//        }

//        public static void PopulateHolidayCategory(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.HolidayCategory);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static string GetMailFooter(Page currentPage, string receiverEmail, int memberId, bool isRemovalLinkAttached)
//        {
//            SecureUrl unSubscribeUrl = UrlHelper.BuildSecureUrl(ConfigurationManager.AppSettings["WebRoot"].ToString() + "UnsubscribeMe.aspx", string.Empty, UrlConstants.PARAM_MEMBER_ID, memberId.ToString());

//            StringBuilder sb = new StringBuilder();

//            sb.Append(@"<table width='100%' border='0' cellspacing='1' cellpadding='3'>");

//            if (isRemovalLinkAttached && !string.IsNullOrEmpty(receiverEmail) && memberId > 0)
//            {
//                sb.Append(@"<tr>
//                            <td style='font-size: 10px;'>You have been subscribe as");
//                sb.Append(receiverEmail);
//                sb.Append(". If you want to unsubscribe please ");
//                sb.Append("<a href='");
//                sb.Append(unSubscribeUrl.ToString());
//                sb.Append(@"'>Click Here</a></td>
//                          </tr>");
//            }

//            sb.Append(@"              
//                          <tr>
//                            <td style='font-size: 10px;'>Powered by: <a href='" + UrlConstants.GetCurrentDomainName(currentPage) + @"' target='_blank' style='text-decoration: none;'>TalentPlus Software Inc.<sup>0</sup></a></td>
//                          </tr>
//                        </table>");

//            return sb.ToString();
//        }

//        public static string GetAdministratorEmail()
//        {
//            return "faisal@tps360.com";
//        }

//        public static void PopulateVHResumeSource(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            IList<CompanyContact> companyContactList = facade.GetAllCompanyContactByVolumeHireGroup();
//            if (companyContactList != null && companyContactList.Count > 0)
//            {
//                foreach (CompanyContact contact in companyContactList)
//                {
//                    list.Items.Add(new ListItem(contact.FirstName + " " + contact.LastName, contact.Id.ToString()));
//                }
//            }
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateJobPostingVolumeHireByStatus(ListControl list, IFacade facade, int jobStatus)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllJobPostingVolumeHireByStatus(jobStatus);
//            list.DataTextField = "JobTitle";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem("Please select a requisition", "0"));
//        }

//        public static string AlertInfo(string ago)
//        {
//            StringBuilder sb = new StringBuilder();

//            if (!string.IsNullOrEmpty(ago))
//            {
//                sb.Append(ago);
//            }

//            sb.Append(" ago.");

//            return sb.ToString();
//        }

//        public static void PopulatePercentageList(ListControl ddlList)
//        {
//            for (int i = 0; i <= 100; i += 10)
//            {
//                ddlList.Items.Add(new ListItem(i.ToString() + "%", i.ToString()));
//            }
//            ddlList.Items.Insert(0, new ListItem("Please select", "0"));
//        }

//        public static void PopulateNumberList(ListControl ddlList, int lowerLimit, int higherLimit, bool isAddPleaseSelectItem)
//        {
//            for (int i = lowerLimit; i <= higherLimit; i++)
//            {
//                ddlList.Items.Add(new ListItem(i.ToString(), i.ToString()));
//            }
//            if (isAddPleaseSelectItem)
//            {
//                ddlList.Items.Insert(0, new ListItem("Please select", "0"));
//            }
//        }

//        public static void PopulateOfferValidityPeriod(ListControl list)
//        {
//            //list.Items.Clear();
//            //list.Items.Add(new ListItem("7", "7"));
//            //list.Items.Add(new ListItem("15", "15"));
//            //list.Items.Add(new ListItem("30", "30"));
//            //list.Items.Add(new ListItem("45", "45"));
//            //list.Items.Add(new ListItem("60", "60"));
//            //list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//            PopulateNumberList(list, 1, 31, true);
//        }

//        public static void PopulateProvisionPeriod(ListControl list)
//        {
//            //list.Items.Clear();

//            //list.Items.Add(new ListItem("30", "30"));
//            //list.Items.Add(new ListItem("60", "60"));
//            //list.Items.Add(new ListItem("90", "90"));
//            //list.Items.Add(new ListItem("120", "120"));
//            //list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//            PopulateNumberList(list, 1, 31, true);
//        }

//        public static void PopulateWorkRotationPeriod(ListControl list)
//        {
//            list.Items.Clear();

//            list.Items.Add(new ListItem("30", "30"));
//            list.Items.Add(new ListItem("60", "60"));
//            list.Items.Add(new ListItem("90", "90"));
//            list.Items.Add(new ListItem("120", "120"));
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateNoticePeriod(ListControl list)
//        {
//            list.Items.Clear();

//            list.Items.Add(new ListItem("7", "7"));
//            list.Items.Add(new ListItem("15", "15"));
//            list.Items.Add(new ListItem("30", "30"));
//            list.Items.Add(new ListItem("45", "45"));
//            list.Items.Add(new ListItem("60", "60"));
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateLeaveAllowedDays(ListControl list, bool addPleaseSelectItem)
//        {
//            for (int i = 1; i <= 60; i++)
//            {
//                list.Items.Add(new ListItem(i.ToString(), i.ToString()));
//            }
//            if (addPleaseSelectItem)
//            {
//                list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//            }
//        }

//        public static void PopulatePayDayList(ListControl list)
//        {
//            list.Items.Clear();

//            list.Items.Add(new ListItem("Monday", "Monday"));
//            list.Items.Add(new ListItem("1st and 7th of Month", "1st and 7th of Month"));
//            list.Items.Add(new ListItem("1st and 15th of Month", "1st and 15th of Month"));
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulatePositionsByDivisionId(ListControl list, IFacade facade, int divisionId)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllPositionByParentId(divisionId, "");
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateSalaryPaymentTypeList(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.TaxTermType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateSalaryPaymentByList(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.SalaryPaymentBy);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateSalaryPaymentNotification(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.SalaryPaymentNotification);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateNumberOfSale(ListControl list, int index, int lenght, int increment)
//        {
//            for (int i = index; i <= lenght; i = i + increment)
//            {
//                list.Items.Add(new ListItem(i.ToString(), i.ToString()));
//            }

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateAttorneyList(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAttorneyList();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateAttendanceType(ListControl list, IFacade facade, bool addPleaseSelectItem)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllLeaveType();
//            list.DataTextField = "Title";
//            list.DataValueField = "Id";
//            list.DataBind();
//            if (addPleaseSelectItem)
//            {
//                list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//            }
//        }

//        public static void PopulateHolidayCalendar(ListControl list, IFacade facade, bool addPleaseSelectItem)
//        {
//            list.DataSource = facade.GetAllHolidayCalendar();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            if (addPleaseSelectItem)
//            {
//                list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//            }
//        }

//        public static void PopulateLeavePackage(ListControl list, IFacade facade, bool addPleaseSelectItem)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllTemplateMasterByCategory(TemplateCategory.LeavePackage);
//            list.DataTextField = "Title";
//            list.DataValueField = "Id";
//            list.DataBind();
//            if (addPleaseSelectItem)
//            {
//                list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//            }
//        }

//        public static void PopulatePercentage(ListControl list, int defaultSelectedIndex)
//        {
//            for (int i = 0; i <= 100; i++)
//            {
//                list.Items.Add(new ListItem(i.ToString(), i.ToString()));
//            }
//            list.SelectedIndex = defaultSelectedIndex;
//        }

//        public static string ConnectionString
//        {
//            get
//            {
//                return WebConfigurationManager.ConnectionStrings[0].ConnectionString;
//            }
//        }








//        public static BusinessFacade.IFacade CreateFacade()
//        {
//            return new BusinessFacade.Facade();
//        }

//        public static void PopulateCountry(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            IList<Country> stateList = facade.GetAllCountry();
//            list.DataSource = stateList;
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));

//            SiteSetting siteSetting = facade.GetSiteSettingBySettingType((int)SettingType.SiteSetting);
//            if (siteSetting != null)
//            {
//                Hashtable siteSettingTable = ObjectEncrypter.Decrypt<Hashtable>(siteSetting.SettingConfiguration);
//                list.SelectedValue = siteSettingTable[DefaultSiteSetting.Country.ToString()].ToString();
//            }
//        }

//        public static void PopulateCountry(ListControl list, IFacade facade, bool addPleaseSelectItem, bool selectDefaultCountry)
//        {
//            list.Items.Clear();
//            IList<Country> stateList = facade.GetAllCountry();
//            list.DataSource = stateList;
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            if (addPleaseSelectItem)
//            {
//                list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//            }
//            if (selectDefaultCountry)
//            {
//                SiteSetting siteSetting = facade.GetSiteSettingBySettingType((int)SettingType.SiteSetting);
//                if (siteSetting != null)
//                {
//                    Hashtable siteSettingTable = ObjectEncrypter.Decrypt<Hashtable>(siteSetting.SettingConfiguration);
//                    list.SelectedValue = siteSettingTable[DefaultSiteSetting.Country.ToString()].ToString();
//                }
//            }
//        }

//        public static void PopulateBussinessType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            IList<GenericLookup> genericLookup = facade.GetAllGenericLookup();
//            list.DataSource = genericLookup;
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopolateAttorneyName(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAttorneyList();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateState(ListControl list, int countryId, IFacade facade)
//        {
//            list.Items.Clear();
//            IList<State> stateList = facade.GetAllStateByCountryId(countryId);
//            if (stateList != null)
//            {
//                try
//                {
//                    list.DataSource = stateList;
//                    list.DataTextField = "Name";
//                    list.DataValueField = "Id";
//                    list.DataBind();
//                }
//                catch
//                {
//                }
//            }
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT_STATE, "0"));
//        }

//        public static void PopolateColor(ListControl list)
//        {
//            string[] names = Enum.GetNames(typeof(KnownColor));
//            if ((names != null) && (names.Length > 0))
//            {
//                foreach (string name in names)
//                {
//                    string colorCode = ColorTranslator.ToHtml(Color.FromName(name));
//                    ListItem newItem = new ListItem(name, colorCode);
//                    newItem.Attributes.Add("style", "background-color:" + colorCode);
//                    list.Items.Add(newItem);
//                }
//            }
//        }

//        public static void PopulateMyEmployee(ListControl list, int managerId, IFacade facade)
//        {
//            IList<Employee> myEmployeeList = facade.GetAllEmployeeByManagerId(managerId);
//            if (myEmployeeList != null && myEmployeeList.Count > 0)
//            {
//                foreach (Employee emp in myEmployeeList)
//                {
//                    list.Items.Add(new ListItem(emp.FirstName + " " + emp.LastName, emp.Id.ToString()));
//                }
//            }
//        }

//        public static string GetOfferLetterLinks(int memberId, int jobPostingId, IFacade facade, bool isAddCreateOfferLetterLink, bool isAddEditLink)
//        {
//            string offerLetterLinks = string.Empty;
//            IList<HROfferLetter> hrOfferLetterList = null;
//            if (memberId > 0 && jobPostingId > 0)
//            {
//                hrOfferLetterList = facade.GetAllHROfferLetterByMemberIdAndJobPostingId(memberId, jobPostingId);
//            }
//            else if (memberId > 0)
//            {
//                hrOfferLetterList = facade.GetAllHROfferLetterByMemberId(memberId);
//            }
//            if (hrOfferLetterList != null)
//            {
//                foreach (HROfferLetter hrOfferLetter in hrOfferLetterList)
//                {
//                    string urlView = UrlHelper.BuildSecureUrl(UrlConstants.HR.HR_OFFER_VIEWER_PAGE1, string.Empty, UrlConstants.PARAM_HR_OFFER_LETTER_ID, hrOfferLetter.Id.ToString()).ToString();
//                    if (offerLetterLinks.IsNullOrEmpty())
//                    {
//                        offerLetterLinks = "<a href='" + urlView + "' target='_blank'> OfferLetter#" + hrOfferLetter.IssueDate.ToShortDateString() + " ( " + hrOfferLetter.Status.ToString() + " )</a>";
//                    }
//                    else
//                    {
//                        offerLetterLinks = offerLetterLinks + "<br /><a href='" + urlView + "' target='_blank'> OfferLetter#" + hrOfferLetter.IssueDate.ToShortDateString() + "</a>";
//                    }
//                    if (isAddEditLink)
//                    {
//                        string urlEdit = UrlHelper.BuildSecureUrl(UrlConstants.HR.HR_OFFER_LETTER_EDITOR_PAGE, string.Empty, UrlConstants.PARAM_HR_OFFER_LETTER_ID, hrOfferLetter.Id.ToString(), UrlConstants.PARAM_MEMBER_ID, memberId.ToString(), UrlConstants.PARAM_JOB_ID, jobPostingId.ToString(), UrlConstants.PARAM_TAB, "hROfferLetterEditor").ToString();
//                        urlEdit = urlEdit.Replace("~/", "../");
//                        urlEdit = urlEdit.Replace("//", "/");
//                        offerLetterLinks = offerLetterLinks + "&nbsp;&nbsp;<a href='" + urlEdit + "' target='_blank'>Edit</a>";
//                    }
//                }
//            }
//            if (isAddCreateOfferLetterLink)
//            {
//                string urlCreate = UrlHelper.BuildSecureUrl(UrlConstants.HR.HR_OFFER_LETTER_EDITOR_PAGE, string.Empty, UrlConstants.PARAM_MEMBER_ID, memberId.ToString(), UrlConstants.PARAM_JOB_ID, jobPostingId.ToString(), UrlConstants.PARAM_TAB, "hROfferLetterEditor").ToString();
//                urlCreate = urlCreate.Replace("~/", "../");
//                urlCreate = urlCreate.Replace("//", "/");
//                if (offerLetterLinks.IsNullOrEmpty())
//                {
//                    offerLetterLinks = "<a href='" + urlCreate + "' target='_blank'>Create Offer Letter</a>";
//                }
//                else
//                {
//                    offerLetterLinks = offerLetterLinks + "<br /><a href='" + urlCreate + "' target='_blank'>Create Offer Letter</a>";
//                }
//            }
//            return offerLetterLinks;
//        }

//        public static void SelectDefaultCountry(ListControl list)
//        {
//            ControlHelper.SelectListByText(list, "United States");
//        }

//        public static void PopulateParentSiteMap(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllParentCustomSiteMap();
//            list.DataTextField = "Title";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_ROOT, "0"));
//        }

//        public static void PopulateParentSiteMapTree(ListControl list, SiteMapDataSource source)
//        {
//            list.Items.Clear();

//            SiteMapNodeCollection nodeList = source.Provider.GetChildNodes(source.Provider.RootNode);

//            PopulateParentSiteMapTree(list, nodeList, string.Empty);
//        }

//        public static void PopulateParentSiteMapTree(ListControl list, SiteMapNodeCollection nodeList, string prefix)
//        {
//            if (nodeList != null && nodeList.Count > 0)
//            {
//                foreach (SiteMapNode node in nodeList)
//                {
//                    if (string.IsNullOrEmpty(node.Url))
//                    {
//                        list.Items.Add(new ListItem(prefix + node.Title, StringHelper.Convert(node["Id"])));

//                        if (node.HasChildNodes)
//                        {
//                            string oldPrefix = prefix;
//                            prefix = prefix + "----";
//                            PopulateParentSiteMapTree(list, node.ChildNodes, prefix);
//                            prefix = oldPrefix;
//                        }
//                    }
//                }
//            }
//        }

//        public static void PopulateMemberTier(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.PositionTier);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopolateMemberTeam(ListControl list, IFacade facade, int memberId)
//        {
//            list.Items.Clear();
//            List<MemberManager> memberManagerList = (List<MemberManager>)facade.GetAllMemberManagerByMemberId(memberId);
//            List<MemberManager> memberSubordinateList = (List<MemberManager>)facade.GetAllSubordinateByMemberId(memberId);
//            Member member = null;
//            if (memberManagerList != null)
//            {
//                foreach (MemberManager memberManager in memberManagerList)
//                {
//                    member = facade.GetMemberById(memberManager.ManagerId);
//                    if (member != null)
//                    {
//                        list.Items.Add(new ListItem(GetFullName(member.FirstName, member.LastName), member.Id.ToString()));
//                    }
//                }
//            }
//            if (memberSubordinateList != null)
//            {
//                foreach (MemberManager memberManager in memberSubordinateList)
//                {
//                    member = facade.GetMemberById(memberManager.MemberId);
//                    if (member != null)
//                    {
//                        list.Items.Add(new ListItem(GetFullName(member.FirstName, member.LastName), member.Id.ToString()));
//                    }
//                }
//            }
//        }

//        public static void PopulateSubOrdinateTeam(ListControl list, IFacade facade, int memberId)
//        {
//            list.Items.Clear();
//            List<MemberManager> memberSubordinateList = (List<MemberManager>)facade.GetAllSubordinateByMemberId(memberId);
//            if (memberSubordinateList != null)
//            {
//                foreach (MemberManager memberManager in memberSubordinateList)
//                {
//                    Member member = facade.GetMemberById(memberManager.MemberId);
//                    if (member != null)
//                    {
//                        list.Items.Add(new ListItem(GetFullName(member.FirstName, member.LastName), member.Id.ToString()));
//                    }
//                }
//            }
//        }

//        public static void PopolateShareScheduleTeam(ListControl list, IFacade facade, int memberId)
//        {
//            list.Items.Clear();
//            List<MemberSharedSchedule> memberManagerList = (List<MemberSharedSchedule>)facade.GetAllMemberSharedScheduleByMemberId(memberId);
//            if (memberManagerList != null)
//            {
//                foreach (MemberSharedSchedule memberManager in memberManagerList)
//                {
//                    Member member = facade.GetMemberById(memberManager.SharingMemberId);
//                    if (member != null)
//                    {
//                        list.Items.Add(new ListItem(GetFullName(member.FirstName, member.LastName), member.Id.ToString()));
//                    }
//                }
//            }
//        }

//        public static void PopulateResourceGroup(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.ResourceGroup);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateTimeSheetList(ListControl list, IFacade facade, int MemberId)
//        {
//            list.Items.Clear();
//            list.DataSource = facade.GetMemberTimeSheetByMemberId(MemberId);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateCustomRole(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllCustomRole();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateOfficeType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.OfficeType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateBranchOfficeType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.BranchOfficeType);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            //list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateGuestHouseType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.GuestHouse);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
//        }

//        public static void PopulateExpenseCategory(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.ExpenseCategory);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            //list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//            list.Items.Insert(0, new ListItem("Please select", "0"));
//        }

//        public static void PopulateCampaignStatus(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.CampaignStatus);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateColdCallScript(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllCampaignColdCallScript();
//            list.DataTextField = "Subject";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateContent(ListControl list, IFacade facade, int contentCategory)
//        {
//            list.Items.Clear();

//            IList<Bay.ERP.Common.BusinessEntities.Content> contentList = null;

//            if (contentCategory == 0)
//            {
//                contentList = facade.GetAllContent();
//            }
//            else
//            {
//                contentList = facade.GetAllContentByCategory((ContentCategory)contentCategory);
//            }

//            list.DataSource = contentList;
//            list.DataTextField = "Subject";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateMemberProduct(ListControl list, IFacade facade, int memberId)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllProductByMemberId(memberId);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateProduct(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllProduct();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateBank(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllBank();
//            list.DataTextField = "BankName";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateCashHolder(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllCashHolder();
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateCultureCode(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            list.DataSource = facade.GetAllGenericLookupByLookupType(LookupType.CultureCode);
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }

//        public static void PopulateLookupType(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();

//            Type lookupType = typeof(LookupType);

//            ControlHelper.PopulateEnumIntoList(list, lookupType);

//            list.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);
//        }
//        //public static void PopulateOvallStatusType(DropDownList ddlOvallStatus)
//        //{

//        //    ControlHelper.PopulateEnumIntoList(ddlOvallStatus, typeof(JobStatus));
//        //    ddlOvallStatus.Items.Insert(0, UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT);

//        //}






//        public static Control FindControlRecursive(Control root, string Id)
//        {
//            if (root.ID == Id)
//                return root;

//            foreach (Control control in root.Controls)
//            {
//                Control foundControl = FindControlRecursive(control, Id);

//                if (foundControl != null)

//                    return foundControl;
//            }

//            return null;
//        }

//        public static void LoadAllControlState(HttpRequest request, Control container)
//        {
//            foreach (string key in request.Form.AllKeys)
//            {
//                string value = string.Empty, nameOfControl = string.Empty;
//                int lastPos = 0;
//                if (key != null)
//                {
//                    value = request.Form[key];
//                    lastPos = key.LastIndexOf('$');
//                    nameOfControl = key;

//                    if (lastPos > 0) nameOfControl = key.Substring(lastPos + 1);

//                    Control c = FindControlRecursive(container, nameOfControl);
//                    if (c != null)
//                    {
//                        if (c is DropDownList)
//                        {
//                            (c as DropDownList).SelectedValue = value;
//                        }
//                        else if (c is ListBox)
//                        {
//                            ListBox cntrlListBox = (ListBox)c;
//                            string[] selectedValues = value.Split(new string[] { "," }, StringSplitOptions.RemoveEmptyEntries);
//                            foreach (string selectedValue in selectedValues)
//                            {
//                                ListItem lstSelectedItem = cntrlListBox.Items.FindByValue(selectedValue);
//                                if (lstSelectedItem != null)
//                                {
//                                    lstSelectedItem.Selected = true;
//                                }
//                            }
//                        }
//                        else if (c is TextBox)
//                        {
//                            (c as TextBox).Text = value;
//                        }
//                        else if (c is Label)
//                        {
//                            (c as Label).Text = value;
//                        }
//                        else if (c is RadioButton)
//                        {
//                            (c as CheckBox).Checked = (value != "" && value != "off" && value != "false");
//                        }
//                        else if (c is RadioButtonList)
//                        {
//                        }
//                        else if (c is CheckBox)
//                        {
//                            (c as CheckBox).Checked = (value != "" && value != "off" && value != "false");
//                        }
//                        //else if (c is CheckBoxList)
//                        //{
//                        //    // (c as CheckBox).Checked = (value != "" && value != "off" && value != "false");

//                        //    //for (int i = 0; i < c.Controls.Count; i++)
//                        //    //{                                

//                        //    //}
//                        //}
//                    }
//                }
//            }
//        }

//        public static bool IsDeleteButtonVisible(bool isAdmin, bool isCareerPortal)
//        {
//            if (isAdmin || isCareerPortal)
//            {
//                return true;
//            }
//            else
//            {
//                return false;
//            }
//        }

//        public static string GetResumeServiceUrl(Page page)
//        {
//            string url = page.ResolveUrl("~/ResumeParserService.asmx");
//            string port = string.Empty;
//            if (HttpContext.Current.Request.Url.Port != 0)
//            {
//                port = ":" + HttpContext.Current.Request.Url.Port;
//            }
//            url = HttpContext.Current.Request.Url.Scheme + "://" + HttpContext.Current.Request.Url.Host + port + url;
//            return url;
//        }

//        public static void PopulateEmployeeByManagerId(ListBox list, int managerId, IFacade facade)
//        {
//            IList<Employee> myEmployeeList = facade.GetAllEmployeeByManagerId(managerId);
//            if (myEmployeeList != null && myEmployeeList.Count > 0)
//            {
//                foreach (Employee emp in myEmployeeList)
//                {
//                    list.Items.Add(new ListItem(emp.FirstName + " " + emp.LastName, emp.Id.ToString()));
//                }
//            }
//        }

//        public static void PopulateEmployeeNameByStatus(ListBox list, MemberStatus memberStatus, IFacade facade)
//        {
//            list.Items.Clear();
//            if (memberStatus == MemberStatus.Suspend)
//            {
//                list.DataSource = facade.GetAllFormerEmployeeName();
//            }
//            else
//            {
//                list.DataSource = facade.GetAllCurrentEmployeeName();
//            }
//            list.DataTextField = "Name";
//            list.DataValueField = "Id";
//            list.DataBind();
//        }

//        public static void PopulateTeamManagerByManagerId(ListBox list, IFacade facade)
//        {
//            list.Items.Clear();
//            IList<OnBoardingTeam> onBoardingTeamList = facade.GetAllOnBoardingTeam();
//            if (onBoardingTeamList != null)
//            {
//                foreach (OnBoardingTeam onboardingTeam in onBoardingTeamList)
//                {
//                    Member member = facade.GetMemberById(onboardingTeam.MemberId);
//                    if (member != null)
//                    {
//                        list.Items.Add(new ListItem(member.FirstName + " " + member.LastName, onboardingTeam.Id.ToString()));
//                    }
//                }
//            }
//        }

//        public static int GetKeywordOccuranceCountByMemberId(string keyword, int id, IFacade facade)
//        {
//            return facade.GetKeywordCountByMemberId(keyword, id);
//        }

//        public static decimal GetDecimalFromString(string strValue)
//        {
//            decimal decValue = 0;
//            try
//            {
//                if (strValue.Trim() != string.Empty)
//                {
//                    strValue = strValue.Replace(",", "");
//                    //Regex expReg = new Regex(@"[0-9]*?(\.)?([0-9]*)", RegexOptions.IgnoreCase);
//                    Regex expReg = new Regex(@"(\d*)?(\.)?(\d*)", RegexOptions.IgnoreCase);
//                    MatchCollection currentMatchs = expReg.Matches(strValue);
//                    for (int index = 0; index < currentMatchs.Count; index++)
//                    {
//                        if (currentMatchs[index].Value.Trim() != string.Empty)
//                        {
//                            decValue = Convert.ToDecimal(currentMatchs[index].Value);
//                            break;
//                        }
//                    }
//                }
//            }
//            catch
//            {
//                decValue = 0;
//            }
//            return decValue;
//        }

//        public static void PopulateOrganizationBranchOffice(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            IList<OrganizationBranchOffice> officeList = facade.GetAllOrganizationBranchOffice();
//            if (officeList != null)
//            {
//                foreach (OrganizationBranchOffice office in officeList)
//                {
//                    list.Items.Add(new ListItem(office.Name, office.Id.ToString()));
//                }
//            }
//        }

//        public static void PopulatePayScale(ListControl list, IFacade facade)
//        {
//            list.Items.Clear();
//            IList<PayScale> payScaleList = facade.GetAllPayScale();
//            if (payScaleList != null && payScaleList.Count > 0)
//            {
//                list.DataSource = payScaleList;
//                list.DataTextField = "Name";
//                list.DataValueField = "Id";
//                list.DataBind();
//            }
//        }

//        public static string GetEmployeePosition(int employeeId, string currentPosition, IFacade facade)
//        {
//            IList<MemberOrganizationFunctionalityCategoryMap> mofcmList = facade.GetAllMemberOrganizationFunctionalityCategoryMapByMemberId(employeeId);
//            if (mofcmList != null)
//            {
//                Position p = facade.GetPositionById(mofcmList[0].PositionId);
//                if (p != null)
//                {
//                    return p.Name;
//                }
//            }
//            return currentPosition;
//        }

//        public static void SetGlobalVariable(string name, string value, int creatorId, IFacade facade)
//        {
//            GlobalVariable globalVariable = new GlobalVariable();
//            globalVariable.Name = name;
//            globalVariable.Value = value;
//            globalVariable.CreatorId = creatorId;
//            facade.AddGlobalVariable(globalVariable);
//        }

//        public static void PoppulateCompensationPackageList(ListControl list, IFacade facade)
//        {
//            IList<CompensationPackage> compensationPackageList = facade.GetAllCompensationPackage();
//            if (compensationPackageList != null && compensationPackageList.Count > 0)
//            {
//                foreach (CompensationPackage compensationPackage in compensationPackageList)
//                    list.Items.Add(new ListItem(compensationPackage.Name, compensationPackage.Id.ToString()));
//            }
//        }

//        public static string CreateFile(string fileNameOrPath, string fileContent, bool isTemporary)
//        {
//            string path = string.Empty;
//            if (isTemporary)
//            {
//                path = UrlConstants.TemporaryDirectory;
//                if (!Directory.Exists(path))
//                {
//                    Directory.CreateDirectory(path);
//                }
//            }
//            path = path + "\\" + fileNameOrPath;
//            using (TextWriter tw = new StreamWriter(path))
//            {
//                tw.Write(fileContent);
//            }
//            return path;
//        }

//        public static string CreateZipFile(ListItemCollection lstFiles, string zipFileName, IFacade facade)
//        {
//            string zipFilePath = string.Empty;
//            if (lstFiles.Count > 0)
//            {
//                zipFilePath = UrlConstants.TemporaryDirectory;
//                if (!Directory.Exists(zipFilePath))
//                {
//                    Directory.CreateDirectory(zipFilePath);
//                }
//                zipFilePath = zipFilePath + "\\" + zipFileName + ".zip";
//                try
//                {
//                    File.Delete(zipFilePath);
//                }
//                catch
//                {
//                    zipFilePath = zipFilePath.Replace(zipFileName, zipFileName + "1");
//                }
//                using (ZipFile newZipFile = new ZipFile(zipFilePath))
//                {
//                    foreach (ListItem lstCurrentFile in lstFiles)
//                    {
//                        string pathUploadedFile = lstCurrentFile.Value;
//                        if (File.Exists(pathUploadedFile))
//                        {
//                            if (pathUploadedFile.IndexOf("EmailDocuments") >= 0)
//                            {
//                                newZipFile.AddFile(pathUploadedFile, "OtherDocument");
//                            }
//                            else
//                            {
//                                //Find member name from member document path
//                                string memberName = string.Empty;
//                                int memberIndex = pathUploadedFile.IndexOf("\\Member\\");
//                                if (memberIndex != -1)
//                                {
//                                    memberIndex = memberIndex + "\\Member\\".Length;
//                                    int memberIdLastIndex = pathUploadedFile.IndexOf("\\", memberIndex);
//                                    if (memberIdLastIndex != -1 && memberIdLastIndex > memberIndex)
//                                    {
//                                        string strMemberId = pathUploadedFile.Substring(memberIndex, memberIdLastIndex - memberIndex);
//                                        int memberId = strMemberId.ToInteger();
//                                        if (memberId > 0)
//                                        {
//                                            memberName = GetMemberNameById(memberId, facade);
//                                        }
//                                    }
//                                }
//                                if (memberName.IsNotNullOrEmpty())
//                                {
//                                    newZipFile.AddFile(pathUploadedFile, memberName);
//                                }
//                                else
//                                {
//                                    newZipFile.AddFile(pathUploadedFile, zipFileName);
//                                }
//                            }
//                        }
//                    }
//                    newZipFile.Save();
//                }

//            }
//            return zipFilePath;
//        }

//        public static decimal GetFileSize(string filePath)
//        {
//            if (File.Exists(filePath))
//            {
//                FileInfo newFileInfo = new FileInfo(filePath);
//                return Decimal.Divide(newFileInfo.Length, 1048576);
//            }
//            else
//            {
//                return 0;
//            }
//        }

//        public static string FillHRTemplate(string templateBody, int memberId, IFacade facade,bool isOfferLetter)
//        {
//            StringBuilder sb = new StringBuilder(templateBody);
//            if (memberId > 0)
//            {
//                    MemberGroupType memberRole = facade.GetMemberRoleNameById(memberId);
//                    if (memberRole == MemberGroupType.Candidate)
//                    {
//                        Candidate candidate = facade.GetCandidateById(memberId);
//                        if (candidate != null)
//                        {
//                            sb.Replace("[[Candidate.HomePhone]]", candidate.HomePhone);
//                            sb.Replace("[[Candidate.CurrentCity]]", candidate.CurrentCity);
//                            sb.Replace("[[Candidate.StateName]]", candidate.StateName);
//                            sb.Replace("[[Candidate.StateCode]]", candidate.StateCode);
//                            sb.Replace("[[Candidate.Remarks]]", candidate.Remarks);
//                            sb.Replace("[[Candidate.Objective]]", candidate.Objective);
//                            sb.Replace("[[Candidate.Summary]]", candidate.Summary);
//                            sb.Replace("[[Candidate.Skills]]", candidate.Skills);

//                            sb.Replace("[[Candidate.MemberCode]]", candidate.MemberCode);
//                            sb.Replace("[[Candidate.FirstName]]", candidate.FirstName);
//                            sb.Replace("[[Candidate.MiddleName]]", candidate.MiddleName);
//                            sb.Replace("[[Candidate.LastName]]", candidate.LastName);
//                            sb.Replace("[[Candidate.NickName]]", candidate.NickName);
//                            sb.Replace("[[Candidate.DateOfBirth]]", candidate.DateOfBirth.ToShortDateString());
//                            sb.Replace("[[Candidate.PermanentAddressLine1]]", candidate.PermanentAddressLine1);
//                            sb.Replace("[[Candidate.PermanentAddressLine2]]", candidate.PermanentAddressLine2);
//                            sb.Replace("[[Candidate.PermanentCity]]", candidate.PermanentCity);
//                            sb.Replace("[[Candidate.PermanentStateId]]", candidate.PermanentStateId.ToString());
//                            sb.Replace("[[Candidate.PermanentCountryId]]", candidate.PermanentCountryId.ToString());
//                            sb.Replace("[[Candidate.PermanentPhone]]", candidate.PermanentPhone);
//                            sb.Replace("[[Candidate.PermanentPhoneExt]]", candidate.PermanentPhoneExt);
//                            sb.Replace("[[Candidate.PermanentMobile]]", candidate.PermanentMobile);
//                            sb.Replace("[[Candidate.PrimaryEmail]]", candidate.PrimaryEmail);
//                            sb.Replace("[[Candidate.AlternateEmail]]", candidate.AlternateEmail);
//                            sb.Replace("[[Candidate.PrimaryPhone]]", candidate.PrimaryPhone);
//                            sb.Replace("[[Candidate.PrimaryPhoneExtension]]", candidate.PrimaryPhoneExtension);
//                            sb.Replace("[[Candidate.CellPhone]]", candidate.CellPhone);
//                            sb.Replace("[[Candidate.AutomatedEmailStatus]]", candidate.AutomatedEmailStatus.ToString());
//                            sb.Replace("[[Candidate.ResumeSource]]", candidate.ResumeSource.ToString());
//                            sb.Replace("[[Candidate.Status]]", candidate.Status.ToString());
//                            sb.Replace("[[Candidate.IsRemoved]]", candidate.IsRemoved.ToString());
//                            sb.Replace("[[Candidate.UserId]]", candidate.UserId.ToString());
//                        }
//                    }
//                    else if (memberRole == MemberGroupType.Consultant)
//                    {
//                        Consultant consultant = facade.GetConsultantById(memberId);
//                        if (consultant != null)
//                        {
//                            sb.Replace("[[Consultant.HomePhone]]", consultant.HomePhone);
//                            sb.Replace("[[Consultant.CurrentCity]]", consultant.CurrentCity);
//                            sb.Replace("[[Consultant.StateName]]", consultant.StateName);
//                            sb.Replace("[[Consultant.StateCode]]", consultant.StateCode);
//                            sb.Replace("[[Consultant.CurrentPosition]]", consultant.CurrentPosition);
//                            sb.Replace("[[Consultant.SystemAccess]]", consultant.SystemAccess);

//                            sb.Replace("[[Consultant.MemberCode]]", consultant.MemberCode);
//                            sb.Replace("[[Consultant.FirstName]]", consultant.FirstName);
//                            sb.Replace("[[Consultant.MiddleName]]", consultant.MiddleName);
//                            sb.Replace("[[Consultant.LastName]]", consultant.LastName);
//                            sb.Replace("[[Consultant.NickName]]", consultant.NickName);
//                            sb.Replace("[[Consultant.DateOfBirth]]", consultant.DateOfBirth.ToShortDateString());
//                            sb.Replace("[[Consultant.PermanentAddressLine1]]", consultant.PermanentAddressLine1);
//                            sb.Replace("[[Consultant.PermanentAddressLine2]]", consultant.PermanentAddressLine2);
//                            sb.Replace("[[Consultant.PermanentCity]]", consultant.PermanentCity);
//                            sb.Replace("[[Consultant.PermanentStateId]]", consultant.PermanentStateId.ToString());
//                            sb.Replace("[[Consultant.PermanentCountryId]]", consultant.PermanentCountryId.ToString());
//                            sb.Replace("[[Consultant.PermanentPhone]]", consultant.PermanentPhone);
//                            sb.Replace("[[Consultant.PermanentPhoneExt]]", consultant.PermanentPhoneExt);
//                            sb.Replace("[[Consultant.PermanentMobile]]", consultant.PermanentMobile);
//                            sb.Replace("[[Consultant.PrimaryEmail]]", consultant.PrimaryEmail);
//                            sb.Replace("[[Consultant.AlternateEmail]]", consultant.AlternateEmail);
//                            sb.Replace("[[Consultant.PrimaryPhone]]", consultant.PrimaryPhone);
//                            sb.Replace("[[Consultant.PrimaryPhoneExtension]]", consultant.PrimaryPhoneExtension);
//                            sb.Replace("[[Consultant.CellPhone]]", consultant.CellPhone);
//                            sb.Replace("[[Consultant.AutomatedEmailStatus]]", consultant.AutomatedEmailStatus.ToString());
//                            sb.Replace("[[Consultant.ResumeSource]]", consultant.ResumeSource.ToString());
//                            sb.Replace("[[Consultant.Status]]", consultant.Status.ToString());
//                            sb.Replace("[[Consultant.IsRemoved]]", consultant.IsRemoved.ToString());
//                            sb.Replace("[[Consultant.UserId]]", consultant.UserId.ToString());
//                        }
//                    }
//                    else if (memberRole == MemberGroupType.Employee)
//                    {
//                        Employee employee = facade.GetEmployeeById(memberId);
//                        if (employee != null)
//                        {
//                            if (isOfferLetter)
//                            {
//                                sb.Replace("[[Candidate.HomePhone]]", employee.HomePhone);
//                                sb.Replace("[[Candidate.CurrentCity]]", employee.CurrentCity);
//                                sb.Replace("[[Candidate.StateName]]", employee.StateName);
//                                sb.Replace("[[Candidate.StateCode]]", employee.StateCode);
//                                sb.Replace("[[Candidate.Remarks]]", employee.Remarks);
//                                sb.Replace("[[Candidate.Objective]]", employee.Objective);
//                                sb.Replace("[[Candidate.Summary]]", employee.Summary);
//                                sb.Replace("[[Candidate.Skills]]", employee.Skills);

//                                sb.Replace("[[Candidate.MemberCode]]", employee.MemberCode);
//                                sb.Replace("[[Candidate.FirstName]]", employee.FirstName);
//                                sb.Replace("[[Candidate.MiddleName]]", employee.MiddleName);
//                                sb.Replace("[[Candidate.LastName]]", employee.LastName);
//                                sb.Replace("[[Candidate.NickName]]", employee.NickName);
//                                sb.Replace("[[Candidate.DateOfBirth]]", employee.DateOfBirth.ToShortDateString());
//                                sb.Replace("[[Candidate.PermanentAddressLine1]]", employee.PermanentAddressLine1);
//                                sb.Replace("[[Candidate.PermanentAddressLine2]]", employee.PermanentAddressLine2);
//                                sb.Replace("[[Candidate.PermanentCity]]", employee.PermanentCity);
//                                sb.Replace("[[Candidate.PermanentStateId]]", employee.PermanentStateId.ToString());
//                                sb.Replace("[[Candidate.PermanentCountryId]]", employee.PermanentCountryId.ToString());
//                                sb.Replace("[[Candidate.PermanentPhone]]", employee.PermanentPhone);
//                                sb.Replace("[[Candidate.PermanentPhoneExt]]", employee.PermanentPhoneExt);
//                                sb.Replace("[[Candidate.PermanentMobile]]", employee.PermanentMobile);
//                                sb.Replace("[[Candidate.PrimaryEmail]]", employee.PrimaryEmail);
//                                sb.Replace("[[Candidate.AlternateEmail]]", employee.AlternateEmail);
//                                sb.Replace("[[Candidate.PrimaryPhone]]", employee.PrimaryPhone);
//                                sb.Replace("[[Candidate.PrimaryPhoneExtension]]", employee.PrimaryPhoneExtension);
//                                sb.Replace("[[Candidate.CellPhone]]", employee.CellPhone);
//                                sb.Replace("[[Candidate.AutomatedEmailStatus]]", employee.AutomatedEmailStatus.ToString());
//                                sb.Replace("[[Candidate.ResumeSource]]", employee.ResumeSource.ToString());
//                                sb.Replace("[[Candidate.Status]]", employee.Status.ToString());
//                                sb.Replace("[[Candidate.IsRemoved]]", employee.IsRemoved.ToString());
//                                sb.Replace("[[Candidate.UserId]]", employee.UserId.ToString());
//                            }
//                            else
//                            {
//                                sb.Replace("[[Employee.HomePhone]]", employee.HomePhone);
//                                sb.Replace("[[Employee.CurrentCity]]", employee.CurrentCity);
//                                sb.Replace("[[Employee.StateName]]", employee.StateName);
//                                sb.Replace("[[Employee.StateCode]]", employee.StateCode);
//                                sb.Replace("[[Employee.OfficeCity]]", employee.OfficeCity);
//                                sb.Replace("[[Employee.CurrentPosition]]", employee.CurrentPosition);
//                                sb.Replace("[[Employee.SystemAccess]]", employee.SystemAccess);


//                                sb.Replace("[[Employee.MemberCode]]", employee.MemberCode);
//                                sb.Replace("[[Employee.FirstName]]", employee.FirstName);
//                                sb.Replace("[[Employee.MiddleName]]", employee.MiddleName);
//                                sb.Replace("[[Employee.LastName]]", employee.LastName);
//                                sb.Replace("[[Employee.NickName]]", employee.NickName);
//                                sb.Replace("[[Employee.DateOfBirth]]", employee.DateOfBirth.ToShortDateString());
//                                sb.Replace("[[Employee.PermanentAddressLine1]]", employee.PermanentAddressLine1);
//                                sb.Replace("[[Employee.PermanentAddressLine2]]", employee.PermanentAddressLine2);
//                                sb.Replace("[[Employee.PermanentCity]]", employee.PermanentCity);
//                                sb.Replace("[[Employee.PermanentStateId]]", employee.PermanentStateId.ToString());
//                                sb.Replace("[[Employee.PermanentCountryId]]", employee.PermanentCountryId.ToString());
//                                sb.Replace("[[Employee.PermanentPhone]]", employee.PermanentPhone);
//                                sb.Replace("[[Employee.PermanentPhoneExt]]", employee.PermanentPhoneExt);
//                                sb.Replace("[[Employee.PermanentMobile]]", employee.PermanentMobile);
//                                sb.Replace("[[Employee.PrimaryEmail]]", employee.PrimaryEmail);
//                                sb.Replace("[[Employee.AlternateEmail]]", employee.AlternateEmail);
//                                sb.Replace("[[Employee.PrimaryPhone]]", employee.PrimaryPhone);
//                                sb.Replace("[[Employee.PrimaryPhoneExtension]]", employee.PrimaryPhoneExtension);
//                                sb.Replace("[[Employee.CellPhone]]", employee.CellPhone);
//                                sb.Replace("[[Employee.AutomatedEmailStatus]]", employee.AutomatedEmailStatus.ToString());
//                                sb.Replace("[[Employee.ResumeSource]]", employee.ResumeSource.ToString());
//                                sb.Replace("[[Employee.Status]]", employee.Status.ToString());
//                                sb.Replace("[[Employee.IsRemoved]]", employee.IsRemoved.ToString());
//                                sb.Replace("[[Employee.UserId]]", employee.UserId.ToString());
//                            }
//                        }
//                    }
//                    else
//                    {
//                        Member member = facade.GetMemberById(memberId);
//                        if (member != null)
//                        {
//                            sb.Replace("[[Member.MemberCode]]", member.MemberCode);
//                            sb.Replace("[[Member.FirstName]]", member.FirstName);
//                            sb.Replace("[[Member.MiddleName]]", member.MiddleName);
//                            sb.Replace("[[Member.LastName]]", member.LastName);
//                            sb.Replace("[[Member.NickName]]", member.NickName);
//                            sb.Replace("[[Member.DateOfBirth]]", member.DateOfBirth.ToShortDateString());
//                            sb.Replace("[[Member.PermanentAddressLine1]]", member.PermanentAddressLine1);
//                            sb.Replace("[[Member.PermanentAddressLine2]]", member.PermanentAddressLine2);
//                            sb.Replace("[[Member.PermanentCity]]", member.PermanentCity);
//                            sb.Replace("[[Member.PermanentStateId]]", member.PermanentStateId.ToString());
//                            sb.Replace("[[Member.PermanentCountryId]]", member.PermanentCountryId.ToString());
//                            sb.Replace("[[Member.PermanentPhone]]", member.PermanentPhone);
//                            sb.Replace("[[Member.PermanentPhoneExt]]", member.PermanentPhoneExt);
//                            sb.Replace("[[Member.PermanentMobile]]", member.PermanentMobile);
//                            sb.Replace("[[Member.PrimaryEmail]]", member.PrimaryEmail);
//                            sb.Replace("[[Member.AlternateEmail]]", member.AlternateEmail);
//                            sb.Replace("[[Member.PrimaryPhone]]", member.PrimaryPhone);
//                            sb.Replace("[[Member.PrimaryPhoneExtension]]", member.PrimaryPhoneExtension);
//                            sb.Replace("[[Member.CellPhone]]", member.CellPhone);
//                            sb.Replace("[[Member.AutomatedEmailStatus]]", member.AutomatedEmailStatus.ToString());
//                            sb.Replace("[[Member.ResumeSource]]", member.ResumeSource.ToString());
//                            sb.Replace("[[Member.Status]]", member.Status.ToString());
//                            sb.Replace("[[Member.IsRemoved]]", member.IsRemoved.ToString());
//                            sb.Replace("[[Member.UserId]]", member.UserId.ToString());

//                            MemberExtendedInformation memberExtendedInformation = facade.GetMemberExtendedInformationByMemberId(member.Id);

//                            if (memberExtendedInformation != null)
//                            {
//                                sb.Replace("[[Member.Designation]]", memberExtendedInformation.CurrentPosition.ToString());
//                                sb.Replace("[[Member.LastEmployer]]", memberExtendedInformation.LastEmployer.ToString());
//                            }
//                        }
//                    }
//            }
//            return sb.ToString();
//        }

//        public static string FillHROfferLetter(HROfferLetter hROfferLetter, IFacade facade, bool flagAcceptRejectlink,int creatorId)
//        {
//            string offerLetterTemplate = File.ReadAllText(HttpContext.Current.Server.MapPath("~/MailTemplate/OfferLetterTemplate.htm"));
//            StringBuilder stringBuilder = new StringBuilder();

//            string offerLetterBody = FillHRTemplate(offerLetterTemplate, hROfferLetter.MemberId, facade,true);
//            stringBuilder.Append(offerLetterBody);
//            stringBuilder.Replace("[[HROfferLetter.Position]]", hROfferLetter.Position.ToString());
//            stringBuilder.Replace("[[HROfferLetter.Department]]", hROfferLetter.Department.ToString());
//            stringBuilder.Replace("[[HROfferLetter.WorkDescription]]", hROfferLetter.WorkDescription.ToString());
//            stringBuilder.Replace("[[HROfferLetter.ContractType]]", Enum.GetName(typeof(ContractType), hROfferLetter.ContractType));
//            stringBuilder.Replace("[[HROfferLetter.SupervisorName]]", hROfferLetter.SupervisorName.ToString());
//            stringBuilder.Replace("[[HROfferLetter.SuperVisorDesignation]]", hROfferLetter.SuperVisorDesignation.ToString());
//            stringBuilder.Replace("[[HROfferLetter.WorkLocation]]", hROfferLetter.WorkLocation.ToString());
//            stringBuilder.Replace("[[HROfferLetter.WorkPresentAddress]]", hROfferLetter.WorkPresentAddress.ToString());
//            stringBuilder.Replace("[[HROfferLetter.WorkPermanentAddress]]", hROfferLetter.WorkPermanentAddress.ToString());
//            stringBuilder.Replace("[[HROfferLetter.IssueDate]]", hROfferLetter.IssueDate.ToShortDateString());
//            stringBuilder.Replace("[[HROfferLetter.JoiningDate]]", hROfferLetter.JoiningDate.ToLongDateString());
//            stringBuilder.Replace("[[HROfferLetter.EndingDate]]", hROfferLetter.EndingDate.ToShortDateString());
//            stringBuilder.Replace("[[HROfferLetter.AppraisalDate]]", hROfferLetter.AppraisalDate.ToShortDateString());
//            stringBuilder.Replace("[[HROfferLetter.AppraisalReminderDate]]", hROfferLetter.AppraisalReminderDate.ToShortDateString());
//            stringBuilder.Replace("[[HROfferLetter.ProbationPeriodExpiryDate]]", hROfferLetter.ProbationPeriodExpiryDate.ToShortDateString());
//            stringBuilder.Replace("[[HROfferLetter.ProbationPeriodDateType]]", EnumHelper.GetDescription(hROfferLetter.ProbationPeriodDateType));
//            stringBuilder.Replace("[[HROfferLetter.OfferValidityPeriod]]", hROfferLetter.OfferValidityPeriod.ToString());
//            stringBuilder.Replace("[[HROfferLetter.DailyWorkingHours]]", hROfferLetter.DailyWorkingHours.ToString());
//            stringBuilder.Replace("[[HROfferLetter.WeeklyWorkingHours]]", hROfferLetter.WeeklyWorkingHours.ToString());
//            stringBuilder.Replace("[[HROfferLetter.MonthlyWorkingHours]]", hROfferLetter.MonthlyWorkingHours.ToString());
//            stringBuilder.Replace("[[HROfferLetter.WeeklyWorkingDays]]", hROfferLetter.WeeklyWorkingDays);
//            stringBuilder.Replace("[[HROfferLetter.WorkRotationPeriod]]", hROfferLetter.WorkRotationPeriod.ToString());
//            stringBuilder.Replace("[[HROfferLetter.ProvisionPeriod]]", hROfferLetter.ProvisionPeriod.ToString());
//            stringBuilder.Replace("[[HROfferLetter.NoticePeriod]]", hROfferLetter.NoticePeriod.ToString());
//            stringBuilder.Replace("[[HROfferLetter.SalaryType]]", EnumHelper.GetDescription((PaymentType)hROfferLetter.SalaryType));
//            stringBuilder.Replace("[[HROfferLetter.BaseSalary]]", hROfferLetter.BaseSalary.ToString());
//            stringBuilder.Replace("[[HROfferLetter.BaseSalaryInWords]]", hROfferLetter.BaseSalaryInWords.ToString());

//            if (hROfferLetter.BaseSalaryCurrencyLookupId > 0)
//            {
//                GenericLookup baseSalaryCurrencyLookup = facade.GetGenericLookupById(hROfferLetter.BaseSalaryCurrencyLookupId);

//                if (baseSalaryCurrencyLookup.Id > 0)
//                {
//                    stringBuilder.Replace("[[HROfferLetter.BaseSalaryCurrencyLookupId]]", baseSalaryCurrencyLookup.Name.ToString());
//                }
//            }

//            stringBuilder.Replace("[[HROfferLetter.GrossSalary]]", hROfferLetter.GrossSalary.ToString());
//            stringBuilder.Replace("[[HROfferLetter.GrossSalaryInWords]]", hROfferLetter.GrossSalaryInWords.ToString());

//            if (hROfferLetter.GrossSalaryCurrencyLookupId > 0)
//            {
//                GenericLookup grossSalaryCurrencyLookup = facade.GetGenericLookupById(hROfferLetter.GrossSalaryCurrencyLookupId);

//                if (!grossSalaryCurrencyLookup.IsNew)
//                {
//                    stringBuilder.Replace("[[HROfferLetter.GrossSalaryCurrencyLookupId]]", grossSalaryCurrencyLookup.Name.ToString());
//                }
//            }

//            stringBuilder.Replace("[[HROfferLetter.RegularOvertimeRate]]", hROfferLetter.RegularOvertimeRate.ToString());

//            stringBuilder.Replace("[[HROfferLetter.HolidayOvertimeRate]]", hROfferLetter.HolidayOvertimeRate.ToString());

//            Employee employee = facade.GetEmployeeById(creatorId);
//            if (employee != null)
//            {
//                stringBuilder.Replace("[[Employee.FirstName]]", employee.FirstName);
//                stringBuilder.Replace("[[Employee.LastName]]", employee.FirstName);
//                stringBuilder.Replace("[[Employee.Designation]]", employee.CurrentPosition);
//                stringBuilder.Replace("[[Employee.Organization]]", employee.LastEmployer);
//            }

//            string acceptRejectUrl = AppSettings.OfferLetterAcceptrRejectUrl;

//            SecureUrl acceptedUrl = UrlHelper.BuildSecureUrl(acceptRejectUrl, String.Empty, UrlConstants.PARAM_MEMBER_ID, hROfferLetter.MemberId.ToString(), UrlConstants.PARAM_HR_OFFER_LETTER_ID, hROfferLetter.Id.ToString(), UrlConstants.PARAM_HR_OFFER_LETTER_ACCEPT_REJECT_STATUS, Convert.ToString((int)OfferLetterAcceptRejectStatus.Accepted));
//            SecureUrl rejectedUrl = UrlHelper.BuildSecureUrl(acceptRejectUrl, String.Empty, UrlConstants.PARAM_MEMBER_ID, hROfferLetter.MemberId.ToString(), UrlConstants.PARAM_HR_OFFER_LETTER_ID, hROfferLetter.Id.ToString(), UrlConstants.PARAM_HR_OFFER_LETTER_ACCEPT_REJECT_STATUS, Convert.ToString((int)OfferLetterAcceptRejectStatus.Rejected));

//            string acceptRejectPart = @"<br /><table width='50' border='0' cellspacing='0' cellpadding='1'>
//                                      <tr>
//                                        <td width='45%'><a title='Accept' target='_blank' href='" + acceptedUrl.ToString() + @"'><strong>Accept</strong></a></td>
//                                        <td width='10%'>&nbsp;|&nbsp;</td>
//                                        <td width='45%'><a title='Reject' target='_blank' href='" + rejectedUrl.ToString() + @"'><strong>Reject</strong></a></td>
//                                      </tr>
//                                    </table><br />";

//            if (flagAcceptRejectlink)
//            {
//                stringBuilder.Replace("||AcceptRejectPart||", acceptRejectPart.ToString());
//            }
//            else
//            {
//                stringBuilder.Replace("||AcceptRejectPart||", String.Empty);
//            }

//            return stringBuilder.ToString();
//        }

//        public static string GetOfferLetterHtml(HROfferLetter hROfferLetter, bool withLogo, bool toCreatePdf, IFacade facade, int creatorId)
//{
//    string offerLetterHtml = string.Empty;
//    string organizationAddress = string.Empty;
//    string organizationLogo = string.Empty;
//    if (!hROfferLetter.IsNew)
//    {
//        offerLetterHtml = FillHROfferLetter(hROfferLetter, facade, toCreatePdf, creatorId);
//        if (withLogo)
//        {
//            string logoPath = string.Empty;
//            StringBuilder stringBuilder = new StringBuilder();
//            IList<OrganizationBranchOffice> organizationBranchOfficeList = facade.GetAllOrganizationBranchOfficeByOrganizationId(0);

//            if (organizationBranchOfficeList != null && organizationBranchOfficeList.Count > 0)
//            {
//                if (organizationBranchOfficeList[0].Logo != "")
//                {
//                    logoPath = Path.Combine(UrlConstants.ORGBRANCH_LOGO_DIR, organizationBranchOfficeList[0].Logo); //Path.Combine(UrlConstants.GetPhysicalOrgBranchUploadDirectory(), organizationBranchOfficeList[0].Logo);
//                }
//            }
//            if (File.Exists(HttpContext.Current.Server.MapPath(logoPath)))
//            {
//                organizationLogo = "<hr><img src='" + logoPath + "' width=\"221\" height=\"76\"/><hr>";
//            }
//            //stringBuilder.Append("<table style='width:100%;' align='left' border = '0' bordercolor='#000000' cellspacing='0'>");
//            //stringBuilder.Append("    <tr>");
//            //stringBuilder.Append("        <td style=\"background-color: #E3EFFD;\"><img src=\"" + logoPath + "\" width=\"221\" height=\"76\"/></td>");
//            //stringBuilder.Append("    </tr>");
//            //stringBuilder.Append("    <tr><td>&nbsp;</td></tr>");
//            //stringBuilder.Append("    <tr><td>" + offerLetterHtml + "</td></tr>");
//            //stringBuilder.Append("    <tr><td>&nbsp;</td></tr>");
//            if (organizationBranchOfficeList != null && organizationBranchOfficeList.Count > 0)
//            {
//                //stringBuilder.Append("    <tr><td><hr></td></tr>");
//                //stringBuilder.Append("    <tr><td><hr></td></tr>");
//                //stringBuilder.Append("    <tr>");
//                //stringBuilder.Append("      <td style=\"font-weight:bold;text-align:center;\"> " + organizationBranchOfficeList[0].Name + "</td>");
//                //stringBuilder.Append("    </tr>");
//                //stringBuilder.Append("    <tr>");
//                //stringBuilder.Append("      <td style=\"text-align:center;\"> Address: " + organizationBranchOfficeList[0].Address1 + "</td>");
//                //stringBuilder.Append("    </tr>");
//                //stringBuilder.Append("    <tr>");
//                //stringBuilder.Append("      <td style=\"text-align:center;\"> Phone: " + organizationBranchOfficeList[0].OfficePhone + ", Fax: " + organizationBranchOfficeList[0].OfficePhone + "</td>");
//                //stringBuilder.Append("    </tr>");
//                //stringBuilder.Append("    <tr><td><hr></td></tr>");
//                organizationAddress = "<br/><hr>" + organizationBranchOfficeList[0].Name + "<br/>Address: " + organizationBranchOfficeList[0].Address1 + "<br/>Phone: " + organizationBranchOfficeList[0].OfficePhone + ", Fax: " + organizationBranchOfficeList[0].OfficePhone + "<hr><br/>";
//            }
//            //stringBuilder.Append(" </table>");
//            //offerLetterHtml = stringBuilder.ToString();
//        }
//    }
//    offerLetterHtml = offerLetterHtml.Replace("[[OrganizationLogo]]", organizationLogo);
//    offerLetterHtml = offerLetterHtml.Replace("[[OrganizationAddress]]", organizationAddress);
//    return offerLetterHtml;
//}
#endregion