@echo off

@echo ����ǵ�һ��ִ�У���������Ҫ����api��dll. �༭linkcodegencli\LinkCodeGenCLI.exe.config ����api��dll
@pause

@echo ɾ�������ļ�

rd /s /q linkcodegencli\as3_unity
md linkcodegencli\as3_unity
del /q AS3Hotfix_U56\Assets\ScriptSupport\Generated\*.*


linkcodegencli\LinkCodeGenCLI.exe

