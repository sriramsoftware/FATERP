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
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICRMPaymentCollectionMoneyRecipt_RPTDataAccess

    public partial interface ICRMPaymentCollectionMoneyRecipt_RPTDataAccess
    {
        #region Get

        IList<CRMPaymentCollectionMoneyRecipt_RPTEntity> GetIL(Int64 paymentCollectionID);

        DataTable GetDT(Int64 paymentCollectionID);

        #endregion Get

    }
    #endregion
}
