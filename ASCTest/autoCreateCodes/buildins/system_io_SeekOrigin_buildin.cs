using ASBinCode;
using ASBinCode.rtti;
using ASRuntime;
using ASRuntime.nativefuncs;
using System;
using System.Collections;
using System.Collections.Generic;
namespace ASCTest.regNativeFunctions
{
	class system_io_SeekOrigin_buildin
	{
		public static void regNativeFunctions(CSWC bin)
		{
			bin.regNativeFunction(LinkSystem_Buildin.getCreator("system_io_SeekOrigin_creator", default(System.IO.SeekOrigin)));
			bin.regNativeFunction(new system_io_SeekOrigin_ctor());
			bin.regNativeFunction(LinkSystem_Buildin.getStruct_static_field_getter("system_io_SeekOrigin_Begin_getter",()=>{ return System.IO.SeekOrigin.Begin;}));
			bin.regNativeFunction(LinkSystem_Buildin.getStruct_static_field_getter("system_io_SeekOrigin_Current_getter",()=>{ return System.IO.SeekOrigin.Current;}));
			bin.regNativeFunction(LinkSystem_Buildin.getStruct_static_field_getter("system_io_SeekOrigin_End_getter",()=>{ return System.IO.SeekOrigin.End;}));
			bin.regNativeFunction(new system_io_SeekOrigin_operator_bitOr());
		}

		class system_io_SeekOrigin_ctor : NativeFunctionBase
		{
			public system_io_SeekOrigin_ctor()
			{
				para = new List<RunTimeDataType>();
			}

			public override bool isMethod
			{
				get
				{
					return true;
				}
			}

			public override string name
			{
				get
				{
					return "system_io_SeekOrigin_ctor";
				}
			}

			List<RunTimeDataType> para;
			public override List<RunTimeDataType> parameters
			{
				get
				{
					return para;
				}
			}

			public override RunTimeDataType returnType
			{
				get
				{
					return RunTimeDataType.rt_void;
				}
			}

			public override RunTimeValueBase execute(RunTimeValueBase thisObj, SLOT[] argements, object stackframe, out string errormessage, out int errorno)
			{
				errormessage = null; errorno = 0;
				return ASBinCode.rtData.rtUndefined.undefined;

			}
		}

		class system_io_SeekOrigin_operator_bitOr : ASRuntime.nativefuncs.NativeConstParameterFunction
		{
			public system_io_SeekOrigin_operator_bitOr() : base(2)
			{
				para = new List<RunTimeDataType>();
				para.Add(RunTimeDataType.rt_void);
				para.Add(RunTimeDataType.rt_void);
			}

			public override bool isMethod
			{
				get
				{
					return true;
				}
			}

			public override string name
			{
				get
				{
					return "system_io_SeekOrigin_operator_bitOr";
				}
			}

			List<RunTimeDataType> para;
			public override List<RunTimeDataType> parameters
			{
				get
				{
					return para;
				}
			}

			public override RunTimeDataType returnType
			{
				get
				{
					return RunTimeDataType.rt_void;
				}
			}

			public override void execute3(RunTimeValueBase thisObj, FunctionDefine functionDefine, SLOT returnSlot, SourceToken token, StackFrame stackframe, out bool success)
			{
				System.IO.SeekOrigin ts1;

				if (argements[0].rtType == RunTimeDataType.rt_null)
				{
					ts1 = default(System.IO.SeekOrigin);
				}
				else
				{
					LinkObj<object> argObj = (LinkObj<object>)((ASBinCode.rtData.rtObject)argements[0]).value;
					ts1 = (System.IO.SeekOrigin)argObj.value;
				}

				System.IO.SeekOrigin ts2;

				if (argements[1].rtType == RunTimeDataType.rt_null)
				{
					ts2 = default(System.IO.SeekOrigin);
				}
				else
				{
					LinkObj<object> argObj = (LinkObj<object>)((ASBinCode.rtData.rtObject)argements[1]).value;
					ts2 = (System.IO.SeekOrigin)argObj.value;
				}

				((StackSlot)returnSlot).setLinkObjectValue(
					bin.getClassByRunTimeDataType(functionDefine.signature.returnType), stackframe.player, ts1 | ts2);

				success = true;
			}
		}

	}
}