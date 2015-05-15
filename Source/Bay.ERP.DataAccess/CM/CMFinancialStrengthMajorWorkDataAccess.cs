// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




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
    internal sealed partial class CMFinancialStrengthMajorWorkDataAccess : BaseDataAccess, ICMFinancialStrengthMajorWorkDataAccess
    {
        #region Constructors

        public CMFinancialStrengthMajorWorkDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMFinancialStrengthMajorWorkEntity> CreateEntityBuilder<CMFinancialStrengthMajorWorkEntity>()
        {
            return (new CMFinancialStrengthMajorWorkBuilder()) as IEntityBuilder<CMFinancialStrengthMajorWorkEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMFinancialStrengthMajorWorkDataAccess.Add(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMFinancialStrengthMajorWorkEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMFinancialStrengthMajorWorkEntity, option);
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

        private Int64 Add(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMFinancialStrengthMajorWork_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "FinancialStrengthMajorWorkID");

                Database.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMFinancialStrengthMajorWorkEntity.ContractorID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, cMFinancialStrengthMajorWorkEntity.Name);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMFinancialStrengthMajorWorkEntity already exists. Please specify another CMFinancialStrengthMajorWorkEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMFinancialStrengthMajorWorkEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMFinancialStrengthMajorWorkEntity already exists. Please specify another CMFinancialStrengthMajorWorkEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMFinancialStrengthMajorWork_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "FinancialStrengthMajorWorkID", db);

                db.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMFinancialStrengthMajorWorkEntity.ContractorID);
                db.AddInParameter(cmd, "@Name", DbType.String, cMFinancialStrengthMajorWorkEntity.Name);

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

        IList<Int64> ICMFinancialStrengthMajorWorkDataAccess.Add(IList<CMFinancialStrengthMajorWorkEntity> cMFinancialStrengthMajorWorkEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity in cMFinancialStrengthMajorWorkEntityList)
            {
                returnCode = (this as ICMFinancialStrengthMajorWorkDataAccess).Add(cMFinancialStrengthMajorWorkEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMFinancialStrengthMajorWorkDataAccess.Update(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMFinancialStrengthMajorWorkEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMFinancialStrengthMajorWorkEntity, filterExpression, option);
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

        private Int64 Update(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMFinancialStrengthMajorWork_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@FinancialStrengthMajorWorkID", DbType.Int64, cMFinancialStrengthMajorWorkEntity.FinancialStrengthMajorWorkID);
                Database.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMFinancialStrengthMajorWorkEntity.ContractorID);
                Database.AddInParameter(cmd, "@Name", DbType.String, cMFinancialStrengthMajorWorkEntity.Name);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMFinancialStrengthMajorWorkEntity already exists. Please specify another CMFinancialStrengthMajorWorkEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMFinancialStrengthMajorWorkEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMFinancialStrengthMajorWorkEntity already exists. Please specify another CMFinancialStrengthMajorWorkEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMFinancialStrengthMajorWork_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@FinancialStrengthMajorWorkID", DbType.Int64, cMFinancialStrengthMajorWorkEntity.FinancialStrengthMajorWorkID);
                db.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMFinancialStrengthMajorWorkEntity.ContractorID);
                db.AddInParameter(cmd, "@Name", DbType.String, cMFinancialStrengthMajorWorkEntity.Name);

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

        IList<Int64> ICMFinancialStrengthMajorWorkDataAccess.Update(IList<CMFinancialStrengthMajorWorkEntity> cMFinancialStrengthMajorWorkEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity in cMFinancialStrengthMajorWorkEntityList)
            {
                returnCode = (this as ICMFinancialStrengthMajorWorkDataAccess).Update(cMFinancialStrengthMajorWorkEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMFinancialStrengthMajorWorkDataAccess.Delete(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMFinancialStrengthMajorWorkEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMFinancialStrengthMajorWorkEntity, filterExpression, option);
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

        private Int64 Delete(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMFinancialStrengthMajorWork_SET";

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
                                throw new ArgumentException("CMFinancialStrengthMajorWorkEntity already exists. Please specify another CMFinancialStrengthMajorWorkEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMFinancialStrengthMajorWorkEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMFinancialStrengthMajorWorkEntity already exists. Please specify another CMFinancialStrengthMajorWorkEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMFinancialStrengthMajorWork_SET";

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

        IList<Int64> ICMFinancialStrengthMajorWorkDataAccess.Delete(IList<CMFinancialStrengthMajorWorkEntity> cMFinancialStrengthMajorWorkEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity in cMFinancialStrengthMajorWorkEntityList)
            {
                returnCode = (this as ICMFinancialStrengthMajorWorkDataAccess).Delete(cMFinancialStrengthMajorWorkEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMFinancialStrengthMajorWorkEntity> ICMFinancialStrengthMajorWorkDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMFinancialStrengthMajorWork_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMFinancialStrengthMajorWorkEntity> list = CreateEntityBuilder<CMFinancialStrengthMajorWorkEntity>().BuildEntities(reader);

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

        DataTable ICMFinancialStrengthMajorWorkDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMFinancialStrengthMajorWork_GET";

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
