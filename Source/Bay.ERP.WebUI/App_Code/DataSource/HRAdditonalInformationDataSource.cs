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
    public partial class HRAdditonalInformationDataSource
    {
        public Int32 totalRowCount = 0;

        public HRAdditonalInformationDataSource()
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
        public IList<HRAdditonalInformationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HRAdditonalInformationEntity> hRAdditonalInformationEntityList = new List<HRAdditonalInformationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HRAdditonalInformationEntity.FLD_NAME_AdditonalInformationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hRAdditonalInformationEntityList = FCCHRAdditonalInformation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hRAdditonalInformationEntityList != null && hRAdditonalInformationEntityList.Count > 0)
                {
                    totalRowCount = hRAdditonalInformationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hRAdditonalInformationEntityList ?? new List<HRAdditonalInformationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HRAdditonalInformationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HRAdditonalInformationEntity> hRAdditonalInformationEntityList = new List<HRAdditonalInformationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HRAdditonalInformationEntity.FLD_NAME_AdditonalInformationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hRAdditonalInformationEntityList =  FCCHRAdditonalInformation.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hRAdditonalInformationEntityList =  FCCHRAdditonalInformation.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hRAdditonalInformationEntityList =  FCCHRAdditonalInformation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hRAdditonalInformationEntityList =  FCCHRAdditonalInformation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hRAdditonalInformationEntityList != null && hRAdditonalInformationEntityList.Count > 0)
                {
                    totalRowCount = hRAdditonalInformationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hRAdditonalInformationEntityList ?? new List<HRAdditonalInformationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HRAdditonalInformationEntity> GetData()
        {
            IList<HRAdditonalInformationEntity> hRAdditonalInformationEntityList = new List<HRAdditonalInformationEntity>();
            
            try
            {
                hRAdditonalInformationEntityList = FCCHRAdditonalInformation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hRAdditonalInformationEntityList != null && hRAdditonalInformationEntityList.Count > 0)
                {
                    totalRowCount = hRAdditonalInformationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hRAdditonalInformationEntityList ?? new List<HRAdditonalInformationEntity>();
        }
    }
}
