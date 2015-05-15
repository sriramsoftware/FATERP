// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    public partial class MDAddressTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public MDAddressTypeDataSource()
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
        public IList<MDAddressTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<MDAddressTypeEntity> mDAddressTypeEntityList = new List<MDAddressTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDAddressTypeEntity.FLD_NAME_AddressTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                mDAddressTypeEntityList = FCCMDAddressType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (mDAddressTypeEntityList != null && mDAddressTypeEntityList.Count > 0)
                {
                    totalRowCount = mDAddressTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDAddressTypeEntityList ?? new List<MDAddressTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDAddressTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<MDAddressTypeEntity> mDAddressTypeEntityList = new List<MDAddressTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = MDAddressTypeEntity.FLD_NAME_AddressTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDAddressTypeEntityList =  FCCMDAddressType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        mDAddressTypeEntityList =  FCCMDAddressType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        mDAddressTypeEntityList =  FCCMDAddressType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        mDAddressTypeEntityList =  FCCMDAddressType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (mDAddressTypeEntityList != null && mDAddressTypeEntityList.Count > 0)
                {
                    totalRowCount = mDAddressTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return mDAddressTypeEntityList ?? new List<MDAddressTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<MDAddressTypeEntity> GetData()
        {
            IList<MDAddressTypeEntity> mDAddressTypeEntityList = new List<MDAddressTypeEntity>();
            
            try
            {
                mDAddressTypeEntityList = FCCMDAddressType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (mDAddressTypeEntityList != null && mDAddressTypeEntityList.Count > 0)
                {
                    totalRowCount = mDAddressTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return mDAddressTypeEntityList ?? new List<MDAddressTypeEntity>();
        }
    }
}
