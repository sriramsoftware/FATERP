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
    public sealed partial class CMNEventInvitationInformationFacade : ICMNEventInvitationInformationFacade
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

        public CMNEventInvitationInformationFacade()
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

        ~CMNEventInvitationInformationFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 ICMNEventInvitationInformationFacade.Add(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNEventInvitationInformationDataAccess().Add(cMNEventInvitationInformationEntity, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNEventInvitationInformationFacade.Update(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNEventInvitationInformationDataAccess().Update(cMNEventInvitationInformationEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 ICMNEventInvitationInformationFacade.Delete(CMNEventInvitationInformationEntity cMNEventInvitationInformationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNEventInvitationInformationDataAccess().Delete(cMNEventInvitationInformationEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> ICMNEventInvitationInformationFacade.Add(IList<CMNEventInvitationInformationEntity> cMNEventInvitationInformationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNEventInvitationInformationDataAccess().Add(cMNEventInvitationInformationEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNEventInvitationInformationFacade.Update(IList<CMNEventInvitationInformationEntity> cMNEventInvitationInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNEventInvitationInformationDataAccess().Update(cMNEventInvitationInformationEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> ICMNEventInvitationInformationFacade.Delete(IList<CMNEventInvitationInformationEntity> cMNEventInvitationInformationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateCMNEventInvitationInformationDataAccess().Delete(cMNEventInvitationInformationEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<CMNEventInvitationInformationEntity> ICMNEventInvitationInformationFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNEventInvitationInformationDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable ICMNEventInvitationInformationFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateCMNEventInvitationInformationDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        CMNEventInvitationInformationEntity ICMNEventInvitationInformationFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(CMNEventInvitationInformationEntity.FLD_NAME_EventInvitationInformationID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateCMNEventInvitationInformationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
