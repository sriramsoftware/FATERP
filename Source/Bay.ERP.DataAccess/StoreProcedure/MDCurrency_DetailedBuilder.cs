// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 04:44:22




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDCurrency_DetailedBuilder : IEntityBuilder<MDCurrency_DetailedEntity>
    {
        IList<MDCurrency_DetailedEntity> IEntityBuilder<MDCurrency_DetailedEntity>.BuildEntities(IDataReader reader)
        {
            List<MDCurrency_DetailedEntity> MDCurrency_DetailedEntityList = new List<MDCurrency_DetailedEntity>();

            while (reader.Read())
            {
                MDCurrency_DetailedEntityList.Add(((IEntityBuilder<MDCurrency_DetailedEntity>)this).BuildEntity(reader));
            }

            return (MDCurrency_DetailedEntityList.Count > 0) ? MDCurrency_DetailedEntityList : null;
        }

        MDCurrency_DetailedEntity IEntityBuilder<MDCurrency_DetailedEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CURRENCYID = 0;
            const Int32 FLD_ABBREVIATION = 1;
            const Int32 FLD_SYMBOL = 2;
            const Int32 FLD_CURRENCYNAME = 3;
            const Int32 FLD_HUNDREDTHSNAME = 4;
            const Int32 FLD_COUNTRYID = 5;
            const Int32 FLD_ISSTANDARDCURRENCY = 6;
            const Int32 FLD_ISREMOVED = 7;
            const Int32 FLD_COUNTRYNAME = 8;
            const Int32 FLD_ROWNUMBER = 9;

            MDCurrency_DetailedEntity mDCurrency_DetailedEntity = new MDCurrency_DetailedEntity();

            mDCurrency_DetailedEntity.CurrencyID = reader.GetInt64(FLD_CURRENCYID);
            mDCurrency_DetailedEntity.Abbreviation = reader.GetString(FLD_ABBREVIATION);
            if (reader.IsDBNull(FLD_SYMBOL)) { mDCurrency_DetailedEntity.Symbol = String.Empty; } else { mDCurrency_DetailedEntity.Symbol = reader.GetString(FLD_SYMBOL); }
            if (reader.IsDBNull(FLD_CURRENCYNAME)) { mDCurrency_DetailedEntity.CurrencyName = String.Empty; } else { mDCurrency_DetailedEntity.CurrencyName = reader.GetString(FLD_CURRENCYNAME); }
            if (reader.IsDBNull(FLD_HUNDREDTHSNAME)) { mDCurrency_DetailedEntity.HundredthsName = String.Empty; } else { mDCurrency_DetailedEntity.HundredthsName = reader.GetString(FLD_HUNDREDTHSNAME); }
            mDCurrency_DetailedEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            mDCurrency_DetailedEntity.IsStandardCurrency = reader.GetBoolean(FLD_ISSTANDARDCURRENCY);
            mDCurrency_DetailedEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);
            if (reader.IsDBNull(FLD_COUNTRYNAME)) { mDCurrency_DetailedEntity.CountryName = String.Empty; } else { mDCurrency_DetailedEntity.CountryName = reader.GetString(FLD_COUNTRYNAME); }
            if (reader.IsDBNull(FLD_ROWNUMBER)) { mDCurrency_DetailedEntity.RowNumber = null; } else { mDCurrency_DetailedEntity.RowNumber = reader.GetInt64(FLD_ROWNUMBER); }

            return mDCurrency_DetailedEntity;
        }
    }
}
