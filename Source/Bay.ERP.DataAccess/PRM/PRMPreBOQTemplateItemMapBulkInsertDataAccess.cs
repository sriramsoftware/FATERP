// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 02-Jan-2012, 03:42:46




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
    internal sealed partial class PRMPreBOQTemplateItemMapBulkInsertDataAccess : BaseDataAccess, IPRMPreBOQTemplateItemMapBulkInsertDataAccess
    {
        #region Constructors

        public PRMPreBOQTemplateItemMapBulkInsertDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMPreBOQTemplateItemMapBulkInsertEntity> CreateEntityBuilder<PRMPreBOQTemplateItemMapBulkInsertEntity>()
        {
            return (new PRMPreBOQTemplateItemMapBulkInsertBuilder()) as IEntityBuilder<PRMPreBOQTemplateItemMapBulkInsertEntity>;
        }

        #endregion


        #region GetAll

        IList<PRMPreBOQTemplateItemMapBulkInsertEntity> IPRMPreBOQTemplateItemMapBulkInsertDataAccess.GetIL(String xVar)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQTemplateItemMapBulkInsert";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@xVar", DbType.Xml, xVar);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMPreBOQTemplateItemMapBulkInsertEntity> list = CreateEntityBuilder<PRMPreBOQTemplateItemMapBulkInsertEntity>().BuildEntities(reader);

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

        DataTable IPRMPreBOQTemplateItemMapBulkInsertDataAccess.GetDT(String xVar)
        {
            try
            {
                const string SP = "dbo.PRMPreBOQTemplateItemMapBulkInsert";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@xVar", DbType.Xml, xVar);	

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
