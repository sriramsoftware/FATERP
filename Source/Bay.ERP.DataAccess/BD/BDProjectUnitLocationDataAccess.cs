// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 05-Oct-2013, 03:32:47




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
    internal sealed partial class BDProjectUnitLocationDataAccess : BaseDataAccess, IBDProjectUnitLocationDataAccess
    {
        #region Constructors

        public BDProjectUnitLocationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<BDProjectUnitLocationEntity> CreateEntityBuilder<BDProjectUnitLocationEntity>()
        {
            return (new BDProjectUnitLocationBuilder()) as IEntityBuilder<BDProjectUnitLocationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IBDProjectUnitLocationDataAccess.Add(BDProjectUnitLocationEntity bDProjectUnitLocationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(bDProjectUnitLocationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(bDProjectUnitLocationEntity, option);
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

        private Int64 Add(BDProjectUnitLocationEntity bDProjectUnitLocationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectUnitLocation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ProjectUnitLocationID");

                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectUnitLocationEntity.ProjectID);	
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, bDProjectUnitLocationEntity.ProjectFloorID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, bDProjectUnitLocationEntity.ProjectFloorUnitID);	
                Database.AddInParameter(cmd, "@FloorUnitLocationCategoryID", DbType.Int64, bDProjectUnitLocationEntity.FloorUnitLocationCategoryID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, bDProjectUnitLocationEntity.Name);	
                Database.AddInParameter(cmd, "@NetAreaSft", DbType.Decimal, bDProjectUnitLocationEntity.NetAreaSft);	
                Database.AddInParameter(cmd, "@GrossAreaSft", DbType.Decimal, bDProjectUnitLocationEntity.GrossAreaSft);	
                Database.AddInParameter(cmd, "@Measurement", DbType.String, bDProjectUnitLocationEntity.Measurement);	
                Database.AddInParameter(cmd, "@Facing", DbType.String, bDProjectUnitLocationEntity.Facing);	
                Database.AddInParameter(cmd, "@Dimension", DbType.String, bDProjectUnitLocationEntity.Dimension);	
                Database.AddInParameter(cmd, "@Description", DbType.String, bDProjectUnitLocationEntity.Description);	
                Database.AddInParameter(cmd, "@ModificationDate", DbType.DateTime, bDProjectUnitLocationEntity.ModificationDate);	
                Database.AddInParameter(cmd, "@ModificationNote", DbType.String, bDProjectUnitLocationEntity.ModificationNote);	
                Database.AddInParameter(cmd, "@SpecialFeatures", DbType.String, bDProjectUnitLocationEntity.SpecialFeatures);	
                Database.AddInParameter(cmd, "@Extra1", DbType.String, bDProjectUnitLocationEntity.Extra1);	
                Database.AddInParameter(cmd, "@Extra2", DbType.String, bDProjectUnitLocationEntity.Extra2);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectUnitLocationEntity already exists. Please specify another BDProjectUnitLocationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectUnitLocationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectUnitLocationEntity already exists. Please specify another BDProjectUnitLocationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(BDProjectUnitLocationEntity bDProjectUnitLocationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectUnitLocation_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ProjectUnitLocationID", db);

                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectUnitLocationEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, bDProjectUnitLocationEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, bDProjectUnitLocationEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@FloorUnitLocationCategoryID", DbType.Int64, bDProjectUnitLocationEntity.FloorUnitLocationCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, bDProjectUnitLocationEntity.Name);
                db.AddInParameter(cmd, "@NetAreaSft", DbType.Decimal, bDProjectUnitLocationEntity.NetAreaSft);
                db.AddInParameter(cmd, "@GrossAreaSft", DbType.Decimal, bDProjectUnitLocationEntity.GrossAreaSft);
                db.AddInParameter(cmd, "@Measurement", DbType.String, bDProjectUnitLocationEntity.Measurement);
                db.AddInParameter(cmd, "@Facing", DbType.String, bDProjectUnitLocationEntity.Facing);
                db.AddInParameter(cmd, "@Dimension", DbType.String, bDProjectUnitLocationEntity.Dimension);
                db.AddInParameter(cmd, "@Description", DbType.String, bDProjectUnitLocationEntity.Description);
                db.AddInParameter(cmd, "@ModificationDate", DbType.DateTime, bDProjectUnitLocationEntity.ModificationDate);
                db.AddInParameter(cmd, "@ModificationNote", DbType.String, bDProjectUnitLocationEntity.ModificationNote);
                db.AddInParameter(cmd, "@SpecialFeatures", DbType.String, bDProjectUnitLocationEntity.SpecialFeatures);
                db.AddInParameter(cmd, "@Extra1", DbType.String, bDProjectUnitLocationEntity.Extra1);
                db.AddInParameter(cmd, "@Extra2", DbType.String, bDProjectUnitLocationEntity.Extra2);

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

        IList<Int64> IBDProjectUnitLocationDataAccess.Add(IList<BDProjectUnitLocationEntity> bDProjectUnitLocationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (BDProjectUnitLocationEntity bDProjectUnitLocationEntity in bDProjectUnitLocationEntityList)
            {
                returnCode = (this as IBDProjectUnitLocationDataAccess).Add(bDProjectUnitLocationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IBDProjectUnitLocationDataAccess.Update(BDProjectUnitLocationEntity bDProjectUnitLocationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(bDProjectUnitLocationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(bDProjectUnitLocationEntity, filterExpression, option);
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

        private Int64 Update(BDProjectUnitLocationEntity bDProjectUnitLocationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectUnitLocation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ProjectUnitLocationID", DbType.Int64, bDProjectUnitLocationEntity.ProjectUnitLocationID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectUnitLocationEntity.ProjectID);
                Database.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, bDProjectUnitLocationEntity.ProjectFloorID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, bDProjectUnitLocationEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@FloorUnitLocationCategoryID", DbType.Int64, bDProjectUnitLocationEntity.FloorUnitLocationCategoryID);
                Database.AddInParameter(cmd, "@Name", DbType.String, bDProjectUnitLocationEntity.Name);
                Database.AddInParameter(cmd, "@NetAreaSft", DbType.Decimal, bDProjectUnitLocationEntity.NetAreaSft);
                Database.AddInParameter(cmd, "@GrossAreaSft", DbType.Decimal, bDProjectUnitLocationEntity.GrossAreaSft);
                Database.AddInParameter(cmd, "@Measurement", DbType.String, bDProjectUnitLocationEntity.Measurement);
                Database.AddInParameter(cmd, "@Facing", DbType.String, bDProjectUnitLocationEntity.Facing);
                Database.AddInParameter(cmd, "@Dimension", DbType.String, bDProjectUnitLocationEntity.Dimension);
                Database.AddInParameter(cmd, "@Description", DbType.String, bDProjectUnitLocationEntity.Description);
                Database.AddInParameter(cmd, "@ModificationDate", DbType.DateTime, bDProjectUnitLocationEntity.ModificationDate);
                Database.AddInParameter(cmd, "@ModificationNote", DbType.String, bDProjectUnitLocationEntity.ModificationNote);
                Database.AddInParameter(cmd, "@SpecialFeatures", DbType.String, bDProjectUnitLocationEntity.SpecialFeatures);
                Database.AddInParameter(cmd, "@Extra1", DbType.String, bDProjectUnitLocationEntity.Extra1);
                Database.AddInParameter(cmd, "@Extra2", DbType.String, bDProjectUnitLocationEntity.Extra2);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("BDProjectUnitLocationEntity already exists. Please specify another BDProjectUnitLocationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectUnitLocationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectUnitLocationEntity already exists. Please specify another BDProjectUnitLocationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(BDProjectUnitLocationEntity bDProjectUnitLocationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectUnitLocation_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ProjectUnitLocationID", DbType.Int64, bDProjectUnitLocationEntity.ProjectUnitLocationID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, bDProjectUnitLocationEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectFloorID", DbType.Int64, bDProjectUnitLocationEntity.ProjectFloorID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, bDProjectUnitLocationEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@FloorUnitLocationCategoryID", DbType.Int64, bDProjectUnitLocationEntity.FloorUnitLocationCategoryID);
                db.AddInParameter(cmd, "@Name", DbType.String, bDProjectUnitLocationEntity.Name);
                db.AddInParameter(cmd, "@NetAreaSft", DbType.Decimal, bDProjectUnitLocationEntity.NetAreaSft);
                db.AddInParameter(cmd, "@GrossAreaSft", DbType.Decimal, bDProjectUnitLocationEntity.GrossAreaSft);
                db.AddInParameter(cmd, "@Measurement", DbType.String, bDProjectUnitLocationEntity.Measurement);
                db.AddInParameter(cmd, "@Facing", DbType.String, bDProjectUnitLocationEntity.Facing);
                db.AddInParameter(cmd, "@Dimension", DbType.String, bDProjectUnitLocationEntity.Dimension);
                db.AddInParameter(cmd, "@Description", DbType.String, bDProjectUnitLocationEntity.Description);
                db.AddInParameter(cmd, "@ModificationDate", DbType.DateTime, bDProjectUnitLocationEntity.ModificationDate);
                db.AddInParameter(cmd, "@ModificationNote", DbType.String, bDProjectUnitLocationEntity.ModificationNote);
                db.AddInParameter(cmd, "@SpecialFeatures", DbType.String, bDProjectUnitLocationEntity.SpecialFeatures);
                db.AddInParameter(cmd, "@Extra1", DbType.String, bDProjectUnitLocationEntity.Extra1);
                db.AddInParameter(cmd, "@Extra2", DbType.String, bDProjectUnitLocationEntity.Extra2);

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

        IList<Int64> IBDProjectUnitLocationDataAccess.Update(IList<BDProjectUnitLocationEntity> bDProjectUnitLocationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (BDProjectUnitLocationEntity bDProjectUnitLocationEntity in bDProjectUnitLocationEntityList)
            {
                returnCode = (this as IBDProjectUnitLocationDataAccess).Update(bDProjectUnitLocationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IBDProjectUnitLocationDataAccess.Delete(BDProjectUnitLocationEntity bDProjectUnitLocationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(bDProjectUnitLocationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(bDProjectUnitLocationEntity, filterExpression, option);
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

        private Int64 Delete(BDProjectUnitLocationEntity bDProjectUnitLocationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectUnitLocation_SET";

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
                                throw new ArgumentException("BDProjectUnitLocationEntity already exists. Please specify another BDProjectUnitLocationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("BDProjectUnitLocationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("BDProjectUnitLocationEntity already exists. Please specify another BDProjectUnitLocationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(BDProjectUnitLocationEntity bDProjectUnitLocationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.BDProjectUnitLocation_SET";

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

        IList<Int64> IBDProjectUnitLocationDataAccess.Delete(IList<BDProjectUnitLocationEntity> bDProjectUnitLocationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (BDProjectUnitLocationEntity bDProjectUnitLocationEntity in bDProjectUnitLocationEntityList)
            {
                returnCode = (this as IBDProjectUnitLocationDataAccess).Delete(bDProjectUnitLocationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<BDProjectUnitLocationEntity> IBDProjectUnitLocationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectUnitLocation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<BDProjectUnitLocationEntity> list = CreateEntityBuilder<BDProjectUnitLocationEntity>().BuildEntities(reader);

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

        DataTable IBDProjectUnitLocationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.BDProjectUnitLocation_GET";

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
