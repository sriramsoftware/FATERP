// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 01:14:46




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomFacade

    [ServiceContract(Name = "IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomFacade")]
    public partial interface IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity> GetIL(Int64 prePayableStatementID, Int64 preparedByMemberID);

        [OperationContract]
        DataTable GetDT(Int64 prePayableStatementID, Int64 preparedByMemberID);

        #endregion Get

    }
    #endregion
}
