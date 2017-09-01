using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cs_registry_wrapper
{
	class Examples
	{
		static void Main(string[] args)
		{
			
			int i = Reg.TestInt++;
			Reg.TestDouble += 0.1;
			double d = Reg.TestDouble;

			Console.WriteLine($"i : {i}, d : {d}");

			//try it again and again
		}
	}
}
