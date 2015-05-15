// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Feb-2013, 02:55:23




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACAccountBalanceSheet_CustomFacade

    [ServiceContract(Name = "IACAccountBalanceSheet_CustomFacade")]
    public partial interface IACAccountBalanceSheet_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACAccountBalanceSheet_CustomEntity> GetIL(Int64 accountGroupID, Int64 fiscalYearID, DateTime asAtDate);

        [OperationContract]
        DataTable GetDT(Int64 accountGroupID, Int64 fiscalYearID, DateTime asAtDate);

        #endregion Get

    }
    #endregion
}
