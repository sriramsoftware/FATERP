// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jan-2012, 02:37:15




using System;
using System.Collections.Generic;
using System.Data;
using System.Collections;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    #region IBulkInsertXMLDataAccess

    public partial interface IBulkInsertXMLDataAccess
    {
        #region Get

        IList<BulkInsertXMLEntity> GetIL(String xVar, Int32 tableInfo);

        DataTable GetDT(String xVar, Int32 tableInfo);

        #endregion Get

    }
    #endregion
}
