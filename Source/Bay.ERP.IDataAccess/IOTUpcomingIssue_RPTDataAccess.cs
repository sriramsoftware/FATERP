// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-May-2012, 05:15:27




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IOTUpcomingIssue_RPTDataAccess

    public partial interface IOTUpcomingIssue_RPTDataAccess
    {
        #region Get

        IList<OTUpcomingIssue_RPTEntity> GetIL();

        DataTable GetDT();

        #endregion Get

    }
    #endregion
}
