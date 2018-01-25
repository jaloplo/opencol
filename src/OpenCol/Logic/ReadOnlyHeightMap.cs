namespace OpenCol.Logic {
    
    public class ReadOnlyHeightMap : IMap2D {

        protected IMap2D Parent { get; private set; }


        public ReadOnlyHeightMap(IMap2D parent) {
            Parent = parent;
        }


        public virtual IDataMap2D GetValue(int x, int y) {
            return Parent.GetValue(x, y);
        }
    }
}