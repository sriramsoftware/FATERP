using System.Diagnostics;
using System.Web;
using System.Web.UI;
using System.Web.Security;
using System;
using Bay.ERP.Common.Helper;
using Bay.ERP.Common.BusinessEntities;
using System.Collections.Generic;
using Bay.ERP.FacadeCreator.FacadeContext;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.Web.UI.Manager
{
	public static class ASSecurityManager
    {
        #region Properties

        static IList<ASSiteMapNode_DetailedEntity> list = new List<ASSiteMapNode_DetailedEntity>();

        #endregion

        #region Manage User

        public static Boolean IsUserNameAvailable(String userName)
        {
            MembershipUserCollection memberList = Membership.FindUsersByName(userName);

            if (memberList.Count == 0)
            {
                return true;
            }

            return false;
        }

        public static MembershipUser CreateASPNETUser(String userName, String password)
        {
            MembershipUser user = null;

            if (userName.IsNotNullOrEmpty() && password.IsNotNullOrEmpty())
            {
                user = Membership.CreateUser(userName, password);
            }

            return user;
        }

        public static MembershipUser CreateASPNETUserForMember(Int64 memberID, String userName, String password, String email)
        {
            MembershipUser user = null;

            if (userName.IsNotNullOrEmpty() && password.IsNotNullOrEmpty())
            {
                user = Membership.CreateUser(userName, password, email);

                MapMemberWithASPNETUser(memberID, user);
            }

            return user;
        }

        public static MembershipUser CreateASPNETUserForMember(Int64 memberID, String userName, String password)
        {
            MembershipUser user = null;

            if (userName.IsNotNullOrEmpty() && password.IsNotNullOrEmpty())
            {
                user = Membership.CreateUser(userName, password);

                MapMemberWithASPNETUser(memberID, user);
            }

            return user;
        }

        public static Boolean ValidateASPNETUserPassword(String userName, String password)
        {
            Boolean result = false;

            if (userName.IsNotNullOrEmpty() && password.IsNotNullOrEmpty())
            {
                result = Membership.ValidateUser(userName, password);
            }

            return result;
        }

        public static Boolean ChangeASPNETUserPassword(MembershipUser user, String oldPassword, String newPassword)
        {
            return user.ChangePassword(oldPassword, newPassword);
        }

        public static Boolean ChangeASPNETUserPassword(String userName, String oldPassword, String newPassword)
        {
            return GetASPNETUserByUserName(userName).ChangePassword(oldPassword, newPassword);
        }

        public static Boolean ChangeASPNETUserPassword(String userName, String newPassword)
        {
            MembershipUser  user = GetASPNETUserByUserName(userName);

            return ChangeASPNETUserPassword(userName, user.GetPassword(), newPassword);
        }

        public static void MapMemberWithASPNETUser(Int64 memberID, MembershipUser user)
        {
            if (user != null)
            {
                ASMemberAspnetUsersMapEntity aspnetUsersMemberMapEntity = new ASMemberAspnetUsersMapEntity();

                aspnetUsersMemberMapEntity.UserId = (Guid)user.ProviderUserKey;
                aspnetUsersMemberMapEntity.MemberID = memberID;

                FCCASMemberAspnetUsersMap.GetFacadeCreate().Add(aspnetUsersMemberMapEntity, DatabaseOperationType.Add, TransactionRequired.No);
            }
        }

        public static String[] GetRolesByMemberID(Int64 memberID)
        {
            MembershipUser member = GetASPNETUserByMemberID(memberID);

            String[] roels = Roles.GetRolesForUser(member.UserName);

            return roels;
        }

        public static String[] GetAllRoles()
        { 
            String[] roels = Roles.GetAllRoles();

            return roels;
        }

        public static Boolean DeleteASPNETUser(String userName)
        {
            Boolean result = false;

            if (userName.IsNotNullOrEmpty())
            {
                result = Membership.DeleteUser(userName);
            }

            return result;
        }

        #endregion


        #region After Login

        public static void UserLogedIn(String userName)
        {
            HRMemberEntity member = GetMemberByASPNETUserName(userName);

            SetCurrentMember(member);

            PermissionHelper.PreserveUserPermissionKeys(userName);

            CreateMenuSourceForLogedInUser();

            HttpContext.Current.Response.Cookies.Remove(FormsAuthentication.FormsCookieName);
            FormsAuthentication.SetAuthCookie(userName, false);
        }

        public static HRMemberEntity GetMemberByASPNETUserName(String userName)
        {
            HRMemberEntity member = null;

            MembershipUser user = GetASPNETUserByUserName(userName);

            if(user != null)
            {
                Guid userID = (Guid)user.ProviderUserKey;

                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASMemberAspnetUsersMapEntity.FLD_NAME_UserId, userID.ToString(), SQLMatchType.Equal);
                
                IList<ASMemberAspnetUsersMapEntity> aSMemberAspnetUsersMapEntityList = FCCASMemberAspnetUsersMap.GetFacadeCreate().GetIL(null, null, null, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                if (aSMemberAspnetUsersMapEntityList != null && aSMemberAspnetUsersMapEntityList.Count > 0)
                {
                    filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRMemberEntity.FLD_NAME_MemberID, aSMemberAspnetUsersMapEntityList[0].MemberID.ToString(), SQLMatchType.Equal);

                    IList<HRMemberEntity> memberEntityList = FCCHRMember.GetFacadeCreate().GetIL(null, null, null, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

                    if (memberEntityList!= null && memberEntityList.Count > 0)
                    {
                        member = memberEntityList[0];
                    }
                }
            }

            return member;
        }

        public static MembershipUser GetASPNETUserByUserName(String userName)
        {
            MembershipUser user = null;

            if (userName.IsNotNullOrEmpty())
            {
                user = Membership.GetUser(userName);
            }

            return user;
        }

        public static MembershipUser GetASPNETUserByMemberID(Int64 memberID)
        {
            MembershipUser user = null;

            IList<ASPNETUserNameByMemberIDEntity> aSPNETUserNameByMemberIDEntityList = FCCASPNETUserNameByMemberID.GetFacadeCreate().GetIL(memberID);

            if (aSPNETUserNameByMemberIDEntityList != null && aSPNETUserNameByMemberIDEntityList.Count > 0)
            {
                user = Membership.GetUser(aSPNETUserNameByMemberIDEntityList[0].UserName);
            }

            return user;
        }

        public static void SetCurrentMember(HRMemberEntity member)
        {
            HttpContext.Current.Session[SessionConstants.LOGIN_MEMBER_INFO] = member;
        }

        public static void SetUserNameAndPasswordToCookies(String userName, String password)
        {
            HttpCookie cookieASSecurityUserInfo = new HttpCookie("ASSecurityUserInfo");

            cookieASSecurityUserInfo.Values.Add("ASSecurityUserName", userName);
            cookieASSecurityUserInfo.Values.Add("ASSecurityPassword", password);
            cookieASSecurityUserInfo.Expires = DateTime.Now.AddDays(3);//cookie Expires 

            HttpContext.Current.Response.AppendCookie(cookieASSecurityUserInfo);
        }

        public static String GetUserNameFromCookies()
        {
            String userName = String.Empty;

            if (HttpContext.Current.Request.Cookies["ASSecurityUserInfo"] != null)
            {
                userName = HttpContext.Current.Request.Cookies["ASSecurityUserInfo"]["ASSecurityUserName"];
            }

            return userName;
        }

        public static String GetPasswordFromCookies()
        {
            String password = String.Empty;

            if (HttpContext.Current.Request.Cookies["ASSecurityUserInfo"] != null)
            {
                password = HttpContext.Current.Request.Cookies["ASSecurityUserInfo"]["ASSecurityPassword"];
            }

            return password;

        }

        private static void CreateMenuSourceForLogedInUser()
        {
            try
            {
                list = new List<ASSiteMapNode_DetailedEntity>();

                String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
                String filterExpression1 = "ASSiteMapNode." + SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ASSiteMapID, SecurityConstants.ASSiteMap.MASTER_NAVIGATION_MENU.ToString(), SQLMatchType.Equal);
                String filterExpression2 = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ParentASSiteMapNodeID, String.Empty, SQLMatchType.IsNull);
                String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(filterExpression1, SQLJoinType.AND, filterExpression2);

                IList<ASSiteMapNode_DetailedEntity> aSSiteMapNode_DetailedEntityList = FCCASSiteMapNode_Detailed.GetFacadeCreate().GetIL(1, 1000000, sortExpression, filterExpression);

                if (aSSiteMapNode_DetailedEntityList != null && aSSiteMapNode_DetailedEntityList.Count > 0)
                {
                    foreach (ASSiteMapNode_DetailedEntity aSSiteMapNode_DetailedEntity in aSSiteMapNode_DetailedEntityList)
                    {
                        AddMenuNode(aSSiteMapNode_DetailedEntity.ASSiteMapNodeID);

                        break;
                    }
                }                

                System.Web.HttpContext.Current.Session[SessionConstants.MASTER_NAVIGATION_MENU_ITEMS] = list;
            }
            catch(Exception ex)
            {

            }
        }

        private static void AddMenuNode(Int64 parentID)
        {
            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ParentASSiteMapNodeID, parentID.ToString(), SQLMatchType.Equal);

            IList<ASSiteMapNode_DetailedEntity> aSSiteMapNode_DetailedEntityList = FCCASSiteMapNode_Detailed.GetFacadeCreate().GetIL(1, 1000000, sortExpression, filterExpression);

            if (aSSiteMapNode_DetailedEntityList != null && aSSiteMapNode_DetailedEntityList.Count > 0)
            {
                foreach (ASSiteMapNode_DetailedEntity aSSiteMapNode_DetailedEntity in aSSiteMapNode_DetailedEntityList)
                {
                    doRec(aSSiteMapNode_DetailedEntity.ASSiteMapNodeID);

                    Boolean hasPermission = false;

                    if (aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID == null)
                    {
                        hasPermission = PermissionHelper.IsUerHasPermission(aSSiteMapNode_DetailedEntity.UniqueKey);
                    }
                    else if (aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID > 0)
                    {
                        hasPermission = PermissionHelper.IsUerHasPermission(aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey);
                    }

                    if (hasPermission == true)
                    {
                        aSSiteMapNode_DetailedEntity.ParentASSiteMapNodeID = null;

                        list.Add(aSSiteMapNode_DetailedEntity);
                    }
                }
            }
        }

        private static void doRec(Int64 parentID)
        {
            String sortExpression = SqlExpressionBuilder.PrepareSortExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_SequenceNumber, SQLSortOrderType.Assending);
            String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(ASSiteMapNode_DetailedEntity.FLD_NAME_ParentASSiteMapNodeID, parentID.ToString(), SQLMatchType.Equal);

            IList<ASSiteMapNode_DetailedEntity> aSSiteMapNode_DetailedEntityList = FCCASSiteMapNode_Detailed.GetFacadeCreate().GetIL(1, 1000000, sortExpression, filterExpression);

            if (aSSiteMapNode_DetailedEntityList != null && aSSiteMapNode_DetailedEntityList.Count > 0)
            {
                foreach (ASSiteMapNode_DetailedEntity aSSiteMapNode_DetailedEntity in aSSiteMapNode_DetailedEntityList)
                {
                    doRec(aSSiteMapNode_DetailedEntity.ASSiteMapNodeID);


                    Boolean hasPermission = false;

                    if (aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID == null)
                    {
                        hasPermission = PermissionHelper.IsUerHasPermission(aSSiteMapNode_DetailedEntity.UniqueKey);
                    }
                    else if (aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapID > 0)
                    {
                        hasPermission = PermissionHelper.IsUerHasPermission(aSSiteMapNode_DetailedEntity.ASPhysicalSiteMapUniqueKey);
                    }

                    if (hasPermission == true)
                    {
                        list.Add(aSSiteMapNode_DetailedEntity);
                    }
                }
            }
        }

        //public static String[] GetRolesForAssignToUserByMemberID(Int64 memberID)
        //{
        //    String[] roleList = null;

        //    MembershipUser member = GetASPNETUserByMemberID(memberID);

        //    String filterExpression = SqlExpressionBuilder.PrepareFilterExpression(HRMemberUserCreationRoleListEntity.FLD_NAME_MemberID, memberID.ToString(), SQLMatchType.Equal);

        //    IList<ERMMemberUserCreationRoleListEntity> eRMMemberUserCreationRoleListEntityList = FCCERMMemberUserCreationRoleList.GetFacadeCreate().GetIL(null, null, String.Empty, filterExpression, DatabaseOperationType.LoadWithFilterExpression);

        //    if (eRMMemberUserCreationRoleListEntityList != null && eRMMemberUserCreationRoleListEntityList.Count > 0)
        //    {
        //        roleList = new String[eRMMemberUserCreationRoleListEntityList.Count];

        //        for (int i = 0; i < eRMMemberUserCreationRoleListEntityList.Count; i++)
        //        {
        //            roleList[i] = eRMMemberUserCreationRoleListEntityList[i].RoleName;
        //        }
        //    }

        //    return roleList;
        //}

        #endregion

        public static HRMemberEntity CreateMember(HRMemberEntity member)
        {
            Int64 memberID = FCCHRMember.GetFacadeCreate().Add(member, DatabaseOperationType.Add, TransactionRequired.No);

            if (memberID > 0)
            {
                member.MemberID = memberID;

                return member;
            }

            return null;
        }       

        public static void SetMemberSourceInfo(Int64 addedByMemberID, Int64 newMemberID, Int64 mDMemberSourceCategoryID)
        {
 
        }

        public static void AssignRoleToUser(String userName, String roleName)
        {
            Roles.AddUserToRole(userName, roleName);
        }	
    }
}