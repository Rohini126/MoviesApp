using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace MovieServices.MovieDAL.Models
{
    public static class Context
    {
		public static MovieContext GetContext()
		{
			MovieContext ctx = null;
			ctx = (MovieContext)Thread.GetData(Thread.GetNamedDataSlot("Context"));
			if (ctx == null)
			{
                ctx = new MovieContext();
			}
			return ctx;
		}
	}
}
