// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Jun-2012, 12:03:16




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IOTIssue_RPTDataAccess

    public partial interface IOTIssue_RPTDataAccess
    {
        #region Get

        IList<OTIssue_RPTEntity> GetIL(Int64 issueID);

        DataTable GetDT(Int64 issueID);

        #endregion Get

    }
    #endregion
}
