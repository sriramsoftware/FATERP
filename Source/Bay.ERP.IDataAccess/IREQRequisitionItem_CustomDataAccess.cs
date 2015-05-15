// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jun-2012, 10:09:58




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IREQRequisitionItem_CustomDataAccess

    public partial interface IREQRequisitionItem_CustomDataAccess
    {
        #region Get

        IList<REQRequisitionItem_CustomEntity> GetIL(String filterExpression);

        DataTable GetDT(String filterExpression);

        #endregion Get

    }
    #endregion
}
