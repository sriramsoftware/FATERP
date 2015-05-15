// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 03-Apr-2013, 03:04:35




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
    internal sealed partial class CRMLandBasicInfoDataAccess : BaseDataAccess, ICRMLandBasicInfoDataAccess
    {
        #region Constructors

        public CRMLandBasicInfoDataAccess(Context context)
            : base(context)
        {
        }

        protected override IEntityBuilder<CRMLandBasicInfoEntity> CreateEntityBuilder<CRMLandBasicInfoEntity>()
        {
            return (new CRMLandBasicInfoBuilder()) as IEntityBuilder<CRMLandBasicInfoEntity>;
        }

        #endregion

        #region Add Operation

        Int64 ICRMLandBasicInfoDataAccess.Add(CRMLandBasicInfoEntity cRMLandBasicInfoEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Add(cRMLandBasicInfoEntity, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = AddTran(cRMLandBasicInfoEntity, option);
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

        private Int64 Add(CRMLandBasicInfoEntity cRMLandBasicInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandBasicInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddNullPrimaryKeyParameter(cmd, "LandBasicInfoID");

                Database.AddInParameter(cmd, "@LandOwnerTypeID", DbType.Int64, cRMLandBasicInfoEntity.LandOwnerTypeID);	
                Database.AddInParameter(cmd, "@ContactFullName", DbType.String, cRMLandBasicInfoEntity.ContactFullName);	
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, cRMLandBasicInfoEntity.MobileNo);	
                Database.AddInParameter(cmd, "@LandPhone", DbType.String, cRMLandBasicInfoEntity.LandPhone);	
                Database.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMLandBasicInfoEntity.PresentAddress);	
                Database.AddInParameter(cmd, "@Email", DbType.String, cRMLandBasicInfoEntity.Email);	
                Database.AddInParameter(cmd, "@InterestedLandLocationID", DbType.Int64, cRMLandBasicInfoEntity.InterestedLandLocationID);	
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, cRMLandBasicInfoEntity.CityID);	
                Database.AddInParameter(cmd, "@LandArea1", DbType.String, cRMLandBasicInfoEntity.LandArea1);	
                Database.AddInParameter(cmd, "@AreaUnitID1", DbType.Int64, cRMLandBasicInfoEntity.AreaUnitID1);	
                Database.AddInParameter(cmd, "@LandArea2", DbType.String, cRMLandBasicInfoEntity.LandArea2);	
                Database.AddInParameter(cmd, "@AreaUnitID2", DbType.Int64, cRMLandBasicInfoEntity.AreaUnitID2);	
                Database.AddInParameter(cmd, "@PlotNumber", DbType.String, cRMLandBasicInfoEntity.PlotNumber);	
                Database.AddInParameter(cmd, "@PlotAddress", DbType.String, cRMLandBasicInfoEntity.PlotAddress);	
                Database.AddInParameter(cmd, "@PlotMapUrl", DbType.String, cRMLandBasicInfoEntity.PlotMapUrl);	
                Database.AddInParameter(cmd, "@Area", DbType.String, cRMLandBasicInfoEntity.Area);	
                Database.AddInParameter(cmd, "@Dimension", DbType.String, cRMLandBasicInfoEntity.Dimension);	
                Database.AddInParameter(cmd, "@SpecialFeatures", DbType.String, cRMLandBasicInfoEntity.SpecialFeatures);	
                Database.AddInParameter(cmd, "@Structure", DbType.String, cRMLandBasicInfoEntity.Structure);	
                Database.AddInParameter(cmd, "@RAJUKDetails", DbType.String, cRMLandBasicInfoEntity.RAJUKDetails);	
                Database.AddInParameter(cmd, "@LeadGeneratedByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadGeneratedByEmployeeID);	
                Database.AddInParameter(cmd, "@LeadManagedByOneEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadManagedByOneEmployeeID);	
                Database.AddInParameter(cmd, "@LeadManagedByTwoEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadManagedByTwoEmployeeID);	
                Database.AddInParameter(cmd, "@LeadConversionDate", DbType.DateTime, cRMLandBasicInfoEntity.LeadConversionDate);	
                Database.AddInParameter(cmd, "@ReferredByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.ReferredByEmployeeID);	
                Database.AddInParameter(cmd, "@LandOwnerOfProject", DbType.Int64, cRMLandBasicInfoEntity.LandOwnerOfProject);	
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.CreatedByEmployeeID);	
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMLandBasicInfoEntity.IP);	
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMLandBasicInfoEntity.CreateDate);	

				using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMLandBasicInfoEntity already exists. Please specify another CRMLandBasicInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMLandBasicInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMLandBasicInfoEntity already exists. Please specify another CRMLandBasicInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 AddTran(CRMLandBasicInfoEntity cRMLandBasicInfoEntity, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandBasicInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();

            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db);
                AddNullPrimaryKeyParameter(cmd, "LandBasicInfoID", db);

                db.AddInParameter(cmd, "@LandOwnerTypeID", DbType.Int64, cRMLandBasicInfoEntity.LandOwnerTypeID);
                db.AddInParameter(cmd, "@ContactFullName", DbType.String, cRMLandBasicInfoEntity.ContactFullName);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, cRMLandBasicInfoEntity.MobileNo);
                db.AddInParameter(cmd, "@LandPhone", DbType.String, cRMLandBasicInfoEntity.LandPhone);
                db.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMLandBasicInfoEntity.PresentAddress);
                db.AddInParameter(cmd, "@Email", DbType.String, cRMLandBasicInfoEntity.Email);
                db.AddInParameter(cmd, "@InterestedLandLocationID", DbType.Int64, cRMLandBasicInfoEntity.InterestedLandLocationID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, cRMLandBasicInfoEntity.CityID);
                db.AddInParameter(cmd, "@LandArea1", DbType.String, cRMLandBasicInfoEntity.LandArea1);
                db.AddInParameter(cmd, "@AreaUnitID1", DbType.Int64, cRMLandBasicInfoEntity.AreaUnitID1);
                db.AddInParameter(cmd, "@LandArea2", DbType.String, cRMLandBasicInfoEntity.LandArea2);
                db.AddInParameter(cmd, "@AreaUnitID2", DbType.Int64, cRMLandBasicInfoEntity.AreaUnitID2);
                db.AddInParameter(cmd, "@PlotNumber", DbType.String, cRMLandBasicInfoEntity.PlotNumber);
                db.AddInParameter(cmd, "@PlotAddress", DbType.String, cRMLandBasicInfoEntity.PlotAddress);
                db.AddInParameter(cmd, "@PlotMapUrl", DbType.String, cRMLandBasicInfoEntity.PlotMapUrl);
                db.AddInParameter(cmd, "@Area", DbType.String, cRMLandBasicInfoEntity.Area);
                db.AddInParameter(cmd, "@Dimension", DbType.String, cRMLandBasicInfoEntity.Dimension);
                db.AddInParameter(cmd, "@SpecialFeatures", DbType.String, cRMLandBasicInfoEntity.SpecialFeatures);
                db.AddInParameter(cmd, "@Structure", DbType.String, cRMLandBasicInfoEntity.Structure);
                db.AddInParameter(cmd, "@RAJUKDetails", DbType.String, cRMLandBasicInfoEntity.RAJUKDetails);
                db.AddInParameter(cmd, "@LeadGeneratedByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadGeneratedByEmployeeID);
                db.AddInParameter(cmd, "@LeadManagedByOneEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadManagedByOneEmployeeID);
                db.AddInParameter(cmd, "@LeadManagedByTwoEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadManagedByTwoEmployeeID);
                db.AddInParameter(cmd, "@LeadConversionDate", DbType.DateTime, cRMLandBasicInfoEntity.LeadConversionDate);
                db.AddInParameter(cmd, "@ReferredByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.ReferredByEmployeeID);
                db.AddInParameter(cmd, "@LandOwnerOfProject", DbType.Int64, cRMLandBasicInfoEntity.LandOwnerOfProject);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMLandBasicInfoEntity.IP);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMLandBasicInfoEntity.CreateDate);

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

        IList<Int64> ICRMLandBasicInfoDataAccess.Add(IList<CRMLandBasicInfoEntity> cRMLandBasicInfoEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99; 

            foreach (CRMLandBasicInfoEntity cRMLandBasicInfoEntity in cRMLandBasicInfoEntityList)
            {
                returnCode = (this as ICRMLandBasicInfoDataAccess).Add(cRMLandBasicInfoEntity, option, reqTran); 

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Add List Operation

        #region Update Operation

        Int64 ICRMLandBasicInfoDataAccess.Update(CRMLandBasicInfoEntity cRMLandBasicInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Update(cRMLandBasicInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = UpdateTran(cRMLandBasicInfoEntity, filterExpression, option);
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

        private Int64 Update(CRMLandBasicInfoEntity cRMLandBasicInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandBasicInfo_SET";

            using (DbCommand cmd = Database.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option);
                AddOutputParameter(cmd);
                AddFilterExpressionParameter(cmd, filterExpression);

                Database.AddInParameter(cmd, "@LandBasicInfoID", DbType.Int64, cRMLandBasicInfoEntity.LandBasicInfoID);
                Database.AddInParameter(cmd, "@LandOwnerTypeID", DbType.Int64, cRMLandBasicInfoEntity.LandOwnerTypeID);
                Database.AddInParameter(cmd, "@ContactFullName", DbType.String, cRMLandBasicInfoEntity.ContactFullName);
                Database.AddInParameter(cmd, "@MobileNo", DbType.String, cRMLandBasicInfoEntity.MobileNo);
                Database.AddInParameter(cmd, "@LandPhone", DbType.String, cRMLandBasicInfoEntity.LandPhone);
                Database.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMLandBasicInfoEntity.PresentAddress);
                Database.AddInParameter(cmd, "@Email", DbType.String, cRMLandBasicInfoEntity.Email);
                Database.AddInParameter(cmd, "@InterestedLandLocationID", DbType.Int64, cRMLandBasicInfoEntity.InterestedLandLocationID);
                Database.AddInParameter(cmd, "@CityID", DbType.Int64, cRMLandBasicInfoEntity.CityID);
                Database.AddInParameter(cmd, "@LandArea1", DbType.String, cRMLandBasicInfoEntity.LandArea1);
                Database.AddInParameter(cmd, "@AreaUnitID1", DbType.Int64, cRMLandBasicInfoEntity.AreaUnitID1);
                Database.AddInParameter(cmd, "@LandArea2", DbType.String, cRMLandBasicInfoEntity.LandArea2);
                Database.AddInParameter(cmd, "@AreaUnitID2", DbType.Int64, cRMLandBasicInfoEntity.AreaUnitID2);
                Database.AddInParameter(cmd, "@PlotNumber", DbType.String, cRMLandBasicInfoEntity.PlotNumber);
                Database.AddInParameter(cmd, "@PlotAddress", DbType.String, cRMLandBasicInfoEntity.PlotAddress);
                Database.AddInParameter(cmd, "@PlotMapUrl", DbType.String, cRMLandBasicInfoEntity.PlotMapUrl);
                Database.AddInParameter(cmd, "@Area", DbType.String, cRMLandBasicInfoEntity.Area);
                Database.AddInParameter(cmd, "@Dimension", DbType.String, cRMLandBasicInfoEntity.Dimension);
                Database.AddInParameter(cmd, "@SpecialFeatures", DbType.String, cRMLandBasicInfoEntity.SpecialFeatures);
                Database.AddInParameter(cmd, "@Structure", DbType.String, cRMLandBasicInfoEntity.Structure);
                Database.AddInParameter(cmd, "@RAJUKDetails", DbType.String, cRMLandBasicInfoEntity.RAJUKDetails);
                Database.AddInParameter(cmd, "@LeadGeneratedByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadGeneratedByEmployeeID);
                Database.AddInParameter(cmd, "@LeadManagedByOneEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadManagedByOneEmployeeID);
                Database.AddInParameter(cmd, "@LeadManagedByTwoEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadManagedByTwoEmployeeID);
                Database.AddInParameter(cmd, "@LeadConversionDate", DbType.DateTime, cRMLandBasicInfoEntity.LeadConversionDate);
                Database.AddInParameter(cmd, "@ReferredByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.ReferredByEmployeeID);
                Database.AddInParameter(cmd, "@LandOwnerOfProject", DbType.Int64, cRMLandBasicInfoEntity.LandOwnerOfProject);
                Database.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.CreatedByEmployeeID);
                Database.AddInParameter(cmd, "@IP", DbType.String, cRMLandBasicInfoEntity.IP);
                Database.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMLandBasicInfoEntity.CreateDate);

                using (IDataReader reader = Database.ExecuteReader(cmd))
                {
                    returnCode = GetReturnCodeFromParameter(cmd);

                    switch (returnCode)
                    {
                        case SqlConstants.DB_STATUS_CODE_DATAALREADYEXIST:
                            {
                                throw new ArgumentException("CRMLandBasicInfoEntity already exists. Please specify another CRMLandBasicInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMLandBasicInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMLandBasicInfoEntity already exists. Please specify another CRMLandBasicInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 UpdateTran(CRMLandBasicInfoEntity cRMLandBasicInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandBasicInfo_SET";

            Database db = DatabaseFactory.CreateDatabase();
            
            using (DbCommand cmd = db.GetStoredProcCommand(SP))
            {
                AddOptionParameter(cmd, option, db);
                AddOutputParameter(cmd, db); 
                AddFilterExpressionParameter(cmd, filterExpression, db);

                db.AddInParameter(cmd, "@LandBasicInfoID", DbType.Int64, cRMLandBasicInfoEntity.LandBasicInfoID);
                db.AddInParameter(cmd, "@LandOwnerTypeID", DbType.Int64, cRMLandBasicInfoEntity.LandOwnerTypeID);
                db.AddInParameter(cmd, "@ContactFullName", DbType.String, cRMLandBasicInfoEntity.ContactFullName);
                db.AddInParameter(cmd, "@MobileNo", DbType.String, cRMLandBasicInfoEntity.MobileNo);
                db.AddInParameter(cmd, "@LandPhone", DbType.String, cRMLandBasicInfoEntity.LandPhone);
                db.AddInParameter(cmd, "@PresentAddress", DbType.String, cRMLandBasicInfoEntity.PresentAddress);
                db.AddInParameter(cmd, "@Email", DbType.String, cRMLandBasicInfoEntity.Email);
                db.AddInParameter(cmd, "@InterestedLandLocationID", DbType.Int64, cRMLandBasicInfoEntity.InterestedLandLocationID);
                db.AddInParameter(cmd, "@CityID", DbType.Int64, cRMLandBasicInfoEntity.CityID);
                db.AddInParameter(cmd, "@LandArea1", DbType.String, cRMLandBasicInfoEntity.LandArea1);
                db.AddInParameter(cmd, "@AreaUnitID1", DbType.Int64, cRMLandBasicInfoEntity.AreaUnitID1);
                db.AddInParameter(cmd, "@LandArea2", DbType.String, cRMLandBasicInfoEntity.LandArea2);
                db.AddInParameter(cmd, "@AreaUnitID2", DbType.Int64, cRMLandBasicInfoEntity.AreaUnitID2);
                db.AddInParameter(cmd, "@PlotNumber", DbType.String, cRMLandBasicInfoEntity.PlotNumber);
                db.AddInParameter(cmd, "@PlotAddress", DbType.String, cRMLandBasicInfoEntity.PlotAddress);
                db.AddInParameter(cmd, "@PlotMapUrl", DbType.String, cRMLandBasicInfoEntity.PlotMapUrl);
                db.AddInParameter(cmd, "@Area", DbType.String, cRMLandBasicInfoEntity.Area);
                db.AddInParameter(cmd, "@Dimension", DbType.String, cRMLandBasicInfoEntity.Dimension);
                db.AddInParameter(cmd, "@SpecialFeatures", DbType.String, cRMLandBasicInfoEntity.SpecialFeatures);
                db.AddInParameter(cmd, "@Structure", DbType.String, cRMLandBasicInfoEntity.Structure);
                db.AddInParameter(cmd, "@RAJUKDetails", DbType.String, cRMLandBasicInfoEntity.RAJUKDetails);
                db.AddInParameter(cmd, "@LeadGeneratedByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadGeneratedByEmployeeID);
                db.AddInParameter(cmd, "@LeadManagedByOneEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadManagedByOneEmployeeID);
                db.AddInParameter(cmd, "@LeadManagedByTwoEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.LeadManagedByTwoEmployeeID);
                db.AddInParameter(cmd, "@LeadConversionDate", DbType.DateTime, cRMLandBasicInfoEntity.LeadConversionDate);
                db.AddInParameter(cmd, "@ReferredByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.ReferredByEmployeeID);
                db.AddInParameter(cmd, "@LandOwnerOfProject", DbType.Int64, cRMLandBasicInfoEntity.LandOwnerOfProject);
                db.AddInParameter(cmd, "@CreatedByEmployeeID", DbType.Int64, cRMLandBasicInfoEntity.CreatedByEmployeeID);
                db.AddInParameter(cmd, "@IP", DbType.String, cRMLandBasicInfoEntity.IP);
                db.AddInParameter(cmd, "@CreateDate", DbType.DateTime, cRMLandBasicInfoEntity.CreateDate);

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

        IList<Int64> ICRMLandBasicInfoDataAccess.Update(IList<CRMLandBasicInfoEntity> cRMLandBasicInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            Int64 returnCode = -99;

            foreach (CRMLandBasicInfoEntity cRMLandBasicInfoEntity in cRMLandBasicInfoEntityList)
            {
                returnCode = (this as ICRMLandBasicInfoDataAccess).Update(cRMLandBasicInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }

        #endregion Update List Operation
        
        #region Delete Operation

        Int64 ICRMLandBasicInfoDataAccess.Delete(CRMLandBasicInfoEntity cRMLandBasicInfoEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            try
            {
                long retValues = -99;

                switch (reqTran)
                {
                    case TransactionRequired.No:
                        {
                            retValues = Delete(cRMLandBasicInfoEntity, filterExpression, option);
                            break;
                        }
                    case TransactionRequired.Yes:
                        {
                            retValues = DeleteTran(cRMLandBasicInfoEntity, filterExpression, option);
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

        private Int64 Delete(CRMLandBasicInfoEntity cRMLandBasicInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandBasicInfo_SET";

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
                                throw new ArgumentException("CRMLandBasicInfoEntity already exists. Please specify another CRMLandBasicInfoEntity.");
                            }
                        case SqlConstants.DB_STATUS_CODE_DATAUPDATEDFROMOTHERSESSION:
                            {
                                throw new ArgumentException("CRMLandBasicInfoEntity data already updated from different session.");
                            }
                        case SqlConstants.DB_STATUS_CODE_FAIL_OPERATION:
                            {
                                throw new ArgumentException("CRMLandBasicInfoEntity already exists. Please specify another CRMLandBasicInfoEntity.");
                            }
                    }
                }
            }

            return returnCode;
        }

        private Int64 DeleteTran(CRMLandBasicInfoEntity cRMLandBasicInfoEntity, String filterExpression, DatabaseOperationType option)
        {
            long returnCode = -99;
            const string SP = "dbo.CRMLandBasicInfo_SET";

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

        IList<Int64> ICRMLandBasicInfoDataAccess.Delete(IList<CRMLandBasicInfoEntity> cRMLandBasicInfoEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            IList<Int64> returnCodeList = new List<Int64>(); 

            long returnCode = -99;

            foreach (CRMLandBasicInfoEntity cRMLandBasicInfoEntity in cRMLandBasicInfoEntityList)
            {
                returnCode = (this as ICRMLandBasicInfoDataAccess).Delete(cRMLandBasicInfoEntity, filterExpression, option, reqTran);

                returnCodeList.Add(returnCode); 
            }

            return returnCodeList;
        }      

        #endregion Delete List Operation
        
        #region GetAll

        IList<CRMLandBasicInfoEntity> ICRMLandBasicInfoDataAccess.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMLandBasicInfo_GET";

                using (DbCommand cmd = Database.GetStoredProcCommand(SP))
                {
                    AddOptionParameter(cmd, option);
                    AddPageSizeParameter(cmd, pageSize);
                    AddCurrentPageParameter(cmd, currentPage);                
                    AddSortExpressionParameter(cmd, sortExpression);
                    AddFilterExpressionParameter(cmd, filterExpression);

                    using (IDataReader reader = Database.ExecuteReader(cmd))
                    {
                        IList<CRMLandBasicInfoEntity> list = CreateEntityBuilder<CRMLandBasicInfoEntity>().BuildEntities(reader);

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

        DataTable ICRMLandBasicInfoDataAccess.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            try
            {
                const string SP = "dbo.CRMLandBasicInfo_GET";

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
