// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Oct-2013, 10:57:26




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
    public sealed partial class CMNMDEventIdentityCategoryFacade : ICMNMDEventIdentityCategoryFacade
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

        public CMNMDEventIdentityCategoryFacade()
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

        ~CMNMDEventIdentityCategoryFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMNMDEventIdentityCategoryFacade.Add(CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDEventIdentityCategoryDataAccess().Add(cMNMDEventIdentityCategoryEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNMDEventIdentityCategoryFacade.Update(CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDEventIdentityCategoryDataAccess().Update(cMNMDEventIdentityCategoryEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNMDEventIdentityCategoryFacade.Delete(CMNMDEventIdentityCategoryEntity cMNMDEventIdentityCategoryEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDEventIdentityCategoryDataAccess().Delete(cMNMDEventIdentityCategoryEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMNMDEventIdentityCategoryFacade.Add(IList<CMNMDEventIdentityCategoryEntity> cMNMDEventIdentityCategoryEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDEventIdentityCategoryDataAccess().Add(cMNMDEventIdentityCategoryEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNMDEventIdentityCategoryFacade.Update(IList<CMNMDEventIdentityCategoryEntity> cMNMDEventIdentityCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDEventIdentityCategoryDataAccess().Update(cMNMDEventIdentityCategoryEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNMDEventIdentityCategoryFacade.Delete(IList<CMNMDEventIdentityCategoryEntity> cMNMDEventIdentityCategoryEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDEventIdentityCategoryDataAccess().Delete(cMNMDEventIdentityCategoryEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMNMDEventIdentityCategoryEntity> ICMNMDEventIdentityCategoryFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNMDEventIdentityCategoryDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMNMDEventIdentityCategoryFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNMDEventIdentityCategoryDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMNMDEventIdentityCategoryEntity ICMNMDEventIdentityCategoryFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNMDEventIdentityCategoryEntity.FLD_NAME_EventIdentityCategoryID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMNMDEventIdentityCategoryDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
