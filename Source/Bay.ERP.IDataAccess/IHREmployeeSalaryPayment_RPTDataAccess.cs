// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Jan-2014, 01:58:57




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IHREmployeeSalaryPayment_RPTDataAccess

    public partial interface IHREmployeeSalaryPayment_RPTDataAccess
    {
        #region Get

        IList<HREmployeeSalaryPayment_RPTEntity> GetIL(Int64 salarySessionID, Int64 from, Int64 to, Int64 other);

        DataTable GetDT(Int64 salarySessionID, Int64 from, Int64 to, Int64 other);

        #endregion Get

    }
    #endregion
}
