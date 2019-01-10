﻿using Cheviri.Data.Entities.Base;
using Cheviri.Data.Entities.Base.Schemas;

namespace Cheviri.Data.Entities.Parameter
{
    public class Language : BaseEntity, ISchemaParameter
    {
        public string Name { get; set; }
        /// <summary>
        /// ISO 639-1 
        /// </summary>
        public string IsoCode2Char { get; set; }
        /// <summary>
        /// ISO 639-2 
        /// </summary>
        public string IsoCode3Char { get; set; }
        public string Description { get; set; }
        public string IconUrl { get; set; }
    }
}