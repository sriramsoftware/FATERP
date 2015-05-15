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
    public partial class CMProjectScheduleTemplateDataSource
    {
        public Int32 totalRowCount = 0;

        public CMProjectScheduleTemplateDataSource()
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
        public IList<CMProjectScheduleTemplateEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMProjectScheduleTemplateEntity> cMProjectScheduleTemplateEntityList = new List<CMProjectScheduleTemplateEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMProjectScheduleTemplateEntity.FLD_NAME_ProjectScheduleTemplateID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMProjectScheduleTemplateEntityList = FCCCMProjectScheduleTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMProjectScheduleTemplateEntityList != null && cMProjectScheduleTemplateEntityList.Count > 0)
                {
                    totalRowCount = cMProjectScheduleTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMProjectScheduleTemplateEntityList ?? new List<CMProjectScheduleTemplateEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMProjectScheduleTemplateEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMProjectScheduleTemplateEntity> cMProjectScheduleTemplateEntityList = new List<CMProjectScheduleTemplateEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMProjectScheduleTemplateEntity.FLD_NAME_ProjectScheduleTemplateID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMProjectScheduleTemplateEntityList =  FCCCMProjectScheduleTemplate.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMProjectScheduleTemplateEntityList =  FCCCMProjectScheduleTemplate.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMProjectScheduleTemplateEntityList =  FCCCMProjectScheduleTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMProjectScheduleTemplateEntityList =  FCCCMProjectScheduleTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMProjectScheduleTemplateEntityList != null && cMProjectScheduleTemplateEntityList.Count > 0)
                {
                    totalRowCount = cMProjectScheduleTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMProjectScheduleTemplateEntityList ?? new List<CMProjectScheduleTemplateEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMProjectScheduleTemplateEntity> GetData()
        {
            IList<CMProjectScheduleTemplateEntity> cMProjectScheduleTemplateEntityList = new List<CMProjectScheduleTemplateEntity>();
            
            try
            {
                cMProjectScheduleTemplateEntityList = FCCCMProjectScheduleTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMProjectScheduleTemplateEntityList != null && cMProjectScheduleTemplateEntityList.Count > 0)
                {
                    totalRowCount = cMProjectScheduleTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMProjectScheduleTemplateEntityList ?? new List<CMProjectScheduleTemplateEntity>();
        }
    }
}
