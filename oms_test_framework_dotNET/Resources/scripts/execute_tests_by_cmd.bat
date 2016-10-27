cd ..\..\bin\Debug\

IF "%1"=="" ( 
vstest.console.exe oms_test_framework_dotNET.dll /tests:EditOrderTest,DeleteOrderTest,LogOutTest,SwitchTabsTest,PositiveLogInTest
 ) ELSE ( 
 vstest.console.exe oms_test_framework_dotNET.dll /tests:%1
 )