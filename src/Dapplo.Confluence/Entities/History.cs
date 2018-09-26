﻿//  Dapplo - building blocks for desktop applications
//  Copyright (C) 2016-2018 Dapplo
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

using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

#endregion

namespace Dapplo.Confluence.Entities
{
	/// <summary>
	///     History information
	///     See: https://docs.atlassian.com/confluence/REST/latest
	/// </summary>
	[DataContract]
	public class History
	{
		/// <summary>
		///     User who created it
		/// </summary>
		[DataMember(Name = "createdBy", EmitDefaultValue = false)]
		public User CreatedBy { get; set; }

		/// <summary>
		///     Created data
		/// </summary>
		[DataMember(Name = "createdDate", EmitDefaultValue = false)]
		public DateTimeOffset CreatedDate { get; set; }

		/// <summary>
		///     The values that are expandable
		/// </summary>
		[DataMember(Name = "_expandable", EmitDefaultValue = false)]
		public IDictionary<string, string> Expandables { get; set; }

		/// <summary>
		///     Last updated information
		/// </summary>
		[DataMember(Name = "lastUpdated", EmitDefaultValue = false)]
		public LastUpdated LastUpdated { get; set; }

		/// <summary>
		///     Is this history entity the latest entry?
		/// </summary>
		[DataMember(Name = "latest", EmitDefaultValue = false)]
		public bool Latest { get; set; }

		/// <summary>
		///     Different links for this entity, depending on the entry
		/// </summary>
		[DataMember(Name = "_links", EmitDefaultValue = false)]
		public Links Links { get; set; }
	}
}