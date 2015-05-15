// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2013, 01:09:58




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICRMDuePaymentFromPaymentSchedule_RPTFacade

    [ServiceContract(Name = "ICRMDuePaymentFromPaymentSchedule_RPTFacade")]
    public partial interface ICRMDuePaymentFromPaymentSchedule_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<CRMDuePaymentFromPaymentSchedule_RPTEntity> GetIL(DateTime toDate);

        [OperationContract]
        DataTable GetDT(DateTime toDate);

        #endregion Get

    }
    #endregion
}
