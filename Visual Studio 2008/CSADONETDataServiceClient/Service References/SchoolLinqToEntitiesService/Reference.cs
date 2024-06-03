//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.4927
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// Original file name:
// Generation date: 9/16/2009 7:23:24 PM
namespace CSADONETDataServiceClient.SchoolLinqToEntitiesService
{
    
    /// <summary>
    /// There are no comments for SQLServer2005DBEntities in the schema.
    /// </summary>
    public partial class SQLServer2005DBEntities : global::System.Data.Services.Client.DataServiceContext
    {
        /// <summary>
        /// Initialize a new SQLServer2005DBEntities object.
        /// </summary>
        public SQLServer2005DBEntities(global::System.Uri serviceRoot) : 
                base(serviceRoot)
        {
            this.ResolveName = new global::System.Func<global::System.Type, string>(this.ResolveNameFromType);
            this.ResolveType = new global::System.Func<string, global::System.Type>(this.ResolveTypeFromName);
            this.OnContextCreated();
        }
        partial void OnContextCreated();
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        protected global::System.Type ResolveTypeFromName(string typeName)
        {
            if (typeName.StartsWith("SQLServer2005DBModel", global::System.StringComparison.Ordinal))
            {
                return this.GetType().Assembly.GetType(string.Concat("CSADONETDataServiceClient.SchoolLinqToEntitiesService", typeName.Substring(20)), true);
            }
            return null;
        }
        /// <summary>
        /// Since the namespace configured for this service reference
        /// in Visual Studio is different from the one indicated in the
        /// server schema, use type-mappers to map between the two.
        /// </summary>
        protected string ResolveNameFromType(global::System.Type clientType)
        {
            if (clientType.Namespace.Equals("CSADONETDataServiceClient.SchoolLinqToEntitiesService", global::System.StringComparison.Ordinal))
            {
                return string.Concat("SQLServer2005DBModel.", clientType.Name);
            }
            return null;
        }
        /// <summary>
        /// There are no comments for Course in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceQuery<Course> Course
        {
            get
            {
                if ((this._Course == null))
                {
                    this._Course = base.CreateQuery<Course>("Course");
                }
                return this._Course;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<Course> _Course;
        /// <summary>
        /// There are no comments for CourseGrade in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceQuery<CourseGrade> CourseGrade
        {
            get
            {
                if ((this._CourseGrade == null))
                {
                    this._CourseGrade = base.CreateQuery<CourseGrade>("CourseGrade");
                }
                return this._CourseGrade;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<CourseGrade> _CourseGrade;
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        public global::System.Data.Services.Client.DataServiceQuery<Person> Person
        {
            get
            {
                if ((this._Person == null))
                {
                    this._Person = base.CreateQuery<Person>("Person");
                }
                return this._Person;
            }
        }
        private global::System.Data.Services.Client.DataServiceQuery<Person> _Person;
        /// <summary>
        /// There are no comments for Course in the schema.
        /// </summary>
        public void AddToCourse(Course course)
        {
            base.AddObject("Course", course);
        }
        /// <summary>
        /// There are no comments for CourseGrade in the schema.
        /// </summary>
        public void AddToCourseGrade(CourseGrade courseGrade)
        {
            base.AddObject("CourseGrade", courseGrade);
        }
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        public void AddToPerson(Person person)
        {
            base.AddObject("Person", person);
        }
    }
    /// <summary>
    /// There are no comments for SQLServer2005DBModel.Course in the schema.
    /// </summary>
    /// <KeyProperties>
    /// CourseID
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("CourseID")]
    public partial class Course
    {
        /// <summary>
        /// Create a new Course object.
        /// </summary>
        /// <param name="courseID">Initial value of CourseID.</param>
        /// <param name="title">Initial value of Title.</param>
        /// <param name="credits">Initial value of Credits.</param>
        /// <param name="departmentID">Initial value of DepartmentID.</param>
        public static Course CreateCourse(int courseID, string title, int credits, int departmentID)
        {
            Course course = new Course();
            course.CourseID = courseID;
            course.Title = title;
            course.Credits = credits;
            course.DepartmentID = departmentID;
            return course;
        }
        /// <summary>
        /// There are no comments for Property CourseID in the schema.
        /// </summary>
        public int CourseID
        {
            get
            {
                return this._CourseID;
            }
            set
            {
                this.OnCourseIDChanging(value);
                this._CourseID = value;
                this.OnCourseIDChanged();
            }
        }
        private int _CourseID;
        partial void OnCourseIDChanging(int value);
        partial void OnCourseIDChanged();
        /// <summary>
        /// There are no comments for Property Title in the schema.
        /// </summary>
        public string Title
        {
            get
            {
                return this._Title;
            }
            set
            {
                this.OnTitleChanging(value);
                this._Title = value;
                this.OnTitleChanged();
            }
        }
        private string _Title;
        partial void OnTitleChanging(string value);
        partial void OnTitleChanged();
        /// <summary>
        /// There are no comments for Property Credits in the schema.
        /// </summary>
        public int Credits
        {
            get
            {
                return this._Credits;
            }
            set
            {
                this.OnCreditsChanging(value);
                this._Credits = value;
                this.OnCreditsChanged();
            }
        }
        private int _Credits;
        partial void OnCreditsChanging(int value);
        partial void OnCreditsChanged();
        /// <summary>
        /// There are no comments for Property DepartmentID in the schema.
        /// </summary>
        public int DepartmentID
        {
            get
            {
                return this._DepartmentID;
            }
            set
            {
                this.OnDepartmentIDChanging(value);
                this._DepartmentID = value;
                this.OnDepartmentIDChanged();
            }
        }
        private int _DepartmentID;
        partial void OnDepartmentIDChanging(int value);
        partial void OnDepartmentIDChanged();
        /// <summary>
        /// There are no comments for CourseGrade in the schema.
        /// </summary>
        public global::System.Collections.ObjectModel.Collection<CourseGrade> CourseGrade
        {
            get
            {
                return this._CourseGrade;
            }
            set
            {
                if ((value != null))
                {
                    this._CourseGrade = value;
                }
            }
        }
        private global::System.Collections.ObjectModel.Collection<CourseGrade> _CourseGrade = new global::System.Collections.ObjectModel.Collection<CourseGrade>();
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        public global::System.Collections.ObjectModel.Collection<Person> Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                if ((value != null))
                {
                    this._Person = value;
                }
            }
        }
        private global::System.Collections.ObjectModel.Collection<Person> _Person = new global::System.Collections.ObjectModel.Collection<Person>();
    }
    /// <summary>
    /// There are no comments for SQLServer2005DBModel.CourseGrade in the schema.
    /// </summary>
    /// <KeyProperties>
    /// EnrollmentID
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("EnrollmentID")]
    public partial class CourseGrade
    {
        /// <summary>
        /// Create a new CourseGrade object.
        /// </summary>
        /// <param name="enrollmentID">Initial value of EnrollmentID.</param>
        public static CourseGrade CreateCourseGrade(int enrollmentID)
        {
            CourseGrade courseGrade = new CourseGrade();
            courseGrade.EnrollmentID = enrollmentID;
            return courseGrade;
        }
        /// <summary>
        /// There are no comments for Property EnrollmentID in the schema.
        /// </summary>
        public int EnrollmentID
        {
            get
            {
                return this._EnrollmentID;
            }
            set
            {
                this.OnEnrollmentIDChanging(value);
                this._EnrollmentID = value;
                this.OnEnrollmentIDChanged();
            }
        }
        private int _EnrollmentID;
        partial void OnEnrollmentIDChanging(int value);
        partial void OnEnrollmentIDChanged();
        /// <summary>
        /// There are no comments for Property Grade in the schema.
        /// </summary>
        public global::System.Nullable<decimal> Grade
        {
            get
            {
                return this._Grade;
            }
            set
            {
                this.OnGradeChanging(value);
                this._Grade = value;
                this.OnGradeChanged();
            }
        }
        private global::System.Nullable<decimal> _Grade;
        partial void OnGradeChanging(global::System.Nullable<decimal> value);
        partial void OnGradeChanged();
        /// <summary>
        /// There are no comments for Course in the schema.
        /// </summary>
        public Course Course
        {
            get
            {
                return this._Course;
            }
            set
            {
                this._Course = value;
            }
        }
        private Course _Course;
        /// <summary>
        /// There are no comments for Person in the schema.
        /// </summary>
        public Person Person
        {
            get
            {
                return this._Person;
            }
            set
            {
                this._Person = value;
            }
        }
        private Person _Person;
    }
    /// <summary>
    /// There are no comments for SQLServer2005DBModel.Person in the schema.
    /// </summary>
    /// <KeyProperties>
    /// PersonID
    /// </KeyProperties>
    [global::System.Data.Services.Common.DataServiceKeyAttribute("PersonID")]
    public partial class Person
    {
        /// <summary>
        /// Create a new Person object.
        /// </summary>
        /// <param name="personID">Initial value of PersonID.</param>
        /// <param name="lastName">Initial value of LastName.</param>
        /// <param name="firstName">Initial value of FirstName.</param>
        /// <param name="personCategory">Initial value of PersonCategory.</param>
        public static Person CreatePerson(int personID, string lastName, string firstName, short personCategory)
        {
            Person person = new Person();
            person.PersonID = personID;
            person.LastName = lastName;
            person.FirstName = firstName;
            person.PersonCategory = personCategory;
            return person;
        }
        /// <summary>
        /// There are no comments for Property PersonID in the schema.
        /// </summary>
        public int PersonID
        {
            get
            {
                return this._PersonID;
            }
            set
            {
                this.OnPersonIDChanging(value);
                this._PersonID = value;
                this.OnPersonIDChanged();
            }
        }
        private int _PersonID;
        partial void OnPersonIDChanging(int value);
        partial void OnPersonIDChanged();
        /// <summary>
        /// There are no comments for Property LastName in the schema.
        /// </summary>
        public string LastName
        {
            get
            {
                return this._LastName;
            }
            set
            {
                this.OnLastNameChanging(value);
                this._LastName = value;
                this.OnLastNameChanged();
            }
        }
        private string _LastName;
        partial void OnLastNameChanging(string value);
        partial void OnLastNameChanged();
        /// <summary>
        /// There are no comments for Property FirstName in the schema.
        /// </summary>
        public string FirstName
        {
            get
            {
                return this._FirstName;
            }
            set
            {
                this.OnFirstNameChanging(value);
                this._FirstName = value;
                this.OnFirstNameChanged();
            }
        }
        private string _FirstName;
        partial void OnFirstNameChanging(string value);
        partial void OnFirstNameChanged();
        /// <summary>
        /// There are no comments for Property PersonCategory in the schema.
        /// </summary>
        public short PersonCategory
        {
            get
            {
                return this._PersonCategory;
            }
            set
            {
                this.OnPersonCategoryChanging(value);
                this._PersonCategory = value;
                this.OnPersonCategoryChanged();
            }
        }
        private short _PersonCategory;
        partial void OnPersonCategoryChanging(short value);
        partial void OnPersonCategoryChanged();
        /// <summary>
        /// There are no comments for Property HireDate in the schema.
        /// </summary>
        public global::System.Nullable<global::System.DateTime> HireDate
        {
            get
            {
                return this._HireDate;
            }
            set
            {
                this.OnHireDateChanging(value);
                this._HireDate = value;
                this.OnHireDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _HireDate;
        partial void OnHireDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnHireDateChanged();
        /// <summary>
        /// There are no comments for Property EnrollmentDate in the schema.
        /// </summary>
        public global::System.Nullable<global::System.DateTime> EnrollmentDate
        {
            get
            {
                return this._EnrollmentDate;
            }
            set
            {
                this.OnEnrollmentDateChanging(value);
                this._EnrollmentDate = value;
                this.OnEnrollmentDateChanged();
            }
        }
        private global::System.Nullable<global::System.DateTime> _EnrollmentDate;
        partial void OnEnrollmentDateChanging(global::System.Nullable<global::System.DateTime> value);
        partial void OnEnrollmentDateChanged();
        /// <summary>
        /// There are no comments for Property Picture in the schema.
        /// </summary>
        public byte[] Picture
        {
            get
            {
                if ((this._Picture != null))
                {
                    return ((byte[])(this._Picture.Clone()));
                }
                else
                {
                    return null;
                }
            }
            set
            {
                this.OnPictureChanging(value);
                this._Picture = value;
                this.OnPictureChanged();
            }
        }
        private byte[] _Picture;
        partial void OnPictureChanging(byte[] value);
        partial void OnPictureChanged();
        /// <summary>
        /// There are no comments for CourseGrade in the schema.
        /// </summary>
        public global::System.Collections.ObjectModel.Collection<CourseGrade> CourseGrade
        {
            get
            {
                return this._CourseGrade;
            }
            set
            {
                if ((value != null))
                {
                    this._CourseGrade = value;
                }
            }
        }
        private global::System.Collections.ObjectModel.Collection<CourseGrade> _CourseGrade = new global::System.Collections.ObjectModel.Collection<CourseGrade>();
        /// <summary>
        /// There are no comments for Course in the schema.
        /// </summary>
        public global::System.Collections.ObjectModel.Collection<Course> Course
        {
            get
            {
                return this._Course;
            }
            set
            {
                if ((value != null))
                {
                    this._Course = value;
                }
            }
        }
        private global::System.Collections.ObjectModel.Collection<Course> _Course = new global::System.Collections.ObjectModel.Collection<Course>();
    }
}
