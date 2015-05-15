// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Dec-2013, 03:16:13




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IHREmployeeEvaluationReportForAllEmployee_RPTDataAccess

    public partial interface IHREmployeeEvaluationReportForAllEmployee_RPTDataAccess
    {
        #region Get

        IList<HREmployeeEvaluationReportForAllEmployee_RPTEntity> GetIL(Int64 sessionID);

        DataTable GetDT(Int64 sessionID);

        #endregion Get

    }
    #endregion
}
