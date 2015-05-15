// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Jan-2012, 02:37:47




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICMProjectMilestone_CustomDataAccess

    public partial interface ICMProjectMilestone_CustomDataAccess
    {
        #region Get

        IList<CMProjectMilestone_CustomEntity> GetIL(Int64 projectID);

        DataTable GetDT(Int64 projectID);

        #endregion Get

    }
    #endregion
}
