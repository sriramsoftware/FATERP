// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IHRSession_DetailedDataAccess

    public partial interface IHRSession_DetailedDataAccess
    {
        #region Get

        IList<HRSession_DetailedEntity> GetIL(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression);

        DataTable GetDT(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression);

        #endregion Get

    }
    #endregion
}
