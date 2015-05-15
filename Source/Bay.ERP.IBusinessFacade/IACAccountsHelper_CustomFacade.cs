// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Feb-2013, 02:12:00




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IACAccountsHelper_CustomFacade

    [ServiceContract(Name = "IACAccountsHelper_CustomFacade")]
    public partial interface IACAccountsHelper_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<ACAccountsHelper_CustomEntity> GetIL(Int32 pageSize, Int32 currentPage, String filterExpression);

        [OperationContract]
        DataTable GetDT(Int32 pageSize, Int32 currentPage, String filterExpression);

        #endregion Get

    }
    #endregion
}
