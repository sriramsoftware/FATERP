// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Apr-2013, 03:35:56




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
    internal sealed partial class CRMBuyerBookSpaceDataAccess : BaseDataAccess, ICRMBuyerBookSpaceDataAccess
    {
        #region Constructors

        public CRMBuyerBookSpaceDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMBuyerBookSpaceEntity> CreateEntityBuilder<CRMBuyerBookSpaceEntity>()
        {
            return (new CRMBuyerBookSpaceBuilder()) as IEntityBuilder<CRMBuyerBookSpaceEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMBuyerBookSpaceDataAccess.Add(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMBuyerBookSpaceEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMBuyerBookSpaceEntity, option);
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

        private Int64 Add(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBookSpace_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "BuyerBookSpaceID");

                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cRMBuyerBookSpaceEntity.ReferenceID);	
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMBuyerBookSpaceEntity.ProjectID);	
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cRMBuyerBookSpaceEntity.ProjectFloorUnitID);	
                Database.AddInParameter(cmd, "@BookingNote", DbType.String, cRMBuyerBookSpaceEntity.BookingNote);	
                Database.AddInParameter(cmd, "@IsLandOwner", DbType.Boolean, cRMBuyerBookSpaceEntity.IsLandOwner);	
                Database.AddInParameter(cmd, "@IsApprovedByManagement", DbType.Boolean, cRMBuyerBookSpaceEntity.IsApprovedByManagement);	
                Database.AddInParameter(cmd, "@BookingStatusID", DbType.Int64, cRMBuyerBookSpaceEntity.BookingStatusID);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMBuyerBookSpaceEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMBuyerBookSpaceEntity.IP);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMBuyerBookSpaceEntity.CreateDate);
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMBuyerBookSpaceEntity.ImageUrl);

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMBuyerBookSpaceEntity already exists. Please specify another CRMBuyerBookSpaceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerBookSpaceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerBookSpaceEntity already exists. Please specify another CRMBuyerBookSpaceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBookSpace_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "BuyerBookSpaceID", db);

                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cRMBuyerBookSpaceEntity.ReferenceID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMBuyerBookSpaceEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cRMBuyerBookSpaceEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@BookingNote", DbType.String, cRMBuyerBookSpaceEntity.BookingNote);
                db.AddInParameter(cmd, "@IsLandOwner", DbType.Boolean, cRMBuyerBookSpaceEntity.IsLandOwner);
                db.AddInParameter(cmd, "@IsApprovedByManagement", DbType.Boolean, cRMBuyerBookSpaceEntity.IsApprovedByManagement);
                db.AddInParameter(cmd, "@BookingStatusID", DbType.Int64, cRMBuyerBookSpaceEntity.BookingStatusID);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMBuyerBookSpaceEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMBuyerBookSpaceEntity.IP);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMBuyerBookSpaceEntity.CreateDate);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMBuyerBookSpaceEntity.ImageUrl);

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

        IList<Int64> ICRMBuyerBookSpaceDataAccess.Add(IList<CRMBuyerBookSpaceEntity> cRMBuyerBookSpaceEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity in cRMBuyerBookSpaceEntityList)
            {
                returnCode = (this as ICRMBuyerBookSpaceDataAccess).Add(cRMBuyerBookSpaceEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMBuyerBookSpaceDataAccess.Update(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMBuyerBookSpaceEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMBuyerBookSpaceEntity, filterExpression, option);
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

        private Int64 Update(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBookSpace_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@BuyerBookSpaceID", DbType.Int64, cRMBuyerBookSpaceEntity.BuyerBookSpaceID);
                Database.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cRMBuyerBookSpaceEntity.ReferenceID);
                Database.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMBuyerBookSpaceEntity.ProjectID);
                Database.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cRMBuyerBookSpaceEntity.ProjectFloorUnitID);
                Database.AddInParameter(cmd, "@BookingNote", DbType.String, cRMBuyerBookSpaceEntity.BookingNote);
                Database.AddInParameter(cmd, "@IsLandOwner", DbType.Boolean, cRMBuyerBookSpaceEntity.IsLandOwner);
                Database.AddInParameter(cmd, "@IsApprovedByManagement", DbType.Boolean, cRMBuyerBookSpaceEntity.IsApprovedByManagement);
                Database.AddInParameter(cmd, "@BookingStatusID", DbType.Int64, cRMBuyerBookSpaceEntity.BookingStatusID);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMBuyerBookSpaceEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMBuyerBookSpaceEntity.IP);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMBuyerBookSpaceEntity.CreateDate);
                Database.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMBuyerBookSpaceEntity.ImageUrl);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMBuyerBookSpaceEntity already exists. Please specify another CRMBuyerBookSpaceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerBookSpaceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerBookSpaceEntity already exists. Please specify another CRMBuyerBookSpaceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBookSpace_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@BuyerBookSpaceID", DbType.Int64, cRMBuyerBookSpaceEntity.BuyerBookSpaceID);
                db.AddInParameter(cmd, "@ReferenceID", DbType.Int64, cRMBuyerBookSpaceEntity.ReferenceID);
                db.AddInParameter(cmd, "@ProjectID", DbType.Int64, cRMBuyerBookSpaceEntity.ProjectID);
                db.AddInParameter(cmd, "@ProjectFloorUnitID", DbType.Int64, cRMBuyerBookSpaceEntity.ProjectFloorUnitID);
                db.AddInParameter(cmd, "@BookingNote", DbType.String, cRMBuyerBookSpaceEntity.BookingNote);
                db.AddInParameter(cmd, "@IsLandOwner", DbType.Boolean, cRMBuyerBookSpaceEntity.IsLandOwner);
                db.AddInParameter(cmd, "@IsApprovedByManagement", DbType.Boolean, cRMBuyerBookSpaceEntity.IsApprovedByManagement);
                db.AddInParameter(cmd, "@BookingStatusID", DbType.Int64, cRMBuyerBookSpaceEntity.BookingStatusID);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMBuyerBookSpaceEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMBuyerBookSpaceEntity.IP);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMBuyerBookSpaceEntity.CreateDate);
                db.AddInParameter(cmd, "@ImageUrl", DbType.String, cRMBuyerBookSpaceEntity.ImageUrl);

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

        IList<Int64> ICRMBuyerBookSpaceDataAccess.Update(IList<CRMBuyerBookSpaceEntity> cRMBuyerBookSpaceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity in cRMBuyerBookSpaceEntityList)
            {
                returnCode = (this as ICRMBuyerBookSpaceDataAccess).Update(cRMBuyerBookSpaceEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMBuyerBookSpaceDataAccess.Delete(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMBuyerBookSpaceEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMBuyerBookSpaceEntity, filterExpression, option);
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

        private Int64 Delete(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBookSpace_SET";

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
                                throw new ArgumentException("CRMBuyerBookSpaceEntity already exists. Please specify another CRMBuyerBookSpaceEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMBuyerBookSpaceEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMBuyerBookSpaceEntity already exists. Please specify another CRMBuyerBookSpaceEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMBuyerBookSpace_SET";

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

        IList<Int64> ICRMBuyerBookSpaceDataAccess.Delete(IList<CRMBuyerBookSpaceEntity> cRMBuyerBookSpaceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMBuyerBookSpaceEntity cRMBuyerBookSpaceEntity in cRMBuyerBookSpaceEntityList)
            {
                returnCode = (this as ICRMBuyerBookSpaceDataAccess).Delete(cRMBuyerBookSpaceEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMBuyerBookSpaceEntity> ICRMBuyerBookSpaceDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMBuyerBookSpace_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMBuyerBookSpaceEntity> list = CreateEntityBuilder<CRMBuyerBookSpaceEntity>().BuildEntities(reader);

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

        DataTable ICRMBuyerBookSpaceDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMBuyerBookSpace_GET";

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
