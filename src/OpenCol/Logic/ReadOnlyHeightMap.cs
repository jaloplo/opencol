namespace OpenCol.Logic {
    
    public class ReadOnlyHeightMap : IMap2D<DataMap> {

        protected IMap2D<DataMap> Parent { get; private set; }


        public ReadOnlyHeightMap(IMap2D<DataMap> parent) {
            Parent = parent;
        }


        public virtual DataMap GetValue(int x, int y) {
            return Parent.GetValue(x, y);
        }
    }
}