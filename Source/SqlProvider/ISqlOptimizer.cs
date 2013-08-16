﻿using System;

namespace LinqToDB.SqlProvider
{
	using SqlQuery;

	public interface ISqlOptimizer
	{
		ISqlExpression ConvertExpression(ISqlExpression expression);
	}
}
