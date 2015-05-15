using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;


using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.Shared;

using AjaxControlToolkit;
using Bay.ERP.Web.UI;
/// <summary>
/// Summary description for AutoCompleteAccount
/// </summary>
[WebService(Namespace = "http://tempuri.org/")]
[WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
[System.Web.Script.Services.ScriptService]
public class AutoCompleteAccount : System.Web.Services.WebService {

    public class ACAccountComparer : IEqualityComparer<ACAccount_DetailedEntity>
    {
        public bool Equals(ACAccount_DetailedEntity x, ACAccount_DetailedEntity y)
        {
            return (x.AccountID.Equals(y.AccountID));
        }

        public int GetHashCode(ACAccount_DetailedEntity obj)
        {
            return obj.AccountID.GetHashCode();
        }
    }

    public AutoCompleteAccount () {

        //Uncomment the following line if using designed components 
        //InitializeComponent(); 
    }

    [WebMethod]
    public string[] GetCompletionItemList(string prefixText, int count, string contextKey)
    {

        #region GET ITEM

        //Int64 storeUnitID;
        //Int64.TryParse(contextKey.ToString(), out storeUnitID);
        
        List<string> items = new List<string>(count);

        #region Accounts

        String fePrefix = SqlExpressionBuilder.PrepareFilterExpression("(SELECT dbo.RemoveAllSpecialCharacter(ACAccount.AccountName))", prefixText, SQLMatchType.LikeWithSuffixMath);
        String fe_accountCode = SqlExpressionBuilder.PrepareFilterExpression("ACAccount." + ACAccountEntity.FLD_NAME_AccountCode, prefixText, SQLMatchType.LikeWithSuffixMath);
        fePrefix = SqlExpressionBuilder.PrepareFilterExpression(fePrefix, SQLJoinType.OR, fe_accountCode);

        IList<ACAccount_DetailedEntity> accountsListBySuffix = FCCACAccount_Detailed.GetFacadeCreate().GetIL(10000000,1,String.Empty, fePrefix);

        String feBothfix = SqlExpressionBuilder.PrepareFilterExpression("(SELECT dbo.RemoveAllSpecialCharacter(ACAccount.AccountName))", prefixText, SQLMatchType.LikeWithBothMath);

        IList<ACAccount_DetailedEntity> accountsListByBoth = FCCACAccount_Detailed.GetFacadeCreate().GetIL(10000000, 1, String.Empty, feBothfix);

        if (accountsListBySuffix == null || accountsListBySuffix.Count <= 0)
        {
            accountsListBySuffix = new List<ACAccount_DetailedEntity>();
        }

        if (accountsListByBoth == null || accountsListByBoth.Count <= 0)
        {
            accountsListByBoth = new List<ACAccount_DetailedEntity>();
        }

        IList<ACAccount_DetailedEntity> tempBOQItemList = accountsListByBoth.Except(accountsListBySuffix, new ACAccountComparer()).ToList();
        IList<ACAccount_DetailedEntity> itemList = new List<ACAccount_DetailedEntity>();

        itemList = accountsListBySuffix;

        if (tempBOQItemList != null && tempBOQItemList.Count > 0)
        {
            foreach (ACAccount_DetailedEntity ent in tempBOQItemList)
            {
                itemList.Add(ent);
            }
        }

        if (itemList != null && itemList.Count > 0)
        {
            foreach (ACAccount_DetailedEntity entItem in itemList)
            {
                if (prefixText.Equals(entItem.AccountCode + " - " + entItem.AccountName))
                {
                    return new string[0];
                }

                items.Add(AutoCompleteExtender.CreateAutoCompleteItem(entItem.AccountCode + " - " + entItem.AccountName, entItem.AccountID.ToString()));
            }
        }
        else
        {
            items.Add(AutoCompleteExtender.CreateAutoCompleteItem("No Accounts Available", "0"));
        }

        #endregion

        #endregion

        return items.ToArray();
    }
    
}
