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
    public sealed partial class MDItemFacade
    {
        #region Extra Methods

        [OperationContract]
        IList<MDItemEntity> IMDItemFacade.GetILFC()
        {
            return GetILFromCache();
        }

        [OperationContract]
        IList<MDItemEntity> IMDItemFacade.GetByCategoryIDILFC(Int64 categoryID)
        {
            IList<MDItemEntity> lstItemCategory = GetILFromCache();

            IList<MDItemEntity> lstByParentCategory = ( from a in lstItemCategory where a.ItemCategoryID == categoryID select a).ToList();

            return lstByParentCategory;
        }

        private IList<MDItemEntity> GetILFromCache()
        {
            IList<MDItemEntity> lstItemCategory;

            if (HttpContext.Current.Cache[CommonConstants.ITEM_FC] == null)
            {
                // collecting form database
                String fe = SqlExpressionBuilder.PrepareFilterExpression(MDItemEntity.FLD_NAME_IsRemoved, "false", SQLMatchType.Equal);
                lstItemCategory = DataAccessFactory.CreateMDItemDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                // storing in the cache
                if (lstItemCategory != null)
                {
                    HttpContext.Current.Cache[CommonConstants.ITEM_FC] = lstItemCategory;
                }
            }
            else
            {
                lstItemCategory = (IList<MDItemEntity>)HttpContext.Current.Cache[CommonConstants.ITEM_FC];
            }

            return lstItemCategory;
        }


        [OperationContract]
        void IMDItemFacade.RemoveCache()
        {
            HttpContext.Current.Cache.Remove(CommonConstants.ITEM_FC);
        }

        #endregion
    }
}
