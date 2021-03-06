namespace OpenCol.Logic.TerrainGeneration {

    public interface IMap2DGenerator<T>
        where T : IDataMap2D {

        IMap2D<T> Generate(int width, int height);
    }
}