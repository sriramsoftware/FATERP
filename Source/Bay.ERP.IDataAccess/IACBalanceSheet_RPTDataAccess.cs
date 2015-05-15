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
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACBalanceSheet_RPTDataAccess

    public partial interface IACBalanceSheet_RPTDataAccess
    {
        #region Get

        IList<ACBalanceSheet_RPTEntity> GetIL(Int64 fiscalYearID, DateTime fromDate, DateTime toDate);

        DataTable GetDT(Int64 fiscalYearID, DateTime fromDate, DateTime toDate);

        #endregion Get

    }
    #endregion
}
