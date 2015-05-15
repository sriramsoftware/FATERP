// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 11-Apr-2013, 01:28:07




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
    internal sealed partial class CRMMDAgreementSpecsTypeDataAccess : BaseDataAccess, ICRMMDAgreementSpecsTypeDataAccess
    {
        #region Constructors

        public CRMMDAgreementSpecsTypeDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMMDAgreementSpecsTypeEntity> CreateEntityBuilder<CRMMDAgreementSpecsTypeEntity>()
        {
            return (new CRMMDAgreementSpecsTypeBuilder()) as IEntityBuilder<CRMMDAgreementSpecsTypeEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMMDAgreementSpecsTypeDataAccess.Add(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMMDAgreementSpecsTypeEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMMDAgreementSpecsTypeEntity, option);
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

        private Int64 Add(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAgreementSpecsType_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AgreementSpecsTypeID");

                Database.AddInParameter(cmd, "@Name", DbType.String, cRMMDAgreementSpecsTypeEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, cRMMDAgreementSpecsTypeEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cRMMDAgreementSpecsTypeEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMMDAgreementSpecsTypeEntity already exists. Please specify another CRMMDAgreementSpecsTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMMDAgreementSpecsTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMMDAgreementSpecsTypeEntity already exists. Please specify another CRMMDAgreementSpecsTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAgreementSpecsType_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AgreementSpecsTypeID", db);

                db.AddInParameter(cmd, "@Name", DbType.String, cRMMDAgreementSpecsTypeEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, cRMMDAgreementSpecsTypeEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cRMMDAgreementSpecsTypeEntity.IsRemoved);

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

        IList<Int64> ICRMMDAgreementSpecsTypeDataAccess.Add(IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity in cRMMDAgreementSpecsTypeEntityList)
            {
                returnCode = (this as ICRMMDAgreementSpecsTypeDataAccess).Add(cRMMDAgreementSpecsTypeEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMMDAgreementSpecsTypeDataAccess.Update(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMMDAgreementSpecsTypeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMMDAgreementSpecsTypeEntity, filterExpression, option);
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

        private Int64 Update(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAgreementSpecsType_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AgreementSpecsTypeID", DbType.Int64, cRMMDAgreementSpecsTypeEntity.AgreementSpecsTypeID);
                Database.AddInParameter(cmd, "@Name", DbType.String, cRMMDAgreementSpecsTypeEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, cRMMDAgreementSpecsTypeEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cRMMDAgreementSpecsTypeEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMMDAgreementSpecsTypeEntity already exists. Please specify another CRMMDAgreementSpecsTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMMDAgreementSpecsTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMMDAgreementSpecsTypeEntity already exists. Please specify another CRMMDAgreementSpecsTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAgreementSpecsType_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AgreementSpecsTypeID", DbType.Int64, cRMMDAgreementSpecsTypeEntity.AgreementSpecsTypeID);
                db.AddInParameter(cmd, "@Name", DbType.String, cRMMDAgreementSpecsTypeEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, cRMMDAgreementSpecsTypeEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, cRMMDAgreementSpecsTypeEntity.IsRemoved);

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

        IList<Int64> ICRMMDAgreementSpecsTypeDataAccess.Update(IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity in cRMMDAgreementSpecsTypeEntityList)
            {
                returnCode = (this as ICRMMDAgreementSpecsTypeDataAccess).Update(cRMMDAgreementSpecsTypeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMMDAgreementSpecsTypeDataAccess.Delete(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMMDAgreementSpecsTypeEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMMDAgreementSpecsTypeEntity, filterExpression, option);
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

        private Int64 Delete(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAgreementSpecsType_SET";

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
                                throw new ArgumentException("CRMMDAgreementSpecsTypeEntity already exists. Please specify another CRMMDAgreementSpecsTypeEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMMDAgreementSpecsTypeEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMMDAgreementSpecsTypeEntity already exists. Please specify another CRMMDAgreementSpecsTypeEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMMDAgreementSpecsType_SET";

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

        IList<Int64> ICRMMDAgreementSpecsTypeDataAccess.Delete(IList<CRMMDAgreementSpecsTypeEntity> cRMMDAgreementSpecsTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMMDAgreementSpecsTypeEntity cRMMDAgreementSpecsTypeEntity in cRMMDAgreementSpecsTypeEntityList)
            {
                returnCode = (this as ICRMMDAgreementSpecsTypeDataAccess).Delete(cRMMDAgreementSpecsTypeEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMMDAgreementSpecsTypeEntity> ICRMMDAgreementSpecsTypeDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMMDAgreementSpecsType_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMMDAgreementSpecsTypeEntity> list = CreateEntityBuilder<CRMMDAgreementSpecsTypeEntity>().BuildEntities(reader);

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

        DataTable ICRMMDAgreementSpecsTypeDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMMDAgreementSpecsType_GET";

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
