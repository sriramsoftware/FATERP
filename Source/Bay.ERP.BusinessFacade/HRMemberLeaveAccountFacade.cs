// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Dec-2013, 02:17:52




using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.ServiceModel;
using System.Diagnostics;

using Bay.ERP.Common.BusinessEntities;
using Bay.ERP.DataAccess;
using Bay.ERP.BusinessFacade;
using Bay.ERP.Common.Shared;
using Bay.ERP.Common.Helper;

namespace Bay.ERP.BusinessFacade
{
    public sealed partial class HRMemberLeaveAccountFacade : IHRMemberLeaveAccountFacade
    {

        #region Instance Variables

        private bool _isDisposed;
        private Context _currentContext;

        private BaseDataAccessFactory _dataAccessFactory;

        #endregion

        #region Private Properties

        private Context CurrentContext
        {
            [DebuggerStepThrough()]
            get
            {
                if (_currentContext == null)
                {
                    _currentContext = new Context();
                }

                return _currentContext;
            }
        }

        private BaseDataAccessFactory DataAccessFactory
        {
            [DebuggerStepThrough()]
            get
            {
                if (_dataAccessFactory == null)
                {
                    _dataAccessFactory = BaseDataAccessFactory.Create(CurrentContext);
                }

                return _dataAccessFactory;
            }
        }

        #endregion

        #region Constructer & Destructor

        public HRMemberLeaveAccountFacade()
            : base()
        {
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        private void Dispose(bool disposing)
        {
            if (!_isDisposed)
            {
                if (disposing)
                {
                    if (_currentContext != null)
                    {
                        _currentContext.Dispose();
                    }
                }
            }

            _isDisposed = true;
        }

        ~HRMemberLeaveAccountFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHRMemberLeaveAccountFacade.Add(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveAccountDataAccess().Add(hRMemberLeaveAccountEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHRMemberLeaveAccountFacade.Update(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveAccountDataAccess().Update(hRMemberLeaveAccountEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHRMemberLeaveAccountFacade.Delete(HRMemberLeaveAccountEntity hRMemberLeaveAccountEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveAccountDataAccess().Delete(hRMemberLeaveAccountEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHRMemberLeaveAccountFacade.Add(IList<HRMemberLeaveAccountEntity> hRMemberLeaveAccountEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveAccountDataAccess().Add(hRMemberLeaveAccountEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHRMemberLeaveAccountFacade.Update(IList<HRMemberLeaveAccountEntity> hRMemberLeaveAccountEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveAccountDataAccess().Update(hRMemberLeaveAccountEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHRMemberLeaveAccountFacade.Delete(IList<HRMemberLeaveAccountEntity> hRMemberLeaveAccountEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveAccountDataAccess().Delete(hRMemberLeaveAccountEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HRMemberLeaveAccountEntity> IHRMemberLeaveAccountFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHRMemberLeaveAccountDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHRMemberLeaveAccountFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHRMemberLeaveAccountDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HRMemberLeaveAccountEntity IHRMemberLeaveAccountFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRMemberLeaveAccountEntity.FLD_NAME_MemberLeaveAccountID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHRMemberLeaveAccountDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
