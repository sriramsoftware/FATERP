using System;
using System.Collections.Generic;
using System.Web.Services;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

using System.Linq;
using AjaxControlToolkit;
using Bay.ERP.Web.UI;




/// <summary>
/// Summary description for AutoCompleteTRF
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
 [System.Web.Script.Services.ScriptService]
public class AutoCompleteTRF : System.Web.Services.WebService {

    //public class PreBOQItemComparer : IEqualityComparer<PRMPreBOQDetail_DetailedCustomEntity>
    //{
    //    public bool Equals(PRMPreBOQDetail_DetailedCustomEntity x, PRMPreBOQDetail_DetailedCustomEntity y)
    //    {
    //        return (x.ItemID.Equals(y.ItemID));
    //    }

    //    public int GetHashCode(PRMPreBOQDetail_DetailedCustomEntity obj)
    //    {
    //        return obj.ItemID.GetHashCode();
    //    }
    //}

    //public class BOQItemComparer : IEqualityComparer<PRMBOQDetail_DetailedCustomEntity>
    //{
    //    public bool Equals(PRMBOQDetail_DetailedCustomEntity x, PRMBOQDetail_DetailedCustomEntity y)
    //    {
    //        return (x.ItemID.Equals(y.ItemID));
    //    }

    //    public int GetHashCode(PRMBOQDetail_DetailedCustomEntity obj)
    //    {
    //        return obj.ItemID.GetHashCode();
    //    }
    //}

    public class INVStoreUnitItemComparer : IEqualityComparer<INVStoreUnitItem_DetailedEntity>
    {
        public bool Equals(INVStoreUnitItem_DetailedEntity x, INVStoreUnitItem_DetailedEntity y)
        {
            return (x.ItemID.Equals(y.ItemID));
        }

        public int GetHashCode(INVStoreUnitItem_DetailedEntity obj)
        {
            return obj.ItemID.GetHashCode();
        }
    }

    public AutoCompleteTRF () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string[] GetCompletionItemList(string prefixText, int count, string contextKey)
    {

        #region GET ITEM

        Int64 storeUnitID;
        Int64.TryParse(contextKey.ToString(), out storeUnitID);
        List<string> items = new List<string>(count);

        #region Store Unit Item


        String fe = SqlExpressionBuilder.PrepareFilterExpression("INVStoreUnit.StoreID", storeUnitID.ToString(), SQLMatchType.LikeWithSuffixMath);
            String fePrefix = SqlExpressionBuilder.PrepareFilterExpression("MDItem.ItemName", prefixText, SQLMatchType.LikeWithSuffixMath);
            fePrefix = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, fePrefix);
            IList<INVStoreUnitItem_DetailedEntity> itemListBySuffix = FCCINVStoreUnitItem_Detailed.GetFacadeCreate().GetIL(1000000, 1,String.Empty, fePrefix);
            String feBothfix = SqlExpressionBuilder.PrepareFilterExpression("MDItem.ItemName", prefixText, SQLMatchType.LikeWithBothMath);
            feBothfix = SqlExpressionBuilder.PrepareFilterExpression(fe, SQLJoinType.AND, feBothfix);
            IList<INVStoreUnitItem_DetailedEntity> itemListByBoth = FCCINVStoreUnitItem_Detailed.GetFacadeCreate().GetIL(1000000, 1, String.Empty, feBothfix);

            if (itemListBySuffix == null || itemListBySuffix.Count <= 0)
            {
                itemListBySuffix = new List<INVStoreUnitItem_DetailedEntity>();
            }

            if (itemListByBoth == null || itemListByBoth.Count <= 0)
            {
                itemListByBoth = new List<INVStoreUnitItem_DetailedEntity>();
            }

            IList<INVStoreUnitItem_DetailedEntity> tempBOQItemList = itemListByBoth.Except(itemListBySuffix, new INVStoreUnitItemComparer()).ToList();
            IList<INVStoreUnitItem_DetailedEntity> itemList = new List<INVStoreUnitItem_DetailedEntity>();

            itemList = itemListBySuffix;

