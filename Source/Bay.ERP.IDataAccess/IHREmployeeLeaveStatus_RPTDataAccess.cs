// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Jan-2014, 04:20:23




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IHREmployeeLeaveStatus_RPTDataAccess

    public partial interface IHREmployeeLeaveStatus_RPTDataAccess
    {
        #region Get

        IList<HREmployeeLeaveStatus_RPTEntity> GetIL(Int64 fiscalYearID);

        DataTable GetDT(Int64 fiscalYearID);

        #endregion Get

    }
    #endregion
}
