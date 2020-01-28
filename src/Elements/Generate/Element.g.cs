//----------------------
// <auto-generated>
//     Generated using the NJsonSchema v10.1.4.0 (Newtonsoft.Json v12.0.0.0) (http://NJsonSchema.org)
// </auto-generated>
//----------------------
using Elements;
using Elements.GeoJSON;
using Elements.Geometry;
using Elements.Geometry.Solids;
using Elements.Properties;
using Elements.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using Line = Elements.Geometry.Line;
using Polygon = Elements.Geometry.Polygon;

namespace Elements
{
    #pragma warning disable // Disable all warnings

    /// <summary>A uniquely identifiable element.</summary>
    [Newtonsoft.Json.JsonConverter(typeof(Elements.Serialization.JSON.JsonInheritanceConverter), "discriminator")]
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial class Element 
    {
        [Newtonsoft.Json.JsonConstructor]
        public Element(System.Guid @id, string @name)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Element>();
            if(validator != null)
            {
                validator.Validate(new object[]{ @id, @name});
            }
        
            this.Id = @id;
            this.Name = @name;
        }
    
        /// <summary>A unique id.</summary>
        [Newtonsoft.Json.JsonProperty("Id", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Required(AllowEmptyStrings = true)]
        public System.Guid Id { get; set; }
    
        /// <summary>A name.</summary>
        [Newtonsoft.Json.JsonProperty("Name", Required = Newtonsoft.Json.Required.AllowNull)]
        public string Name { get; set; }
    
    
    }
}