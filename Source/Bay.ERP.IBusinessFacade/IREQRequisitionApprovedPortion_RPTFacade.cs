// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Jul-2012, 11:35:58




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IREQRequisitionApprovedPortion_RPTFacade

    [ServiceContract(Name = "IREQRequisitionApprovedPortion_RPTFacade")]
    public partial interface IREQRequisitionApprovedPortion_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<REQRequisitionApprovedPortion_RPTEntity> GetIL(Int64 projectID);

        [OperationContract]
        DataTable GetDT(Int64 projectID);

        #endregion Get

    }
    #endregion
}
