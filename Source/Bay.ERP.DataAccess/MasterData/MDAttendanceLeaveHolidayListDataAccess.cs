// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    internal sealed partial class MDAttendanceLeaveHolidayListDataAccess : BaseDataAccess, IMDAttendanceLeaveHolidayListDataAccess
    {
        #region Constructors

        public MDAttendanceLeaveHolidayListDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDAttendanceLeaveHolidayListEntity> CreateEntityBuilder<MDAttendanceLeaveHolidayListEntity>()
        {
            return (new MDAttendanceLeaveHolidayListBuilder()) as IEntityBuilder<MDAttendanceLeaveHolidayListEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDAttendanceLeaveHolidayListDataAccess.Add(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDAttendanceLeaveHolidayListEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDAttendanceLeaveHolidayListEntity, option);
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

        private Int64 Add(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAttendanceLeaveHolidayList_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AttendanceLeaveHolidayListID");

                Database.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, mDAttendanceLeaveHolidayListEntity.AttendanceLeaveAndHolidayCategoryID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, mDAttendanceLeaveHolidayListEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDAttendanceLeaveHolidayListEntity.Description);	
                Database.AddInParameter(cmd, "@Code", DbType.String, mDAttendanceLeaveHolidayListEntity.Code);	
                Database.AddInParameter(cmd, "@Color", DbType.String, mDAttendanceLeaveHolidayListEntity.Color);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDAttendanceLeaveHolidayListEntity already exists. Please specify another MDAttendanceLeaveHolidayListEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDAttendanceLeaveHolidayListEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDAttendanceLeaveHolidayListEntity already exists. Please specify another MDAttendanceLeaveHolidayListEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAttendanceLeaveHolidayList_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AttendanceLeaveHolidayListID", db);

                db.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, mDAttendanceLeaveHolidayListEntity.AttendanceLeaveAndHolidayCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDAttendanceLeaveHolidayListEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDAttendanceLeaveHolidayListEntity.Description);
                db.AddInParameter(cmd, "@Code", DbType.String, mDAttendanceLeaveHolidayListEntity.Code);
                db.AddInParameter(cmd, "@Color", DbType.String, mDAttendanceLeaveHolidayListEntity.Color);

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

        IList<Int64> IMDAttendanceLeaveHolidayListDataAccess.Add(IList<MDAttendanceLeaveHolidayListEntity> mDAttendanceLeaveHolidayListEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity in mDAttendanceLeaveHolidayListEntityList)
            {
                returnCode = (this as IMDAttendanceLeaveHolidayListDataAccess).Add(mDAttendanceLeaveHolidayListEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDAttendanceLeaveHolidayListDataAccess.Update(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDAttendanceLeaveHolidayListEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDAttendanceLeaveHolidayListEntity, filterExpression, option);
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

        private Int64 Update(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAttendanceLeaveHolidayList_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AttendanceLeaveHolidayListID", DbType.Int64, mDAttendanceLeaveHolidayListEntity.AttendanceLeaveHolidayListID);
                Database.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, mDAttendanceLeaveHolidayListEntity.AttendanceLeaveAndHolidayCategoryID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDAttendanceLeaveHolidayListEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDAttendanceLeaveHolidayListEntity.Description);
                Database.AddInParameter(cmd, "@Code", DbType.String, mDAttendanceLeaveHolidayListEntity.Code);
                Database.AddInParameter(cmd, "@Color", DbType.String, mDAttendanceLeaveHolidayListEntity.Color);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDAttendanceLeaveHolidayListEntity already exists. Please specify another MDAttendanceLeaveHolidayListEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDAttendanceLeaveHolidayListEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDAttendanceLeaveHolidayListEntity already exists. Please specify another MDAttendanceLeaveHolidayListEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAttendanceLeaveHolidayList_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AttendanceLeaveHolidayListID", DbType.Int64, mDAttendanceLeaveHolidayListEntity.AttendanceLeaveHolidayListID);
                db.AddInParameter(cmd, "@AttendanceLeaveAndHolidayCategoryID", DbType.Int64, mDAttendanceLeaveHolidayListEntity.AttendanceLeaveAndHolidayCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDAttendanceLeaveHolidayListEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDAttendanceLeaveHolidayListEntity.Description);
                db.AddInParameter(cmd, "@Code", DbType.String, mDAttendanceLeaveHolidayListEntity.Code);
                db.AddInParameter(cmd, "@Color", DbType.String, mDAttendanceLeaveHolidayListEntity.Color);

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

        IList<Int64> IMDAttendanceLeaveHolidayListDataAccess.Update(IList<MDAttendanceLeaveHolidayListEntity> mDAttendanceLeaveHolidayListEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity in mDAttendanceLeaveHolidayListEntityList)
            {
                returnCode = (this as IMDAttendanceLeaveHolidayListDataAccess).Update(mDAttendanceLeaveHolidayListEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDAttendanceLeaveHolidayListDataAccess.Delete(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDAttendanceLeaveHolidayListEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDAttendanceLeaveHolidayListEntity, filterExpression, option);
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

        private Int64 Delete(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAttendanceLeaveHolidayList_SET";

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
                                throw new ArgumentException("MDAttendanceLeaveHolidayListEntity already exists. Please specify another MDAttendanceLeaveHolidayListEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDAttendanceLeaveHolidayListEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDAttendanceLeaveHolidayListEntity already exists. Please specify another MDAttendanceLeaveHolidayListEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDAttendanceLeaveHolidayList_SET";

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

        IList<Int64> IMDAttendanceLeaveHolidayListDataAccess.Delete(IList<MDAttendanceLeaveHolidayListEntity> mDAttendanceLeaveHolidayListEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDAttendanceLeaveHolidayListEntity mDAttendanceLeaveHolidayListEntity in mDAttendanceLeaveHolidayListEntityList)
            {
                returnCode = (this as IMDAttendanceLeaveHolidayListDataAccess).Delete(mDAttendanceLeaveHolidayListEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDAttendanceLeaveHolidayListEntity> IMDAttendanceLeaveHolidayListDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDAttendanceLeaveHolidayList_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDAttendanceLeaveHolidayListEntity> list = CreateEntityBuilder<MDAttendanceLeaveHolidayListEntity>().BuildEntities(reader);

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

        DataTable IMDAttendanceLeaveHolidayListDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDAttendanceLeaveHolidayList_GET";

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
