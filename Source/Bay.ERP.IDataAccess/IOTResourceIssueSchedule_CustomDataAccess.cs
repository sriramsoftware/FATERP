// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 18-Jun-2012, 11:27:18




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IOTResourceIssueSchedule_CustomDataAccess

    public partial interface IOTResourceIssueSchedule_CustomDataAccess
    {
        #region Get

        IList<OTResourceIssueSchedule_CustomEntity> GetIL(Int64 resourceID, Int64 resourceCategoryID);

        DataTable GetDT(Int64 resourceID, Int64 resourceCategoryID);

        #endregion Get

    }
    #endregion
}
