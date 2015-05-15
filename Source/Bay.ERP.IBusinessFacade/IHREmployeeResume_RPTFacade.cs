// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Sep-2013, 12:39:02




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{
    #region IHREmployeeResume_RPTFacade

    [ServiceContract(Name = "IHREmployeeResume_RPTFacade")]
    public partial interface IHREmployeeResume_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<HREmployeeResume_RPTEntity> GetIL(Int64 employeeID);

        [OperationContract]
        DataTable GetDT(Int64 employeeID);

        #endregion Get

    }
    #endregion
}
