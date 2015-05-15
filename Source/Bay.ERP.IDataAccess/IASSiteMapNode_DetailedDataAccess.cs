// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:34:29




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IASSiteMapNode_DetailedDataAccess

    public partial interface IASSiteMapNode_DetailedDataAccess
    {
        #region Get

        IList<ASSiteMapNode_DetailedEntity> GetIL(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression);

        DataTable GetDT(Int32 startRowIndex, Int32 pageSize, String sortExpression, String filterExpression);

        #endregion Get

    }
    #endregion
}
