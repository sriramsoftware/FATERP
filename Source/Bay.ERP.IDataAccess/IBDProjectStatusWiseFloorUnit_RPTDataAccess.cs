// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 04:56:23




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IBDProjectStatusWiseFloorUnit_RPTDataAccess

    public partial interface IBDProjectStatusWiseFloorUnit_RPTDataAccess
    {
        #region Get

        IList<BDProjectStatusWiseFloorUnit_RPTEntity> GetIL(Int64 projectFloorUnitStatusID);

        DataTable GetDT(Int64 projectFloorUnitStatusID);

        #endregion Get

    }
    #endregion
}