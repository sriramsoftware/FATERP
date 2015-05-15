// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 06-Oct-2013, 05:27:25




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
    public sealed partial class CMNMDSharedSettingFacade : ICMNMDSharedSettingFacade
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

        public CMNMDSharedSettingFacade()
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

        ~CMNMDSharedSettingFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMNMDSharedSettingFacade.Add(CMNMDSharedSettingEntity cMNMDSharedSettingEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDSharedSettingDataAccess().Add(cMNMDSharedSettingEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNMDSharedSettingFacade.Update(CMNMDSharedSettingEntity cMNMDSharedSettingEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDSharedSettingDataAccess().Update(cMNMDSharedSettingEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNMDSharedSettingFacade.Delete(CMNMDSharedSettingEntity cMNMDSharedSettingEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDSharedSettingDataAccess().Delete(cMNMDSharedSettingEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMNMDSharedSettingFacade.Add(IList<CMNMDSharedSettingEntity> cMNMDSharedSettingEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDSharedSettingDataAccess().Add(cMNMDSharedSettingEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNMDSharedSettingFacade.Update(IList<CMNMDSharedSettingEntity> cMNMDSharedSettingEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDSharedSettingDataAccess().Update(cMNMDSharedSettingEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNMDSharedSettingFacade.Delete(IList<CMNMDSharedSettingEntity> cMNMDSharedSettingEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNMDSharedSettingDataAccess().Delete(cMNMDSharedSettingEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMNMDSharedSettingEntity> ICMNMDSharedSettingFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNMDSharedSettingDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMNMDSharedSettingFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNMDSharedSettingDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMNMDSharedSettingEntity ICMNMDSharedSettingFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNMDSharedSettingEntity.FLD_NAME_SharedSettingID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMNMDSharedSettingDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
