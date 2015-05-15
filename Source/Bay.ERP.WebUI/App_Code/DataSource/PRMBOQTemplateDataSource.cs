// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    public partial class PRMBOQTemplateDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMBOQTemplateDataSource()
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
        public IList<PRMBOQTemplateEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMBOQTemplateEntity> pRMBOQTemplateEntityList = new List<PRMBOQTemplateEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMBOQTemplateEntity.FLD_NAME_BOQTemplateID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMBOQTemplateEntityList = FCCPRMBOQTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMBOQTemplateEntityList != null && pRMBOQTemplateEntityList.Count > 0)
                {
                    totalRowCount = pRMBOQTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMBOQTemplateEntityList ?? new List<PRMBOQTemplateEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMBOQTemplateEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMBOQTemplateEntity> pRMBOQTemplateEntityList = new List<PRMBOQTemplateEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMBOQTemplateEntity.FLD_NAME_BOQTemplateID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMBOQTemplateEntityList =  FCCPRMBOQTemplate.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMBOQTemplateEntityList =  FCCPRMBOQTemplate.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMBOQTemplateEntityList =  FCCPRMBOQTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMBOQTemplateEntityList =  FCCPRMBOQTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMBOQTemplateEntityList != null && pRMBOQTemplateEntityList.Count > 0)
                {
                    totalRowCount = pRMBOQTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMBOQTemplateEntityList ?? new List<PRMBOQTemplateEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMBOQTemplateEntity> GetData()
        {
            IList<PRMBOQTemplateEntity> pRMBOQTemplateEntityList = new List<PRMBOQTemplateEntity>();
            
            try
            {
                pRMBOQTemplateEntityList = FCCPRMBOQTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMBOQTemplateEntityList != null && pRMBOQTemplateEntityList.Count > 0)
                {
                    totalRowCount = pRMBOQTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMBOQTemplateEntityList ?? new List<PRMBOQTemplateEntity>();
        }
    }
}
