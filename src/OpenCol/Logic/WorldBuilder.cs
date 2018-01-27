namespace OpenCol.Logic {

    using OpenCol.Logic.TerrainGeneration;
    
    public class WorldBuilder : IWorldBuilder {

        public IWorld Build(IWorldDefinition definition) {
            var heightGenerator = new HeightMapGenerator();
            var heightMesh = heightGenerator.Generate(definition.Size.Width, definition.Size.Height);

            var temperatureGenerator = new TemperatureMapGenerator();
            var temperatureMesh = temperatureGenerator.Generate(definition.Size.Width, definition.Size.Height);

            var moistureGenerator = new MoistureMapGenerator();
            var moistureMesh = moistureGenerator.Generate(definition.Size.Width, definition.Size.Height);

            var map = new WorldMap(definition.Size.Width, definition.Size.Height);
            for(var x = 0; x < definition.Size.Width; x++) {
                for(var y = 0; y < definition.Size.Height; y++) {
                    map.SetValue(x, y, 
                        heightMesh.GetValue(x, y).Value, 
                        moistureMesh.GetValue(x, y).Value, 
                        temperatureMesh.GetValue(x, y).Value);
                }
            }

            return new World(map);
        }
    }
}