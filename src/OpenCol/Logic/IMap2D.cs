namespace OpenCol.Logic {

    using System.Collections.Generic;

    public interface IMap2D<T>
        where T : IDataMap2D {
        T GetValue(int x, int y);
    }
}