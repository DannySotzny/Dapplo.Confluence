﻿//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2016-2019 Dapplo
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

#region using

using Newtonsoft.Json;

#endregion

namespace Dapplo.Confluence.Entities
{
    /// <summary>
    ///     Contents of a space
    /// </summary>
    [JsonObject]
	public class SpaceContents
    {
		/// <summary>
		///     The pages
		/// </summary>
		[JsonProperty("page", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Result<Content> Pages { get; set; }

        /// <summary>
        ///     The blogposts
        /// </summary>
        [JsonProperty("blogpost", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Result<Content> Blogposts { get; set; }

        /// <summary>
        /// The links
        /// </summary>
        [JsonProperty("_links", DefaultValueHandling = DefaultValueHandling.Ignore)]
        public Links Links { get; set; }
    }
}