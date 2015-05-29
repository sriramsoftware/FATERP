// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 26-May-2015, 10:30:28




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
    public sealed partial class MDZoneDesignationFacade : IMDZoneDesignationFacade
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

        public MDZoneDesignationFacade()
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

        ~MDZoneDesignationFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDZoneDesignationFacade.Add(MDZoneDesignationEntity mDZoneDesignationEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDZoneDesignationDataAccess().Add(mDZoneDesignationEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDZoneDesignationFacade.Update(MDZoneDesignationEntity mDZoneDesignationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDZoneDesignationDataAccess().Update(mDZoneDesignationEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDZoneDesignationFacade.Delete(MDZoneDesignationEntity mDZoneDesignationEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDZoneDesignationDataAccess().Delete(mDZoneDesignationEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDZoneDesignationFacade.Add(IList<MDZoneDesignationEntity> mDZoneDesignationEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDZoneDesignationDataAccess().Add(mDZoneDesignationEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDZoneDesignationFacade.Update(IList<MDZoneDesignationEntity> mDZoneDesignationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDZoneDesignationDataAccess().Update(mDZoneDesignationEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDZoneDesignationFacade.Delete(IList<MDZoneDesignationEntity> mDZoneDesignationEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDZoneDesignationDataAccess().Delete(mDZoneDesignationEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDZoneDesignationEntity> IMDZoneDesignationFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDZoneDesignationDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDZoneDesignationFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDZoneDesignationDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDZoneDesignationEntity IMDZoneDesignationFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDZoneDesignationEntity.FLD_NAME_ZoneDesignationID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDZoneDesignationDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
