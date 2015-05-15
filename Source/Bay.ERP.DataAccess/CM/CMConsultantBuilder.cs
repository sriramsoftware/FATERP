// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 01:41:30




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConsultantBuilder : IEntityBuilder<CMConsultantEntity>
    {
        IList<CMConsultantEntity> IEntityBuilder<CMConsultantEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultantEntity> CMConsultantEntityList = new List<CMConsultantEntity>();

            while (reader.Read())
            {
                CMConsultantEntityList.Add(((IEntityBuilder<CMConsultantEntity>)this).BuildEntity(reader));
            }

            return (CMConsultantEntityList.Count > 0) ? CMConsultantEntityList : null;
        }

        CMConsultantEntity IEntityBuilder<CMConsultantEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSULTANTID = 0;
            const Int32 FLD_MEMBERID = 1;
            const Int32 FLD_OUTSOURCECATEGORYID = 2;
            const Int32 FLD_NAME = 3;
            const Int32 FLD_IMAGEURL = 4;
            const Int32 FLD_CURRENTPOSITION = 5;
            const Int32 FLD_INSTITUENAME = 6;
            const Int32 FLD_EMAILADDRESS1 = 7;
            const Int32 FLD_EMAILADDRESS2 = 8;
            const Int32 FLD_CONTACTNO1 = 9;
            const Int32 FLD_CONTACTNO2 = 10;
            const Int32 FLD_PHONE = 11;
            const Int32 FLD_REMARKS = 12;
            const Int32 FLD_ISREMOVED = 13;

            CMConsultantEntity cMConsultantEntity = new CMConsultantEntity();

            cMConsultantEntity.ConsultantID = reader.GetInt64(FLD_CONSULTANTID);
            if (reader.IsDBNull(FLD_MEMBERID)) { cMConsultantEntity.MemberID = null; } else { cMConsultantEntity.MemberID = reader.GetInt64(FLD_MEMBERID); }
            cMConsultantEntity.OutsourceCategoryID = reader.GetInt64(FLD_OUTSOURCECATEGORYID);
            cMConsultantEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_IMAGEURL)) { cMConsultantEntity.ImageUrl = String.Empty; } else { cMConsultantEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            if (reader.IsDBNull(FLD_CURRENTPOSITION)) { cMConsultantEntity.CurrentPosition = String.Empty; } else { cMConsultantEntity.CurrentPosition = reader.GetString(FLD_CURRENTPOSITION); }
            if (reader.IsDBNull(FLD_INSTITUENAME)) { cMConsultantEntity.InstitueName = String.Empty; } else { cMConsultantEntity.InstitueName = reader.GetString(FLD_INSTITUENAME); }
            if (reader.IsDBNull(FLD_EMAILADDRESS1)) { cMConsultantEntity.EmailAddress1 = String.Empty; } else { cMConsultantEntity.EmailAddress1 = reader.GetString(FLD_EMAILADDRESS1); }
            if (reader.IsDBNull(FLD_EMAILADDRESS2)) { cMConsultantEntity.EmailAddress2 = String.Empty; } else { cMConsultantEntity.EmailAddress2 = reader.GetString(FLD_EMAILADDRESS2); }
            if (reader.IsDBNull(FLD_CONTACTNO1)) { cMConsultantEntity.ContactNo1 = String.Empty; } else { cMConsultantEntity.ContactNo1 = reader.GetString(FLD_CONTACTNO1); }
            if (reader.IsDBNull(FLD_CONTACTNO2)) { cMConsultantEntity.ContactNo2 = String.Empty; } else { cMConsultantEntity.ContactNo2 = reader.GetString(FLD_CONTACTNO2); }
            if (reader.IsDBNull(FLD_PHONE)) { cMConsultantEntity.Phone = String.Empty; } else { cMConsultantEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_REMARKS)) { cMConsultantEntity.Remarks = String.Empty; } else { cMConsultantEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMConsultantEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMConsultantEntity;
        }
    }
}
