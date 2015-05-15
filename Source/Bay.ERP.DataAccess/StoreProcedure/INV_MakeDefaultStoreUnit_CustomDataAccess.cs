// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Dec-2012, 03:50:26




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
    internal sealed partial class INV_MakeDefaultStoreUnit_CustomDataAccess : BaseDataAccess, IINV_MakeDefaultStoreUnit_CustomDataAccess
    {
        #region Constructors

        public INV_MakeDefaultStoreUnit_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INV_MakeDefaultStoreUnit_CustomEntity> CreateEntityBuilder<INV_MakeDefaultStoreUnit_CustomEntity>()
        {
            return (new INV_MakeDefaultStoreUnit_CustomBuilder()) as IEntityBuilder<INV_MakeDefaultStoreUnit_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<INV_MakeDefaultStoreUnit_CustomEntity> IINV_MakeDefaultStoreUnit_CustomDataAccess.GetIL(Int64 storeUnitID, Int64 storeID)
        {
            try
            {
                const string SP = "dbo.INV_MakeDefaultStoreUnit_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@StoreUnitID", DbType.Int64, storeUnitID);	
				    Database.AddInParameter(cmd, "@StoreID", DbType.Int64, storeID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INV_MakeDefaultStoreUnit_CustomEntity> list = CreateEntityBuilder<INV_MakeDefaultStoreUnit_CustomEntity>().BuildEntities(reader);

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

        DataTable IINV_MakeDefaultStoreUnit_CustomDataAccess.GetDT(Int64 storeUnitID, Int64 storeID)
        {
            try
            {
                const string SP = "dbo.INV_MakeDefaultStoreUnit_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@StoreUnitID", DbType.Int64, storeUnitID);	
				    Database.AddInParameter(cmd, "@StoreID", DbType.Int64, storeID);	

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
