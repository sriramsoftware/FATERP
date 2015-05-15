// (c) Copyright Microsoft Corporation.
// This source is subject to the Microsoft Public License.
// See http://www.microsoft.com/opensource/licenses.mspx#Ms-PL.
// All other rights reserved.


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

public class PreBOQItemComparer : IEqualityComparer<PRMPreBOQDetail_DetailedCustomEntity>
{
    public bool Equals(PRMPreBOQDetail_DetailedCustomEntity x, PRMPreBOQDetail_DetailedCustomEntity y)
    {
        return (x.ItemID.Equals(y.ItemID));
    }

    public int GetHashCode(PRMPreBOQDetail_DetailedCustomEntity obj)
    {
        return obj.ItemID.GetHashCode();
    }
}

public class BOQItemComparer : IEqualityComparer<PRMBOQDetail_DetailedCustomEntity>
{
    public bool Equals(PRMBOQDetail_DetailedCustomEntity x, PRMBOQDetail_DetailedCustomEntity y)
    {
        return (x.ItemID.Equals(y.ItemID));
    }

    public int GetHashCode(PRMBOQDetail_DetailedCustomEntity obj)
    {
        return obj.ItemID.GetHashCode();
    }
}

public class ItemComparer : IEqualityComparer<MDItemEntity>
{
    public bool Equals(MDItemEntity x, MDItemEntity y)
    {
        return (x.ItemID.Equals(y.ItemID));
    }

    public int GetHashCode(MDItemEntity obj)
    {
        return obj.ItemID.GetHashCode();
    }
}


