# Terrain types definition

Relationship between different aspects of the tiles to create the proper terrain.
The current relationship is made mixing three values from height, temperature and moisture. Depending on their values we have different kind of terrain type.

## Temperature types
Coldest -> For ice, glaciers and higher mountains
Colder  -> For tundra, boreal forest, taiga and cold desert
Cold    -> For tundra, boreal forest, grassland and forest
Warm    -> For grassland, desert, woodland, forest and rainforest
Warmer  -> For desert, woodland, forest, rainforest, jungle
Warmest -> For desert, savannah, tropical forest, jungle

## Moisture types
Dryest  -> For desert, cold desert, tundra
Dryer   -> For desert, tundra, woodland, boreal forest
Dry     -> For tundra, boreal forest, forest, woodland, savannah
Wet     -> For boreal forest, forest, tropical forest, savannah
Wetter  -> For rainforest, tropical forest, jungle
Wettest -> For rainforest, jungle

## Terrain type definition


## Table

          | Coldest | Colder | Cold     | Warm     | Warmer   | Warmest  |
--------------------------------------------------------------------------
| Dryest  | Tundra  | Tundra | Desert   | Desert   | Desert   | Desert   |
--------------------------------------------------------------------------
| Dryer   | Tundra  | Tundra | Woodland | Woodland | Savannah | Savannah |
--------------------------------------------------------------------------
| Dry     | Tundra  | Tundra | Boreal F | Forest   | Forest   | Savannah |
--------------------------------------------------------------------------
| Wet     | Tundra  | Tundra | Boreal F | Forest   | Forest   | Jungle   |
--------------------------------------------------------------------------
| Wetter  | Tundra  | Tundra | Forest   | Forest   | Jungle   | Jungle   |
--------------------------------------------------------------------------
| Wettest | Tundra  | Tundra | Forest   | Forest   | Jungle   | Jungle   |
--------------------------------------------------------------------------