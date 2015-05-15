// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
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
    public partial class CMCriterionStatusRemarksDataSource
    {
        public Int32 totalRowCount = 0;

        public CMCriterionStatusRemarksDataSource()
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
        public IList<CMCriterionStatusRemarksEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMCriterionStatusRemarksEntity> cMCriterionStatusRemarksEntityList = new List<CMCriterionStatusRemarksEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMCriterionStatusRemarksEntity.FLD_NAME_CriterionStatusRemarksID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMCriterionStatusRemarksEntityList = FCCCMCriterionStatusRemarks.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMCriterionStatusRemarksEntityList != null && cMCriterionStatusRemarksEntityList.Count > 0)
                {
                    totalRowCount = cMCriterionStatusRemarksEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMCriterionStatusRemarksEntityList ?? new List<CMCriterionStatusRemarksEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMCriterionStatusRemarksEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMCriterionStatusRemarksEntity> cMCriterionStatusRemarksEntityList = new List<CMCriterionStatusRemarksEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMCriterionStatusRemarksEntity.FLD_NAME_CriterionStatusRemarksID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMCriterionStatusRemarksEntityList =  FCCCMCriterionStatusRemarks.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMCriterionStatusRemarksEntityList =  FCCCMCriterionStatusRemarks.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMCriterionStatusRemarksEntityList =  FCCCMCriterionStatusRemarks.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMCriterionStatusRemarksEntityList =  FCCCMCriterionStatusRemarks.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMCriterionStatusRemarksEntityList != null && cMCriterionStatusRemarksEntityList.Count > 0)
                {
                    totalRowCount = cMCriterionStatusRemarksEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMCriterionStatusRemarksEntityList ?? new List<CMCriterionStatusRemarksEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMCriterionStatusRemarksEntity> GetData()
        {
            IList<CMCriterionStatusRemarksEntity> cMCriterionStatusRemarksEntityList = new List<CMCriterionStatusRemarksEntity>();
            
            try
            {
                cMCriterionStatusRemarksEntityList = FCCCMCriterionStatusRemarks.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMCriterionStatusRemarksEntityList != null && cMCriterionStatusRemarksEntityList.Count > 0)
                {
                    totalRowCount = cMCriterionStatusRemarksEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMCriterionStatusRemarksEntityList ?? new List<CMCriterionStatusRemarksEntity>();
        }
    }
}
