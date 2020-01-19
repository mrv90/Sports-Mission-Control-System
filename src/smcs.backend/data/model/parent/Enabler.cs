using System;

namespace Backend.Data.Model.Parent
{
    [Obsolete("References must be replaced with smcs.backend.data.model.parent.Base", true)]
    public abstract class Enabler
    {
        public bool Enbl { get; set; }
    }
}
