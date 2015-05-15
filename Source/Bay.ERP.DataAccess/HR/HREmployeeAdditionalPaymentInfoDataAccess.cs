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
    internal sealed partial class HREmployeeAdditionalPaymentInfoDataAccess : BaseDataAccess, IHREmployeeAdditionalPaymentInfoDataAccess
    {
        #region Constructors

        public HREmployeeAdditionalPaymentInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeAdditionalPaymentInfoEntity> CreateEntityBuilder<HREmployeeAdditionalPaymentInfoEntity>()
        {
            return (new HREmployeeAdditionalPaymentInfoBuilder()) as IEntityBuilder<HREmployeeAdditionalPaymentInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeAdditionalPaymentInfoDataAccess.Add(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeAdditionalPaymentInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeAdditionalPaymentInfoEntity, option);
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

        private Int64 Add(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAdditionalPaymentInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeAdditonalPaymentInfoID");

                Database.AddInParameter(cmd, "@PayDate", DbType.DateTime, hREmployeeAdditionalPaymentInfoEntity.PayDate);	
                Database.AddInParameter(cmd, "@PayAmount", DbType.Decimal, hREmployeeAdditionalPaymentInfoEntity.PayAmount);	
                Database.AddInParameter(cmd, "@PayCurrency", DbType.Decimal, hREmployeeAdditionalPaymentInfoEntity.PayCurrency);	
                Database.AddInParameter(cmd, "@Notes", DbType.String, hREmployeeAdditionalPaymentInfoEntity.Notes);	
                Database.AddInParameter(cmd, "@PayNow", DbType.Boolean, hREmployeeAdditionalPaymentInfoEntity.PayNow);	
                Database.AddInParameter(cmd, "@PayDuringPayrollGenerationEditorID", DbType.Int64, hREmployeeAdditionalPaymentInfoEntity.PayDuringPayrollGenerationEditorID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeAdditionalPaymentInfoEntity already exists. Please specify another HREmployeeAdditionalPaymentInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeAdditionalPaymentInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeAdditionalPaymentInfoEntity already exists. Please specify another HREmployeeAdditionalPaymentInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAdditionalPaymentInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeAdditonalPaymentInfoID", db);

                db.AddInParameter(cmd, "@PayDate", DbType.DateTime, hREmployeeAdditionalPaymentInfoEntity.PayDate);
                db.AddInParameter(cmd, "@PayAmount", DbType.Decimal, hREmployeeAdditionalPaymentInfoEntity.PayAmount);
                db.AddInParameter(cmd, "@PayCurrency", DbType.Decimal, hREmployeeAdditionalPaymentInfoEntity.PayCurrency);
                db.AddInParameter(cmd, "@Notes", DbType.String, hREmployeeAdditionalPaymentInfoEntity.Notes);
                db.AddInParameter(cmd, "@PayNow", DbType.Boolean, hREmployeeAdditionalPaymentInfoEntity.PayNow);
                db.AddInParameter(cmd, "@PayDuringPayrollGenerationEditorID", DbType.Int64, hREmployeeAdditionalPaymentInfoEntity.PayDuringPayrollGenerationEditorID);

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

        IList<Int64> IHREmployeeAdditionalPaymentInfoDataAccess.Add(IList<HREmployeeAdditionalPaymentInfoEntity> hREmployeeAdditionalPaymentInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity in hREmployeeAdditionalPaymentInfoEntityList)
            {
                returnCode = (this as IHREmployeeAdditionalPaymentInfoDataAccess).Add(hREmployeeAdditionalPaymentInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeAdditionalPaymentInfoDataAccess.Update(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeAdditionalPaymentInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeAdditionalPaymentInfoEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAdditionalPaymentInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeAdditonalPaymentInfoID", DbType.Int64, hREmployeeAdditionalPaymentInfoEntity.EmployeeAdditonalPaymentInfoID);
                Database.AddInParameter(cmd, "@PayDate", DbType.DateTime, hREmployeeAdditionalPaymentInfoEntity.PayDate);
                Database.AddInParameter(cmd, "@PayAmount", DbType.Decimal, hREmployeeAdditionalPaymentInfoEntity.PayAmount);
                Database.AddInParameter(cmd, "@PayCurrency", DbType.Decimal, hREmployeeAdditionalPaymentInfoEntity.PayCurrency);
                Database.AddInParameter(cmd, "@Notes", DbType.String, hREmployeeAdditionalPaymentInfoEntity.Notes);
                Database.AddInParameter(cmd, "@PayNow", DbType.Boolean, hREmployeeAdditionalPaymentInfoEntity.PayNow);
                Database.AddInParameter(cmd, "@PayDuringPayrollGenerationEditorID", DbType.Int64, hREmployeeAdditionalPaymentInfoEntity.PayDuringPayrollGenerationEditorID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeAdditionalPaymentInfoEntity already exists. Please specify another HREmployeeAdditionalPaymentInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeAdditionalPaymentInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeAdditionalPaymentInfoEntity already exists. Please specify another HREmployeeAdditionalPaymentInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAdditionalPaymentInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeAdditonalPaymentInfoID", DbType.Int64, hREmployeeAdditionalPaymentInfoEntity.EmployeeAdditonalPaymentInfoID);
                db.AddInParameter(cmd, "@PayDate", DbType.DateTime, hREmployeeAdditionalPaymentInfoEntity.PayDate);
                db.AddInParameter(cmd, "@PayAmount", DbType.Decimal, hREmployeeAdditionalPaymentInfoEntity.PayAmount);
                db.AddInParameter(cmd, "@PayCurrency", DbType.Decimal, hREmployeeAdditionalPaymentInfoEntity.PayCurrency);
                db.AddInParameter(cmd, "@Notes", DbType.String, hREmployeeAdditionalPaymentInfoEntity.Notes);
                db.AddInParameter(cmd, "@PayNow", DbType.Boolean, hREmployeeAdditionalPaymentInfoEntity.PayNow);
                db.AddInParameter(cmd, "@PayDuringPayrollGenerationEditorID", DbType.Int64, hREmployeeAdditionalPaymentInfoEntity.PayDuringPayrollGenerationEditorID);

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

        IList<Int64> IHREmployeeAdditionalPaymentInfoDataAccess.Update(IList<HREmployeeAdditionalPaymentInfoEntity> hREmployeeAdditionalPaymentInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity in hREmployeeAdditionalPaymentInfoEntityList)
            {
                returnCode = (this as IHREmployeeAdditionalPaymentInfoDataAccess).Update(hREmployeeAdditionalPaymentInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeAdditionalPaymentInfoDataAccess.Delete(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeAdditionalPaymentInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeAdditionalPaymentInfoEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAdditionalPaymentInfo_SET";

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
                                throw new ArgumentException("HREmployeeAdditionalPaymentInfoEntity already exists. Please specify another HREmployeeAdditionalPaymentInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeAdditionalPaymentInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeAdditionalPaymentInfoEntity already exists. Please specify another HREmployeeAdditionalPaymentInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeAdditionalPaymentInfo_SET";

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

        IList<Int64> IHREmployeeAdditionalPaymentInfoDataAccess.Delete(IList<HREmployeeAdditionalPaymentInfoEntity> hREmployeeAdditionalPaymentInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeAdditionalPaymentInfoEntity hREmployeeAdditionalPaymentInfoEntity in hREmployeeAdditionalPaymentInfoEntityList)
            {
                returnCode = (this as IHREmployeeAdditionalPaymentInfoDataAccess).Delete(hREmployeeAdditionalPaymentInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeAdditionalPaymentInfoEntity> IHREmployeeAdditionalPaymentInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeAdditionalPaymentInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeAdditionalPaymentInfoEntity> list = CreateEntityBuilder<HREmployeeAdditionalPaymentInfoEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeAdditionalPaymentInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeAdditionalPaymentInfo_GET";

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