[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class AutoComplete : WebService
{
    public AutoComplete()
    {

    }

    [WebMethod]
    public string[] GetCompletionItemList(string prefixText, int count, string contextKey)
    {

        #region GET ITEM

        Int64 projectID;
        Int64.TryParse(contextKey.ToString(), out projectID);
        List<string> items = new List<string>(count);

        #region DEFAULT_PROJECT

        if (projectID == MasterDataConstants.Project.DEFAULT_PROJECT)
        {
            String fePrefix = SqlExpressionBuilder.PrepareFilterExpression(MDItemEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithSuffixMath);
            IList<MDItemEntity> itemListBySuffix = FCCMDItem.GetFacadeCreate().GetIL(null, null, String.Empty, fePrefix, DatabaseOperationType.LoadWithFilterExpression);
            String feBothfix = SqlExpressionBuilder.PrepareFilterExpression(MDItemEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithBothMath);
            IList<MDItemEntity> itemListByBoth = FCCMDItem.GetFacadeCreate().GetIL(null, null, String.Empty, feBothfix, DatabaseOperationType.LoadWithFilterExpression);

            if (itemListBySuffix == null || itemListBySuffix.Count <= 0)
            {
                itemListBySuffix = new List<MDItemEntity>();
            }

            if (itemListByBoth == null || itemListByBoth.Count <= 0)
            {
                itemListByBoth = new List<MDItemEntity>();
            }

            IList<MDItemEntity> tempBOQItemList = itemListByBoth.Except(itemListBySuffix, new ItemComparer()).ToList();
            IList<MDItemEntity> itemList = new List<MDItemEntity>();

            itemList = itemListBySuffix;

            if (tempBOQItemList != null && tempBOQItemList.Count > 0)
            {
                foreach (MDItemEntity ent in tempBOQItemList)
                {
                    itemList.Add(ent);
                }
            }

            if (itemList != null && itemList.Count > 0)
                {
                    foreach (MDItemEntity entItem in itemList)
                    {
                        if (prefixText.Equals(entItem.ItemName))
                        {
                            return new string[0];
                        }

                        items.Add(AutoCompleteExtender.CreateAutoCompleteItem(entItem.ItemName.ToString(), entItem.ItemID.ToString()));
                    }
                }
                else
                {
                    items.Add(AutoCompleteExtender.CreateAutoCompleteItem("No Items Available", "0"));
                }
        }

        #endregion

        if (projectID > 0 && projectID != MasterDataConstants.Project.DEFAULT_PROJECT)
        {
            String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMPreBOQEntity.FLD_NAME_ProjectID, projectID.ToString(), SQLMatchType.Equal);
            IList<PRMPreBOQEntity> preBOQList = FCCPRMPreBOQ.GetFacadeCreate().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression);

            if (preBOQList != null && preBOQList.Count > 0)
            {
                Int64 preBOQID = preBOQList[0].PreBOQID;

                switch (preBOQList[0].IsLocked)
                {
                    case true:
                        #region GET Item From BOQ

                        String feBOQSufix1 = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetail_DetailedCustomEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                        String feBOQSuffix2 = SqlExpressionBuilder.PrepareFilterExpression("MDItem." + PRMPreBOQDetail_DetailedCustomEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithSuffixMath);
                        String fiterExpressionBysuffix = SqlExpressionBuilder.PrepareFilterExpression(feBOQSufix1, SQLJoinType.AND, feBOQSuffix2);
                        IList<PRMBOQDetail_DetailedCustomEntity> prmBOQDetailListBySuffix = FCCPRMBOQDetail_DetailedCustom.GetFacadeCreate().GetIL(fiterExpressionBysuffix);

                        String feBothBOQ = SqlExpressionBuilder.PrepareFilterExpression(PRMBOQDetail_DetailedCustomEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                        String feBOQBoth = SqlExpressionBuilder.PrepareFilterExpression("MDItem." + MDItemEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithBothMath);
                        String filterExpressionBoth = SqlExpressionBuilder.PrepareFilterExpression(feBothBOQ, SQLJoinType.AND, feBOQBoth);
                        IList<PRMBOQDetail_DetailedCustomEntity> prmBOQDetailListByBoth = FCCPRMBOQDetail_DetailedCustom.GetFacadeCreate().GetIL(filterExpressionBoth);

                        if (prmBOQDetailListBySuffix == null || prmBOQDetailListBySuffix.Count <= 0)
                        {
                            prmBOQDetailListBySuffix = new List<PRMBOQDetail_DetailedCustomEntity>();
                        }

                        if (prmBOQDetailListByBoth == null || prmBOQDetailListByBoth.Count <= 0)
                        {
                            prmBOQDetailListByBoth = new List<PRMBOQDetail_DetailedCustomEntity>();
                        }

                        IList<PRMBOQDetail_DetailedCustomEntity> tempBOQItemList = prmBOQDetailListByBoth.Except(prmBOQDetailListBySuffix, new BOQItemComparer()).ToList();
                        IList<PRMBOQDetail_DetailedCustomEntity> BOQItemList = new List<PRMBOQDetail_DetailedCustomEntity>();

                        BOQItemList = prmBOQDetailListBySuffix;

                        if (tempBOQItemList != null && tempBOQItemList.Count > 0)
                        {
                            foreach (PRMBOQDetail_DetailedCustomEntity ent in tempBOQItemList)
                            {
                                //If Zero Qty is not need to show or We can manage it From DB
                                //if (ent.TotalQty > 0)
                                //{
                                BOQItemList.Add(ent);
                                //}
                            }
                        }

                        if (BOQItemList != null && BOQItemList.Count > 0)
                        {
                            foreach (PRMBOQDetail_DetailedCustomEntity entItem in BOQItemList)
                            {

                                if (prefixText.Equals(entItem.ItemName))
                                {
                                    return new string[0];
                                }

                                items.Add(AutoCompleteExtender.CreateAutoCompleteItem(entItem.ItemName.ToString(), entItem.ItemID.ToString()));
                            }
                        }
                        else
                        {
                            items.Add(AutoCompleteExtender.CreateAutoCompleteItem("No Items Available", "0"));
                        }

                        #endregion
                        break;

                    case false:
                        #region Get Item From Pre-BOQ

                        String fePreBOQSufix1 = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQDetail." + PRMPreBOQDetail_DetailedCustomEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                        String fePreBOQSufix2 = SqlExpressionBuilder.PrepareFilterExpression("MDItem." + PRMPreBOQDetail_DetailedCustomEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithSuffixMath);
                        String filterExpressionSuffix = SqlExpressionBuilder.PrepareFilterExpression(fePreBOQSufix1, SQLJoinType.AND, fePreBOQSufix2);
                        IList<PRMPreBOQDetail_DetailedCustomEntity> preBOQDetailListBySuffix = FCCPRMPreBOQDetail_DetailedCustom.GetFacadeCreate().GetIL(filterExpressionSuffix);

                        String feBothPreBOQ = SqlExpressionBuilder.PrepareFilterExpression("PRMPreBOQDetail." + PRMPreBOQDetail_DetailedCustomEntity.FLD_NAME_PreBOQID, preBOQID.ToString(), SQLMatchType.Equal);
                        String feBoth1 = SqlExpressionBuilder.PrepareFilterExpression("MDItem." + MDItemEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithBothMath);
                        String feBoth = SqlExpressionBuilder.PrepareFilterExpression(feBothPreBOQ, SQLJoinType.AND, feBoth1);
                        IList<PRMPreBOQDetail_DetailedCustomEntity> preBOQDetailListByBoth = FCCPRMPreBOQDetail_DetailedCustom.GetFacadeCreate().GetIL(feBoth);

                        if (preBOQDetailListBySuffix == null || preBOQDetailListBySuffix.Count <= 0)
                        {
                            preBOQDetailListBySuffix = new List<PRMPreBOQDetail_DetailedCustomEntity>();
                        }

                        if (preBOQDetailListByBoth == null || preBOQDetailListByBoth.Count <= 0)
                        {
                            preBOQDetailListByBoth = new List<PRMPreBOQDetail_DetailedCustomEntity>();
                        }

                        IList<PRMPreBOQDetail_DetailedCustomEntity> tempPreBOQItemList = preBOQDetailListByBoth.Except(preBOQDetailListBySuffix, new PreBOQItemComparer()).ToList();
                        IList<PRMPreBOQDetail_DetailedCustomEntity> PreBOQItemList = new List<PRMPreBOQDetail_DetailedCustomEntity>();

                        PreBOQItemList = preBOQDetailListBySuffix;

                        if (tempPreBOQItemList != null && tempPreBOQItemList.Count > 0)
                        {
                            foreach (PRMPreBOQDetail_DetailedCustomEntity ent in tempPreBOQItemList)
                            {
                                //If Zero Qty is not need to show or We can manage it From DB
                                //if (ent.TotalQty > 0)
                                //{
                                PreBOQItemList.Add(ent);
                                // }
                            }
                        }

                        if (PreBOQItemList != null && PreBOQItemList.Count > 0)
                        {
                            foreach (PRMPreBOQDetail_DetailedCustomEntity entItem in PreBOQItemList)
                            {

                                if (prefixText.Equals(entItem.ItemName))
                                {
                                    return new string[0];
                                }

                                items.Add(AutoCompleteExtender.CreateAutoCompleteItem(entItem.ItemName.ToString(), entItem.ItemID.ToString()));
                            }
                        }
                        else
                        {
                            items.Add(AutoCompleteExtender.CreateAutoCompleteItem("No Items Available", "0"));
                        }

                        #endregion
                        break;

                    default:
                        break;
                }
            }

            else
            {
                items.Add(AutoCompleteExtender.CreateAutoCompleteItem("Pre-BOQ Is Not Ready Yet.", "0"));
            }
        }

        #endregion

        return items.ToArray();
    }
}
#region Backup

