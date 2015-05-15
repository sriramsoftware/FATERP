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
    internal sealed class ACAccountGroup_DetailedBuilder : IEntityBuilder<ACAccountGroup_DetailedEntity>
    {
        IList<ACAccountGroup_DetailedEntity> IEntityBuilder<ACAccountGroup_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccountGroup_DetailedEntity> ACAccountGroup_DetailedEntityList = new List<ACAccountGroup_DetailedEntity>();

            while (reader.Read())
            {
                ACAccountGroup_DetailedEntityList.Add(((IEntityBuilder<ACAccountGroup_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACAccountGroup_DetailedEntityList.Count > 0) ? ACAccountGroup_DetailedEntityList : null;
        }

        ACAccountGroup_DetailedEntity IEntityBuilder<ACAccountGroup_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTGROUPID = 0;
            const Int32 FLD_PARENTACCOUNTGROUPID = 1;
            const Int32 FLD_CLASSID = 2;
            const Int32 FLD_NAME = 3;
            const Int32 FLD_DESCRIPTION = 4;
            const Int32 FLD_ISINACTIVE = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_ACCOUNTGROUPNAME = 7;
            const Int32 FLD_CLASSNAME = 8;
            const Int32 FLD_ROWNUMBER = 9;

            ACAccountGroup_DetailedEntity aCAccountGroup_DetailedEntity = new ACAccountGroup_DetailedEntity();

            aCAccountGroup_DetailedEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            if (reader.IsDBNull(FLD_PARENTACCOUNTGROUPID)) { aCAccountGroup_DetailedEntity.ParentAccountGroupID = null; } else { aCAccountGroup_DetailedEntity.ParentAccountGroupID = reader.GetInt64(FLD_PARENTACCOUNTGROUPID); }
            aCAccountGroup_DetailedEntity.ClassID = reader.GetInt64(FLD_CLASSID);
            aCAccountGroup_DetailedEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCAccountGroup_DetailedEntity.Description = String.Empty; } else { aCAccountGroup_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCAccountGroup_DetailedEntity.IsInActive = reader.GetBoolean(FLD_ISINACTIVE);
            aCAccountGroup_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            aCAccountGroup_DetailedEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME);
            if (reader.IsDBNull(FLD_CLASSNAME)) { aCAccountGroup_DetailedEntity.ClassName = String.Empty; } else { aCAccountGroup_DetailedEntity.ClassName = reader.GetString(FLD_CLASSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCAccountGroup_DetailedEntity.RowNumber = null; } else { aCAccountGroup_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCAccountGroup_DetailedEntity;
        }
    }
}
