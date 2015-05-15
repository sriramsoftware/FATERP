// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Feb-2013, 12:00:23




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACBalanceSheet_RPTFacade

    [ServiceContract(Name = "IACBalanceSheet_RPTFacade")]
    public partial interface IACBalanceSheet_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACBalanceSheet_RPTEntity> GetIL(Int64 fiscalYearID, DateTime fromDate, DateTime toDate);

        [OperationContract]
        DataTable GetDT(Int64 fiscalYearID, DateTime fromDate, DateTime toDate);

        #endregion Get

    }
    #endregion
}
