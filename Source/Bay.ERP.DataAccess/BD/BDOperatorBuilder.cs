// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 11:33:13




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class BDOperatorBuilder : IEntityBuilder<BDOperatorEntity>
    {
        IList<BDOperatorEntity> IEntityBuilder<BDOperatorEntity>.BuildEntities(IDataReader reader)
        {
            List<BDOperatorEntity> BDOperatorEntityList = new List<BDOperatorEntity>();

            while (reader.Read())
            {
                BDOperatorEntityList.Add(((IEntityBuilder<BDOperatorEntity>)this).BuildEntity(reader));
            }

            return (BDOperatorEntityList.Count > 0) ? BDOperatorEntityList : null;
        }

        BDOperatorEntity IEntityBuilder<BDOperatorEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_OPERATORID = 0;
            const Int32 FLD_OPERATORCODE = 1;
            const Int32 FLD_OPERATORNAME = 2;
            const Int32 FLD_RELATIONSHIP = 3;
            const Int32 FLD_PHONE = 4;
            const Int32 FLD_MOBILENO = 5;
            const Int32 FLD_FAX = 6;
            const Int32 FLD_EMAIL = 7;
            const Int32 FLD_WEBLINK = 8;
            const Int32 FLD_CREATEDATE = 9;
            const Int32 FLD_REMARKS = 10;
            const Int32 FLD_REASON = 11;
            const Int32 FLD_OPERATORSTATUSID = 12;
            const Int32 FLD_ISREMOVED = 13;

            BDOperatorEntity bDOperatorEntity = new BDOperatorEntity();

            bDOperatorEntity.OperatorID = reader.GetInt64(FLD_OPERATORID);
            if (reader.IsDBNull(FLD_OPERATORCODE)) { bDOperatorEntity.OperatorCode = String.Empty; } else { bDOperatorEntity.OperatorCode = reader.GetString(FLD_OPERATORCODE); }
            bDOperatorEntity.OperatorName = reader.GetString(FLD_OPERATORNAME);
            if (reader.IsDBNull(FLD_RELATIONSHIP)) { bDOperatorEntity.Relationship = String.Empty; } else { bDOperatorEntity.Relationship = reader.GetString(FLD_RELATIONSHIP); }
            if (reader.IsDBNull(FLD_PHONE)) { bDOperatorEntity.Phone = String.Empty; } else { bDOperatorEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { bDOperatorEntity.MobileNo = String.Empty; } else { bDOperatorEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_FAX)) { bDOperatorEntity.Fax = String.Empty; } else { bDOperatorEntity.Fax = reader.GetString(FLD_FAX); }
            if (reader.IsDBNull(FLD_EMAIL)) { bDOperatorEntity.Email = String.Empty; } else { bDOperatorEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_WEBLINK)) { bDOperatorEntity.WebLink = String.Empty; } else { bDOperatorEntity.WebLink = reader.GetString(FLD_WEBLINK); }
            bDOperatorEntity.CreateDate = reader.GetDateTime(FLD_CREATEDATE);
            if (reader.IsDBNull(FLD_REMARKS)) { bDOperatorEntity.Remarks = String.Empty; } else { bDOperatorEntity.Remarks = reader.GetString(FLD_REMARKS); }
            if (reader.IsDBNull(FLD_REASON)) { bDOperatorEntity.Reason = String.Empty; } else { bDOperatorEntity.Reason = reader.GetString(FLD_REASON); }
            bDOperatorEntity.OperatorStatusID = reader.GetInt64(FLD_OPERATORSTATUSID);
            bDOperatorEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return bDOperatorEntity;
        }
    }
}
