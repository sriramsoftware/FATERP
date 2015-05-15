// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 09-Jan-2012, 01:23:18




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
    public partial class CMConsultantEnlistedWorkAreaDataSource
    {
        public Int32 totalRowCount = 0;

        public CMConsultantEnlistedWorkAreaDataSource()
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
        public IList<CMConsultantEnlistedWorkAreaEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMConsultantEnlistedWorkAreaEntity> cMConsultantEnlistedWorkAreaEntityList = new List<CMConsultantEnlistedWorkAreaEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantEnlistedWorkAreaEntity.FLD_NAME_ConsultantEnlistedWorkAreaID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMConsultantEnlistedWorkAreaEntityList = FCCCMConsultantEnlistedWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMConsultantEnlistedWorkAreaEntityList != null && cMConsultantEnlistedWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantEnlistedWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConsultantEnlistedWorkAreaEntityList ?? new List<CMConsultantEnlistedWorkAreaEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantEnlistedWorkAreaEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMConsultantEnlistedWorkAreaEntity> cMConsultantEnlistedWorkAreaEntityList = new List<CMConsultantEnlistedWorkAreaEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantEnlistedWorkAreaEntity.FLD_NAME_ConsultantEnlistedWorkAreaID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConsultantEnlistedWorkAreaEntityList =  FCCCMConsultantEnlistedWorkArea.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMConsultantEnlistedWorkAreaEntityList =  FCCCMConsultantEnlistedWorkArea.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConsultantEnlistedWorkAreaEntityList =  FCCCMConsultantEnlistedWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMConsultantEnlistedWorkAreaEntityList =  FCCCMConsultantEnlistedWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMConsultantEnlistedWorkAreaEntityList != null && cMConsultantEnlistedWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantEnlistedWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConsultantEnlistedWorkAreaEntityList ?? new List<CMConsultantEnlistedWorkAreaEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantEnlistedWorkAreaEntity> GetData()
        {
            IList<CMConsultantEnlistedWorkAreaEntity> cMConsultantEnlistedWorkAreaEntityList = new List<CMConsultantEnlistedWorkAreaEntity>();
            
            try
            {
                cMConsultantEnlistedWorkAreaEntityList = FCCCMConsultantEnlistedWorkArea.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMConsultantEnlistedWorkAreaEntityList != null && cMConsultantEnlistedWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantEnlistedWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMConsultantEnlistedWorkAreaEntityList ?? new List<CMConsultantEnlistedWorkAreaEntity>();
        }
    }
}
