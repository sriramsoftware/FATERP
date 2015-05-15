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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IHREmployeeSalaryPayment_RPTFacade

    [ServiceContract(Name = "IHREmployeeSalaryPayment_RPTFacade")]
    public partial interface IHREmployeeSalaryPayment_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<HREmployeeSalaryPayment_RPTEntity> GetIL(Int64 salarySessionID, Int64 from, Int64 to, Int64 other);

        [OperationContract]
        DataTable GetDT(Int64 salarySessionID, Int64 from, Int64 to, Int64 other);

        #endregion Get

    }
    #endregion
}
