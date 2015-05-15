// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 05:23:47




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACAccountGroupBalanceSheet_CustomDataAccess

    public partial interface IACAccountGroupBalanceSheet_CustomDataAccess
    {
        #region Get

        IList<ACAccountGroupBalanceSheet_CustomEntity> GetIL(Int64 fiscalYearID, DateTime asAtDate);

        DataTable GetDT(Int64 fiscalYearID, DateTime asAtDate);

        #endregion Get

    }
    #endregion
}
