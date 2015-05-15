// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Jan-2012, 09:54:11




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
    internal sealed partial class CMContractor_DetailedDataAccess : BaseDataAccess, ICMContractor_DetailedDataAccess
    {
        #region Constructors

        public CMContractor_DetailedDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMContractor_DetailedEntity> CreateEntityBuilder<CMContractor_DetailedEntity>()
        {
            return (new CMContractor_DetailedBuilder()) as IEntityBuilder<CMContractor_DetailedEntity>;
        }

        #endregion


        #region GetAll

        IList<CMContractor_DetailedEntity> ICMContractor_DetailedDataAccess.GetIL(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression)
        {
            try
            {
                const string SP = "dbo.CMContractor_Detailed";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PageSize", DbType.Int32, pageSize);	
				    Database.AddInParameter(cmd, "@CurrentPage", DbType.Int32, currentPage);	
				    Database.AddInParameter(cmd, "@SortExpression", DbType.String, sortExpression);	
				    Database.AddInParameter(cmd, "@FilterExpression", DbType.String, filterExpression);	

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMContractor_DetailedEntity> list = CreateEntityBuilder<CMContractor_DetailedEntity>().BuildEntities(reader);

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

        DataTable ICMContractor_DetailedDataAccess.GetDT(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression)
        {
            try
            {
                const string SP = "dbo.CMContractor_Detailed";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
				    Database.AddInParameter(cmd, "@PageSize", DbType.Int32, pageSize);	
				    Database.AddInParameter(cmd, "@CurrentPage", DbType.Int32, currentPage);	
				    Database.AddInParameter(cmd, "@SortExpression", DbType.String, sortExpression);	
				    Database.AddInParameter(cmd, "@FilterExpression", DbType.String, filterExpression);	

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
