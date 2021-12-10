Scaffolding has generated all the files and added the required dependencies.

However the Application's Startup code may require additional changes for things to work end to end.
Add the following code to the Configure method in your Application's Startup class if not already done:

        app.UseEndpoints(endpoints =>
        {
          endpoints.MapControllerRoute(
            name : "areas",
            pattern : "{area:exists}/{controller=Home}/{action=Index}/{id?}"
          );
        });


        20211115054241_AddDefaultIdentityMigration migration file name

        20211115105428_AddCategoryToDo added new file through pm console

        Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0246	The type or namespace name 'Category' could not be found (are you missing a using directive or an assembly reference?)	SahithisBooks.DataAccess	C:\Users\91910\source\repos\SahithisBookStore\SahithisBooks.DataAccess\Repository\CategoryRepository.cs	13	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS1721	Class 'CategoryRepository' cannot have multiple base classes: 'Repository<Category>' and 'ICategoryRepository'	SahithisBooks.DataAccess	C:\Users\91910\source\repos\SahithisBookStore\SahithisBooks.DataAccess\Repository\CategoryRepository.cs	10	Active


Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0161	'SP_Call.OneRecord<T>(string, DynamicParameters)': not all code paths return a value	SahithisBooks.DataAccess	C:\Users\W0767287\source\repos\SahithisBookStore\SahithisBookStore\SahithisBooks.DataAccess\Repository\SP_Call.cs	69	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0246	The type or namespace name 'ICategoryRepository' could not be found (are you missing a using directive or an assembly reference?)	SahithisBooks.DataAccess	C:\Users\W0767287\source\repos\SahithisBookStore\SahithisBookStore\SahithisBooks.DataAccess\Repository\iRepository\UnitOfWork.cs	9	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'sqlCon' does not exist in the current context	SahithisBooks.DataAccess	C:\Users\W0767287\source\repos\SahithisBookStore\SahithisBookStore\SahithisBooks.DataAccess\Repository\SP_Call.cs	71	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0103	The name 'SqlCon' does not exist in the current context	SahithisBooks.DataAccess	C:\Users\W0767287\source\repos\SahithisBookStore\SahithisBookStore\SahithisBooks.DataAccess\Repository\SP_Call.cs	72	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0266	Cannot implicitly convert type 'SahithisBooks.DataAccess.Repository.CategoryRepository' to 'SahithisBooks.DataAccess.Repository.IRepository.ICategoryRepository'. An explicit conversion exists (are you missing a cast?)	SahithisBooks.DataAccess	C:\Users\W0767287\source\repos\SahithisBookStore\SahithisBookStore\SahithisBooks.DataAccess\Repository\UnitOfWork.cs	17	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0246	The type or namespace name 'IUnitOfWork' could not be found (are you missing a using directive or an assembly reference?)	SahithisBookStore	C:\Users\W0767287\source\repos\SahithisBookStore\SahithisBookStore\SahithisBookStore\Startup.cs	38	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0246	The type or namespace name 'UnitOfWork' could not be found (are you missing a using directive or an assembly reference?)	SahithisBookStore	C:\Users\W0767287\source\repos\SahithisBookStore\SahithisBookStore\SahithisBookStore\Startup.cs	38	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0246	The type or namespace name 'ICategoryRepository' could not be found (are you missing a using directive or an assembly reference?)	SahithisBooks.DataAccess	C:\Users\W0767287\source\repos\SahithisBookStore\SahithisBookStore\SahithisBooks.DataAccess\Repository\CategoryRepository.cs	10	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS0061	Inconsistent accessibility: base interface 'IRepository<Category>' is less accessible than interface 'ICategoryRepository'	SahithisBooks.DataAccess	C:\Users\W0767287\source\repos\SahithisBookStore\SahithisBookStore\SahithisBooks.DataAccess\Repository\iRepository\ICategoryRepository.cs	9	Active

Severity	Code	Description	Project	File	Line	Suppression State
Error	CS1513	} expected	SahithisBooks.DataAccess	C:\Users\W0767287\source\repos\SahithisBookStore\SahithisBookStore\SahithisBooks.DataAccess\Repository\SP_Call.cs	32	Active
