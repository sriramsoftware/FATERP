// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2014, 10:14:40




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IHREmployeeAddressInfo_DetailedFacade

    [ServiceContract(Name = "IHREmployeeAddressInfo_DetailedFacade")]
    public partial interface IHREmployeeAddressInfo_DetailedFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<HREmployeeAddressInfo_DetailedEntity> GetIL(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression);

        [OperationContract]
        DataTable GetDT(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression);

        #endregion Get

    }
    #endregion
}
