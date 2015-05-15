// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    public partial class HREmployeeNoticeTemplateDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeeNoticeTemplateDataSource()
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
        public IList<HREmployeeNoticeTemplateEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeeNoticeTemplateEntity> hREmployeeNoticeTemplateEntityList = new List<HREmployeeNoticeTemplateEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeNoticeTemplateEntity.FLD_NAME_EmployeeNoticeTemplateID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeeNoticeTemplateEntityList = FCCHREmployeeNoticeTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeeNoticeTemplateEntityList != null && hREmployeeNoticeTemplateEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeNoticeTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeNoticeTemplateEntityList ?? new List<HREmployeeNoticeTemplateEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeNoticeTemplateEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeeNoticeTemplateEntity> hREmployeeNoticeTemplateEntityList = new List<HREmployeeNoticeTemplateEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeeNoticeTemplateEntity.FLD_NAME_EmployeeNoticeTemplateID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeNoticeTemplateEntityList =  FCCHREmployeeNoticeTemplate.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeeNoticeTemplateEntityList =  FCCHREmployeeNoticeTemplate.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeeNoticeTemplateEntityList =  FCCHREmployeeNoticeTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeeNoticeTemplateEntityList =  FCCHREmployeeNoticeTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeeNoticeTemplateEntityList != null && hREmployeeNoticeTemplateEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeNoticeTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeeNoticeTemplateEntityList ?? new List<HREmployeeNoticeTemplateEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeeNoticeTemplateEntity> GetData()
        {
            IList<HREmployeeNoticeTemplateEntity> hREmployeeNoticeTemplateEntityList = new List<HREmployeeNoticeTemplateEntity>();
            
            try
            {
                hREmployeeNoticeTemplateEntityList = FCCHREmployeeNoticeTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeeNoticeTemplateEntityList != null && hREmployeeNoticeTemplateEntityList.Count > 0)
                {
                    totalRowCount = hREmployeeNoticeTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeeNoticeTemplateEntityList ?? new List<HREmployeeNoticeTemplateEntity>();
        }
    }
}
