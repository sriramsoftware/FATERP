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
    public sealed partial class MDReligionFacade : IMDReligionFacade
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

        public MDReligionFacade()
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

        ~MDReligionFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IMDReligionFacade.Add(MDReligionEntity mDReligionEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDReligionDataAccess().Add(mDReligionEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IMDReligionFacade.Update(MDReligionEntity mDReligionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDReligionDataAccess().Update(mDReligionEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IMDReligionFacade.Delete(MDReligionEntity mDReligionEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDReligionDataAccess().Delete(mDReligionEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IMDReligionFacade.Add(IList<MDReligionEntity> mDReligionEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDReligionDataAccess().Add(mDReligionEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDReligionFacade.Update(IList<MDReligionEntity> mDReligionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDReligionDataAccess().Update(mDReligionEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IMDReligionFacade.Delete(IList<MDReligionEntity> mDReligionEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateMDReligionDataAccess().Delete(mDReligionEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<MDReligionEntity> IMDReligionFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDReligionDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IMDReligionFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateMDReligionDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        MDReligionEntity IMDReligionFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(MDReligionEntity.FLD_NAME_ReligionID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateMDReligionDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
