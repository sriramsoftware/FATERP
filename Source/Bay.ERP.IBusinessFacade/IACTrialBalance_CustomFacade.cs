// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Feb-2013, 02:55:33




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACTrialBalance_CustomFacade

    [ServiceContract(Name = "IACTrialBalance_CustomFacade")]
    public partial interface IACTrialBalance_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACTrialBalance_CustomEntity> GetIL(DateTime fromDate, DateTime toDate, Int64 fiscalYearID);

        [OperationContract]
        DataTable GetDT(DateTime fromDate, DateTime toDate, Int64 fiscalYearID);

        #endregion Get

    }
    #endregion
}
