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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPRMWorkOrderItemDetail_RPTFacade

    [ServiceContract(Name = "IPRMWorkOrderItemDetail_RPTFacade")]
    public partial interface IPRMWorkOrderItemDetail_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PRMWorkOrderItemDetail_RPTEntity> GetIL(Int64 workOrderItemMap);

        [OperationContract]
        DataTable GetDT(Int64 workOrderItemMap);

        #endregion Get

    }
    #endregion
}
