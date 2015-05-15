// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 04:47:08




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConsultantWorkAreaBuilder : IEntityBuilder<CMConsultantWorkAreaEntity>
    {
        IList<CMConsultantWorkAreaEntity> IEntityBuilder<CMConsultantWorkAreaEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultantWorkAreaEntity> CMConsultantWorkAreaEntityList = new List<CMConsultantWorkAreaEntity>();

            while (reader.Read())
            {
                CMConsultantWorkAreaEntityList.Add(((IEntityBuilder<CMConsultantWorkAreaEntity>)this).BuildEntity(reader));
            }

            return (CMConsultantWorkAreaEntityList.Count > 0) ? CMConsultantWorkAreaEntityList : null;
        }

        CMConsultantWorkAreaEntity IEntityBuilder<CMConsultantWorkAreaEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSULTANTWORKAREAID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_ISREMOVED = 2;

            CMConsultantWorkAreaEntity cMConsultantWorkAreaEntity = new CMConsultantWorkAreaEntity();

            cMConsultantWorkAreaEntity.ConsultantWorkAreaID = reader.GetInt64(FLD_CONSULTANTWORKAREAID);
            cMConsultantWorkAreaEntity.Name = reader.GetString(FLD_NAME);
            cMConsultantWorkAreaEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMConsultantWorkAreaEntity;
        }
    }
}
