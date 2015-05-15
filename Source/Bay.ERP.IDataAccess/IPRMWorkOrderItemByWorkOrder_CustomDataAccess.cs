// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Oct-2012, 11:18:20




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMWorkOrderItemByWorkOrder_CustomDataAccess

    public partial interface IPRMWorkOrderItemByWorkOrder_CustomDataAccess
    {
        #region Get

        IList<PRMWorkOrderItemByWorkOrder_CustomEntity> GetIL(Int64 workOrderID);

        DataTable GetDT(Int64 workOrderID);

        #endregion Get

    }
    #endregion
}
