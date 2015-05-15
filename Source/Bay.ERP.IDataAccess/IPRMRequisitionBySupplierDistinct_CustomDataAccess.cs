// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Jul-2012, 03:56:56




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMRequisitionBySupplierDistinct_CustomDataAccess

    public partial interface IPRMRequisitionBySupplierDistinct_CustomDataAccess
    {
        #region Get

        IList<PRMRequisitionBySupplierDistinct_CustomEntity> GetIL(Int64 supplierID);

        DataTable GetDT(Int64 supplierID);

        #endregion Get

    }
    #endregion
}
