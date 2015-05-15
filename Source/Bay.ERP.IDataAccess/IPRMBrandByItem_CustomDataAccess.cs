// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Jul-2012, 02:21:44




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMBrandByItem_CustomDataAccess

    public partial interface IPRMBrandByItem_CustomDataAccess
    {
        #region Get

        IList<PRMBrandByItem_CustomEntity> GetIL(Int64 itemID);

        DataTable GetDT(Int64 itemID);

        #endregion Get

    }
    #endregion
}
