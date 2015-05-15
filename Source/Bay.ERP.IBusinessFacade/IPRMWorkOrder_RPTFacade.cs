// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Oct-2012, 09:52:02




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMWorkOrder_RPTFacade

    [ServiceContract(Name = "IPRMWorkOrder_RPTFacade")]
    public partial interface IPRMWorkOrder_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMWorkOrder_RPTEntity> GetIL(Int64 workOrderID);

        [OperationContract]
        DataTable GetDT(Int64 workOrderID);

        #endregion Get

    }
    #endregion
}
