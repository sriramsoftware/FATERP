// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 14-Aug-2013, 02:50:29




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
    internal sealed partial class CMBillFloorDetailDataAccess : BaseDataAccess, ICMBillFloorDetailDataAccess
    {
        #region Constructors

        public CMBillFloorDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMBillFloorDetailEntity> CreateEntityBuilder<CMBillFloorDetailEntity>()
        {
            return (new CMBillFloorDetailBuilder()) as IEntityBuilder<CMBillFloorDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMBillFloorDetailDataAccess.Add(CMBillFloorDetailEntity cMBillFloorDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMBillFloorDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMBillFloorDetailEntity, option);
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

        private Int64 Add(CMBillFloorDetailEntity cMBillFloorDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillFloorDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BillFloorDetailID");

                Database.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillFloorDetailEntity.BillID);	
                Database.AddInParameter(cmd, "@BillFloorDetailCategoryID", DbType.Int64, cMBillFloorDetailEntity.BillFloorDetailCategoryID);	
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, cMBillFloorDetailEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cMBillFloorDetailEntity.ProjectFloorUnitID);	
                Database.AddInParameter(cmd, "@FloorBillAmount", DbType.Decimal, cMBillFloorDetailEntity.FloorBillAmount);	
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMBillFloorDetailEntity.Remarks);	
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, cMBillFloorDetailEntity.EntryDate);	
                Database.AddInParameter(cmd, "@Extra1", DbType.String, cMBillFloorDetailEntity.Extra1);	
                Database.AddInParameter(cmd, "@Extra2", DbType.String, cMBillFloorDetailEntity.Extra2);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillFloorDetailEntity already exists. Please specify another CMBillFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillFloorDetailEntity already exists. Please specify another CMBillFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMBillFloorDetailEntity cMBillFloorDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillFloorDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BillFloorDetailID", db);

                db.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillFloorDetailEntity.BillID);
                db.AddInParameter(cmd, "@BillFloorDetailCategoryID", DbType.Int64, cMBillFloorDetailEntity.BillFloorDetailCategoryID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, cMBillFloorDetailEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cMBillFloorDetailEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@FloorBillAmount", DbType.Decimal, cMBillFloorDetailEntity.FloorBillAmount);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMBillFloorDetailEntity.Remarks);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, cMBillFloorDetailEntity.EntryDate);
                db.AddInParameter(cmd, "@Extra1", DbType.String, cMBillFloorDetailEntity.Extra1);
                db.AddInParameter(cmd, "@Extra2", DbType.String, cMBillFloorDetailEntity.Extra2);

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

        IList<Int64> ICMBillFloorDetailDataAccess.Add(IList<CMBillFloorDetailEntity> cMBillFloorDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMBillFloorDetailEntity cMBillFloorDetailEntity in cMBillFloorDetailEntityList)
            {
                returnCode = (this as ICMBillFloorDetailDataAccess).Add(cMBillFloorDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMBillFloorDetailDataAccess.Update(CMBillFloorDetailEntity cMBillFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMBillFloorDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMBillFloorDetailEntity, filterExpression, option);
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

        private Int64 Update(CMBillFloorDetailEntity cMBillFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillFloorDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BillFloorDetailID", DbType.Int64, cMBillFloorDetailEntity.BillFloorDetailID);
                Database.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillFloorDetailEntity.BillID);
                Database.AddInParameter(cmd, "@BillFloorDetailCategoryID", DbType.Int64, cMBillFloorDetailEntity.BillFloorDetailCategoryID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, cMBillFloorDetailEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cMBillFloorDetailEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@FloorBillAmount", DbType.Decimal, cMBillFloorDetailEntity.FloorBillAmount);
                Database.AddInParameter(cmd, "@Remarks", DbType.String, cMBillFloorDetailEntity.Remarks);
                Database.AddInParameter(cmd, "@EntryDate", DbType.DateTime, cMBillFloorDetailEntity.EntryDate);
                Database.AddInParameter(cmd, "@Extra1", DbType.String, cMBillFloorDetailEntity.Extra1);
                Database.AddInParameter(cmd, "@Extra2", DbType.String, cMBillFloorDetailEntity.Extra2);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMBillFloorDetailEntity already exists. Please specify another CMBillFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillFloorDetailEntity already exists. Please specify another CMBillFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMBillFloorDetailEntity cMBillFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillFloorDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BillFloorDetailID", DbType.Int64, cMBillFloorDetailEntity.BillFloorDetailID);
                db.AddInParameter(cmd, "@BillID", DbType.Int64, cMBillFloorDetailEntity.BillID);
                db.AddInParameter(cmd, "@BillFloorDetailCategoryID", DbType.Int64, cMBillFloorDetailEntity.BillFloorDetailCategoryID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, cMBillFloorDetailEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cMBillFloorDetailEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@FloorBillAmount", DbType.Decimal, cMBillFloorDetailEntity.FloorBillAmount);
                db.AddInParameter(cmd, "@Remarks", DbType.String, cMBillFloorDetailEntity.Remarks);
                db.AddInParameter(cmd, "@EntryDate", DbType.DateTime, cMBillFloorDetailEntity.EntryDate);
                db.AddInParameter(cmd, "@Extra1", DbType.String, cMBillFloorDetailEntity.Extra1);
                db.AddInParameter(cmd, "@Extra2", DbType.String, cMBillFloorDetailEntity.Extra2);

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

        IList<Int64> ICMBillFloorDetailDataAccess.Update(IList<CMBillFloorDetailEntity> cMBillFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMBillFloorDetailEntity cMBillFloorDetailEntity in cMBillFloorDetailEntityList)
            {
                returnCode = (this as ICMBillFloorDetailDataAccess).Update(cMBillFloorDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMBillFloorDetailDataAccess.Delete(CMBillFloorDetailEntity cMBillFloorDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMBillFloorDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMBillFloorDetailEntity, filterExpression, option);
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

        private Int64 Delete(CMBillFloorDetailEntity cMBillFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillFloorDetail_SET";

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
                                throw new ArgumentException("CMBillFloorDetailEntity already exists. Please specify another CMBillFloorDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMBillFloorDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMBillFloorDetailEntity already exists. Please specify another CMBillFloorDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMBillFloorDetailEntity cMBillFloorDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMBillFloorDetail_SET";

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

        IList<Int64> ICMBillFloorDetailDataAccess.Delete(IList<CMBillFloorDetailEntity> cMBillFloorDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMBillFloorDetailEntity cMBillFloorDetailEntity in cMBillFloorDetailEntityList)
            {
                returnCode = (this as ICMBillFloorDetailDataAccess).Delete(cMBillFloorDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMBillFloorDetailEntity> ICMBillFloorDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMBillFloorDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMBillFloorDetailEntity> list = CreateEntityBuilder<CMBillFloorDetailEntity>().BuildEntities(reader);

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

        DataTable ICMBillFloorDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMBillFloorDetail_GET";

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
