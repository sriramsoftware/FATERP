// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-May-2012, 12:37:41




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICMConsultantEnlistedWorkArea_CustomDataAccess

    public partial interface ICMConsultantEnlistedWorkArea_CustomDataAccess
    {
        #region Get

        IList<CMConsultantEnlistedWorkArea_CustomEntity> GetIL(String filterExpression);

        DataTable GetDT(String filterExpression);

        #endregion Get

    }
    #endregion
}
