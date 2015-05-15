// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Dec-2012, 01:47:00




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
    internal sealed partial class ACCPrePayableStatementDetail_CustomDataAccess : BaseDataAccess, IACCPrePayableStatementDetail_CustomDataAccess
    {
        #region Constructors

        public ACCPrePayableStatementDetail_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACCPrePayableStatementDetail_CustomEntity> CreateEntityBuilder<ACCPrePayableStatementDetail_CustomEntity>()
        {
            return (new ACCPrePayableStatementDetail_CustomBuilder()) as IEntityBuilder<ACCPrePayableStatementDetail_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<ACCPrePayableStatementDetail_CustomEntity> IACCPrePayableStatementDetail_CustomDataAccess.GetIL(DateTime startDate, DateTime endDate)
        {
            try
            {
                const string SP = "dbo.ACCPrePayableStatementDetail_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, startDate);	
				    Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, endDate);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACCPrePayableStatementDetail_CustomEntity> list = CreateEntityBuilder<ACCPrePayableStatementDetail_CustomEntity>().BuildEntities(reader);

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

        DataTable IACCPrePayableStatementDetail_CustomDataAccess.GetDT(DateTime startDate, DateTime endDate)
        {
            try
            {
                const string SP = "dbo.ACCPrePayableStatementDetail_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, startDate);	
				    Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, endDate);	

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
