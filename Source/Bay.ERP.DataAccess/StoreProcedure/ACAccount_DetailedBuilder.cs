// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACAccount_DetailedBuilder : IEntityBuilder<ACAccount_DetailedEntity>
    {
        IList<ACAccount_DetailedEntity> IEntityBuilder<ACAccount_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccount_DetailedEntity> ACAccount_DetailedEntityList = new List<ACAccount_DetailedEntity>();

            while (reader.Read())
            {
                ACAccount_DetailedEntityList.Add(((IEntityBuilder<ACAccount_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACAccount_DetailedEntityList.Count > 0) ? ACAccount_DetailedEntityList : null;
        }

        ACAccount_DetailedEntity IEntityBuilder<ACAccount_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTID = 0;
            const Int32 FLD_ACCOUNTGROUPID = 1;
            const Int32 FLD_ACCOUNTCODE = 2;
            const Int32 FLD_ACCOUNTCODE2 = 3;
            const Int32 FLD_ACCOUNTNAME = 4;
            const Int32 FLD_ACCOUNTNAMEEXCEPTSPECIALCHARACTER = 5;
            const Int32 FLD_DESCRIPTION = 6;
            const Int32 FLD_ACCOUNTSTATUSID = 7;
            const Int32 FLD_ISREMOVED = 8;
            const Int32 FLD_ACCOUNTGROUPNAME = 9;
            const Int32 FLD_ACCOUNTSTATUSNAME = 10;
            const Int32 FLD_ROWNUMBER = 11;

            ACAccount_DetailedEntity aCAccount_DetailedEntity = new ACAccount_DetailedEntity();

            aCAccount_DetailedEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCAccount_DetailedEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            aCAccount_DetailedEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE);
            if (reader.IsDBNull(FLD_ACCOUNTCODE2)) { aCAccount_DetailedEntity.AccountCode2 = String.Empty; } else { aCAccount_DetailedEntity.AccountCode2 = reader.GetString(FLD_ACCOUNTCODE2); }
            aCAccount_DetailedEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME);
            if (reader.IsDBNull(FLD_ACCOUNTNAMEEXCEPTSPECIALCHARACTER)) { aCAccount_DetailedEntity.AccountNameExceptSpecialCharacter = String.Empty; } else { aCAccount_DetailedEntity.AccountNameExceptSpecialCharacter = reader.GetString(FLD_ACCOUNTNAMEEXCEPTSPECIALCHARACTER); }
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCAccount_DetailedEntity.Description = String.Empty; } else { aCAccount_DetailedEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCAccount_DetailedEntity.AccountStatusID = reader.GetInt64(FLD_ACCOUNTSTATUSID);
            aCAccount_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_ACCOUNTGROUPNAME)) { aCAccount_DetailedEntity.AccountGroupName = String.Empty; } else { aCAccount_DetailedEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME); }
            if (reader.IsDBNull(FLD_ACCOUNTSTATUSNAME)) { aCAccount_DetailedEntity.AccountStatusName = String.Empty; } else { aCAccount_DetailedEntity.AccountStatusName = reader.GetString(FLD_ACCOUNTSTATUSNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { aCAccount_DetailedEntity.RowNumber = null; } else { aCAccount_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return aCAccount_DetailedEntity;
        }
    }
}
