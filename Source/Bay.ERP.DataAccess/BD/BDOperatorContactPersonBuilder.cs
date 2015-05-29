// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-May-2015, 12:50:36




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDOperatorContactPersonBuilder : IEntityBuilder<BDOperatorContactPersonEntity>
    {
        IList<BDOperatorContactPersonEntity> IEntityBuilder<BDOperatorContactPersonEntity>.BuildEntities(IDataReader reader)
        {
            List<BDOperatorContactPersonEntity> BDOperatorContactPersonEntityList = new List<BDOperatorContactPersonEntity>();

            while (reader.Read())
            {
                BDOperatorContactPersonEntityList.Add(((IEntityBuilder<BDOperatorContactPersonEntity>)this).BuildEntity(reader));
            }

            return (BDOperatorContactPersonEntityList.Count > 0) ? BDOperatorContactPersonEntityList : null;
        }

        BDOperatorContactPersonEntity IEntityBuilder<BDOperatorContactPersonEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_OPERATORCONTACTPERSONID = 0;
            const Int32 FLD_OPERATORID = 1;
            const Int32 FLD_ZONEID = 2;
            const Int32 FLD_NAME = 3;
            const Int32 FLD_ZONEDESIGNATIONID = 4;
            const Int32 FLD_ID = 5;
            const Int32 FLD_PHONE = 6;
            const Int32 FLD_MOBILENO = 7;
            const Int32 FLD_FAX = 8;
            const Int32 FLD_EMAIL = 9;
            const Int32 FLD_WEBLINK = 10;

            BDOperatorContactPersonEntity bDOperatorContactPersonEntity = new BDOperatorContactPersonEntity();

            bDOperatorContactPersonEntity.OperatorContactPersonID = reader.GetInt64(FLD_OPERATORCONTACTPERSONID);
            bDOperatorContactPersonEntity.OperatorID = reader.GetInt64(FLD_OPERATORID);
            bDOperatorContactPersonEntity.ZoneID = reader.GetInt64(FLD_ZONEID);
            bDOperatorContactPersonEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_ZONEDESIGNATIONID)) { bDOperatorContactPersonEntity.ZoneDesignationID = null; } else { bDOperatorContactPersonEntity.ZoneDesignationID = reader.GetInt64(FLD_ZONEDESIGNATIONID); }
            if (reader.IsDBNull(FLD_ID)) { bDOperatorContactPersonEntity.ID = String.Empty; } else { bDOperatorContactPersonEntity.ID = reader.GetString(FLD_ID); }
            if (reader.IsDBNull(FLD_PHONE)) { bDOperatorContactPersonEntity.Phone = String.Empty; } else { bDOperatorContactPersonEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { bDOperatorContactPersonEntity.MobileNo = String.Empty; } else { bDOperatorContactPersonEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_FAX)) { bDOperatorContactPersonEntity.Fax = String.Empty; } else { bDOperatorContactPersonEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_EMAIL)) { bDOperatorContactPersonEntity.Email = String.Empty; } else { bDOperatorContactPersonEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { bDOperatorContactPersonEntity.WebLink = String.Empty; } else { bDOperatorContactPersonEntity.WebLink = reader.GetString(FLD_WEBLINK); }

            return bDOperatorContactPersonEntity;
        }
    }
}
