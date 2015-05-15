// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 10-May-2012, 05:58:01




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
    internal sealed partial class PRMBOQDetailDataAccess : BaseDataAccess, IPRMBOQDetailDataAccess
    {
        #region Constructors

        public PRMBOQDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<PRMBOQDetailEntity> CreateEntityBuilder<PRMBOQDetailEntity>()
        {
            return (new PRMBOQDetailBuilder()) as IEntityBuilder<PRMBOQDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IPRMBOQDetailDataAccess.Add(PRMBOQDetailEntity pRMBOQDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(pRMBOQDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(pRMBOQDetailEntity, option);
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

        private Int64 Add(PRMBOQDetailEntity pRMBOQDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BOQDetailID");

                Database.AddInParameter(cmd, "@BOQID", DbType.Int64, pRMBOQDetailEntity.BOQID);	
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMBOQDetailEntity.ItemID);	
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQDetailEntity.Rate);	
                Database.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMBOQDetailEntity.TotalQty);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQDetailEntity.Remarks);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMBOQDetailEntity.IsRemoved);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQDetailEntity.EntryDate);	
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMBOQDetailEntity.BrandID);	
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMBOQDetailEntity.SupplierID);	
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMBOQDetailEntity.RegionID);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMBOQDetailEntity.CountryID);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMBOQDetailEntity already exists. Please specify another PRMBOQDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQDetailEntity already exists. Please specify another PRMBOQDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(PRMBOQDetailEntity pRMBOQDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BOQDetailID", db);

                db.AddInParameter(cmd, "@BOQID", DbType.Int64, pRMBOQDetailEntity.BOQID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMBOQDetailEntity.ItemID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQDetailEntity.Rate);
                db.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMBOQDetailEntity.TotalQty);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQDetailEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMBOQDetailEntity.IsRemoved);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQDetailEntity.EntryDate);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMBOQDetailEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMBOQDetailEntity.SupplierID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMBOQDetailEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMBOQDetailEntity.CountryID);

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

        IList<Int64> IPRMBOQDetailDataAccess.Add(IList<PRMBOQDetailEntity> pRMBOQDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (PRMBOQDetailEntity pRMBOQDetailEntity in pRMBOQDetailEntityList)
            {
                returnCode = (this as IPRMBOQDetailDataAccess).Add(pRMBOQDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IPRMBOQDetailDataAccess.Update(PRMBOQDetailEntity pRMBOQDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(pRMBOQDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(pRMBOQDetailEntity, filterExpression, option);
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

        private Int64 Update(PRMBOQDetailEntity pRMBOQDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BOQDetailID", DbType.Int64, pRMBOQDetailEntity.BOQDetailID);
                Database.AddInParameter(cmd, "@BOQID", DbType.Int64, pRMBOQDetailEntity.BOQID);
                Database.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMBOQDetailEntity.ItemID);
                Database.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQDetailEntity.Rate);
                Database.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMBOQDetailEntity.TotalQty);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQDetailEntity.Remarks);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMBOQDetailEntity.IsRemoved);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQDetailEntity.EntryDate);
                Database.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMBOQDetailEntity.BrandID);
                Database.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMBOQDetailEntity.SupplierID);
                Database.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMBOQDetailEntity.RegionID);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMBOQDetailEntity.CountryID);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("PRMBOQDetailEntity already exists. Please specify another PRMBOQDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQDetailEntity already exists. Please specify another PRMBOQDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(PRMBOQDetailEntity pRMBOQDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BOQDetailID", DbType.Int64, pRMBOQDetailEntity.BOQDetailID);
                db.AddInParameter(cmd, "@BOQID", DbType.Int64, pRMBOQDetailEntity.BOQID);
                db.AddInParameter(cmd, "@ItemID", DbType.Int64, pRMBOQDetailEntity.ItemID);
                db.AddInParameter(cmd, "@Rate", DbType.Decimal, pRMBOQDetailEntity.Rate);
                db.AddInParameter(cmd, "@TotalQty", DbType.Decimal, pRMBOQDetailEntity.TotalQty);
                db.AddInParameter(cmd, "@Remarks", DbType.String, pRMBOQDetailEntity.Remarks);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, pRMBOQDetailEntity.IsRemoved);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, pRMBOQDetailEntity.EntryDate);
                db.AddInParameter(cmd, "@BrandID", DbType.Int64, pRMBOQDetailEntity.BrandID);
                db.AddInParameter(cmd, "@SupplierID", DbType.Int64, pRMBOQDetailEntity.SupplierID);
                db.AddInParameter(cmd, "@RegionID", DbType.Int64, pRMBOQDetailEntity.RegionID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, pRMBOQDetailEntity.CountryID);

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

        IList<Int64> IPRMBOQDetailDataAccess.Update(IList<PRMBOQDetailEntity> pRMBOQDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (PRMBOQDetailEntity pRMBOQDetailEntity in pRMBOQDetailEntityList)
            {
                returnCode = (this as IPRMBOQDetailDataAccess).Update(pRMBOQDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IPRMBOQDetailDataAccess.Delete(PRMBOQDetailEntity pRMBOQDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(pRMBOQDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(pRMBOQDetailEntity, filterExpression, option);
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

        private Int64 Delete(PRMBOQDetailEntity pRMBOQDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetail_SET";

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
                                throw new ArgumentException("PRMBOQDetailEntity already exists. Please specify another PRMBOQDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("PRMBOQDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("PRMBOQDetailEntity already exists. Please specify another PRMBOQDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(PRMBOQDetailEntity pRMBOQDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.PRMBOQDetail_SET";

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

        IList<Int64> IPRMBOQDetailDataAccess.Delete(IList<PRMBOQDetailEntity> pRMBOQDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (PRMBOQDetailEntity pRMBOQDetailEntity in pRMBOQDetailEntityList)
            {
                returnCode = (this as IPRMBOQDetailDataAccess).Delete(pRMBOQDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<PRMBOQDetailEntity> IPRMBOQDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMBOQDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<PRMBOQDetailEntity> list = CreateEntityBuilder<PRMBOQDetailEntity>().BuildEntities(reader);

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

        DataTable IPRMBOQDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.PRMBOQDetail_GET";

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
