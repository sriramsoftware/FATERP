// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Mar-2013, 10:30:04




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
    internal sealed partial class ACTDSHistoryDataAccess : BaseDataAccess, IACTDSHistoryDataAccess
    {
        #region Constructors

        public ACTDSHistoryDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<ACTDSHistoryEntity> CreateEntityBuilder<ACTDSHistoryEntity>()
        {
            return (new ACTDSHistoryBuilder()) as IEntityBuilder<ACTDSHistoryEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IACTDSHistoryDataAccess.Add(ACTDSHistoryEntity aCTDSHistoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(aCTDSHistoryEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(aCTDSHistoryEntity, option);
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

        private Int64 Add(ACTDSHistoryEntity aCTDSHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDSHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "TDSHistoryID");

                Database.AddInParameter(cmd, "@TDSCategoryID", DbType.Int64, aCTDSHistoryEntity.TDSCategoryID);	
                Database.AddInParameter(cmd, "@StartValue", DbType.Decimal, aCTDSHistoryEntity.StartValue);	
                Database.AddInParameter(cmd, "@EndValue", DbType.Decimal, aCTDSHistoryEntity.EndValue);	
                Database.AddInParameter(cmd, "@Tax", DbType.Decimal, aCTDSHistoryEntity.Tax);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCTDSHistoryEntity.Remarks);	
                Database.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, aCTDSHistoryEntity.UpdatedDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACTDSHistoryEntity already exists. Please specify another ACTDSHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTDSHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTDSHistoryEntity already exists. Please specify another ACTDSHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(ACTDSHistoryEntity aCTDSHistoryEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDSHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "TDSHistoryID", db);

                db.AddInParameter(cmd, "@TDSCategoryID", DbType.Int64, aCTDSHistoryEntity.TDSCategoryID);
                db.AddInParameter(cmd, "@StartValue", DbType.Decimal, aCTDSHistoryEntity.StartValue);
                db.AddInParameter(cmd, "@EndValue", DbType.Decimal, aCTDSHistoryEntity.EndValue);
                db.AddInParameter(cmd, "@Tax", DbType.Decimal, aCTDSHistoryEntity.Tax);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCTDSHistoryEntity.Remarks);
                db.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, aCTDSHistoryEntity.UpdatedDate);

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

        IList<Int64> IACTDSHistoryDataAccess.Add(IList<ACTDSHistoryEntity> aCTDSHistoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (ACTDSHistoryEntity aCTDSHistoryEntity in aCTDSHistoryEntityList)
            {
                returnCode = (this as IACTDSHistoryDataAccess).Add(aCTDSHistoryEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IACTDSHistoryDataAccess.Update(ACTDSHistoryEntity aCTDSHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(aCTDSHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(aCTDSHistoryEntity, filterExpression, option);
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

        private Int64 Update(ACTDSHistoryEntity aCTDSHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDSHistory_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@TDSHistoryID", DbType.Int64, aCTDSHistoryEntity.TDSHistoryID);
                Database.AddInParameter(cmd, "@TDSCategoryID", DbType.Int64, aCTDSHistoryEntity.TDSCategoryID);
                Database.AddInParameter(cmd, "@StartValue", DbType.Decimal, aCTDSHistoryEntity.StartValue);
                Database.AddInParameter(cmd, "@EndValue", DbType.Decimal, aCTDSHistoryEntity.EndValue);
                Database.AddInParameter(cmd, "@Tax", DbType.Decimal, aCTDSHistoryEntity.Tax);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, aCTDSHistoryEntity.Remarks);
                Database.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, aCTDSHistoryEntity.UpdatedDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("ACTDSHistoryEntity already exists. Please specify another ACTDSHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTDSHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTDSHistoryEntity already exists. Please specify another ACTDSHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(ACTDSHistoryEntity aCTDSHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDSHistory_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@TDSHistoryID", DbType.Int64, aCTDSHistoryEntity.TDSHistoryID);
                db.AddInParameter(cmd, "@TDSCategoryID", DbType.Int64, aCTDSHistoryEntity.TDSCategoryID);
                db.AddInParameter(cmd, "@StartValue", DbType.Decimal, aCTDSHistoryEntity.StartValue);
                db.AddInParameter(cmd, "@EndValue", DbType.Decimal, aCTDSHistoryEntity.EndValue);
                db.AddInParameter(cmd, "@Tax", DbType.Decimal, aCTDSHistoryEntity.Tax);
                db.AddInParameter(cmd, "@Remarks", DbType.String, aCTDSHistoryEntity.Remarks);
                db.AddInParameter(cmd, "@UpdatedDate", DbType.DateTime, aCTDSHistoryEntity.UpdatedDate);

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

        IList<Int64> IACTDSHistoryDataAccess.Update(IList<ACTDSHistoryEntity> aCTDSHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (ACTDSHistoryEntity aCTDSHistoryEntity in aCTDSHistoryEntityList)
            {
                returnCode = (this as IACTDSHistoryDataAccess).Update(aCTDSHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IACTDSHistoryDataAccess.Delete(ACTDSHistoryEntity aCTDSHistoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(aCTDSHistoryEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(aCTDSHistoryEntity, filterExpression, option);
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

        private Int64 Delete(ACTDSHistoryEntity aCTDSHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDSHistory_SET";

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
                                throw new ArgumentException("ACTDSHistoryEntity already exists. Please specify another ACTDSHistoryEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("ACTDSHistoryEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("ACTDSHistoryEntity already exists. Please specify another ACTDSHistoryEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(ACTDSHistoryEntity aCTDSHistoryEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.ACTDSHistory_SET";

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

        IList<Int64> IACTDSHistoryDataAccess.Delete(IList<ACTDSHistoryEntity> aCTDSHistoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (ACTDSHistoryEntity aCTDSHistoryEntity in aCTDSHistoryEntityList)
            {
                returnCode = (this as IACTDSHistoryDataAccess).Delete(aCTDSHistoryEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<ACTDSHistoryEntity> IACTDSHistoryDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACTDSHistory_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<ACTDSHistoryEntity> list = CreateEntityBuilder<ACTDSHistoryEntity>().BuildEntities(reader);

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

        DataTable IACTDSHistoryDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.ACTDSHistory_GET";

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
