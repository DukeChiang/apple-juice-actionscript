@echo off

@echo ����ǵ�һ��ִ�У���������Ҫ����api��dll. �༭linkcodegencli\genapi.config ����api��dll
@pause

@echo ɾ�������ļ�

rd /s /q linkcodegencli\as3_unity
md linkcodegencli\as3_unity
del /q AS3Hotfix_U56\Assets\ScriptSupport\Generated\*.*


..\SDK1.0.0\linkcodegencli\LinkCodeGenCLI.exe config=linkcodegencli/genapi.config

if %errorlevel% NEQ 0 goto error


goto end



:error


pause



:end

