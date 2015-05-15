// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 12:21:52




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
    public partial class CMNEventInvitationInformationDataSource
    {
        public Int32 totalRowCount = 0;

        public CMNEventInvitationInformationDataSource()
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
        public IList<CMNEventInvitationInformationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression)
        {
            IList<CMNEventInvitationInformationEntity> cMNEventInvitationInformationEntityList = new List<CMNEventInvitationInformationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNEventInvitationInformationEntity.FLD_NAME_EventInvitationInformationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                cMNEventInvitationInformationEntityList = FCCCMNEventInvitationInformation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, null, DatabaseOperationType.LoadPagedWithSortExpression);

                if (cMNEventInvitationInformationEntityList != null && cMNEventInvitationInformationEntityList.Count > 0)
                {
                    totalRowCount = cMNEventInvitationInformationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNEventInvitationInformationEntityList ?? new List<CMNEventInvitationInformationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNEventInvitationInformationEntity> GetPagedData(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression)
        {
            IList<CMNEventInvitationInformationEntity> cMNEventInvitationInformationEntityList = new List<CMNEventInvitationInformationEntity>();

            try
            {
                if (pageSize == -1)
                {
                    pageSize = 1000000000;
                }

                if (String.IsNullOrEmpty(sortExpression))
                {
                    sortExpression = CMNEventInvitationInformationEntity.FLD_NAME_EventInvitationInformationID + " " + SQLConstants.SORT_ORDER_DESCENDING;
                }

                startRowIndex = Convert.ToInt32(startRowIndex / pageSize) + 1;

                if (pageSize == 2147483647)
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNEventInvitationInformationEntityList =  FCCCMNEventInvitationInformation.GetFacadeCreate().GetIL(null, null, sortExpression, String.Empty, DatabaseOperationType.LoadWithSortExpression);
                    }
                    else
                    {
                        cMNEventInvitationInformationEntityList =  FCCCMNEventInvitationInformation.GetFacadeCreate().GetIL(null, null, sortExpression, filterExpression, DatabaseOperationType.LoadWithFilterAndSortExpression);
                    }
                }
                else
                {
                    if (filterExpression.IsNullOrEmpty())
                    {
                        cMNEventInvitationInformationEntityList =  FCCCMNEventInvitationInformation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, String.Empty, DatabaseOperationType.LoadPagedWithSortExpression);
                    }
                    else
                    {
                        cMNEventInvitationInformationEntityList =  FCCCMNEventInvitationInformation.GetFacadeCreate().GetIL(startRowIndex, pageSize, sortExpression, filterExpression, DatabaseOperationType.LoadPagedWithFilterAndSortExpression);
                    }
                }

                if (cMNEventInvitationInformationEntityList != null && cMNEventInvitationInformationEntityList.Count > 0)
                {
                    totalRowCount = cMNEventInvitationInformationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
            }

            return cMNEventInvitationInformationEntityList ?? new List<CMNEventInvitationInformationEntity>();
        }

        [DataObjectMethod(DataObjectMethodType.Select, true)]
        public IList<CMNEventInvitationInformationEntity> GetData()
        {
            IList<CMNEventInvitationInformationEntity> cMNEventInvitationInformationEntityList = new List<CMNEventInvitationInformationEntity>();
            
            try
            {
                cMNEventInvitationInformationEntityList = FCCCMNEventInvitationInformation.GetFacadeCreate().GetIL(null, null, null, null, DatabaseOperationType.Load);

                if (cMNEventInvitationInformationEntityList != null && cMNEventInvitationInformationEntityList.Count > 0)
                {
                    totalRowCount = cMNEventInvitationInformationEntityList[0].TotalRowCount;
                }
            }
            catch (Exception ex)
            {
             
            }

            return cMNEventInvitationInformationEntityList ?? new List<CMNEventInvitationInformationEntity>();
        }
    }
}
