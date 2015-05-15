// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Aug-2013, 03:30:14




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IREQRequisitionItemFloorDetail_RPTDataAccess

    public partial interface IREQRequisitionItemFloorDetail_RPTDataAccess
    {
        #region Get

        IList<REQRequisitionItemFloorDetail_RPTEntity> GetIL(Int64 requisitionID);

        DataTable GetDT(Int64 requisitionID);

        #endregion Get

    }
    #endregion
}
