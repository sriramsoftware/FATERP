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
    internal sealed partial class HREmployeeNoticeDataAccess : BaseDataAccess, IHREmployeeNoticeDataAccess
    {
        #region Constructors

        public HREmployeeNoticeDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeNoticeEntity> CreateEntityBuilder<HREmployeeNoticeEntity>()
        {
            return (new HREmployeeNoticeBuilder()) as IEntityBuilder<HREmployeeNoticeEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeNoticeDataAccess.Add(HREmployeeNoticeEntity hREmployeeNoticeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeNoticeEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeNoticeEntity, option);
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

        private Int64 Add(HREmployeeNoticeEntity hREmployeeNoticeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeNotice_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeNoticeID");

                Database.AddInParameter(cmd, "@SendToEmployeeID", DbType.Int64, hREmployeeNoticeEntity.SendToEmployeeID);
                Database.AddInParameter(cmd, "@Memo", DbType.String, hREmployeeNoticeEntity.Memo);	
                Database.AddInParameter(cmd, "@Text", DbType.String, hREmployeeNoticeEntity.Text);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeNoticeEntity.Remarks);	
                Database.AddInParameter(cmd, "@NoticeDate", DbType.DateTime, hREmployeeNoticeEntity.NoticeDate);	
                Database.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, hREmployeeNoticeEntity.PreparedByEmployeeID);	
                Database.AddInParameter(cmd, "@PreparedByEmployeeSalaryLevel", DbType.Int32, hREmployeeNoticeEntity.PreparedByEmployeeSalaryLevel);
                Database.AddInParameter(cmd, "@TemplateID", DbType.Int64, hREmployeeNoticeEntity.TemplateID);
                Database.AddInParameter(cmd, "@SeenNotice", DbType.DateTime, hREmployeeNoticeEntity.SeenNotice);
                Database.AddInParameter(cmd, "@ViewCount", DbType.Int64, hREmployeeNoticeEntity.ViewCount);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeNoticeEntity already exists. Please specify another HREmployeeNoticeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeNoticeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeNoticeEntity already exists. Please specify another HREmployeeNoticeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeNoticeEntity hREmployeeNoticeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeNotice_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeNoticeID", db);

                db.AddInParameter(cmd, "@SendToEmployeeID", DbType.Int64, hREmployeeNoticeEntity.SendToEmployeeID);
                db.AddInParameter(cmd, "@Memo", DbType.String, hREmployeeNoticeEntity.Memo);
                db.AddInParameter(cmd, "@Text", DbType.String, hREmployeeNoticeEntity.Text);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeNoticeEntity.Remarks);
                db.AddInParameter(cmd, "@NoticeDate", DbType.DateTime, hREmployeeNoticeEntity.NoticeDate);
                db.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, hREmployeeNoticeEntity.PreparedByEmployeeID);
                db.AddInParameter(cmd, "@PreparedByEmployeeSalaryLevel", DbType.Int32, hREmployeeNoticeEntity.PreparedByEmployeeSalaryLevel);
                db.AddInParameter(cmd, "@TemplateID", DbType.Int64, hREmployeeNoticeEntity.TemplateID);
                db.AddInParameter(cmd, "@SeenNotice", DbType.DateTime, hREmployeeNoticeEntity.SeenNotice);
                db.AddInParameter(cmd, "@ViewCount", DbType.Int64, hREmployeeNoticeEntity.ViewCount);

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

        IList<Int64> IHREmployeeNoticeDataAccess.Add(IList<HREmployeeNoticeEntity> hREmployeeNoticeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeNoticeEntity hREmployeeNoticeEntity in hREmployeeNoticeEntityList)
            {
                returnCode = (this as IHREmployeeNoticeDataAccess).Add(hREmployeeNoticeEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeNoticeDataAccess.Update(HREmployeeNoticeEntity hREmployeeNoticeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeNoticeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeNoticeEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeNoticeEntity hREmployeeNoticeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeNotice_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeNoticeID", DbType.Int64, hREmployeeNoticeEntity.EmployeeNoticeID);
                Database.AddInParameter(cmd, "@SendToEmployeeID", DbType.Int64, hREmployeeNoticeEntity.SendToEmployeeID);
                Database.AddInParameter(cmd, "@Memo", DbType.String, hREmployeeNoticeEntity.Memo);
                Database.AddInParameter(cmd, "@Text", DbType.String, hREmployeeNoticeEntity.Text);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeNoticeEntity.Remarks);
                Database.AddInParameter(cmd, "@NoticeDate", DbType.DateTime, hREmployeeNoticeEntity.NoticeDate);
                Database.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, hREmployeeNoticeEntity.PreparedByEmployeeID);
                Database.AddInParameter(cmd, "@PreparedByEmployeeSalaryLevel", DbType.Int32, hREmployeeNoticeEntity.PreparedByEmployeeSalaryLevel);
                Database.AddInParameter(cmd, "@TemplateID", DbType.Int64, hREmployeeNoticeEntity.TemplateID);
                Database.AddInParameter(cmd, "@SeenNotice", DbType.DateTime, hREmployeeNoticeEntity.SeenNotice);
                Database.AddInParameter(cmd, "@ViewCount", DbType.Int64, hREmployeeNoticeEntity.ViewCount);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeNoticeEntity already exists. Please specify another HREmployeeNoticeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeNoticeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeNoticeEntity already exists. Please specify another HREmployeeNoticeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeNoticeEntity hREmployeeNoticeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeNotice_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeNoticeID", DbType.Int64, hREmployeeNoticeEntity.EmployeeNoticeID);
                db.AddInParameter(cmd, "@SendToEmployeeID", DbType.Int64, hREmployeeNoticeEntity.SendToEmployeeID);
                db.AddInParameter(cmd, "@Memo", DbType.String, hREmployeeNoticeEntity.Memo);
                db.AddInParameter(cmd, "@Text", DbType.String, hREmployeeNoticeEntity.Text);
                db.AddInParameter(cmd, "@Remarks", DbType.String, hREmployeeNoticeEntity.Remarks);
                db.AddInParameter(cmd, "@NoticeDate", DbType.DateTime, hREmployeeNoticeEntity.NoticeDate);
                db.AddInParameter(cmd, "@PreparedByEmployeeID", DbType.Int64, hREmployeeNoticeEntity.PreparedByEmployeeID);
                db.AddInParameter(cmd, "@PreparedByEmployeeSalaryLevel", DbType.Int32, hREmployeeNoticeEntity.PreparedByEmployeeSalaryLevel);
                db.AddInParameter(cmd, "@TemplateID", DbType.Int64, hREmployeeNoticeEntity.TemplateID);
                db.AddInParameter(cmd, "@SeenNotice", DbType.DateTime, hREmployeeNoticeEntity.SeenNotice);
                db.AddInParameter(cmd, "@ViewCount", DbType.Int64, hREmployeeNoticeEntity.ViewCount);

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

        IList<Int64> IHREmployeeNoticeDataAccess.Update(IList<HREmployeeNoticeEntity> hREmployeeNoticeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeNoticeEntity hREmployeeNoticeEntity in hREmployeeNoticeEntityList)
            {
                returnCode = (this as IHREmployeeNoticeDataAccess).Update(hREmployeeNoticeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeNoticeDataAccess.Delete(HREmployeeNoticeEntity hREmployeeNoticeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeNoticeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeNoticeEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeNoticeEntity hREmployeeNoticeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeNotice_SET";

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
                                throw new ArgumentException("HREmployeeNoticeEntity already exists. Please specify another HREmployeeNoticeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeNoticeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeNoticeEntity already exists. Please specify another HREmployeeNoticeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeNoticeEntity hREmployeeNoticeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeNotice_SET";

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

        IList<Int64> IHREmployeeNoticeDataAccess.Delete(IList<HREmployeeNoticeEntity> hREmployeeNoticeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeNoticeEntity hREmployeeNoticeEntity in hREmployeeNoticeEntityList)
            {
                returnCode = (this as IHREmployeeNoticeDataAccess).Delete(hREmployeeNoticeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeNoticeEntity> IHREmployeeNoticeDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeNotice_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeNoticeEntity> list = CreateEntityBuilder<HREmployeeNoticeEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeNoticeDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeNotice_GET";

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
