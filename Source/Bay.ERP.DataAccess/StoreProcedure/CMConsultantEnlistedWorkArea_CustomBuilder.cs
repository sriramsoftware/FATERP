// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-May-2012, 12:37:41




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConsultantEnlistedWorkArea_CustomBuilder : IEntityBuilder<CMConsultantEnlistedWorkArea_CustomEntity>
    {
        IList<CMConsultantEnlistedWorkArea_CustomEntity> IEntityBuilder<CMConsultantEnlistedWorkArea_CustomEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultantEnlistedWorkArea_CustomEntity> CMConsultantEnlistedWorkArea_CustomEntityList = new List<CMConsultantEnlistedWorkArea_CustomEntity>();

            while (reader.Read())
            {
                CMConsultantEnlistedWorkArea_CustomEntityList.Add(((IEntityBuilder<CMConsultantEnlistedWorkArea_CustomEntity>)this).BuildEntity(reader));
            }

            return (CMConsultantEnlistedWorkArea_CustomEntityList.Count > 0) ? CMConsultantEnlistedWorkArea_CustomEntityList : null;
        }

        CMConsultantEnlistedWorkArea_CustomEntity IEntityBuilder<CMConsultantEnlistedWorkArea_CustomEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSULTANTENLISTEDWORKAREAID = 0;
            const Int32 FLD_CONSULTANTID = 1;
            const Int32 FLD_CONSULTANTWORKAREAID = 2;
            const Int32 FLD_CONSULTANTNAME = 3;
            const Int32 FLD_CONSULTANTWORKAREANAME = 4;
            const Int32 FLD_ROWNUMBER = 5;

            CMConsultantEnlistedWorkArea_CustomEntity cMConsultantEnlistedWorkArea_CustomEntity = new CMConsultantEnlistedWorkArea_CustomEntity();

            cMConsultantEnlistedWorkArea_CustomEntity.ConsultantEnlistedWorkAreaID = reader.GetInt64(FLD_CONSULTANTENLISTEDWORKAREAID);
            cMConsultantEnlistedWorkArea_CustomEntity.ConsultantID = reader.GetInt64(FLD_CONSULTANTID);
            cMConsultantEnlistedWorkArea_CustomEntity.ConsultantWorkAreaID = reader.GetInt64(FLD_CONSULTANTWORKAREAID);
            if (reader.IsDBNull(FLD_CONSULTANTNAME)) { cMConsultantEnlistedWorkArea_CustomEntity.ConsultantName = String.Empty; } else { cMConsultantEnlistedWorkArea_CustomEntity.ConsultantName = reader.GetString(FLD_CONSULTANTNAME); }
            if (reader.IsDBNull(FLD_CONSULTANTWORKAREANAME)) { cMConsultantEnlistedWorkArea_CustomEntity.ConsultantWorkAreaName = String.Empty; } else { cMConsultantEnlistedWorkArea_CustomEntity.ConsultantWorkAreaName = reader.GetString(FLD_CONSULTANTWORKAREANAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMConsultantEnlistedWorkArea_CustomEntity.RowNumber = null; } else { cMConsultantEnlistedWorkArea_CustomEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMConsultantEnlistedWorkArea_CustomEntity;
        }
    }
}
