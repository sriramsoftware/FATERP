// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Mar-2012, 11:54:12




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICMCriterionStatusRemarks_DetailedDataAccess

    public partial interface ICMCriterionStatusRemarks_DetailedDataAccess
    {
        #region Get

        IList<CMCriterionStatusRemarks_DetailedEntity> GetIL(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression);

        DataTable GetDT(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression);

        #endregion Get

    }
    #endregion
}
