// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 03:50:26




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IINV_MakeDefaultStore_CustomDataAccess

    public partial interface IINV_MakeDefaultStore_CustomDataAccess
    {
        #region Get

        IList<INV_MakeDefaultStore_CustomEntity> GetIL(Int64 projectID, Int64 storeID);

        DataTable GetDT(Int64 projectID, Int64 storeID);

        #endregion Get

    }
    #endregion
}