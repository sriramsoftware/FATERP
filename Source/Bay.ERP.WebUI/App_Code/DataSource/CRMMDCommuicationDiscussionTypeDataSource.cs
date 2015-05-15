// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    public partial class CRMMDCommuicationDiscussionTypeDataSource
    {
        public Int32 totalRowCount = 0;

        public CRMMDCommuicationDiscussionTypeDataSource()
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
        public IList<CRMMDCommuicationDiscussionTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CRMMDCommuicationDiscussionTypeEntity> cRMMDCommuicationDiscussionTypeEntityList = new List<CRMMDCommuicationDiscussionTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDCommuicationDiscussionTypeEntity.FLD_NAME_CommuicationDiscussionTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cRMMDCommuicationDiscussionTypeEntityList = FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cRMMDCommuicationDiscussionTypeEntityList != null && cRMMDCommuicationDiscussionTypeEntityList.Count > 0)
                {
                    totalRowCount = cRMMDCommuicationDiscussionTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDCommuicationDiscussionTypeEntityList ?? new List<CRMMDCommuicationDiscussionTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDCommuicationDiscussionTypeEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CRMMDCommuicationDiscussionTypeEntity> cRMMDCommuicationDiscussionTypeEntityList = new List<CRMMDCommuicationDiscussionTypeEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CRMMDCommuicationDiscussionTypeEntity.FLD_NAME_CommuicationDiscussionTypeID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDCommuicationDiscussionTypeEntityList =  FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cRMMDCommuicationDiscussionTypeEntityList =  FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cRMMDCommuicationDiscussionTypeEntityList =  FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cRMMDCommuicationDiscussionTypeEntityList =  FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cRMMDCommuicationDiscussionTypeEntityList != null && cRMMDCommuicationDiscussionTypeEntityList.Count > 0)
                {
                    totalRowCount = cRMMDCommuicationDiscussionTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cRMMDCommuicationDiscussionTypeEntityList ?? new List<CRMMDCommuicationDiscussionTypeEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CRMMDCommuicationDiscussionTypeEntity> GetData()
        {
            IList<CRMMDCommuicationDiscussionTypeEntity> cRMMDCommuicationDiscussionTypeEntityList = new List<CRMMDCommuicationDiscussionTypeEntity>();
            
            try
            {
                cRMMDCommuicationDiscussionTypeEntityList = FCCCRMMDCommuicationDiscussionType.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cRMMDCommuicationDiscussionTypeEntityList != null && cRMMDCommuicationDiscussionTypeEntityList.Count > 0)
                {
                    totalRowCount = cRMMDCommuicationDiscussionTypeEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cRMMDCommuicationDiscussionTypeEntityList ?? new List<CRMMDCommuicationDiscussionTypeEntity>();
        }
    }
}
