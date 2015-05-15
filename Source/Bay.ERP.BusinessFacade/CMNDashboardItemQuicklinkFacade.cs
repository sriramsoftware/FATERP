// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 08-Mar-2012, 11:45:48




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
    public sealed partial class CMNDashboardItemQuicklinkFacade : ICMNDashboardItemQuicklinkFacade
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

        public CMNDashboardItemQuicklinkFacade()
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

        ~CMNDashboardItemQuicklinkFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMNDashboardItemQuicklinkFacade.Add(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNDashboardItemQuicklinkDataAccess().Add(cMNDashboardItemQuicklinkEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNDashboardItemQuicklinkFacade.Update(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNDashboardItemQuicklinkDataAccess().Update(cMNDashboardItemQuicklinkEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNDashboardItemQuicklinkFacade.Delete(CMNDashboardItemQuicklinkEntity cMNDashboardItemQuicklinkEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNDashboardItemQuicklinkDataAccess().Delete(cMNDashboardItemQuicklinkEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMNDashboardItemQuicklinkFacade.Add(IList<CMNDashboardItemQuicklinkEntity> cMNDashboardItemQuicklinkEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNDashboardItemQuicklinkDataAccess().Add(cMNDashboardItemQuicklinkEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNDashboardItemQuicklinkFacade.Update(IList<CMNDashboardItemQuicklinkEntity> cMNDashboardItemQuicklinkEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNDashboardItemQuicklinkDataAccess().Update(cMNDashboardItemQuicklinkEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNDashboardItemQuicklinkFacade.Delete(IList<CMNDashboardItemQuicklinkEntity> cMNDashboardItemQuicklinkEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNDashboardItemQuicklinkDataAccess().Delete(cMNDashboardItemQuicklinkEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMNDashboardItemQuicklinkEntity> ICMNDashboardItemQuicklinkFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNDashboardItemQuicklinkDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMNDashboardItemQuicklinkFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNDashboardItemQuicklinkDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMNDashboardItemQuicklinkEntity ICMNDashboardItemQuicklinkFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNDashboardItemQuicklinkEntity.FLD_NAME_DashboardItemQuicklinkID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMNDashboardItemQuicklinkDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
