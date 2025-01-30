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
    /// Represents the single assignment object view model.
    /// </summary>
    public partial class assignmentViewModel : SingleObjectViewModel<assignment, Guid, IstudentprojectEntitiesUnitOfWork> {

        /// <summary>
        /// Creates a new instance of assignmentViewModel as a POCO view model.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        public static assignmentViewModel Create(IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> unitOfWorkFactory = null) {
            return ViewModelSource.Create(() => new assignmentViewModel(unitOfWorkFactory));
        }

        /// <summary>
        /// Initializes a new instance of the assignmentViewModel class.
        /// This constructor is declared protected to avoid undesired instantiation of the assignmentViewModel type without the POCO proxy factory.
        /// </summary>
        /// <param name="unitOfWorkFactory">A factory used to create a unit of work instance.</param>
        protected assignmentViewModel(IUnitOfWorkFactory<IstudentprojectEntitiesUnitOfWork> unitOfWorkFactory = null)
            : base(unitOfWorkFactory ?? UnitOfWorkSource.GetUnitOfWorkFactory(), x => x.assignments, x => x.createdby) {
                }


        /// <summary>
        /// The view model that contains a look-up collection of departments for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<department> LookUpdepartments {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (assignmentViewModel x) => x.LookUpdepartments,
                    getRepositoryFunc: x => x.departments);
            }
        }
        /// <summary>
        /// The view model that contains a look-up collection of employees for the corresponding navigation property in the view.
        /// </summary>
        public IEntitiesViewModel<employee> LookUpemployees {
            get {
                return GetLookUpEntitiesViewModel(
                    propertyExpression: (assignmentViewModel x) => x.LookUpemployees,
                    getRepositoryFunc: x => x.employees);
            }
        }

    }
}
