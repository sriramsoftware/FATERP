// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Oct-2012, 09:30:27




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMWorkOrderItemDetail_RPTDataAccess

    public partial interface IPRMWorkOrderItemDetail_RPTDataAccess
    {
        #region Get

        IList<PRMWorkOrderItemDetail_RPTEntity> GetIL(Int64 workOrderItemMap);

        DataTable GetDT(Int64 workOrderItemMap);

        #endregion Get

    }
    #endregion
}
