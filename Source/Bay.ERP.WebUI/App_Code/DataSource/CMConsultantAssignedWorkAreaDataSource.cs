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
    public partial class CMConsultantAssignedWorkAreaDataSource
    {
        public Int32 totalRowCount = 0;

        public CMConsultantAssignedWorkAreaDataSource()
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
        public IList<CMConsultantAssignedWorkAreaEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMConsultantAssignedWorkAreaEntity> cMConsultantAssignedWorkAreaEntityList = new List<CMConsultantAssignedWorkAreaEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantAssignedWorkAreaEntity.FLD_NAME_ConsultantAssignedWorkAreaID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMConsultantAssignedWorkAreaEntityList = FCCCMConsultantAssignedWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMConsultantAssignedWorkAreaEntityList != null && cMConsultantAssignedWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantAssignedWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConsultantAssignedWorkAreaEntityList ?? new List<CMConsultantAssignedWorkAreaEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantAssignedWorkAreaEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMConsultantAssignedWorkAreaEntity> cMConsultantAssignedWorkAreaEntityList = new List<CMConsultantAssignedWorkAreaEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantAssignedWorkAreaEntity.FLD_NAME_ConsultantAssignedWorkAreaID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConsultantAssignedWorkAreaEntityList =  FCCCMConsultantAssignedWorkArea.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMConsultantAssignedWorkAreaEntityList =  FCCCMConsultantAssignedWorkArea.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConsultantAssignedWorkAreaEntityList =  FCCCMConsultantAssignedWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMConsultantAssignedWorkAreaEntityList =  FCCCMConsultantAssignedWorkArea.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMConsultantAssignedWorkAreaEntityList != null && cMConsultantAssignedWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantAssignedWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConsultantAssignedWorkAreaEntityList ?? new List<CMConsultantAssignedWorkAreaEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantAssignedWorkAreaEntity> GetData()
        {
            IList<CMConsultantAssignedWorkAreaEntity> cMConsultantAssignedWorkAreaEntityList = new List<CMConsultantAssignedWorkAreaEntity>();
            
            try
            {
                cMConsultantAssignedWorkAreaEntityList = FCCCMConsultantAssignedWorkArea.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMConsultantAssignedWorkAreaEntityList != null && cMConsultantAssignedWorkAreaEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantAssignedWorkAreaEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMConsultantAssignedWorkAreaEntityList ?? new List<CMConsultantAssignedWorkAreaEntity>();
        }
    }
}
