// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 02:22:45




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
    public partial class PRMPreBOQTemplateDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMPreBOQTemplateDataSource()
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
        public IList<PRMPreBOQTemplateEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMPreBOQTemplateEntity> pRMPreBOQTemplateEntityList = new List<PRMPreBOQTemplateEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMPreBOQTemplateEntity.FLD_NAME_PreBOQTemplateID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMPreBOQTemplateEntityList = FCCPRMPreBOQTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMPreBOQTemplateEntityList != null && pRMPreBOQTemplateEntityList.Count > 0)
                {
                    totalRowCount = pRMPreBOQTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMPreBOQTemplateEntityList ?? new List<PRMPreBOQTemplateEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMPreBOQTemplateEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMPreBOQTemplateEntity> pRMPreBOQTemplateEntityList = new List<PRMPreBOQTemplateEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMPreBOQTemplateEntity.FLD_NAME_PreBOQTemplateID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMPreBOQTemplateEntityList =  FCCPRMPreBOQTemplate.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMPreBOQTemplateEntityList =  FCCPRMPreBOQTemplate.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMPreBOQTemplateEntityList =  FCCPRMPreBOQTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMPreBOQTemplateEntityList =  FCCPRMPreBOQTemplate.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMPreBOQTemplateEntityList != null && pRMPreBOQTemplateEntityList.Count > 0)
                {
                    totalRowCount = pRMPreBOQTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMPreBOQTemplateEntityList ?? new List<PRMPreBOQTemplateEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMPreBOQTemplateEntity> GetData()
        {
            IList<PRMPreBOQTemplateEntity> pRMPreBOQTemplateEntityList = new List<PRMPreBOQTemplateEntity>();
            
            try
            {
                pRMPreBOQTemplateEntityList = FCCPRMPreBOQTemplate.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMPreBOQTemplateEntityList != null && pRMPreBOQTemplateEntityList.Count > 0)
                {
                    totalRowCount = pRMPreBOQTemplateEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMPreBOQTemplateEntityList ?? new List<PRMPreBOQTemplateEntity>();
        }
    }
}
