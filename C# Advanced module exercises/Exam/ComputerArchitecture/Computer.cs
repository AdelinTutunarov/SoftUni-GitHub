using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ComputerArchitecture
{
    public class Computer
    {
		public Computer(string model ,int capacity)
		{
			Model = model;
			Capacity = capacity;
			Multiprocessor = new List<CPU>();
		}
		private string model;

		public string Model
		{
			get { return model; }
			set { model = value; }
		}

		private int capacity ;

		public int Capacity 
		{
			get { return capacity ; }
			set { capacity  = value; }
		}

		private List<CPU> multiprocessor ;

		public List<CPU> Multiprocessor 
		{
			get { return multiprocessor ; }
			set { multiprocessor  = value; }
		}


		public int Count
		{
			get { return Multiprocessor.Count; }
		}

		public void Add(CPU cpu)
		{
			if(Multiprocessor.Count + 1 <= Capacity) Multiprocessor.Add(cpu);
		}

		public bool Remove(string brand)
		{
			var target = Multiprocessor.FirstOrDefault(x => x.Brand == brand);
			if(target == null) return false;
			Multiprocessor.Remove(target);
			return true;
		}

		public CPU MostPowerful()
		{
			Multiprocessor = Multiprocessor.OrderBy(x => x.Frequency).ToList();
			return Multiprocessor.FirstOrDefault();
		}

		public CPU GetCPU(string brand)
		{
			return Multiprocessor.FirstOrDefault(x => x.Brand == brand);
		}
		public string Report()
		{
			StringBuilder sb = new StringBuilder();
			sb.AppendLine($"CPUs in the Computer {Model}:");
			foreach (var item in Multiprocessor)
			{
				sb.AppendLine(item.ToString());
			}
			return sb.ToString();
		}
    }
}
