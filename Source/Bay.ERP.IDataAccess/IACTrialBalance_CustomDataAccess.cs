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
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACTrialBalance_CustomDataAccess

    public partial interface IACTrialBalance_CustomDataAccess
    {
        #region Get

        IList<ACTrialBalance_CustomEntity> GetIL(DateTime fromDate, DateTime toDate, Int64 fiscalYearID);

        DataTable GetDT(DateTime fromDate, DateTime toDate, Int64 fiscalYearID);

        #endregion Get

    }
    #endregion
}
