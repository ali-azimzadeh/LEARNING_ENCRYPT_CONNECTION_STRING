//************************************************************
	STEP 1
//************************************************************
	Install follow packages from Manage Nuget Packages:
		
		Microsoft.EntityFrameworkCore 
		Microsoft.EntityFrameworkCore.Design
		Microsoft.EntityFrameworkCore.SqlServer

		Microsoft.Extensions.Configuration
		Microsoft.Extensions.Configuration.Binder
		Microsoft.Extensions.Configuration.Json
		Microsoft.Extensions.Configuration.UserSecrets
		System.Data.SqlClient

//************************************************************
	STEP 2
//************************************************************
	In project root ->
		right click on project -> add -> new item 
			add json file as appsettings.json

//************************************************************
	STEP 3
//************************************************************

	add connection string(s) and other configuration or settings to appsettings.json

//************************************************************
	STEP 4
//************************************************************

	Create a POCO class for mapping connection strings

//************************************************************
	STEP 5
//************************************************************

	Create User Secrets for secure connection string password and ...
		right click on project -> click on [Manage User Secrets] item

//************************************************************
	STEP 6
//************************************************************
	Goto CLI .net 
		right click on project -> click on [Open File In Explorer] item 
			from [File] menu click on [open windows powers shell as administrator] item 
			or
			from [File] menu click on [open command prompt as administrator] item 

//************************************************************
	STEP 7
//************************************************************
	Type the following commands step by step :
		1.  dotnet user-secrets init
		2.  dotnet user-secrets set "DbPassword" "123123123"