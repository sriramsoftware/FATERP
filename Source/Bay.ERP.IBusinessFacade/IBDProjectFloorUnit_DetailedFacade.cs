// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Apr-2013, 03:03:13




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IBDProjectFloorUnit_DetailedFacade

    [ServiceContract(Name = "IBDProjectFloorUnit_DetailedFacade")]
    public partial interface IBDProjectFloorUnit_DetailedFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<BDProjectFloorUnit_DetailedEntity> GetIL(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression);

        [OperationContract]
        DataTable GetDT(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression);

        #endregion Get

    }
    #endregion
}
