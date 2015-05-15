// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 06-Oct-2013, 01:41:30




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
    public partial class CMConsultantDataSource
    {
        public Int32 totalRowCount = 0;

        public CMConsultantDataSource()
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
        public IList<CMConsultantEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMConsultantEntity> cMConsultantEntityList = new List<CMConsultantEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantEntity.FLD_NAME_ConsultantID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMConsultantEntityList = FCCCMConsultant.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMConsultantEntityList != null && cMConsultantEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConsultantEntityList ?? new List<CMConsultantEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMConsultantEntity> cMConsultantEntityList = new List<CMConsultantEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantEntity.FLD_NAME_ConsultantID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConsultantEntityList =  FCCCMConsultant.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMConsultantEntityList =  FCCCMConsultant.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConsultantEntityList =  FCCCMConsultant.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMConsultantEntityList =  FCCCMConsultant.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMConsultantEntityList != null && cMConsultantEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConsultantEntityList ?? new List<CMConsultantEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantEntity> GetData()
        {
            IList<CMConsultantEntity> cMConsultantEntityList = new List<CMConsultantEntity>();
            
            try
            {
                cMConsultantEntityList = FCCCMConsultant.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMConsultantEntityList != null && cMConsultantEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMConsultantEntityList ?? new List<CMConsultantEntity>();
        }
    }
}
