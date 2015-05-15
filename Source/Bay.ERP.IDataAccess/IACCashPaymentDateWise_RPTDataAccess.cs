// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2013, 02:22:23




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IACCashPaymentDateWise_RPTDataAccess

    public partial interface IACCashPaymentDateWise_RPTDataAccess
    {
        #region Get

        IList<ACCashPaymentDateWise_RPTEntity> GetIL(DateTime fromDate, DateTime toDate);

        DataTable GetDT(DateTime fromDate, DateTime toDate);

        #endregion Get

    }
    #endregion
}
