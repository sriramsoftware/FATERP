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
    public partial class CMConsultantWorkAreaDataSource
    {
        public Int32 totalRowCount = 0;

        public CMConsultantWorkAreaDataSource()
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
        public IList<CMConsultantWorkAreaEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMConsultantWorkAreaEntity> cMConsultantWorkAreaEntityList = new List<CMConsultantWorkAreaEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantWorkAreaEntity.FLD_NAME_ConsultantWorkAreaID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMConsultantWorkAreaEntityList = FCCCMConsultantWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMConsultantWorkAreaEntityList != null && cMConsultantWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConsultantWorkAreaEntityList ?? new List<CMConsultantWorkAreaEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantWorkAreaEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMConsultantWorkAreaEntity> cMConsultantWorkAreaEntityList = new List<CMConsultantWorkAreaEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantWorkAreaEntity.FLD_NAME_ConsultantWorkAreaID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConsultantWorkAreaEntityList =  FCCCMConsultantWorkArea.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMConsultantWorkAreaEntityList =  FCCCMConsultantWorkArea.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConsultantWorkAreaEntityList =  FCCCMConsultantWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMConsultantWorkAreaEntityList =  FCCCMConsultantWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMConsultantWorkAreaEntityList != null && cMConsultantWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConsultantWorkAreaEntityList ?? new List<CMConsultantWorkAreaEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantWorkAreaEntity> GetData()
        {
            IList<CMConsultantWorkAreaEntity> cMConsultantWorkAreaEntityList = new List<CMConsultantWorkAreaEntity>();
            
            try
            {
                cMConsultantWorkAreaEntityList = FCCCMConsultantWorkArea.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMConsultantWorkAreaEntityList != null && cMConsultantWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMConsultantWorkAreaEntityList ?? new List<CMConsultantWorkAreaEntity>();
        }
    }
}
