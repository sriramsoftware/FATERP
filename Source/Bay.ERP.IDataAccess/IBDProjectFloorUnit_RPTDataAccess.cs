// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IBDProjectFloorUnit_RPTDataAccess

    public partial interface IBDProjectFloorUnit_RPTDataAccess
    {
        #region Get
       
        IList<BDProjectFloorUnit_RPTEntity> GetIL(Int64 id);

        DataTable GetDT(Int64 id);

        #endregion Get

    }
    #endregion
}
