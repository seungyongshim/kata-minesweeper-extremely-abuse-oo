namespace SeungyongShim.Model
{
    using System.Collections.Generic;

    internal class NearNode<T>
    {
        public List<NearNode<T>> Nears { get; } = new List<NearNode<T>>();
    }
}
