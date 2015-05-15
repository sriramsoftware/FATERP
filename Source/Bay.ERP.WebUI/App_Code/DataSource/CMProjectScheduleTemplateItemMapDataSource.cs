// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    public partial class CMProjectScheduleTemplateItemMapDataSource
    {
        public Int32 totalRowCount = 0;

        public CMProjectScheduleTemplateItemMapDataSource()
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
        public IList<CMProjectScheduleTemplateItemMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMProjectScheduleTemplateItemMapEntity> cMProjectScheduleTemplateItemMapEntityList = new List<CMProjectScheduleTemplateItemMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMProjectScheduleTemplateItemMapEntity.FLD_NAME_ProjectScheduleTemplateItemMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMProjectScheduleTemplateItemMapEntityList = FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMProjectScheduleTemplateItemMapEntityList != null && cMProjectScheduleTemplateItemMapEntityList.Count > 0)
                {
                    totalRowCount = cMProjectScheduleTemplateItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMProjectScheduleTemplateItemMapEntityList ?? new List<CMProjectScheduleTemplateItemMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMProjectScheduleTemplateItemMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMProjectScheduleTemplateItemMapEntity> cMProjectScheduleTemplateItemMapEntityList = new List<CMProjectScheduleTemplateItemMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMProjectScheduleTemplateItemMapEntity.FLD_NAME_ProjectScheduleTemplateItemMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMProjectScheduleTemplateItemMapEntityList =  FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMProjectScheduleTemplateItemMapEntityList =  FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMProjectScheduleTemplateItemMapEntityList =  FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMProjectScheduleTemplateItemMapEntityList =  FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMProjectScheduleTemplateItemMapEntityList != null && cMProjectScheduleTemplateItemMapEntityList.Count > 0)
                {
                    totalRowCount = cMProjectScheduleTemplateItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMProjectScheduleTemplateItemMapEntityList ?? new List<CMProjectScheduleTemplateItemMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMProjectScheduleTemplateItemMapEntity> GetData()
        {
            IList<CMProjectScheduleTemplateItemMapEntity> cMProjectScheduleTemplateItemMapEntityList = new List<CMProjectScheduleTemplateItemMapEntity>();
            
            try
            {
                cMProjectScheduleTemplateItemMapEntityList = FCCCMProjectScheduleTemplateItemMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMProjectScheduleTemplateItemMapEntityList != null && cMProjectScheduleTemplateItemMapEntityList.Count > 0)
                {
                    totalRowCount = cMProjectScheduleTemplateItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMProjectScheduleTemplateItemMapEntityList ?? new List<CMProjectScheduleTemplateItemMapEntity>();
        }
    }
}
