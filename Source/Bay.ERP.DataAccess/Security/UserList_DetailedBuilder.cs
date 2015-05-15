// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jul-2012, 11:09:39




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class UserList_DetailedBuilder : IEntityBuilder<UserList_DetailedEntity>
    {
        IList<UserList_DetailedEntity> IEntityBuilder<UserList_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<UserList_DetailedEntity> UserList_DetailedEntityList = new List<UserList_DetailedEntity>();

            while (reader.Read())
            {
                UserList_DetailedEntityList.Add(((IEntityBuilder<UserList_DetailedEntity>)this).BuildEntity(reader));
            }

            return (UserList_DetailedEntityList.Count > 0) ? UserList_DetailedEntityList : null;
        }

        UserList_DetailedEntity IEntityBuilder<UserList_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_MEMBERID = 0;
            const Int32 FLD_FIRSTNAME = 1;
            const Int32 FLD_MIDDLENAME = 2;
            const Int32 FLD_LASTNAME = 3;
            const Int32 FLD_FULLNAME = 4;
            const Int32 FLD_USERNAME = 5;
            const Int32 FLD_ROLENAME = 6;
            const Int32 FLD_LASTLOGINDATE = 7;
            const Int32 FLD_ROWNUMBER = 8;

            UserList_DetailedEntity userList_DetailedEntity = new UserList_DetailedEntity();

            if (reader.IsDBNull(FLD_MEMBERID)) { userList_DetailedEntity.MemberID = null; } else { userList_DetailedEntity.MemberID = reader.GetInt64(FLD_MEMBERID); }
            if (reader.IsDBNull(FLD_FIRSTNAME)) { userList_DetailedEntity.FirstName = String.Empty; } else { userList_DetailedEntity.FirstName = reader.GetString(FLD_FIRSTNAME); }
            if (reader.IsDBNull(FLD_MIDDLENAME)) { userList_DetailedEntity.MiddleName = String.Empty; } else { userList_DetailedEntity.MiddleName = reader.GetString(FLD_MIDDLENAME); }
            if (reader.IsDBNull(FLD_LASTNAME)) { userList_DetailedEntity.LastName = String.Empty; } else { userList_DetailedEntity.LastName = reader.GetString(FLD_LASTNAME); }
            if (reader.IsDBNull(FLD_FULLNAME)) { userList_DetailedEntity.FullName = String.Empty; } else { userList_DetailedEntity.FullName = reader.GetString(FLD_FULLNAME); }
            userList_DetailedEntity.UserName = reader.GetString(FLD_USERNAME);
            if (reader.IsDBNull(FLD_ROLENAME)) { userList_DetailedEntity.RoleName = String.Empty; } else { userList_DetailedEntity.RoleName = reader.GetString(FLD_ROLENAME); }
            userList_DetailedEntity.LastLoginDate = reader.GetDateTime(FLD_LASTLOGINDATE);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { userList_DetailedEntity.RowNumber = null; } else { userList_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return userList_DetailedEntity;
        }
    }
}
