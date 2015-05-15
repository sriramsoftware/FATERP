// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 09:54:11




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMContractor_DetailedBuilder : IEntityBuilder<CMContractor_DetailedEntity>
    {
        IList<CMContractor_DetailedEntity> IEntityBuilder<CMContractor_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMContractor_DetailedEntity> CMContractor_DetailedEntityList = new List<CMContractor_DetailedEntity>();

            while (reader.Read())
            {
                CMContractor_DetailedEntityList.Add(((IEntityBuilder<CMContractor_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMContractor_DetailedEntityList.Count > 0) ? CMContractor_DetailedEntityList : null;
        }

        CMContractor_DetailedEntity IEntityBuilder<CMContractor_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONTRACTORID = 0;
            const Int32 FLD_MEMBERID = 1;
            const Int32 FLD_NAMEOFWORK = 2;
            const Int32 FLD_DATE = 3;
            const Int32 FLD_NAME = 4;
            const Int32 FLD_PREPAREDBY = 5;
            const Int32 FLD_ISREMOVED = 6;
            const Int32 FLD_MEMBERFULLNAME = 7;
            const Int32 FLD_PREPAREDBYNAME = 8;
            const Int32 FLD_ROWNUMBER = 9;

            CMContractor_DetailedEntity cMContractor_DetailedEntity = new CMContractor_DetailedEntity();

            cMContractor_DetailedEntity.ContractorID = reader.GetInt64(FLD_CONTRACTORID);
            cMContractor_DetailedEntity.MemberID = reader.GetInt64(FLD_MEMBERID);
            cMContractor_DetailedEntity.NameOfWork = reader.GetString(FLD_NAMEOFWORK);
            cMContractor_DetailedEntity.Date = reader.GetDateTime(FLD_DATE);
            cMContractor_DetailedEntity.Name = reader.GetString(FLD_NAME);
            cMContractor_DetailedEntity.PreparedBy = reader.GetInt64(FLD_PREPAREDBY);
            cMContractor_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_MEMBERFULLNAME)) { cMContractor_DetailedEntity.MemberFullName = String.Empty; } else { cMContractor_DetailedEntity.MemberFullName = reader.GetString(FLD_MEMBERFULLNAME); }
            if (reader.IsDBNull(FLD_PREPAREDBYNAME)) { cMContractor_DetailedEntity.PreparedByName = String.Empty; } else { cMContractor_DetailedEntity.PreparedByName = reader.GetString(FLD_PREPAREDBYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMContractor_DetailedEntity.RowNumber = null; } else { cMContractor_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMContractor_DetailedEntity;
        }
    }
}
