// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Apr-2012, 10:30:24




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMSupplierItemMapHistory_RPTDataAccess

    public partial interface IPRMSupplierItemMapHistory_RPTDataAccess
    {
        #region Get

        IList<PRMSupplierItemMapHistory_RPTEntity> GetIL(Int64 itemID);

        DataTable GetDT(Int64 itemID);

        #endregion Get

    }
    #endregion
}
