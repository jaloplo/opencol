namespace OpenCol.Logic.TerrainGeneration {
    
    using SharpNoise;
    using SharpNoise.Builders;
    using SharpNoise.Modules;

    public abstract class MapGenerator<T> : IMap2DGenerator<T> 
        where T : IDataMap2D {

        public Module Module { get; set; }

        public MapGenerator() {
            Module = new Constant();
        }

        public virtual IMap2D<T> Generate(int width, int height) {
            var map = new NoiseMap(width, height);

            var builder = new PlaneNoiseMapBuilder();
            builder.EnableSeamless = true;
            builder.DestNoiseMap = map;
            builder.SetBounds(-5, 5, -5, 5);
            builder.SetDestSize(width, height);
            builder.SourceModule = Module;
            builder.Build();

            return TransformMap(map);
        }

        protected abstract IMap2D<T> TransformMap(NoiseMap map);
    }
}