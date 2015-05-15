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
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICRMPaymentEncashed_RPTDataAccess

    public partial interface ICRMPaymentEncashed_RPTDataAccess
    {
        #region Get

        IList<CRMPaymentEncashed_RPTEntity> GetIL(DateTime toDate, Boolean encashed);

        DataTable GetDT(DateTime toDate, Boolean encashed);

        #endregion Get

    }
    #endregion
}
