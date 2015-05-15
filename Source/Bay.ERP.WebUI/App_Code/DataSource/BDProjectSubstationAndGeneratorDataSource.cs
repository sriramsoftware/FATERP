// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    public partial class BDProjectSubstationAndGeneratorDataSource
    {
        public Int32 totalRowCount = 0;

        public BDProjectSubstationAndGeneratorDataSource()
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
        public IList<BDProjectSubstationAndGeneratorEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<BDProjectSubstationAndGeneratorEntity> bDProjectSubstationAndGeneratorEntityList = new List<BDProjectSubstationAndGeneratorEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectSubstationAndGeneratorEntity.FLD_NAME_ProjectSubstationAndGeneratorID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                bDProjectSubstationAndGeneratorEntityList = FCCBDProjectSubstationAndGenerator.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (bDProjectSubstationAndGeneratorEntityList != null && bDProjectSubstationAndGeneratorEntityList.Count > 0)
                {
                    totalRowCount = bDProjectSubstationAndGeneratorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectSubstationAndGeneratorEntityList ?? new List<BDProjectSubstationAndGeneratorEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectSubstationAndGeneratorEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<BDProjectSubstationAndGeneratorEntity> bDProjectSubstationAndGeneratorEntityList = new List<BDProjectSubstationAndGeneratorEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = BDProjectSubstationAndGeneratorEntity.FLD_NAME_ProjectSubstationAndGeneratorID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectSubstationAndGeneratorEntityList =  FCCBDProjectSubstationAndGenerator.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        bDProjectSubstationAndGeneratorEntityList =  FCCBDProjectSubstationAndGenerator.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        bDProjectSubstationAndGeneratorEntityList =  FCCBDProjectSubstationAndGenerator.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        bDProjectSubstationAndGeneratorEntityList =  FCCBDProjectSubstationAndGenerator.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (bDProjectSubstationAndGeneratorEntityList != null && bDProjectSubstationAndGeneratorEntityList.Count > 0)
                {
                    totalRowCount = bDProjectSubstationAndGeneratorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return bDProjectSubstationAndGeneratorEntityList ?? new List<BDProjectSubstationAndGeneratorEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<BDProjectSubstationAndGeneratorEntity> GetData()
        {
            IList<BDProjectSubstationAndGeneratorEntity> bDProjectSubstationAndGeneratorEntityList = new List<BDProjectSubstationAndGeneratorEntity>();
            
            try
            {
                bDProjectSubstationAndGeneratorEntityList = FCCBDProjectSubstationAndGenerator.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (bDProjectSubstationAndGeneratorEntityList != null && bDProjectSubstationAndGeneratorEntityList.Count > 0)
                {
                    totalRowCount = bDProjectSubstationAndGeneratorEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return bDProjectSubstationAndGeneratorEntityList ?? new List<BDProjectSubstationAndGeneratorEntity>();
        }
    }
}