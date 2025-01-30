using System;
using System.Linq;
using System.Linq.Expressions;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DevExpress.Mvvm;
using DevExpress.Mvvm.POCO;
using DevExpress.Mvvm.DataModel;
using DevExpress.Mvvm.ViewModel;
using StudentWindowsFormsApp.studentprojectEntitiesDataModel;
using StudentWindowsFormsApp.Common;
using StudentWindowsFormsApp;

namespace StudentWindowsFormsApp.ViewModels {

    /// <summary>
    /// Represents the single department object view model.
    /// </summary>
    public partial class departmentViewModel : SingleObjectViewModel<department, Guid, IstudentprojectEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of departmentViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static departmentViewModel Create(IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new departmentViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the departmentViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the departmentViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected departmentViewModel(IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.departments, x => x.deptname) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of assignments for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<assignment> LookUpassignments {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (departmentViewModel x) => x.LookUpassignments,
                    getRepositoryFunc: x => x.assignments);
            }
        }


        /// <summary>
        /// The view model for the departmentassignments detail collection.
        /// </summary>
        public CollectionViewModelBase<assignment, assignment, Guid, IstudentprojectEntitiesUnitOfWork> departmentassignmentsDetails {
            get {
                return GetDetailsCollectionViewModel(
                    propertyExpression: (departmentViewModel x) => x.departmentassignmentsDetails,
                    getRepositoryFunc: x => x.assignments,
                    foreignKeyExpression: x => x.deptID,
                    navigationExpression: x => x.department);
            }
        }
    }
}
