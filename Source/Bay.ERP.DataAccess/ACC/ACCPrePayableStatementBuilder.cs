// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 11:43:49




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPrePayableStatementBuilder : IEntityBuilder<ACCPrePayableStatementEntity>
    {
        IList<ACCPrePayableStatementEntity> IEntityBuilder<ACCPrePayableStatementEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPrePayableStatementEntity> ACCPrePayableStatementEntityList = new List<ACCPrePayableStatementEntity>();

            while (reader.Read())
            {
                ACCPrePayableStatementEntityList.Add(((IEntityBuilder<ACCPrePayableStatementEntity>)this).BuildEntity(reader));
            }

            return (ACCPrePayableStatementEntityList.Count > 0) ? ACCPrePayableStatementEntityList : null;
        }

        ACCPrePayableStatementEntity IEntityBuilder<ACCPrePayableStatementEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_PREPAYABLESTATEMENTID = 0;
            const Int32 FLD_REF = 1;
            const Int32 FLD_CREATEDATE = 2;
            const Int32 FLD_STARTDATE = 3;
            const Int32 FLD_ENDDATE = 4;
            const Int32 FLD_ISREMOVED = 5;

            ACCPrePayableStatementEntity aCCPrePayableStatementEntity = new ACCPrePayableStatementEntity();

            aCCPrePayableStatementEntity.PrePayableStatementID = reader.GetInt64(FLD_PREPAYABLESTATEMENTID);
            aCCPrePayableStatementEntity.Ref = reader.GetString(FLD_REF);
            aCCPrePayableStatementEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            aCCPrePayableStatementEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            aCCPrePayableStatementEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            aCCPrePayableStatementEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCCPrePayableStatementEntity;
        }
    }
}
