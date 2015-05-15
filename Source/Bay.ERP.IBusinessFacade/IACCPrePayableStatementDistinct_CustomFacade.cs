// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jan-2013, 05:19:48




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACCPrePayableStatementDistinct_CustomFacade

    [ServiceContract(Name = "IACCPrePayableStatementDistinct_CustomFacade")]
    public partial interface IACCPrePayableStatementDistinct_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACCPrePayableStatementDistinct_CustomEntity> GetIL();

        [OperationContract]
        DataTable GetDT();

        #endregion Get

    }
    #endregion
}
