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
    public partial class PRMPreBOQTemplateItemMapDataSource
    {
        public Int32 totalRowCount = 0;

        public PRMPreBOQTemplateItemMapDataSource()
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
        public IList<PRMPreBOQTemplateItemMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<PRMPreBOQTemplateItemMapEntity> pRMPreBOQTemplateItemMapEntityList = new List<PRMPreBOQTemplateItemMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMPreBOQTemplateItemMapEntity.FLD_NAME_PreBOQTemplateItemMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                pRMPreBOQTemplateItemMapEntityList = FCCPRMPreBOQTemplateItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (pRMPreBOQTemplateItemMapEntityList != null && pRMPreBOQTemplateItemMapEntityList.Count > 0)
                {
                    totalRowCount = pRMPreBOQTemplateItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMPreBOQTemplateItemMapEntityList ?? new List<PRMPreBOQTemplateItemMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMPreBOQTemplateItemMapEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<PRMPreBOQTemplateItemMapEntity> pRMPreBOQTemplateItemMapEntityList = new List<PRMPreBOQTemplateItemMapEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = PRMPreBOQTemplateItemMapEntity.FLD_NAME_PreBOQTemplateItemMapID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMPreBOQTemplateItemMapEntityList =  FCCPRMPreBOQTemplateItemMap.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        pRMPreBOQTemplateItemMapEntityList =  FCCPRMPreBOQTemplateItemMap.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        pRMPreBOQTemplateItemMapEntityList =  FCCPRMPreBOQTemplateItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        pRMPreBOQTemplateItemMapEntityList =  FCCPRMPreBOQTemplateItemMap.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (pRMPreBOQTemplateItemMapEntityList != null && pRMPreBOQTemplateItemMapEntityList.Count > 0)
                {
                    totalRowCount = pRMPreBOQTemplateItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return pRMPreBOQTemplateItemMapEntityList ?? new List<PRMPreBOQTemplateItemMapEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<PRMPreBOQTemplateItemMapEntity> GetData()
        {
            IList<PRMPreBOQTemplateItemMapEntity> pRMPreBOQTemplateItemMapEntityList = new List<PRMPreBOQTemplateItemMapEntity>();
            
            try
            {
                pRMPreBOQTemplateItemMapEntityList = FCCPRMPreBOQTemplateItemMap.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (pRMPreBOQTemplateItemMapEntityList != null && pRMPreBOQTemplateItemMapEntityList.Count > 0)
                {
                    totalRowCount = pRMPreBOQTemplateItemMapEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return pRMPreBOQTemplateItemMapEntityList ?? new List<PRMPreBOQTemplateItemMapEntity>();
        }
    }
}
