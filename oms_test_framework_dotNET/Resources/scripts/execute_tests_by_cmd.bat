cd ..\..\bin\Debug\

IF "%1"=="" (
echo Running all tests!
vstest.console.exe oms_test_framework_dotNET.dll /tests:EditOrderTest,DeleteOrderTest,LogOutTest,SwitchTabsTest,PositiveLogInTest
 ) ELSE (
 echo Running just test sent to parameter!
 vstest.console.exe oms_test_framework_dotNET.dll /tests:%1
 )
