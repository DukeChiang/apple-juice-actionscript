@echo off

@echo ���û�а�װflashdevelop ��java,��ô����ִ�����bat�����ȸ����뵽unity.���һ´��һ�ݵ�buildgame�С�
@echo �����UnityҲû�а�װ����ô��������buildgame�鿴�ȸ�Ч����

@pause

..\SDK1.0.0\bin\CMXMLCCLI.exe -load-config+=HotFixProj\obj\HotFixProjConfig.cli.xml -o AS3Hotfix_U56\Assets\StreamingAssets\hotfix.cswc



IF ERRORLEVEL 1 goto error

copy AS3Hotfix_U56\Assets\StreamingAssets\hotfix.cswc buildgame\hotfixdemo_Data\StreamingAssets\hotfix.cswc
buildgame\hotfixdemo.exe


exit
:error
@echo �����������
pause



