// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 23-Sep-2012, 10:06:41




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
    public sealed partial class DMSFileTrackingFacade : IDMSFileTrackingFacade
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

        public DMSFileTrackingFacade()
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

        ~DMSFileTrackingFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IDMSFileTrackingFacade.Add(DMSFileTrackingEntity dMSFileTrackingEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileTrackingDataAccess().Add(dMSFileTrackingEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IDMSFileTrackingFacade.Update(DMSFileTrackingEntity dMSFileTrackingEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileTrackingDataAccess().Update(dMSFileTrackingEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IDMSFileTrackingFacade.Delete(DMSFileTrackingEntity dMSFileTrackingEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileTrackingDataAccess().Delete(dMSFileTrackingEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IDMSFileTrackingFacade.Add(IList<DMSFileTrackingEntity> dMSFileTrackingEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileTrackingDataAccess().Add(dMSFileTrackingEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IDMSFileTrackingFacade.Update(IList<DMSFileTrackingEntity> dMSFileTrackingEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileTrackingDataAccess().Update(dMSFileTrackingEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IDMSFileTrackingFacade.Delete(IList<DMSFileTrackingEntity> dMSFileTrackingEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateDMSFileTrackingDataAccess().Delete(dMSFileTrackingEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<DMSFileTrackingEntity> IDMSFileTrackingFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateDMSFileTrackingDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IDMSFileTrackingFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateDMSFileTrackingDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DMSFileTrackingEntity IDMSFileTrackingFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(DMSFileTrackingEntity.FLD_NAME_FileTrackingID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateDMSFileTrackingDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}