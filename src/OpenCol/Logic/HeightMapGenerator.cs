namespace OpenCol.Logic {

    using SharpNoise;
    using SharpNoise.Builders;
    using SharpNoise.Modules;
    using System;
    
    public class HeightMapGenerator : IMap2DGenerator {

        protected int Seed { get; private set; }

        public HeightMapGenerator() {
            Seed = new Random().Next(0, Int32.MaxValue);
        }

        public virtual IMap2D Generate(int width, int height) {
            var noise = new Perlin();
            noise.Seed = Seed;
            noise.Frequency = 1.5f;
            noise.OctaveCount = 6;
            noise.Persistence = 0.4f;

            var turbulence = new Turbulence();
            turbulence.Power = 0.25;
            turbulence.Frequency = 4;
            turbulence.Source0 = noise;

            var map = new NoiseMap(width, height);

            var builder = new PlaneNoiseMapBuilder();
            builder.EnableSeamless = true;
            builder.DestNoiseMap = map;
            builder.SetBounds(-5, 5, -5, 5);
            builder.SetDestSize(width, height);
            builder.SourceModule = noise;
            builder.Build();

            var heightMap = new HeightMap(map);
            
            return new ReadOnlyHeightMap(heightMap);
        }
    }
}