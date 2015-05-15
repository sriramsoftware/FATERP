// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 09-Oct-2013, 01:39:59




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
    internal sealed partial class MDArtGalleriaLocationDataAccess : BaseDataAccess, IMDArtGalleriaLocationDataAccess
    {
        #region Constructors

        public MDArtGalleriaLocationDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<MDArtGalleriaLocationEntity> CreateEntityBuilder<MDArtGalleriaLocationEntity>()
        {
            return (new MDArtGalleriaLocationBuilder()) as IEntityBuilder<MDArtGalleriaLocationEntity>;
        }

        #endregion

        #region Add Operation

        Int64 IMDArtGalleriaLocationDataAccess.Add(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(mDArtGalleriaLocationEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(mDArtGalleriaLocationEntity, option);
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

        private Int64 Add(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDArtGalleriaLocation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "ArtGalleriaLocationID");

                Database.AddInParameter(cmd, "@ParentArtGalleriaLocationID", DbType.Int64, mDArtGalleriaLocationEntity.ParentArtGalleriaLocationID);	
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, mDArtGalleriaLocationEntity.CountryID);	
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, mDArtGalleriaLocationEntity.CityID);	
                Database.AddInParameter(cmd, "@Name", DbType.String, mDArtGalleriaLocationEntity.Name);	
                Database.AddInParameter(cmd, "@Description", DbType.String, mDArtGalleriaLocationEntity.Description);	
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDArtGalleriaLocationEntity.IsRemoved);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDArtGalleriaLocationEntity already exists. Please specify another MDArtGalleriaLocationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDArtGalleriaLocationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDArtGalleriaLocationEntity already exists. Please specify another MDArtGalleriaLocationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDArtGalleriaLocation_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "ArtGalleriaLocationID", db);

                db.AddInParameter(cmd, "@ParentArtGalleriaLocationID", DbType.Int64, mDArtGalleriaLocationEntity.ParentArtGalleriaLocationID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, mDArtGalleriaLocationEntity.CountryID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, mDArtGalleriaLocationEntity.CityID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDArtGalleriaLocationEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDArtGalleriaLocationEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDArtGalleriaLocationEntity.IsRemoved);

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

        IList<Int64> IMDArtGalleriaLocationDataAccess.Add(IList<MDArtGalleriaLocationEntity> mDArtGalleriaLocationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity in mDArtGalleriaLocationEntityList)
            {
                returnCode = (this as IMDArtGalleriaLocationDataAccess).Add(mDArtGalleriaLocationEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 IMDArtGalleriaLocationDataAccess.Update(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(mDArtGalleriaLocationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(mDArtGalleriaLocationEntity, filterExpression, option);
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

        private Int64 Update(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDArtGalleriaLocation_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@ArtGalleriaLocationID", DbType.Int64, mDArtGalleriaLocationEntity.ArtGalleriaLocationID);
                Database.AddInParameter(cmd, "@ParentArtGalleriaLocationID", DbType.Int64, mDArtGalleriaLocationEntity.ParentArtGalleriaLocationID);
                Database.AddInParameter(cmd, "@CountryID", DbType.Int64, mDArtGalleriaLocationEntity.CountryID);
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, mDArtGalleriaLocationEntity.CityID);
                Database.AddInParameter(cmd, "@Name", DbType.String, mDArtGalleriaLocationEntity.Name);
                Database.AddInParameter(cmd, "@Description", DbType.String, mDArtGalleriaLocationEntity.Description);
                Database.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDArtGalleriaLocationEntity.IsRemoved);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("MDArtGalleriaLocationEntity already exists. Please specify another MDArtGalleriaLocationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDArtGalleriaLocationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDArtGalleriaLocationEntity already exists. Please specify another MDArtGalleriaLocationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDArtGalleriaLocation_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@ArtGalleriaLocationID", DbType.Int64, mDArtGalleriaLocationEntity.ArtGalleriaLocationID);
                db.AddInParameter(cmd, "@ParentArtGalleriaLocationID", DbType.Int64, mDArtGalleriaLocationEntity.ParentArtGalleriaLocationID);
                db.AddInParameter(cmd, "@CountryID", DbType.Int64, mDArtGalleriaLocationEntity.CountryID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, mDArtGalleriaLocationEntity.CityID);
                db.AddInParameter(cmd, "@Name", DbType.String, mDArtGalleriaLocationEntity.Name);
                db.AddInParameter(cmd, "@Description", DbType.String, mDArtGalleriaLocationEntity.Description);
                db.AddInParameter(cmd, "@IsRemoved", DbType.Boolean, mDArtGalleriaLocationEntity.IsRemoved);

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

        IList<Int64> IMDArtGalleriaLocationDataAccess.Update(IList<MDArtGalleriaLocationEntity> mDArtGalleriaLocationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity in mDArtGalleriaLocationEntityList)
            {
                returnCode = (this as IMDArtGalleriaLocationDataAccess).Update(mDArtGalleriaLocationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 IMDArtGalleriaLocationDataAccess.Delete(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(mDArtGalleriaLocationEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(mDArtGalleriaLocationEntity, filterExpression, option);
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

        private Int64 Delete(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDArtGalleriaLocation_SET";

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
                                throw new ArgumentException("MDArtGalleriaLocationEntity already exists. Please specify another MDArtGalleriaLocationEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("MDArtGalleriaLocationEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("MDArtGalleriaLocationEntity already exists. Please specify another MDArtGalleriaLocationEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.MDArtGalleriaLocation_SET";

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

        IList<Int64> IMDArtGalleriaLocationDataAccess.Delete(IList<MDArtGalleriaLocationEntity> mDArtGalleriaLocationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (MDArtGalleriaLocationEntity mDArtGalleriaLocationEntity in mDArtGalleriaLocationEntityList)
            {
                returnCode = (this as IMDArtGalleriaLocationDataAccess).Delete(mDArtGalleriaLocationEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<MDArtGalleriaLocationEntity> IMDArtGalleriaLocationDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDArtGalleriaLocation_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<MDArtGalleriaLocationEntity> list = CreateEntityBuilder<MDArtGalleriaLocationEntity>().BuildEntities(reader);

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

        DataTable IMDArtGalleriaLocationDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.MDArtGalleriaLocation_GET";

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
