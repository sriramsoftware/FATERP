// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 28-Dec-2011, 07:18:54




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
    internal sealed partial class OTScheduleDataAccess : BaseDataAccess, IOTScheduleDataAccess
    {
        #region Constructors

        public OTScheduleDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<OTScheduleEntity> CreateEntityBuilder<OTScheduleEntity>()
        {
            return (new OTScheduleBuilder()) as IEntityBuilder<OTScheduleEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IOTScheduleDataAccess.Add(OTScheduleEntity oTScheduleEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(oTScheduleEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(oTScheduleEntity, option);
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

        private Int64 Add(OTScheduleEntity oTScheduleEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTSchedule_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ScheduleID");

                Database.AddInParameter(cmd, "@ScheduleIdentityCategoryID", DbType.Int64, oTScheduleEntity.ScheduleIdentityCategoryID);	
                Database.AddInParameter(cmd, "@ScheduleCategoryID", DbType.Int64, oTScheduleEntity.ScheduleCategoryID);	
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, oTScheduleEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@Title", DbType.String, oTScheduleEntity.Title);	
                Database.AddInParameter(cmd, "@Description", DbType.String, oTScheduleEntity.Description);	
                Database.AddInParameter(cmd, "@SchedulePriorityID", DbType.Int64, oTScheduleEntity.SchedulePriorityID);	
                Database.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, oTScheduleEntity.CreatedByMemberID);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, oTScheduleEntity.CreateDate);	
                Database.AddInParameter(cmd, "@Duration", DbType.Decimal, oTScheduleEntity.Duration);	
                Database.AddInParameter(cmd, "@StartDateTime", DbType.DateTime, oTScheduleEntity.StartDateTime);	
                Database.AddInParameter(cmd, "@EndDateTime", DbType.DateTime, oTScheduleEntity.EndDateTime);	
                Database.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, oTScheduleEntity.NotifyBeforeMin);	
                Database.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, oTScheduleEntity.IsNotifyCompleted);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, oTScheduleEntity.Remarks);	
                Database.AddInParameter(cmd, "@ReferenceScheduleID", DbType.Int64, oTScheduleEntity.ReferenceScheduleID);	
                Database.AddInParameter(cmd, "@IsRescheduled", DbType.Boolean, oTScheduleEntity.IsRescheduled);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, oTScheduleEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("OTScheduleEntity already exists. Please specify another OTScheduleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTScheduleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTScheduleEntity already exists. Please specify another OTScheduleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(OTScheduleEntity oTScheduleEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTSchedule_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ScheduleID", db);

                db.AddInParameter(cmd, "@ScheduleIdentityCategoryID", DbType.Int64, oTScheduleEntity.ScheduleIdentityCategoryID);
                db.AddInParameter(cmd, "@ScheduleCategoryID", DbType.Int64, oTScheduleEntity.ScheduleCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, oTScheduleEntity.ReferenceID);
                db.AddInParameter(cmd, "@Title", DbType.String, oTScheduleEntity.Title);
                db.AddInParameter(cmd, "@Description", DbType.String, oTScheduleEntity.Description);
                db.AddInParameter(cmd, "@SchedulePriorityID", DbType.Int64, oTScheduleEntity.SchedulePriorityID);
                db.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, oTScheduleEntity.CreatedByMemberID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, oTScheduleEntity.CreateDate);
                db.AddInParameter(cmd, "@Duration", DbType.Decimal, oTScheduleEntity.Duration);
                db.AddInParameter(cmd, "@StartDateTime", DbType.DateTime, oTScheduleEntity.StartDateTime);
                db.AddInParameter(cmd, "@EndDateTime", DbType.DateTime, oTScheduleEntity.EndDateTime);
                db.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, oTScheduleEntity.NotifyBeforeMin);
                db.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, oTScheduleEntity.IsNotifyCompleted);
                db.AddInParameter(cmd, "@Remarks", DbType.String, oTScheduleEntity.Remarks);
                db.AddInParameter(cmd, "@ReferenceScheduleID", DbType.Int64, oTScheduleEntity.ReferenceScheduleID);
                db.AddInParameter(cmd, "@IsRescheduled", DbType.Boolean, oTScheduleEntity.IsRescheduled);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, oTScheduleEntity.IsRemoved);

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

        IList<Int64> IOTScheduleDataAccess.Add(IList<OTScheduleEntity> oTScheduleEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (OTScheduleEntity oTScheduleEntity in oTScheduleEntityList)
            {
                returnCode = (this as IOTScheduleDataAccess).Add(oTScheduleEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IOTScheduleDataAccess.Update(OTScheduleEntity oTScheduleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(oTScheduleEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(oTScheduleEntity, filterExpression, option);
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

        private Int64 Update(OTScheduleEntity oTScheduleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTSchedule_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ScheduleID", DbType.Int64, oTScheduleEntity.ScheduleID);
                Database.AddInParameter(cmd, "@ScheduleIdentityCategoryID", DbType.Int64, oTScheduleEntity.ScheduleIdentityCategoryID);
                Database.AddInParameter(cmd, "@ScheduleCategoryID", DbType.Int64, oTScheduleEntity.ScheduleCategoryID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, oTScheduleEntity.ReferenceID);
                Database.AddInParameter(cmd, "@Title", DbType.String, oTScheduleEntity.Title);
                Database.AddInParameter(cmd, "@Description", DbType.String, oTScheduleEntity.Description);
                Database.AddInParameter(cmd, "@SchedulePriorityID", DbType.Int64, oTScheduleEntity.SchedulePriorityID);
                Database.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, oTScheduleEntity.CreatedByMemberID);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, oTScheduleEntity.CreateDate);
                Database.AddInParameter(cmd, "@Duration", DbType.Decimal, oTScheduleEntity.Duration);
                Database.AddInParameter(cmd, "@StartDateTime", DbType.DateTime, oTScheduleEntity.StartDateTime);
                Database.AddInParameter(cmd, "@EndDateTime", DbType.DateTime, oTScheduleEntity.EndDateTime);
                Database.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, oTScheduleEntity.NotifyBeforeMin);
                Database.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, oTScheduleEntity.IsNotifyCompleted);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, oTScheduleEntity.Remarks);
                Database.AddInParameter(cmd, "@ReferenceScheduleID", DbType.Int64, oTScheduleEntity.ReferenceScheduleID);
                Database.AddInParameter(cmd, "@IsRescheduled", DbType.Boolean, oTScheduleEntity.IsRescheduled);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, oTScheduleEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("OTScheduleEntity already exists. Please specify another OTScheduleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTScheduleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTScheduleEntity already exists. Please specify another OTScheduleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(OTScheduleEntity oTScheduleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTSchedule_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ScheduleID", DbType.Int64, oTScheduleEntity.ScheduleID);
                db.AddInParameter(cmd, "@ScheduleIdentityCategoryID", DbType.Int64, oTScheduleEntity.ScheduleIdentityCategoryID);
                db.AddInParameter(cmd, "@ScheduleCategoryID", DbType.Int64, oTScheduleEntity.ScheduleCategoryID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, oTScheduleEntity.ReferenceID);
                db.AddInParameter(cmd, "@Title", DbType.String, oTScheduleEntity.Title);
                db.AddInParameter(cmd, "@Description", DbType.String, oTScheduleEntity.Description);
                db.AddInParameter(cmd, "@SchedulePriorityID", DbType.Int64, oTScheduleEntity.SchedulePriorityID);
                db.AddInParameter(cmd, "@CreatedByMemberID", DbType.Int64, oTScheduleEntity.CreatedByMemberID);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, oTScheduleEntity.CreateDate);
                db.AddInParameter(cmd, "@Duration", DbType.Decimal, oTScheduleEntity.Duration);
                db.AddInParameter(cmd, "@StartDateTime", DbType.DateTime, oTScheduleEntity.StartDateTime);
                db.AddInParameter(cmd, "@EndDateTime", DbType.DateTime, oTScheduleEntity.EndDateTime);
                db.AddInParameter(cmd, "@NotifyBeforeMin", DbType.Int32, oTScheduleEntity.NotifyBeforeMin);
                db.AddInParameter(cmd, "@IsNotifyCompleted", DbType.Boolean, oTScheduleEntity.IsNotifyCompleted);
                db.AddInParameter(cmd, "@Remarks", DbType.String, oTScheduleEntity.Remarks);
                db.AddInParameter(cmd, "@ReferenceScheduleID", DbType.Int64, oTScheduleEntity.ReferenceScheduleID);
                db.AddInParameter(cmd, "@IsRescheduled", DbType.Boolean, oTScheduleEntity.IsRescheduled);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, oTScheduleEntity.IsRemoved);

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

        IList<Int64> IOTScheduleDataAccess.Update(IList<OTScheduleEntity> oTScheduleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (OTScheduleEntity oTScheduleEntity in oTScheduleEntityList)
            {
                returnCode = (this as IOTScheduleDataAccess).Update(oTScheduleEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IOTScheduleDataAccess.Delete(OTScheduleEntity oTScheduleEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(oTScheduleEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(oTScheduleEntity, filterExpression, option);
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

        private Int64 Delete(OTScheduleEntity oTScheduleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTSchedule_SET";

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
                                throw new ArgumentException("OTScheduleEntity already exists. Please specify another OTScheduleEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("OTScheduleEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("OTScheduleEntity already exists. Please specify another OTScheduleEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(OTScheduleEntity oTScheduleEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.OTSchedule_SET";

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

        IList<Int64> IOTScheduleDataAccess.Delete(IList<OTScheduleEntity> oTScheduleEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (OTScheduleEntity oTScheduleEntity in oTScheduleEntityList)
            {
                returnCode = (this as IOTScheduleDataAccess).Delete(oTScheduleEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<OTScheduleEntity> IOTScheduleDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.OTSchedule_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<OTScheduleEntity> list = CreateEntityBuilder<OTScheduleEntity>().BuildEntities(reader);

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

        DataTable IOTScheduleDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.OTSchedule_GET";

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
