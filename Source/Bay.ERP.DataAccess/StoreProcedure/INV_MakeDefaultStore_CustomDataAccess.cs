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
    internal sealed partial class INV_MakeDefaultStore_CustomDataAccess : BaseDataAccess, IINV_MakeDefaultStore_CustomDataAccess
    {
        #region Constructors

        public INV_MakeDefaultStore_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<INV_MakeDefaultStore_CustomEntity> CreateEntityBuilder<INV_MakeDefaultStore_CustomEntity>()
        {
            return (new INV_MakeDefaultStore_CustomBuilder()) as IEntityBuilder<INV_MakeDefaultStore_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<INV_MakeDefaultStore_CustomEntity> IINV_MakeDefaultStore_CustomDataAccess.GetIL(Int64 projectID, Int64 storeID)
        {
            try
            {
                const string SP = "dbo.INV_MakeDefaultStore_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	
				    Database.AddInParameter(cmd, "@StoreID", DbType.Int64, storeID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<INV_MakeDefaultStore_CustomEntity> list = CreateEntityBuilder<INV_MakeDefaultStore_CustomEntity>().BuildEntities(reader);

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

        DataTable IINV_MakeDefaultStore_CustomDataAccess.GetDT(Int64 projectID, Int64 storeID)
        {
            try
            {
                const string SP = "dbo.INV_MakeDefaultStore_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	
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
