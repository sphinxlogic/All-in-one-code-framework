SET obj = CreateObject("CppDllCOMServer.SimpleObject")

MsgBox "An CppDllCOMServer.SimpleObject object is created"

' call the HelloWorld method that returns a string
MsgBox "The HelloWorld method returns " & obj.HelloWorld

' Set the FloatProperty property
MsgBox "Set the FloatProperty property to 1.2"
obj.FloatProperty = 1.2

' Get the FloatProperty property
MsgBox "The FloatProperty property returns " & obj.FloatProperty

SET obj = Nothing