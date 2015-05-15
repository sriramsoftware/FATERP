// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IHREmployeeSalaryDisbursementBank_RPTDataAccess

    public partial interface IHREmployeeSalaryDisbursementBank_RPTDataAccess
    {
        #region Get

        IList<HREmployeeSalaryDisbursementBank_RPTEntity> GetIL(Int64 salarySessionID, Int64 fromLevel, Int64 toLevel);

        DataTable GetDT(Int64 salarySessionID, Int64 fromLevel, Int64 toLevel);

        #endregion Get

    }
    #endregion
}
