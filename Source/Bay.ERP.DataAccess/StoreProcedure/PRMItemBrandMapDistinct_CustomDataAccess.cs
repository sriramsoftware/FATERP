// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-May-2012, 03:36:37




using System;
using System.Data;
using System.Data.SqlClient;
using System.Data.Common;
using System.Collections;
using System.Collections.Generic;
using Microsoft.Practices.EnterpriseLibrary.Data;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;
using Bay.ERP.DataAccess;

namespace Bay.ERP.DataAccess
{
    internal sealed partial class PRMItemBrandMapDistinct_CustomDataAccess : BaseDataAccess, IPRMItemBrandMapDistinct_CustomDataAccess
    {
        #region Constructors

        public PRMItemBrandMapDistinct_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMItemBrandMapDistinct_CustomEntity> CreateEntityBuilder<PRMItemBrandMapDistinct_CustomEntity>()
        {
            return (new PRMItemBrandMapDistinct_CustomBuilder()) as IEntityBuilder<PRMItemBrandMapDistinct_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMItemBrandMapDistinct_CustomEntity> IPRMItemBrandMapDistinct_CustomDataAccess.GetIL(Int64 supplierID)
        {
            try
            {
                const string SP = "dbo.PRMItemBrandMapDistinct_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, supplierID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMItemBrandMapDistinct_CustomEntity> list = CreateEntityBuilder<PRMItemBrandMapDistinct_CustomEntity>().BuildEntities(reader);

                        if (list != null && list.Count > 0)
                        {
                            if ((reader.NextResult()) && (reader.Read()))
                            {
                                list[0].TotalRowCount = reader.GetInt32(0);
                            }
                        }

                        return list;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        DataTable IPRMItemBrandMapDistinct_CustomDataAccess.GetDT(Int64 supplierID)
        {
            try
            {
                const string SP = "dbo.PRMItemBrandMapDistinct_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, supplierID);	

                    DataSet ds = new DataSet();
                    ds = Database.ExecuteDataSet(cmd);

                    if (ds.Tables.Count > 0)
                    {
                        return (ds.Tables[0]);
                    }
                    else
                    {
                        return null;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        #endregion
    }
}
