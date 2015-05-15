// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Apr-2013, 01:26:57




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class CRMAgreementSpecsBuilder : IEntityBuilder<CRMAgreementSpecsEntity>
    {
        IList<CRMAgreementSpecsEntity> IEntityBuilder<CRMAgreementSpecsEntity>.BuildEntities(IDataReader reader)
        {
            List<CRMAgreementSpecsEntity> CRMAgreementSpecsEntityList = new List<CRMAgreementSpecsEntity>();

            while (reader.Read())
            {
                CRMAgreementSpecsEntityList.Add(((IEntityBuilder<CRMAgreementSpecsEntity>)this).BuildEntity(reader));
            }

            return (CRMAgreementSpecsEntityList.Count > 0) ? CRMAgreementSpecsEntityList : null;
        }

        CRMAgreementSpecsEntity IEntityBuilder<CRMAgreementSpecsEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_AGREEMENTSPECSID = 0;
            const Int32 FLD_AGREEMENTID = 1;
            const Int32 FLD_ITEM = 2;
            const Int32 FLD_BRANDID = 3;
            const Int32 FLD_BAYQTY = 4;
            const Int32 FLD_BAYPRICE = 5;
            const Int32 FLD_CUSTOMERQTY = 6;
            const Int32 FLD_CUSTOMERPRICE = 7;
            const Int32 FLD_FIELD1 = 8;
            const Int32 FLD_FIELD2 = 9;
            const Int32 FLD_VAR0 = 10;
            const Int32 FLD_VAR1 = 11;
            const Int32 FLD_VAR2 = 12;
            const Int32 FLD_VAR3 = 13;
            const Int32 FLD_VAR4 = 14;
            const Int32 FLD_VAR5 = 15;
            const Int32 FLD_REMARKS = 16;
            const Int32 FLD_AGREEMENTSPECSTYPE = 17;

            CRMAgreementSpecsEntity cRMAgreementSpecsEntity = new CRMAgreementSpecsEntity();

            cRMAgreementSpecsEntity.AgreementSpecsID = reader.GetInt64(FLD_AGREEMENTSPECSID);
            cRMAgreementSpecsEntity.AgreementID = reader.GetInt64(FLD_AGREEMENTID);
            cRMAgreementSpecsEntity.Item = reader.GetString(FLD_ITEM);
            cRMAgreementSpecsEntity.BrandID = reader.GetInt64(FLD_BRANDID);
            if (reader.IsDBNull(FLD_BAYQTY)) { cRMAgreementSpecsEntity.BayQty = null; } else { cRMAgreementSpecsEntity.BayQty = reader.GetDecimal(FLD_BAYQTY); }
            if (reader.IsDBNull(FLD_BAYPRICE)) { cRMAgreementSpecsEntity.BayPrice = null; } else { cRMAgreementSpecsEntity.BayPrice = reader.GetDecimal(FLD_BAYPRICE); }
            if (reader.IsDBNull(FLD_CUSTOMERQTY)) { cRMAgreementSpecsEntity.CustomerQty = null; } else { cRMAgreementSpecsEntity.CustomerQty = reader.GetDecimal(FLD_CUSTOMERQTY); }
            if (reader.IsDBNull(FLD_CUSTOMERPRICE)) { cRMAgreementSpecsEntity.CustomerPrice = null; } else { cRMAgreementSpecsEntity.CustomerPrice = reader.GetDecimal(FLD_CUSTOMERPRICE); }
            if (reader.IsDBNull(FLD_FIELD1)) { cRMAgreementSpecsEntity.Field1 = String.Empty; } else { cRMAgreementSpecsEntity.Field1 = reader.GetString(FLD_FIELD1); }
            if (reader.IsDBNull(FLD_FIELD2)) { cRMAgreementSpecsEntity.Field2 = String.Empty; } else { cRMAgreementSpecsEntity.Field2 = reader.GetString(FLD_FIELD2); }
            if (reader.IsDBNull(FLD_VAR0)) { cRMAgreementSpecsEntity.var0 = String.Empty; } else { cRMAgreementSpecsEntity.var0 = reader.GetString(FLD_VAR0); }
            if (reader.IsDBNull(FLD_VAR1)) { cRMAgreementSpecsEntity.var1 = String.Empty; } else { cRMAgreementSpecsEntity.var1 = reader.GetString(FLD_VAR1); }
            if (reader.IsDBNull(FLD_VAR2)) { cRMAgreementSpecsEntity.var2 = String.Empty; } else { cRMAgreementSpecsEntity.var2 = reader.GetString(FLD_VAR2); }
            if (reader.IsDBNull(FLD_VAR3)) { cRMAgreementSpecsEntity.var3 = String.Empty; } else { cRMAgreementSpecsEntity.var3 = reader.GetString(FLD_VAR3); }
            if (reader.IsDBNull(FLD_VAR4)) { cRMAgreementSpecsEntity.var4 = String.Empty; } else { cRMAgreementSpecsEntity.var4 = reader.GetString(FLD_VAR4); }
            if (reader.IsDBNull(FLD_VAR5)) { cRMAgreementSpecsEntity.var5 = String.Empty; } else { cRMAgreementSpecsEntity.var5 = reader.GetString(FLD_VAR5); }
            if (reader.IsDBNull(FLD_REMARKS)) { cRMAgreementSpecsEntity.Remarks = String.Empty; } else { cRMAgreementSpecsEntity.Remarks = reader.GetString(FLD_REMARKS); }
            cRMAgreementSpecsEntity.AgreementSpecsType = reader.GetString(FLD_AGREEMENTSPECSTYPE);

            return cRMAgreementSpecsEntity;
        }
    }
}
