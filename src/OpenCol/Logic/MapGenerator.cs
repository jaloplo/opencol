namespace OpenCol.Logic {
    
    using SharpNoise;
    using SharpNoise.Builders;
    using SharpNoise.Modules;

    public abstract class MapGenerator : IMap2DGenerator {

        public Module Module { get; set; }

        public MapGenerator() {
            Module = new Constant();
        }

        public virtual IMap2D Generate(int width, int height) {
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

        protected abstract IMap2D TransformMap(NoiseMap map);
    }
}