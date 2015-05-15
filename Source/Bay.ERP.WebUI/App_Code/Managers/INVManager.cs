using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System;
using System.Linq;
using System.Linq.Expressions;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.BusinessEntities;

using System.Collections.Generic;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI.Manager
{
    public static class INVManager
    {
        #region Properties


        #endregion

        #region Methods

        #region Store

        public static Int64 CreateStore(INVStoreEntity ent)
        {
            Int64 storeID = 0;

            try
            {
                storeID = FCCINVStore.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
            }
            catch (Exception ex)
            {
            }

            return storeID;
        }

        public static Int64 CreateStore(Int64 projectID, Int64 departmentID, Int64 storeInChargeEmployeeID, String name, String storeTracNumber, String location, String description)
        {
            Int64 storeID = 0;

            try
            {
                INVStoreEntity ent = new INVStoreEntity();

                ent.ProjectID = projectID;
                ent.DepartmentID = departmentID;
                ent.StoreInChargeEmployeeID = storeInChargeEmployeeID;
                ent.Name = name;
                ent.StoreTrackNumber = storeTracNumber;
                ent.Location = location;
                ent.Description = description;
                ent.CreateDate = DateTime.Now;
                ent.IsRemoved = false;

                storeID = FCCINVStore.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
            }
            catch (Exception ex)
            {
            }

            return storeID;
        }

        public static Int64 UpdateStore(INVStoreEntity ent)
        {
            Int64 storeID = 0;

            try
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_StoreID, ent.StoreID.ToString(), SQLMatchType.Equal);

                storeID = FCCINVStore.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);
            }
            catch (Exception ex)
            {
            }

            return storeID;
        }

        public static Boolean DisableStore(Int64 storeID)
        {
            Boolean result = false;

            try
            {
                INVStoreEntity ent = INVManager.GetStoreByID(storeID);

                ent.IsRemoved = true;

                String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_StoreID, ent.StoreID.ToString(), SQLMatchType.Equal);

                storeID = FCCINVStore.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);

                result = true;
            }
            catch (Exception ex)
            {
            }

            return result;
        }

        public static Boolean EnableStore(Int64 storeID)
        {
            Boolean result = false;

            try
            {
                INVStoreEntity ent = INVManager.GetStoreByID(storeID);

                ent.IsRemoved = false;

                String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_StoreID, ent.StoreID.ToString(), SQLMatchType.Equal);

                storeID = FCCINVStore.GetFacadeCreate().Update(ent, fe, DatabaseOperationType.Update, TransactionRequired.No);

                result = true;
            }
            catch (Exception ex)
            {
            }

            return result;
        }

        public static INVStoreEntity GetStoreByID(Int64 storeID)
        {
            INVStoreEntity ent = new INVStoreEntity();

            try
            {
                ent = FCCINVStore.GetFacadeCreate().GetByID(storeID);
            }
            catch (Exception ex)
            {

            }

            return ent;
        }

        public static INVStoreEntity GetDefaultStore(Int64 projectID)
        {
            INVStoreEntity ent = new INVStoreEntity();

            try
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_IsDefault, "1", SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                IList<INVStoreEntity> lst = FCCINVStore.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    ent = lst[0];
                }
            }
            catch (Exception ex)
            {
            }

            return ent;
        }

        public static INVStore_DetailedEntity GetStoreDetailedByID(Int64 storeID)
        {
            INVStore_DetailedEntity ent = new INVStore_DetailedEntity();

            try
            {
                IList<INVStore_DetailedEntity> lst = new List<INVStore_DetailedEntity>();

                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression("INVStore." + INVStore_DetailedEntity.FLD_NAME_StoreID, storeID.ToString(), SQLMatchType.Equal);

                lst = FCCINVStore_Detailed.GetFacadeCreate().GetIL(1, 1, String.Empty, filterExpression);

                if (lst != null && lst.Count > 0)
                {
                    ent = lst[0];
                }
            }
            catch (Exception ex)
            {

            }

            return ent;
        }

        public static INVStoreEntity GetStoreByTracNumber(String tracNumber)
        {
            INVStoreEntity ent = new INVStoreEntity();

            try
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_StoreTrackNumber, tracNumber, SQLMatchType.Equal);

                IList<INVStoreEntity> lst = FCCINVStore.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    ent = lst[0];
                }
            }
            catch (Exception ex)
            {
            }

            return ent;
        }

        public static IList<INVStoreEntity> GetStoreByDepartmentID(Int64 departmentID)
        {
            IList<INVStoreEntity> lst = new List<INVStoreEntity>();

            try
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_DepartmentID, departmentID.ToString(), SQLMatchType.Equal);

                lst = FCCINVStore.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            }
            catch (Exception ex)
            {
            }

            return lst;
        }

        public static IList<INVStoreEntity> GetStoreByProjectID(Int64 projectID)
        {
            IList<INVStoreEntity> lst = new List<INVStoreEntity>();

            try
            {
                String fe = SqlExpressionBuilder.PrepareFilterExpression(INVStoreEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);

                lst = FCCINVStore.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);
            }
            catch (Exception ex)
            {
            }

            return lst;
        }

        public static IList<INVStore_DetailedEntity> GetAllStoresDetailed()
        {
            IList<INVStore_DetailedEntity> lst = new List<INVStore_DetailedEntity>();

            try
            {
                lst = FCCINVStore_Detailed.GetFacadeCreate().GetIL(1000000000, 1, String.Empty, String.Empty);
            }
            catch (Exception ex)
            {

            }

            return lst;
        }

        public static IList<INVStore_DetailedEntity> GetAllStoresDetailed(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression)
        {
            IList<INVStore_DetailedEntity> lst = new List<INVStore_DetailedEntity>();

            try
            {
                lst = FCCINVStore_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);
            }
            catch (Exception ex)
            {

            }

            return lst;
        }

        public static INVStoreEntity GetStoreByStoreUnitID(Int64 storeUnitID)
        {
            INVStoreEntity ent = new INVStoreEntity();

            try
            {
                INVStoreUnitEntity suEnt = FCCINVStoreUnit.GetFacadeCreate().GetByID(storeUnitID);

                ent = FCCINVStore.GetFacadeCreate().GetByID(suEnt.StoreID);
            }
            catch (Exception ex)
            {
            }

            return ent;
        }

        public static HREmployeeEntity GetStoreInCharge(Int64 storeID)
        {
            HREmployeeEntity ent = new HREmployeeEntity();

            try
            {
                INVStoreEntity store = FCCINVStore.GetFacadeCreate().GetByID(storeID);

                ent = FCCHREmployee.GetFacadeCreate().GetByID(store.StoreInChargeEmployeeID);
            }
            catch (Exception ex)
            {
            }

            return ent;
        }

        public static IList<INVStoreUnitItem_DetailedEntity> GetAllItemsInStore(Int64 storeID)
        {
            IList<INVStoreUnitItem_DetailedEntity> lst = new List<INVStoreUnitItem_DetailedEntity>();

            try
            {
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnit." + INVStoreUnitItem_DetailedEntity.FLD_NAME_INVStoreUnitStoreID, storeID.ToString(), SQLMatchType.Equal);

                lst = FCCINVStoreUnitItem_Detailed.GetFacadeCreate().GetIL(10000000, 1, String.Empty, filterExpression);
            }
            catch (Exception ex)
            {

            }

            return lst;
        }

        #endregion

        #region Store Unit

        public static Int64 CreateStoreUnit(INVStoreUnitEntity ent)
        {
            Int64 storeUnitID = 0;

            try
            {
                storeUnitID = FCCINVStoreUnit.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
            }
            catch (Exception ex)
            {
            }

            return storeUnitID;
        }

        public static Int64 CreateStoreUnit(Int64 storeID, Int64 inventoryStoreUnitID, String unitTrackNumber, String location, String description, Int64? parentStoreUnitID)
        {
            Int64 storeUnitID = 0;

            try
            {
                INVStoreUnitEntity ent = new INVStoreUnitEntity();

                ent.StoreID = storeID;
                ent.InventoryStoreUnitTypeID = inventoryStoreUnitID;
                ent.UnitTrackNumber = unitTrackNumber;
                ent.Location = location;
                ent.Description = description;
                ent.ParentStoreUnitID = parentStoreUnitID;

                storeUnitID = FCCINVStoreUnit.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
            }
            catch (Exception ex)
            {
            }

            return storeUnitID;
        }

        public static Int64 UpdateStoreUnit(INVStoreUnitEntity ent)
        {
            Int64 storeUnitID = 0;

            try
            {
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreUnitID, ent.StoreUnitID.ToString(), SQLMatchType.Equal);

                storeUnitID = FCCINVStoreUnit.GetFacadeCreate().Update(ent, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            }
            catch (Exception ex)
            {
            }

            return storeUnitID;
        }

        public static Boolean DisableStoreUnit(Int64 storeUnitID)
        {
            Boolean result = false;

            try
            {
                INVStoreUnitEntity ent = FCCINVStoreUnit.GetFacadeCreate().GetByID(storeUnitID);

                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreUnitID, ent.StoreUnitID.ToString(), SQLMatchType.Equal);

                ent.IsRemoved = true;

                storeUnitID = FCCINVStoreUnit.GetFacadeCreate().Update(ent, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            }
            catch (Exception ex)
            {
            }

            return result;
        }

        public static Boolean EnableStoreUnit(Int64 storeUnitID)
        {
            Boolean result = false;

            try
            {
                INVStoreUnitEntity ent = FCCINVStoreUnit.GetFacadeCreate().GetByID(storeUnitID);

                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreUnitID, ent.StoreUnitID.ToString(), SQLMatchType.Equal);

                ent.IsRemoved = false;

                storeUnitID = FCCINVStoreUnit.GetFacadeCreate().Update(ent, filterExpression, DatabaseOperationType.Update, TransactionRequired.No);
            }
            catch (Exception ex)
            {
            }

            return result;
        }

        public static INVStoreUnitEntity GetStoreUnitByID(Int64 storeUnitID)
        {
            INVStoreUnitEntity ent = new INVStoreUnitEntity();

            try
            {
                ent = FCCINVStoreUnit.GetFacadeCreate().GetByID(storeUnitID);
            }
            catch (Exception ex)
            {
            }

            return ent;
        }

        public static IList<INVStoreUnit_DetailedEntity> GetStoreUnitByStoreID(Int64 storeID)
        {
            IList<INVStoreUnit_DetailedEntity> lst = new List<INVStoreUnit_DetailedEntity>();

            try
            {
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnit." + INVStoreUnit_DetailedEntity.FLD_NAME_StoreID, storeID.ToString(), SQLMatchType.Equal);

                lst = FCCINVStoreUnit_Detailed.GetFacadeCreate().GetIL(10000000, 1, String.Empty, filterExpression);
            }
            catch (Exception ex)
            {

            }

            return lst;
        }

        public static IList<INVStoreUnitEntity> GetAllStoreUnit()
        {
            IList<INVStoreUnitEntity> lst = new List<INVStoreUnitEntity>();

            try
            {
                lst = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, String.Empty, String.Empty, DatabaseOperationType.Load);
            }
            catch (Exception ex)
            {

            }

            return lst;
        }

        public static IList<INVStoreUnit_DetailedEntity> GetAllStoreUnit_Detailed()
        {
            IList<INVStoreUnit_DetailedEntity> lst = new List<INVStoreUnit_DetailedEntity>();

            try
            {
                lst = FCCINVStoreUnit_Detailed.GetFacadeCreate().GetIL(10000000, 1, String.Empty, String.Empty);
            }
            catch (Exception ex)
            {

            }

            return lst;
        }

        public static IList<INVStoreUnit_DetailedEntity> GetAllStoreUnit_Detailed(Int32 pageSize, Int32 currentPage, String sortExpression, String filterExpression)
        {
            IList<INVStoreUnit_DetailedEntity> lst = new List<INVStoreUnit_DetailedEntity>();

            try
            {
                lst = FCCINVStoreUnit_Detailed.GetFacadeCreate().GetIL(pageSize, currentPage, sortExpression, filterExpression);
            }
            catch (Exception ex)
            {

            }

            return lst;
        }

        public static IList<INVStoreUnitEntity> GetStoreUnitByStoreInventoryStoreUnitID(Int64 inventoryStoreUnitID, Int64 storeID)
        {
            IList<INVStoreUnitEntity> lst = new List<INVStoreUnitEntity>();

            try
            {
                String filterExpression1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreID, storeID.ToString(), SQLMatchType.Equal);
                String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_InventoryStoreUnitTypeID, inventoryStoreUnitID.ToString(), SQLMatchType.Equal);
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

                lst = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);
            }
            catch (Exception ex)
            {

            }

            return lst;
        }

        public static INVStoreUnitEntity GetStoreUnitByUnitTrackNumber(String unitTrackNumber)
        {
            INVStoreUnitEntity ent = new INVStoreUnitEntity();

            try
            {
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_UnitTrackNumber, unitTrackNumber, SQLMatchType.Equal);

                IList<INVStoreUnitEntity> lst = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    ent = lst[0];
                }
            }
            catch (Exception ex)
            {

            }

            return ent;
        }

        public static INVStoreUnitEntity GetStoreUnitByLocation(String location)
        {
            INVStoreUnitEntity ent = new INVStoreUnitEntity();

            try
            {
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_Location, location, SQLMatchType.Equal);

                IList<INVStoreUnitEntity> lst = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    ent = lst[0];
                }
            }
            catch (Exception ex)
            {

            }

            return ent;
        }

        public static IList<INVStoreUnitEntity> GetStoreUnitByParentStoreUnitID(Int64 parentStoreUnitID)
        {
            IList<INVStoreUnitEntity> lst = new List<INVStoreUnitEntity>();

            try
            {
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_ParentStoreUnitID, parentStoreUnitID.ToString(), SQLMatchType.Equal);

                lst = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);
            }
            catch (Exception ex)
            {

            }

            return lst;
        }

        public static INVStoreUnitEntity GetDefaultStoreUnit(Int64 storeID)
        {
            INVStoreUnitEntity ent = new INVStoreUnitEntity();

            try
            {
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_StoreID, storeID.ToString(), SQLMatchType.Equal);
                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitEntity.FLD_NAME_IsDefault, "1", SQLMatchType.Equal);
                String fe = SqlExpressionBuilder.PrepareFilterExpression(fe1, SQLJoinType.AND, fe2);

                IList<INVStoreUnitEntity> lst = FCCINVStoreUnit.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

                if (lst != null && lst.Count > 0)
                {
                    ent = lst[0];
                }
            }
            catch (Exception ex)
            {
            }

            return ent;
        }

        #endregion

        #region MD Inventory Store Unit

        public static Int64 CreateMDInventoryStoreUnit(MDInventoryStoreUnitTypeEntity ent)
        {
            Int64 id = 0;

            try
            {
                id = FCCMDInventoryStoreUnitType.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);
            }
            catch (Exception ex)
            {

            }

            return id;
        }

        public static Boolean CreateMDInventoryStoreUnit(String name, String description, String iconPath)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean UpdateMDInventoryStoreUnit(MDInventoryStoreUnitTypeEntity ent)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean UpdateMDInventoryStoreUnitIconPath(Int64 mDInventoryStoreUnitID, String iconPath)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean DisableMDInventoryStoreUnit(Int64 mDInventoryStoreUnitID)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean EnableMDInventoryStoreUnit(Int64 mDInventoryStoreUnitID)
        {
            Boolean result = false;

            return result;
        }

        public static MDInventoryStoreUnitTypeEntity GetMDInventoryStoreUnitByID(Int64 mDInventoryStoreUnitID)
        {
            MDInventoryStoreUnitTypeEntity ent = new MDInventoryStoreUnitTypeEntity();

            return ent;
        }

        public static IList<MDInventoryStoreUnitTypeEntity> GetAllMDInventoryStoreUnit()
        {
            IList<MDInventoryStoreUnitTypeEntity> ent = new List<MDInventoryStoreUnitTypeEntity>();

            return ent;
        }

        #endregion

        #region Store Unit Item

        public static Boolean AddStoreUnitItem(INVStoreUnitItemEntity ent)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean AddStoreUnitItem(Int64 storeUnitID, Int64 itemID, Int64 brandID, Int64 regionID, Int64 countryID, Int64 unitCurrentStock)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean UpdateStoreUnitItem(INVStoreUnitItemEntity ent)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean UpdateStoreUnitItemCurrentStock(Int64 storeUnitID, Int64 unitCurrentStock)
        {
            Boolean result = false;

            return result;
        }

        public static INVStoreUnitItemEntity GetStoreUnitItemEntityByID(Int64 storeUnitItemID)
        {
            INVStoreUnitItemEntity ent = new INVStoreUnitItemEntity();

            return ent;
        }

        public static IList<INVStoreUnitItemEntity> GetAllStoreUnitItem()
        {
            IList<INVStoreUnitItemEntity> lst = new List<INVStoreUnitItemEntity>();

            return lst;
        }

        public static IList<INVStoreUnitItemEntity> GetStoreUnitItemUnitCurrentStock(Int64 storeUnitItemID)
        {
            IList<INVStoreUnitItemEntity> lst = new List<INVStoreUnitItemEntity>();

            return lst;
        }

        public static IList<INVStoreUnitItemEntity> GetStoreUnitItemUnitCurrentStock(Int64 storeUnitID, Int64 itemID)
        {
            IList<INVStoreUnitItemEntity> lst = new List<INVStoreUnitItemEntity>();

            return lst;
        }

        public static IList<INVStoreUnitItemEntity> GetStoreUnitItemsByStoreUnit(Int64 storeUnitID)
        {
            IList<INVStoreUnitItemEntity> lst = new List<INVStoreUnitItemEntity>();

            return lst;
        }

        public static IList<INVStoreUnitItemEntity> GetStoreUnitItemsByStore(Int64 storeID)
        {
            IList<INVStoreUnitItemEntity> lst = new List<INVStoreUnitItemEntity>();

            return lst;
        }

        public static Boolean DeleteStoreUnitItem(Int64 storeUnitItemID)
        {
            Boolean result = false;

            return result;
        }

        #endregion

        #region Current Stock

        public static Boolean CreateCurrentStock(INVCurrentStockEntity ent)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean CreateCurrentStock(Int64 itemID, Int64 brandID, Int64 regionID, Int64 countryID, Int64 unitCurrentStock)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean UpdateCurrentStock(INVCurrentStockEntity ent)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean UpdateCurrentStockUnitCurrentStock(Int64 currentStockID)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean UpdateCurrentStockUnitCurrentStockByItemID(Int64 itemID)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean DeleteCurrentStock(Int64 currentStockID)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean DeleteCurrentStockByItemID(Int64 itemID)
        {
            Boolean result = false;

            return result;
        }

        public static INVCurrentStockEntity GetCurrentStockByID(Int64 itemID)
        {
            INVCurrentStockEntity ent = new INVCurrentStockEntity();

            return ent;
        }

        public static INVCurrentStockEntity GetCurrentStockByItemID(Int64 itemID)
        {
            INVCurrentStockEntity ent = new INVCurrentStockEntity();

            return ent;
        }

        public static IList<INVCurrentStockEntity> GetAllCurrentStock()
        {
            IList<INVCurrentStockEntity> ent = new List<INVCurrentStockEntity>();

            return ent;
        }

        #endregion

        #region Transaction

        public static Boolean CreateTransaction(INVTransactionEntity ent)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean CreateTransaction(Int64 itemID, Int64 brandID, Int64 regionID, Int64 countryID, Int64 transactionQty, DateTime transactionDate, Boolean transactionDirection, String iPAddress, Int64 employeeID, Decimal unitPrice, String requisitionNumber, String wordOrderNumber, String mRRNumber, String billNumber)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean UpdateTransaction(INVTransactionEntity ent)
        {
            Boolean result = false;

            return result;
        }

        public static Boolean DeleteTransaction(INVTransactionEntity ent)
        {
            Boolean result = false;

            return result;
        }

        public static INVTransactionEntity GetTransactionsByID(Int64 transactionsID)
        {
            INVTransactionEntity ent = new INVTransactionEntity();

            return ent;
        }

        public static IList<INVTransactionEntity> GetAllTransactions()
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByItemID(Int64 itemID)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByIPAddress(String iPAddress)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByEmployeeID(Int64 employeeID)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByStoreID(Int64 storeID)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByStoreUnitID(Int64 storeUnitID)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByItemIDAndStoreID(Int64 itemID, Int64 storeID)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByItemIDAndStoreUnitID(Int64 itemID, Int64 storeUnitID)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByRequisitionNumber(String requisitionNumber)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByItemIDAndRequisitionNumber(Int64 itemID, String requisitionNumber)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByWordOrderNumber(String wordOrderNumber)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByItemIDAndWordOrderNumber(Int64 itemID, String wordOrderNumber)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByMRRNumber(String mRRNumber)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByItemIDAndMRRNumber(Int64 itemID, String mRRNumber)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByBillNumber(String billNumber)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetTransactionsByItemIDAndBillNumber(Int64 itemID, String billNumber)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetAllTransactionsByIsTransfer()
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        public static IList<INVTransactionEntity> GetAllTransactionsByIsTransferAndItemID(Int64 itemID)
        {
            IList<INVTransactionEntity> lst = new List<INVTransactionEntity>();

            return lst;
        }

        #endregion

        #region Business

        public static Boolean MakeDefaultStore(Int64 projectID, Int64 storeID)
        {
            Boolean result = false;

            try
            {
                FCCINV_MakeDefaultStore_Custom.GetFacadeCreate().GetIL(projectID, storeID);

                result = true;
            }
            catch(Exception ex)
            {
 
            }

            return result;
        }

        public static Boolean MakeDefaultStoreUnit(Int64 storeUnitID, Int64 storeID)
        {
            Boolean result = false;

            try
            {
                FCCINV_MakeDefaultStoreUnit_Custom.GetFacadeCreate().GetIL(storeUnitID, storeID);

                result = true;
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public static Boolean AddItemsToStoreUnit(Int64 itemID, Int64 brandID, Int64 regionID, Int64 countryID, String batchNumber, Int64 transactionQty, String iPAddress, Int64 employeeID, Decimal unitPrice, String requisitionNumber, String wordOrderNumber, String mRRNumber, String billNumber, Int64? projectID, Int64 storeID, Int64 storeUnitID)
        {
            Boolean result = false;

            try
            {
                AddItemsToStoreUnit(itemID, brandID, regionID, countryID, batchNumber, transactionQty, iPAddress, employeeID, unitPrice, requisitionNumber, wordOrderNumber, mRRNumber, billNumber, projectID, storeID, storeUnitID, false);
            
                result = true;
            }
            catch(Exception ex)
            {

            }

            return result;
        }

        public static Boolean AddItemsToStoreUnit(Int64 itemID, Int64 brandID, Int64 regionID, Int64 countryID, String batchNumber, Int64 transactionQty, String iPAddress, Int64 employeeID, Decimal unitPrice, String requisitionNumber, String wordOrderNumber, String mRRNumber, String billNumber, Int64? projectID, Int64 storeID, Int64 storeUnitID, Boolean isTransfer)
        {
            Boolean result = false;

            try
            {
                #region Tran

                INVTransactionEntity ent = new INVTransactionEntity();

                ent.ItemID = itemID;
                ent.BrandID = brandID;
                ent.RegionID = regionID;
                ent.CountryID = countryID;
                ent.BatchNumber = batchNumber;
                ent.TransactionQty = transactionQty;
                ent.TransactionDate = DateTime.Now;
                ent.TransactionDirection = true;
                ent.IPAddress = iPAddress;
                ent.EmployeeID = employeeID;
                ent.UnitPrice = unitPrice;
                ent.RequisitionNumber = requisitionNumber;
                ent.WordOrderNumber = wordOrderNumber;
                ent.MRRNumber = mRRNumber;
                ent.BillNumber = billNumber;
                ent.IsTransfer = isTransfer;
                ent.ProjectID = projectID;
                ent.StoreID = storeID;
                ent.StoreUnitID = storeUnitID;

                FCCINVTransaction.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

                #endregion


                #region Unit Item 

                String fe11  = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitItemEntity.FLD_NAME_ItemID, itemID.ToString(),SQLMatchType.Equal); 
                String fe12  = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitItemEntity.FLD_NAME_StoreUnitID, storeUnitID.ToString(),SQLMatchType.Equal); 
                String fe1  = SqlExpressionBuilder.PrepareFilterExpression(fe11, SQLJoinType.AND, fe12);
                IList<INVStoreUnitItemEntity> lst1 = FCCINVStoreUnitItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe1, DatabaseOperationType.LoadWithFilterExpression);

                if (lst1 != null && lst1.Count > 0)
                {
                    INVStoreUnitItemEntity ent1 = lst1[0];

                    ent1.UnitCurrentStock += transactionQty;

                    String fe_up1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitItemEntity.FLD_NAME_StoreUnitItemID, ent1.StoreUnitItemID.ToString(), SQLMatchType.Equal);

                    FCCINVStoreUnitItem.GetFacadeCreate().Update(ent1, fe_up1, DatabaseOperationType.Update, TransactionRequired.No);
                }
                else
                {
                    INVStoreUnitItemEntity ent1 = new INVStoreUnitItemEntity();

                    ent1.StoreUnitID = storeUnitID;
                    ent1.ItemID = itemID;
                    ent1.BrandID = brandID;
                    ent1.RegionID = regionID;
                    ent1.CountryID = countryID;
                    ent1.UnitCurrentStock = transactionQty;

                    FCCINVStoreUnitItem.GetFacadeCreate().Add(ent1, DatabaseOperationType.Add, TransactionRequired.No); 
                }

                #endregion


                #region Total Item

                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(INVCurrentStockEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);
                IList<INVCurrentStockEntity> lst2 = FCCINVCurrentStock.GetFacadeCreate().GetIL(null, null, String.Empty, fe2, DatabaseOperationType.LoadWithFilterExpression);

                if (lst2 != null && lst2.Count > 0)
                {
                    INVCurrentStockEntity ent2 = lst2[0];

                    ent2.UnitCurrentStock += transactionQty;

                    String fe_up2 = SqlExpressionBuilder.PrepareFilterExpression(INVCurrentStockEntity.FLD_NAME_CurrentStockID, ent2.CurrentStockID.ToString(), SQLMatchType.Equal);

                    FCCINVCurrentStock.GetFacadeCreate().Update(ent2, fe_up2, DatabaseOperationType.Update, TransactionRequired.No);
                }
                else
                {
                    INVCurrentStockEntity ent2 = new INVCurrentStockEntity();

                    ent2.ItemID = itemID;
                    ent2.BrandID = brandID;
                    ent2.RegionID = regionID;
                    ent2.CountryID = countryID;
                    ent2.UnitCurrentStock = transactionQty;

                    FCCINVCurrentStock.GetFacadeCreate().Add(ent2, DatabaseOperationType.Add, TransactionRequired.No);
                }

                #endregion


                result = true;
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public static Boolean RemoveItemsFromStoreUnit(Int64 itemID, Int64 brandID, Int64 regionID, Int64 countryID, String batchNumber, Int64 transactionQty, String iPAddress, Int64 employeeID, Decimal unitPrice, String requisitionNumber, String wordOrderNumber, String mRRNumber, String billNumber, Int64? projectID, Int64 storeID, Int64 storeUnitID)
        { 
            Boolean result = false;

            try
            {
                RemoveItemsFromStoreUnit(itemID, brandID, regionID, countryID, batchNumber, transactionQty, iPAddress, employeeID, unitPrice, requisitionNumber, wordOrderNumber, mRRNumber, billNumber, projectID, storeID, storeUnitID, false);

                result = true;
            }
            catch(Exception ex)
            {
            }

            return result;
        }

        public static Boolean RemoveItemsFromStoreUnit(Int64 itemID, Int64 brandID, Int64 regionID, Int64 countryID, String batchNumber, Int64 transactionQty, String iPAddress, Int64 employeeID, Decimal unitPrice, String requisitionNumber, String wordOrderNumber, String mRRNumber, String billNumber, Int64? projectID, Int64 storeID, Int64 storeUnitID, Boolean isTransfer)
        {
            Boolean result = false;

            try
            {
                #region Tran

                INVTransactionEntity ent = new INVTransactionEntity();

                ent.ItemID = itemID;
                ent.BrandID = brandID;
                ent.RegionID = regionID;
                ent.CountryID = countryID;
                ent.BatchNumber = batchNumber;
                ent.TransactionQty = transactionQty;
                ent.TransactionDate = DateTime.Now;
                ent.TransactionDirection = false;
                ent.IPAddress = iPAddress;
                ent.EmployeeID = employeeID;
                ent.UnitPrice = unitPrice;
                ent.RequisitionNumber = requisitionNumber;
                ent.WordOrderNumber = wordOrderNumber;
                ent.MRRNumber = mRRNumber;
                ent.BillNumber = billNumber;
                ent.IsTransfer = isTransfer;
                ent.ProjectID = projectID;
                ent.StoreID = storeID;
                ent.StoreUnitID = storeUnitID;

                FCCINVTransaction.GetFacadeCreate().Add(ent, DatabaseOperationType.Add, TransactionRequired.No);

                #endregion


                #region Unit Item

                String fe11 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitItemEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);
                String fe12 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitItemEntity.FLD_NAME_StoreUnitID, storeUnitID.ToString(), SQLMatchType.Equal);
                String fe1 = SqlExpressionBuilder.PrepareFilterExpression(fe11, SQLJoinType.AND, fe12);
                IList<INVStoreUnitItemEntity> lst1 = FCCINVStoreUnitItem.GetFacadeCreate().GetIL(null, null, String.Empty, fe1, DatabaseOperationType.LoadWithFilterExpression);

                if (lst1 != null && lst1.Count > 0)
                {
                    INVStoreUnitItemEntity ent1 = lst1[0];

                    //Rayan vaiya recommand to do this
                    //if (ent1.UnitCurrentStock - transactionQty > 0) ent1.UnitCurrentStock -= transactionQty;
                    //else
                    //{
                    //    return false;
                    //}
                    //This code skipped by rayan vaiya over phone - 22-Jul-13


                    ent1.UnitCurrentStock -= transactionQty;

                    String fe_up1 = SqlExpressionBuilder.PrepareFilterExpression(INVStoreUnitItemEntity.FLD_NAME_StoreUnitItemID, ent1.StoreUnitItemID.ToString(), SQLMatchType.Equal);

                    FCCINVStoreUnitItem.GetFacadeCreate().Update(ent1, fe_up1, DatabaseOperationType.Update, TransactionRequired.No);
                }
                else
                {
                    INVStoreUnitItemEntity ent1 = new INVStoreUnitItemEntity();

                    ent1.StoreUnitID = storeUnitID;
                    ent1.ItemID = itemID;
                    ent1.BrandID = brandID;
                    ent1.RegionID = regionID;
                    ent1.CountryID = countryID;
                    ent1.UnitCurrentStock = 0;
                    ent1.UnitCurrentStock -= transactionQty;

                    FCCINVStoreUnitItem.GetFacadeCreate().Add(ent1, DatabaseOperationType.Add, TransactionRequired.No);
                }

                #endregion


                #region Total Item

                String fe2 = SqlExpressionBuilder.PrepareFilterExpression(INVCurrentStockEntity.FLD_NAME_ItemID, itemID.ToString(), SQLMatchType.Equal);
                IList<INVCurrentStockEntity> lst2 = FCCINVCurrentStock.GetFacadeCreate().GetIL(null, null, String.Empty, fe2, DatabaseOperationType.LoadWithFilterExpression);

                if (lst2 != null && lst2.Count > 0)
                {
                    INVCurrentStockEntity ent2 = lst2[0];

                    ent2.UnitCurrentStock -= transactionQty;

                    String fe_up2 = SqlExpressionBuilder.PrepareFilterExpression(INVCurrentStockEntity.FLD_NAME_CurrentStockID, ent2.CurrentStockID.ToString(), SQLMatchType.Equal);

                    FCCINVCurrentStock.GetFacadeCreate().Update(ent2, fe_up2, DatabaseOperationType.Update, TransactionRequired.No);
                }
                else
                {
                    INVCurrentStockEntity ent2 = new INVCurrentStockEntity();

                    ent2.ItemID = itemID;
                    ent2.BrandID = brandID;
                    ent2.RegionID = regionID;
                    ent2.CountryID = countryID;
                    ent2.UnitCurrentStock = 0;
                    ent2.UnitCurrentStock -= transactionQty;

                    FCCINVCurrentStock.GetFacadeCreate().Add(ent2, DatabaseOperationType.Add, TransactionRequired.No);
                }

                #endregion


                result = true;
            }
            catch (Exception ex)
            {

            }

            return result;
        }

        public static Boolean TransferItems(Int64 itemID, Int64 brandID, Int64 regionID, Int64 countryID, String batchNumber, Int64 transactionQty, String iPAddress, Int64 employeeID, Decimal unitPrice, String requisitionNumber, String wordOrderNumber, String mRRNumber, String billNumber, Int64? projectID, Int64 transferFromStoreID, Int64 transferFromStoreUnitID, Int64 transferToStoreID, Int64 transferToStoreUnitID)
        {
            Boolean result = false;

            try
            {
                RemoveItemsFromStoreUnit(itemID, brandID, regionID, countryID, batchNumber, transactionQty, iPAddress, employeeID, unitPrice, requisitionNumber, wordOrderNumber, mRRNumber, billNumber, projectID, transferFromStoreID, transferFromStoreUnitID, true);
                AddItemsToStoreUnit(itemID, brandID, regionID, countryID, batchNumber, transactionQty, iPAddress, employeeID, unitPrice, requisitionNumber, wordOrderNumber, mRRNumber, billNumber, projectID, transferToStoreID, transferToStoreUnitID, true);

                result = true;
            }
            catch (Exception ex)
            { 
            }

            return result;
        }

        #endregion

        #endregion
    }
}