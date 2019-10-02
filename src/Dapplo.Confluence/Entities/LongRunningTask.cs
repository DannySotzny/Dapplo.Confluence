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

using Newtonsoft.Json;

namespace Dapplo.Confluence.Entities
{
    /// <summary>
    ///     For instance when using delete
    /// </summary>
    [JsonObject]
	public class LongRunningTask
	{
		/// <summary>
		///     Id of the task
		/// </summary>
		[JsonProperty("id", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public string Id { get; set; }

		/// <summary>
		///     In this the link for the status is returned
		/// </summary>
		[JsonProperty("links", DefaultValueHandling = DefaultValueHandling.Ignore)]
		public Links Links { get; set; }
	}
}