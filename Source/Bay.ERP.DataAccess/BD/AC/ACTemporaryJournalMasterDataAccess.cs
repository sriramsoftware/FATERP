// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 17-Feb-2013, 02:08:21




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
    internal sealed partial class ACTemporaryJournalMasterDataAccess : BaseDataAccess, IACTemporaryJournalMasterDataAccess
    {
        #region Constructors

        public ACTemporaryJournalMasterDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACTemporaryJournalMasterEntity> CreateEntityBuilder<ACTemporaryJournalMasterEntity>()
        {
            return (new ACTemporaryJournalMasterBuilder()) as IEntityBuilder<ACTemporaryJournalMasterEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACTemporaryJournalMasterDataAccess.Add(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCTemporaryJournalMasterEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCTemporaryJournalMasterEntity, option);
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

        private Int64 Add(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournalMaster_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TemporaryJournalMasterID");

                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCTemporaryJournalMasterEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCTemporaryJournalMasterEntity.CreateDate);	
                Database.AddInParameter(cmd, "@TemporyJournalApprovalStatusID", DbType.Int64, aCTemporaryJournalMasterEntity.TemporyJournalApprovalStatusID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACTemporaryJournalMasterEntity already exists. Please specify another ACTemporaryJournalMasterEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTemporaryJournalMasterEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTemporaryJournalMasterEntity already exists. Please specify another ACTemporaryJournalMasterEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournalMaster_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TemporaryJournalMasterID", db);

                db.AddInParameter(cmd, "@Remarks", DbType.String, aCTemporaryJournalMasterEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCTemporaryJournalMasterEntity.CreateDate);
                db.AddInParameter(cmd, "@TemporyJournalApprovalStatusID", DbType.Int64, aCTemporaryJournalMasterEntity.TemporyJournalApprovalStatusID);

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

        IList<Int64> IACTemporaryJournalMasterDataAccess.Add(IList<ACTemporaryJournalMasterEntity> aCTemporaryJournalMasterEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity in aCTemporaryJournalMasterEntityList)
            {
                returnCode = (this as IACTemporaryJournalMasterDataAccess).Add(aCTemporaryJournalMasterEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACTemporaryJournalMasterDataAccess.Update(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCTemporaryJournalMasterEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCTemporaryJournalMasterEntity, filterExpression, option);
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

        private Int64 Update(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournalMaster_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TemporaryJournalMasterID", DbType.Int64, aCTemporaryJournalMasterEntity.TemporaryJournalMasterID);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCTemporaryJournalMasterEntity.Remarks);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCTemporaryJournalMasterEntity.CreateDate);
                Database.AddInParameter(cmd, "@TemporyJournalApprovalStatusID", DbType.Int64, aCTemporaryJournalMasterEntity.TemporyJournalApprovalStatusID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACTemporaryJournalMasterEntity already exists. Please specify another ACTemporaryJournalMasterEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTemporaryJournalMasterEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTemporaryJournalMasterEntity already exists. Please specify another ACTemporaryJournalMasterEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournalMaster_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TemporaryJournalMasterID", DbType.Int64, aCTemporaryJournalMasterEntity.TemporaryJournalMasterID);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCTemporaryJournalMasterEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, aCTemporaryJournalMasterEntity.CreateDate);
                db.AddInParameter(cmd, "@TemporyJournalApprovalStatusID", DbType.Int64, aCTemporaryJournalMasterEntity.TemporyJournalApprovalStatusID);

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

        IList<Int64> IACTemporaryJournalMasterDataAccess.Update(IList<ACTemporaryJournalMasterEntity> aCTemporaryJournalMasterEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity in aCTemporaryJournalMasterEntityList)
            {
                returnCode = (this as IACTemporaryJournalMasterDataAccess).Update(aCTemporaryJournalMasterEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACTemporaryJournalMasterDataAccess.Delete(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCTemporaryJournalMasterEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCTemporaryJournalMasterEntity, filterExpression, option);
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

        private Int64 Delete(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournalMaster_SET";

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
                                throw new ArgumentException("ACTemporaryJournalMasterEntity already exists. Please specify another ACTemporaryJournalMasterEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTemporaryJournalMasterEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTemporaryJournalMasterEntity already exists. Please specify another ACTemporaryJournalMasterEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTemporaryJournalMaster_SET";

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

        IList<Int64> IACTemporaryJournalMasterDataAccess.Delete(IList<ACTemporaryJournalMasterEntity> aCTemporaryJournalMasterEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACTemporaryJournalMasterEntity aCTemporaryJournalMasterEntity in aCTemporaryJournalMasterEntityList)
            {
                returnCode = (this as IACTemporaryJournalMasterDataAccess).Delete(aCTemporaryJournalMasterEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACTemporaryJournalMasterEntity> IACTemporaryJournalMasterDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACTemporaryJournalMaster_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACTemporaryJournalMasterEntity> list = CreateEntityBuilder<ACTemporaryJournalMasterEntity>().BuildEntities(reader);

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

        DataTable IACTemporaryJournalMasterDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACTemporaryJournalMaster_GET";

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
