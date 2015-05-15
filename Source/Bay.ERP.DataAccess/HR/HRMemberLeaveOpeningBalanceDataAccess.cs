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
    internal sealed partial class HRMemberLeaveOpeningBalanceDataAccess : BaseDataAccess, IHRMemberLeaveOpeningBalanceDataAccess
    {
        #region Constructors

        public HRMemberLeaveOpeningBalanceDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HRMemberLeaveOpeningBalanceEntity> CreateEntityBuilder<HRMemberLeaveOpeningBalanceEntity>()
        {
            return (new HRMemberLeaveOpeningBalanceBuilder()) as IEntityBuilder<HRMemberLeaveOpeningBalanceEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHRMemberLeaveOpeningBalanceDataAccess.Add(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hRMemberLeaveOpeningBalanceEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hRMemberLeaveOpeningBalanceEntity, option);
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

        private Int64 Add(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveOpeningBalance_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "MemberLeaveOpeningBalanceID");

                Database.AddInParameter(cmd, "@AttendanceLeaveHolidayListID", DbType.Int64, hRMemberLeaveOpeningBalanceEntity.AttendanceLeaveHolidayListID);	
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRMemberLeaveOpeningBalanceEntity.EmployeeID);	
                Database.AddInParameter(cmd, "@BalanceDays", DbType.Decimal, hRMemberLeaveOpeningBalanceEntity.BalanceDays);	
                Database.AddInParameter(cmd, "@BalanceAsOffDate", DbType.DateTime, hRMemberLeaveOpeningBalanceEntity.BalanceAsOffDate);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRMemberLeaveOpeningBalanceEntity.Remarks);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRMemberLeaveOpeningBalanceEntity already exists. Please specify another HRMemberLeaveOpeningBalanceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRMemberLeaveOpeningBalanceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRMemberLeaveOpeningBalanceEntity already exists. Please specify another HRMemberLeaveOpeningBalanceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveOpeningBalance_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "MemberLeaveOpeningBalanceID", db);

                db.AddInParameter(cmd, "@AttendanceLeaveHolidayListID", DbType.Int64, hRMemberLeaveOpeningBalanceEntity.AttendanceLeaveHolidayListID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRMemberLeaveOpeningBalanceEntity.EmployeeID);
                db.AddInParameter(cmd, "@BalanceDays", DbType.Decimal, hRMemberLeaveOpeningBalanceEntity.BalanceDays);
                db.AddInParameter(cmd, "@BalanceAsOffDate", DbType.DateTime, hRMemberLeaveOpeningBalanceEntity.BalanceAsOffDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRMemberLeaveOpeningBalanceEntity.Remarks);

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

        IList<Int64> IHRMemberLeaveOpeningBalanceDataAccess.Add(IList<HRMemberLeaveOpeningBalanceEntity> hRMemberLeaveOpeningBalanceEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity in hRMemberLeaveOpeningBalanceEntityList)
            {
                returnCode = (this as IHRMemberLeaveOpeningBalanceDataAccess).Add(hRMemberLeaveOpeningBalanceEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHRMemberLeaveOpeningBalanceDataAccess.Update(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hRMemberLeaveOpeningBalanceEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hRMemberLeaveOpeningBalanceEntity, filterExpression, option);
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

        private Int64 Update(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveOpeningBalance_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@MemberLeaveOpeningBalanceID", DbType.Int64, hRMemberLeaveOpeningBalanceEntity.MemberLeaveOpeningBalanceID);
                Database.AddInParameter(cmd, "@AttendanceLeaveHolidayListID", DbType.Int64, hRMemberLeaveOpeningBalanceEntity.AttendanceLeaveHolidayListID);
                Database.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRMemberLeaveOpeningBalanceEntity.EmployeeID);
                Database.AddInParameter(cmd, "@BalanceDays", DbType.Decimal, hRMemberLeaveOpeningBalanceEntity.BalanceDays);
                Database.AddInParameter(cmd, "@BalanceAsOffDate", DbType.DateTime, hRMemberLeaveOpeningBalanceEntity.BalanceAsOffDate);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hRMemberLeaveOpeningBalanceEntity.Remarks);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HRMemberLeaveOpeningBalanceEntity already exists. Please specify another HRMemberLeaveOpeningBalanceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRMemberLeaveOpeningBalanceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRMemberLeaveOpeningBalanceEntity already exists. Please specify another HRMemberLeaveOpeningBalanceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveOpeningBalance_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@MemberLeaveOpeningBalanceID", DbType.Int64, hRMemberLeaveOpeningBalanceEntity.MemberLeaveOpeningBalanceID);
                db.AddInParameter(cmd, "@AttendanceLeaveHolidayListID", DbType.Int64, hRMemberLeaveOpeningBalanceEntity.AttendanceLeaveHolidayListID);
                db.AddInParameter(cmd, "@EmployeeID", DbType.Int64, hRMemberLeaveOpeningBalanceEntity.EmployeeID);
                db.AddInParameter(cmd, "@BalanceDays", DbType.Decimal, hRMemberLeaveOpeningBalanceEntity.BalanceDays);
                db.AddInParameter(cmd, "@BalanceAsOffDate", DbType.DateTime, hRMemberLeaveOpeningBalanceEntity.BalanceAsOffDate);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hRMemberLeaveOpeningBalanceEntity.Remarks);

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

        IList<Int64> IHRMemberLeaveOpeningBalanceDataAccess.Update(IList<HRMemberLeaveOpeningBalanceEntity> hRMemberLeaveOpeningBalanceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity in hRMemberLeaveOpeningBalanceEntityList)
            {
                returnCode = (this as IHRMemberLeaveOpeningBalanceDataAccess).Update(hRMemberLeaveOpeningBalanceEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHRMemberLeaveOpeningBalanceDataAccess.Delete(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hRMemberLeaveOpeningBalanceEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hRMemberLeaveOpeningBalanceEntity, filterExpression, option);
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

        private Int64 Delete(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveOpeningBalance_SET";

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
                                throw new ArgumentException("HRMemberLeaveOpeningBalanceEntity already exists. Please specify another HRMemberLeaveOpeningBalanceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HRMemberLeaveOpeningBalanceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HRMemberLeaveOpeningBalanceEntity already exists. Please specify another HRMemberLeaveOpeningBalanceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HRMemberLeaveOpeningBalance_SET";

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

        IList<Int64> IHRMemberLeaveOpeningBalanceDataAccess.Delete(IList<HRMemberLeaveOpeningBalanceEntity> hRMemberLeaveOpeningBalanceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity in hRMemberLeaveOpeningBalanceEntityList)
            {
                returnCode = (this as IHRMemberLeaveOpeningBalanceDataAccess).Delete(hRMemberLeaveOpeningBalanceEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HRMemberLeaveOpeningBalanceEntity> IHRMemberLeaveOpeningBalanceDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRMemberLeaveOpeningBalance_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HRMemberLeaveOpeningBalanceEntity> list = CreateEntityBuilder<HRMemberLeaveOpeningBalanceEntity>().BuildEntities(reader);

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

        DataTable IHRMemberLeaveOpeningBalanceDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HRMemberLeaveOpeningBalance_GET";

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
