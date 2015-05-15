// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-May-2013, 11:39:55




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConsultant_DetailedBuilder : IEntityBuilder<CMConsultant_DetailedEntity>
    {
        IList<CMConsultant_DetailedEntity> IEntityBuilder<CMConsultant_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConsultant_DetailedEntity> ACAccount_DetailedEntityList = new List<CMConsultant_DetailedEntity>();

            while (reader.Read())
            {
                ACAccount_DetailedEntityList.Add(((IEntityBuilder<CMConsultant_DetailedEntity>)this).BuildEntity(reader));
            }

            return (ACAccount_DetailedEntityList.Count > 0) ? ACAccount_DetailedEntityList : null;
        }

        CMConsultant_DetailedEntity IEntityBuilder<CMConsultant_DetailedEntity>.BuildEntity(IDataReader reader)
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
            const Int32 FLD_MEMBERNAME = 14;
            const Int32 FLD_OUTSOURCECATEGORYNAME = 15;
            const Int32 FLD_FIRSTNAME= 16;
            const Int32 FLD_MIDDLENAME = 17;
            const Int32 FLD_LASTNAME = 18;
            const Int32 FLD_ROWNUMBER = 19;

            CMConsultant_DetailedEntity cMConsultant_DetailedEntity = new CMConsultant_DetailedEntity();

            cMConsultant_DetailedEntity.ConsultantID = reader.GetInt64(FLD_CONSULTANTID);
            if (reader.IsDBNull(FLD_MEMBERID)) { cMConsultant_DetailedEntity.MemberID = null; } else { cMConsultant_DetailedEntity.MemberID = reader.GetInt64(FLD_MEMBERID); }
            cMConsultant_DetailedEntity.OutsourceCategoryID = reader.GetInt64(FLD_OUTSOURCECATEGORYID);
            cMConsultant_DetailedEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_IMAGEURL)) { cMConsultant_DetailedEntity.ImageUrl = String.Empty; } else { cMConsultant_DetailedEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            if (reader.IsDBNull(FLD_CURRENTPOSITION)) { cMConsultant_DetailedEntity.CurrentPosition = String.Empty; } else { cMConsultant_DetailedEntity.CurrentPosition = reader.GetString(FLD_CURRENTPOSITION); }
            if (reader.IsDBNull(FLD_INSTITUENAME)) { cMConsultant_DetailedEntity.InstitueName = String.Empty; } else { cMConsultant_DetailedEntity.InstitueName = reader.GetString(FLD_INSTITUENAME); }
            if (reader.IsDBNull(FLD_EMAILADDRESS1)) { cMConsultant_DetailedEntity.EmailAddress1 = String.Empty; } else { cMConsultant_DetailedEntity.EmailAddress1 = reader.GetString(FLD_EMAILADDRESS1); }
            if (reader.IsDBNull(FLD_EMAILADDRESS2)) { cMConsultant_DetailedEntity.EmailAddress2 = String.Empty; } else { cMConsultant_DetailedEntity.EmailAddress2 = reader.GetString(FLD_EMAILADDRESS2); }
            if (reader.IsDBNull(FLD_CONTACTNO1)) { cMConsultant_DetailedEntity.ContactNo1 = String.Empty; } else { cMConsultant_DetailedEntity.ContactNo1 = reader.GetString(FLD_CONTACTNO1); }
            if (reader.IsDBNull(FLD_CONTACTNO2)) { cMConsultant_DetailedEntity.ContactNo2 = String.Empty; } else { cMConsultant_DetailedEntity.ContactNo2 = reader.GetString(FLD_CONTACTNO2); }
            if (reader.IsDBNull(FLD_PHONE)) { cMConsultant_DetailedEntity.Phone = String.Empty; } else { cMConsultant_DetailedEntity.Phone = reader.GetString(FLD_PHONE); }
            if (reader.IsDBNull(FLD_REMARKS)) { cMConsultant_DetailedEntity.Remarks = String.Empty; } else { cMConsultant_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMConsultant_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_MEMBERNAME)) { cMConsultant_DetailedEntity.MemberName = String.Empty; } else { cMConsultant_DetailedEntity.MemberName = reader.GetString(FLD_MEMBERNAME); }
            if (reader.IsDBNull(FLD_OUTSOURCECATEGORYNAME)) { cMConsultant_DetailedEntity.OutsourceCategoryName = String.Empty; } else { cMConsultant_DetailedEntity.OutsourceCategoryName = reader.GetString(FLD_OUTSOURCECATEGORYNAME); }
            cMConsultant_DetailedEntity.FirstName = reader.GetString(FLD_FIRSTNAME);
            cMConsultant_DetailedEntity.MiddleName = reader.GetString(FLD_MIDDLENAME);
            cMConsultant_DetailedEntity.LastName = reader.GetString(FLD_LASTNAME);
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMConsultant_DetailedEntity.RowNumber = null; } else { cMConsultant_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMConsultant_DetailedEntity;
        }
    }
}
