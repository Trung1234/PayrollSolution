# Payroll Solution
MVC Web Application  using .NET Core 2.2
 - Server-Side Validation using Regular Expression, Ajax, Jquery
 - Implement multi-layered architecture and their dependencies on each other 
 - Use ICompositeViewEngine to render PartialView to string and add in PopUp
 - Creating PDF using RotativaCore version 2.2
      -  Copy folder WkHtmlToPdf to Payroll 
      -  Copy to Payroll.csproj
      		<details>
    			<summary>Click to expand</summary>
			<ItemGroup>
				<None Update="WkHtmlToPdf\wkhtmltoimage.exe">
					<CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
				</None>
				<None Update="WkHtmlToPdf\wkhtmltopdf.exe">
					<CopyToOutputDirectory>PreserveNewest</CopyToOutputDirectory>
				</None>
			</ItemGroup>
	 	</details>
	
# To run web
 - Change DefaultConnection to your Connection Strings
 - For database migration , we need to follow the following steps.
	- Tools -> NuGet Package Manager -> Package Manager Console -> change Default Project: Payroll.Persistence.
	- Run PM> Add-Migration MyFirstMigration to scaffold a migration to create the initial set of tables for our model. 	
	- Run PM> Update-Database to apply the new migration to the database. 
	- Since our database doesn't exist yet, it will be created for us before the migration is applied
## References
- https://www.c-sharpcorner.com/article/managing-data-with-viewmodel-in-asp-net-mvc/
- https://www.c-sharpcorner.com/UploadFile/3d39b4/Asp-Net-mvc-server-side-validation/
- https://hoc5.blogspot.com/2017/07/phan-biet-viewbag-viewdata-tempdata.html
- https://techmaster.vn/posts/36427/quy-uoc-dat-ten-css-theo-chuan-bem
- https://www.c-sharpcorner.com/article/creating-pdf-in-asp-net-core-mvc-using-rotativa-aspnetcore/
- https://www.c-sharpcorner.com/blogs/preventing-cross-site-request-forgery-in-mvc
- https://www.codaffection.com/asp-net-core-article/jquery-ajax-crud-in-asp-net-core-mvc/
- https://gist.github.com/tanveery/94260e1eeace704797f7#file-homecontroller-cs-L30
- https://www.codeproject.com/Articles/216439/Data-Validation-Using-Annotations-for-jQuery-Ajax
