// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 20-Oct-2012, 11:32:20




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
    public sealed partial class APPanelForwardMemberFacade : IAPPanelForwardMemberFacade
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

        public APPanelForwardMemberFacade()
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

        ~APPanelForwardMemberFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IAPPanelForwardMemberFacade.Add(APPanelForwardMemberEntity aPPanelForwardMemberEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPPanelForwardMemberDataAccess().Add(aPPanelForwardMemberEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IAPPanelForwardMemberFacade.Update(APPanelForwardMemberEntity aPPanelForwardMemberEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPPanelForwardMemberDataAccess().Update(aPPanelForwardMemberEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IAPPanelForwardMemberFacade.Delete(APPanelForwardMemberEntity aPPanelForwardMemberEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPPanelForwardMemberDataAccess().Delete(aPPanelForwardMemberEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IAPPanelForwardMemberFacade.Add(IList<APPanelForwardMemberEntity> aPPanelForwardMemberEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPPanelForwardMemberDataAccess().Add(aPPanelForwardMemberEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IAPPanelForwardMemberFacade.Update(IList<APPanelForwardMemberEntity> aPPanelForwardMemberEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPPanelForwardMemberDataAccess().Update(aPPanelForwardMemberEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IAPPanelForwardMemberFacade.Delete(IList<APPanelForwardMemberEntity> aPPanelForwardMemberEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateAPPanelForwardMemberDataAccess().Delete(aPPanelForwardMemberEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<APPanelForwardMemberEntity> IAPPanelForwardMemberFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateAPPanelForwardMemberDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IAPPanelForwardMemberFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateAPPanelForwardMemberDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        APPanelForwardMemberEntity IAPPanelForwardMemberFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(APPanelForwardMemberEntity.FLD_NAME_APPanelForwardMemberID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateAPPanelForwardMemberDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
