// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 01-Apr-2013, 03:04:35




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
    public sealed partial class MDProjectFloorUnitStatusFacade : IMDProjectFloorUnitStatusFacade
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

        public MDProjectFloorUnitStatusFacade()
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

        ~MDProjectFloorUnitStatusFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDProjectFloorUnitStatusFacade.Add(MDProjectFloorUnitStatusEntity mDProjectFloorUnitStatusEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitStatusDataAccess().Add(mDProjectFloorUnitStatusEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDProjectFloorUnitStatusFacade.Update(MDProjectFloorUnitStatusEntity mDProjectFloorUnitStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitStatusDataAccess().Update(mDProjectFloorUnitStatusEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDProjectFloorUnitStatusFacade.Delete(MDProjectFloorUnitStatusEntity mDProjectFloorUnitStatusEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitStatusDataAccess().Delete(mDProjectFloorUnitStatusEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDProjectFloorUnitStatusFacade.Add(IList<MDProjectFloorUnitStatusEntity> mDProjectFloorUnitStatusEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitStatusDataAccess().Add(mDProjectFloorUnitStatusEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDProjectFloorUnitStatusFacade.Update(IList<MDProjectFloorUnitStatusEntity> mDProjectFloorUnitStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitStatusDataAccess().Update(mDProjectFloorUnitStatusEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDProjectFloorUnitStatusFacade.Delete(IList<MDProjectFloorUnitStatusEntity> mDProjectFloorUnitStatusEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitStatusDataAccess().Delete(mDProjectFloorUnitStatusEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDProjectFloorUnitStatusEntity> IMDProjectFloorUnitStatusFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitStatusDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDProjectFloorUnitStatusFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitStatusDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDProjectFloorUnitStatusEntity IMDProjectFloorUnitStatusFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectFloorUnitStatusEntity.FLD_NAME_ProjectFloorUnitStatusID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDProjectFloorUnitStatusDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
