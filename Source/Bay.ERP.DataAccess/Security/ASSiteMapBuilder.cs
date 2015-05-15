// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 03:24:04




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class ASSiteMapBuilder : IEntityBuilder<ASSiteMapEntity>
    {
        IList<ASSiteMapEntity> IEntityBuilder<ASSiteMapEntity>.BuildEntities(IDataReader reader)
        {
            List<ASSiteMapEntity> ASSiteMapEntityList = new List<ASSiteMapEntity>();

            while (reader.Read())
            {
                ASSiteMapEntityList.Add(((IEntityBuilder<ASSiteMapEntity>)this).BuildEntity(reader));
            }

            return (ASSiteMapEntityList.Count > 0) ? ASSiteMapEntityList : null;
        }

        ASSiteMapEntity IEntityBuilder<ASSiteMapEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASSITEMAPID = 0;
            const Int32 FLD_SITEMAPNAME = 1;
            const Int32 FLD_DESCRIPTION = 2;
            const Int32 FLD_ISMASTERSITEMAP = 3;

            ASSiteMapEntity aSSiteMapEntity = new ASSiteMapEntity();

            aSSiteMapEntity.ASSiteMapID = reader.GetInt64(FLD_ASSITEMAPID);
            aSSiteMapEntity.SiteMapName = reader.GetString(FLD_SITEMAPNAME);
            if (reader.IsDBNull(FLD_DESCRIPTION)) { aSSiteMapEntity.Description = String.Empty; } else { aSSiteMapEntity.Description = reader.GetString(FLD_DESCRIPTION); }
            aSSiteMapEntity.IsMasterSiteMap = reader.GetBoolean(FLD_ISMASTERSITEMAP);

            return aSSiteMapEntity;
        }
    }
}
