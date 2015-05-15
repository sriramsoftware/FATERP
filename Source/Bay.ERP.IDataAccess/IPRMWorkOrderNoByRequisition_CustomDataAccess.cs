// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Dec-2012, 10:27:04




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMWorkOrderNoByRequisition_CustomDataAccess

    public partial interface IPRMWorkOrderNoByRequisition_CustomDataAccess
    {
        #region Get

        IList<PRMWorkOrderNoByRequisition_CustomEntity> GetIL(Int64 rEQRequisitionID);

        DataTable GetDT(Int64 rEQRequisitionID);

        #endregion Get

    }
    #endregion
}
