// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Feb-2012, 11:55:12




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CMConstructionToolDetail_DetailedBuilder : IEntityBuilder<CMConstructionToolDetail_DetailedEntity>
    {
        IList<CMConstructionToolDetail_DetailedEntity> IEntityBuilder<CMConstructionToolDetail_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<CMConstructionToolDetail_DetailedEntity> CMConstructionToolDetail_DetailedEntityList = new List<CMConstructionToolDetail_DetailedEntity>();

            while (reader.Read())
            {
                CMConstructionToolDetail_DetailedEntityList.Add(((IEntityBuilder<CMConstructionToolDetail_DetailedEntity>)this).BuildEntity(reader));
            }

            return (CMConstructionToolDetail_DetailedEntityList.Count > 0) ? CMConstructionToolDetail_DetailedEntityList : null;
        }

        CMConstructionToolDetail_DetailedEntity IEntityBuilder<CMConstructionToolDetail_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CONSTRUCTIONTOOLDETAILID = 0;
            const Int32 FLD_CONSTRUCTIONTOOLID = 1;
            const Int32 FLD_SPECIFICATION = 2;
            const Int32 FLD_CONSTRUCTIONTOOLWORKINGCONDITIONID = 3;
            const Int32 FLD_BRANDID = 4;
            const Int32 FLD_SUPPLIERID = 5;
            const Int32 FLD_NEXTMAINTANANCEDATE = 6;
            const Int32 FLD_USEDORHANDELEDBY = 7;
            const Int32 FLD_PROJECTID = 8;
            const Int32 FLD_REMARKS = 9;
            const Int32 FLD_ISREMOVED = 10;
            const Int32 FLD_CONSTRUCTIONTOOLTOOLNAME = 11;
            const Int32 FLD_CONSTRUCTIONTOOLWORKINGCONDITIONNAME = 12;
            const Int32 FLD_MDBRANDBRANDNAME = 13;
            const Int32 FLD_SUPPLIERNAME = 14;
            const Int32 FLD_PROJECTNAME = 15;
            const Int32 FLD_ROWNUMBER = 16;

            CMConstructionToolDetail_DetailedEntity cMConstructionToolDetail_DetailedEntity = new CMConstructionToolDetail_DetailedEntity();

            cMConstructionToolDetail_DetailedEntity.ConstructionToolDetailID = reader.GetInt64(FLD_CONSTRUCTIONTOOLDETAILID);
            cMConstructionToolDetail_DetailedEntity.ConstructionToolID = reader.GetInt64(FLD_CONSTRUCTIONTOOLID);
            cMConstructionToolDetail_DetailedEntity.Specification = reader.GetString(FLD_SPECIFICATION);
            cMConstructionToolDetail_DetailedEntity.ConstructionToolWorkingConditionID = reader.GetInt64(FLD_CONSTRUCTIONTOOLWORKINGCONDITIONID);
            if (reader.IsDBNull(FLD_BRANDID)) { cMConstructionToolDetail_DetailedEntity.BrandID = null; } else { cMConstructionToolDetail_DetailedEntity.BrandID = reader.GetInt64(FLD_BRANDID); }
            if (reader.IsDBNull(FLD_SUPPLIERID)) { cMConstructionToolDetail_DetailedEntity.SupplierID = null; } else { cMConstructionToolDetail_DetailedEntity.SupplierID = reader.GetInt64(FLD_SUPPLIERID); }
            if (reader.IsDBNull(FLD_NEXTMAINTANANCEDATE)) { cMConstructionToolDetail_DetailedEntity.NextMaintananceDate = null; } else { cMConstructionToolDetail_DetailedEntity.NextMaintananceDate = reader.GetDateTime(FLD_NEXTMAINTANANCEDATE); }
            if (reader.IsDBNull(FLD_USEDORHANDELEDBY)) { cMConstructionToolDetail_DetailedEntity.UsedOrHandeledBy = String.Empty; } else { cMConstructionToolDetail_DetailedEntity.UsedOrHandeledBy = reader.GetString(FLD_USEDORHANDELEDBY); }
            if (reader.IsDBNull(FLD_PROJECTID)) { cMConstructionToolDetail_DetailedEntity.ProjectID = null; } else { cMConstructionToolDetail_DetailedEntity.ProjectID = reader.GetInt64(FLD_PROJECTID); }
            if (reader.IsDBNull(FLD_REMARKS)) { cMConstructionToolDetail_DetailedEntity.Remarks = String.Empty; } else { cMConstructionToolDetail_DetailedEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cMConstructionToolDetail_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_CONSTRUCTIONTOOLTOOLNAME)) { cMConstructionToolDetail_DetailedEntity.ConstructionToolToolName = String.Empty; } else { cMConstructionToolDetail_DetailedEntity.ConstructionToolToolName = reader.GetString(FLD_CONSTRUCTIONTOOLTOOLNAME); }
            if (reader.IsDBNull(FLD_CONSTRUCTIONTOOLWORKINGCONDITIONNAME)) { cMConstructionToolDetail_DetailedEntity.ConstructionToolWorkingConditionName = String.Empty; } else { cMConstructionToolDetail_DetailedEntity.ConstructionToolWorkingConditionName = reader.GetString(FLD_CONSTRUCTIONTOOLWORKINGCONDITIONNAME); }
            if (reader.IsDBNull(FLD_MDBRANDBRANDNAME)) { cMConstructionToolDetail_DetailedEntity.MDBrandBrandName = String.Empty; } else { cMConstructionToolDetail_DetailedEntity.MDBrandBrandName = reader.GetString(FLD_MDBRANDBRANDNAME); }
            if (reader.IsDBNull(FLD_SUPPLIERNAME)) { cMConstructionToolDetail_DetailedEntity.SupplierName = String.Empty; } else { cMConstructionToolDetail_DetailedEntity.SupplierName = reader.GetString(FLD_SUPPLIERNAME); }
            if (reader.IsDBNull(FLD_PROJECTNAME)) { cMConstructionToolDetail_DetailedEntity.ProjectName = String.Empty; } else { cMConstructionToolDetail_DetailedEntity.ProjectName = reader.GetString(FLD_PROJECTNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { cMConstructionToolDetail_DetailedEntity.RowNumber = null; } else { cMConstructionToolDetail_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return cMConstructionToolDetail_DetailedEntity;
        }
    }
}
