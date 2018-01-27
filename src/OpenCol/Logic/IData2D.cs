namespace OpenCol.Logic {
    public interface IData2D<T> {
        
        Coordinates2D Coordinates { get; }

        T Value { get; }
    }
}