//IList<MDItemEntity> ItemListBySuffix = new List<MDItemEntity>();


//String feSuffix = SqlExpressionBuilder.PrepareFilterExpression(MDItemEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithSuffixMath);
//ItemListBySuffix = FCCMDItem.GetFacadeCreate().GetIL(null, null, String.Empty, feSuffix, DatabaseOperationType.LoadWithFilterExpression);

//String feBoth = SqlExpressionBuilder.PrepareFilterExpression(MDItemEntity.FLD_NAME_ItemName, prefixText, SQLMatchType.LikeWithBothMath);
//IList<MDItemEntity> ItemListByBoth = FCCMDItem.GetFacadeCreate().GetIL(null, null, String.Empty, feBoth, DatabaseOperationType.LoadWithFilterExpression);

//if (ItemListBySuffix == null || ItemListBySuffix.Count <= 0)
//{
//    ItemListBySuffix = new List<MDItemEntity>();
//}

//if (ItemListByBoth == null || ItemListByBoth.Count <= 0)
//{
//    ItemListByBoth = new List<MDItemEntity>();
//}
//IList<MDItemEntity> tempItemList = ItemListByBoth.Except(ItemListBySuffix, new ItemComparer()).ToList();
//IList<MDItemEntity> ItemListByItem = new List<MDItemEntity>();

//ItemListByItem = ItemListBySuffix;

//if (tempItemList != null && tempItemList.Count > 0)
//{
//    foreach (MDItemEntity ent in tempItemList)
//    {
//        ItemListByItem.Add(ent);
//    }
//}

//List<string> items = new List<string>(count);


//if (ItemListByItem != null && ItemListByItem.Count > 0)
//{
//    foreach (MDItemEntity entItem in ItemListByItem)
//    {

//        if (prefixText.Equals(entItem.ItemName))
//        {
//            return new string[0];
//        }

//        items.Add(AutoCompleteExtender.CreateAutoCompleteItem(entItem.ItemName, entItem.ItemID.ToString()));
//    }
//}

#endregion