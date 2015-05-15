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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICMBill_RPTFacade

    [ServiceContract(Name = "ICMBill_RPTFacade")]
    public partial interface ICMBill_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<CMBill_RPTEntity> GetIL(Int64 billID);

        [OperationContract]
        DataTable GetDT(Int64 billID);

        #endregion Get

    }
    #endregion
}
