// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Jul-2013, 01:30:15




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IOTIssueWithEmployeeandDateWise_RPTDataAccess

    public partial interface IOTIssueWithEmployeeandDateWise_RPTDataAccess
    {
        #region Get

        IList<OTIssueWithEmployeeandDateWise_RPTEntity> GetIL(DateTime fromDate, DateTime toDate, Int64 employeeID);

        DataTable GetDT(DateTime fromDate, DateTime toDate, Int64 employeeID);

        #endregion Get

    }
    #endregion
}
