// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-Oct-2012, 01:09:23




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IPRMBOQRequisitionItem_CustomDataAccess

    public partial interface IPRMBOQRequisitionItem_CustomDataAccess
    {
        #region Get

        IList<PRMBOQRequisitionItem_CustomEntity> GetIL(Int64 projectID, Int64 itemCategoryID);

        DataTable GetDT(Int64 projectID, Int64 itemCategoryID);

        #endregion Get

    }
    #endregion
}
