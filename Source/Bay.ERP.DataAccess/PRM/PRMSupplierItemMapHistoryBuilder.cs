// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 16-Apr-2012, 04:09:50




using System;
using System.Data;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;

namespace Bay.ERP.DataAccess
{
    internal sealed class PRMSupplierItemMapHistoryBuilder : IEntityBuilder<PRMSupplierItemMapHistoryEntity>
    {
        IList<PRMSupplierItemMapHistoryEntity> IEntityBuilder<PRMSupplierItemMapHistoryEntity>.BuildEntities(IDataReader reader)
        {
            List<PRMSupplierItemMapHistoryEntity> PRMSupplierItemMapHistoryEntityList = new List<PRMSupplierItemMapHistoryEntity>();

            while (reader.Read())
            {
                PRMSupplierItemMapHistoryEntityList.Add(((IEntityBuilder<PRMSupplierItemMapHistoryEntity>)this).BuildEntity(reader));
            }

            return (PRMSupplierItemMapHistoryEntityList.Count > 0) ? PRMSupplierItemMapHistoryEntityList : null;
        }

        PRMSupplierItemMapHistoryEntity IEntityBuilder<PRMSupplierItemMapHistoryEntity>.BuildEntity(IDataReader reader)
        {
            const Int32 FLD_SUPPLIERITEMMAPHISTORYID = 0;
            const Int32 FLD_SUPPLIERITEMMAPID = 1;
            const Int32 FLD_ACTUALPRICE = 2;
            const Int32 FLD_DISCOUNTPERCENTAGE = 3;
            const Int32 FLD_PRICE = 4;
            const Int32 FLD_ENTRYDATE = 5;

            PRMSupplierItemMapHistoryEntity pRMSupplierItemMapHistoryEntity = new PRMSupplierItemMapHistoryEntity();

            pRMSupplierItemMapHistoryEntity.SupplierItemMapHistoryID = reader.GetInt64(FLD_SUPPLIERITEMMAPHISTORYID);
            pRMSupplierItemMapHistoryEntity.SupplierItemMapID = reader.GetInt64(FLD_SUPPLIERITEMMAPID);
            pRMSupplierItemMapHistoryEntity.ActualPrice = reader.GetDecimal(FLD_ACTUALPRICE);
            pRMSupplierItemMapHistoryEntity.DiscountPercentage = reader.GetDecimal(FLD_DISCOUNTPERCENTAGE);
            pRMSupplierItemMapHistoryEntity.Price = reader.GetDecimal(FLD_PRICE);
            pRMSupplierItemMapHistoryEntity.EntryDate = reader.GetDateTime(FLD_ENTRYDATE);

            return pRMSupplierItemMapHistoryEntity;
        }
    }
}
