// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Dec-2013, 06:06:24




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IHRWorkingDay_RPTFacade

    [ServiceContract(Name = "IHRWorkingDay_RPTFacade")]
    public partial interface IHRWorkingDay_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<HRWorkingDay_RPTEntity> GetIL(Int64 salarySessionID);

        [OperationContract]
        DataTable GetDT(Int64 salarySessionID);

        #endregion Get

    }
    #endregion
}
