using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpFog.Models
{
    internal interface ICompute
    {
        string Id { get; set; }
        string Name { get; set; }
        string Type { get; set; }
    }
}