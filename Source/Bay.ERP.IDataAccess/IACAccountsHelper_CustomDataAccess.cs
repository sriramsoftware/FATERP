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
    #region IACAccountsHelper_CustomDataAccess

    public partial interface IACAccountsHelper_CustomDataAccess
    {
        #region Get

        IList<ACAccountsHelper_CustomEntity> GetIL(Int32 pageSize, Int32 currentPage, String filterExpression);

        DataTable GetDT(Int32 pageSize, Int32 currentPage, String filterExpression);

        #endregion Get

    }
    #endregion
}
