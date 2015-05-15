// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Jan-2012, 01:23:18




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConsultantEnlistedWorkAreaBuilder : IEntityBuilder<CMConsultantEnlistedWorkAreaEntity>
    {
        IList<CMConsultantEnlistedWorkAreaEntity> IEntityBuilder<CMConsultantEnlistedWorkAreaEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultantEnlistedWorkAreaEntity> CMConsultantEnlistedWorkAreaEntityList = new List<CMConsultantEnlistedWorkAreaEntity>();

            while (reader.Read())
            {
                CMConsultantEnlistedWorkAreaEntityList.Add(((IEntityBuilder<CMConsultantEnlistedWorkAreaEntity>)this).BuildEntity(reader));
            }

            return (CMConsultantEnlistedWorkAreaEntityList.Count > 0) ? CMConsultantEnlistedWorkAreaEntityList : null;
        }

        CMConsultantEnlistedWorkAreaEntity IEntityBuilder<CMConsultantEnlistedWorkAreaEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSULTANTENLISTEDWORKAREAID = 0;
            const Int32 FLD_CONSULTANTID = 1;
            const Int32 FLD_CONSULTANTWORKAREAID = 2;

            CMConsultantEnlistedWorkAreaEntity cMConsultantEnlistedWorkAreaEntity = new CMConsultantEnlistedWorkAreaEntity();

            cMConsultantEnlistedWorkAreaEntity.ConsultantEnlistedWorkAreaID = reader.GetInt64(FLD_CONSULTANTENLISTEDWORKAREAID);
            cMConsultantEnlistedWorkAreaEntity.ConsultantID = reader.GetInt64(FLD_CONSULTANTID);
            cMConsultantEnlistedWorkAreaEntity.ConsultantWorkAreaID = reader.GetInt64(FLD_CONSULTANTWORKAREAID);

            return cMConsultantEnlistedWorkAreaEntity;
        }
    }
}
