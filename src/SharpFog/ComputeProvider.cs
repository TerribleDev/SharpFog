using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SharpFog
{
    public static class ComputeProvider
    {
        public static ComputeProvider<T> New<T>(T Provider) where T : IComputeProvider => new ComputeProvider<T>(Provider);
    }

    public class ComputeProvider<T> where T : IComputeProvider
    {
        public ComputeProvider(T provider)
        {
        }
    }
}