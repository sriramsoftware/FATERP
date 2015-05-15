// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 03:17:49




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;
using System.Web;
using System.Linq;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class MDItemCategoryFacade
    {
        #region Extra Methods

        [OperationContract]
        IList<MDItemCategoryEntity> IMDItemCategoryFacade.GetILFC()
        {
            return GetILFromCache();
        }

        [OperationContract]
        IList<MDItemCategoryEntity> IMDItemCategoryFacade.GetByParentCategoryILFC(Int64 parentCategoryID)
        {
            IList<MDItemCategoryEntity> lstItemCategory = GetILFromCache();

            IList<MDItemCategoryEntity> lstByParentCategory = (from a in lstItemCategory where a.ParentItemCategoryID == parentCategoryID select a).ToList();

            return lstByParentCategory;
        }

        private IList<MDItemCategoryEntity> GetILFromCache()
        {
            IList<MDItemCategoryEntity> lstItemCategory = null;

            if (HttpContext.Current.Cache[CommonConstants.ITEM_CATEGORY_FC] == null)
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemCategoryEntity.FLD_NAME_IsRemoved, "false", SQLMatchType.Equal);

                lstItemCategory = DataAccessFactory.CreateMDItemCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                // storing in the cache
                if (lstItemCategory != null)
                {
                    HttpContext.Current.Cache[CommonConstants.ITEM_CATEGORY_FC] = lstItemCategory;
                }
            }
            else
            {
                lstItemCategory = (IList<MDItemCategoryEntity>)HttpContext.Current.Cache[CommonConstants.ITEM_CATEGORY_FC];
            }

            return lstItemCategory;
        }

        [OperationContract]
        void IMDItemCategoryFacade.RemoveCache()
        {
            HttpContext.Current.Cache.Remove(CommonConstants.ITEM_CATEGORY_FC);
        }  

        #endregion
    }
}
