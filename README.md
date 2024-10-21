"# dotnet-exam" 
<h1>step</h1>
<h3>Add package</h3>
<h4>dotnet add package Microsoft.EntityFrameWorkCore</h4>
<h4>dotnet add package Microsoft.EntityFrameWorkCore.Design</h4>
<h4>dotnet add package MySQL.Data</h4>
<h4>dotnet add package MySQL.EntityFrameWorkCore</h4>
<h1>paste in cmd</h1>
<h4>dotnet ef dbContext scafford  "Server:localhost;database=thuchanh;uid=root;password=admin" -o Model</h4>
<h1>paste in appsetting.json</h1>
<h4>"ConnectionStrings": {
   "DbString": "server=localhost; database=employees;uid=root; password=root;"
 }</h4>
 <h1>paste in program.cs</h1>
 <h4>var DbString = builder.Configuration.GetConnectionString("DbString");
</h4>
 builder.Services.AddDbContext<<ad>ThuchanhContext>(options =>
options.UseMySQL(DbString));
    <br>
builder.Services.AddScoped<<hu>IEmployeeRepo, EmployeeRepo>();
<h2>create repo folder</h2>
<h3>create IEmployeeRepo class</h3>
<h3>paste in IEmployeeRepo</h3>
<h4>Task<<asa>IEnumerable<Employee>> GetAllStaffs();</h4>
<h4>Task<<aa>Employee> GetStaffById(int id);</h4>
<h3>create EmployeeRepo class</h3>
<h3>create EmployeeDetailBase.cs class</h3>
<h3>create EmployeeDetail.razor</h3>

        
