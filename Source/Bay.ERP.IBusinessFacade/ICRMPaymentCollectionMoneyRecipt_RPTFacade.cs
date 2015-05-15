// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-May-2013, 03:57:32




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICRMPaymentCollectionMoneyRecipt_RPTFacade

    [ServiceContract(Name = "ICRMPaymentCollectionMoneyRecipt_RPTFacade")]
    public partial interface ICRMPaymentCollectionMoneyRecipt_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<CRMPaymentCollectionMoneyRecipt_RPTEntity> GetIL(Int64 paymentCollectionID);

        [OperationContract]
        DataTable GetDT(Int64 paymentCollectionID);

        #endregion Get

    }
    #endregion
}
