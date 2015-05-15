// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Dec-2012, 10:46:38




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACCPrePayableStatementDetail_CustomFacade

    [ServiceContract(Name = "IACCPrePayableStatementDetail_CustomFacade")]
    public partial interface IACCPrePayableStatementDetail_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACCPrePayableStatementDetail_CustomEntity> GetIL(DateTime startDate, DateTime endDate);

        [OperationContract]
        DataTable GetDT(DateTime startDate, DateTime endDate);

        #endregion Get

    }
    #endregion
}
