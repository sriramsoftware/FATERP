using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Common.Helper
{
    public static class SqlExpressionBuilder
    {
        public static String PrepareFilterExpression(String fieldName, String fieldValue, SQLMatchType option)
        {
            String expression = "";

            switch (option)
            {
                case SQLMatchType.Equal:
                    expression = String.Format("{0} = '{1}'", fieldName, fieldValue);
                    break;
                case SQLMatchType.LikeWithPrefixMath:
                    expression = String.Format("{0} Like '%{1}'", fieldName, fieldValue);
                    break;
                case SQLMatchType.LikeWithSuffixMath:
                    expression = String.Format("{0} Like '{1}%'", fieldName, fieldValue);
                    break;
                case SQLMatchType.LikeWithBothMath:
                    expression = String.Format("{0} Like '%{1}%'", fieldName, fieldValue);
                    break;
                case SQLMatchType.IsNull:
                    expression = String.Format("{0} IS NULL", fieldName);
                    break;
                default:
                    break;
            }

            return expression;
        }

        public static String PrepareFilterExpression(String exp1, SQLJoinType option, String exp2)
        {
            String expression = "";

            switch (option)
            {
                case SQLJoinType.AND:
                    expression = String.Format("({0} AND {1})", exp1, exp2);
                    break;
                case SQLJoinType.OR:
                    expression = String.Format("({0} OR {1})", exp1, exp2);
                    break;
                default:
                    break;
            }

            return expression;
        }

        public static String PrepareSortExpression(String fieldName, SQLSortOrderType option)
        {
            String expression = "";

            switch (option)
            {
                case SQLSortOrderType.Assending:
                    expression = String.Format("{0} asc", fieldName);
                    break;
                case SQLSortOrderType.Decending:
                    expression = String.Format("{0} desc", fieldName);
                    break;
                case SQLSortOrderType.UnSpecified:
                    expression = fieldName;
                    break;
                default:
                    break;
            }

            return expression;
        }

        public static String PrepareSortExpression(String sortExpression1, String sortExpression2)
        {
            return String.Format("{0}, {1}", sortExpression1, sortExpression2);
        }
    }
}
