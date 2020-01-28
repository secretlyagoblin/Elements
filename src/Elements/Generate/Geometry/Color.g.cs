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

namespace Elements.Geometry
{
    #pragma warning disable // Disable all warnings

    /// <summary>A color with red, green, blue, and alpha components.</summary>
    [System.CodeDom.Compiler.GeneratedCode("NJsonSchema", "10.1.4.0 (Newtonsoft.Json v12.0.0.0)")]
    public partial struct Color 
    {
        [Newtonsoft.Json.JsonConstructor]
        public Color(double @red, double @green, double @blue, double @alpha)
        {
            var validator = Validator.Instance.GetFirstValidatorForType<Color>();
            if(validator != null)
            {
                validator.Validate(new object[]{ @red, @green, @blue, @alpha});
            }
        
            this.Red = @red;
            this.Green = @green;
            this.Blue = @blue;
            this.Alpha = @alpha;
        }
    
        /// <summary>The red component of the color between 0.0 and 1.0.</summary>
        [Newtonsoft.Json.JsonProperty("Red", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0.0D, 1.0D)]
        public double Red { get; set; }
    
        /// <summary>The green component of the color between 0.0 and 1.0.</summary>
        [Newtonsoft.Json.JsonProperty("Green", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0.0D, 1.0D)]
        public double Green { get; set; }
    
        /// <summary>The blue component of the color between 0.0 and 1.0.</summary>
        [Newtonsoft.Json.JsonProperty("Blue", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0.0D, 1.0D)]
        public double Blue { get; set; }
    
        /// <summary>The alpha component of the color between 0.0 and 1.0.</summary>
        [Newtonsoft.Json.JsonProperty("Alpha", Required = Newtonsoft.Json.Required.Always)]
        [System.ComponentModel.DataAnnotations.Range(0.0D, 1.0D)]
        public double Alpha { get; set; }
    
    
    }
}