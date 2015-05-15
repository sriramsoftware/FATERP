// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 27-Dec-2012, 12:17:40




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
    internal sealed partial class ACCPrePayableStatement_RPTDataAccess : BaseDataAccess, IACCPrePayableStatement_RPTDataAccess
    {
        #region Constructors

        public ACCPrePayableStatement_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACCPrePayableStatement_RPTEntity> CreateEntityBuilder<ACCPrePayableStatement_RPTEntity>()
        {
            return (new ACCPrePayableStatement_RPTBuilder()) as IEntityBuilder<ACCPrePayableStatement_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<ACCPrePayableStatement_RPTEntity> IACCPrePayableStatement_RPTDataAccess.GetIL(Int64 prePayableStatementID)
        {
            try
            {
                const string SP = "dbo.ACCPrePayableStatement_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PrePayableStatementID", DbType.Int64, prePayableStatementID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACCPrePayableStatement_RPTEntity> list = CreateEntityBuilder<ACCPrePayableStatement_RPTEntity>().BuildEntities(reader);

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

        DataTable IACCPrePayableStatement_RPTDataAccess.GetDT(Int64 prePayableStatementID)
        {
            try
            {
                const string SP = "dbo.ACCPrePayableStatement_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PrePayableStatementID", DbType.Int64, prePayableStatementID);	

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
