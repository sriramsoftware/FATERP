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
    internal sealed partial class CMContractorContactPersonDataAccess : BaseDataAccess, ICMContractorContactPersonDataAccess
    {
        #region Constructors

        public CMContractorContactPersonDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMContractorContactPersonEntity> CreateEntityBuilder<CMContractorContactPersonEntity>()
        {
            return (new CMContractorContactPersonBuilder()) as IEntityBuilder<CMContractorContactPersonEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMContractorContactPersonDataAccess.Add(CMContractorContactPersonEntity cMContractorContactPersonEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMContractorContactPersonEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMContractorContactPersonEntity, option);
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

        private Int64 Add(CMContractorContactPersonEntity cMContractorContactPersonEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorContactPerson_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ContractorContactPersonID");

                Database.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMContractorContactPersonEntity.ContractorID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, cMContractorContactPersonEntity.Name);	
                Database.AddInParameter(cmd, "@Designation", DbType.String, cMContractorContactPersonEntity.Designation);	
                Database.AddInParameter(cmd, "@Phone", DbType.String, cMContractorContactPersonEntity.Phone);	
                Database.AddInParameter(cmd, "@Email", DbType.String, cMContractorContactPersonEntity.Email);	
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, cMContractorContactPersonEntity.AddressLine1);	
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, cMContractorContactPersonEntity.AddressLine2);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMContractorContactPersonEntity already exists. Please specify another CMContractorContactPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMContractorContactPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMContractorContactPersonEntity already exists. Please specify another CMContractorContactPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMContractorContactPersonEntity cMContractorContactPersonEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorContactPerson_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ContractorContactPersonID", db);

                db.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMContractorContactPersonEntity.ContractorID);
                db.AddInParameter(cmd, "@Name", DbType.String, cMContractorContactPersonEntity.Name);
                db.AddInParameter(cmd, "@Designation", DbType.String, cMContractorContactPersonEntity.Designation);
                db.AddInParameter(cmd, "@Phone", DbType.String, cMContractorContactPersonEntity.Phone);
                db.AddInParameter(cmd, "@Email", DbType.String, cMContractorContactPersonEntity.Email);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, cMContractorContactPersonEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, cMContractorContactPersonEntity.AddressLine2);

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

        IList<Int64> ICMContractorContactPersonDataAccess.Add(IList<CMContractorContactPersonEntity> cMContractorContactPersonEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMContractorContactPersonEntity cMContractorContactPersonEntity in cMContractorContactPersonEntityList)
            {
                returnCode = (this as ICMContractorContactPersonDataAccess).Add(cMContractorContactPersonEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMContractorContactPersonDataAccess.Update(CMContractorContactPersonEntity cMContractorContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMContractorContactPersonEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMContractorContactPersonEntity, filterExpression, option);
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

        private Int64 Update(CMContractorContactPersonEntity cMContractorContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorContactPerson_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ContractorContactPersonID", DbType.Int64, cMContractorContactPersonEntity.ContractorContactPersonID);
                Database.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMContractorContactPersonEntity.ContractorID);
                Database.AddInParameter(cmd, "@Name", DbType.String, cMContractorContactPersonEntity.Name);
                Database.AddInParameter(cmd, "@Designation", DbType.String, cMContractorContactPersonEntity.Designation);
                Database.AddInParameter(cmd, "@Phone", DbType.String, cMContractorContactPersonEntity.Phone);
                Database.AddInParameter(cmd, "@Email", DbType.String, cMContractorContactPersonEntity.Email);
                Database.AddInParameter(cmd, "@AddressLine1", DbType.String, cMContractorContactPersonEntity.AddressLine1);
                Database.AddInParameter(cmd, "@AddressLine2", DbType.String, cMContractorContactPersonEntity.AddressLine2);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMContractorContactPersonEntity already exists. Please specify another CMContractorContactPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMContractorContactPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMContractorContactPersonEntity already exists. Please specify another CMContractorContactPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMContractorContactPersonEntity cMContractorContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorContactPerson_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ContractorContactPersonID", DbType.Int64, cMContractorContactPersonEntity.ContractorContactPersonID);
                db.AddInParameter(cmd, "@ContractorID", DbType.Int64, cMContractorContactPersonEntity.ContractorID);
                db.AddInParameter(cmd, "@Name", DbType.String, cMContractorContactPersonEntity.Name);
                db.AddInParameter(cmd, "@Designation", DbType.String, cMContractorContactPersonEntity.Designation);
                db.AddInParameter(cmd, "@Phone", DbType.String, cMContractorContactPersonEntity.Phone);
                db.AddInParameter(cmd, "@Email", DbType.String, cMContractorContactPersonEntity.Email);
                db.AddInParameter(cmd, "@AddressLine1", DbType.String, cMContractorContactPersonEntity.AddressLine1);
                db.AddInParameter(cmd, "@AddressLine2", DbType.String, cMContractorContactPersonEntity.AddressLine2);

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

        IList<Int64> ICMContractorContactPersonDataAccess.Update(IList<CMContractorContactPersonEntity> cMContractorContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMContractorContactPersonEntity cMContractorContactPersonEntity in cMContractorContactPersonEntityList)
            {
                returnCode = (this as ICMContractorContactPersonDataAccess).Update(cMContractorContactPersonEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMContractorContactPersonDataAccess.Delete(CMContractorContactPersonEntity cMContractorContactPersonEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMContractorContactPersonEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMContractorContactPersonEntity, filterExpression, option);
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

        private Int64 Delete(CMContractorContactPersonEntity cMContractorContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorContactPerson_SET";

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
                                throw new ArgumentException("CMContractorContactPersonEntity already exists. Please specify another CMContractorContactPersonEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMContractorContactPersonEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMContractorContactPersonEntity already exists. Please specify another CMContractorContactPersonEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMContractorContactPersonEntity cMContractorContactPersonEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMContractorContactPerson_SET";

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

        IList<Int64> ICMContractorContactPersonDataAccess.Delete(IList<CMContractorContactPersonEntity> cMContractorContactPersonEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMContractorContactPersonEntity cMContractorContactPersonEntity in cMContractorContactPersonEntityList)
            {
                returnCode = (this as ICMContractorContactPersonDataAccess).Delete(cMContractorContactPersonEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMContractorContactPersonEntity> ICMContractorContactPersonDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMContractorContactPerson_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMContractorContactPersonEntity> list = CreateEntityBuilder<CMContractorContactPersonEntity>().BuildEntities(reader);

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

        DataTable ICMContractorContactPersonDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMContractorContactPerson_GET";

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
