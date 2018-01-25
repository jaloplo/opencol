namespace OpenCol.Logic {

    using System.Collections.Generic;

    public interface IMap2D {
        IDataMap2D GetValue(int x, int y);
    }
}