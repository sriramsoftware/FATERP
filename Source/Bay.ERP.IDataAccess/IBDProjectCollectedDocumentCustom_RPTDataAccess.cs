// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jul-2013, 10:34:17




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IBDProjectCollectedDocumentCustom_RPTDataAccess

    public partial interface IBDProjectCollectedDocumentCustom_RPTDataAccess
    {
        #region Get

        IList<BDProjectCollectedDocumentCustom_RPTEntity> GetIL(Int64 projectID);

        DataTable GetDT(Int64 projectID);

        #endregion Get

    }
    #endregion
}
