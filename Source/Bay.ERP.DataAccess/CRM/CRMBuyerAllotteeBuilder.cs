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
    internal sealed class CRMBuyerAllotteeBuilder : IEntityBuilder<CRMBuyerAllotteeEntity>
    {
        IList<CRMBuyerAllotteeEntity> IEntityBuilder<CRMBuyerAllotteeEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMBuyerAllotteeEntity> CRMBuyerAllotteeEntityList = new List<CRMBuyerAllotteeEntity>();

            while (reader.Read())
            {
                CRMBuyerAllotteeEntityList.Add(((IEntityBuilder<CRMBuyerAllotteeEntity>)this).BuildEntity(reader));
            }

            return (CRMBuyerAllotteeEntityList.Count > 0) ? CRMBuyerAllotteeEntityList : null;
        }

        CRMBuyerAllotteeEntity IEntityBuilder<CRMBuyerAllotteeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BUYERALLOTTEEID = 0;
            const Int32 FLD_BUYERBASICINFOID = 1;
            const Int32 FLD_OWNERFULLNAME = 2;
            const Int32 FLD_IMAGEURL = 3;
            const Int32 FLD_OWNPERCENTAGE = 4;
            const Int32 FLD_MOBILENO = 5;
            const Int32 FLD_LANDPHONE = 6;
            const Int32 FLD_PRESENTADDRESS = 7;
            const Int32 FLD_FATHERNAME = 8;
            const Int32 FLD_MOTHERNAME = 9;
            const Int32 FLD_SPOUSENAME = 10;
            const Int32 FLD_TINNUMBER = 11;
            const Int32 FLD_DATEOFBIRTH = 12;
            const Int32 FLD_EMAIL = 13;
            const Int32 FLD_BUSINESSDETAILS = 14;

            CRMBuyerAllotteeEntity cRMBuyerAllotteeEntity = new CRMBuyerAllotteeEntity();

            cRMBuyerAllotteeEntity.BuyerAllotteeID = reader.GetInt64(FLD_BUYERALLOTTEEID);
            cRMBuyerAllotteeEntity.BuyerBasicInfoID = reader.GetInt64(FLD_BUYERBASICINFOID);
            cRMBuyerAllotteeEntity.OwnerFullName = reader.GetString(FLD_OWNERFULLNAME);
            if (reader.IsDBNull(FLD_IMAGEURL)) { cRMBuyerAllotteeEntity.ImageUrl = String.Empty; } else { cRMBuyerAllotteeEntity.ImageUrl = reader.GetString(FLD_IMAGEURL); }
            if (reader.IsDBNull(FLD_OWNPERCENTAGE)) { cRMBuyerAllotteeEntity.OwnPercentage = null; } else { cRMBuyerAllotteeEntity.OwnPercentage = reader.GetDecimal(FLD_OWNPERCENTAGE); }
            if (reader.IsDBNull(FLD_MOBILENO)) { cRMBuyerAllotteeEntity.MobileNo = String.Empty; } else { cRMBuyerAllotteeEntity.MobileNo = reader.GetString(FLD_MOBILENO); }
            if (reader.IsDBNull(FLD_LANDPHONE)) { cRMBuyerAllotteeEntity.LandPhone = String.Empty; } else { cRMBuyerAllotteeEntity.LandPhone = reader.GetString(FLD_LANDPHONE); }
            if (reader.IsDBNull(FLD_PRESENTADDRESS)) { cRMBuyerAllotteeEntity.PresentAddress = String.Empty; } else { cRMBuyerAllotteeEntity.PresentAddress = reader.GetString(FLD_PRESENTADDRESS); }
            if (reader.IsDBNull(FLD_FATHERNAME)) { cRMBuyerAllotteeEntity.FatherName = String.Empty; } else { cRMBuyerAllotteeEntity.FatherName = reader.GetString(FLD_FATHERNAME); }
            if (reader.IsDBNull(FLD_MOTHERNAME)) { cRMBuyerAllotteeEntity.MotherName = String.Empty; } else { cRMBuyerAllotteeEntity.MotherName = reader.GetString(FLD_MOTHERNAME); }
            if (reader.IsDBNull(FLD_SPOUSENAME)) { cRMBuyerAllotteeEntity.SpouseName = String.Empty; } else { cRMBuyerAllotteeEntity.SpouseName = reader.GetString(FLD_SPOUSENAME); }
            if (reader.IsDBNull(FLD_TINNUMBER)) { cRMBuyerAllotteeEntity.TINNumber = String.Empty; } else { cRMBuyerAllotteeEntity.TINNumber = reader.GetString(FLD_TINNUMBER); }
            if (reader.IsDBNull(FLD_DATEOFBIRTH)) { cRMBuyerAllotteeEntity.DateOfBirth = null; } else { cRMBuyerAllotteeEntity.DateOfBirth = reader.GetDateTime(FLD_DATEOFBIRTH); }
            if (reader.IsDBNull(FLD_EMAIL)) { cRMBuyerAllotteeEntity.Email = String.Empty; } else { cRMBuyerAllotteeEntity.Email = reader.GetString(FLD_EMAIL); }
            if (reader.IsDBNull(FLD_BUSINESSDETAILS)) { cRMBuyerAllotteeEntity.BusinessDetails = String.Empty; } else { cRMBuyerAllotteeEntity.BusinessDetails = reader.GetString(FLD_BUSINESSDETAILS); }

            return cRMBuyerAllotteeEntity;
        }
    }
}
