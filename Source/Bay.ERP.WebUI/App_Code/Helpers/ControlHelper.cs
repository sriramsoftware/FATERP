using System;
using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Reflection;
using Bay.ERP.Common;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Helper;
using Bay.ERP.BusinessFacade;

namespace Bay.ERP.Web.UI.Helper
{
    public sealed class ControlHelper
    {
        private HttpRequest _request;

        public ControlHelper(HttpRequest request)
        {
            _request = request;
        }

        [DebuggerStepThrough()]
        public static Control GetControlOfType(ControlCollection controls,
        Type type)
        {
            if (controls.Count == 0)
            {
                return null;
            }

            if (controls[0].GetType() == type)
            {
                return controls[0];
            }

            foreach (Control c in controls)
            {
                if ((c.GetType() == type) || (c.GetType().BaseType == type))
                {
                    return c;
                }
            }

            return null;
        }

        [DebuggerStepThrough()]
        public string GetControlValue(string control)
        {
            return FormValue(control);
        }

        [DebuggerStepThrough()]
        public string GetControlValue(Control control)
        {
            return FormValue(control.UniqueID);
        }

        [DebuggerStepThrough()]
        public string GetControlValue(Control control,
        string defaultValue)
        {
            string returnValue = FormValue(control.UniqueID);

            if (returnValue == null)
            {
                return defaultValue;
            }

            return returnValue;
        }

        [DebuggerStepThrough()]
        private string FormValue(string control)
        {
            return _request.Form[control];
        }

        [DebuggerStepThrough()]
        public static void SetDefaultButton(WebControl[] controls, Control button)
        {
            if ((controls != null) && (controls.Length > 0))
            {
                for (int i = 0; i < controls.Length; i++)
                {
                    SetDefaultButton(controls[i], button);
                }
            }
        }

        [DebuggerStepThrough()]
        public static void SetDefaultButton(WebControl control, Control button)
        {
            if ((control != null) && (button != null))
            {
                control.Attributes.Add("onkeydown", "SetDefaultButton('" + button.ClientID + "')");
            }
        }

        [DebuggerStepThrough()]
        public static void SetHyperLink(HyperLink link,
        string url)
        {
            link.NavigateUrl = url;
        }

        [DebuggerStepThrough()]
        public static void SetHyperLink(HyperLink link,
        string url,
        string text)
        {
            if (!string.IsNullOrEmpty(text))
            {
                link.Text = text;
            }

            link.NavigateUrl = url;
        }

        [DebuggerStepThrough()]
        public static void SetHyperLink(HyperLink link,
        string url,
        string returnUrl,
        string text,
        params string[] parameters)
        {
            SecureUrl secureUrl = UrlHelper.BuildSecureUrl(url, returnUrl, parameters);
            SetHyperLink(link, secureUrl, text);
        }

        [DebuggerStepThrough()]
        public static void SetHyperLink(HyperLink link,
        string url,
        //string returnUrl, IFacade facade, // just to make it error free
        string returnUrl, IHRMemberFacade facade,
        string text, 
        params string[] parameters)
        {
            SecureUrl secureUrl = UrlHelper.BuildSecureUrl(url, returnUrl, facade, parameters);
            SetHyperLink(link, secureUrl, text);
        }

        [DebuggerStepThrough()]
        public static void SetHyperLink(HyperLink link,
        string url,
        string returnUrl,
        string text)
        {
            SetHyperLink(link, url, returnUrl, text, null);
        }

        [DebuggerStepThrough()]
        public static void SetHyperLink(HyperLink link,
        SecureUrl url,
        string text)
        {
            SetHyperLink(link, url.ToString(), text);
        }

        [DebuggerStepThrough()]
        public static void SetHyperLink(HyperLink link,
        SecureUrl url)
        {
            SetHyperLink(link, url.ToString());
        }

        [DebuggerStepThrough()]
        public static bool IsItemDataRow(ListItemType itemType)
        {
            return (
                     (itemType == ListItemType.Item) ||
                     (itemType == ListItemType.AlternatingItem)
                    );
        }

        [DebuggerStepThrough()]
        public static bool IsListItemDataRow(ListViewItemType itemType)
        {
            return (
                     (itemType == ListViewItemType.DataItem)
                    );
        }

