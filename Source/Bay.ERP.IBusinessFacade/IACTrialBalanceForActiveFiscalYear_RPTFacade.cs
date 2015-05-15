// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Feb-2013, 10:20:31




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACTrialBalanceForActiveFiscalYear_RPTFacade

    [ServiceContract(Name = "IACTrialBalanceForActiveFiscalYear_RPTFacade")]
    public partial interface IACTrialBalanceForActiveFiscalYear_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACTrialBalanceForActiveFiscalYear_RPTEntity> GetIL(Int64 fiscalYearID);

        [OperationContract]
        DataTable GetDT(Int64 fiscalYearID);

        #endregion Get

    }
    #endregion
}
