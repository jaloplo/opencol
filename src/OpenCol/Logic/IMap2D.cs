namespace OpenCol.Logic {

    using System.Collections.Generic;

    public interface IMap2D<T> {
        T GetValue(int x, int y);
    }
}