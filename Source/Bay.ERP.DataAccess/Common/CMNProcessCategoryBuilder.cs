// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNProcessCategoryBuilder : IEntityBuilder<CMNProcessCategoryEntity>
    {
        IList<CMNProcessCategoryEntity> IEntityBuilder<CMNProcessCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNProcessCategoryEntity> CMNProcessCategoryEntityList = new List<CMNProcessCategoryEntity>();

            while (reader.Read())
            {
                CMNProcessCategoryEntityList.Add(((IEntityBuilder<CMNProcessCategoryEntity>)this).BuildEntity(reader));
            }

            return (CMNProcessCategoryEntityList.Count > 0) ? CMNProcessCategoryEntityList : null;
        }

        CMNProcessCategoryEntity IEntityBuilder<CMNProcessCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PROCESSCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            CMNProcessCategoryEntity cMNProcessCategoryEntity = new CMNProcessCategoryEntity();

            cMNProcessCategoryEntity.ProcessCategoryID = reader.GetInt64(FLD_PROCESSCATEGORYID);
            cMNProcessCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { cMNProcessCategoryEntity.Remarks = String.Empty; } else { cMNProcessCategoryEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMNProcessCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMNProcessCategoryEntity;
        }
    }
}
