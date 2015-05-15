// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 12:50:45




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
    internal sealed partial class ACMDTemporaryJournalApprovalStatusDataAccess : BaseDataAccess, IACMDTemporaryJournalApprovalStatusDataAccess
    {
        #region Constructors

        public ACMDTemporaryJournalApprovalStatusDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACMDTemporaryJournalApprovalStatusEntity> CreateEntityBuilder<ACMDTemporaryJournalApprovalStatusEntity>()
        {
            return (new ACMDTemporaryJournalApprovalStatusBuilder()) as IEntityBuilder<ACMDTemporaryJournalApprovalStatusEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACMDTemporaryJournalApprovalStatusDataAccess.Add(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCMDTemporaryJournalApprovalStatusEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCMDTemporaryJournalApprovalStatusEntity, option);
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

        private Int64 Add(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACMDTemporaryJournalApprovalStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TemporyJournalApprovalStatusID");

                Database.AddInParameter(cmd, "@Name", DbType.String, aCMDTemporaryJournalApprovalStatusEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, aCMDTemporaryJournalApprovalStatusEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCMDTemporaryJournalApprovalStatusEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACMDTemporaryJournalApprovalStatusEntity already exists. Please specify another ACMDTemporaryJournalApprovalStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACMDTemporaryJournalApprovalStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACMDTemporaryJournalApprovalStatusEntity already exists. Please specify another ACMDTemporaryJournalApprovalStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACMDTemporaryJournalApprovalStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TemporyJournalApprovalStatusID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, aCMDTemporaryJournalApprovalStatusEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, aCMDTemporaryJournalApprovalStatusEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCMDTemporaryJournalApprovalStatusEntity.IsRemoved);

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

        IList<Int64> IACMDTemporaryJournalApprovalStatusDataAccess.Add(IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity in aCMDTemporaryJournalApprovalStatusEntityList)
            {
                returnCode = (this as IACMDTemporaryJournalApprovalStatusDataAccess).Add(aCMDTemporaryJournalApprovalStatusEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACMDTemporaryJournalApprovalStatusDataAccess.Update(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCMDTemporaryJournalApprovalStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCMDTemporaryJournalApprovalStatusEntity, filterExpression, option);
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

        private Int64 Update(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACMDTemporaryJournalApprovalStatus_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TemporyJournalApprovalStatusID", DbType.Int64, aCMDTemporaryJournalApprovalStatusEntity.TemporyJournalApprovalStatusID);
                Database.AddInParameter(cmd, "@Name", DbType.String, aCMDTemporaryJournalApprovalStatusEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, aCMDTemporaryJournalApprovalStatusEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCMDTemporaryJournalApprovalStatusEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACMDTemporaryJournalApprovalStatusEntity already exists. Please specify another ACMDTemporaryJournalApprovalStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACMDTemporaryJournalApprovalStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACMDTemporaryJournalApprovalStatusEntity already exists. Please specify another ACMDTemporaryJournalApprovalStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACMDTemporaryJournalApprovalStatus_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TemporyJournalApprovalStatusID", DbType.Int64, aCMDTemporaryJournalApprovalStatusEntity.TemporyJournalApprovalStatusID);
                db.AddInParameter(cmd, "@Name", DbType.String, aCMDTemporaryJournalApprovalStatusEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, aCMDTemporaryJournalApprovalStatusEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, aCMDTemporaryJournalApprovalStatusEntity.IsRemoved);

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

        IList<Int64> IACMDTemporaryJournalApprovalStatusDataAccess.Update(IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity in aCMDTemporaryJournalApprovalStatusEntityList)
            {
                returnCode = (this as IACMDTemporaryJournalApprovalStatusDataAccess).Update(aCMDTemporaryJournalApprovalStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACMDTemporaryJournalApprovalStatusDataAccess.Delete(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCMDTemporaryJournalApprovalStatusEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCMDTemporaryJournalApprovalStatusEntity, filterExpression, option);
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

        private Int64 Delete(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACMDTemporaryJournalApprovalStatus_SET";

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
                                throw new ArgumentException("ACMDTemporaryJournalApprovalStatusEntity already exists. Please specify another ACMDTemporaryJournalApprovalStatusEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACMDTemporaryJournalApprovalStatusEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACMDTemporaryJournalApprovalStatusEntity already exists. Please specify another ACMDTemporaryJournalApprovalStatusEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACMDTemporaryJournalApprovalStatus_SET";

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

        IList<Int64> IACMDTemporaryJournalApprovalStatusDataAccess.Delete(IList<ACMDTemporaryJournalApprovalStatusEntity> aCMDTemporaryJournalApprovalStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACMDTemporaryJournalApprovalStatusEntity aCMDTemporaryJournalApprovalStatusEntity in aCMDTemporaryJournalApprovalStatusEntityList)
            {
                returnCode = (this as IACMDTemporaryJournalApprovalStatusDataAccess).Delete(aCMDTemporaryJournalApprovalStatusEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACMDTemporaryJournalApprovalStatusEntity> IACMDTemporaryJournalApprovalStatusDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACMDTemporaryJournalApprovalStatus_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACMDTemporaryJournalApprovalStatusEntity> list = CreateEntityBuilder<ACMDTemporaryJournalApprovalStatusEntity>().BuildEntities(reader);

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

        DataTable IACMDTemporaryJournalApprovalStatusDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACMDTemporaryJournalApprovalStatus_GET";

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
