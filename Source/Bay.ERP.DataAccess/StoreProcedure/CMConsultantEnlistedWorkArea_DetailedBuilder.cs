// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 01:42:10




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConsultantEnlistedWorkArea_DetailedBuilder : IEntityBuilder<CMConsultantEnlistedWorkArea_DetailedEntity>
    {
        IList<CMConsultantEnlistedWorkArea_DetailedEntity> IEntityBuilder<CMConsultantEnlistedWorkArea_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultantEnlistedWorkArea_DetailedEntity> CMConsultantEnlistedWorkArea_DetailedEntityList = new List<CMConsultantEnlistedWorkArea_DetailedEntity>();

            while (reader.Read())
            {
                CMConsultantEnlistedWorkArea_DetailedEntityList.Add(((IEntityBuilder<CMConsultantEnlistedWorkArea_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMConsultantEnlistedWorkArea_DetailedEntityList.Count > 0) ? CMConsultantEnlistedWorkArea_DetailedEntityList : null;
        }

        CMConsultantEnlistedWorkArea_DetailedEntity IEntityBuilder<CMConsultantEnlistedWorkArea_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSULTANTENLISTEDWORKAREAID = 0;
            const Int32 FLD_CONSULTANTID = 1;
            const Int32 FLD_CONSULTANTWORKAREAID = 2;
            const Int32 FLD_CONSULTANTNAME = 3;
            const Int32 FLD_CONSULTANTWORKAREANAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            CMConsultantEnlistedWorkArea_DetailedEntity cMConsultantEnlistedWorkArea_DetailedEntity = new CMConsultantEnlistedWorkArea_DetailedEntity();

            cMConsultantEnlistedWorkArea_DetailedEntity.ConsultantEnlistedWorkAreaID = reader.GetInt64(FLD_CONSULTANTENLISTEDWORKAREAID);
            cMConsultantEnlistedWorkArea_DetailedEntity.ConsultantID = reader.GetInt64(FLD_CONSULTANTID);
            cMConsultantEnlistedWorkArea_DetailedEntity.ConsultantWorkAreaID = reader.GetInt64(FLD_CONSULTANTWORKAREAID);
            if (reader.IsDBNull(FLD_CONSULTANTNAME)) { cMConsultantEnlistedWorkArea_DetailedEntity.ConsultantName = String.Empty; } else { cMConsultantEnlistedWorkArea_DetailedEntity.ConsultantName = reader.GetString(FLD_CONSULTANTNAME); }
            if (reader.IsDBNull(FLD_CONSULTANTWORKAREANAME)) { cMConsultantEnlistedWorkArea_DetailedEntity.ConsultantWorkAreaName = String.Empty; } else { cMConsultantEnlistedWorkArea_DetailedEntity.ConsultantWorkAreaName = reader.GetString(FLD_CONSULTANTWORKAREANAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMConsultantEnlistedWorkArea_DetailedEntity.RowNumber = null; } else { cMConsultantEnlistedWorkArea_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMConsultantEnlistedWorkArea_DetailedEntity;
        }
    }
}
