// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class HRMemberBuilder : IEntityBuilder<HRMemberEntity>
    {
        IList<HRMemberEntity> IEntityBuilder<HRMemberEntity>.BuildEntities(IDataReader reader)
        {
            List<HRMemberEntity> HRMemberEntityList = new List<HRMemberEntity>();

            while (reader.Read())
            {
                HRMemberEntityList.Add(((IEntityBuilder<HRMemberEntity>)this).BuildEntity(reader));
            }

            return (HRMemberEntityList.Count > 0) ? HRMemberEntityList : null;
        }

        HRMemberEntity IEntityBuilder<HRMemberEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEMBERID = 0;
            const Int32 FLD_FIRSTNAME = 1;
            const Int32 FLD_MIDDLENAME = 2;
            const Int32 FLD_LASTNAME = 3;
            const Int32 FLD_MEMBERTYPEID = 4;

            HRMemberEntity hRMemberEntity = new HRMemberEntity();

            hRMemberEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            hRMemberEntity.FirstName = reader.GetString(FLD_FIRSTNAME);
            if (reader.IsDBNull(FLD_MIDDLENAME)) { hRMemberEntity.MiddleName = String.Empty; } else { hRMemberEntity.MiddleName = reader.GetString(FLD_MIDDLENAME); }
            hRMemberEntity.LastName = reader.GetString(FLD_LASTNAME);
            hRMemberEntity.MemberTypeID = reader.GetInt64(FLD_MEMBERTYPEID);

            return hRMemberEntity;
        }
    }
}
