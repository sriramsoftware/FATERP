// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Dec-2013, 10:06:11




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IHREmployeeResume_RPTDataAccess

    public partial interface IHREmployeeResume_RPTDataAccess
    {
        #region Get

        IList<HREmployeeResume_RPTEntity> GetIL(Int64 employeeID);

        DataTable GetDT(Int64 employeeID);

        #endregion Get

    }
    #endregion
}
