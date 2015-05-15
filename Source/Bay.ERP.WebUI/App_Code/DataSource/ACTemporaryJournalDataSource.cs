// Copyright and All Rights Reserved by
// 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// B2B Solutions, Info@b2b-erp.com
// ©2010 – 2013.
//
// Code Generate Time - 16-Jul-2013, 11:20:53




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
    public partial class ACTemporaryJournalDataSource
    {
        public Int32 totalRowCount = 0;

        public ACTemporaryJournalDataSource()
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
        public IList<ACTemporaryJournalEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<ACTemporaryJournalEntity> aCTemporaryJournalEntityList = new List<ACTemporaryJournalEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                aCTemporaryJournalEntityList = FCCACTemporaryJournal.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (aCTemporaryJournalEntityList != null && aCTemporaryJournalEntityList.Count > 0)
                {
                    totalRowCount = aCTemporaryJournalEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCTemporaryJournalEntityList ?? new List<ACTemporaryJournalEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACTemporaryJournalEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<ACTemporaryJournalEntity> aCTemporaryJournalEntityList = new List<ACTemporaryJournalEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = ACTemporaryJournalEntity.FLD_NAME_TemporaryJournalID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCTemporaryJournalEntityList =  FCCACTemporaryJournal.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        aCTemporaryJournalEntityList =  FCCACTemporaryJournal.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        aCTemporaryJournalEntityList =  FCCACTemporaryJournal.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        aCTemporaryJournalEntityList =  FCCACTemporaryJournal.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (aCTemporaryJournalEntityList != null && aCTemporaryJournalEntityList.Count > 0)
                {
                    totalRowCount = aCTemporaryJournalEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return aCTemporaryJournalEntityList ?? new List<ACTemporaryJournalEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<ACTemporaryJournalEntity> GetData()
        {
            IList<ACTemporaryJournalEntity> aCTemporaryJournalEntityList = new List<ACTemporaryJournalEntity>();
            
            try
            {
                aCTemporaryJournalEntityList = FCCACTemporaryJournal.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (aCTemporaryJournalEntityList != null && aCTemporaryJournalEntityList.Count > 0)
                {
                    totalRowCount = aCTemporaryJournalEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return aCTemporaryJournalEntityList ?? new List<ACTemporaryJournalEntity>();
        }
    }
}
