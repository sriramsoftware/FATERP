// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class MDBankAccountCategoryBuilder : IEntityBuilder<MDBankAccountCategoryEntity>
    {
        IList<MDBankAccountCategoryEntity> IEntityBuilder<MDBankAccountCategoryEntity>.BuildEntities(IDataReader reader)
        {
            List<MDBankAccountCategoryEntity> MDBankAccountCategoryEntityList = new List<MDBankAccountCategoryEntity>();

            while (reader.Read())
            {
                MDBankAccountCategoryEntityList.Add(((IEntityBuilder<MDBankAccountCategoryEntity>)this).BuildEntity(reader));
            }

            return (MDBankAccountCategoryEntityList.Count > 0) ? MDBankAccountCategoryEntityList : null;
        }

        MDBankAccountCategoryEntity IEntityBuilder<MDBankAccountCategoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_BANKACCOUNTCATEGORYID = 0;
            const Int32 FLD_NAME = 1;
            const Int32 FLD_REMARKS = 2;
            const Int32 FLD_ISREMOVED = 3;

            MDBankAccountCategoryEntity mDBankAccountCategoryEntity = new MDBankAccountCategoryEntity();

            mDBankAccountCategoryEntity.BankAccountCategoryID = reader.GetInt64(FLD_BANKACCOUNTCATEGORYID);
            mDBankAccountCategoryEntity.Name = reader.GetString(FLD_NAME);
            if (reader.IsDBNull(FLD_REMARKS)) { mDBankAccountCategoryEntity.Remarks = String.Empty; } else { mDBankAccountCategoryEntity.Remarks = reader.GetString(FLD_REMARKS); }
            mDBankAccountCategoryEntity.IsRemoved = reader.GetBoolean(FLD_ISREMOVED);

            return mDBankAccountCategoryEntity;
        }
    }
}