            if (tempBOQItemList != null && tempBOQItemList.Count > 0)
            {
                foreach (INVStoreUnitItem_DetailedEntity ent in tempBOQItemList)
                {
                    itemList.Add(ent);
                }
            }

            if (itemList != null && itemList.Count > 0)
            {
                foreach (INVStoreUnitItem_DetailedEntity entItem in itemList)
                {
                    if (prefixText.Equals(entItem.MDItemItemName))
                    {
                        return new string[0];
                    }

                    items.Add(AutoCompleteExtender.CreateAutoCompleteItem(entItem.MDItemItemName.ToString(), entItem.ItemID.ToString()));
                }
            }
            else
            {
                items.Add(AutoCompleteExtender.CreateAutoCompleteItem("No Items Available", "0"));
            }
     

        #endregion

        //if (projectID > 0 && projectID != MasterDataConstants.Project.DEFAULT_PROJECT)
        //{
        //    String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);
        //    IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

        //    if (preBOQList != null && preBOQList.Count > 0)
        //    {
        //        Int64 preBOQID = preBOQList[0].PreBOQID;

        //        switch (preBOQList[0].IsLocked)
        //        {
        //            case true:
        //                #region GET Item From BOQ

        //                String feBOQSufix1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetail_DetailedCustomEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
        //                String feBOQSuffix2 = SqlExpressionBuilder.PrepareFilterExpression("MDItem." + PRMPreBOQDetail_DetailedCustomEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithSuffixMath);
        //                String fiterExpressionBysuffix = SqlExpressionBuilder.PrepareFilterExpression(feBOQSufix1, SQLJoinType.AND, feBOQSuffix2);
        //                IList<PRMBOQDetail_DetailedCustomEntity> prmBOQDetailListBySuffix = FCCPRMBOQDetail_DetailedCustom.GetFacadeCreate().GetIL(fiterExpressionBysuffix);

        //                String feBothBOQ = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetail_DetailedCustomEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
        //                String feBOQBoth = SqlExpressionBuilder.PrepareFilterExpression("MDItem." + MDItemEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithBothMath);
        //                String filterExpressionBoth = SqlExpressionBuilder.PrepareFilterExpression(feBothBOQ, SQLJoinType.AND, feBOQBoth);
        //                IList<PRMBOQDetail_DetailedCustomEntity> prmBOQDetailListByBoth = FCCPRMBOQDetail_DetailedCustom.GetFacadeCreate().GetIL(filterExpressionBoth);

        //                if (prmBOQDetailListBySuffix == null || prmBOQDetailListBySuffix.Count <= 0)
        //                {
        //                    prmBOQDetailListBySuffix = new List<PRMBOQDetail_DetailedCustomEntity>();
        //                }

        //                if (prmBOQDetailListByBoth == null || prmBOQDetailListByBoth.Count <= 0)
        //                {
        //                    prmBOQDetailListByBoth = new List<PRMBOQDetail_DetailedCustomEntity>();
        //                }

        //                IList<PRMBOQDetail_DetailedCustomEntity> tempBOQItemList = prmBOQDetailListByBoth.Except(prmBOQDetailListBySuffix, new BOQItemComparer()).ToList();
        //                IList<PRMBOQDetail_DetailedCustomEntity> BOQItemList = new List<PRMBOQDetail_DetailedCustomEntity>();

        //                BOQItemList = prmBOQDetailListBySuffix;

        //                if (tempBOQItemList != null && tempBOQItemList.Count > 0)
        //                {
        //                    foreach (PRMBOQDetail_DetailedCustomEntity ent in tempBOQItemList)
        //                    {
        //                        //If Zero Qty is not need to show or We can manage it From DB
        //                        //if (ent.TotalQty > 0)
        //                        //{
        //                        BOQItemList.Add(ent);
        //                        //}
        //                    }
        //                }

        //                if (BOQItemList != null && BOQItemList.Count > 0)
        //                {
        //                    foreach (PRMBOQDetail_DetailedCustomEntity entItem in BOQItemList)
        //                    {

        //                        if (prefixText.Equals(entItem.ItemName))
        //                        {
        //                            return new string[0];
        //                        }

