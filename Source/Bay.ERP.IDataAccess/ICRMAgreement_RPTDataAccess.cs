// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2013, 01:42:12




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region ICRMAgreement_RPTDataAccess

    public partial interface ICRMAgreement_RPTDataAccess
    {
        #region Get

        IList<CRMAgreement_RPTEntity> GetIL(Int64 agreementID);

        DataTable GetDT(Int64 agreementID);

        #endregion Get

    }
    #endregion
}
