// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 02:41:21




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
    internal sealed partial class CRMLandOwnerDataAccess : BaseDataAccess, ICRMLandOwnerDataAccess
    {
        #region Constructors

        public CRMLandOwnerDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMLandOwnerEntity> CreateEntityBuilder<CRMLandOwnerEntity>()
        {
            return (new CRMLandOwnerBuilder()) as IEntityBuilder<CRMLandOwnerEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMLandOwnerDataAccess.Add(CRMLandOwnerEntity cRMLandOwnerEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMLandOwnerEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMLandOwnerEntity, option);
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

        private Int64 Add(CRMLandOwnerEntity cRMLandOwnerEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandOwner_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "LandOwnerID");

                Database.AddInParameter(cmd, "@LandBasicInfoID", DbType.Int64, cRMLandOwnerEntity.LandBasicInfoID);	
                Database.AddInParameter(cmd, "@OwnerName", DbType.String, cRMLandOwnerEntity.OwnerName);	
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMLandOwnerEntity.ImageUrl);	
                Database.AddInParameter(cmd, "@OwnPercentage", DbType.Decimal, cRMLandOwnerEntity.OwnPercentage);	
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, cRMLandOwnerEntity.MobileNo);	
                Database.AddInParameter(cmd, "@LandPhone", DbType.String, cRMLandOwnerEntity.LandPhone);	
                Database.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMLandOwnerEntity.PresentAddress);	
                Database.AddInParameter(cmd, "@FatherName", DbType.String, cRMLandOwnerEntity.FatherName);	
                Database.AddInParameter(cmd, "@MotherName", DbType.String, cRMLandOwnerEntity.MotherName);	
                Database.AddInParameter(cmd, "@SpouseName", DbType.String, cRMLandOwnerEntity.SpouseName);	
                Database.AddInParameter(cmd, "@DateOfBirth", DbType.DateTime, cRMLandOwnerEntity.DateOfBirth);	
                Database.AddInParameter(cmd, "@Email", DbType.String, cRMLandOwnerEntity.Email);	
                Database.AddInParameter(cmd, "@BusinessDetails", DbType.String, cRMLandOwnerEntity.BusinessDetails);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMLandOwnerEntity already exists. Please specify another CRMLandOwnerEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMLandOwnerEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMLandOwnerEntity already exists. Please specify another CRMLandOwnerEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMLandOwnerEntity cRMLandOwnerEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandOwner_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "LandOwnerID", db);

                db.AddInParameter(cmd, "@LandBasicInfoID", DbType.Int64, cRMLandOwnerEntity.LandBasicInfoID);
                db.AddInParameter(cmd, "@OwnerName", DbType.String, cRMLandOwnerEntity.OwnerName);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMLandOwnerEntity.ImageUrl);
                db.AddInParameter(cmd, "@OwnPercentage", DbType.Decimal, cRMLandOwnerEntity.OwnPercentage);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, cRMLandOwnerEntity.MobileNo);
                db.AddInParameter(cmd, "@LandPhone", DbType.String, cRMLandOwnerEntity.LandPhone);
                db.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMLandOwnerEntity.PresentAddress);
                db.AddInParameter(cmd, "@FatherName", DbType.String, cRMLandOwnerEntity.FatherName);
                db.AddInParameter(cmd, "@MotherName", DbType.String, cRMLandOwnerEntity.MotherName);
                db.AddInParameter(cmd, "@SpouseName", DbType.String, cRMLandOwnerEntity.SpouseName);
                db.AddInParameter(cmd, "@DateOfBirth", DbType.DateTime, cRMLandOwnerEntity.DateOfBirth);
                db.AddInParameter(cmd, "@Email", DbType.String, cRMLandOwnerEntity.Email);
                db.AddInParameter(cmd, "@BusinessDetails", DbType.String, cRMLandOwnerEntity.BusinessDetails);

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

        IList<Int64> ICRMLandOwnerDataAccess.Add(IList<CRMLandOwnerEntity> cRMLandOwnerEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMLandOwnerEntity cRMLandOwnerEntity in cRMLandOwnerEntityList)
            {
                returnCode = (this as ICRMLandOwnerDataAccess).Add(cRMLandOwnerEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMLandOwnerDataAccess.Update(CRMLandOwnerEntity cRMLandOwnerEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMLandOwnerEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMLandOwnerEntity, filterExpression, option);
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

        private Int64 Update(CRMLandOwnerEntity cRMLandOwnerEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandOwner_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@LandOwnerID", DbType.Int64, cRMLandOwnerEntity.LandOwnerID);
                Database.AddInParameter(cmd, "@LandBasicInfoID", DbType.Int64, cRMLandOwnerEntity.LandBasicInfoID);
                Database.AddInParameter(cmd, "@OwnerName", DbType.String, cRMLandOwnerEntity.OwnerName);
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMLandOwnerEntity.ImageUrl);
                Database.AddInParameter(cmd, "@OwnPercentage", DbType.Decimal, cRMLandOwnerEntity.OwnPercentage);
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, cRMLandOwnerEntity.MobileNo);
                Database.AddInParameter(cmd, "@LandPhone", DbType.String, cRMLandOwnerEntity.LandPhone);
                Database.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMLandOwnerEntity.PresentAddress);
                Database.AddInParameter(cmd, "@FatherName", DbType.String, cRMLandOwnerEntity.FatherName);
                Database.AddInParameter(cmd, "@MotherName", DbType.String, cRMLandOwnerEntity.MotherName);
                Database.AddInParameter(cmd, "@SpouseName", DbType.String, cRMLandOwnerEntity.SpouseName);
                Database.AddInParameter(cmd, "@DateOfBirth", DbType.DateTime, cRMLandOwnerEntity.DateOfBirth);
                Database.AddInParameter(cmd, "@Email", DbType.String, cRMLandOwnerEntity.Email);
                Database.AddInParameter(cmd, "@BusinessDetails", DbType.String, cRMLandOwnerEntity.BusinessDetails);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMLandOwnerEntity already exists. Please specify another CRMLandOwnerEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMLandOwnerEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMLandOwnerEntity already exists. Please specify another CRMLandOwnerEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMLandOwnerEntity cRMLandOwnerEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandOwner_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@LandOwnerID", DbType.Int64, cRMLandOwnerEntity.LandOwnerID);
                db.AddInParameter(cmd, "@LandBasicInfoID", DbType.Int64, cRMLandOwnerEntity.LandBasicInfoID);
                db.AddInParameter(cmd, "@OwnerName", DbType.String, cRMLandOwnerEntity.OwnerName);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMLandOwnerEntity.ImageUrl);
                db.AddInParameter(cmd, "@OwnPercentage", DbType.Decimal, cRMLandOwnerEntity.OwnPercentage);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, cRMLandOwnerEntity.MobileNo);
                db.AddInParameter(cmd, "@LandPhone", DbType.String, cRMLandOwnerEntity.LandPhone);
                db.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMLandOwnerEntity.PresentAddress);
                db.AddInParameter(cmd, "@FatherName", DbType.String, cRMLandOwnerEntity.FatherName);
                db.AddInParameter(cmd, "@MotherName", DbType.String, cRMLandOwnerEntity.MotherName);
                db.AddInParameter(cmd, "@SpouseName", DbType.String, cRMLandOwnerEntity.SpouseName);
                db.AddInParameter(cmd, "@DateOfBirth", DbType.DateTime, cRMLandOwnerEntity.DateOfBirth);
                db.AddInParameter(cmd, "@Email", DbType.String, cRMLandOwnerEntity.Email);
                db.AddInParameter(cmd, "@BusinessDetails", DbType.String, cRMLandOwnerEntity.BusinessDetails);

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

        IList<Int64> ICRMLandOwnerDataAccess.Update(IList<CRMLandOwnerEntity> cRMLandOwnerEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMLandOwnerEntity cRMLandOwnerEntity in cRMLandOwnerEntityList)
            {
                returnCode = (this as ICRMLandOwnerDataAccess).Update(cRMLandOwnerEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMLandOwnerDataAccess.Delete(CRMLandOwnerEntity cRMLandOwnerEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMLandOwnerEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMLandOwnerEntity, filterExpression, option);
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

        private Int64 Delete(CRMLandOwnerEntity cRMLandOwnerEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandOwner_SET";

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
                                throw new ArgumentException("CRMLandOwnerEntity already exists. Please specify another CRMLandOwnerEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMLandOwnerEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMLandOwnerEntity already exists. Please specify another CRMLandOwnerEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMLandOwnerEntity cRMLandOwnerEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandOwner_SET";

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

        IList<Int64> ICRMLandOwnerDataAccess.Delete(IList<CRMLandOwnerEntity> cRMLandOwnerEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMLandOwnerEntity cRMLandOwnerEntity in cRMLandOwnerEntityList)
            {
                returnCode = (this as ICRMLandOwnerDataAccess).Delete(cRMLandOwnerEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMLandOwnerEntity> ICRMLandOwnerDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMLandOwner_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMLandOwnerEntity> list = CreateEntityBuilder<CRMLandOwnerEntity>().BuildEntities(reader);

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

        DataTable ICRMLandOwnerDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMLandOwner_GET";

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
