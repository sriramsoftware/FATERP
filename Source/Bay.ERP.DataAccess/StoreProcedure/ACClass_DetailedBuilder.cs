// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 05:23:47




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACClass_DetailedBuilder : IEntityBuilder<ACClass_DetailedEntity>
    {
        IList<ACClass_DetailedEntity> IEntityBuilder<ACClass_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACClass_DetailedEntity> ACClass_DetailedEntityList = new List<ACClass_DetailedEntity>();

            while (reader.Read())
            {
                ACClass_DetailedEntityList.Add(((IEntityBuilder<ACClass_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACClass_DetailedEntityList.Count > 0) ? ACClass_DetailedEntityList : null;
        }

        ACClass_DetailedEntity IEntityBuilder<ACClass_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CLASSID = 0;
            const Int32 FLD_CLASSTYPEID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISINACTIVE = 4;
            const Int32 FLD_ISREMOVED = 5;
            const Int32 FLD_CLASSTYPENAME = 6;
            const Int32 FLD_ROWNUMBER = 7;

            ACClass_DetailedEntity aCClass_DetailedEntity = new ACClass_DetailedEntity();

            aCClass_DetailedEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCClass_DetailedEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID);
            aCClass_DetailedEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCClass_DetailedEntity.Description = String.Empty; } else { aCClass_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCClass_DetailedEntity.IsInActive = reader.GetBoolean(FLD_ISINACTIVE);
            aCClass_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_CLASSTYPENAME)) { aCClass_DetailedEntity.ClassTypeName = String.Empty; } else { aCClass_DetailedEntity.ClassTypeName = reader.GetString(FLD_CLASSTYPENAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCClass_DetailedEntity.RowNumber = null; } else { aCClass_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCClass_DetailedEntity;
        }
    }
}