        //                        items.Add(AutoCompleteExtender.CreateAutoCompleteItem(entItem.ItemName.ToString(), entItem.ItemID.ToString()));
        //                    }
        //                }
        //                else
        //                {
        //                    items.Add(AutoCompleteExtender.CreateAutoCompleteItem("No Items Available", "0"));
        //                }

        //                #endregion
        //                break;

        //            case false:
        //                #region Get Item From Pre-BOQ

        //                String fePreBOQSufix1 = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQDetail." + PRMPreBOQDetail_DetailedCustomEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
        //                String fePreBOQSufix2 = SqlExpressionBuilder.PrepareFilterExpression("MDItem." + PRMPreBOQDetail_DetailedCustomEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithSuffixMath);
        //                String filterExpressionSuffix = SqlExpressionBuilder.PrepareFilterExpression(fePreBOQSufix1, SQLJoinType.AND, fePreBOQSufix2);
        //                IList<PRMPreBOQDetail_DetailedCustomEntity> preBOQDetailListBySuffix = FCCPRMPreBOQDetail_DetailedCustom.GetFacadeCreate().GetIL(filterExpressionSuffix);

        //                String feBothPreBOQ = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQDetail." + PRMPreBOQDetail_DetailedCustomEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
        //                String feBoth1 = SqlExpressionBuilder.PrepareFilterExpression("MDItem." + MDItemEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithBothMath);
        //                String feBoth = SqlExpressionBuilder.PrepareFilterExpression(feBothPreBOQ, SQLJoinType.AND, feBoth1);
        //                IList<PRMPreBOQDetail_DetailedCustomEntity> preBOQDetailListByBoth = FCCPRMPreBOQDetail_DetailedCustom.GetFacadeCreate().GetIL(feBoth);

        //                if (preBOQDetailListBySuffix == null || preBOQDetailListBySuffix.Count <= 0)
        //                {
        //                    preBOQDetailListBySuffix = new List<PRMPreBOQDetail_DetailedCustomEntity>();
        //                }

        //                if (preBOQDetailListByBoth == null || preBOQDetailListByBoth.Count <= 0)
        //                {
        //                    preBOQDetailListByBoth = new List<PRMPreBOQDetail_DetailedCustomEntity>();
        //                }

        //                IList<PRMPreBOQDetail_DetailedCustomEntity> tempPreBOQItemList = preBOQDetailListByBoth.Except(preBOQDetailListBySuffix, new PreBOQItemComparer()).ToList();
        //                IList<PRMPreBOQDetail_DetailedCustomEntity> PreBOQItemList = new List<PRMPreBOQDetail_DetailedCustomEntity>();

        //                PreBOQItemList = preBOQDetailListBySuffix;

        //                if (tempPreBOQItemList != null && tempPreBOQItemList.Count > 0)
        //                {
        //                    foreach (PRMPreBOQDetail_DetailedCustomEntity ent in tempPreBOQItemList)
        //                    {
        //                        //If Zero Qty is not need to show or We can manage it From DB
        //                        //if (ent.TotalQty > 0)
        //                        //{
        //                        PreBOQItemList.Add(ent);
        //                        // }
        //                    }
        //                }

        //                if (PreBOQItemList != null && PreBOQItemList.Count > 0)
        //                {
        //                    foreach (PRMPreBOQDetail_DetailedCustomEntity entItem in PreBOQItemList)
        //                    {

        //                        if (prefixText.Equals(entItem.ItemName))
        //                        {
        //                            return new string[0];
        //                        }

        //                        items.Add(AutoCompleteExtender.CreateAutoCompleteItem(entItem.ItemName.ToString(), entItem.ItemID.ToString()));
        //                    }
        //                }
        //                else
        //                {
        //                    items.Add(AutoCompleteExtender.CreateAutoCompleteItem("No Items Available", "0"));
        //                }

        //                #endregion
        //                break;

        //            default:
        //                break;
        //        }
        //    }

        //    else
        //    {
        //        items.Add(AutoCompleteExtender.CreateAutoCompleteItem("Pre-BOQ Is Not Ready Yet.", "0"));
        //    }
        //}

        #endregion

        return items.ToArray();
    }
    
}
