// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-May-2013, 04:56:23




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICRMBookingStatus_RPTFacade

    [ServiceContract(Name = "ICRMBookingStatus_RPTFacade")]
    public partial interface ICRMBookingStatus_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<CRMBookingStatus_RPTEntity> GetIL();

        [OperationContract]
        DataTable GetDT();

        #endregion Get

    }
    #endregion
}
