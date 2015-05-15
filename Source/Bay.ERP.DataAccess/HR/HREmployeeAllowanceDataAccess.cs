// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Jan-2014, 12:08:49




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
    internal sealed partial class HREmployeeAllowanceDataAccess : BaseDataAccess, IHREmployeeAllowanceDataAccess
    {
        #region Constructors

        public HREmployeeAllowanceDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeAllowanceEntity> CreateEntityBuilder<HREmployeeAllowanceEntity>()
        {
            return (new HREmployeeAllowanceBuilder()) as IEntityBuilder<HREmployeeAllowanceEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeAllowanceDataAccess.Add(HREmployeeAllowanceEntity hREmployeeAllowanceEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeAllowanceEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeAllowanceEntity, option);
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

        private Int64 Add(HREmployeeAllowanceEntity hREmployeeAllowanceEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAllowance_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeAllowanceID");

                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeAllowanceEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeAllowanceEntity.FiscalYearID);	
                Database.AddInParameter(cmd, "@AllowanceCategoryID", DbType.Int64, hREmployeeAllowanceEntity.AllowanceCategoryID);	
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, hREmployeeAllowanceEntity.Amount);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeAllowanceEntity.Remarks);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeAllowanceEntity.CreateDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeAllowanceEntity already exists. Please specify another HREmployeeAllowanceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeAllowanceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeAllowanceEntity already exists. Please specify another HREmployeeAllowanceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeAllowanceEntity hREmployeeAllowanceEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAllowance_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeAllowanceID", db);

                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeAllowanceEntity.EmployeeID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeAllowanceEntity.FiscalYearID);
                db.AddInParameter(cmd, "@AllowanceCategoryID", DbType.Int64, hREmployeeAllowanceEntity.AllowanceCategoryID);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, hREmployeeAllowanceEntity.Amount);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeAllowanceEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeAllowanceEntity.CreateDate);

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

        IList<Int64> IHREmployeeAllowanceDataAccess.Add(IList<HREmployeeAllowanceEntity> hREmployeeAllowanceEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeAllowanceEntity hREmployeeAllowanceEntity in hREmployeeAllowanceEntityList)
            {
                returnCode = (this as IHREmployeeAllowanceDataAccess).Add(hREmployeeAllowanceEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeAllowanceDataAccess.Update(HREmployeeAllowanceEntity hREmployeeAllowanceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeAllowanceEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeAllowanceEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeAllowanceEntity hREmployeeAllowanceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAllowance_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeAllowanceID", DbType.Int64, hREmployeeAllowanceEntity.EmployeeAllowanceID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeAllowanceEntity.EmployeeID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeAllowanceEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@AllowanceCategoryID", DbType.Int64, hREmployeeAllowanceEntity.AllowanceCategoryID);
                Database.AddInParameter(cmd, "@Amount", DbType.Decimal, hREmployeeAllowanceEntity.Amount);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeAllowanceEntity.Remarks);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeAllowanceEntity.CreateDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeAllowanceEntity already exists. Please specify another HREmployeeAllowanceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeAllowanceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeAllowanceEntity already exists. Please specify another HREmployeeAllowanceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeAllowanceEntity hREmployeeAllowanceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAllowance_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeAllowanceID", DbType.Int64, hREmployeeAllowanceEntity.EmployeeAllowanceID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hREmployeeAllowanceEntity.EmployeeID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hREmployeeAllowanceEntity.FiscalYearID);
                db.AddInParameter(cmd, "@AllowanceCategoryID", DbType.Int64, hREmployeeAllowanceEntity.AllowanceCategoryID);
                db.AddInParameter(cmd, "@Amount", DbType.Decimal, hREmployeeAllowanceEntity.Amount);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeAllowanceEntity.Remarks);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, hREmployeeAllowanceEntity.CreateDate);

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

        IList<Int64> IHREmployeeAllowanceDataAccess.Update(IList<HREmployeeAllowanceEntity> hREmployeeAllowanceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeAllowanceEntity hREmployeeAllowanceEntity in hREmployeeAllowanceEntityList)
            {
                returnCode = (this as IHREmployeeAllowanceDataAccess).Update(hREmployeeAllowanceEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeAllowanceDataAccess.Delete(HREmployeeAllowanceEntity hREmployeeAllowanceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeAllowanceEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeAllowanceEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeAllowanceEntity hREmployeeAllowanceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAllowance_SET";

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
                                throw new ArgumentException("HREmployeeAllowanceEntity already exists. Please specify another HREmployeeAllowanceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeAllowanceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeAllowanceEntity already exists. Please specify another HREmployeeAllowanceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeAllowanceEntity hREmployeeAllowanceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAllowance_SET";

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

        IList<Int64> IHREmployeeAllowanceDataAccess.Delete(IList<HREmployeeAllowanceEntity> hREmployeeAllowanceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeAllowanceEntity hREmployeeAllowanceEntity in hREmployeeAllowanceEntityList)
            {
                returnCode = (this as IHREmployeeAllowanceDataAccess).Delete(hREmployeeAllowanceEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeAllowanceEntity> IHREmployeeAllowanceDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeAllowance_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeAllowanceEntity> list = CreateEntityBuilder<HREmployeeAllowanceEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeAllowanceDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeAllowance_GET";

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
