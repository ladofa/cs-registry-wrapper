using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace cs_registry_wrapper
{
	public static class Reg
	{
		
		static Microsoft.Win32.RegistryKey rootKey;

		//-- 1. set root registry key as you want
		static Reg()
		{
			rootKey = Microsoft.Win32.Registry.CurrentUser.CreateSubKey("RegTest");
		}

		//-- 2. make your own property like below
		//--    copy, paste and just modify type, name, and defaultValue
		public static int TestInt
		{
			get
			{
				var defaultValue = 0;
				var info = System.Reflection.MethodBase.GetCurrentMethod() as System.Reflection.MethodInfo;
				var name = info.Name.Substring(4);
				string str = rootKey.GetValue(name, defaultValue.ToString()) as string;
				return (dynamic)Convert.ChangeType(str, info.ReturnType);
			}

			set
			{
				var name = System.Reflection.MethodBase.GetCurrentMethod().Name.Substring(4);
				rootKey.SetValue(name, value.ToString());
			}
		}

		public static double TestDouble
		{
			get
			{
				var defaultValue = 0;
				var info = System.Reflection.MethodBase.GetCurrentMethod() as System.Reflection.MethodInfo;
				var name = info.Name.Substring(4);
				string str = rootKey.GetValue(name, defaultValue.ToString()) as string;
				return (dynamic)Convert.ChangeType(str, info.ReturnType);
			}

			set
			{
				var name = System.Reflection.MethodBase.GetCurrentMethod().Name.Substring(4);
				rootKey.SetValue(name, value.ToString());
			}
		}

		//3. CTRL + M + O to collapse all
	}
}
