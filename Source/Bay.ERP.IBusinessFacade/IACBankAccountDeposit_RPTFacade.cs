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
    #region IACBankAccountDeposit_RPTFacade

    [ServiceContract(Name = "IACBankAccountDeposit_RPTFacade")]
    public partial interface IACBankAccountDeposit_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACBankAccountDeposit_RPTEntity> GetIL(Int64 bankAccountDepositID);

        [OperationContract]
        DataTable GetDT(Int64 bankAccountDepositID);

        #endregion Get

    }
    #endregion
}
