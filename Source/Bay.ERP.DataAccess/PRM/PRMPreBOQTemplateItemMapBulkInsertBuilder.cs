// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jan-2012, 03:42:46




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMPreBOQTemplateItemMapBulkInsertBuilder : IEntityBuilder<PRMPreBOQTemplateItemMapBulkInsertEntity>
    {
        IList<PRMPreBOQTemplateItemMapBulkInsertEntity> IEntityBuilder<PRMPreBOQTemplateItemMapBulkInsertEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMPreBOQTemplateItemMapBulkInsertEntity> PRMPreBOQTemplateItemMapBulkInsertEntityList = new List<PRMPreBOQTemplateItemMapBulkInsertEntity>();

            while (reader.Read())
            {
                PRMPreBOQTemplateItemMapBulkInsertEntityList.Add(((IEntityBuilder<PRMPreBOQTemplateItemMapBulkInsertEntity>)this).BuildEntity(reader));
            }

            return (PRMPreBOQTemplateItemMapBulkInsertEntityList.Count > 0) ? PRMPreBOQTemplateItemMapBulkInsertEntityList : null;
        }

        PRMPreBOQTemplateItemMapBulkInsertEntity IEntityBuilder<PRMPreBOQTemplateItemMapBulkInsertEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESULT = 0;

            PRMPreBOQTemplateItemMapBulkInsertEntity pRMPreBOQTemplateItemMapBulkInsertEntity = new PRMPreBOQTemplateItemMapBulkInsertEntity();

            if (reader.IsDBNull(FLD_RESULT)) { pRMPreBOQTemplateItemMapBulkInsertEntity.Result = null; } else { pRMPreBOQTemplateItemMapBulkInsertEntity.Result = reader.GetInt64(FLD_RESULT); }

            return pRMPreBOQTemplateItemMapBulkInsertEntity;
        }
    }
}
