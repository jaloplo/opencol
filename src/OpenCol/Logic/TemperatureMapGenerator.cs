namespace OpenCol.Logic {

    using SharpNoise;
    using SharpNoise.Modules;
    using System;
    
    public class TemperatureMapGenerator : MapGenerator<DataMap> {

        public TemperatureMapGenerator() {
            var noise = new Perlin();
            noise.Frequency = .75f;
            noise.OctaveCount = 4;

            var clamper = new Clamp();
            clamper.LowerBound = 0;
            clamper.UpperBound = 1;
            clamper.Source0 = noise;

            Module = clamper;
        }

        protected override IMap2D<DataMap> TransformMap(NoiseMap noiseMap) {
            var map = new Map(noiseMap);

            var coldestPercentage = Math.Floor(noiseMap.Height * 0.03);
            var colderPercentage = Math.Floor(noiseMap.Height * 0.09);
            var coldPercentage = Math.Floor(noiseMap.Height * 0.16);
            var warmPercentage = Math.Floor(noiseMap.Height * 0.28);
            var warmerPercentage = Math.Floor(noiseMap.Height * 0.40);

            for(var x = 0; x < noiseMap.Width; x++) {
                for(var y = 0; y < noiseMap.Height; y++) {
                    var h = y;
                    if(y > noiseMap.Height/2)
                        h = y - (2 * (y - noiseMap.Height/2));
                    
                    var value = map.GetValue(x, y).Value;

                    if(h < coldestPercentage)
                        value = ((0.1f - value)/3) + value;
                    else if(h < colderPercentage)
                        value = ((0.2f - value)/3) + value;
                    else if(h < coldPercentage)
                        value = ((0.4f - value)/3) + value;
                    else if(h < warmPercentage)
                        value = ((0.6f - value)/3) + value;
                    else if(h < warmerPercentage)
                        value = ((0.7f - value)/3) + value;
                    else
                        value = ((0.9f - value)/3) + value;

                    map.SetValue(x, y, value);
                }
            }
            return map;
        }
    }
}