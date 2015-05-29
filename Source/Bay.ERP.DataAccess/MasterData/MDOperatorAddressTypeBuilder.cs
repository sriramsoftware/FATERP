// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-May-2015, 10:46:54




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDOperatorAddressTypeBuilder : IEntityBuilder<MDOperatorAddressTypeEntity>
    {
        IList<MDOperatorAddressTypeEntity> IEntityBuilder<MDOperatorAddressTypeEntity>.BuildEntities(IDataReader reader)
        {
            List<MDOperatorAddressTypeEntity> MDOperatorAddressTypeEntityList = new List<MDOperatorAddressTypeEntity>();

            while (reader.Read())
            {
                MDOperatorAddressTypeEntityList.Add(((IEntityBuilder<MDOperatorAddressTypeEntity>)this).BuildEntity(reader));
            }

            return (MDOperatorAddressTypeEntityList.Count > 0) ? MDOperatorAddressTypeEntityList : null;
        }

        MDOperatorAddressTypeEntity IEntityBuilder<MDOperatorAddressTypeEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_OPERATORADDRESSTYPEID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_DESCRIPTON = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDOperatorAddressTypeEntity mDOperatorAddressTypeEntity = new MDOperatorAddressTypeEntity();

            mDOperatorAddressTypeEntity.OperatorAddressTypeID = reader.GetInt64(FLD_OPERATORADDRESSTYPEID);
            mDOperatorAddressTypeEntity.Name = reader.GetString(FLD_NAME);
            mDOperatorAddressTypeEntity.Descripton = reader.GetString(FLD_DESCRIPTON);
            mDOperatorAddressTypeEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDOperatorAddressTypeEntity;
        }
    }
}
