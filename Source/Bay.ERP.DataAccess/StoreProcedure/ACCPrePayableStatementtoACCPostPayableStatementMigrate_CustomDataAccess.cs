// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 13-Dec-2012, 01:14:46




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
    internal sealed partial class ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess : BaseDataAccess, IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess
    {
        #region Constructors

        public ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity> CreateEntityBuilder<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity>()
        {
            return (new ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomBuilder()) as IEntityBuilder<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity> IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess.GetIL(Int64 prePayableStatementID, Int64 preparedByMemberID)
        {
            try
            {
                const string SP = "dbo.ACCPrePayableStatementtoACCPostPayableStatementMigrate_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PrePayableStatementID", DbType.Int64, prePayableStatementID);	
				    Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, preparedByMemberID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity> list = CreateEntityBuilder<ACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomEntity>().BuildEntities(reader);

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

        DataTable IACCPrePayableStatementtoACCPostPayableStatementMigrate_CustomDataAccess.GetDT(Int64 prePayableStatementID, Int64 preparedByMemberID)
        {
            try
            {
                const string SP = "dbo.ACCPrePayableStatementtoACCPostPayableStatementMigrate_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PrePayableStatementID", DbType.Int64, prePayableStatementID);	
				    Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, preparedByMemberID);	

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
