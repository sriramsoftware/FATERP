// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Dec-2012, 04:37:54




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACCPrePayableStatementDetailByBill_CustomDataAccess

    public partial interface IACCPrePayableStatementDetailByBill_CustomDataAccess
    {
        #region Get

        IList<ACCPrePayableStatementDetailByBill_CustomEntity> GetIL(Int64 billID);

        DataTable GetDT(Int64 billID);

        #endregion Get

    }
    #endregion
}
