// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




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
    internal sealed partial class HRSalaryAdjustmentDataAccess : BaseDataAccess, IHRSalaryAdjustmentDataAccess
    {
        #region Constructors

        public HRSalaryAdjustmentDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HRSalaryAdjustmentEntity> CreateEntityBuilder<HRSalaryAdjustmentEntity>()
        {
            return (new HRSalaryAdjustmentBuilder()) as IEntityBuilder<HRSalaryAdjustmentEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHRSalaryAdjustmentDataAccess.Add(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hRSalaryAdjustmentEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hRSalaryAdjustmentEntity, option);
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

        private Int64 Add(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSalaryAdjustment_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "SalaryAdjustmentID");

                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRSalaryAdjustmentEntity.FiscalYearID);	
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRSalaryAdjustmentEntity.SalarySessionID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRSalaryAdjustmentEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hRSalaryAdjustmentEntity.SalaryLevel);	
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hRSalaryAdjustmentEntity.DesignationID);	
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hRSalaryAdjustmentEntity.EmployeeCode);	
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hRSalaryAdjustmentEntity.EmployeeJobTypeID);	
                Database.AddInParameter(cmd, "@AdjustmentAmount", DbType.Decimal, hRSalaryAdjustmentEntity.AdjustmentAmount);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRSalaryAdjustmentEntity.Remarks);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRSalaryAdjustmentEntity already exists. Please specify another HRSalaryAdjustmentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRSalaryAdjustmentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRSalaryAdjustmentEntity already exists. Please specify another HRSalaryAdjustmentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSalaryAdjustment_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "SalaryAdjustmentID");

                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRSalaryAdjustmentEntity.FiscalYearID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRSalaryAdjustmentEntity.SalarySessionID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRSalaryAdjustmentEntity.EmployeeID);
                db.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hRSalaryAdjustmentEntity.SalaryLevel);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hRSalaryAdjustmentEntity.DesignationID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hRSalaryAdjustmentEntity.EmployeeCode);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hRSalaryAdjustmentEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@AdjustmentAmount", DbType.Decimal, hRSalaryAdjustmentEntity.AdjustmentAmount);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRSalaryAdjustmentEntity.Remarks);

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

        IList<Int64> IHRSalaryAdjustmentDataAccess.Add(IList<HRSalaryAdjustmentEntity> hRSalaryAdjustmentEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity in hRSalaryAdjustmentEntityList)
            {
                returnCode = (this as IHRSalaryAdjustmentDataAccess).Add(hRSalaryAdjustmentEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHRSalaryAdjustmentDataAccess.Update(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hRSalaryAdjustmentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hRSalaryAdjustmentEntity, filterExpression, option);
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

        private Int64 Update(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSalaryAdjustment_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@SalaryAdjustmentID", DbType.Int64, hRSalaryAdjustmentEntity.SalaryAdjustmentID);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRSalaryAdjustmentEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRSalaryAdjustmentEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRSalaryAdjustmentEntity.EmployeeID);
                Database.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hRSalaryAdjustmentEntity.SalaryLevel);
                Database.AddInParameter(cmd, "@DesignationID", DbType.Int64, hRSalaryAdjustmentEntity.DesignationID);
                Database.AddInParameter(cmd, "@EmployeeCode", DbType.String, hRSalaryAdjustmentEntity.EmployeeCode);
                Database.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hRSalaryAdjustmentEntity.EmployeeJobTypeID);
                Database.AddInParameter(cmd, "@AdjustmentAmount", DbType.Decimal, hRSalaryAdjustmentEntity.AdjustmentAmount);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRSalaryAdjustmentEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRSalaryAdjustmentEntity already exists. Please specify another HRSalaryAdjustmentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRSalaryAdjustmentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRSalaryAdjustmentEntity already exists. Please specify another HRSalaryAdjustmentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSalaryAdjustment_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@SalaryAdjustmentID", DbType.Int64, hRSalaryAdjustmentEntity.SalaryAdjustmentID);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRSalaryAdjustmentEntity.FiscalYearID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRSalaryAdjustmentEntity.SalarySessionID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRSalaryAdjustmentEntity.EmployeeID);
                db.AddInParameter(cmd, "@SalaryLevel", DbType.Int32, hRSalaryAdjustmentEntity.SalaryLevel);
                db.AddInParameter(cmd, "@DesignationID", DbType.Int64, hRSalaryAdjustmentEntity.DesignationID);
                db.AddInParameter(cmd, "@EmployeeCode", DbType.String, hRSalaryAdjustmentEntity.EmployeeCode);
                db.AddInParameter(cmd, "@EmployeeJobTypeID", DbType.Int64, hRSalaryAdjustmentEntity.EmployeeJobTypeID);
                db.AddInParameter(cmd, "@AdjustmentAmount", DbType.Decimal, hRSalaryAdjustmentEntity.AdjustmentAmount);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRSalaryAdjustmentEntity.Remarks);

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

        IList<Int64> IHRSalaryAdjustmentDataAccess.Update(IList<HRSalaryAdjustmentEntity> hRSalaryAdjustmentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity in hRSalaryAdjustmentEntityList)
            {
                returnCode = (this as IHRSalaryAdjustmentDataAccess).Update(hRSalaryAdjustmentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHRSalaryAdjustmentDataAccess.Delete(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hRSalaryAdjustmentEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hRSalaryAdjustmentEntity, filterExpression, option);
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

        private Int64 Delete(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSalaryAdjustment_SET";

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
                                throw new ArgumentException("HRSalaryAdjustmentEntity already exists. Please specify another HRSalaryAdjustmentEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRSalaryAdjustmentEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRSalaryAdjustmentEntity already exists. Please specify another HRSalaryAdjustmentEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRSalaryAdjustment_SET";

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

        IList<Int64> IHRSalaryAdjustmentDataAccess.Delete(IList<HRSalaryAdjustmentEntity> hRSalaryAdjustmentEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HRSalaryAdjustmentEntity hRSalaryAdjustmentEntity in hRSalaryAdjustmentEntityList)
            {
                returnCode = (this as IHRSalaryAdjustmentDataAccess).Delete(hRSalaryAdjustmentEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HRSalaryAdjustmentEntity> IHRSalaryAdjustmentDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRSalaryAdjustment_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HRSalaryAdjustmentEntity> list = CreateEntityBuilder<HRSalaryAdjustmentEntity>().BuildEntities(reader);

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

        DataTable IHRSalaryAdjustmentDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRSalaryAdjustment_GET";

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
