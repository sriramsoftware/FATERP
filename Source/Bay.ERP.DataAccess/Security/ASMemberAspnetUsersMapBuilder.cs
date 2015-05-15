// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ASMemberAspnetUsersMapBuilder : IEntityBuilder<ASMemberAspnetUsersMapEntity>
    {
        IList<ASMemberAspnetUsersMapEntity> IEntityBuilder<ASMemberAspnetUsersMapEntity>.BuildEntities(IDataReader reader)
        {
            List<ASMemberAspnetUsersMapEntity> ASMemberAspnetUsersMapEntityList = new List<ASMemberAspnetUsersMapEntity>();

            while (reader.Read())
            {
                ASMemberAspnetUsersMapEntityList.Add(((IEntityBuilder<ASMemberAspnetUsersMapEntity>)this).BuildEntity(reader));
            }

            return (ASMemberAspnetUsersMapEntityList.Count > 0) ? ASMemberAspnetUsersMapEntityList : null;
        }

        ASMemberAspnetUsersMapEntity IEntityBuilder<ASMemberAspnetUsersMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASMEMBERASPNETUSERSMAPID = 0;
            const Int32 FLD_MEMBERID = 1;
            const Int32 FLD_USERID = 2;

            ASMemberAspnetUsersMapEntity aSMemberAspnetUsersMapEntity = new ASMemberAspnetUsersMapEntity();

            aSMemberAspnetUsersMapEntity.ASMemberAspnetUsersMapID = reader.GetInt64(FLD_ASMEMBERASPNETUSERSMAPID);
            aSMemberAspnetUsersMapEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            aSMemberAspnetUsersMapEntity.UserId = reader.GetGuid(FLD_USERID);

            return aSMemberAspnetUsersMapEntity;
        }
    }
}
