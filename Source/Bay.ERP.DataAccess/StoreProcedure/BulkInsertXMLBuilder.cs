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
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BulkInsertXMLBuilder : IEntityBuilder<BulkInsertXMLEntity>
    {
        IList<BulkInsertXMLEntity> IEntityBuilder<BulkInsertXMLEntity>.BuildEntities(IDataReader reader)
        {
            List<BulkInsertXMLEntity> BulkInsertXMLEntityList = new List<BulkInsertXMLEntity>();

            while (reader.Read())
            {
                BulkInsertXMLEntityList.Add(((IEntityBuilder<BulkInsertXMLEntity>)this).BuildEntity(reader));
            }

            return (BulkInsertXMLEntityList.Count > 0) ? BulkInsertXMLEntityList : null;
        }

        BulkInsertXMLEntity IEntityBuilder<BulkInsertXMLEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_RESULT = 0;

            BulkInsertXMLEntity bulkInsertXMLEntity = new BulkInsertXMLEntity();

            if (reader.IsDBNull(FLD_RESULT)) { bulkInsertXMLEntity.Result = null; } else { bulkInsertXMLEntity.Result = reader.GetInt64(FLD_RESULT); }

            return bulkInsertXMLEntity;
        }
    }
}
