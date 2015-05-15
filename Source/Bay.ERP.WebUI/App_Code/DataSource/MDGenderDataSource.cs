// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public partial class MDGenderDataSource
    {
        public Int32 totalRowCount = 0;

        public MDGenderDataSource()
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
        public IList<MDGenderEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDGenderEntity> mDGenderEntityList = new List<MDGenderEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDGenderEntity.FLD_NAME_GenderID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDGenderEntityList = FCCMDGender.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDGenderEntityList != null && mDGenderEntityList.Count > 0)
                {
                    totalRowCount = mDGenderEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDGenderEntityList ?? new List<MDGenderEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDGenderEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDGenderEntity> mDGenderEntityList = new List<MDGenderEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDGenderEntity.FLD_NAME_GenderID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDGenderEntityList =  FCCMDGender.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDGenderEntityList =  FCCMDGender.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDGenderEntityList =  FCCMDGender.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDGenderEntityList =  FCCMDGender.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDGenderEntityList != null && mDGenderEntityList.Count > 0)
                {
                    totalRowCount = mDGenderEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDGenderEntityList ?? new List<MDGenderEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDGenderEntity> GetData()
        {
            IList<MDGenderEntity> mDGenderEntityList = new List<MDGenderEntity>();
            
            try
            {
                mDGenderEntityList = FCCMDGender.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDGenderEntityList != null && mDGenderEntityList.Count > 0)
                {
                    totalRowCount = mDGenderEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDGenderEntityList ?? new List<MDGenderEntity>();
        }
    }
}
