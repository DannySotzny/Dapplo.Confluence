﻿//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2016-2020 Dapplo
//
//  For more information see: http://dapplo.net/
//  Dapplo repositories are hosted on GitHub: https://github.com/dapplo
//
//  This file is part of Dapplo.Confluence
//
//  Dapplo.Confluence is free software: you can redistribute it and/or modify
//  it under the terms of the GNU Lesser General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  Dapplo.Confluence is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU Lesser General Public License for more details.
//
//  You should have a copy of the GNU Lesser General Public License
//  along with Dapplo.Confluence. If not, see <http://www.gnu.org/licenses/lgpl.txt>.

namespace Dapplo.Confluence.Query
{
    /// <summary>
    ///     An interface for a content id based clauses
    /// </summary>
    public interface IContentClause
    {
        /// <summary>
        ///     Negates the expression
        /// </summary>
        IContentClause Not { get; }

        /// <summary>
        ///     This allows fluent constructs like Id.In(1234, 45678)
        /// </summary>
        IFinalClause In(params long[] values);


        /// <summary>
        ///     This allows fluent constructs like Id.InRecentlyViewedContent(10, 20)
        /// </summary>
        IFinalClause InRecentlyViewedContent(int limit, int offset = 0);

        /// <summary>
        ///     This allows fluent constructs like Id.Is(12345)
        /// </summary>
        IFinalClause Is(long id);
    }
}