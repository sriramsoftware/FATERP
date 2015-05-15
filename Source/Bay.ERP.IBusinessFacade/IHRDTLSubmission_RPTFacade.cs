// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 24-Sep-2013, 12:20:17




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IHRDTLSubmission_RPTFacade

    [ServiceContract(Name = "IHRDTLSubmission_RPTFacade")]
    public partial interface IHRDTLSubmission_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<HRDTLSubmission_RPTEntity> GetIL(DateTime fromDate, DateTime toDate);

        [OperationContract]
        DataTable GetDT(DateTime fromDate, DateTime toDate);

        #endregion Get

    }
    #endregion
}
