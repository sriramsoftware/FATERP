// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 12-Jan-2014, 03:42:17




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
    public sealed partial class MDSalaryRateDurationFacade : IMDSalaryRateDurationFacade
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

        public MDSalaryRateDurationFacade()
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

        ~MDSalaryRateDurationFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDSalaryRateDurationFacade.Add(MDSalaryRateDurationEntity mDSalaryRateDurationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSalaryRateDurationDataAccess().Add(mDSalaryRateDurationEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDSalaryRateDurationFacade.Update(MDSalaryRateDurationEntity mDSalaryRateDurationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSalaryRateDurationDataAccess().Update(mDSalaryRateDurationEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDSalaryRateDurationFacade.Delete(MDSalaryRateDurationEntity mDSalaryRateDurationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSalaryRateDurationDataAccess().Delete(mDSalaryRateDurationEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDSalaryRateDurationFacade.Add(IList<MDSalaryRateDurationEntity> mDSalaryRateDurationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSalaryRateDurationDataAccess().Add(mDSalaryRateDurationEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDSalaryRateDurationFacade.Update(IList<MDSalaryRateDurationEntity> mDSalaryRateDurationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSalaryRateDurationDataAccess().Update(mDSalaryRateDurationEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDSalaryRateDurationFacade.Delete(IList<MDSalaryRateDurationEntity> mDSalaryRateDurationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDSalaryRateDurationDataAccess().Delete(mDSalaryRateDurationEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDSalaryRateDurationEntity> IMDSalaryRateDurationFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDSalaryRateDurationDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDSalaryRateDurationFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDSalaryRateDurationDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDSalaryRateDurationEntity IMDSalaryRateDurationFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDSalaryRateDurationEntity.FLD_NAME_SalaryRateDurationID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDSalaryRateDurationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
