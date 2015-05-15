// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-May-2012, 04:28:13




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
    internal sealed partial class PreBOQtoBOQMigration_CustomDataAccess : BaseDataAccess, IPreBOQtoBOQMigration_CustomDataAccess
    {
        #region Constructors

        public PreBOQtoBOQMigration_CustomDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PreBOQtoBOQMigration_CustomEntity> CreateEntityBuilder<PreBOQtoBOQMigration_CustomEntity>()
        {
            return (new PreBOQtoBOQMigration_CustomBuilder()) as IEntityBuilder<PreBOQtoBOQMigration_CustomEntity>;
        }

        #endregion


        #region GetAll

        IList<PreBOQtoBOQMigration_CustomEntity> IPreBOQtoBOQMigration_CustomDataAccess.GetIL(Int64 preBOQID, Int64 preparedByMemberID)
        {
            try
            {
                const string SP = "dbo.PreBOQtoBOQMigration_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PreBOQID", DbType.Int64, preBOQID);	
				    Database.AddInParameter(cmd, "@PreparedByMemberID", DbType.Int64, preparedByMemberID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PreBOQtoBOQMigration_CustomEntity> list = CreateEntityBuilder<PreBOQtoBOQMigration_CustomEntity>().BuildEntities(reader);

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

        DataTable IPreBOQtoBOQMigration_CustomDataAccess.GetDT(Int64 preBOQID, Int64 preparedByMemberID)
        {
            try
            {
                const string SP = "dbo.PreBOQtoBOQMigration_Custom";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PreBOQID", DbType.Int64, preBOQID);	
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
