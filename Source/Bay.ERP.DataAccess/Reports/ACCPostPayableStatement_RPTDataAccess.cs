// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Dec-2012, 12:10:34




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
    internal sealed partial class ACCPostPayableStatement_RPTDataAccess : BaseDataAccess, IACCPostPayableStatement_RPTDataAccess
    {
        #region Constructors

        public ACCPostPayableStatement_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACCPostPayableStatement_RPTEntity> CreateEntityBuilder<ACCPostPayableStatement_RPTEntity>()
        {
            return (new ACCPostPayableStatement_RPTBuilder()) as IEntityBuilder<ACCPostPayableStatement_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<ACCPostPayableStatement_RPTEntity> IACCPostPayableStatement_RPTDataAccess.GetIL(Int64 postPayableStatementID)
        {
            try
            {
                const string SP = "dbo.ACCPostPayableStatement_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PostPayableStatementID", DbType.Int64, postPayableStatementID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACCPostPayableStatement_RPTEntity> list = CreateEntityBuilder<ACCPostPayableStatement_RPTEntity>().BuildEntities(reader);

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

        DataTable IACCPostPayableStatement_RPTDataAccess.GetDT(Int64 postPayableStatementID)
        {
            try
            {
                const string SP = "dbo.ACCPostPayableStatement_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PostPayableStatementID", DbType.Int64, postPayableStatementID);	

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
