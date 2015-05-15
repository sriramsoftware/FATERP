// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Mar-2013, 04:14:01




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
    public sealed partial class KBMDUserTreeSharedPermissionFacade : IKBMDUserTreeSharedPermissionFacade
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

        public KBMDUserTreeSharedPermissionFacade()
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

        ~KBMDUserTreeSharedPermissionFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IKBMDUserTreeSharedPermissionFacade.Add(KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSharedPermissionDataAccess().Add(kBMDUserTreeSharedPermissionEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IKBMDUserTreeSharedPermissionFacade.Update(KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSharedPermissionDataAccess().Update(kBMDUserTreeSharedPermissionEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IKBMDUserTreeSharedPermissionFacade.Delete(KBMDUserTreeSharedPermissionEntity kBMDUserTreeSharedPermissionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSharedPermissionDataAccess().Delete(kBMDUserTreeSharedPermissionEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IKBMDUserTreeSharedPermissionFacade.Add(IList<KBMDUserTreeSharedPermissionEntity> kBMDUserTreeSharedPermissionEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSharedPermissionDataAccess().Add(kBMDUserTreeSharedPermissionEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IKBMDUserTreeSharedPermissionFacade.Update(IList<KBMDUserTreeSharedPermissionEntity> kBMDUserTreeSharedPermissionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSharedPermissionDataAccess().Update(kBMDUserTreeSharedPermissionEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IKBMDUserTreeSharedPermissionFacade.Delete(IList<KBMDUserTreeSharedPermissionEntity> kBMDUserTreeSharedPermissionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateKBMDUserTreeSharedPermissionDataAccess().Delete(kBMDUserTreeSharedPermissionEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<KBMDUserTreeSharedPermissionEntity> IKBMDUserTreeSharedPermissionFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateKBMDUserTreeSharedPermissionDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IKBMDUserTreeSharedPermissionFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateKBMDUserTreeSharedPermissionDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        KBMDUserTreeSharedPermissionEntity IKBMDUserTreeSharedPermissionFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(KBMDUserTreeSharedPermissionEntity.FLD_NAME_UserTreeSharedPermissionID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateKBMDUserTreeSharedPermissionDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
