// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Dec-2012, 04:37:54




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACCPrePayableStatementDetailByBill_CustomFacade

    [ServiceContract(Name = "IACCPrePayableStatementDetailByBill_CustomFacade")]
    public partial interface IACCPrePayableStatementDetailByBill_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACCPrePayableStatementDetailByBill_CustomEntity> GetIL(Int64 billID);

        [OperationContract]
        DataTable GetDT(Int64 billID);

        #endregion Get

    }
    #endregion
}
