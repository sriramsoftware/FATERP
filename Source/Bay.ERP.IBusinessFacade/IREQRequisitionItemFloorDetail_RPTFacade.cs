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
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IREQRequisitionItemFloorDetail_RPTFacade

    [ServiceContract(Name = "IREQRequisitionItemFloorDetail_RPTFacade")]
    public partial interface IREQRequisitionItemFloorDetail_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<REQRequisitionItemFloorDetail_RPTEntity> GetIL(Int64 requisitionID);

        [OperationContract]
        DataTable GetDT(Int64 requisitionID);

        #endregion Get

    }
    #endregion
}