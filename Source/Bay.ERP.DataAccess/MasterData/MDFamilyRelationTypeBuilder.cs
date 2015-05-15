// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDFamilyRelationTypeBuilder : IEntityBuilder<MDFamilyRelationTypeEntity>
    {
        IList<MDFamilyRelationTypeEntity> IEntityBuilder<MDFamilyRelationTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDFamilyRelationTypeEntity> MDFamilyRelationTypeEntityList = new List<MDFamilyRelationTypeEntity>();

            while (reader.Read())
            {
                MDFamilyRelationTypeEntityList.Add(((IEntityBuilder<MDFamilyRelationTypeEntity>)this).BuildEntity(reader));
            }

            return (MDFamilyRelationTypeEntityList.Count > 0) ? MDFamilyRelationTypeEntityList : null;
        }

        MDFamilyRelationTypeEntity IEntityBuilder<MDFamilyRelationTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FAMILYRELATIONTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTION = 2;

            MDFamilyRelationTypeEntity mDFamilyRelationTypeEntity = new MDFamilyRelationTypeEntity();

            mDFamilyRelationTypeEntity.FamilyRelationTypeID = reader.GetInt64(FLD_FAMILYRELATIONTYPEID);
            mDFamilyRelationTypeEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDFamilyRelationTypeEntity.Description = String.Empty; } else { mDFamilyRelationTypeEntity.Description = reader.GetString(FLD_DESCRIPTION); }

            return mDFamilyRelationTypeEntity;
        }
    }
}
