// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-Aug-2013, 11:09:08




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
    internal sealed partial class CMMeasurementBookDetailDataAccess : BaseDataAccess, ICMMeasurementBookDetailDataAccess
    {
        #region Constructors

        public CMMeasurementBookDetailDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CMMeasurementBookDetailEntity> CreateEntityBuilder<CMMeasurementBookDetailEntity>()
        {
            return (new CMMeasurementBookDetailBuilder()) as IEntityBuilder<CMMeasurementBookDetailEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICMMeasurementBookDetailDataAccess.Add(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cMMeasurementBookDetailEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cMMeasurementBookDetailEntity, option);
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

        private Int64 Add(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMMeasurementBookDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "MeasurementBookDetailID");

                Database.AddInParameter(cmd, "@MeasurementBookID", DbType.Int64, cMMeasurementBookDetailEntity.MeasurementBookID);	
                Database.AddInParameter(cmd, "@Description", DbType.String, cMMeasurementBookDetailEntity.Description);	
                Database.AddInParameter(cmd, "@UnitID", DbType.Int64, cMMeasurementBookDetailEntity.UnitID);	
                Database.AddInParameter(cmd, "@Lengthft", DbType.Decimal, cMMeasurementBookDetailEntity.Lengthft);	
                Database.AddInParameter(cmd, "@Lenghtin", DbType.Decimal, cMMeasurementBookDetailEntity.Lenghtin);	
                Database.AddInParameter(cmd, "@Widthft", DbType.Decimal, cMMeasurementBookDetailEntity.Widthft);	
                Database.AddInParameter(cmd, "@Widthin", DbType.Decimal, cMMeasurementBookDetailEntity.Widthin);	
                Database.AddInParameter(cmd, "@Heightft", DbType.Decimal, cMMeasurementBookDetailEntity.Heightft);	
                Database.AddInParameter(cmd, "@Heightin", DbType.Decimal, cMMeasurementBookDetailEntity.Heightin);	
                Database.AddInParameter(cmd, "@Nos", DbType.Decimal, cMMeasurementBookDetailEntity.Nos);	
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, cMMeasurementBookDetailEntity.Qty);	
                Database.AddInParameter(cmd, "@Price", DbType.Decimal, cMMeasurementBookDetailEntity.Price);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMMeasurementBookDetailEntity already exists. Please specify another CMMeasurementBookDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMMeasurementBookDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMMeasurementBookDetailEntity already exists. Please specify another CMMeasurementBookDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMMeasurementBookDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "MeasurementBookDetailID", db);

                db.AddInParameter(cmd, "@MeasurementBookID", DbType.Int64, cMMeasurementBookDetailEntity.MeasurementBookID);
                db.AddInParameter(cmd, "@Description", DbType.String, cMMeasurementBookDetailEntity.Description);
                db.AddInParameter(cmd, "@UnitID", DbType.Int64, cMMeasurementBookDetailEntity.UnitID);
                db.AddInParameter(cmd, "@Lengthft", DbType.Decimal, cMMeasurementBookDetailEntity.Lengthft);
                db.AddInParameter(cmd, "@Lenghtin", DbType.Decimal, cMMeasurementBookDetailEntity.Lenghtin);
                db.AddInParameter(cmd, "@Widthft", DbType.Decimal, cMMeasurementBookDetailEntity.Widthft);
                db.AddInParameter(cmd, "@Widthin", DbType.Decimal, cMMeasurementBookDetailEntity.Widthin);
                db.AddInParameter(cmd, "@Heightft", DbType.Decimal, cMMeasurementBookDetailEntity.Heightft);
                db.AddInParameter(cmd, "@Heightin", DbType.Decimal, cMMeasurementBookDetailEntity.Heightin);
                db.AddInParameter(cmd, "@Nos", DbType.Decimal, cMMeasurementBookDetailEntity.Nos);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, cMMeasurementBookDetailEntity.Qty);
                db.AddInParameter(cmd, "@Price", DbType.Decimal, cMMeasurementBookDetailEntity.Price);

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

        IList<Int64> ICMMeasurementBookDetailDataAccess.Add(IList<CMMeasurementBookDetailEntity> cMMeasurementBookDetailEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity in cMMeasurementBookDetailEntityList)
            {
                returnCode = (this as ICMMeasurementBookDetailDataAccess).Add(cMMeasurementBookDetailEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICMMeasurementBookDetailDataAccess.Update(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cMMeasurementBookDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cMMeasurementBookDetailEntity, filterExpression, option);
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

        private Int64 Update(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMMeasurementBookDetail_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@MeasurementBookDetailID", DbType.Int64, cMMeasurementBookDetailEntity.MeasurementBookDetailID);
                Database.AddInParameter(cmd, "@MeasurementBookID", DbType.Int64, cMMeasurementBookDetailEntity.MeasurementBookID);
                Database.AddInParameter(cmd, "@Description", DbType.String, cMMeasurementBookDetailEntity.Description);
                Database.AddInParameter(cmd, "@UnitID", DbType.Int64, cMMeasurementBookDetailEntity.UnitID);
                Database.AddInParameter(cmd, "@Lengthft", DbType.Decimal, cMMeasurementBookDetailEntity.Lengthft);
                Database.AddInParameter(cmd, "@Lenghtin", DbType.Decimal, cMMeasurementBookDetailEntity.Lenghtin);
                Database.AddInParameter(cmd, "@Widthft", DbType.Decimal, cMMeasurementBookDetailEntity.Widthft);
                Database.AddInParameter(cmd, "@Widthin", DbType.Decimal, cMMeasurementBookDetailEntity.Widthin);
                Database.AddInParameter(cmd, "@Heightft", DbType.Decimal, cMMeasurementBookDetailEntity.Heightft);
                Database.AddInParameter(cmd, "@Heightin", DbType.Decimal, cMMeasurementBookDetailEntity.Heightin);
                Database.AddInParameter(cmd, "@Nos", DbType.Decimal, cMMeasurementBookDetailEntity.Nos);
                Database.AddInParameter(cmd, "@Qty", DbType.Decimal, cMMeasurementBookDetailEntity.Qty);
                Database.AddInParameter(cmd, "@Price", DbType.Decimal, cMMeasurementBookDetailEntity.Price);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CMMeasurementBookDetailEntity already exists. Please specify another CMMeasurementBookDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMMeasurementBookDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMMeasurementBookDetailEntity already exists. Please specify another CMMeasurementBookDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMMeasurementBookDetail_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@MeasurementBookDetailID", DbType.Int64, cMMeasurementBookDetailEntity.MeasurementBookDetailID);
                db.AddInParameter(cmd, "@MeasurementBookID", DbType.Int64, cMMeasurementBookDetailEntity.MeasurementBookID);
                db.AddInParameter(cmd, "@Description", DbType.String, cMMeasurementBookDetailEntity.Description);
                db.AddInParameter(cmd, "@UnitID", DbType.Int64, cMMeasurementBookDetailEntity.UnitID);
                db.AddInParameter(cmd, "@Lengthft", DbType.Decimal, cMMeasurementBookDetailEntity.Lengthft);
                db.AddInParameter(cmd, "@Lenghtin", DbType.Decimal, cMMeasurementBookDetailEntity.Lenghtin);
                db.AddInParameter(cmd, "@Widthft", DbType.Decimal, cMMeasurementBookDetailEntity.Widthft);
                db.AddInParameter(cmd, "@Widthin", DbType.Decimal, cMMeasurementBookDetailEntity.Widthin);
                db.AddInParameter(cmd, "@Heightft", DbType.Decimal, cMMeasurementBookDetailEntity.Heightft);
                db.AddInParameter(cmd, "@Heightin", DbType.Decimal, cMMeasurementBookDetailEntity.Heightin);
                db.AddInParameter(cmd, "@Nos", DbType.Decimal, cMMeasurementBookDetailEntity.Nos);
                db.AddInParameter(cmd, "@Qty", DbType.Decimal, cMMeasurementBookDetailEntity.Qty);
                db.AddInParameter(cmd, "@Price", DbType.Decimal, cMMeasurementBookDetailEntity.Price);

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

        IList<Int64> ICMMeasurementBookDetailDataAccess.Update(IList<CMMeasurementBookDetailEntity> cMMeasurementBookDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity in cMMeasurementBookDetailEntityList)
            {
                returnCode = (this as ICMMeasurementBookDetailDataAccess).Update(cMMeasurementBookDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICMMeasurementBookDetailDataAccess.Delete(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cMMeasurementBookDetailEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cMMeasurementBookDetailEntity, filterExpression, option);
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

        private Int64 Delete(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMMeasurementBookDetail_SET";

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
                                throw new ArgumentException("CMMeasurementBookDetailEntity already exists. Please specify another CMMeasurementBookDetailEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CMMeasurementBookDetailEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CMMeasurementBookDetailEntity already exists. Please specify another CMMeasurementBookDetailEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CMMeasurementBookDetail_SET";

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

        IList<Int64> ICMMeasurementBookDetailDataAccess.Delete(IList<CMMeasurementBookDetailEntity> cMMeasurementBookDetailEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CMMeasurementBookDetailEntity cMMeasurementBookDetailEntity in cMMeasurementBookDetailEntityList)
            {
                returnCode = (this as ICMMeasurementBookDetailDataAccess).Delete(cMMeasurementBookDetailEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CMMeasurementBookDetailEntity> ICMMeasurementBookDetailDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMMeasurementBookDetail_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CMMeasurementBookDetailEntity> list = CreateEntityBuilder<CMMeasurementBookDetailEntity>().BuildEntities(reader);

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

        DataTable ICMMeasurementBookDetailDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CMMeasurementBookDetail_GET";

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
