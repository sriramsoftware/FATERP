// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Apr-2012, 03:22:36




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMSupplierByBrand_CustomDataAccess

    public partial interface IPRMSupplierByBrand_CustomDataAccess
    {
        #region Get

        IList<PRMSupplierByBrand_CustomEntity> GetIL(Int64 brandID);

        DataTable GetDT(Int64 brandID);

        #endregion Get

    }
    #endregion
}
