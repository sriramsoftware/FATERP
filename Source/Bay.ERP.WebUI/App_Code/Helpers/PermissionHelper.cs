using System;
using System.Data;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.UI;
using System.Web.UI.HtmlControls;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;
using System.Xml.Linq;
using System.Collections.Generic;

using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.BusinessEntities;


/// <summary>
/// Summary description for PermissionHelper
/// </summary>
/// 
namespace Bay.ERP.Web.UI
{
    public class PermissionHelper
    {
        public PermissionHelper()
        {
            //
            // TODO: Add constructor logic here
            //
        }

        public static bool IsUerHasPermission(string uniqueKey)
        {
            Boolean hasPermission = false;

            IList<ASRolePermissionEntity> permissions = null;

            if (HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS] != null)
            {
                permissions = HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS] as List<ASRolePermissionEntity>;
            }

            if (uniqueKey == "Public_Page")
            {
                hasPermission = true;
            }            
            else if (permissions != null)
            {
                foreach (ASRolePermissionEntity tempASRolePermissionEntity in permissions)
                {
                    if (tempASRolePermissionEntity.PermissionKey.ToUpper() == uniqueKey.ToUpper())
                    {
                        hasPermission = true;
                        break;
                    }
                }
            }

            return hasPermission;
        }

        public static bool IsUerHasPermissionForPermissionApply(string uniqueKey)
        {
            Boolean hasPermission = false;

            IList<ASRolePermissionEntity> permissions = null;

            if (HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS_FOR_PERMISSION_APPLY] != null)
            {
                permissions = HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS_FOR_PERMISSION_APPLY] as List<ASRolePermissionEntity>;
            }

            if (uniqueKey == "Public_Page")
            {
                hasPermission = true;
            }
            else if (permissions != null)
            {
                foreach (ASRolePermissionEntity tempASRolePermissionEntity in permissions)
                {
                    if (tempASRolePermissionEntity.PermissionKey.ToUpper() == uniqueKey.ToUpper())
                    {
                        hasPermission = true;
                        break;
                    }
                }
            }

            return hasPermission;
        }

        public static bool IsRoleHasPermission(string uniqueKey)
        {
            Boolean result = false;

            IList<ASRolePermissionEntity> permissions = null;

            if (HttpContext.Current.Session[SessionConstants.ROLE_PERMISSION_KEYS] != null)
            {
                permissions = HttpContext.Current.Session[SessionConstants.ROLE_PERMISSION_KEYS] as List<ASRolePermissionEntity>;
            }

            if (permissions != null)
            {
                foreach (ASRolePermissionEntity tempASRolePermissionEntity in permissions)
                {
                    if (tempASRolePermissionEntity.PermissionKey.ToUpper() == uniqueKey.ToUpper())
                    {
                        result = true;
                        break;
                    }
                }
            }

            return result;
        }

        public static void PreserveUserPermissionKeys(string user)
        {
            if (HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS] != null)
            {
                HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS] = null;
            }
            IASRolePermissionFacade rolepermissionfacade = new ASRolePermissionFacade();
            IASUserPermissionExcludedFacade userpermissionexclusionfacade = new ASUserPermissionExcludedFacade();
            IList<ASRolePermissionEntity> permissions = rolepermissionfacade.GetAllRolePermissionsByRoleName(Roles.GetRolesForUser(user));
            IList<ASUserPermissionExcludedEntity> userpermissionexcluded = userpermissionexclusionfacade.GetByUserName(user);

            foreach (ASUserPermissionExcludedEntity userpermission in userpermissionexcluded)
            {
                for (int i = 0; i < permissions.Count; i++)
                {
                    if (permissions[i].PermissionKey == userpermission.PermissionKey)
                    {
                        permissions.RemoveAt(i);
                        break;
                    }
                }
            }

            HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS] = permissions;
        }
        
        public static void PreserveUserPermissionKeysForPermissionApply(string user)
        {
            if (HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS_FOR_PERMISSION_APPLY] != null)
            {
                HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS_FOR_PERMISSION_APPLY] = null;
            }
            IASRolePermissionFacade rolepermissionfacade = new ASRolePermissionFacade();
            IASUserPermissionExcludedFacade userpermissionexclusionfacade = new ASUserPermissionExcludedFacade();
            IList<ASRolePermissionEntity> permissions = rolepermissionfacade.GetAllRolePermissionsByRoleName(Roles.GetRolesForUser(user));
            IList<ASUserPermissionExcludedEntity> userpermissionexcluded = userpermissionexclusionfacade.GetByUserName(user);

            foreach (ASUserPermissionExcludedEntity userpermission in userpermissionexcluded)
            {
                for (int i = 0; i < permissions.Count; i++)
                {
                    if (permissions[i].PermissionKey == userpermission.PermissionKey)
                    {
                        permissions.RemoveAt(i);
                        break;
                    }
                }
            }

            HttpContext.Current.Session[SessionConstants.USER_PERMISSION_KEYS_FOR_PERMISSION_APPLY] = permissions;

        }

        public static void PreserveRolePermissionKeys(string role)
        {
            if (HttpContext.Current.Session[SessionConstants.ROLE_PERMISSION_KEYS] != null)
            {
                HttpContext.Current.Session[SessionConstants.ROLE_PERMISSION_KEYS] = null;
            }

            String[] roles = { role };

            IASRolePermissionFacade rolepermissionfacade = new ASRolePermissionFacade();
            IList<ASRolePermissionEntity> permissions = rolepermissionfacade.GetAllRolePermissionsByRoleName(roles);
            
            HttpContext.Current.Session[SessionConstants.ROLE_PERMISSION_KEYS] = permissions;
        }
    }
}