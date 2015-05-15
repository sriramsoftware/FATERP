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
    public partial class HREmployeePhotoDataSource
    {
        public Int32 totalRowCount = 0;

        public HREmployeePhotoDataSource()
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
        public IList<HREmployeePhotoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<HREmployeePhotoEntity> hREmployeePhotoEntityList = new List<HREmployeePhotoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeePhotoEntity.FLD_NAME_EmployeePhotoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                hREmployeePhotoEntityList = FCCHREmployeePhoto.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (hREmployeePhotoEntityList != null && hREmployeePhotoEntityList.Count > 0)
                {
                    totalRowCount = hREmployeePhotoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeePhotoEntityList ?? new List<HREmployeePhotoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeePhotoEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<HREmployeePhotoEntity> hREmployeePhotoEntityList = new List<HREmployeePhotoEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = HREmployeePhotoEntity.FLD_NAME_EmployeePhotoID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeePhotoEntityList =  FCCHREmployeePhoto.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        hREmployeePhotoEntityList =  FCCHREmployeePhoto.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        hREmployeePhotoEntityList =  FCCHREmployeePhoto.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        hREmployeePhotoEntityList =  FCCHREmployeePhoto.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (hREmployeePhotoEntityList != null && hREmployeePhotoEntityList.Count > 0)
                {
                    totalRowCount = hREmployeePhotoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return hREmployeePhotoEntityList ?? new List<HREmployeePhotoEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<HREmployeePhotoEntity> GetData()
        {
            IList<HREmployeePhotoEntity> hREmployeePhotoEntityList = new List<HREmployeePhotoEntity>();
            
            try
            {
                hREmployeePhotoEntityList = FCCHREmployeePhoto.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (hREmployeePhotoEntityList != null && hREmployeePhotoEntityList.Count > 0)
                {
                    totalRowCount = hREmployeePhotoEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return hREmployeePhotoEntityList ?? new List<HREmployeePhotoEntity>();
        }
    }
}
