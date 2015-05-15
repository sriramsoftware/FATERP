// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 30-Jan-2013, 03:35:13




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
    internal sealed partial class ACDebitCreditRuleDataAccess : BaseDataAccess, IACDebitCreditRuleDataAccess
    {
        #region Constructors

        public ACDebitCreditRuleDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACDebitCreditRuleEntity> CreateEntityBuilder<ACDebitCreditRuleEntity>()
        {
            return (new ACDebitCreditRuleBuilder()) as IEntityBuilder<ACDebitCreditRuleEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACDebitCreditRuleDataAccess.Add(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCDebitCreditRuleEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCDebitCreditRuleEntity, option);
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

        private Int64 Add(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACDebitCreditRule_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ACDebitCreditRuleID");

                Database.AddInParameter(cmd, "@DebitCreditActionID", DbType.Int64, aCDebitCreditRuleEntity.DebitCreditActionID);	
                Database.AddInParameter(cmd, "@IsUp", DbType.Boolean, aCDebitCreditRuleEntity.IsUp);	
                Database.AddInParameter(cmd, "@IsDown", DbType.Boolean, aCDebitCreditRuleEntity.IsDown);	
                Database.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCDebitCreditRuleEntity.MDDebitCreditID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACDebitCreditRuleEntity already exists. Please specify another ACDebitCreditRuleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACDebitCreditRuleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACDebitCreditRuleEntity already exists. Please specify another ACDebitCreditRuleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACDebitCreditRule_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ACDebitCreditRuleID", db);

                db.AddInParameter(cmd, "@DebitCreditActionID", DbType.Int64, aCDebitCreditRuleEntity.DebitCreditActionID);
                db.AddInParameter(cmd, "@IsUp", DbType.Boolean, aCDebitCreditRuleEntity.IsUp);
                db.AddInParameter(cmd, "@IsDown", DbType.Boolean, aCDebitCreditRuleEntity.IsDown);
                db.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCDebitCreditRuleEntity.MDDebitCreditID);

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

        IList<Int64> IACDebitCreditRuleDataAccess.Add(IList<ACDebitCreditRuleEntity> aCDebitCreditRuleEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACDebitCreditRuleEntity aCDebitCreditRuleEntity in aCDebitCreditRuleEntityList)
            {
                returnCode = (this as IACDebitCreditRuleDataAccess).Add(aCDebitCreditRuleEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACDebitCreditRuleDataAccess.Update(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCDebitCreditRuleEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCDebitCreditRuleEntity, filterExpression, option);
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

        private Int64 Update(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACDebitCreditRule_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ACDebitCreditRuleID", DbType.Int64, aCDebitCreditRuleEntity.ACDebitCreditRuleID);
                Database.AddInParameter(cmd, "@DebitCreditActionID", DbType.Int64, aCDebitCreditRuleEntity.DebitCreditActionID);
                Database.AddInParameter(cmd, "@IsUp", DbType.Boolean, aCDebitCreditRuleEntity.IsUp);
                Database.AddInParameter(cmd, "@IsDown", DbType.Boolean, aCDebitCreditRuleEntity.IsDown);
                Database.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCDebitCreditRuleEntity.MDDebitCreditID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACDebitCreditRuleEntity already exists. Please specify another ACDebitCreditRuleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACDebitCreditRuleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACDebitCreditRuleEntity already exists. Please specify another ACDebitCreditRuleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACDebitCreditRule_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ACDebitCreditRuleID", DbType.Int64, aCDebitCreditRuleEntity.ACDebitCreditRuleID);
                db.AddInParameter(cmd, "@DebitCreditActionID", DbType.Int64, aCDebitCreditRuleEntity.DebitCreditActionID);
                db.AddInParameter(cmd, "@IsUp", DbType.Boolean, aCDebitCreditRuleEntity.IsUp);
                db.AddInParameter(cmd, "@IsDown", DbType.Boolean, aCDebitCreditRuleEntity.IsDown);
                db.AddInParameter(cmd, "@MDDebitCreditID", DbType.Int64, aCDebitCreditRuleEntity.MDDebitCreditID);

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

        IList<Int64> IACDebitCreditRuleDataAccess.Update(IList<ACDebitCreditRuleEntity> aCDebitCreditRuleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACDebitCreditRuleEntity aCDebitCreditRuleEntity in aCDebitCreditRuleEntityList)
            {
                returnCode = (this as IACDebitCreditRuleDataAccess).Update(aCDebitCreditRuleEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACDebitCreditRuleDataAccess.Delete(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCDebitCreditRuleEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCDebitCreditRuleEntity, filterExpression, option);
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

        private Int64 Delete(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACDebitCreditRule_SET";

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
                                throw new ArgumentException("ACDebitCreditRuleEntity already exists. Please specify another ACDebitCreditRuleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACDebitCreditRuleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACDebitCreditRuleEntity already exists. Please specify another ACDebitCreditRuleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACDebitCreditRuleEntity aCDebitCreditRuleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACDebitCreditRule_SET";

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

        IList<Int64> IACDebitCreditRuleDataAccess.Delete(IList<ACDebitCreditRuleEntity> aCDebitCreditRuleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACDebitCreditRuleEntity aCDebitCreditRuleEntity in aCDebitCreditRuleEntityList)
            {
                returnCode = (this as IACDebitCreditRuleDataAccess).Delete(aCDebitCreditRuleEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACDebitCreditRuleEntity> IACDebitCreditRuleDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACDebitCreditRule_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACDebitCreditRuleEntity> list = CreateEntityBuilder<ACDebitCreditRuleEntity>().BuildEntities(reader);

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

        DataTable IACDebitCreditRuleDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACDebitCreditRule_GET";

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
