// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Jul-2013, 09:56:00




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACAccount_RPTBuilder : IEntityBuilder<ACAccount_RPTEntity>
    {
        IList<ACAccount_RPTEntity> IEntityBuilder<ACAccount_RPTEntity>.BuildEntities(IDataReader reader)
        {
            List<ACAccount_RPTEntity> ACAccount_RPTEntityList = new List<ACAccount_RPTEntity>();

            while (reader.Read())
            {
                ACAccount_RPTEntityList.Add(((IEntityBuilder<ACAccount_RPTEntity>)this).BuildEntity(reader));
            }

            return (ACAccount_RPTEntityList.Count > 0) ? ACAccount_RPTEntityList : null;
        }

        ACAccount_RPTEntity IEntityBuilder<ACAccount_RPTEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ACCOUNTID = 0;
            const Int32 FLD_ACCOUNTGROUPID = 1;
            const Int32 FLD_ACCOUNTCODE = 2;
            const Int32 FLD_ACCOUNTCODE2 = 3;
            const Int32 FLD_ACCOUNTNAME = 4;
            const Int32 FLD_DESCRIPTION = 5;
            const Int32 FLD_ACCOUNTSTATUSID = 6;
            const Int32 FLD_TAXTYPEID = 7;
            const Int32 FLD_ISREMOVED = 8;
            const Int32 FLD_PARENTACCOUNTGROUP = 9;
            const Int32 FLD_ACCOUNTGROUPNAME = 10;

            ACAccount_RPTEntity aCAccount_RPTEntity = new ACAccount_RPTEntity();

            aCAccount_RPTEntity.AccountID = reader.GetInt64(FLD_ACCOUNTID);
            aCAccount_RPTEntity.AccountGroupID = reader.GetInt64(FLD_ACCOUNTGROUPID);
            aCAccount_RPTEntity.AccountCode = reader.GetString(FLD_ACCOUNTCODE);
            if (reader.IsDBNull(FLD_ACCOUNTCODE2)) { aCAccount_RPTEntity.AccountCode2 = String.Empty; } else { aCAccount_RPTEntity.AccountCode2 = reader.GetString(FLD_ACCOUNTCODE2); }
            aCAccount_RPTEntity.AccountName = reader.GetString(FLD_ACCOUNTNAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aCAccount_RPTEntity.Description = String.Empty; } else { aCAccount_RPTEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aCAccount_RPTEntity.AccountStatusID = reader.GetInt64(FLD_ACCOUNTSTATUSID);
            aCAccount_RPTEntity.TaxTypeID = reader.GetInt64(FLD_TAXTYPEID);
            aCAccount_RPTEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_PARENTACCOUNTGROUP)) { aCAccount_RPTEntity.ParentAccountGroup = String.Empty; } else { aCAccount_RPTEntity.ParentAccountGroup = reader.GetString(FLD_PARENTACCOUNTGROUP); }
            aCAccount_RPTEntity.AccountGroupName = reader.GetString(FLD_ACCOUNTGROUPNAME);

            return aCAccount_RPTEntity;
        }
    }
}
