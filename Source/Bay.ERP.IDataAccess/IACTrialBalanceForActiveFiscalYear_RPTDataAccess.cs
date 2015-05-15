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
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACTrialBalanceForActiveFiscalYear_RPTDataAccess

    public partial interface IACTrialBalanceForActiveFiscalYear_RPTDataAccess
    {
        #region Get

        IList<ACTrialBalanceForActiveFiscalYear_RPTEntity> GetIL(Int64 fiscalYearID);

        DataTable GetDT(Int64 fiscalYearID);

        #endregion Get

    }
    #endregion
}
