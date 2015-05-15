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
    public partial class MDFamilyRelationTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public MDFamilyRelationTypeDataSource()
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
        public IList<MDFamilyRelationTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDFamilyRelationTypeEntity> mDFamilyRelationTypeEntityList = new List<MDFamilyRelationTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDFamilyRelationTypeEntity.FLD_NAME_FamilyRelationTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDFamilyRelationTypeEntityList = FCCMDFamilyRelationType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDFamilyRelationTypeEntityList != null && mDFamilyRelationTypeEntityList.Count > 0)
                {
                    totalRowCount = mDFamilyRelationTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDFamilyRelationTypeEntityList ?? new List<MDFamilyRelationTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDFamilyRelationTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDFamilyRelationTypeEntity> mDFamilyRelationTypeEntityList = new List<MDFamilyRelationTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDFamilyRelationTypeEntity.FLD_NAME_FamilyRelationTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDFamilyRelationTypeEntityList =  FCCMDFamilyRelationType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDFamilyRelationTypeEntityList =  FCCMDFamilyRelationType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDFamilyRelationTypeEntityList =  FCCMDFamilyRelationType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDFamilyRelationTypeEntityList =  FCCMDFamilyRelationType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDFamilyRelationTypeEntityList != null && mDFamilyRelationTypeEntityList.Count > 0)
                {
                    totalRowCount = mDFamilyRelationTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDFamilyRelationTypeEntityList ?? new List<MDFamilyRelationTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDFamilyRelationTypeEntity> GetData()
        {
            IList<MDFamilyRelationTypeEntity> mDFamilyRelationTypeEntityList = new List<MDFamilyRelationTypeEntity>();
            
            try
            {
                mDFamilyRelationTypeEntityList = FCCMDFamilyRelationType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDFamilyRelationTypeEntityList != null && mDFamilyRelationTypeEntityList.Count > 0)
                {
                    totalRowCount = mDFamilyRelationTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDFamilyRelationTypeEntityList ?? new List<MDFamilyRelationTypeEntity>();
        }
    }
}
