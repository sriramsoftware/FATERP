// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Jul-2013, 10:23:15




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACBankAccountPayment_RPTFacade

    [ServiceContract(Name = "IACBankAccountPayment_RPTFacade")]
    public partial interface IACBankAccountPayment_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACBankAccountPayment_RPTEntity> GetIL(Int64 bankAccountPaymentID);

        [OperationContract]
        DataTable GetDT(Int64 bankAccountPaymentID);

        #endregion Get

    }
    #endregion
}
