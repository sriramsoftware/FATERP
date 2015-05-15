using System.Collections.Generic;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.Common.Shared;

namespace Bay.ERP.DataAccess
{
    internal abstract class BaseEntityBuilder
    {
        #region Instance Variables

        private Context _context = new Context();
        private static Dictionary<int, HRMemberEntity> _memberCache = new Dictionary<int, HRMemberEntity>();

        #endregion

        #region Properties

        #endregion

        #region Constructer & Destructer

        protected BaseEntityBuilder()
        {

        }

        #endregion

        #region Protected Methods

        protected HRMemberEntity GetMember(int memberId)
        {
            if (!_memberCache.ContainsKey(memberId))
            {
                IHRMemberDataAccess da = new HRMemberDataAccess(_context);

                //Member member = da.GetById(memberId); reza changed this
                //MemberEntity member = da.GetAll()[0];
                HRMemberEntity member = null;

                if (member == null)
                {
                    return null;
                }

                _memberCache.Add(memberId, member);
            }

            return _memberCache[memberId];
        }

        #endregion
    }
}