// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 12:10:49




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICMBillWithRequisitionItemMap_RPTDataAccess

    public partial interface ICMBillWithRequisitionItemMap_RPTDataAccess
    {
        #region Get

        IList<CMBillWithRequisitionItemMap_RPTEntity> GetIL(Int64 billID);

        DataTable GetDT(Int64 billID);

        #endregion Get

    }
    #endregion
}
