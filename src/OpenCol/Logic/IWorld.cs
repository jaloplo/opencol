namespace OpenCol.Logic {
    
    public interface IWorld {
        Size2D Size { get; }

        WorldDataValue Get(int x, int y);
    }
}