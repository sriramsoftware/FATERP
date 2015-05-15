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
    internal sealed partial class HREmployeeSalarySessionDeducationInfoDataAccess : BaseDataAccess, IHREmployeeSalarySessionDeducationInfoDataAccess
    {
        #region Constructors

        public HREmployeeSalarySessionDeducationInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<HREmployeeSalarySessionDeducationInfoEntity> CreateEntityBuilder<HREmployeeSalarySessionDeducationInfoEntity>()
        {
            return (new HREmployeeSalarySessionDeducationInfoBuilder()) as IEntityBuilder<HREmployeeSalarySessionDeducationInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IHREmployeeSalarySessionDeducationInfoDataAccess.Add(HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(hREmployeeSalarySessionDeducationInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(hREmployeeSalarySessionDeducationInfoEntity, option);
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

        private Int64 Add(HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalarySessionDeducationInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalarySessionDeducationInfoID");

                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalarySessionDeducationInfoEntity.SalarySessionID);	
                Database.AddInParameter(cmd, "@DeductionAmount", DbType.Decimal, hREmployeeSalarySessionDeducationInfoEntity.DeductionAmount);	
                Database.AddInParameter(cmd, "@Note", DbType.String, hREmployeeSalarySessionDeducationInfoEntity.Note);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalarySessionDeducationInfoEntity already exists. Please specify another HREmployeeSalarySessionDeducationInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalarySessionDeducationInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalarySessionDeducationInfoEntity already exists. Please specify another HREmployeeSalarySessionDeducationInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalarySessionDeducationInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "EmployeeSalarySessionDeducationInfoID", db);

                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalarySessionDeducationInfoEntity.SalarySessionID);
                db.AddInParameter(cmd, "@DeductionAmount", DbType.Decimal, hREmployeeSalarySessionDeducationInfoEntity.DeductionAmount);
                db.AddInParameter(cmd, "@Note", DbType.String, hREmployeeSalarySessionDeducationInfoEntity.Note);

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

        IList<Int64> IHREmployeeSalarySessionDeducationInfoDataAccess.Add(IList<HREmployeeSalarySessionDeducationInfoEntity> hREmployeeSalarySessionDeducationInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity in hREmployeeSalarySessionDeducationInfoEntityList)
            {
                returnCode = (this as IHREmployeeSalarySessionDeducationInfoDataAccess).Add(hREmployeeSalarySessionDeducationInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IHREmployeeSalarySessionDeducationInfoDataAccess.Update(HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(hREmployeeSalarySessionDeducationInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(hREmployeeSalarySessionDeducationInfoEntity, filterExpression, option);
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

        private Int64 Update(HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalarySessionDeducationInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@EmployeeSalarySessionDeducationInfoID", DbType.Int64, hREmployeeSalarySessionDeducationInfoEntity.EmployeeSalarySessionDeducationInfoID);
                Database.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalarySessionDeducationInfoEntity.SalarySessionID);
                Database.AddInParameter(cmd, "@DeductionAmount", DbType.Decimal, hREmployeeSalarySessionDeducationInfoEntity.DeductionAmount);
                Database.AddInParameter(cmd, "@Note", DbType.String, hREmployeeSalarySessionDeducationInfoEntity.Note);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("HREmployeeSalarySessionDeducationInfoEntity already exists. Please specify another HREmployeeSalarySessionDeducationInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalarySessionDeducationInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalarySessionDeducationInfoEntity already exists. Please specify another HREmployeeSalarySessionDeducationInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalarySessionDeducationInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@EmployeeSalarySessionDeducationInfoID", DbType.Int64, hREmployeeSalarySessionDeducationInfoEntity.EmployeeSalarySessionDeducationInfoID);
                db.AddInParameter(cmd, "@SalarySessionID", DbType.Int64, hREmployeeSalarySessionDeducationInfoEntity.SalarySessionID);
                db.AddInParameter(cmd, "@DeductionAmount", DbType.Decimal, hREmployeeSalarySessionDeducationInfoEntity.DeductionAmount);
                db.AddInParameter(cmd, "@Note", DbType.String, hREmployeeSalarySessionDeducationInfoEntity.Note);

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

        IList<Int64> IHREmployeeSalarySessionDeducationInfoDataAccess.Update(IList<HREmployeeSalarySessionDeducationInfoEntity> hREmployeeSalarySessionDeducationInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity in hREmployeeSalarySessionDeducationInfoEntityList)
            {
                returnCode = (this as IHREmployeeSalarySessionDeducationInfoDataAccess).Update(hREmployeeSalarySessionDeducationInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IHREmployeeSalarySessionDeducationInfoDataAccess.Delete(HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(hREmployeeSalarySessionDeducationInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(hREmployeeSalarySessionDeducationInfoEntity, filterExpression, option);
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

        private Int64 Delete(HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalarySessionDeducationInfo_SET";

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
                                throw new ArgumentException("HREmployeeSalarySessionDeducationInfoEntity already exists. Please specify another HREmployeeSalarySessionDeducationInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("HREmployeeSalarySessionDeducationInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("HREmployeeSalarySessionDeducationInfoEntity already exists. Please specify another HREmployeeSalarySessionDeducationInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.HREmployeeSalarySessionDeducationInfo_SET";

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

        IList<Int64> IHREmployeeSalarySessionDeducationInfoDataAccess.Delete(IList<HREmployeeSalarySessionDeducationInfoEntity> hREmployeeSalarySessionDeducationInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (HREmployeeSalarySessionDeducationInfoEntity hREmployeeSalarySessionDeducationInfoEntity in hREmployeeSalarySessionDeducationInfoEntityList)
            {
                returnCode = (this as IHREmployeeSalarySessionDeducationInfoDataAccess).Delete(hREmployeeSalarySessionDeducationInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<HREmployeeSalarySessionDeducationInfoEntity> IHREmployeeSalarySessionDeducationInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalarySessionDeducationInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<HREmployeeSalarySessionDeducationInfoEntity> list = CreateEntityBuilder<HREmployeeSalarySessionDeducationInfoEntity>().BuildEntities(reader);

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

        DataTable IHREmployeeSalarySessionDeducationInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.HREmployeeSalarySessionDeducationInfo_GET";

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
