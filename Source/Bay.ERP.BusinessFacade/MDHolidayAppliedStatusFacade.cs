// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 19-Dec-2013, 12:42:28




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
    public sealed partial class MDHolidayAppliedStatusFacade : IMDHolidayAppliedStatusFacade
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

        public MDHolidayAppliedStatusFacade()
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

        ~MDHolidayAppliedStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDHolidayAppliedStatusFacade.Add(MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHolidayAppliedStatusDataAccess().Add(mDHolidayAppliedStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDHolidayAppliedStatusFacade.Update(MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHolidayAppliedStatusDataAccess().Update(mDHolidayAppliedStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDHolidayAppliedStatusFacade.Delete(MDHolidayAppliedStatusEntity mDHolidayAppliedStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHolidayAppliedStatusDataAccess().Delete(mDHolidayAppliedStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDHolidayAppliedStatusFacade.Add(IList<MDHolidayAppliedStatusEntity> mDHolidayAppliedStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHolidayAppliedStatusDataAccess().Add(mDHolidayAppliedStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDHolidayAppliedStatusFacade.Update(IList<MDHolidayAppliedStatusEntity> mDHolidayAppliedStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHolidayAppliedStatusDataAccess().Update(mDHolidayAppliedStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDHolidayAppliedStatusFacade.Delete(IList<MDHolidayAppliedStatusEntity> mDHolidayAppliedStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDHolidayAppliedStatusDataAccess().Delete(mDHolidayAppliedStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDHolidayAppliedStatusEntity> IMDHolidayAppliedStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDHolidayAppliedStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDHolidayAppliedStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDHolidayAppliedStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDHolidayAppliedStatusEntity IMDHolidayAppliedStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDHolidayAppliedStatusEntity.FLD_NAME_HolidayAppliedStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDHolidayAppliedStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
