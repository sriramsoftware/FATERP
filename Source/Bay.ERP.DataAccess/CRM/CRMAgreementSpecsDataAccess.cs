// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 21-Apr-2013, 01:26:57




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
    internal sealed partial class CRMAgreementSpecsDataAccess : BaseDataAccess, ICRMAgreementSpecsDataAccess
    {
        #region Constructors

        public CRMAgreementSpecsDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMAgreementSpecsEntity> CreateEntityBuilder<CRMAgreementSpecsEntity>()
        {
            return (new CRMAgreementSpecsBuilder()) as IEntityBuilder<CRMAgreementSpecsEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMAgreementSpecsDataAccess.Add(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMAgreementSpecsEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMAgreementSpecsEntity, option);
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

        private Int64 Add(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementSpecs_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "AgreementSpecsID");

                Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMAgreementSpecsEntity.AgreementID);	
                Database.AddInParameter(cmd, "@Item", DbType.String, cRMAgreementSpecsEntity.Item);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, cRMAgreementSpecsEntity.BrandID);	
                Database.AddInParameter(cmd, "@BayQty", DbType.Decimal, cRMAgreementSpecsEntity.BayQty);	
                Database.AddInParameter(cmd, "@BayPrice", DbType.Decimal, cRMAgreementSpecsEntity.BayPrice);	
                Database.AddInParameter(cmd, "@CustomerQty", DbType.Decimal, cRMAgreementSpecsEntity.CustomerQty);	
                Database.AddInParameter(cmd, "@CustomerPrice", DbType.Decimal, cRMAgreementSpecsEntity.CustomerPrice);	
                Database.AddInParameter(cmd, "@Field1", DbType.String, cRMAgreementSpecsEntity.Field1);	
                Database.AddInParameter(cmd, "@Field2", DbType.String, cRMAgreementSpecsEntity.Field2);	
                Database.AddInParameter(cmd, "@var0", DbType.String, cRMAgreementSpecsEntity.var0);	
                Database.AddInParameter(cmd, "@var1", DbType.String, cRMAgreementSpecsEntity.var1);	
                Database.AddInParameter(cmd, "@var2", DbType.String, cRMAgreementSpecsEntity.var2);	
                Database.AddInParameter(cmd, "@var3", DbType.String, cRMAgreementSpecsEntity.var3);	
                Database.AddInParameter(cmd, "@var4", DbType.String, cRMAgreementSpecsEntity.var4);	
                Database.AddInParameter(cmd, "@var5", DbType.String, cRMAgreementSpecsEntity.var5);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementSpecsEntity.Remarks);	
                Database.AddInParameter(cmd, "@AgreementSpecsType", DbType.String, cRMAgreementSpecsEntity.AgreementSpecsType);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMAgreementSpecsEntity already exists. Please specify another CRMAgreementSpecsEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementSpecsEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementSpecsEntity already exists. Please specify another CRMAgreementSpecsEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementSpecs_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "AgreementSpecsID", db);

                db.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMAgreementSpecsEntity.AgreementID);
                db.AddInParameter(cmd, "@Item", DbType.String, cRMAgreementSpecsEntity.Item);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, cRMAgreementSpecsEntity.BrandID);
                db.AddInParameter(cmd, "@BayQty", DbType.Decimal, cRMAgreementSpecsEntity.BayQty);
                db.AddInParameter(cmd, "@BayPrice", DbType.Decimal, cRMAgreementSpecsEntity.BayPrice);
                db.AddInParameter(cmd, "@CustomerQty", DbType.Decimal, cRMAgreementSpecsEntity.CustomerQty);
                db.AddInParameter(cmd, "@CustomerPrice", DbType.Decimal, cRMAgreementSpecsEntity.CustomerPrice);
                db.AddInParameter(cmd, "@Field1", DbType.String, cRMAgreementSpecsEntity.Field1);
                db.AddInParameter(cmd, "@Field2", DbType.String, cRMAgreementSpecsEntity.Field2);
                db.AddInParameter(cmd, "@var0", DbType.String, cRMAgreementSpecsEntity.var0);
                db.AddInParameter(cmd, "@var1", DbType.String, cRMAgreementSpecsEntity.var1);
                db.AddInParameter(cmd, "@var2", DbType.String, cRMAgreementSpecsEntity.var2);
                db.AddInParameter(cmd, "@var3", DbType.String, cRMAgreementSpecsEntity.var3);
                db.AddInParameter(cmd, "@var4", DbType.String, cRMAgreementSpecsEntity.var4);
                db.AddInParameter(cmd, "@var5", DbType.String, cRMAgreementSpecsEntity.var5);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementSpecsEntity.Remarks);
                db.AddInParameter(cmd, "@AgreementSpecsType", DbType.String, cRMAgreementSpecsEntity.AgreementSpecsType);

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

        IList<Int64> ICRMAgreementSpecsDataAccess.Add(IList<CRMAgreementSpecsEntity> cRMAgreementSpecsEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMAgreementSpecsEntity cRMAgreementSpecsEntity in cRMAgreementSpecsEntityList)
            {
                returnCode = (this as ICRMAgreementSpecsDataAccess).Add(cRMAgreementSpecsEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMAgreementSpecsDataAccess.Update(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMAgreementSpecsEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMAgreementSpecsEntity, filterExpression, option);
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

        private Int64 Update(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementSpecs_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@AgreementSpecsID", DbType.Int64, cRMAgreementSpecsEntity.AgreementSpecsID);
                Database.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMAgreementSpecsEntity.AgreementID);
                Database.AddInParameter(cmd, "@Item", DbType.String, cRMAgreementSpecsEntity.Item);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, cRMAgreementSpecsEntity.BrandID);
                Database.AddInParameter(cmd, "@BayQty", DbType.Decimal, cRMAgreementSpecsEntity.BayQty);
                Database.AddInParameter(cmd, "@BayPrice", DbType.Decimal, cRMAgreementSpecsEntity.BayPrice);
                Database.AddInParameter(cmd, "@CustomerQty", DbType.Decimal, cRMAgreementSpecsEntity.CustomerQty);
                Database.AddInParameter(cmd, "@CustomerPrice", DbType.Decimal, cRMAgreementSpecsEntity.CustomerPrice);
                Database.AddInParameter(cmd, "@Field1", DbType.String, cRMAgreementSpecsEntity.Field1);
                Database.AddInParameter(cmd, "@Field2", DbType.String, cRMAgreementSpecsEntity.Field2);
                Database.AddInParameter(cmd, "@var0", DbType.String, cRMAgreementSpecsEntity.var0);
                Database.AddInParameter(cmd, "@var1", DbType.String, cRMAgreementSpecsEntity.var1);
                Database.AddInParameter(cmd, "@var2", DbType.String, cRMAgreementSpecsEntity.var2);
                Database.AddInParameter(cmd, "@var3", DbType.String, cRMAgreementSpecsEntity.var3);
                Database.AddInParameter(cmd, "@var4", DbType.String, cRMAgreementSpecsEntity.var4);
                Database.AddInParameter(cmd, "@var5", DbType.String, cRMAgreementSpecsEntity.var5);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementSpecsEntity.Remarks);
                Database.AddInParameter(cmd, "@AgreementSpecsType", DbType.String, cRMAgreementSpecsEntity.AgreementSpecsType);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMAgreementSpecsEntity already exists. Please specify another CRMAgreementSpecsEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementSpecsEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementSpecsEntity already exists. Please specify another CRMAgreementSpecsEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementSpecs_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@AgreementSpecsID", DbType.Int64, cRMAgreementSpecsEntity.AgreementSpecsID);
                db.AddInParameter(cmd, "@AgreementID", DbType.Int64, cRMAgreementSpecsEntity.AgreementID);
                db.AddInParameter(cmd, "@Item", DbType.String, cRMAgreementSpecsEntity.Item);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, cRMAgreementSpecsEntity.BrandID);
                db.AddInParameter(cmd, "@BayQty", DbType.Decimal, cRMAgreementSpecsEntity.BayQty);
                db.AddInParameter(cmd, "@BayPrice", DbType.Decimal, cRMAgreementSpecsEntity.BayPrice);
                db.AddInParameter(cmd, "@CustomerQty", DbType.Decimal, cRMAgreementSpecsEntity.CustomerQty);
                db.AddInParameter(cmd, "@CustomerPrice", DbType.Decimal, cRMAgreementSpecsEntity.CustomerPrice);
                db.AddInParameter(cmd, "@Field1", DbType.String, cRMAgreementSpecsEntity.Field1);
                db.AddInParameter(cmd, "@Field2", DbType.String, cRMAgreementSpecsEntity.Field2);
                db.AddInParameter(cmd, "@var0", DbType.String, cRMAgreementSpecsEntity.var0);
                db.AddInParameter(cmd, "@var1", DbType.String, cRMAgreementSpecsEntity.var1);
                db.AddInParameter(cmd, "@var2", DbType.String, cRMAgreementSpecsEntity.var2);
                db.AddInParameter(cmd, "@var3", DbType.String, cRMAgreementSpecsEntity.var3);
                db.AddInParameter(cmd, "@var4", DbType.String, cRMAgreementSpecsEntity.var4);
                db.AddInParameter(cmd, "@var5", DbType.String, cRMAgreementSpecsEntity.var5);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cRMAgreementSpecsEntity.Remarks);
                db.AddInParameter(cmd, "@AgreementSpecsType", DbType.String, cRMAgreementSpecsEntity.AgreementSpecsType);

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

        IList<Int64> ICRMAgreementSpecsDataAccess.Update(IList<CRMAgreementSpecsEntity> cRMAgreementSpecsEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMAgreementSpecsEntity cRMAgreementSpecsEntity in cRMAgreementSpecsEntityList)
            {
                returnCode = (this as ICRMAgreementSpecsDataAccess).Update(cRMAgreementSpecsEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMAgreementSpecsDataAccess.Delete(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMAgreementSpecsEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMAgreementSpecsEntity, filterExpression, option);
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

        private Int64 Delete(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementSpecs_SET";

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
                                throw new ArgumentException("CRMAgreementSpecsEntity already exists. Please specify another CRMAgreementSpecsEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMAgreementSpecsEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMAgreementSpecsEntity already exists. Please specify another CRMAgreementSpecsEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMAgreementSpecsEntity cRMAgreementSpecsEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMAgreementSpecs_SET";

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

        IList<Int64> ICRMAgreementSpecsDataAccess.Delete(IList<CRMAgreementSpecsEntity> cRMAgreementSpecsEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMAgreementSpecsEntity cRMAgreementSpecsEntity in cRMAgreementSpecsEntityList)
            {
                returnCode = (this as ICRMAgreementSpecsDataAccess).Delete(cRMAgreementSpecsEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMAgreementSpecsEntity> ICRMAgreementSpecsDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMAgreementSpecs_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMAgreementSpecsEntity> list = CreateEntityBuilder<CRMAgreementSpecsEntity>().BuildEntities(reader);

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

        DataTable ICRMAgreementSpecsDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMAgreementSpecs_GET";

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
