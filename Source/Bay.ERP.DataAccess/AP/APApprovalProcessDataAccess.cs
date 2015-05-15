// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Oct-2012, 03:53:48




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
    internal sealed partial class APApprovalProcessDataAccess : BaseDataAccess, IAPApprovalProcessDataAccess
    {
        #region Constructors

        public APApprovalProcessDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<APApprovalProcessEntity> CreateEntityBuilder<APApprovalProcessEntity>()
        {
            return (new APApprovalProcessBuilder()) as IEntityBuilder<APApprovalProcessEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IAPApprovalProcessDataAccess.Add(APApprovalProcessEntity aPApprovalProcessEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aPApprovalProcessEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aPApprovalProcessEntity, option);
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

        private Int64 Add(APApprovalProcessEntity aPApprovalProcessEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APApprovalProcess_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "APApprovalProcessID");

                Database.AddInParameter(cmd, "@APTypeID", DbType.Int64, aPApprovalProcessEntity.APTypeID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aPApprovalProcessEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@Description", DbType.String, aPApprovalProcessEntity.Description);	
                Database.AddInParameter(cmd, "@Title", DbType.String, aPApprovalProcessEntity.Title);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aPApprovalProcessEntity.CreateDate);	
                Database.AddInParameter(cmd, "@APStatusID", DbType.Int64, aPApprovalProcessEntity.APStatusID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("APApprovalProcessEntity already exists. Please specify another APApprovalProcessEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APApprovalProcessEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APApprovalProcessEntity already exists. Please specify another APApprovalProcessEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(APApprovalProcessEntity aPApprovalProcessEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APApprovalProcess_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "APApprovalProcessID", db);

                db.AddInParameter(cmd, "@APTypeID", DbType.Int64, aPApprovalProcessEntity.APTypeID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aPApprovalProcessEntity.ReferenceID);
                db.AddInParameter(cmd, "@Description", DbType.String, aPApprovalProcessEntity.Description);
                db.AddInParameter(cmd, "@Title", DbType.String, aPApprovalProcessEntity.Title);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aPApprovalProcessEntity.CreateDate);
                db.AddInParameter(cmd, "@APStatusID", DbType.Int64, aPApprovalProcessEntity.APStatusID);

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

        IList<Int64> IAPApprovalProcessDataAccess.Add(IList<APApprovalProcessEntity> aPApprovalProcessEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (APApprovalProcessEntity aPApprovalProcessEntity in aPApprovalProcessEntityList)
            {
                returnCode = (this as IAPApprovalProcessDataAccess).Add(aPApprovalProcessEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IAPApprovalProcessDataAccess.Update(APApprovalProcessEntity aPApprovalProcessEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aPApprovalProcessEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aPApprovalProcessEntity, filterExpression, option);
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

        private Int64 Update(APApprovalProcessEntity aPApprovalProcessEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APApprovalProcess_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@APApprovalProcessID", DbType.Int64, aPApprovalProcessEntity.APApprovalProcessID);
                Database.AddInParameter(cmd, "@APTypeID", DbType.Int64, aPApprovalProcessEntity.APTypeID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aPApprovalProcessEntity.ReferenceID);
                Database.AddInParameter(cmd, "@Description", DbType.String, aPApprovalProcessEntity.Description);
                Database.AddInParameter(cmd, "@Title", DbType.String, aPApprovalProcessEntity.Title);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aPApprovalProcessEntity.CreateDate);
                Database.AddInParameter(cmd, "@APStatusID", DbType.Int64, aPApprovalProcessEntity.APStatusID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("APApprovalProcessEntity already exists. Please specify another APApprovalProcessEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APApprovalProcessEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APApprovalProcessEntity already exists. Please specify another APApprovalProcessEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(APApprovalProcessEntity aPApprovalProcessEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APApprovalProcess_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@APApprovalProcessID", DbType.Int64, aPApprovalProcessEntity.APApprovalProcessID);
                db.AddInParameter(cmd, "@APTypeID", DbType.Int64, aPApprovalProcessEntity.APTypeID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, aPApprovalProcessEntity.ReferenceID);
                db.AddInParameter(cmd, "@Description", DbType.String, aPApprovalProcessEntity.Description);
                db.AddInParameter(cmd, "@Title", DbType.String, aPApprovalProcessEntity.Title);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aPApprovalProcessEntity.CreateDate);
                db.AddInParameter(cmd, "@APStatusID", DbType.Int64, aPApprovalProcessEntity.APStatusID);

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

        IList<Int64> IAPApprovalProcessDataAccess.Update(IList<APApprovalProcessEntity> aPApprovalProcessEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (APApprovalProcessEntity aPApprovalProcessEntity in aPApprovalProcessEntityList)
            {
                returnCode = (this as IAPApprovalProcessDataAccess).Update(aPApprovalProcessEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IAPApprovalProcessDataAccess.Delete(APApprovalProcessEntity aPApprovalProcessEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aPApprovalProcessEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aPApprovalProcessEntity, filterExpression, option);
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

        private Int64 Delete(APApprovalProcessEntity aPApprovalProcessEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APApprovalProcess_SET";

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
                                throw new ArgumentException("APApprovalProcessEntity already exists. Please specify another APApprovalProcessEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("APApprovalProcessEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("APApprovalProcessEntity already exists. Please specify another APApprovalProcessEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(APApprovalProcessEntity aPApprovalProcessEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.APApprovalProcess_SET";

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

        IList<Int64> IAPApprovalProcessDataAccess.Delete(IList<APApprovalProcessEntity> aPApprovalProcessEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (APApprovalProcessEntity aPApprovalProcessEntity in aPApprovalProcessEntityList)
            {
                returnCode = (this as IAPApprovalProcessDataAccess).Delete(aPApprovalProcessEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<APApprovalProcessEntity> IAPApprovalProcessDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.APApprovalProcess_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<APApprovalProcessEntity> list = CreateEntityBuilder<APApprovalProcessEntity>().BuildEntities(reader);

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

        DataTable IAPApprovalProcessDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.APApprovalProcess_GET";

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
