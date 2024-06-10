using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailParserService.Business
{
	public static class ServiceCollectionExtensions
	{
		public static IServiceCollection UseBusinessLayer(this IServiceCollection services)
		{
			return services;
		}
	}
}
