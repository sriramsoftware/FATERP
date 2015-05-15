// Copyright and All Rights Reserved by
// TalentPlus Software Inc, USA; 
// Delphi Solutions Ltd., Bangladesh,
// TalentPlus Software FZ LLC, UAE; 
// TalentPlus Systems India Pvt Ltd., India. 
//
// Faisal Alam, faisal@talentPlusSoft.con
// ©2006 – 2010.
//
// Code Generate Time - 22-Jun-2013, 02:07:00




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
    public sealed partial class BDProjectSubstationAndGeneratorFacade : IBDProjectSubstationAndGeneratorFacade
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

        public BDProjectSubstationAndGeneratorFacade()
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

        ~BDProjectSubstationAndGeneratorFacade()
        {
            Dispose(false);
        }

        #endregion


        #region Business Facade


        #region Save Update Delete

        [OperationContract]
        Int64 IBDProjectSubstationAndGeneratorFacade.Add(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectSubstationAndGeneratorDataAccess().Add(bDProjectSubstationAndGeneratorEntity, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectSubstationAndGeneratorFacade.Update(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectSubstationAndGeneratorDataAccess().Update(bDProjectSubstationAndGeneratorEntity, filterExpression, option, reqTran);
        }

        [OperationContract]
        Int64 IBDProjectSubstationAndGeneratorFacade.Delete(BDProjectSubstationAndGeneratorEntity bDProjectSubstationAndGeneratorEntity, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectSubstationAndGeneratorDataAccess().Delete(bDProjectSubstationAndGeneratorEntity, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete

        #region Save Update Delete List

        [OperationContract]
        IList<Int64> IBDProjectSubstationAndGeneratorFacade.Add(IList<BDProjectSubstationAndGeneratorEntity> bDProjectSubstationAndGeneratorEntityList, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectSubstationAndGeneratorDataAccess().Add(bDProjectSubstationAndGeneratorEntityList, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectSubstationAndGeneratorFacade.Update(IList<BDProjectSubstationAndGeneratorEntity> bDProjectSubstationAndGeneratorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectSubstationAndGeneratorDataAccess().Update(bDProjectSubstationAndGeneratorEntityList, filterExpression, option, reqTran);
        }

        [OperationContract]
        IList<Int64> IBDProjectSubstationAndGeneratorFacade.Delete(IList<BDProjectSubstationAndGeneratorEntity> bDProjectSubstationAndGeneratorEntityList, String filterExpression, DatabaseOperationType option, TransactionRequired reqTran)
        {
            return DataAccessFactory.CreateBDProjectSubstationAndGeneratorDataAccess().Delete(bDProjectSubstationAndGeneratorEntityList, filterExpression, option, reqTran);
        }

        #endregion Save Update Delete List

        #region Get

        [OperationContract]
        IList<BDProjectSubstationAndGeneratorEntity> IBDProjectSubstationAndGeneratorFacade.GetIL(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectSubstationAndGeneratorDataAccess().GetIL(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        DataTable IBDProjectSubstationAndGeneratorFacade.GetDT(Int32? currentPage, Int32? pageSize, String sortExpression, String filterExpression, DatabaseOperationType option)
        {
            return DataAccessFactory.CreateBDProjectSubstationAndGeneratorDataAccess().GetDT(currentPage, pageSize, sortExpression, filterExpression, option);
        }

        [OperationContract]
        BDProjectSubstationAndGeneratorEntity IBDProjectSubstationAndGeneratorFacade.GetByID(Int64 iD)
        {
        String fe = SqlExpressionBuilder.PrepareFilterExpression(BDProjectSubstationAndGeneratorEntity.FLD_NAME_ProjectSubstationAndGeneratorID, iD.ToString(), SQLMatchType.Equal);

        return DataAccessFactory.CreateBDProjectSubstationAndGeneratorDataAccess().GetIL(null, null, String.Empty, fe, DatabaseOperationType.LoadWithFilterExpression)[0];
        }

        #endregion Get


        #endregion
    }
}
