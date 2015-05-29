// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-May-2013, 12:02:45




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACAccountGroupBuilder : IEntityBuilder<ACAccountGroupEntity>
    {
        IList<ACAccountGroupEntity> IEntityBuilder<ACAccountGroupEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccountGroupEntity> ACAccountGroupEntityList = new List<ACAccountGroupEntity>();

            while (reader.Read())
            {
                ACAccountGroupEntityList.Add(((IEntityBuilder<ACAccountGroupEntity>)this).BuildEntity(reader));
            }

            return (ACAccountGroupEntityList.Count > 0) ? ACAccountGroupEntityList : null;
        }

        ACAccountGroupEntity IEntityBuilder<ACAccountGroupEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTGROUPID = 0;
            const Int32 FLD_PARENTACCOUNTGROUPID = 1;
            const Int32 FLD_CLASSID = 2;
            const Int32 FLD_ACCOUNTGROUPCODE = 3;
            const Int32 FLD_NAME = 4;
            const Int32 FLD_DESCRIPTION = 5;
            const Int32 FLD_ISINACTIVE = 6;
            const Int32 FLD_ISREMOVED = 7;

            ACAccountGroupEntity aCAccountGroupEntity = new ACAccountGroupEntity();

            aCAccountGroupEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            if (reader.IsDBNull(FLD_PARENTACCOUNTGROUPID)) { aCAccountGroupEntity.ParentAccountGroupID = null; } else { aCAccountGroupEntity.ParentAccountGroupID = reader.GetInt64(FLD_PARENTACCOUNTGROUPID); }
            aCAccountGroupEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCAccountGroupEntity.AccountGroupCode = reader.GetString(FLD_ACCOUNTGROUPCODE);
            aCAccountGroupEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCAccountGroupEntity.Description = String.Empty; } else { aCAccountGroupEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCAccountGroupEntity.IsInActive = reader.GetBoolean(FLD_ISINACTIVE);
            aCAccountGroupEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCAccountGroupEntity;
        }
    }
}
