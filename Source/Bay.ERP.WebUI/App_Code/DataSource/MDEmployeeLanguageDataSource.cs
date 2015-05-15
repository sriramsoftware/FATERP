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
    public partial class MDEmployeeLanguageDataSource
    {
        public Int32 totalRowCount = 0;

        public MDEmployeeLanguageDataSource()
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
        public IList<MDEmployeeLanguageEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDEmployeeLanguageEntity> mDEmployeeLanguageEntityList = new List<MDEmployeeLanguageEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDEmployeeLanguageEntity.FLD_NAME_EmployeeLanguageID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDEmployeeLanguageEntityList = FCCMDEmployeeLanguage.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDEmployeeLanguageEntityList != null && mDEmployeeLanguageEntityList.Count > 0)
                {
                    totalRowCount = mDEmployeeLanguageEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDEmployeeLanguageEntityList ?? new List<MDEmployeeLanguageEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDEmployeeLanguageEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDEmployeeLanguageEntity> mDEmployeeLanguageEntityList = new List<MDEmployeeLanguageEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDEmployeeLanguageEntity.FLD_NAME_EmployeeLanguageID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDEmployeeLanguageEntityList =  FCCMDEmployeeLanguage.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDEmployeeLanguageEntityList =  FCCMDEmployeeLanguage.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDEmployeeLanguageEntityList =  FCCMDEmployeeLanguage.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDEmployeeLanguageEntityList =  FCCMDEmployeeLanguage.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDEmployeeLanguageEntityList != null && mDEmployeeLanguageEntityList.Count > 0)
                {
                    totalRowCount = mDEmployeeLanguageEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDEmployeeLanguageEntityList ?? new List<MDEmployeeLanguageEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDEmployeeLanguageEntity> GetData()
        {
            IList<MDEmployeeLanguageEntity> mDEmployeeLanguageEntityList = new List<MDEmployeeLanguageEntity>();
            
            try
            {
                mDEmployeeLanguageEntityList = FCCMDEmployeeLanguage.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDEmployeeLanguageEntityList != null && mDEmployeeLanguageEntityList.Count > 0)
                {
                    totalRowCount = mDEmployeeLanguageEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDEmployeeLanguageEntityList ?? new List<MDEmployeeLanguageEntity>();
        }
    }
}
