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
    public sealed partial class MDProjectFloorUnitTypeFacade : IMDProjectFloorUnitTypeFacade
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

        public MDProjectFloorUnitTypeFacade()
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

        ~MDProjectFloorUnitTypeFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDProjectFloorUnitTypeFacade.Add(MDProjectFloorUnitTypeEntity mDProjectFloorUnitTypeEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitTypeDataAccess().Add(mDProjectFloorUnitTypeEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDProjectFloorUnitTypeFacade.Update(MDProjectFloorUnitTypeEntity mDProjectFloorUnitTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitTypeDataAccess().Update(mDProjectFloorUnitTypeEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDProjectFloorUnitTypeFacade.Delete(MDProjectFloorUnitTypeEntity mDProjectFloorUnitTypeEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitTypeDataAccess().Delete(mDProjectFloorUnitTypeEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDProjectFloorUnitTypeFacade.Add(IList<MDProjectFloorUnitTypeEntity> mDProjectFloorUnitTypeEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitTypeDataAccess().Add(mDProjectFloorUnitTypeEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDProjectFloorUnitTypeFacade.Update(IList<MDProjectFloorUnitTypeEntity> mDProjectFloorUnitTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitTypeDataAccess().Update(mDProjectFloorUnitTypeEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDProjectFloorUnitTypeFacade.Delete(IList<MDProjectFloorUnitTypeEntity> mDProjectFloorUnitTypeEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitTypeDataAccess().Delete(mDProjectFloorUnitTypeEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDProjectFloorUnitTypeEntity> IMDProjectFloorUnitTypeFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitTypeDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDProjectFloorUnitTypeFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDProjectFloorUnitTypeDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDProjectFloorUnitTypeEntity IMDProjectFloorUnitTypeFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDProjectFloorUnitTypeEntity.FLD_NAME_ProjectFloorUnitTypeID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDProjectFloorUnitTypeDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
