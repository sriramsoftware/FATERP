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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMWorkOrderItemByWorkOrder_CustomFacade

    [ServiceContract(Name = "IPRMWorkOrderItemByWorkOrder_CustomFacade")]
    public partial interface IPRMWorkOrderItemByWorkOrder_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMWorkOrderItemByWorkOrder_CustomEntity> GetIL(Int64 workOrderID);

        [OperationContract]
        DataTable GetDT(Int64 workOrderID);

        #endregion Get

    }
    #endregion
}
