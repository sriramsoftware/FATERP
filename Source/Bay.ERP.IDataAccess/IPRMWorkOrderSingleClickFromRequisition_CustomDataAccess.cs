// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Sep-2013, 02:31:14




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMWorkOrderSingleClickFromRequisition_CustomDataAccess

    public partial interface IPRMWorkOrderSingleClickFromRequisition_CustomDataAccess
    {
        #region Get

        IList<PRMWorkOrderSingleClickFromRequisition_CustomEntity> GetIL(Int64 requisitionID, Int64 preparedByMemberID);

        DataTable GetDT(Int64 requisitionID, Int64 preparedByMemberID);

        #endregion Get

    }
    #endregion
}
