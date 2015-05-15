// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 04-Nov-2013, 12:21:52




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
    public sealed partial class MDEventInvitatedPersonTypeFacade : IMDEventInvitatedPersonTypeFacade
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

        public MDEventInvitatedPersonTypeFacade()
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

        ~MDEventInvitatedPersonTypeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDEventInvitatedPersonTypeFacade.Add(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEventInvitatedPersonTypeDataAccess().Add(mDEventInvitatedPersonTypeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEventInvitatedPersonTypeFacade.Update(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEventInvitatedPersonTypeDataAccess().Update(mDEventInvitatedPersonTypeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDEventInvitatedPersonTypeFacade.Delete(MDEventInvitatedPersonTypeEntity mDEventInvitatedPersonTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEventInvitatedPersonTypeDataAccess().Delete(mDEventInvitatedPersonTypeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDEventInvitatedPersonTypeFacade.Add(IList<MDEventInvitatedPersonTypeEntity> mDEventInvitatedPersonTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEventInvitatedPersonTypeDataAccess().Add(mDEventInvitatedPersonTypeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEventInvitatedPersonTypeFacade.Update(IList<MDEventInvitatedPersonTypeEntity> mDEventInvitatedPersonTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEventInvitatedPersonTypeDataAccess().Update(mDEventInvitatedPersonTypeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDEventInvitatedPersonTypeFacade.Delete(IList<MDEventInvitatedPersonTypeEntity> mDEventInvitatedPersonTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDEventInvitatedPersonTypeDataAccess().Delete(mDEventInvitatedPersonTypeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDEventInvitatedPersonTypeEntity> IMDEventInvitatedPersonTypeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEventInvitatedPersonTypeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDEventInvitatedPersonTypeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDEventInvitatedPersonTypeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDEventInvitatedPersonTypeEntity IMDEventInvitatedPersonTypeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDEventInvitatedPersonTypeEntity.FLD_NAME_EventInvitatedPersonTypeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDEventInvitatedPersonTypeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
