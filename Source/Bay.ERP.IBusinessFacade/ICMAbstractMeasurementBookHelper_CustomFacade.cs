// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Oct-2012, 04:30:09




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region ICMAbstractMeasurementBookHelper_CustomFacade

    [ServiceContract(Name = "ICMAbstractMeasurementBookHelper_CustomFacade")]
    public partial interface ICMAbstractMeasurementBookHelper_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<CMAbstractMeasurementBookHelper_CustomEntity> GetIL(Int64 projectID, Int64 itemID);

        [OperationContract]
        DataTable GetDT(Int64 projectID, Int64 itemID);

        #endregion Get

    }
    #endregion
}
