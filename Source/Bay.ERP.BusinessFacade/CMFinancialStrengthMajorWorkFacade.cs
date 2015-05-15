// Copyright and All Rights Reserved by
//B2B Solution, Bangladesh;
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 07-Jan-2012, 02:49:42




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
    public sealed partial class CMFinancialStrengthMajorWorkFacade : ICMFinancialStrengthMajorWorkFacade
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

        public CMFinancialStrengthMajorWorkFacade()
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

        ~CMFinancialStrengthMajorWorkFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMFinancialStrengthMajorWorkFacade.Add(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMFinancialStrengthMajorWorkDataAccess().Add(cMFinancialStrengthMajorWorkEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMFinancialStrengthMajorWorkFacade.Update(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMFinancialStrengthMajorWorkDataAccess().Update(cMFinancialStrengthMajorWorkEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMFinancialStrengthMajorWorkFacade.Delete(CMFinancialStrengthMajorWorkEntity cMFinancialStrengthMajorWorkEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMFinancialStrengthMajorWorkDataAccess().Delete(cMFinancialStrengthMajorWorkEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMFinancialStrengthMajorWorkFacade.Add(IList<CMFinancialStrengthMajorWorkEntity> cMFinancialStrengthMajorWorkEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMFinancialStrengthMajorWorkDataAccess().Add(cMFinancialStrengthMajorWorkEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMFinancialStrengthMajorWorkFacade.Update(IList<CMFinancialStrengthMajorWorkEntity> cMFinancialStrengthMajorWorkEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMFinancialStrengthMajorWorkDataAccess().Update(cMFinancialStrengthMajorWorkEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMFinancialStrengthMajorWorkFacade.Delete(IList<CMFinancialStrengthMajorWorkEntity> cMFinancialStrengthMajorWorkEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMFinancialStrengthMajorWorkDataAccess().Delete(cMFinancialStrengthMajorWorkEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMFinancialStrengthMajorWorkEntity> ICMFinancialStrengthMajorWorkFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMFinancialStrengthMajorWorkDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMFinancialStrengthMajorWorkFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMFinancialStrengthMajorWorkDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMFinancialStrengthMajorWorkEntity ICMFinancialStrengthMajorWorkFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMFinancialStrengthMajorWorkEntity.FLD_NAME_FinancialStrengthMajorWorkID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMFinancialStrengthMajorWorkDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
