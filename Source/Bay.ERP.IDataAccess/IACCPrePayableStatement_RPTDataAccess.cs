// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Dec-2012, 12:17:40




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACCPrePayableStatement_RPTDataAccess

    public partial interface IACCPrePayableStatement_RPTDataAccess
    {
        #region Get

        IList<ACCPrePayableStatement_RPTEntity> GetIL(Int64 prePayableStatementID);

        DataTable GetDT(Int64 prePayableStatementID);

        #endregion Get

    }
    #endregion
}
