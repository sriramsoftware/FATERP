// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2012, 03:36:37




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMItemBrandMapDistinct_CustomDataAccess

    public partial interface IPRMItemBrandMapDistinct_CustomDataAccess
    {
        #region Get

        IList<PRMItemBrandMapDistinct_CustomEntity> GetIL(Int64 supplierID);

        DataTable GetDT(Int64 supplierID);

        #endregion Get

    }
    #endregion
}
