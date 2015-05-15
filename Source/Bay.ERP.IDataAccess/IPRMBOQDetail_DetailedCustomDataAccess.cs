// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2012, 04:17:30




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMBOQDetail_DetailedCustomDataAccess

    public partial interface IPRMBOQDetail_DetailedCustomDataAccess
    {
        #region Get

        IList<PRMBOQDetail_DetailedCustomEntity> GetIL(String filterExpression);

        DataTable GetDT(String filterExpression);

        #endregion Get

    }
    #endregion
}
