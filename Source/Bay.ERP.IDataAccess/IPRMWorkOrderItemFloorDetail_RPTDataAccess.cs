// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Aug-2013, 02:00:59




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMWorkOrderItemFloorDetail_RPTDataAccess

    public partial interface IPRMWorkOrderItemFloorDetail_RPTDataAccess
    {
        #region Get

        IList<PRMWorkOrderItemFloorDetail_RPTEntity> GetIL(Int64 workOrderID);

        DataTable GetDT(Int64 workOrderID);

        #endregion Get

    }
    #endregion
}
