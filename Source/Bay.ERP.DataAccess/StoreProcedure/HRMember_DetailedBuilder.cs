// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 31-Dec-2011, 05:48:38




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRMember_DetailedBuilder : IEntityBuilder<HRMember_DetailedEntity>
    {
        IList<HRMember_DetailedEntity> IEntityBuilder<HRMember_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<HRMember_DetailedEntity> HRMember_DetailedEntityList = new List<HRMember_DetailedEntity>();

            while (reader.Read())
            {
                HRMember_DetailedEntityList.Add(((IEntityBuilder<HRMember_DetailedEntity>)this).BuildEntity(reader));
            }

            return (HRMember_DetailedEntityList.Count > 0) ? HRMember_DetailedEntityList : null;
        }

        HRMember_DetailedEntity IEntityBuilder<HRMember_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEMBERID = 0;
            const Int32 FLD_FIRSTNAME = 1;
            const Int32 FLD_MIDDLENAME = 2;
            const Int32 FLD_LASTNAME = 3;
            const Int32 FLD_MEMBERTYPEID = 4;
            const Int32 FLD_MEMBERTYPENAME = 5;
            const Int32 FLD_ROWNUMBER = 6;

            HRMember_DetailedEntity hRMember_DetailedEntity = new HRMember_DetailedEntity();

            hRMember_DetailedEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            hRMember_DetailedEntity.FirstName = reader.GetString(FLD_FIRSTNAME);
            if (reader.IsDBNull(FLD_MIDDLENAME)) { hRMember_DetailedEntity.MiddleName = String.Empty; } else { hRMember_DetailedEntity.MiddleName = reader.GetString(FLD_MIDDLENAME); }
            hRMember_DetailedEntity.LastName = reader.GetString(FLD_LASTNAME);
            hRMember_DetailedEntity.MemberTypeID = reader.GetInt64(FLD_MEMBERTYPEID);
            if (reader.IsDBNull(FLD_MEMBERTYPENAME)) { hRMember_DetailedEntity.MemberTypeName = String.Empty; } else { hRMember_DetailedEntity.MemberTypeName = reader.GetString(FLD_MEMBERTYPENAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { hRMember_DetailedEntity.RowNumber = null; } else { hRMember_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return hRMember_DetailedEntity;
        }
    }
}
