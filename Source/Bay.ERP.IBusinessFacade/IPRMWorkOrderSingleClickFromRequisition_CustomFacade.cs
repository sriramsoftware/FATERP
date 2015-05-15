// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2013, 02:31:14




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMWorkOrderSingleClickFromRequisition_CustomFacade

    [ServiceContract(Name = "IPRMWorkOrderSingleClickFromRequisition_CustomFacade")]
    public partial interface IPRMWorkOrderSingleClickFromRequisition_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMWorkOrderSingleClickFromRequisition_CustomEntity> GetIL(Int64 requisitionID, Int64 preparedByMemberID);

        [OperationContract]
        DataTable GetDT(Int64 requisitionID, Int64 preparedByMemberID);

        #endregion Get

    }
    #endregion
}
