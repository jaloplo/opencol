namespace OpenCol.Logic {
    
    public class ReadOnlyHeightMap : IMap2D<HeightDataMap> {

        protected IMap2D<HeightDataMap> Parent { get; private set; }


        public ReadOnlyHeightMap(IMap2D<HeightDataMap> parent) {
            Parent = parent;
        }


        public virtual HeightDataMap GetValue(int x, int y) {
            return Parent.GetValue(x, y);
        }
    }
}