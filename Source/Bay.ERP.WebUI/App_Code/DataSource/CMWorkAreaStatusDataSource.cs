// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




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
    public partial class CMWorkAreaStatusDataSource
    {
        public Int32 totalRowCount = 0;

        public CMWorkAreaStatusDataSource()
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
        public IList<CMWorkAreaStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMWorkAreaStatusEntity> cMWorkAreaStatusEntityList = new List<CMWorkAreaStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMWorkAreaStatusEntity.FLD_NAME_WorkAreaStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMWorkAreaStatusEntityList = FCCCMWorkAreaStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMWorkAreaStatusEntityList != null && cMWorkAreaStatusEntityList.Count > 0)
                {
                    totalRowCount = cMWorkAreaStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMWorkAreaStatusEntityList ?? new List<CMWorkAreaStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMWorkAreaStatusEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMWorkAreaStatusEntity> cMWorkAreaStatusEntityList = new List<CMWorkAreaStatusEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMWorkAreaStatusEntity.FLD_NAME_WorkAreaStatusID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMWorkAreaStatusEntityList =  FCCCMWorkAreaStatus.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMWorkAreaStatusEntityList =  FCCCMWorkAreaStatus.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMWorkAreaStatusEntityList =  FCCCMWorkAreaStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMWorkAreaStatusEntityList =  FCCCMWorkAreaStatus.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMWorkAreaStatusEntityList != null && cMWorkAreaStatusEntityList.Count > 0)
                {
                    totalRowCount = cMWorkAreaStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMWorkAreaStatusEntityList ?? new List<CMWorkAreaStatusEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMWorkAreaStatusEntity> GetData()
        {
            IList<CMWorkAreaStatusEntity> cMWorkAreaStatusEntityList = new List<CMWorkAreaStatusEntity>();
            
            try
            {
                cMWorkAreaStatusEntityList = FCCCMWorkAreaStatus.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMWorkAreaStatusEntityList != null && cMWorkAreaStatusEntityList.Count > 0)
                {
                    totalRowCount = cMWorkAreaStatusEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMWorkAreaStatusEntityList ?? new List<CMWorkAreaStatusEntity>();
        }
    }
}
