// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2014, 11:58:51




using System;
using System.Data;
using System.ComponentModel;
using System.Collections.Generic;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.BusinessFacade;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI
{
    [DataObject(true)]
    public partial class MDDistrictDataSource
    {
        public Int32 totalRowCount = 0;

        public MDDistrictDataSource()
        {
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            return totalRowCount;
        }

        [DataObjectMethod(DataObjectMethodType.Select, false)]
        public Int32 TotalRowCount(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            return totalRowCount;
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDDistrictEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDDistrictEntity> mDDistrictEntityList = new List<MDDistrictEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDDistrictEntity.FLD_NAME_DistrictID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDDistrictEntityList = FCCMDDistrict.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDDistrictEntityList != null && mDDistrictEntityList.Count > 0)
                {
                    totalRowCount = mDDistrictEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDDistrictEntityList ?? new List<MDDistrictEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDDistrictEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDDistrictEntity> mDDistrictEntityList = new List<MDDistrictEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDDistrictEntity.FLD_NAME_DistrictID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDDistrictEntityList =  FCCMDDistrict.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDDistrictEntityList =  FCCMDDistrict.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDDistrictEntityList =  FCCMDDistrict.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDDistrictEntityList =  FCCMDDistrict.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDDistrictEntityList != null && mDDistrictEntityList.Count > 0)
                {
                    totalRowCount = mDDistrictEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDDistrictEntityList ?? new List<MDDistrictEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDDistrictEntity> GetData()
        {
            IList<MDDistrictEntity> mDDistrictEntityList = new List<MDDistrictEntity>();
            
            try
            {
                mDDistrictEntityList = FCCMDDistrict.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDDistrictEntityList != null && mDDistrictEntityList.Count > 0)
                {
                    totalRowCount = mDDistrictEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDDistrictEntityList ?? new List<MDDistrictEntity>();
        }
    }
}
