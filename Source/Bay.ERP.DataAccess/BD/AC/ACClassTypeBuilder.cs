// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jan-2013, 03:28:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACClassTypeBuilder : IEntityBuilder<ACClassTypeEntity>
    {
        IList<ACClassTypeEntity> IEntityBuilder<ACClassTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<ACClassTypeEntity> ACClassTypeEntityList = new List<ACClassTypeEntity>();

            while (reader.Read())
            {
                ACClassTypeEntityList.Add(((IEntityBuilder<ACClassTypeEntity>)this).BuildEntity(reader));
            }

            return (ACClassTypeEntityList.Count > 0) ? ACClassTypeEntityList : null;
        }

        ACClassTypeEntity IEntityBuilder<ACClassTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CLASSTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISREMOVED = 3;

            ACClassTypeEntity aCClassTypeEntity = new ACClassTypeEntity();

            aCClassTypeEntity.ClassTypeID = reader.GetInt64(FLD_CLASSTYPEID);
            aCClassTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCClassTypeEntity.Description = String.Empty; } else { aCClassTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCClassTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCClassTypeEntity;
        }
    }
}
