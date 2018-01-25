namespace OpenCol.Logic {

    using SharpNoise;
    using SharpNoise.Modules;
    using System;
    
    public class HeightMapGenerator : MapGenerator<HeightDataMap> {

        public HeightMapGenerator() {
            var noise = new Perlin();
            noise.Seed = new Random().Next(0, Int32.MaxValue);
            noise.Frequency = 1.5f;
            noise.OctaveCount = 6;
            noise.Persistence = 0.4f;

            var turbulence = new Turbulence();
            turbulence.Power = 0.25;
            turbulence.Frequency = 4;
            turbulence.Source0 = noise;

            var clamper = new Clamp();
            clamper.LowerBound = 0;
            clamper.UpperBound = 1;
            clamper.Source0 = turbulence;

            Module = clamper;
        }

        protected override IMap2D<HeightDataMap> TransformMap(NoiseMap map) {
            var heightMap = new HeightMap(map);            
            return new ReadOnlyHeightMap(heightMap);
        }
    }
}