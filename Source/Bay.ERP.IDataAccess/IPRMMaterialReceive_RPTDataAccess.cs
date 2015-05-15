// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jul-2012, 11:22:51




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMMaterialReceive_RPTDataAccess

    public partial interface IPRMMaterialReceive_RPTDataAccess
    {
        #region Get

        IList<PRMMaterialReceive_RPTEntity> GetIL(Int64 materialReceiveID);

        DataTable GetDT(Int64 materialReceiveID);

        #endregion Get

    }
    #endregion
}
