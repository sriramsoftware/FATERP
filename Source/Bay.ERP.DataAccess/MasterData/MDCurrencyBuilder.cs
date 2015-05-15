// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Jan-2013, 02:50:43




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDCurrencyBuilder : IEntityBuilder<MDCurrencyEntity>
    {
        IList<MDCurrencyEntity> IEntityBuilder<MDCurrencyEntity>.BuildEntities(IDataReader reader)
        {
            List<MDCurrencyEntity> MDCurrencyEntityList = new List<MDCurrencyEntity>();

            while (reader.Read())
            {
                MDCurrencyEntityList.Add(((IEntityBuilder<MDCurrencyEntity>)this).BuildEntity(reader));
            }

            return (MDCurrencyEntityList.Count > 0) ? MDCurrencyEntityList : null;
        }

        MDCurrencyEntity IEntityBuilder<MDCurrencyEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_CURRENCYID = 0;
            const Int32 FLD_ABBREVIATION = 1;
            const Int32 FLD_SYMBOL = 2;
            const Int32 FLD_CURRENCYNAME = 3;
            const Int32 FLD_HUNDREDTHSNAME = 4;
            const Int32 FLD_COUNTRYID = 5;
            const Int32 FLD_ISSTANDARDCURRENCY = 6;
            const Int32 FLD_ISREMOVED = 7;

            MDCurrencyEntity mDCurrencyEntity = new MDCurrencyEntity();

            mDCurrencyEntity.CurrencyID = reader.GetInt64(FLD_CURRENCYID);
            mDCurrencyEntity.Abbreviation = reader.GetString(FLD_ABBREVIATION);
            if (reader.IsDBNull(FLD_SYMBOL)) { mDCurrencyEntity.Symbol = String.Empty; } else { mDCurrencyEntity.Symbol = reader.GetString(FLD_SYMBOL); }
            if (reader.IsDBNull(FLD_CURRENCYNAME)) { mDCurrencyEntity.CurrencyName = String.Empty; } else { mDCurrencyEntity.CurrencyName = reader.GetString(FLD_CURRENCYNAME); }
            if (reader.IsDBNull(FLD_HUNDREDTHSNAME)) { mDCurrencyEntity.HundredthsName = String.Empty; } else { mDCurrencyEntity.HundredthsName = reader.GetString(FLD_HUNDREDTHSNAME); }
            mDCurrencyEntity.CountryID = reader.GetInt64(FLD_COUNTRYID);
            mDCurrencyEntity.IsStandardCurrency = reader.GetBoolean(FLD_ISSTANDARDCURRENCY);
            mDCurrencyEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDCurrencyEntity;
        }
    }
}
