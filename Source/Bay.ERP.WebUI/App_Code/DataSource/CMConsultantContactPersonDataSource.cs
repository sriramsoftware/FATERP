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
    public partial class CMConsultantContactPersonDataSource
    {
        public Int32 totalRowCount = 0;

        public CMConsultantContactPersonDataSource()
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
        public IList<CMConsultantContactPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMConsultantContactPersonEntity> cMConsultantContactPersonEntityList = new List<CMConsultantContactPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantContactPersonEntity.FLD_NAME_ConsultantContactPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMConsultantContactPersonEntityList = FCCCMConsultantContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMConsultantContactPersonEntityList != null && cMConsultantContactPersonEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConsultantContactPersonEntityList ?? new List<CMConsultantContactPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantContactPersonEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMConsultantContactPersonEntity> cMConsultantContactPersonEntityList = new List<CMConsultantContactPersonEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMConsultantContactPersonEntity.FLD_NAME_ConsultantContactPersonID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConsultantContactPersonEntityList =  FCCCMConsultantContactPerson.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMConsultantContactPersonEntityList =  FCCCMConsultantContactPerson.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMConsultantContactPersonEntityList =  FCCCMConsultantContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMConsultantContactPersonEntityList =  FCCCMConsultantContactPerson.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMConsultantContactPersonEntityList != null && cMConsultantContactPersonEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMConsultantContactPersonEntityList ?? new List<CMConsultantContactPersonEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMConsultantContactPersonEntity> GetData()
        {
            IList<CMConsultantContactPersonEntity> cMConsultantContactPersonEntityList = new List<CMConsultantContactPersonEntity>();
            
            try
            {
                cMConsultantContactPersonEntityList = FCCCMConsultantContactPerson.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMConsultantContactPersonEntityList != null && cMConsultantContactPersonEntityList.Count > 0)
                {
                    totalRowCount = cMConsultantContactPersonEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMConsultantContactPersonEntityList ?? new List<CMConsultantContactPersonEntity>();
        }
    }
}
