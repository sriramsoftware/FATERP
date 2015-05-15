// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Dec-2012, 02:36:29




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
    internal sealed partial class ACCPrePayableStatementDetailByBill_CustomDataAccess : BaseDataAccess, IACCPrePayableStatementDetailByBill_CustomDataAccess
    {
        #region Constructors

        public ACCPrePayableStatementDetailByBill_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACCPrePayableStatementDetailByBill_CustomEntity> CreateEntityBuilder<ACCPrePayableStatementDetailByBill_CustomEntity>()
        {
            return (new ACCPrePayableStatementDetailByBill_CustomBuilder()) as IEntityBuilder<ACCPrePayableStatementDetailByBill_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<ACCPrePayableStatementDetailByBill_CustomEntity> IACCPrePayableStatementDetailByBill_CustomDataAccess.GetIL(Int64 billID)
        {
            try
            {
                const string SP = "dbo.ACCPrePayableStatementDetailByBill_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BillID", DbType.Int64, billID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACCPrePayableStatementDetailByBill_CustomEntity> list = CreateEntityBuilder<ACCPrePayableStatementDetailByBill_CustomEntity>().BuildEntities(reader);

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

        DataTable IACCPrePayableStatementDetailByBill_CustomDataAccess.GetDT(Int64 billID)
        {
            try
            {
                const string SP = "dbo.ACCPrePayableStatementDetailByBill_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@BillID", DbType.Int64, billID);	

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
