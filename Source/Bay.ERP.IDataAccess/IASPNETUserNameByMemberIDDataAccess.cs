// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:49:25




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IASPNETUserNameByMemberIDDataAccess

    public partial interface IASPNETUserNameByMemberIDDataAccess
    {
        #region Get

        IList<ASPNETUserNameByMemberIDEntity> GetIL(Int64 memberID);

        DataTable GetDT(Int64 memberID);

        #endregion Get

    }
    #endregion
}
