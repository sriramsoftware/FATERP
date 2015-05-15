// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Oct-2013, 01:39:59




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDArtGalleriaLocationBuilder : IEntityBuilder<MDArtGalleriaLocationEntity>
    {
        IList<MDArtGalleriaLocationEntity> IEntityBuilder<MDArtGalleriaLocationEntity>.BuildEntities(IDataReader reader)
        {
            List<MDArtGalleriaLocationEntity> MDArtGalleriaLocationEntityList = new List<MDArtGalleriaLocationEntity>();

            while (reader.Read())
            {
                MDArtGalleriaLocationEntityList.Add(((IEntityBuilder<MDArtGalleriaLocationEntity>)this).BuildEntity(reader));
            }

            return (MDArtGalleriaLocationEntityList.Count > 0) ? MDArtGalleriaLocationEntityList : null;
        }

        MDArtGalleriaLocationEntity IEntityBuilder<MDArtGalleriaLocationEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ARTGALLERIALOCATIONID = 0;
            const Int32 FLD_PARENTARTGALLERIALOCATIONID = 1;
            const Int32 FLD_COUNTRYID = 2;
            const Int32 FLD_CITYID = 3;
            const Int32 FLD_NAME = 4;
            const Int32 FLD_DESCRIPTION = 5;
            const Int32 FLD_ISREMOVED = 6;

            MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity = new MDArtGalleriaLocationEntity();

            mDArtGalleriaLocationEntity.ArtGalleriaLocationID = reader.GetInt64(FLD_ARTGALLERIALOCATIONID);
            if (reader.IsDBNull(FLD_PARENTARTGALLERIALOCATIONID)) { mDArtGalleriaLocationEntity.ParentArtGalleriaLocationID = null; } else { mDArtGalleriaLocationEntity.ParentArtGalleriaLocationID = reader.GetInt64(FLD_PARENTARTGALLERIALOCATIONID); }
            mDArtGalleriaLocationEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            mDArtGalleriaLocationEntity.CityID = reader.GetInt64(FLD_CITYID);
            mDArtGalleriaLocationEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { mDArtGalleriaLocationEntity.Description = String.Empty; } else { mDArtGalleriaLocationEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            mDArtGalleriaLocationEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDArtGalleriaLocationEntity;
        }
    }
}
