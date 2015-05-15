// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Dec-2012, 01:43:33




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMApprovedAdvancePaymentWorkOrder_CustomFacade

    [ServiceContract(Name = "IPRMApprovedAdvancePaymentWorkOrder_CustomFacade")]
    public partial interface IPRMApprovedAdvancePaymentWorkOrder_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMApprovedAdvancePaymentWorkOrder_CustomEntity> GetIL();

        [OperationContract]
        DataTable GetDT();

        #endregion Get

    }
    #endregion
}
