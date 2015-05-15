// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2012, 04:20:17




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDDesignationBuilder : IEntityBuilder<MDDesignationEntity>
    {
        IList<MDDesignationEntity> IEntityBuilder<MDDesignationEntity>.BuildEntities(IDataReader reader)
        {
            List<MDDesignationEntity> MDDesignationEntityList = new List<MDDesignationEntity>();

            while (reader.Read())
            {
                MDDesignationEntityList.Add(((IEntityBuilder<MDDesignationEntity>)this).BuildEntity(reader));
            }

            return (MDDesignationEntityList.Count > 0) ? MDDesignationEntityList : null;
        }

        MDDesignationEntity IEntityBuilder<MDDesignationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_DESIGNATIONID = 0;
            const Int32 FLD_DEPARTMENTID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESCRIPTION = 3;
            const Int32 FLD_ISREMOVED = 4;

            MDDesignationEntity mDDesignationEntity = new MDDesignationEntity();

            mDDesignationEntity.DesignationID = reader.GetInt64(FLD_DESIGNATIONID);
            mDDesignationEntity.DepartmentID = reader.GetInt64(FLD_DEPARTMENTID);
            mDDesignationEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDDesignationEntity.Description = String.Empty; } else { mDDesignationEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDDesignationEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDDesignationEntity;
        }
    }
}
