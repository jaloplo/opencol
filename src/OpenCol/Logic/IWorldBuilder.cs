namespace OpenCol.Logic {
    
    public interface IWorldBuilder {

        IWorld Build(IWorldDefinition definition);
    }
}