﻿using System.Collections.Generic;
using Newtonsoft.Json;

namespace GoogleApi.Entities.Places.Search.NearBy.Response
{
    /// <summary>
    /// Places NearbySearch Response.
    /// </summary>
    public class PlacesNearbySearchResponse : BasePlacesSearchResponse
    {
        /// <summary>
        /// Contains an array of places, with information about each. See Search Results for information about these results. 
        /// The Places API returns up to 20 establishment results per query. Additionally, political results may be returned 
        /// which serve to identify the area of the request.
        /// </summary>
        [JsonProperty("results")]
        public virtual IEnumerable<NearByResult> Results { get; set; }
    }
}