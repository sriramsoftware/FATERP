// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 12:59:56




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IHRGenerateEvaluation_CustomFacade

    [ServiceContract(Name = "IHRGenerateEvaluation_CustomFacade")]
    public partial interface IHRGenerateEvaluation_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<HRGenerateEvaluation_CustomEntity> GetIL(Int64 sessionID, Int64 evaluatedBy, Int64 salaryLevelFrom, Int64 salaryLevelTo);

        [OperationContract]
        DataTable GetDT(Int64 sessionID, Int64 evaluatedBy, Int64 salaryLevelFrom, Int64 salaryLevelTo);

        #endregion Get

    }
    #endregion
}
