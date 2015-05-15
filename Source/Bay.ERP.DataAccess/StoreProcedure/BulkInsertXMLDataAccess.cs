// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Jan-2012, 02:37:15




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
    internal sealed partial class BulkInsertXMLDataAccess : BaseDataAccess, IBulkInsertXMLDataAccess
    {
        #region Constructors

        public BulkInsertXMLDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BulkInsertXMLEntity> CreateEntityBuilder<BulkInsertXMLEntity>()
        {
            return (new BulkInsertXMLBuilder()) as IEntityBuilder<BulkInsertXMLEntity>;
        }

        #endregion


        #region GetAll

        IList<BulkInsertXMLEntity> IBulkInsertXMLDataAccess.GetIL(String xVar, Int32 tableInfo)
        {
            try
            {
                const string SP = "dbo.BulkInsertXML";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@xVar", DbType.Xml, xVar);	
				    Database.AddInParameter(cmd, "@TableInfo", DbType.Int32, tableInfo);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BulkInsertXMLEntity> list = CreateEntityBuilder<BulkInsertXMLEntity>().BuildEntities(reader);

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

        DataTable IBulkInsertXMLDataAccess.GetDT(String xVar, Int32 tableInfo)
        {
            try
            {
                const string SP = "dbo.BulkInsertXML";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@xVar", DbType.Xml, xVar);	
				    Database.AddInParameter(cmd, "@TableInfo", DbType.Int32, tableInfo);	

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