        [DebuggerStepThrough()]
        public static void SelectListByText(ListControl list,
        string text)
        {
            list.SelectedIndex = list.Items.IndexOf(list.Items.FindByText(text));
        }

        [DebuggerStepThrough()]
        public static void SelectListByValue(ListControl list,
        string value)
        {
            list.SelectedIndex = list.Items.IndexOf(list.Items.FindByValue(value));
        }

        [DebuggerStepThrough()]
        public static void ClearListSelection(ListControl list)
        {
            list.SelectedIndex = -1;

            foreach (ListItem item in list.Items)
            {
                item.Selected = false;
            }
        }

        [DebuggerStepThrough()]
        public static void RemoveSelectedFromList(ListControl list)
        {
            for (int i = list.Items.Count - 1; i > -1; i--)
            {
                if (list.Items[i].Selected)
                {
                    list.Items.RemoveAt(i);
                }
            }
        }

        [DebuggerStepThrough()]
        public static void PopulateEnumIntoList(ListControl list, Type enumType)
        {
            string[] names = Enum.GetNames(enumType);

            if ((names != null) && (names.Length > 0))
            {
                foreach (string name in names)
                {
                    int value = (int)Enum.Parse(enumType, name);

                    if (value != 0)
                    {
                        ListItem item = new ListItem(name, value.ToString(System.Globalization.CultureInfo.CurrentCulture));
                        list.Items.Add(item);
                    }
                }
            }
        }



        [DebuggerStepThrough()]
        public static void PopulateEnumDescriptionIntoList(ListControl list, Type enumType)
        {
            string[] names = Enum.GetNames(enumType);

            IList<Pair> arrayList = new List<Pair>();

            if ((names != null) && (names.Length > 0))
            {
                foreach (string name in names)
                {
                    int value = (int)Enum.Parse(enumType, name);
                    string strDescription = EnumHelper.GetDescription((Enum)Enum.Parse(enumType, name));

                    if (value > 0)
                    {
                        arrayList.Add(new Pair { First = value.ToString(), Second = strDescription });
                        //arrayList.Add(new Pair(StringHelper.Convert(value), strDescription));
                    }
                }
            }

            arrayList = arrayList.OrderBy(t => t.Second).ToList();

            if ((arrayList != null) && (arrayList.Count > 0))
            {
                foreach (Pair pair in arrayList)
                {
                    ListItem item = new ListItem(pair.Second.ToString(), pair.First.ToString());
                    list.Items.Add(item);
                }
            }
        }

        [DebuggerStepThrough()]
        public static void PopulateEnumDescriptionIntoList(ListControl list, Type enumType, bool addPleaseSelectItem)
        {
            PopulateEnumDescriptionIntoList(list, enumType);
            if (addPleaseSelectItem)
            {
                list.Items.Insert(0, new ListItem(UIConstants.DROP_DOWNL_ITEM_PLEASE_SELECT, "0"));
            }
        }

        //public static void PopulateEnumDescriptionIntoListView(ListControl list, Type enumType)
        //{
        //    string[] names = Enum.GetNames(enumType);

        //    IList<WorkOrderExpense> arrayList = new List<WorkOrderExpense>();

        //    if ((names != null) && (names.Length > 0))
        //    {
        //        foreach (string name in names)
        //        {
        //            int value = (int)Enum.Parse(enumType, name);
        //            string strDescription = EnumHelper.GetDescription((Enum)Enum.Parse(enumType, name));

        //            if (value > 0)
        //            {
        //                arrayList.Add(new WorkOrderExpense { Cost = Convert.ToDecimal(strDescription), ExpenseType = value });
        //                //arrayList.Add(new WorkOrderExpense(StringHelper.Convert(value), strDescription));
        //            }
        //        }
        //    }

        //    arrayList = arrayList.OrderBy(t => t.Cost).ToList();

        //    if ((arrayList != null) && (arrayList.Count > 0))
        //    {
        //        foreach (WorkOrderExpense workOrderExpense in arrayList)
        //        {
        //            ListItem item = new ListItem(workOrderExpense.Cost.ToString(), workOrderExpense.ExpenseType.ToString());
        //            list.Items.Add(item);
        //        }
        //    }
        //}
    }
}