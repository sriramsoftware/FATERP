// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Nov-2011, 03:17:49




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.BusinessFacade
{
    #region IMDItemFacade

    public partial interface IMDItemFacade
    {
        #region Extra Methods

        [OperationContract]
        IList<MDItemEntity> GetILFC();

        [OperationContract]
        IList<MDItemEntity> GetByCategoryIDILFC(Int64 categoryID);

        [OperationContract]
        void RemoveCache();

        #endregion Extra Methods
    }
    #endregion
}
