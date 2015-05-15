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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IHREmployeeLeaveStatus_RPTFacade

    [ServiceContract(Name = "IHREmployeeLeaveStatus_RPTFacade")]
    public partial interface IHREmployeeLeaveStatus_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<HREmployeeLeaveStatus_RPTEntity> GetIL(Int64 fiscalYearID);

        [OperationContract]
        DataTable GetDT(Int64 fiscalYearID);

        #endregion Get

    }
    #endregion
}