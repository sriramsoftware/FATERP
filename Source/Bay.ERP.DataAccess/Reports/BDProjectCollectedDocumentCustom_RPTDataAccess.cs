// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jul-2013, 10:34:17




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
    internal sealed partial class BDProjectCollectedDocumentCustom_RPTDataAccess : BaseDataAccess, IBDProjectCollectedDocumentCustom_RPTDataAccess
    {
        #region Constructors

        public BDProjectCollectedDocumentCustom_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectCollectedDocumentCustom_RPTEntity> CreateEntityBuilder<BDProjectCollectedDocumentCustom_RPTEntity>()
        {
            return (new BDProjectCollectedDocumentCustom_RPTBuilder()) as IEntityBuilder<BDProjectCollectedDocumentCustom_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<BDProjectCollectedDocumentCustom_RPTEntity> IBDProjectCollectedDocumentCustom_RPTDataAccess.GetIL(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.BDProjectCollectedDocumentCustom_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectCollectedDocumentCustom_RPTEntity> list = CreateEntityBuilder<BDProjectCollectedDocumentCustom_RPTEntity>().BuildEntities(reader);

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

        DataTable IBDProjectCollectedDocumentCustom_RPTDataAccess.GetDT(Int64 projectID)
        {
            try
            {
                const string SP = "dbo.BDProjectCollectedDocumentCustom_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, projectID);	

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
