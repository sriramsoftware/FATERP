// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Feb-2013, 12:02:49




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACAccountOpenCloseBalance_CustomDataAccess

    public partial interface IACAccountOpenCloseBalance_CustomDataAccess
    {
        #region Get

        IList<ACAccountOpenCloseBalance_CustomEntity> GetIL(Int64 accountID, Int64 fiscalYearID, DateTime fromDate, DateTime toDate);

        DataTable GetDT(Int64 accountID, Int64 fiscalYearID, DateTime fromDate, DateTime toDate);

        #endregion Get

    }
    #endregion
}
