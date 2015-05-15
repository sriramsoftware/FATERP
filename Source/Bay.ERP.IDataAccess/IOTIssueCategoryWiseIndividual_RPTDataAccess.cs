// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Aug-2013, 03:52:52




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IOTIssueCategoryWiseIndividual_RPTDataAccess

    public partial interface IOTIssueCategoryWiseIndividual_RPTDataAccess
    {
        #region Get

        IList<OTIssueCategoryWiseIndividual_RPTEntity> GetIL(DateTime fromDate, DateTime toDate, Int64 assingedEmployeeID);

        DataTable GetDT(DateTime fromDate, DateTime toDate, Int64 assingedEmployeeID);

        #endregion Get

    }
    #endregion
}
