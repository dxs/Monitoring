using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Windows.System.Diagnostics;

namespace Monitoring.Monitoring
{
	public class Temperature
	{
		public Temperature()
		{
			var a = ProcessDiagnosticInfo.GetForProcesses();
			
			foreach(var i in a)
			{
				string s = i.CpuUsage.GetReport().KernelTime.TotalMilliseconds.ToString();
			
				s += 1;
			}

		}
	}
}
