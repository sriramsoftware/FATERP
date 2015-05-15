// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 15-May-2013, 01:17:08




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICRMPaymentCollection_RPTDataAccess

    public partial interface ICRMPaymentCollection_RPTDataAccess
    {
        #region Get

        IList<CRMPaymentCollection_RPTEntity> GetIL(Int64 paymentScheduleID);

        DataTable GetDT(Int64 paymentScheduleID);

        #endregion Get

    }
    #endregion
}
