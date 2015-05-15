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
    public sealed partial class HRMemberLeaveOpeningBalanceFacade : IHRMemberLeaveOpeningBalanceFacade
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

        public HRMemberLeaveOpeningBalanceFacade()
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

        ~HRMemberLeaveOpeningBalanceFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IHRMemberLeaveOpeningBalanceFacade.Add(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveOpeningBalanceDataAccess().Add(hRMemberLeaveOpeningBalanceEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IHRMemberLeaveOpeningBalanceFacade.Update(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveOpeningBalanceDataAccess().Update(hRMemberLeaveOpeningBalanceEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IHRMemberLeaveOpeningBalanceFacade.Delete(HRMemberLeaveOpeningBalanceEntity hRMemberLeaveOpeningBalanceEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveOpeningBalanceDataAccess().Delete(hRMemberLeaveOpeningBalanceEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IHRMemberLeaveOpeningBalanceFacade.Add(IList<HRMemberLeaveOpeningBalanceEntity> hRMemberLeaveOpeningBalanceEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveOpeningBalanceDataAccess().Add(hRMemberLeaveOpeningBalanceEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHRMemberLeaveOpeningBalanceFacade.Update(IList<HRMemberLeaveOpeningBalanceEntity> hRMemberLeaveOpeningBalanceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveOpeningBalanceDataAccess().Update(hRMemberLeaveOpeningBalanceEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IHRMemberLeaveOpeningBalanceFacade.Delete(IList<HRMemberLeaveOpeningBalanceEntity> hRMemberLeaveOpeningBalanceEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateHRMemberLeaveOpeningBalanceDataAccess().Delete(hRMemberLeaveOpeningBalanceEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<HRMemberLeaveOpeningBalanceEntity> IHRMemberLeaveOpeningBalanceFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHRMemberLeaveOpeningBalanceDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IHRMemberLeaveOpeningBalanceFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateHRMemberLeaveOpeningBalanceDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        HRMemberLeaveOpeningBalanceEntity IHRMemberLeaveOpeningBalanceFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(HRMemberLeaveOpeningBalanceEntity.FLD_NAME_MemberLeaveOpeningBalanceID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateHRMemberLeaveOpeningBalanceDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
