// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-May-2012, 04:28:13




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.BusinessFacade
{    
    #region IPreBOQtoBOQMigration_CustomFacade

    [ServiceContract(Name = "IPreBOQtoBOQMigration_CustomFacade")]
    public partial interface IPreBOQtoBOQMigration_CustomFacade : IDisposable
    {
        #region Get

        [OperationContract]
        IList<PreBOQtoBOQMigration_CustomEntity> GetIL(Int64 preBOQID, Int64 preparedByMemberID);

        [OperationContract]
        DataTable GetDT(Int64 preBOQID, Int64 preparedByMemberID);

        #endregion Get

    }
    #endregion
}
