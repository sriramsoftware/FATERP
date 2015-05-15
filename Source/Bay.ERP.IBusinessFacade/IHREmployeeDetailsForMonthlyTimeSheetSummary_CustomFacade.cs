// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jan-2014, 04:42:27




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomFacade

    [ServiceContract(Name = "IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomFacade")]
    public partial interface IHREmployeeDetailsForMonthlyTimeSheetSummary_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<HREmployeeDetailsForMonthlyTimeSheetSummary_CustomEntity> GetIL(Int64 salarySessionID);

        [OperationContract]
        DataTable GetDT(Int64 salarySessionID);

        #endregion Get

    }
    #endregion
}
