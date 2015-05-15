// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 25-Jun-2012, 05:50:09




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
    public sealed partial class PRMWorkOrderItemMapFacade : IPRMWorkOrderItemMapFacade
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

        public PRMWorkOrderItemMapFacade()
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

        ~PRMWorkOrderItemMapFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IPRMWorkOrderItemMapFacade.Add(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemMapDataAccess().Add(pRMWorkOrderItemMapEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMWorkOrderItemMapFacade.Update(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemMapDataAccess().Update(pRMWorkOrderItemMapEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IPRMWorkOrderItemMapFacade.Delete(PRMWorkOrderItemMapEntity pRMWorkOrderItemMapEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemMapDataAccess().Delete(pRMWorkOrderItemMapEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IPRMWorkOrderItemMapFacade.Add(IList<PRMWorkOrderItemMapEntity> pRMWorkOrderItemMapEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemMapDataAccess().Add(pRMWorkOrderItemMapEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMWorkOrderItemMapFacade.Update(IList<PRMWorkOrderItemMapEntity> pRMWorkOrderItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemMapDataAccess().Update(pRMWorkOrderItemMapEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IPRMWorkOrderItemMapFacade.Delete(IList<PRMWorkOrderItemMapEntity> pRMWorkOrderItemMapEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemMapDataAccess().Delete(pRMWorkOrderItemMapEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<PRMWorkOrderItemMapEntity> IPRMWorkOrderItemMapFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemMapDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IPRMWorkOrderItemMapFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreatePRMWorkOrderItemMapDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        PRMWorkOrderItemMapEntity IPRMWorkOrderItemMapFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(PRMWorkOrderItemMapEntity.FLD_NAME_WorkOrderItemMapID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreatePRMWorkOrderItemMapDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
