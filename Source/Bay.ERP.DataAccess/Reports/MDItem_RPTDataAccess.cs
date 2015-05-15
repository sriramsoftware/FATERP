// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 29-Jan-2012, 12:40:04




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
    internal sealed partial class MDItem_RPTDataAccess : BaseDataAccess, IMDItem_RPTDataAccess
    {
        #region Constructors

        public MDItem_RPTDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDItem_RPTEntity> CreateEntityBuilder<MDItem_RPTEntity>()
        {
            return (new MDItem_RPTBuilder()) as IEntityBuilder<MDItem_RPTEntity>;
        }

        #endregion


        #region GetAll

        IList<MDItem_RPTEntity> IMDItem_RPTDataAccess.GetIL(Int64 parentCategoryID, Int64 subCategoryID)
        {
            try
            {
                const string SP = "dbo.MDItem_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ParentCategoryID", DbType.Int64, parentCategoryID);	
				    Database.AddInParameter(cmd, "@SubCategoryID", DbType.Int64, subCategoryID);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDItem_RPTEntity> list = CreateEntityBuilder<MDItem_RPTEntity>().BuildEntities(reader);

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

        DataTable IMDItem_RPTDataAccess.GetDT(Int64 parentCategoryID, Int64 subCategoryID)
        {
            try
            {
                const string SP = "dbo.MDItem_RPT";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@ParentCategoryID", DbType.Int64, parentCategoryID);	
				    Database.AddInParameter(cmd, "@SubCategoryID", DbType.Int64, subCategoryID);	

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
