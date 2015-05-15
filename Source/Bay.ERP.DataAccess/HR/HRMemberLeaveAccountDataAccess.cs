// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




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
    internal sealed partial class HRMemberLeaveAccountDataAccess : BaseDataAccess, IHRMemberLeaveAccountDataAccess
    {
        #region Constructors

        public HRMemberLeaveAccountDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HRMemberLeaveAccountEntity> CreateEntityBuilder<HRMemberLeaveAccountEntity>()
        {
            return (new HRMemberLeaveAccountBuilder()) as IEntityBuilder<HRMemberLeaveAccountEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHRMemberLeaveAccountDataAccess.Add(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hRMemberLeaveAccountEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hRMemberLeaveAccountEntity, option);
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

        private Int64 Add(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveAccount_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "MemberLeaveAccountID");

                Database.AddInParameter(cmd, "@AttendanceLeaveHolidayListID", DbType.Int64, hRMemberLeaveAccountEntity.AttendanceLeaveHolidayListID);	
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRMemberLeaveAccountEntity.SalarySessionID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRMemberLeaveAccountEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@UpdateDate", DbType.DateTime, hRMemberLeaveAccountEntity.UpdateDate);	
                Database.AddInParameter(cmd, "@EarnedDays", DbType.Decimal, hRMemberLeaveAccountEntity.EarnedDays);	
                Database.AddInParameter(cmd, "@AccuredDays", DbType.Decimal, hRMemberLeaveAccountEntity.AccuredDays);	
                Database.AddInParameter(cmd, "@UsedDays", DbType.Decimal, hRMemberLeaveAccountEntity.UsedDays);	
                Database.AddInParameter(cmd, "@BalanceDays", DbType.Decimal, hRMemberLeaveAccountEntity.BalanceDays);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hRMemberLeaveAccountEntity.IsRemoved);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRMemberLeaveAccountEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, hRMemberLeaveAccountEntity.LeaveCategoryID);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRMemberLeaveAccountEntity already exists. Please specify another HRMemberLeaveAccountEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRMemberLeaveAccountEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRMemberLeaveAccountEntity already exists. Please specify another HRMemberLeaveAccountEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveAccount_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "MemberLeaveAccountID", db);

                db.AddInParameter(cmd, "@AttendanceLeaveHolidayListID", DbType.Int64, hRMemberLeaveAccountEntity.AttendanceLeaveHolidayListID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRMemberLeaveAccountEntity.SalarySessionID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRMemberLeaveAccountEntity.EmployeeID);
                db.AddInParameter(cmd, "@UpdateDate", DbType.DateTime, hRMemberLeaveAccountEntity.UpdateDate);
                db.AddInParameter(cmd, "@EarnedDays", DbType.Decimal, hRMemberLeaveAccountEntity.EarnedDays);
                db.AddInParameter(cmd, "@AccuredDays", DbType.Decimal, hRMemberLeaveAccountEntity.AccuredDays);
                db.AddInParameter(cmd, "@UsedDays", DbType.Decimal, hRMemberLeaveAccountEntity.UsedDays);
                db.AddInParameter(cmd, "@BalanceDays", DbType.Decimal, hRMemberLeaveAccountEntity.BalanceDays);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hRMemberLeaveAccountEntity.IsRemoved);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRMemberLeaveAccountEntity.FiscalYearID);
                db.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, hRMemberLeaveAccountEntity.LeaveCategoryID);

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

        IList<Int64> IHRMemberLeaveAccountDataAccess.Add(IList<HRMemberLeaveAccountEntity> hRMemberLeaveAccountEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity in hRMemberLeaveAccountEntityList)
            {
                returnCode = (this as IHRMemberLeaveAccountDataAccess).Add(hRMemberLeaveAccountEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHRMemberLeaveAccountDataAccess.Update(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hRMemberLeaveAccountEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hRMemberLeaveAccountEntity, filterExpression, option);
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

        private Int64 Update(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveAccount_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@MemberLeaveAccountID", DbType.Int64, hRMemberLeaveAccountEntity.MemberLeaveAccountID);
                Database.AddInParameter(cmd, "@AttendanceLeaveHolidayListID", DbType.Int64, hRMemberLeaveAccountEntity.AttendanceLeaveHolidayListID);
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRMemberLeaveAccountEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRMemberLeaveAccountEntity.EmployeeID);
                Database.AddInParameter(cmd, "@UpdateDate", DbType.DateTime, hRMemberLeaveAccountEntity.UpdateDate);
                Database.AddInParameter(cmd, "@EarnedDays", DbType.Decimal, hRMemberLeaveAccountEntity.EarnedDays);
                Database.AddInParameter(cmd, "@AccuredDays", DbType.Decimal, hRMemberLeaveAccountEntity.AccuredDays);
                Database.AddInParameter(cmd, "@UsedDays", DbType.Decimal, hRMemberLeaveAccountEntity.UsedDays);
                Database.AddInParameter(cmd, "@BalanceDays", DbType.Decimal, hRMemberLeaveAccountEntity.BalanceDays);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hRMemberLeaveAccountEntity.IsRemoved);
                Database.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRMemberLeaveAccountEntity.FiscalYearID);
                Database.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, hRMemberLeaveAccountEntity.LeaveCategoryID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRMemberLeaveAccountEntity already exists. Please specify another HRMemberLeaveAccountEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRMemberLeaveAccountEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRMemberLeaveAccountEntity already exists. Please specify another HRMemberLeaveAccountEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveAccount_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@MemberLeaveAccountID", DbType.Int64, hRMemberLeaveAccountEntity.MemberLeaveAccountID);
                db.AddInParameter(cmd, "@AttendanceLeaveHolidayListID", DbType.Int64, hRMemberLeaveAccountEntity.AttendanceLeaveHolidayListID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hRMemberLeaveAccountEntity.SalarySessionID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRMemberLeaveAccountEntity.EmployeeID);
                db.AddInParameter(cmd, "@UpdateDate", DbType.DateTime, hRMemberLeaveAccountEntity.UpdateDate);
                db.AddInParameter(cmd, "@EarnedDays", DbType.Decimal, hRMemberLeaveAccountEntity.EarnedDays);
                db.AddInParameter(cmd, "@AccuredDays", DbType.Decimal, hRMemberLeaveAccountEntity.AccuredDays);
                db.AddInParameter(cmd, "@UsedDays", DbType.Decimal, hRMemberLeaveAccountEntity.UsedDays);
                db.AddInParameter(cmd, "@BalanceDays", DbType.Decimal, hRMemberLeaveAccountEntity.BalanceDays);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, hRMemberLeaveAccountEntity.IsRemoved);
                db.AddInParameter(cmd, "@FiscalYearID", DbType.Int64, hRMemberLeaveAccountEntity.FiscalYearID);
                db.AddInParameter(cmd, "@LeaveCategoryID", DbType.Int64, hRMemberLeaveAccountEntity.LeaveCategoryID);

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

        IList<Int64> IHRMemberLeaveAccountDataAccess.Update(IList<HRMemberLeaveAccountEntity> hRMemberLeaveAccountEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity in hRMemberLeaveAccountEntityList)
            {
                returnCode = (this as IHRMemberLeaveAccountDataAccess).Update(hRMemberLeaveAccountEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHRMemberLeaveAccountDataAccess.Delete(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hRMemberLeaveAccountEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hRMemberLeaveAccountEntity, filterExpression, option);
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

        private Int64 Delete(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveAccount_SET";

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
                                throw new ArgumentException("HRMemberLeaveAccountEntity already exists. Please specify another HRMemberLeaveAccountEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRMemberLeaveAccountEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRMemberLeaveAccountEntity already exists. Please specify another HRMemberLeaveAccountEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveAccount_SET";

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

        IList<Int64> IHRMemberLeaveAccountDataAccess.Delete(IList<HRMemberLeaveAccountEntity> hRMemberLeaveAccountEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity in hRMemberLeaveAccountEntityList)
            {
                returnCode = (this as IHRMemberLeaveAccountDataAccess).Delete(hRMemberLeaveAccountEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HRMemberLeaveAccountEntity> IHRMemberLeaveAccountDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRMemberLeaveAccount_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HRMemberLeaveAccountEntity> list = CreateEntityBuilder<HRMemberLeaveAccountEntity>().BuildEntities(reader);

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

        DataTable IHRMemberLeaveAccountDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRMemberLeaveAccount_GET";

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
