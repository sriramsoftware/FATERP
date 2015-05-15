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
    internal sealed class CMConsultantContactPersonBuilder : IEntityBuilder<CMConsultantContactPersonEntity>
    {
        IList<CMConsultantContactPersonEntity> IEntityBuilder<CMConsultantContactPersonEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultantContactPersonEntity> CMConsultantContactPersonEntityList = new List<CMConsultantContactPersonEntity>();

            while (reader.Read())
            {
                CMConsultantContactPersonEntityList.Add(((IEntityBuilder<CMConsultantContactPersonEntity>)this).BuildEntity(reader));
            }

            return (CMConsultantContactPersonEntityList.Count > 0) ? CMConsultantContactPersonEntityList : null;
        }

        CMConsultantContactPersonEntity IEntityBuilder<CMConsultantContactPersonEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSULTANTCONTACTPERSONID = 0;
            const Int32 FLD_CONSULTANTID = 1;
            const Int32 FLD_NAME = 2;
            const Int32 FLD_DESIGNATION = 3;
            const Int32 FLD_ADDRESSLINE1 = 4;
            const Int32 FLD_ADDRESSLINE2 = 5;
            const Int32 FLD_PHONE = 6;
            const Int32 FLD_CONTACTNO = 7;
            const Int32 FLD_EMAIL = 8;
            const Int32 FLD_REMARKS = 9;

            CMConsultantContactPersonEntity cMConsultantContactPersonEntity = new CMConsultantContactPersonEntity();

            cMConsultantContactPersonEntity.ConsultantContactPersonID = reader.GetInt64(FLD_CONSULTANTCONTACTPERSONID);
            cMConsultantContactPersonEntity.ConsultantID = reader.GetInt64(FLD_CONSULTANTID);
            cMConsultantContactPersonEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESIGNATION)) { cMConsultantContactPersonEntity.Designation = String.Empty; } else { cMConsultantContactPersonEntity.Designation = reader.GetString(FLD_DESIGNATION); }
            if (reader.IsDBNull(FLD_ADDRESSLINE1)) { cMConsultantContactPersonEntity.AddressLine1 = String.Empty; } else { cMConsultantContactPersonEntity.AddressLine1 = reader.GetString(FLD_ADDRESSLINE1); }
            if (reader.IsDBNull(FLD_ADDRESSLINE2)) { cMConsultantContactPersonEntity.AddressLine2 = String.Empty; } else { cMConsultantContactPersonEntity.AddressLine2 = reader.GetString(FLD_ADDRESSLINE2); }
            if (reader.IsDBNull(FLD_PHONE)) { cMConsultantContactPersonEntity.Phone = String.Empty; } else { cMConsultantContactPersonEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_CONTACTNO)) { cMConsultantContactPersonEntity.ContactNo = String.Empty; } else { cMConsultantContactPersonEntity.ContactNo = reader.GetString(FLD_CONTACTNO); }
            if (reader.IsDBNull(FLD_EMAIL)) { cMConsultantContactPersonEntity.Email = String.Empty; } else { cMConsultantContactPersonEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_REMARKS)) { cMConsultantContactPersonEntity.Remarks = String.Empty; } else { cMConsultantContactPersonEntity.Remarks = reader.GetString(FLD_REMARKS); }

            return cMConsultantContactPersonEntity;
        }
    }
}
