// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMLandOwnerBuilder : IEntityBuilder<CRMLandOwnerEntity>
    {
        IList<CRMLandOwnerEntity> IEntityBuilder<CRMLandOwnerEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMLandOwnerEntity> CRMLandOwnerEntityList = new List<CRMLandOwnerEntity>();

            while (reader.Read())
            {
                CRMLandOwnerEntityList.Add(((IEntityBuilder<CRMLandOwnerEntity>)this).BuildEntity(reader));
            }

            return (CRMLandOwnerEntityList.Count > 0) ? CRMLandOwnerEntityList : null;
        }

        CRMLandOwnerEntity IEntityBuilder<CRMLandOwnerEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_LANDOWNERID = 0;
            const Int32 FLD_LANDBASICINFOID = 1;
            const Int32 FLD_OWNERNAME = 2;
            const Int32 FLD_IMAGEURL = 3;
            const Int32 FLD_OWNPERCENTAGE = 4;
            const Int32 FLD_MOBILENO = 5;
            const Int32 FLD_LANDPHONE = 6;
            const Int32 FLD_PRESENTADDRESS = 7;
            const Int32 FLD_FATHERNAME = 8;
            const Int32 FLD_MOTHERNAME = 9;
            const Int32 FLD_SPOUSENAME = 10;
            const Int32 FLD_DATEOFBIRTH = 11;
            const Int32 FLD_EMAIL = 12;
            const Int32 FLD_BUSINESSDETAILS = 13;

            CRMLandOwnerEntity cRMLandOwnerEntity = new CRMLandOwnerEntity();

            cRMLandOwnerEntity.LandOwnerID = reader.GetInt64(FLD_LANDOWNERID);
            cRMLandOwnerEntity.LandBasicInfoID = reader.GetInt64(FLD_LANDBASICINFOID);
            cRMLandOwnerEntity.OwnerName = reader.GetString(FLD_OWNERNAME);
            if (reader.IsDBNull(FLD_IMAGEURL)) { cRMLandOwnerEntity.ImageUrl = String.Empty; } else { cRMLandOwnerEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            if (reader.IsDBNull(FLD_OWNPERCENTAGE)) { cRMLandOwnerEntity.OwnPercentage = null; } else { cRMLandOwnerEntity.OwnPercentage = reader.GetDecimal(FLD_OWNPERCENTAGE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { cRMLandOwnerEntity.MobileNo = String.Empty; } else { cRMLandOwnerEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_LANDPHONE)) { cRMLandOwnerEntity.LandPhone = String.Empty; } else { cRMLandOwnerEntity.LandPhone = reader.GetString(FLD_LANDPHONE); }
            if (reader.IsDBNull(FLD_PRESENTADDRESS)) { cRMLandOwnerEntity.PresentAddress = String.Empty; } else { cRMLandOwnerEntity.PresentAddress = reader.GetString(FLD_PRESENTADDRESS); }
            if (reader.IsDBNull(FLD_FATHERNAME)) { cRMLandOwnerEntity.FatherName = String.Empty; } else { cRMLandOwnerEntity.FatherName = reader.GetString(FLD_FATHERNAME); }
            if (reader.IsDBNull(FLD_MOTHERNAME)) { cRMLandOwnerEntity.MotherName = String.Empty; } else { cRMLandOwnerEntity.MotherName = reader.GetString(FLD_MOTHERNAME); }
            if (reader.IsDBNull(FLD_SPOUSENAME)) { cRMLandOwnerEntity.SpouseName = String.Empty; } else { cRMLandOwnerEntity.SpouseName = reader.GetString(FLD_SPOUSENAME); }
            if (reader.IsDBNull(FLD_DATEOFBIRTH)) { cRMLandOwnerEntity.DateOfBirth = null; } else { cRMLandOwnerEntity.DateOfBirth = reader.GetDateTime(FLD_DATEOFBIRTH); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMLandOwnerEntity.Email = String.Empty; } else { cRMLandOwnerEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_BUSINESSDETAILS)) { cRMLandOwnerEntity.BusinessDetails = String.Empty; } else { cRMLandOwnerEntity.BusinessDetails = reader.GetString(FLD_BUSINESSDETAILS); }

            return cRMLandOwnerEntity;
        }
    }
}
