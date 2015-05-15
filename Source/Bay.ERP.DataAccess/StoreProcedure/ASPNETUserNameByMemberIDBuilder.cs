// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:49:25




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ASPNETUserNameByMemberIDBuilder : IEntityBuilder<ASPNETUserNameByMemberIDEntity>
    {
        IList<ASPNETUserNameByMemberIDEntity> IEntityBuilder<ASPNETUserNameByMemberIDEntity>.BuildEntities(IDataReader reader)
        {
            List<ASPNETUserNameByMemberIDEntity> ASPNETUserNameByMemberIDEntityList = new List<ASPNETUserNameByMemberIDEntity>();

            while (reader.Read())
            {
                ASPNETUserNameByMemberIDEntityList.Add(((IEntityBuilder<ASPNETUserNameByMemberIDEntity>)this).BuildEntity(reader));
            }

            return (ASPNETUserNameByMemberIDEntityList.Count > 0) ? ASPNETUserNameByMemberIDEntityList : null;
        }

        ASPNETUserNameByMemberIDEntity IEntityBuilder<ASPNETUserNameByMemberIDEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEMBERID = 0;
            const Int32 FLD_USERNAME = 1;

            ASPNETUserNameByMemberIDEntity aSPNETUserNameByMemberIDEntity = new ASPNETUserNameByMemberIDEntity();

            aSPNETUserNameByMemberIDEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            aSPNETUserNameByMemberIDEntity.UserName = reader.GetString(FLD_USERNAME);

            return aSPNETUserNameByMemberIDEntity;
        }
    }
}
