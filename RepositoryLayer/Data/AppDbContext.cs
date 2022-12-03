using System;
using DomainLayer.Common;
using DomainLayer.Entities;

namespace RepositoryLayer.Data
{
	public static class AppDbContext<T>
    {
		public static List<T> datas;

		static AppDbContext()
		{
			datas = new List<T>();
		}
	}
}

