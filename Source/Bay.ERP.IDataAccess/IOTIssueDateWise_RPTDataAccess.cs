// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jul-2013, 05:49:04




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IOTIssueDateWise_RPTDataAccess

    public partial interface IOTIssueDateWise_RPTDataAccess
    {
        #region Get

        IList<OTIssueDateWise_RPTEntity> GetIL(DateTime fromDate, DateTime toDate);

        DataTable GetDT(DateTime fromDate, DateTime toDate);

        #endregion Get

    }
    #endregion
}