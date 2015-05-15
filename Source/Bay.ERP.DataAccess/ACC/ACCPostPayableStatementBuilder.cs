// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 03:29:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ACCPostPayableStatementBuilder : IEntityBuilder<ACCPostPayableStatementEntity>
    {
        IList<ACCPostPayableStatementEntity> IEntityBuilder<ACCPostPayableStatementEntity>.BuildEntities(IDataReader reader)
        {
            List<ACCPostPayableStatementEntity> ACCPostPayableStatementEntityList = new List<ACCPostPayableStatementEntity>();

            while (reader.Read())
            {
                ACCPostPayableStatementEntityList.Add(((IEntityBuilder<ACCPostPayableStatementEntity>)this).BuildEntity(reader));
            }

            return (ACCPostPayableStatementEntityList.Count > 0) ? ACCPostPayableStatementEntityList : null;
        }

        ACCPostPayableStatementEntity IEntityBuilder<ACCPostPayableStatementEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_POSTPAYABLESTATEMENTID = 0;
            const Int32 FLD_PREPAYABLESTATEMENTID = 1;
            const Int32 FLD_REF = 2;
            const Int32 FLD_CREATEDATE = 3;
            const Int32 FLD_ENDDATE = 4;
            const Int32 FLD_STARTDATE = 5;
            const Int32 FLD_ISREMOVED = 6;

            ACCPostPayableStatementEntity aCCPostPayableStatementEntity = new ACCPostPayableStatementEntity();

            aCCPostPayableStatementEntity.PostPayableStatementID = reader.GetInt64(FLD_POSTPAYABLESTATEMENTID);
            if (reader.IsDBNull(FLD_PREPAYABLESTATEMENTID)) { aCCPostPayableStatementEntity.PrePayableStatementID = null; } else { aCCPostPayableStatementEntity.PrePayableStatementID = reader.GetInt64(FLD_PREPAYABLESTATEMENTID); }
            aCCPostPayableStatementEntity.Ref = reader.GetString(FLD_REF);
            aCCPostPayableStatementEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            aCCPostPayableStatementEntity.EndDate = reader.GetDateTime(FLD_ENDDATE);
            aCCPostPayableStatementEntity.StartDate = reader.GetDateTime(FLD_STARTDATE);
            aCCPostPayableStatementEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return aCCPostPayableStatementEntity;
        }
    }
}
