// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-May-2013, 01:39:36




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICRMPaymentEncashed_RPTFacade

    [ServiceContract(Name = "ICRMPaymentEncashed_RPTFacade")]
    public partial interface ICRMPaymentEncashed_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<CRMPaymentEncashed_RPTEntity> GetIL(DateTime toDate, Boolean encashed);

        [OperationContract]
        DataTable GetDT(DateTime toDate, Boolean encashed);

        #endregion Get

    }
    #endregion
}
