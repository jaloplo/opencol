namespace OpenCol.Logic {

    using SharpNoise;
    using SharpNoise.Modules;
    using System;
    
    public class MoistureMapGenerator : MapGenerator<DataMap> {

        public MoistureMapGenerator() {
            var noise = new Billow();
            noise.Seed = new Random().Next();
            noise.Frequency = 0.6f;
            noise.OctaveCount = 8;
            noise.Persistence = 0.1;

            var turbulence = new Turbulence();
            turbulence.Power = 0.25;
            turbulence.Roughness = 3;
            turbulence.Frequency = 0.15;
            turbulence.Source0 = noise;

            var clamper = new Clamp();
            clamper.LowerBound = 0;
            clamper.UpperBound = 1;
            clamper.Source0 = turbulence;

            Module = clamper;
        }

        protected override IMap2D<DataMap> TransformMap(NoiseMap noiseMap) {
            var map = new Map(noiseMap);
            return map;
        }
    }
}