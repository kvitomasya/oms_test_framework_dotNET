cd ..\..\bin\Debug\

IF "%1"=="" (
::running all tests, without parameters
vstest.console.exe oms_test_framework_dotNET.dll /tests:EditOrderTest,DeleteOrderTest,LogOutTest,SwitchTabsTest,PositiveLogInTest
 ) ELSE (
 ::running just test sent to parameter
 vstest.console.exe oms_test_framework_dotNET.dll /tests:%1
 )
