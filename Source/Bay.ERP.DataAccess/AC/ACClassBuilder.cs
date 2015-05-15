// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 04:27:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACClassBuilder : IEntityBuilder<ACClassEntity>
    {
        IList<ACClassEntity> IEntityBuilder<ACClassEntity>.BuildEntities(IDataReader reader)
        {
            List<ACClassEntity> ACClassEntityList = new List<ACClassEntity>();

            while (reader.Read())
            {
                ACClassEntityList.Add(((IEntityBuilder<ACClassEntity>)this).BuildEntity(reader));
            }

            return (ACClassEntityList.Count > 0) ? ACClassEntityList : null;
        }

        ACClassEntity IEntityBuilder<ACClassEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CLASSID = 0;
            const Int32 FLD_CLASSTYPEID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISINACTIVE = 4;
            const Int32 FLD_ISREMOVED = 5;

            ACClassEntity aCClassEntity = new ACClassEntity();

            aCClassEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCClassEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID);
            aCClassEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCClassEntity.Description = String.Empty; } else { aCClassEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCClassEntity.IsInActive = reader.GetBoolean(FLD_ISINACTIVE);
            aCClassEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCClassEntity;
        }
    }
}
