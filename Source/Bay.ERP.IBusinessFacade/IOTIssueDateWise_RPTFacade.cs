// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jul-2013, 05:49:04




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IOTIssueDateWise_RPTFacade

    [ServiceContract(Name = "IOTIssueDateWise_RPTFacade")]
    public partial interface IOTIssueDateWise_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<OTIssueDateWise_RPTEntity> GetIL(DateTime fromDate, DateTime toDate);

        [OperationContract]
        DataTable GetDT(DateTime fromDate, DateTime toDate);

        #endregion Get

    }
    #endregion
}
