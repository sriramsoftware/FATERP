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
    internal sealed class ASPhysicalSiteMapControlBuilder : IEntityBuilder<ASPhysicalSiteMapControlEntity>
    {
        IList<ASPhysicalSiteMapControlEntity> IEntityBuilder<ASPhysicalSiteMapControlEntity>.BuildEntities(IDataReader reader)
        {
            List<ASPhysicalSiteMapControlEntity> ASPhysicalSiteMapControlEntityList = new List<ASPhysicalSiteMapControlEntity>();

            while (reader.Read())
            {
                ASPhysicalSiteMapControlEntityList.Add(((IEntityBuilder<ASPhysicalSiteMapControlEntity>)this).BuildEntity(reader));
            }

            return (ASPhysicalSiteMapControlEntityList.Count > 0) ? ASPhysicalSiteMapControlEntityList : null;
        }

        ASPhysicalSiteMapControlEntity IEntityBuilder<ASPhysicalSiteMapControlEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_ASPHYSICALSITEMAPCONTROLID = 0;
            const Int32 FLD_ASPHYSICALSITEMAPID = 1;
            const Int32 FLD_CONTROLID = 2;
            const Int32 FLD_CONTROLNAME = 3;
            const Int32 FLD_UNIQUEKEY = 4;
            const Int32 FLD_MDASCONTROLTYPEID = 5;
            const Int32 FLD_PARENTASPHYSICALSITEMAPCONTROLID = 6;
            const Int32 FLD_TABPAGEREFERENCEUNIQUEKEY = 7;

            ASPhysicalSiteMapControlEntity aSPhysicalSiteMapControlEntity = new ASPhysicalSiteMapControlEntity();

            aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapControlID = reader.GetInt64(FLD_ASPHYSICALSITEMAPCONTROLID);
            aSPhysicalSiteMapControlEntity.ASPhysicalSiteMapID = reader.GetInt64(FLD_ASPHYSICALSITEMAPID);
            aSPhysicalSiteMapControlEntity.ControlId = reader.GetString(FLD_CONTROLID);
            aSPhysicalSiteMapControlEntity.ControlName = reader.GetString(FLD_CONTROLNAME);
            aSPhysicalSiteMapControlEntity.UniqueKey = reader.GetString(FLD_UNIQUEKEY);
            aSPhysicalSiteMapControlEntity.MDASControlTypeID = reader.GetInt64(FLD_MDASCONTROLTYPEID);
            if (reader.IsDBNull(FLD_PARENTASPHYSICALSITEMAPCONTROLID)) { aSPhysicalSiteMapControlEntity.ParentASPhysicalSiteMapControlID = null; } else { aSPhysicalSiteMapControlEntity.ParentASPhysicalSiteMapControlID = reader.GetInt64(FLD_PARENTASPHYSICALSITEMAPCONTROLID); }
            if (reader.IsDBNull(FLD_TABPAGEREFERENCEUNIQUEKEY)) { aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey = String.Empty; } else { aSPhysicalSiteMapControlEntity.TabPageReferenceUniqueKey = reader.GetString(FLD_TABPAGEREFERENCEUNIQUEKEY); }

            return aSPhysicalSiteMapControlEntity;
        }
    }
}
