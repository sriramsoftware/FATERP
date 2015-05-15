// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Mar-2013, 05:31:27




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMNFavoriteBuilder : IEntityBuilder<CMNFavoriteEntity>
    {
        IList<CMNFavoriteEntity> IEntityBuilder<CMNFavoriteEntity>.BuildEntities(IDataReader reader)
        {
            List<CMNFavoriteEntity> CMNFavoriteEntityList = new List<CMNFavoriteEntity>();

            while (reader.Read())
            {
                CMNFavoriteEntityList.Add(((IEntityBuilder<CMNFavoriteEntity>)this).BuildEntity(reader));
            }

            return (CMNFavoriteEntityList.Count > 0) ? CMNFavoriteEntityList : null;
        }

        CMNFavoriteEntity IEntityBuilder<CMNFavoriteEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_FAVORITEID = 0;
            const Int32 FLD_PROCESSCATEGORYID = 1;
            const Int32 FLD_REFERENCEID = 2;
            const Int32 FLD_REMARKS = 3;
            const Int32 FLD_FAVORITEDATE = 4;
            const Int32 FLD_EMPLOYEEID = 5;
            const Int32 FLD_ISREMOVED = 6;

            CMNFavoriteEntity cMNFavoriteEntity = new CMNFavoriteEntity();

            cMNFavoriteEntity.FavoriteID = reader.GetInt64(FLD_FAVORITEID);
            cMNFavoriteEntity.ProcessCategoryID = reader.GetInt64(FLD_PROCESSCATEGORYID);
            cMNFavoriteEntity.ReferenceID = reader.GetInt64(FLD_REFERENCEID);
            if (reader.IsDBNull(FLD_REMARKS)) { cMNFavoriteEntity.Remarks = String.Empty; } else { cMNFavoriteEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMNFavoriteEntity.FavoriteDate = reader.GetDateTime(FLD_FAVORITEDATE);
            cMNFavoriteEntity.EmployeeID = reader.GetInt64(FLD_EMPLOYEEID);
            cMNFavoriteEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return cMNFavoriteEntity;
        }
    }
}
