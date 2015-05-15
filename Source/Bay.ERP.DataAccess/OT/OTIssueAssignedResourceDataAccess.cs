// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Mar-2013, 10:57:47




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
    internal sealed partial class OTIssueAssignedResourceDataAccess : BaseDataAccess, IOTIssueAssignedResourceDataAccess
    {
        #region Constructors

        public OTIssueAssignedResourceDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<OTIssueAssignedResourceEntity> CreateEntityBuilder<OTIssueAssignedResourceEntity>()
        {
            return (new OTIssueAssignedResourceBuilder()) as IEntityBuilder<OTIssueAssignedResourceEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IOTIssueAssignedResourceDataAccess.Add(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(oTIssueAssignedResourceEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(oTIssueAssignedResourceEntity, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Add(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueAssignedResource_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "IssueAssignedResourceID");

                Database.AddInParameter(cmd, "@IssueID", DbType.Int64, oTIssueAssignedResourceEntity.IssueID);	
                Database.AddInParameter(cmd, "@ResourceID", DbType.Int64, oTIssueAssignedResourceEntity.ResourceID);	
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, oTIssueAssignedResourceEntity.StartDate);	
                Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, oTIssueAssignedResourceEntity.EndDate);	
                Database.AddInParameter(cmd, "@IssueAssignTypeID", DbType.Int64, oTIssueAssignedResourceEntity.IssueAssignTypeID);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueAssignedResourceEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("OTIssueAssignedResourceEntity already exists. Please specify another OTIssueAssignedResourceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTIssueAssignedResourceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTIssueAssignedResourceEntity already exists. Please specify another OTIssueAssignedResourceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueAssignedResource_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "IssueAssignedResourceID", db);

                db.AddInParameter(cmd, "@IssueID", DbType.Int64, oTIssueAssignedResourceEntity.IssueID);
                db.AddInParameter(cmd, "@ResourceID", DbType.Int64, oTIssueAssignedResourceEntity.ResourceID);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, oTIssueAssignedResourceEntity.StartDate);
                db.AddInParameter(cmd, "@EndDate", DbType.DateTime, oTIssueAssignedResourceEntity.EndDate);
                db.AddInParameter(cmd, "@IssueAssignTypeID", DbType.Int64, oTIssueAssignedResourceEntity.IssueAssignTypeID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueAssignedResourceEntity.Remarks);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    returnCode = db.ExecuteNonQuery(cmd, transaction);

                    returnCode = GetReturnCodeFromParameter(cmd, db);

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Add Operation

        #region Add List Operation

        IList<Int64> IOTIssueAssignedResourceDataAccess.Add(IList<OTIssueAssignedResourceEntity> oTIssueAssignedResourceEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity in oTIssueAssignedResourceEntityList)
            {
                returnCode = (this as IOTIssueAssignedResourceDataAccess).Add(oTIssueAssignedResourceEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IOTIssueAssignedResourceDataAccess.Update(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(oTIssueAssignedResourceEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(oTIssueAssignedResourceEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Update(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueAssignedResource_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@IssueAssignedResourceID", DbType.Int64, oTIssueAssignedResourceEntity.IssueAssignedResourceID);
                Database.AddInParameter(cmd, "@IssueID", DbType.Int64, oTIssueAssignedResourceEntity.IssueID);
                Database.AddInParameter(cmd, "@ResourceID", DbType.Int64, oTIssueAssignedResourceEntity.ResourceID);
                Database.AddInParameter(cmd, "@StartDate", DbType.DateTime, oTIssueAssignedResourceEntity.StartDate);
                Database.AddInParameter(cmd, "@EndDate", DbType.DateTime, oTIssueAssignedResourceEntity.EndDate);
                Database.AddInParameter(cmd, "@IssueAssignTypeID", DbType.Int64, oTIssueAssignedResourceEntity.IssueAssignTypeID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueAssignedResourceEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("OTIssueAssignedResourceEntity already exists. Please specify another OTIssueAssignedResourceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTIssueAssignedResourceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTIssueAssignedResourceEntity already exists. Please specify another OTIssueAssignedResourceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueAssignedResource_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@IssueAssignedResourceID", DbType.Int64, oTIssueAssignedResourceEntity.IssueAssignedResourceID);
                db.AddInParameter(cmd, "@IssueID", DbType.Int64, oTIssueAssignedResourceEntity.IssueID);
                db.AddInParameter(cmd, "@ResourceID", DbType.Int64, oTIssueAssignedResourceEntity.ResourceID);
                db.AddInParameter(cmd, "@StartDate", DbType.DateTime, oTIssueAssignedResourceEntity.StartDate);
                db.AddInParameter(cmd, "@EndDate", DbType.DateTime, oTIssueAssignedResourceEntity.EndDate);
                db.AddInParameter(cmd, "@IssueAssignTypeID", DbType.Int64, oTIssueAssignedResourceEntity.IssueAssignTypeID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, oTIssueAssignedResourceEntity.Remarks);

                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }                    

                    if (returnCode > 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Update Operation

        #region Update List Operation

        IList<Int64> IOTIssueAssignedResourceDataAccess.Update(IList<OTIssueAssignedResourceEntity> oTIssueAssignedResourceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity in oTIssueAssignedResourceEntityList)
            {
                returnCode = (this as IOTIssueAssignedResourceDataAccess).Update(oTIssueAssignedResourceEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IOTIssueAssignedResourceDataAccess.Delete(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(oTIssueAssignedResourceEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(oTIssueAssignedResourceEntity, filterExpression, option);
                            break;
                        }
                    default:
                        {
                            retValues = -99;
                            break;
                        }
                }

                return retValues;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private Int64 Delete(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueAssignedResource_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);


                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("OTIssueAssignedResourceEntity already exists. Please specify another OTIssueAssignedResourceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTIssueAssignedResourceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTIssueAssignedResourceEntity already exists. Please specify another OTIssueAssignedResourceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTIssueAssignedResource_SET";

            Database db = DatabaseFactory.CreateDatabase();


            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd, db);
                AddFilterExpressionParameter(cmd, filterExpression, db);


                DbConnection connection = db.CreateConnection();
                connection.Open();
                DbTransaction transaction = connection.BeginTransaction();

                try
                {
                    using (IDataReader reader = db.ExecuteReader(cmd, transaction))
                    {
                        returnCode = GetReturnCodeFromParameter(cmd);
                    }

                    if (returnCode >= 0)
                    {
                        transaction.Commit();
                    }
                    else
                    {
                        throw new ArgumentException("Error Code." + returnCode.ToString());
                    }
                }
                catch (Exception ex)
                {
                    transaction.Rollback();
                    throw ex;
                }
                finally
                {
                    transaction.Dispose();
                    connection.Close();
                    connection = null;
                }
            }

            return returnCode;
        }

        #endregion Delete Operation

        #region Delete List Operation

        IList<Int64> IOTIssueAssignedResourceDataAccess.Delete(IList<OTIssueAssignedResourceEntity> oTIssueAssignedResourceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (OTIssueAssignedResourceEntity oTIssueAssignedResourceEntity in oTIssueAssignedResourceEntityList)
            {
                returnCode = (this as IOTIssueAssignedResourceDataAccess).Delete(oTIssueAssignedResourceEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<OTIssueAssignedResourceEntity> IOTIssueAssignedResourceDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.OTIssueAssignedResource_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<OTIssueAssignedResourceEntity> list = CreateEntityBuilder<OTIssueAssignedResourceEntity>().BuildEntities(reader);

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

        DataTable IOTIssueAssignedResourceDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.OTIssueAssignedResource_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddCurrentPageParameter(cmd, currentPage);
                    AddPageSizeParameter(cmd, pageSize);
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

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
