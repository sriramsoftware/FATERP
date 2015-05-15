// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Jan-2012, 11:52:45




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
    internal sealed partial class CMContractorDataAccess : BaseDataAccess, ICMContractorDataAccess
    {
        #region Constructors

        public CMContractorDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMContractorEntity> CreateEntityBuilder<CMContractorEntity>()
        {
            return (new CMContractorBuilder()) as IEntityBuilder<CMContractorEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMContractorDataAccess.Add(CMContractorEntity cMContractorEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMContractorEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMContractorEntity, option);
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

        private Int64 Add(CMContractorEntity cMContractorEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractor_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ContractorID");

                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, cMContractorEntity.MemberID);	
                Database.AddInParameter(cmd, "@NameOfWork", DbType.String, cMContractorEntity.NameOfWork);	
                Database.AddInParameter(cmd, "@Date", DbType.DateTime, cMContractorEntity.Date);	
                Database.AddInParameter(cmd, "@Name", DbType.String, cMContractorEntity.Name);	
                Database.AddInParameter(cmd, "@PreparedBy", DbType.Int64, cMContractorEntity.PreparedBy);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMContractorEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMContractorEntity already exists. Please specify another CMContractorEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMContractorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMContractorEntity already exists. Please specify another CMContractorEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMContractorEntity cMContractorEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractor_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ContractorID", db);

                db.AddInParameter(cmd, "@MemberID", DbType.Int64, cMContractorEntity.MemberID);
                db.AddInParameter(cmd, "@NameOfWork", DbType.String, cMContractorEntity.NameOfWork);
                db.AddInParameter(cmd, "@Date", DbType.DateTime, cMContractorEntity.Date);
                db.AddInParameter(cmd, "@Name", DbType.String, cMContractorEntity.Name);
                db.AddInParameter(cmd, "@PreparedBy", DbType.Int64, cMContractorEntity.PreparedBy);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMContractorEntity.IsRemoved);

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

        IList<Int64> ICMContractorDataAccess.Add(IList<CMContractorEntity> cMContractorEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMContractorEntity cMContractorEntity in cMContractorEntityList)
            {
                returnCode = (this as ICMContractorDataAccess).Add(cMContractorEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMContractorDataAccess.Update(CMContractorEntity cMContractorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMContractorEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMContractorEntity, filterExpression, option);
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

        private Int64 Update(CMContractorEntity cMContractorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractor_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMContractorEntity.ContractorID);
                Database.AddInParameter(cmd, "@MemberID", DbType.Int64, cMContractorEntity.MemberID);
                Database.AddInParameter(cmd, "@NameOfWork", DbType.String, cMContractorEntity.NameOfWork);
                Database.AddInParameter(cmd, "@Date", DbType.DateTime, cMContractorEntity.Date);
                Database.AddInParameter(cmd, "@Name", DbType.String, cMContractorEntity.Name);
                Database.AddInParameter(cmd, "@PreparedBy", DbType.Int64, cMContractorEntity.PreparedBy);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMContractorEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMContractorEntity already exists. Please specify another CMContractorEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMContractorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMContractorEntity already exists. Please specify another CMContractorEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMContractorEntity cMContractorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractor_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMContractorEntity.ContractorID);
                db.AddInParameter(cmd, "@MemberID", DbType.Int64, cMContractorEntity.MemberID);
                db.AddInParameter(cmd, "@NameOfWork", DbType.String, cMContractorEntity.NameOfWork);
                db.AddInParameter(cmd, "@Date", DbType.DateTime, cMContractorEntity.Date);
                db.AddInParameter(cmd, "@Name", DbType.String, cMContractorEntity.Name);
                db.AddInParameter(cmd, "@PreparedBy", DbType.Int64, cMContractorEntity.PreparedBy);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cMContractorEntity.IsRemoved);

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

        IList<Int64> ICMContractorDataAccess.Update(IList<CMContractorEntity> cMContractorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMContractorEntity cMContractorEntity in cMContractorEntityList)
            {
                returnCode = (this as ICMContractorDataAccess).Update(cMContractorEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMContractorDataAccess.Delete(CMContractorEntity cMContractorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMContractorEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMContractorEntity, filterExpression, option);
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

        private Int64 Delete(CMContractorEntity cMContractorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractor_SET";

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
                                throw new ArgumentException("CMContractorEntity already exists. Please specify another CMContractorEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMContractorEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMContractorEntity already exists. Please specify another CMContractorEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMContractorEntity cMContractorEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractor_SET";

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

        IList<Int64> ICMContractorDataAccess.Delete(IList<CMContractorEntity> cMContractorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMContractorEntity cMContractorEntity in cMContractorEntityList)
            {
                returnCode = (this as ICMContractorDataAccess).Delete(cMContractorEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMContractorEntity> ICMContractorDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMContractor_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMContractorEntity> list = CreateEntityBuilder<CMContractorEntity>().BuildEntities(reader);

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

        DataTable ICMContractorDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMContractor_GET";

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
