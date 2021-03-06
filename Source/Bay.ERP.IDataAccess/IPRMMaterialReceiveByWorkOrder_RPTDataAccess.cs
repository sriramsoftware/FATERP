// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Oct-2012, 01:00:56




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMMaterialReceiveByWorkOrder_RPTDataAccess

    public partial interface IPRMMaterialReceiveByWorkOrder_RPTDataAccess
    {
        #region Get

        IList<PRMMaterialReceiveByWorkOrder_RPTEntity> GetIL(Int64 workOrderID);

        DataTable GetDT(Int64 workOrderID);

        #endregion Get

    }
    #endregion
}
