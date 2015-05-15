// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2013, 11:43:49




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACTemporaryJournal_RPTFacade

    [ServiceContract(Name = "IACTemporaryJournal_RPTFacade")]
    public partial interface IACTemporaryJournal_RPTFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACTemporaryJournal_RPTEntity> GetIL(Int64 temporaryJournalMasterID);

        [OperationContract]
        DataTable GetDT(Int64 temporaryJournalMasterID);

        #endregion Get

    }
    #endregion
}
